using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ICSM;
using OrmCs;
using DatalayerCs;
using System.Drawing;
using System.Threading;
using FormsCs;
using NetPlugins2;

namespace XICSM.MiscTools
{
    public partial class SearchInterf : IcsMetroForm
    {
        private bool stop = false;
        private string title="";

        private string wantedStationsOQL;
        private int bagWantedId;
        private int bagunwantedIdMobStation;
        private int bagunwantedIdMobStation2;
        private int bagunwantedIdMicrowa;
        private int bagunwantedIdSfaf;

        //declaration of thread for the computation
        Thread workerThread;

        //color settings for EXW & ICSTELECOM export
        private int ColorWanted = 1; private int ColorMicrowa = 9; private int ColorMs = 10; private int ColorMs2 = 8; private int ColorSfaf=6;

        //Bags Unwanted
        private IcsmBag BagUnWanted = new IcsmBag("ALL_TXRXFREQ");
        private IcsmBag BagWanted = new IcsmBag("ALL_TXRXFREQ");
        private IcsmBag BagUWantedMobSta = new IcsmBag("MOB_STATION");
        private IcsmBag BagUWantedMobSta2 = new IcsmBag("MOB_STATION2");
        private IcsmBag BagUWantedMwa = new IcsmBag("MICROWA");
        private IcsmBag BagUWantedSfaf = new IcsmBag("SFAF");
        //private IcsmBag BagWanted = null;
        //hashset
        private HashSet<int> WantedID = new HashSet<int>();
        private HashSet<int> UnWantedID = new HashSet<int>();
        private HashSet<int> UWantedMsID = new HashSet<int>();
        private HashSet<int> UWantedMs2ID = new HashSet<int>();
        private HashSet<int> UWantedMwaID = new HashSet<int>();
        private HashSet<int> UWantedSfafID = new HashSet<int>();

        IcsMetroTooltip t = new IcsMetroTooltip();

        /* invoke methods*/
        public delegate void ExecDelegate();
        private bool canBuildDataset = true;
        void SwitchBuildButton(bool activate = true) { canBuildDataset = activate; Invoke(new ExecDelegate(switchBuildButton)); }
        void switchBuildButton() { RunSearch.Enabled = canBuildDataset; }
        void switchBuildButton(bool activate = true) { canBuildDataset = activate; RunSearch.Enabled = activate; }

        private bool canExportEwx = false;
        void SwitchEwxButton(bool activate = false) { canExportEwx = activate; Invoke(new ExecDelegate(switchEwxButton)); }
        void switchEwxButton() { toEWX.Enabled = canExportEwx; }
        void switchEwxButton(bool activate = false) { canExportEwx = activate; toEWX.Enabled = activate; }

        private bool Spin = false; private int SpinH = 150; private int SpinW = 150;
        void setSpinner(bool Status) { Spin = Status; setSpinner(); }
        void setSpinner()
        {
            PendingSpinner.Visible = Spin; cancelThread.Visible = Spin;
            if (Spin)
            {
                PendingSpinner.StartSpinning(2, 60);
                int x = this.Size.Width / 2 - SpinW / 2; int y = this.Size.Height / 2 - SpinH / 2;
                PendingSpinner.Location = new System.Drawing.Point(x, y);
                PendingSpinner.Size = new System.Drawing.Size(SpinW, SpinH);
                int xC = PendingSpinner.Location.X; int yC = PendingSpinner.Location.Y + PendingSpinner.Size.Height + 2;
                cancelThread.Location = new System.Drawing.Point(xC, yC);
                cancelThread.Size = new System.Drawing.Size(SpinW, 23);
                cancelThread.Text = "Annuler";
            }
            else
            {
                PendingSpinner.StopSpinning();
            }
        }
        void SetSpinner(bool Status) { Spin = Status; Invoke(new ExecDelegate(setSpinner)); }

        private bool canImportOnMap = false;
        void setImportOnMapButton() { importOnMap.Enabled = canImportOnMap; }
        void setImportOnMapButton(bool activate) { canImportOnMap = activate; setImportOnMapButton(); }
        void SetImportOnMapButton(bool activate) { canImportOnMap = activate; Invoke(new ExecDelegate(setImportOnMapButton)); }

        string PositionName = "";
        void CallMissingDtmError(string PosName) { PositionName = PosName; Invoke(new ExecDelegate(callMissingDtmError)); }
        private void callMissingDtmError()
        {
            IcsMetroMessageBox.Show(this,
                                    L.Txt("Radio horizon has not been computed for {0}".Fmt(PositionName)),
                                    L.Txt("Missing DTM"),
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );
        }

        private string edition { get { return OrmSchema.Linker.ExecuteScalarString("SELECT EDITION FROM %SYS_VERSION"); } }
        private bool isWarfare = false;

        #region Initialization And Instanciation
        public SearchInterf()        { InitializeComponent(); }
        private void TextTranslation()
        {
            if (isWarfare)
            {
                label7.Text = L.Txt("SFAF");
                inSfaf.Text = L.Txt("SFAF (warfare ed. only)");
                tabUW_Sfaf.Text = L.Txt("Unwanted SFAF");
            }
            geoParam.Text = L.Txt("Frequency limits");
            t.SetToolTip(N2, "Rec. ITU-R SM.329-7");
            N2.Text = L.Txt("Spurious Domain\r\n(in accordance with ITU)");
            N1.Text = L.Txt("tight mode\r\nadjacent channel");
            N0.Text = L.Txt("very tight mode\r\ncochannel");
            freqParams.Text = L.Txt("Computing mode");
            radioDistance.Text = L.Txt("radio horizon limit");
            coverMode.Text = L.Txt("free space loss limit");
            importOnMap.Text = L.Txt("Export to HTZ map");
            tabConfig.Text = L.Txt("Configuration");
            StatusFilters.Text = L.Txt("Status Filtering options by tables");
            label6.Text = L.Txt("Microwaves stations");
            label5.Text = L.Txt("Yet other terrestrial stations");
            label3.Text = L.Txt("Process status");
            label2.Text = L.Txt("Familly Status");
            label4.Text = L.Txt("Other terrestrial stations");
            DefaultKtbfArea.Text = L.Txt("default ktbf");
            saveParam.Text = L.Txt("Save result bags");
            labelSave.Text = L.Txt("enter a save name");
            Tables.Text = L.Txt("Search in the following tables");
            inMicrowa.Text = L.Txt("Microwave links");
            inMobStation2.Text = L.Txt("Yet other terrestrial stations");
            inMobStation.Text = L.Txt("Other terrestrial stations");
            EouseFilter.Text = L.Txt("End of use between");
            and2.Text = L.Txt("and");
            BiuseFilter.Text = L.Txt("Bring in use between");
            and1.Text = L.Txt("and");
            toEWX.Text = L.Txt("Export result as EWX file");
            RunSearch.Text = L.Txt("Search");
            tabWanted.Text = L.Txt("wanted stations");
            tabUW_MobStation.Text = L.Txt("Other Terrestrials Unwanted Stations");
            tabUW_MobStation2.Text = L.Txt("Yet Other Terrestrials Unwanted Stations");
            tabUW_Microwa.Text = L.Txt("Unwanted Microwave Stations");
            Text = L.Txt("Search for potential inteferer");
            cancelThread.Text = L.Txt("Cancel");
        }
        public static bool builder(IMQueryMenuNode.Context ct)
        {
            SearchInterf Me = new SearchInterf();
            Me.isWarfare = (Me.edition == "WARFARE" || Me.edition == "WARFARE1");
            Me.getAllWantedStations(ct);
            Me.ShowDialog();
            return false;
        }

        public static bool builder(string OqlFilter, string Table)
        {
            SearchInterf Me = new SearchInterf();
            Me.isWarfare = (Me.edition == "WARFARE" || Me.edition == "WARFARE1" ? true : false);
            Me.getAllWantedStations(OqlFilter, Table);
            Me.ShowDialog();
            return false;
        }
        #endregion

        #region Events
        private void cancelThread_Click(object sender, EventArgs e)
        {
            stop = true;
            SwitchEwxButton(false); SetImportOnMapButton(false);
            PendingSpinner.StopSpinning();
            PendingSpinner.StartSpinning(2, 60, true);
            cancelThread.Text = L.Txt("Annulation...");
        }

        private void DbListWanted_OnRequery(object sender, EventArgs e)
        {
            DbListWanted.MustBePresent("ID");
            DbListWanted.SetFilter(wantedStationsOQL);
        }

        private void DatasetBuilder_Load(object sender, EventArgs e)
        {

            DbListMobStation.Init();
            DbListMobStation2.Init();
            DbListMwa.Init();
            DbListWanted.Init();

            if (isWarfare)
            {
                DbListSfaf.Init();
            }
            else
            {
                panelSfaf.Visible = false;
                inSfaf.Visible = false; inSfaf.Checked = false;
                tabControl1.TabPages.Remove(tabUW_Sfaf);
            }

            int SizeOfStatusFamAlone = 405;

            int Ms = IM.GetActiveProcessControl("MOB_STATION");
            if (Ms == Null.I)
            {
                LikeMsStatus.Visible = false; MobStation_Status.Visible = false;
                panelMobStation.Size = new Size(SizeOfStatusFamAlone - 10, panelMobStation.Size.Height);
            }
            int Ms2 = IM.GetActiveProcessControl("MOB_STATION2");
            if (Ms2 == Null.I)
            {
                LikeMs2Status.Visible = false; MobStation2_Status.Visible = false;
                panelMobStation2.Size = new Size(SizeOfStatusFamAlone - 10, panelMobStation2.Size.Height); 
            }
            int Mw = IM.GetActiveProcessControl("MICROWA");
            if (Mw == Null.I)
            {
                LikeMwStatus.Visible = false; Microwa_Status.Visible = false;
                panelMicrowa.Size = new Size(SizeOfStatusFamAlone - 10, panelMicrowa.Size.Height);
            }

            if (Ms == Null.I && Ms2 == Null.I && Mw == Null.I)
            {
                label3.Visible = false;
                panelSfaf.Size = new Size(SizeOfStatusFamAlone - 10, panelMobStation2.Size.Height);
                StatusFilters.Size = new Size(SizeOfStatusFamAlone, StatusFilters.Size.Height);
            }

            TextTranslation();
        }

        private void DbListMobStation_OnDefColumns(object sender, EventArgs e)
        {
            DbListMobStation.AddColumn("MOB_STATION.ID", L.Txt("ID"), "Auto", 53);
            DbListMobStation.AddColumn("MOB_STATION.REC_ID", L.Txt("REC_ID"), "Auto", 53);
            DbListMobStation.AddColumn("MOB_STATION.NAME", L.Txt("NAME"), "Auto", 236);
            DbListMobStation.AddColumn("MOB_STATION.AssignedFrequencies.TX_FREQ", L.Txt("AssignedFrequencies.TX_FREQ"), "Auto", 106);
            DbListMobStation.AddColumn("MOB_STATION.AssignedFrequencies.RX_FREQ", L.Txt("AssignedFrequencies.RX_FREQ"), "Auto", 106);
            DbListMobStation.AddColumn("MOB_STATION.Position.NAME", L.Txt("Position.NAME"), "Auto", 201);
            DbListMobStation.AddColumn("MOB_STATION.Position.X", L.Txt("Position.X"), "Auto", 106);
            DbListMobStation.AddColumn("MOB_STATION.Position.Y", L.Txt("Position.Y"), "Auto", 106);
            DbListMobStation.AddColumn("MOB_STATION.Position.CSYS", L.Txt("Position.CSYS"), "Auto", 77);
            DbListMobStation.AddColumn("MOB_STATION.Position.ASL", L.Txt("Position.ASL"), "Auto", 106);
            DbListMobStation.AddColumn("MOB_STATION.Position.POINTS", L.Txt("Position.POINTS"), "Auto", 236);
            DbListMobStation.AddColumn("MOB_STATION.AGL", L.Txt("AGL"), "Auto", 106);
        }

        private void DbListMobStation_OnSelChanged(object sender, EventArgs e)
        {

        }

        private void buildDatasets_Click(object sender, EventArgs e)
        {
            if (BagUWantedMobSta.Bag != null || BagUWantedMobSta2.Bag != null || BagUWantedMwa.Bag != null || BagUWantedSfaf.Bag != null || BagWanted != null)
            {
                ClearBags(); // clear bags then reinit them
                BagUWantedMobSta = new IcsmBag("MOB_STATION");
                BagUWantedMobSta2 = new IcsmBag("MOB_STATION2");
                BagUWantedMwa = new IcsmBag("MICROWA");
                BagUWantedSfaf = new IcsmBag("SFAF");
            }

            if (inMicrowa.Checked || inMobStation.Checked || inMobStation2.Checked || inSfaf.Checked)
            {
                ANetDb db = null; string nameIndb = null;
                OrmSchema.Linker.GetTableMapping("LICENCE", ref db, ref nameIndb);
                string schemaPrefix = OrmSchema.Linker.GetSchemaPrefix("MOB_STATION");

                //saveName
                title = SaveBox.Checked ? SaveName.Text : "Search for potential interferer (" + IM.ConnectedUser() + ")";

                workerThread = new Thread(() => { this.DoWork(db, schemaPrefix); });
                workerThread.Start();
            }
            else
            {
                IcsMetroMessageBox.Show(this, L.Txt("No table is selected, search need to have at least one table to search in."), L.Txt("Can't process"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void importOnMap_Click(object sender, EventArgs e)
        {
            exportDataset(true);
        }

        private void toEWX_Click(object sender, EventArgs e)
        {
            exportDataset(false);
        }

        private void DbListMobStation_OnRequery(object sender, EventArgs e)
        {
            DbListMobStation.MustBePresent("ID");
            DbListMobStation.SetInBag(bagunwantedIdMobStation);
        }

        private void DbListMwa_OnRequery(object sender, EventArgs e)
        {
            DbListMwa.MustBePresent("ID");
            DbListMwa.SetInBag(bagunwantedIdMicrowa);
        }

        private void DbListSfaf_OnRequery(object sender, EventArgs e)
        {
            DbListSfaf.MustBePresent("ID");
            DbListSfaf.SetInBag(bagunwantedIdSfaf);
        }

        private void DbListMobStation2_OnRequery(object sender, EventArgs e)
        {
            DbListMobStation2.MustBePresent("ID");
            DbListMobStation2.SetInBag(bagunwantedIdMobStation2);
        }

        private void BiuseBox_CheckedChanged(object sender, EventArgs e)
        {
            BiuseStart.Visible = BiuseBox.Checked;
            BiuseEnd.Visible = BiuseBox.Checked;
            and1.Visible = BiuseBox.Checked;

            DisplayCopyDatesButtons();
        }

        private void EouseBox_CheckedChanged(object sender, EventArgs e)
        {
            EouseStart.Visible = EouseBox.Checked;
            EouseEnd.Visible = EouseBox.Checked;
            and2.Visible = EouseBox.Checked;

            DisplayCopyDatesButtons();
        }

        private void inMobStation_CheckedChanged(object sender, EventArgs e)
        {
            panelMobStation.Visible = inMobStation.Checked;
        }

        private void inMobStation2_CheckedChanged(object sender, EventArgs e)
        {
            panelMobStation2.Visible = inMobStation2.Checked;
        }

        private void inMicrowa_CheckedChanged(object sender, EventArgs e)
        {
            panelMicrowa.Visible = inMicrowa.Checked;
        }

        private void inSfaf_CheckedChanged(object sender, EventArgs e)
        {
            panelSfaf.Visible = inSfaf.Checked;
        }

        private void CopyEtoB_Click(object sender, EventArgs e)
        {
            BiuseStart.Value = EouseStart.Value;
            BiuseEnd.Value = EouseEnd.Value;
        }

        private void CopyBtoE_Click(object sender, EventArgs e)
        {
            EouseEnd.Value = BiuseEnd.Value;
            EouseStart.Value = BiuseStart.Value;
        }

        private void SaveBox_CheckedChanged(object sender, EventArgs e)
        {
            labelSave.Visible = SaveBox.Checked;
            SaveName.Visible = SaveBox.Checked;
        }

        private void SearchInterf_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!SaveBox.Checked)
            {
                ClearBags();
            }
            stop = true;
        }

        private void LikeMsState_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked) { box.Text = "Like"; } else { box.Text = "Not Like"; }
        }

        private void BiuseStart_ValueChanged(object sender, EventArgs e)
        {
            IcsDateTime dt = (IcsDateTime)sender;
            //if (!DateTime.Compatible(dt.Value)) { MessageBox.Show(L.Txt("Date can only be between 1753-01-01 and 9999-12-31.")); }
            if (dt.Value <= DateTime.MaxValue && dt.Value >= DateTime.MinValue && dt.Value != null) { MessageBox.Show(L.Txt("Date can only be between 1753-01-01 and 9999-12-31.")); }
        }

        private void N2_Click(object sender, EventArgs e)
        {
            t.Show(L.Txt("Rec. ITU SM.329-7"), this, 3000);
        }

        private void N2_MouseHover(object sender, EventArgs e)
        {
            t.Show(L.Txt("Rec. ITU SM.329-7"), this, 3000);
        }


        #endregion

        #region Envent Related
        private int Bandwitdh()
        {
            if (N2.Checked) { return 5; }
            else if (N1.Checked) { return 3; }
            else if (N0.Checked) { return 1; }
            else { MessageBox.Show(L.Txt("No frequency limit defined. Standard mode will be set.")); return 5; }
        }
        #endregion

        #region Computation
        private void DoWork(ANetDb db, string schemaPrefix)
        {
            stop = false;
            while (!stop)
            {
                SwitchBuildButton(false);
                SetSpinner(true);
                SetImportOnMapButton(false);
                SwitchEwxButton(false);

                //db connexion for specific thread
                using (DbLinker dbl = new DbLinker(db.Duplicate(), schemaPrefix))//DbLinker dispose will close database
                {
                    // Ln : coef largeur de bande a étudier
                    int Ln = Bandwitdh();

                    YMobStationT unwantedMobStations = new YMobStationT();
                    unwantedMobStations.Table = "MOB_STATION";
                    unwantedMobStations.Format("ID,AssignedFrequencies(TX_FREQ,RX_FREQ),BW,Position(X,Y,ASL,POINTS),AGL,PLAN_ID,Plan(LOWER_FREQ,UPPER_FREQ),BIUSE_DATE,EOUSE_DATE");

                    YMobStationT unwantedMobStations2 = new YMobStationT();
                    unwantedMobStations2.Table = "MOB_STATION2";
                    unwantedMobStations2.Format("ID,AssignedFrequencies(TX_FREQ,RX_FREQ),BW,Position(X,Y,ASL,POINTS),AGL,PLAN_ID,Plan(LOWER_FREQ,UPPER_FREQ),BIUSE_DATE,EOUSE_DATE");

                    YMicrows unwantedMicrows = new YMicrows();
                    unwantedMicrows.Format("ID,TX_FREQ,LinkedTo(TX_FREQ),Microwave(BW,PLAN_ID,Plan(LOWER_FREQ,UPPER_FREQ),BIUSE_DATE,EOUSE_DATE),Position(X,Y,ASL,POINTS),AGL1,MW_ID");

                    YSfaf unwantedSfaf;
                    if (isWarfare) { unwantedSfaf = new YSfaf(); unwantedSfaf.Format("ID,FREQ,BW,Transmitter(X,Y),SFAF_102,BIUSE_DATE,EOUSE_DATE"); }

                    //Build filters on 
                    List<string> ListWhereFreqOT = new List<string>(); List<string> ListWhereFreqMW = new List<string>();
                    List<string> LsitWhereFreqSfaf = new List<string>(); List<string> ListWherePosSfaf = new List<string>();
                    List<string> ListWherePosFix = new List<string>(); List<string> ListWherePosOT = new List<string>();
                    List<int> ListWherePosMob = new List<int>(); List<int> ListWherePosMob2 = new List<int>();
                    List<string> ListWhereFreqOT0 = new List<string>(); List<string> ListWhereFreqMW0 = new List<string>();

                    #region MOB_STATION and MOB_STATION2
                    if (DbListWanted.Table == "MOB_STATION" || DbListWanted.Table == "MOB_STATION2")
                    {
                        //Bag wanted
                        IcsmBag BagWanted = new IcsmBag(DbListWanted.Table);

                        //on cherche les stations unwanted en bouclant sur les wanted
                        YMobStationT YTable = new YMobStationT();
                        YTable.Table = DbListWanted.Table;
                        YTable.Format("ID,AssignedFrequencies(TX_FREQ,RX_FREQ),BW,Position(NAME,X,Y,CSYS,ASL,POINTS),AGL,PLAN_ID,Plan(LOWER_FREQ,UPPER_FREQ),RADIUS,POWER,Equipment(RXTH_3,SENSITIVITY,LOWER_FREQ,UPPER_FREQ,RX_UPPER_FREQ,RX_LOWER_FREQ,MAX_POWER,POWER)");
                        YTable.Filter = DbListWanted.Filter;
                        List<int> ListID = new List<int>();
                        List<int> ListIdFreq0 = new List<int>();

                        //building where conditions for queries foreach wanted stations
                        for (YTable.OpenRs(); !YTable.IsEOF(); YTable.MoveNext())
                        {
                            double bw = YTable.m_bw; string PosName = YTable.m_Position.m_name;
                            double PositionX = YTable.m_Position.m_x; double PositionY = YTable.m_Position.m_y;
                            double PositionASL = YTable.m_Position.m_asl; double PositionAGL = YTable.m_agl;
                            double[] Elevations = new double[72]; double[] Distances = new double[72];
                            double freqTx = YTable.m_AssignedFrequencies.m_tx_freq;
                            double freqRx = YTable.m_AssignedFrequencies.m_rx_freq;
                            List<double> polygoneX = new List<double>(); List<double> polygoneY = new List<double>();
                            double PlanMin = YTable.m_Plan.m_lower_freq; double PlanMax = YTable.m_Plan.m_upper_freq;
                            PolygoneEtude PolyEtd = new PolygoneEtude();

                            //add ID to Wanted HashSet
                            WantedID.Add(YTable.m_id);

                            if (radioDistance.Checked ^ coverMode.Checked)
                            {
                                if (!coverMode.Checked && radioDistance.Checked) //building where conditions for radioDistance (4/3*optical distance) cirteria
                                {
                                    if (YTable.m_Position.m_points == "" && YTable.m_radius <= Null.D) //For fixe position
                                    {
                                        //compute perimeter for Radio Horizon
                                        IMPosition pos = new IMPosition();
                                        pos.CSys = "4DEC"; pos.Lon = PositionX; pos.Lat = PositionY;
                                        bool computed = IM.ComputeHorizon(pos, (PositionAGL + PositionASL), 5, ref Elevations, ref Distances);
                                        if (!computed) {
                                            CallMissingDtmError(PosName);
                                            stop = true; break;
                                        }
                                        double longNode = Null.D, latNode = Null.D;
                                        for (int i = 71; i >= 0; i--)
                                        {
                                            IM.GeoJump(ref longNode, ref latNode, pos.Lon, pos.Lat, Distances[i] * 4 / 3, i * 5);
                                            polygoneX.Add(longNode); polygoneY.Add(latNode);
                                        }
                                        //query conditions for fix position to be in Radio horizon rectangle
                                        string Xmin = polygoneX.Min().ToString().Replace(",", "."); string Xmax = polygoneX.Max().ToString().Replace(",", ".");
                                        string Ymin = polygoneY.Min().ToString().Replace(",", "."); string Ymax = polygoneY.Max().ToString().Replace(",", ".");

                                        if (inMicrowa.Checked)
                                        {
                                            ListWherePosFix.Add("(([Position.X] >= " + Xmin + " AND [Position.X] <= " + Xmax
                                            + ") AND ([Position.Y] >= " + Ymin + " AND [Position.Y] <= " + Ymax + "))");
                                        }

                                        if (inSfaf.Checked)
                                        {
                                            ListWherePosSfaf.Add("([Transmitter.X] >= " + Xmin + " AND [Transmitter.X] <= " + Xmax + ") AND ([Transmitter.Y] >= "
                                            + Ymin + " AND [Transmitter.Y] <= " + Ymax + ")");
                                        }

                                        //query conditions for mob position to be in Radio horizon rectangle
                                        if (inMobStation.Checked || inMobStation2.Checked)
                                        {
                                            string a = (360.0 / 40000.0).ToString().Replace(",", ".");
                                            ListWherePosOT.Add("([Position.X_MIN]-[RADIUS]* " + a + " < " + Xmax + " AND [Position.X_MAX]+[RADIUS]* " + a +
                                                    " > " + Xmin + " AND [Position.Y_MIN]-[RADIUS]* " + a + " < " + Ymax +
                                                    " AND [Position.Y_MAX]-[RADIUS]* " + a + " > " + Ymin + ")");
                                        }
                                    }
                                    else //For mobile positions (radius & points)
                                    {
                                        //compute  perimeter for Radio Horizon
                                        string points = "";
                                        if (YTable.m_Position.m_points != "") //this is a polygon so there is coordinates
                                        {
                                            points = YTable.m_Position.m_points;
                                        }
                                        else if (YTable.m_radius > Null.D) //this is a circle so compute coordinates into a polygon
                                        {
                                            double longNode = Null.D, latNode = Null.D;
                                            IMPosition pos = new IMPosition();
                                            for (int i = 35; i >= 0; i--)
                                            {
                                                IM.GeoJump(ref longNode, ref latNode, PositionX, PositionY, YTable.m_radius, i * 10);
                                                points += longNode + " " + latNode + "\r\n";
                                            }
                                        }

                                        //compute Radio Horizon rectangle
                                        PolyEtd.CalculeVisibiliteRadioPolygone(points, YTable.m_Position.m_csys, PositionASL + PositionAGL);
                                        string maxX = PolyEtd.Extent.maxX.ToString().Replace(",", ".");
                                        string minX = PolyEtd.Extent.minX.ToString().Replace(",", ".");
                                        string maxY = PolyEtd.Extent.maxY.ToString().Replace(",", ".");
                                        string minY = PolyEtd.Extent.minY.ToString().Replace(",", ".");

                                        if (inMobStation.Checked)
                                        {
                                            YMobStationT m = new YMobStationT();
                                            m.Table = "MOB_STATION";
                                            m.Format("ID,AssignedFrequencies(TX_FREQ,RX_FREQ),BW,Position(ID,X,Y,CSYS,ASL,POINTS,X_MIN,X_MAX,Y_MIN,Y_MAX,LONGITUDE,LATITUDE),AGL,PLAN_ID,Plan(LOWER_FREQ,UPPER_FREQ),RADIUS");
                                            m.Filter = "[Position.X_MIN]<{0} AND [Position.X_MAX]>{1} AND [Position.Y_MIN]<{2} AND [Position.Y_MAX]>{3} ".Fmt(maxX, minX, maxY, minY);
                                            for (m.OpenRs(); !m.IsEOF(); m.MoveNext())
                                            {
                                                //Add station ID if a Polygone intersects the Radio Horizon perimeter
                                                try
                                                {
                                                    if (PolyEtd.Intersects(m.m_Position, 0)) { ListWherePosMob.Add(m.m_id); }
                                                }
                                                catch
                                                { }
                                            }
                                        }

                                        if (inMobStation2.Checked)
                                        {
                                            YMobStationT m2 = new YMobStationT();
                                            m2.Table = "MOB_STATION2";
                                            m2.Format("ID,AssignedFrequencies(TX_FREQ,RX_FREQ),BW,Position(ID,X,Y,CSYS,ASL,POINTS,X_MIN,X_MAX,Y_MIN,Y_MAX,LONGITUDE,LATITUDE),AGL,PLAN_ID,Plan(LOWER_FREQ,UPPER_FREQ),RADIUS");
                                            m2.Filter = "[Position.X_MIN]<{0} AND [Position.X_MAX]>{1} AND [Position.Y_MIN]<{2} AND [Position.Y_MAX]>{3} ".Fmt(maxX, minX, maxY, minY);
                                            for (m2.OpenRs(); !m2.IsEOF(); m2.MoveNext())
                                            {
                                                //Add station ID if a Polygone intersects the Radio Horizon perimeter
                                                try
                                                {
                                                    if (PolyEtd.Intersects(m2.m_Position, 0)) { ListWherePosMob2.Add(m2.m_id); }
                                                }
                                                catch
                                                { }
                                            }
                                        }


                                        //query conditions for fix position to be in Radio Horizon rectangle
                                        ListWherePosFix.Add("(([Position.X] >= " + minX + " AND [Position.X] <= " + maxX
                                            + ") AND ([Position.Y] >= " + minY + " AND [Position.Y] <= " + maxY + "))");
                                        ListWherePosSfaf.Add("(([Transmitter.X] >= " + minX + " AND [Transmitter.X] <= " + maxX + ") AND ([Transmitter.Y] >= " + minY + " AND [Transmitter.Y] <= " + maxY + "))");
                                    }
                                }
                                else
                                {
                                    //building where conditions for coverage mode
                                    List<AzimAtten> pattern = AzimAtten.LoadPattern(YTable.Table, YTable.m_id);
                                    double F = 0.0;
                                    if ((YTable.m_AssignedFrequencies.m_tx_freq == 0 || YTable.m_AssignedFrequencies.m_tx_freq == Null.D)
                                     && (YTable.m_AssignedFrequencies.m_rx_freq == 0 || YTable.m_AssignedFrequencies.m_rx_freq == Null.D))
                                    {
                                        F = YTable.m_Equipment.m_upper_freq - (YTable.m_Equipment.m_upper_freq - YTable.m_Equipment.m_lower_freq) / 2;
                                        if (F <= Null.D)
                                        {
                                            F = YTable.m_Equipment.m_rx_upper_freq - (YTable.m_Equipment.m_rx_upper_freq - YTable.m_Equipment.m_rx_lower_freq) / 2;
                                        }
                                    }
                                    else
                                    {
                                        if (YTable.m_AssignedFrequencies.m_tx_freq > Null.D) { F = YTable.m_AssignedFrequencies.m_tx_freq; }
                                        else if (YTable.m_AssignedFrequencies.m_rx_freq > Null.D) { F = YTable.m_AssignedFrequencies.m_rx_freq; }
                                        else { F = YTable.m_Equipment.m_rx_upper_freq - (YTable.m_Equipment.m_rx_upper_freq - YTable.m_Equipment.m_rx_lower_freq) / 2; }
                                    }
                                    double Puissance = YTable.m_power > Null.D ? YTable.m_power : YTable.m_Equipment.m_max_power;
                                    Puissance = Puissance < Null.D ? Puissance : YTable.m_Equipment.m_power;
                                    double Seuil = YTable.m_Equipment.m_sensitivity < Null.D ? YTable.m_Equipment.m_sensitivity : YTable.m_Equipment.m_rxth_3;
                                    if (Seuil == Null.D) { Seuil = DefaultKtbf.Value; }
                                    double range = (299.792 / F) / (4 * Math.PI) * Math.Pow(10, (Puissance - 30 - Seuil) / 20) / 1000;//en Km

                                    if (YTable.m_Position.m_points != "" || YTable.m_radius != Null.D) //mob position
                                    {
                                        if (YTable.m_radius != Null.D && YTable.m_Position.m_points == "")
                                        {
                                            PolyEtd.CalculeCouvertureCercle(PositionX, PositionY, YTable.m_Position.m_csys, YTable.m_radius, pattern, range);
                                        }
                                        else if (YTable.m_Position.m_points != "" || YTable.m_radius == Null.D)
                                        {
                                            PolyEtd.CalculeCouverturePolygone(YTable.m_Position.m_points, YTable.m_Position.m_csys, pattern, range);
                                        }
                                        else { }

                                    }
                                    else if (YTable.m_Position.m_points == "" && YTable.m_radius == Null.D) //fix position
                                    {
                                        PolyEtd.CalculeCouverturePoint(PositionX, PositionY, YTable.m_Position.m_csys, pattern, range);
                                    }
                                    else { }
                                    //compute Radio Horizon rectangle
                                    string maxX = PolyEtd.Extent.maxX.ToString().Replace(",", ".");
                                    string minX = PolyEtd.Extent.minX.ToString().Replace(",", ".");
                                    string maxY = PolyEtd.Extent.maxY.ToString().Replace(",", ".");
                                    string minY = PolyEtd.Extent.minY.ToString().Replace(",", ".");

                                    if (inSfaf.Checked && isWarfare)
                                    {
                                        ListWherePosSfaf.Add("([Transmitter.X] >= " + minX + " AND [Transmitter.X] <= " + maxX + ") AND ([Transmitter.Y] >= " + minY + " AND [Transmitter.Y] <= " + maxY + ")");
                                    }


                                    if (inMobStation.Checked)
                                    {
                                        YMobStationT m = new YMobStationT();
                                        m.Table = "MOB_STATION";
                                        m.Format("ID,AssignedFrequencies(TX_FREQ,RX_FREQ),BW,Position(ID,X,Y,CSYS,ASL,POINTS,X_MIN,X_MAX,Y_MIN,Y_MAX,LONGITUDE,LATITUDE),AGL,PLAN_ID,Plan(LOWER_FREQ,UPPER_FREQ),RADIUS");
                                        m.Filter = "[Position.X_MIN]<{0} AND [Position.X_MAX]>{1} AND [Position.Y_MIN]<{2} AND [Position.Y_MAX]>{3} ".Fmt(maxX, minX, maxY, minY);
                                        for (m.OpenRs(); !m.IsEOF(); m.MoveNext())
                                        {
                                            //Add station ID if a Polygone intersects the Radio Horizon perimeter
                                            try
                                            {
                                                if (PolyEtd.Intersects(m.m_Position, 0)) { ListWherePosMob.Add(m.m_id); }
                                            }
                                            catch
                                            { }
                                        }
                                    }

                                    if (inMobStation2.Checked)
                                    {
                                        YMobStationT m2 = new YMobStationT();
                                        m2.Table = "MOB_STATION2";
                                        m2.Format("ID,AssignedFrequencies(TX_FREQ,RX_FREQ),BW,Position(ID,X,Y,CSYS,ASL,POINTS,X_MIN,X_MAX,Y_MIN,Y_MAX,LONGITUDE,LATITUDE),AGL,PLAN_ID,Plan(LOWER_FREQ,UPPER_FREQ),RADIUS");
                                        m2.Filter = "[Position.X_MIN]<{0} AND [Position.X_MAX]>{1} AND [Position.Y_MIN]<{2} AND [Position.Y_MAX]>{3} ".Fmt(maxX, minX, maxY, minY);
                                        for (m2.OpenRs(); !m2.IsEOF(); m2.MoveNext())
                                        {
                                            //Add station ID if a Polygone intersects the Radio Horizon perimeter
                                            try
                                            {
                                                if (PolyEtd.Intersects(m2.m_Position, 0)) { ListWherePosMob2.Add(m2.m_id); }
                                            }
                                            catch
                                            { }
                                        }
                                    }

                                }
                            }
                            else
                            {
                                IcsMetroMessageBox.Show(L.Txt("No frequency limit defined. Standard mode will be set"));
                            }

                            //excluding Wanted station ID to unwanted station list
                            ListID.Add(YTable.m_id);

                            //building freqeuncy criteria for MobStation & Microwave tables
                            if (freqTx != Null.D || freqRx != Null.D) // depending if there is or not a freq in the station
                            {
                                if (inMobStation.Checked || inMobStation2.Checked)
                                {
                                    ListWhereFreqOT.Add("([AssignedFrequencies.TX_FREQ] + ([BW] /2000) >= " + (freqTx - (bw * Ln / 2000)) +
                                                    " AND [AssignedFrequencies.TX_FREQ] - ([BW] /2000) <= " + (freqTx + (bw * Ln / 2000)) + ")");
                                }

                                if (inMicrowa.Checked)
                                {
                                    ListWhereFreqMW.Add("([TX_FREQ]  + ([Microwave.BW] /2000) >= " + (freqTx - (bw * Ln / 2000)) +
                                                    " AND [TX_FREQ] - ([Microwave.BW] /2000) <= " + (freqTx + (bw * Ln / 2000)) + ")");
                                }

                                if (inSfaf.Checked && isWarfare)
                                {
                                    LsitWhereFreqSfaf.Add("([FREQ]  + ([BW] /2000) >= " + (freqTx - (bw * Ln / 2000)) +
                                                    " AND [FREQ] - ([BW] /2000) <= " + (freqTx + (bw * Ln / 2000)) + ")");
                                }
                            }
                            else
                            {
                                if (inMobStation.Checked || inMobStation2.Checked)
                                {
                                    ListWhereFreqOT0.Add("([AssignedFrequencies.TX_FREQ] + ([BW] /2000) >= " + (PlanMin) +
                                                " AND [AssignedFrequencies.TX_FREQ] - ([BW] /2000) <= " + (PlanMax) + ")");
                                }

                                if (inMicrowa.Checked)
                                {
                                    ListWhereFreqMW0.Add("([TX_FREQ]  + ([Microwave.BW] /2000) >= " + (PlanMin) +
                                                " AND [TX_FREQ] - ([Microwave.BW] /2000) <= " + (PlanMax) + ")");
                                }

                            }
                        }
                        YTable.Close();

                        if (!stop)
                        {
                            //combining each kind of criteria into 1 string
                            string OQL_id = ListID.CommaSep();
                            string OQL_OT_freq = ListWhereFreqOT.Count != 0 ? ListWhereFreqOT.OrSep().Replace(",", ".") : "";
                            string OQL_Positions = ListWherePosFix.Count != 0 ? ListWherePosFix.OrSep().Replace(",", ".") : "";
                            string OQL_PositionsMob = ListWherePosMob.Count != 0 ? "[ID] IN (" + ListWherePosMob.CommaSep() + ")" : "";
                            OQL_PositionsMob += ListWherePosOT.Count != 0 ? (OQL_PositionsMob != "" ? "OR" : "") + "(" + ListWherePosOT.OrSep() + ")" : "";
                            string OQL_PositionsMob2 = ListWherePosMob2.Count != 0 ? "[ID] IN (" + ListWherePosMob2.CommaSep() + ")" : "";
                            OQL_PositionsMob2 += ListWherePosOT.Count != 0 ? (OQL_PositionsMob2 != "" ? "OR" : "") + "(" + ListWherePosOT.OrSep() + ")" : "";
                            string OQL_PositionsSfaf = ListWherePosSfaf.Count != 0 ? ListWherePosSfaf.OrSep().Replace(",", ".") : "";
                            string OQL_Freq0_OT = ListWhereFreqOT0.Count != 0 ? ListWhereFreqOT0.OrSep().Replace(",", ".") : "";
                            string IDlist = "[ID] NOT IN ({0}) ".Fmt(OQL_id);

                            int countAdded = 0;
                            BagWanted.Create(title, "Wanted Mob_Station");
                            foreach (int ida in WantedID) { BagWanted.Add(ida, ref countAdded, false, ColorWanted); } //wanted color = blue

                            if (inMobStation.Checked)
                            {
                                string uwMsPositions = (OQL_Positions == "" ? "" : "({0})".Fmt(OQL_Positions)) +
                                    (OQL_PositionsMob != "" && OQL_Positions != "" ? " OR " : "") +
                                    (OQL_PositionsMob == "" ? "" : "({0})".Fmt(OQL_PositionsMob));
                                //"(" + OQL_Positions + ((OQL_Positions != "" && OQL_PositionsMob != "") ? " OR " : " ") + OQL_PositionsMob + ")";

                                string Biuse = (BiuseBox.Checked ? "AND [BIUSE_DATE] >= " + BiuseStart.Value.ToShortDateString().ToSql() + " AND [BIUSE_DATE] <= " + BiuseEnd.Value.ToShortDateString().ToSql() : "");
                                string Eouse = (EouseBox.Checked ? "AND [EOUSE_DATE] >= " + EouseStart.Value.ToShortDateString().ToSql() + " AND [EOUSE_DATE] <= " + EouseEnd.Value.ToShortDateString().ToSql() : "");
                                string StaFam = (MobStation_State.Value != "" ? "AND [ST_FAMILY] " + (LikeMsState.Checked ? "LIKE" : "NOT LIKE") + " '" + MobStation_State.Value + "'" : "");
                                string Status = (MobStation_Status.Value != "" ? "AND [STATUS] " + (LikeMsStatus.Checked ? "LIKE" : "NOT LIKE") + " '" + MobStation_Status.Value + "'" : "");
                                string freqs = (OQL_OT_freq != "" ? OQL_OT_freq : "") + (OQL_OT_freq != "" && OQL_Freq0_OT != "" ? " OR " : "") + (OQL_Freq0_OT != "" ? OQL_Freq0_OT : "");
                                string MSquery = "({0})".Fmt(uwMsPositions) + Biuse + Eouse + StaFam + Status;
                                MSquery += (freqs != "" ? (MSquery != "" ? " AND (" : "") + freqs + ")" : "");
                                unwantedMobStations.Filter = (YTable.Table == "MOB_STATION" ? IDlist + (MSquery != "" ? " AND" : "") : "") + MSquery;
                                for (unwantedMobStations.OpenRs(); !unwantedMobStations.IsEOF(); unwantedMobStations.MoveNext()) { UWantedMsID.Add(unwantedMobStations.m_id); }
                                unwantedMobStations.Close();
                                BagUWantedMobSta.Create(title, "Unwanted Mob_Station");
                                foreach (int idb in UWantedMsID) { BagUWantedMobSta.Add(idb, ref countAdded, false, ColorMs); } //color = brown
                            }

                            if (inMobStation2.Checked)
                            {
                                string uwMsPositions2 = (OQL_Positions == "" ? "" : "({0})".Fmt(OQL_Positions)) +
                                    (OQL_PositionsMob != "" && OQL_Positions != "" ? " OR " : "") +
                                    (OQL_PositionsMob == "" ? "" : "({0})".Fmt(OQL_PositionsMob));
                                //string uwMsPositions2 = "(" + OQL_Positions + ((OQL_Positions != "" && OQL_PositionsMob2 != "") ? " OR " : " ") + OQL_PositionsMob2 + ")";
                                string Biuse = (BiuseBox.Checked ? "AND [BIUSE_DATE] >= " + BiuseStart.Value.ToShortDateString().ToSql() + " AND [BIUSE_DATE] <= " + BiuseEnd.Value.ToShortDateString().ToSql() : "");
                                string Eouse = (EouseBox.Checked ? "AND [EOUSE_DATE] >= " + EouseStart.Value.ToShortDateString().ToSql() + " AND [EOUSE_DATE] <= " + EouseEnd.Value.ToShortDateString().ToSql() : "");
                                string StaFam = (MobStation2_State.Value != "" ? "AND [ST_FAMILY] " + (LikeMs2State.Checked ? "LIKE" : "NOT LIKE") + " '" + MobStation2_State.Value + "'" : "");
                                string Status = (MobStation2_Status.Value != "" ? "AND [STATUS] " + (LikeMs2Status.Checked ? "LIKE" : "NOT LIKE") + " '" + MobStation2_Status.Value + "'" : "");
                                string freqs = (OQL_OT_freq != "" ? OQL_OT_freq : "") + (OQL_OT_freq != "" && OQL_Freq0_OT != "" ? " OR " : "") + (OQL_Freq0_OT != "" ? OQL_Freq0_OT : "");
                                string MSquery2 = "({0})".Fmt(uwMsPositions2) + Biuse + Eouse + StaFam + Status;
                                MSquery2 += (freqs != "" ? (MSquery2 != "" ? " AND (" : "") + freqs + ")" : "");
                                unwantedMobStations2.Filter = (YTable.Table == "MOB_STATION2" ? IDlist + (MSquery2 != "" ? " AND" : "") : "") + MSquery2;
                                for (unwantedMobStations2.OpenRs(); !unwantedMobStations2.IsEOF(); unwantedMobStations2.MoveNext()) { UWantedMs2ID.Add(unwantedMobStations2.m_id); }
                                unwantedMobStations2.Close();
                                BagUWantedMobSta2.Create(title, "Unwanted Mob_Station2");
                                foreach (int idc in UWantedMs2ID) { BagUWantedMobSta2.Add(idc, ref countAdded, false, ColorMs2); } // color = orange
                            }

                            if (inMicrowa.Checked && (ListWhereFreqMW0.Count + ListWhereFreqMW.Count != 0))
                            {
                                string OQL_Freq0_MW = ListWhereFreqMW0.Count != 0 ? ListWhereFreqMW0.OrSep().Replace(",", ".") : "";
                                string OQL_MW_freq = ListWhereFreqMW.Count != 0 ? ListWhereFreqMW.OrSep().Replace(",", ".") : "";
                                string Biuse = (BiuseBox.Checked ? "AND [Microwave.BIUSE_DATE] >= " + BiuseStart.Value.ToShortDateString().ToSql() + " AND [Microwave.BIUSE_DATE] <= " + BiuseEnd.Value.ToShortDateString().ToSql() : "");
                                string Eouse = (EouseBox.Checked ? "AND [Microwave.EOUSE_DATE] >= " + EouseStart.Value.ToShortDateString().ToSql() + " AND [Microwave.EOUSE_DATE] <= " + EouseEnd.Value.ToShortDateString().ToSql() : "");
                                string StaFam = (Microwa_State.Value != "" ? "AND [Microwave.ST_FAMILY] " + (LikeMwState.Checked ? "LIKE" : "NOT LIKE") + " '" + Microwa_State.Value + "'" : "");
                                string Status = (Microwa_Status.Value != "" ? "AND [Microwave.STATUS] " + (LikeMwStatus.Checked ? "LIKE" : "NOT LIKE") + " '" + Microwa_Status.Value + "'" : "");
                                string freqs = (OQL_MW_freq != "" ? "({0})".Fmt(OQL_MW_freq) : "") + (OQL_Freq0_MW != "" && OQL_MW_freq != "" ? " OR " : "") + (OQL_Freq0_MW != "" ? "({0})".Fmt(OQL_Freq0_MW) : "");
                                unwantedMicrows.Filter = "({0})".Fmt(freqs) + (OQL_Positions != "" ? "AND ({0})".Fmt(OQL_Positions) : "") + Biuse + Eouse + StaFam + Status;
                                for (unwantedMicrows.OpenRs(); !unwantedMicrows.IsEOF(); unwantedMicrows.MoveNext()) { UWantedMwaID.Add(unwantedMicrows.m_mw_id); }
                                unwantedMicrows.Close();
                                BagUWantedMwa.Create(title, "Unwanted Microwave Links");
                                foreach (int idd in UWantedMwaID) { BagUWantedMwa.Add(idd, ref countAdded, false, ColorMicrowa); } //color = red
                            }

                            if (isWarfare && inSfaf.Checked && LsitWhereFreqSfaf.Count != 0 && isWarfare)
                            {
                                unwantedSfaf = new YSfaf();
                                string OQL_Sfaf_freq = LsitWhereFreqSfaf.Count != 0 ? LsitWhereFreqSfaf.OrSep().Replace(",", ".") : "";
                                string Biuse = (BiuseBox.Checked ? "AND [BIUSE_DATE] >= " + BiuseStart.Value.ToShortDateString().ToSql() + " AND [BIUSE_DATE] <= " + BiuseEnd.Value.ToShortDateString().ToSql() : "");
                                string Eouse = (EouseBox.Checked ? "AND [EOUSE_DATE] >= " + EouseStart.Value.ToShortDateString().ToSql() + " AND [EOUSE_DATE] <= " + EouseEnd.Value.ToShortDateString().ToSql() : "");
                                string StaFam = (Sfaf_State.Value != "" ? "AND [Microwave.ST_FAMILY] " + (LikeSfafState.Checked ? "LIKE" : "NOT LIKE") + " '" + Sfaf_State.Value + "'" : "");
                                string freqs = (OQL_Sfaf_freq != "" ? "(" + OQL_Sfaf_freq + ")" : "");
                                unwantedSfaf.Filter = freqs + Biuse + Eouse + StaFam + ((OQL_PositionsSfaf != "") ? (freqs != "" ? " AND " : "") + OQL_PositionsSfaf : "");
                                for (unwantedSfaf.OpenRs(); !unwantedSfaf.IsEOF(); unwantedSfaf.MoveNext()) { UWantedSfafID.Add(unwantedSfaf.m_id); }
                                unwantedSfaf.Close();
                                BagUWantedSfaf.Create(title, "Unwanted SFAF");
                                foreach (int ide in UWantedSfafID) { BagUWantedSfaf.Add(ide, ref countAdded, false, ColorSfaf); } //color = green
                            }

                            YTable.Close();

                            //store bags_id for OnRequery
                            bagWantedId = BagWanted.Bag.m_id;
                        }   
                    }
                    #endregion
                    #region MICROWA
                    else if (DbListWanted.Table == "MICROWA" || DbListWanted.Table == "MICROWS")
                    {
                        //Bag wanted
                        IcsmBag BagWanted = new IcsmBag("MICROWA");

                        //on cherche les stations unwanted dans les MW
                        YMicrows YTable = new YMicrows();
                        YTable.Format("ID,TX_FREQ,LinkedTo(TX_FREQ),Microwave(BW,PLAN_ID,Equipment(SENSITIVITY,LOWER_FREQ,UPPER_FREQ,RX_UPPER_FREQ,RX_LOWER_FREQ,MAX_POWER,POWER,RXTH_3)),Position(NAME,X,Y,CSYS,ASL,POINTS),AGL1,MW_ID,Plan(ID,LOWER_FREQ,UPPER_FREQ),PLAN_ID,POWER,");
                        YTable.Filter = DbListWanted.Filter;
                        List<int> ListID = new List<int>();

                        for (YTable.OpenRs(); !YTable.IsEOF(); YTable.MoveNext())
                        {
                            double bw = YTable.m_Microwave.m_bw; string PosName = YTable.m_Position.m_name;
                            double PositionX = YTable.m_Position.m_x; double PositionY = YTable.m_Position.m_y;
                            double PositionASL = YTable.m_Position.m_asl; double PositionAGL = YTable.m_agl1;
                            double[] Elevations = new double[72]; double[] Distances = new double[72];
                            double freq = YTable.m_tx_freq;
                            List<double> polygoneX = new List<double>(); List<double> polygoneY = new List<double>();
                            double PlanMin = YTable.m_Plan.m_lower_freq; double PlanMax = YTable.m_Plan.m_upper_freq;

                            //add ID to Wanted HashSet
                            WantedID.Add(YTable.m_mw_id);

                            if (radioDistance.Checked ^ coverMode.Checked)
                            {
                                if (!coverMode.Checked && radioDistance.Checked)
                                {
                                    //building where conditions for radioDistance (4/3*optical distance) cirteria                        
                                    IMPosition pos = new IMPosition();
                                    pos.CSys = "4DEC"; pos.Lon = PositionX; pos.Lat = PositionY;
                                    bool computed = IM.ComputeHorizon(pos, (PositionAGL + PositionASL), 5, ref Elevations, ref Distances);
                                    if (!computed)
                                    {
                                            CallMissingDtmError(PosName);
                                        stop = true; break;
                                    }
                                    double longNode = Null.D, latNode = Null.D;
                                    for (int i = 71; i >= 0; i--)
                                    {
                                        IM.GeoJump(ref longNode, ref latNode, pos.Lon, pos.Lat, Distances[i] * 4 / 3, i * 5);
                                        polygoneX.Add(longNode);
                                        polygoneY.Add(latNode);
                                    }

                                    if (inMicrowa.Checked)
                                    {
                                        ListWherePosFix.Add("([Position.X] >= " + polygoneX.Min() + " AND [Position.X] <= " + polygoneX.Max() + ") AND ([Position.Y] >= " + polygoneY.Min() + " AND [Position.Y] <= " + polygoneY.Max() + ")");
                                    }

                                    if (inSfaf.Checked)
                                    {
                                        ListWherePosSfaf.Add("([Transmitter.X] >= " + polygoneX.Min() + " AND [Transmitter.X] <= " + polygoneX.Max() + ") AND ([Transmitter.Y] >= " + polygoneY.Min() + " AND [Transmitter.Y] <= " + polygoneY.Max() + ")");
                                    }

                                }
                                else
                                {
                                    //building where conditions for coverage mode
                                    PolygoneEtude PolyEtd = new PolygoneEtude();
                                    List<AzimAtten> pattern = AzimAtten.LoadPattern("MOB_STATION", YTable.m_id);
                                    double F = 0.0;
                                    if ((YTable.m_tx_freq == 0 || YTable.m_tx_freq == Null.D)
                                     && (YTable.m_LinkedTo.m_tx_freq == 0 || YTable.m_LinkedTo.m_tx_freq == Null.D))
                                    {
                                        F = YTable.m_Microwave.m_Equipment.m_upper_freq - (YTable.m_Microwave.m_Equipment.m_upper_freq - YTable.m_Microwave.m_Equipment.m_lower_freq) / 2;
                                        if (F <= Null.D)
                                        {
                                            F = YTable.m_Microwave.m_Equipment.m_rx_upper_freq - (YTable.m_Microwave.m_Equipment.m_rx_upper_freq - YTable.m_Microwave.m_Equipment.m_rx_lower_freq) / 2;
                                        }
                                    }
                                    else
                                    {
                                        F = YTable.m_tx_freq >= Null.D ? YTable.m_tx_freq : YTable.m_LinkedTo.m_tx_freq;
                                    }
                                    double Puissance = YTable.m_power > Null.D ? YTable.m_power : YTable.m_Microwave.m_Equipment.m_max_power;
                                    Puissance = Puissance > Null.D ? Puissance : YTable.m_Microwave.m_Equipment.m_power;
                                    double Seuil = YTable.m_Microwave.m_Equipment.m_sensitivity < Null.D ? YTable.m_Microwave.m_Equipment.m_sensitivity : YTable.m_Microwave.m_Equipment.m_rxth_3;
                                    if (Seuil == Null.D) { Seuil = DefaultKtbf.Value; }
                                    double range = (299.792 / F) / (4 * Math.PI) * Math.Pow(10, (Puissance - 30 - Seuil) / 20) / 1000;//en Km
                                    PolyEtd.CalculeCouverturePoint(PositionX, PositionY, YTable.m_Position.m_csys, pattern, range);

                                    //compute Radio Horizon rectangle
                                    string maxX = PolyEtd.Extent.maxX.ToString().Replace(",", ".");
                                    string minX = PolyEtd.Extent.minX.ToString().Replace(",", ".");
                                    string maxY = PolyEtd.Extent.maxY.ToString().Replace(",", ".");
                                    string minY = PolyEtd.Extent.minY.ToString().Replace(",", ".");

                                    if (inMicrowa.Checked)
                                    {
                                        ListWherePosFix.Add("([Position.X] >= " + minX + " AND [Position.X] <= " + maxX + ") AND ([Position.Y] >= " + minY + " AND [Position.Y] <= " + maxY + ")");
                                    }

                                    if (inSfaf.Checked && isWarfare)
                                    {
                                        ListWherePosSfaf.Add("([Transmitter.X] >= " + minX + " AND [Transmitter.X] <= " + maxX + ") AND ([Transmitter.Y] >= " + minY + " AND [Transmitter.Y] <= " + maxY + ")");
                                    }

                                    if (inMobStation.Checked)
                                    {
                                        YMobStationT m = new YMobStationT();
                                        m.Table = "MOB_STATION";
                                        m.Format("ID,AssignedFrequencies(TX_FREQ,RX_FREQ),BW,Position(ID,X,Y,CSYS,ASL,POINTS,X_MIN,X_MAX,Y_MIN,Y_MAX,LONGITUDE,LATITUDE),AGL,PLAN_ID,Plan(LOWER_FREQ,UPPER_FREQ),RADIUS");
                                        m.Filter = "[Position.X_MIN]<{0} AND [Position.X_MAX]>{1} AND [Position.Y_MIN]<{2} AND [Position.Y_MAX]>{3} ".Fmt(maxX, minX, maxY, minY);
                                        for (m.OpenRs(); !m.IsEOF(); m.MoveNext())
                                        {
                                            //Add station ID if a Polygone intersects the Radio Horizon perimeter
                                            try
                                            {
                                                if (PolyEtd.Intersects(m.m_Position, 0)) { ListWherePosMob.Add(m.m_id); }
                                            }
                                            catch
                                            { }
                                        }
                                    }

                                    if (inMobStation2.Checked)
                                    {
                                        YMobStationT m2 = new YMobStationT();
                                        m2.Table = "MOB_STATION2";
                                        m2.Format("ID,AssignedFrequencies(TX_FREQ,RX_FREQ),BW,Position(ID,X,Y,CSYS,ASL,POINTS,X_MIN,X_MAX,Y_MIN,Y_MAX,LONGITUDE,LATITUDE),AGL,PLAN_ID,Plan(LOWER_FREQ,UPPER_FREQ),RADIUS");
                                        m2.Filter = "[Position.X_MIN]<{0} AND [Position.X_MAX]>{1} AND [Position.Y_MIN]<{2} AND [Position.Y_MAX]>{3} ".Fmt(maxX, minX, maxY, minY);
                                        for (m2.OpenRs(); !m2.IsEOF(); m2.MoveNext())
                                        {
                                            //Add station ID if a Polygone intersects the Radio Horizon perimeter
                                            try
                                            {
                                                if (PolyEtd.Intersects(m2.m_Position, 0)) { ListWherePosMob2.Add(m2.m_id); }
                                            }
                                            catch
                                            { }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                IcsMetroMessageBox.Show(L.Txt("Bad mode selection. Default mode will be radio horizon limit"));
                            }

                            //excluding Wanted station ID to unwanted station list
                            ListID.Add(YTable.m_id);

                            //building freqeuncy criteria for MobStation & Microwave tables
                            ListWhereFreqOT.Add("([AssignedFrequencies.TX_FREQ] + ([BW] /2000) >= " + (freq - (bw * Ln / 2000)) +
                                                " AND [AssignedFrequencies.TX_FREQ] - ([BW] /2000) <= " + (freq + (bw * Ln / 2000)) + ")");
                            ListWhereFreqMW.Add("([TX_FREQ]  + ([Microwave.BW] /2000) >= " + (freq - (bw * Ln / 2000)) +
                                                " AND [TX_FREQ] - ([Microwave.BW] /2000) <= " + (freq + (bw * Ln / 2000)) + ")");
                            LsitWhereFreqSfaf.Add("([FREQ]  + ([BW] /2000) >= " + (freq - (bw * Ln / 2000)) +
                                               " AND [FREQ] - ([BW] /2000) <= " + (freq + (bw * Ln / 2000)) + ")");
                            ListWhereFreqOT0.Add("([AssignedFrequencies.TX_FREQ] + ([BW] /2000) >= " + (PlanMin) +
                                                " AND [AssignedFrequencies.TX_FREQ] - ([BW] /2000) <= " + (PlanMax) + ")");
                            ListWhereFreqMW0.Add("([TX_FREQ]  + ([Microwave.BW] /2000) >= " + (PlanMin) +
                                                " AND [TX_FREQ] - ([Microwave.BW] /2000) <= " + (PlanMax) + ")");
                        }

                        //combining each kind of criteria into 1 string
                        string OQL_id = ListID.CommaSep();
                        string OQL_Positions = "";
                        string OQL_OT_freq = "";

                        int countAdded = 0;
                        BagWanted.Create(title, "Wanted Microwave links");
                        foreach (int ida in WantedID) { BagWanted.Add(ida, ref countAdded, false, ColorWanted); }
                        string Biuse = "", Eouse = "";

                        if (inMobStation.Checked || inMobStation2.Checked)
                        {
                            OQL_OT_freq = ListWhereFreqOT.Count != 0 ? ListWhereFreqOT.OrSep().Replace(",", ".") : "";
                            OQL_Positions = ListWherePosFix.Count != 0 ? ListWherePosFix.OrSep().Replace(",", ".") : "1=1";
                            Biuse = (BiuseBox.Checked ? "AND [BIUSE_DATE] >= " + BiuseStart.Value.ToShortDateString().ToSql() + " AND [BIUSE_DATE] <= " + BiuseEnd.Value.ToShortDateString().ToSql() : "");
                            Eouse = (EouseBox.Checked ? "AND [EOUSE_DATE] >= " + EouseStart.Value.ToShortDateString().ToSql() + " AND [EOUSE_DATE] <= " + EouseEnd.Value.ToShortDateString().ToSql() : "");
                        }

                        if (inMobStation.Checked)
                        {
                            string StaFam = (MobStation_State.Value != "" ? "AND [ST_FAMILY] " + (LikeMsState.Checked ? "LIKE" : "NOT LIKE") + " '" + MobStation_State.Value + "'" : "");
                            string Status = (MobStation_Status.Value != "" ? "AND [STATUS] " + (LikeMsStatus.Checked ? "LIKE" : "NOT LIKE") + " '" + MobStation_Status.Value + "'" : "");
                            unwantedMobStations.Filter = "(" + OQL_Positions + ") AND (" + OQL_OT_freq + ")" + Biuse + Eouse + StaFam + Status;
                            for (unwantedMobStations.OpenRs(); !unwantedMobStations.IsEOF(); unwantedMobStations.MoveNext()) { UWantedMsID.Add(unwantedMobStations.m_id); }
                            unwantedMobStations.Close();
                            BagUWantedMobSta.Create(title, "Unwanted Mob_Station");
                            foreach (int idb in UWantedMsID) { BagUWantedMobSta.Add(idb, ref countAdded, false, ColorMs); }
                        }

                        if (inMobStation2.Checked)
                        {
                            string StaFam = (MobStation2_State.Value != "" ? "AND [ST_FAMILY] " + (LikeMs2State.Checked ? "LIKE" : "NOT LIKE") + " '" + MobStation2_State.Value + "'" : "");
                            string Status = (MobStation2_Status.Value != "" ? "AND [STATUS] " + (LikeMs2Status.Checked ? "LIKE" : "NOT LIKE") + " '" + MobStation2_Status.Value + "'" : "");
                            unwantedMobStations2.Filter = "(" + OQL_Positions + ") AND (" + OQL_OT_freq + ")" + Biuse + Eouse + StaFam + Status;
                            for (unwantedMobStations2.OpenRs(); !unwantedMobStations2.IsEOF(); unwantedMobStations2.MoveNext()) { UWantedMs2ID.Add(unwantedMobStations2.m_id); }
                            unwantedMobStations2.Close();
                            BagUWantedMobSta2.Create(title, "Unwanted Mob_Station2");
                            foreach (int idc in UWantedMs2ID) { BagUWantedMobSta2.Add(idc, ref countAdded, false, ColorMs2); }
                        }

                        if (inMicrowa.Checked)
                        {
                            string OQL_MW_freq = ListWhereFreqMW.Count != 0 ? ListWhereFreqMW.OrSep().Replace(",", ".") : "";
                            Biuse = (BiuseBox.Checked ? "AND [Microwave.BIUSE_DATE] >= " + BiuseStart.Value.ToShortDateString().ToSql() + " AND [Microwave.BIUSE_DATE] <= " + BiuseEnd.Value.ToShortDateString().ToSql() : "");
                            Eouse = (EouseBox.Checked ? "AND [Microwave.EOUSE_DATE] >= " + EouseStart.Value.ToShortDateString().ToSql() + " AND [Microwave.EOUSE_DATE] <= " + EouseEnd.Value.ToShortDateString().ToSql() : "");
                            string StaFam = (Microwa_State.Value != "" ? "AND [Microwave.ST_FAMILY] " + (LikeMwState.Checked ? "LIKE" : "NOT LIKE") + " '" + Microwa_State.Value + "'" : "");
                            string Status = (Microwa_Status.Value != "" ? "AND [Microwave.STATUS] " + (LikeMwStatus.Checked ? "LIKE" : "NOT LIKE") + " '" + Microwa_Status.Value + "'" : "");
                            unwantedMicrows.Filter = "[ID] NOT IN (" + OQL_id + ") AND (" + OQL_MW_freq + ")" + (OQL_Positions == ")" ? ")" : " AND (" + OQL_Positions + ")") + Biuse + Eouse + StaFam + Status;
                            for (unwantedMicrows.OpenRs(); !unwantedMicrows.IsEOF(); unwantedMicrows.MoveNext()) { UWantedMwaID.Add(unwantedMicrows.m_mw_id); }
                            unwantedMicrows.Close();
                            BagUWantedMwa.Create(title, "Unwanted Microwave Links");
                            foreach (int idd in UWantedMwaID) { BagUWantedMwa.Add(idd, ref countAdded, false, ColorMicrowa); }
                        }

                        if (inSfaf.Checked && LsitWhereFreqSfaf.Count != 0 && isWarfare)
                        {
                            unwantedSfaf = new YSfaf();
                            string OQL_Sfaf_freq = LsitWhereFreqSfaf.Count != 0 ? LsitWhereFreqSfaf.OrSep().Replace(",", ".") : "";
                            Biuse = (BiuseBox.Checked ? "AND [BIUSE_DATE] >= " + BiuseStart.Value.ToShortDateString().ToSql() + " AND [BIUSE_DATE] <= " + BiuseEnd.Value.ToShortDateString().ToSql() : "");
                            Eouse = (EouseBox.Checked ? "AND [EOUSE_DATE] >= " + EouseStart.Value.ToShortDateString().ToSql() + " AND [EOUSE_DATE] <= " + EouseEnd.Value.ToShortDateString().ToSql() : "");
                            string StaFam = (Sfaf_State.Value != "" ? "AND [Microwave.ST_FAMILY] " + (LikeSfafState.Checked ? "LIKE" : "NOT LIKE") + " '" + Sfaf_State.Value + "'" : "");
                            string OQL_PositionsSfaf = ListWherePosSfaf.Count != 0 ? ListWherePosSfaf.OrSep().Replace(",", ".") : "";
                            unwantedSfaf.Filter = "(" + OQL_Sfaf_freq + ")" + (OQL_PositionsSfaf == ")" ? ")" : " AND (" + OQL_PositionsSfaf + ")") + Biuse + Eouse + StaFam;
                            for (unwantedSfaf.OpenRs(); !unwantedSfaf.IsEOF(); unwantedSfaf.MoveNext()) { UWantedSfafID.Add(unwantedSfaf.m_id); }
                            unwantedSfaf.Close();
                            BagUWantedSfaf.Create(title, "Unwanted SFAF");
                            foreach (int ide in UWantedSfafID) { BagUWantedSfaf.Add(ide, ref countAdded, false, ColorSfaf); }
                        }

                        YTable.Close();
                        BagWanted.Bag.Delete();

                        //store bags_id for OnRequery
                        bagWantedId = BagWanted.Bag.m_id;
                    }
                    #endregion

                    if (!stop)
                    {
                        //store bags_id for OnRequery
                        this.bagunwantedIdMobStation = BagUWantedMobSta.Bag.m_id;
                        this.bagunwantedIdMobStation2 = BagUWantedMobSta2.Bag.m_id;
                        this.bagunwantedIdMicrowa = BagUWantedMwa.Bag.m_id;
                        if (inSfaf.Checked && isWarfare) { this.bagunwantedIdSfaf = BagUWantedSfaf.Bag.m_id; }

                        //mise à jour des DbList
                        DbListRequerry("DbListWanted");
                        DbListRequerry("DbListMobStation");
                        DbListRequerry("DbListMwa");
                        if (inSfaf.Checked && isWarfare) { DbListRequerry("DbListSfaf"); }

                        //gestion des boutons à la fin de l'execution
                        if (IM.GetHtzStatus() == 2) { SetImportOnMapButton(true); }
                        SwitchBuildButton(true);
                        SwitchEwxButton(true);
                        SetSpinner(false);
                        stop = true;
                    }
                    else
                    {
                        SwitchBuildButton(true); SetSpinner(false);
                    }

                }
            }
            
        }
        private void DisplayCopyDatesButtons()
        {
            if (BiuseBox.Checked && EouseBox.Checked)
            {
                CopyBtoE.Visible = true;
                CopyEtoB.Visible = true;
            }
            else
            {
                CopyBtoE.Visible = false;
                CopyEtoB.Visible = false;
            }
        }

        #endregion

        void DbListRequerry(string DbListName)
        {
            if (!stop)
            {
                switch (DbListName)
                {
                    case "DbListWanted": Invoke(new ExecDelegate(DbListWanted.Requery)); break;
                    case "DbListMobStation": Invoke(new ExecDelegate(DbListMobStation.Requery)); break;
                    case "DbListMwa": Invoke(new ExecDelegate(DbListMwa.Requery)); break;
                    case "DbListSfaf": Invoke(new ExecDelegate(DbListSfaf.Requery)); break;
                    default: break;
                }
            }
        }
        private void getAllWantedStations(string OqlFilter, string Table)
        {
            //saveName
            string title = SaveBox.Checked ? SaveName.Text : "Search for potential interferer (" + IM.ConnectedUser() + ")";

            //Get(WantedStation) depending TableName
            IcsmBag BagWanted = new IcsmBag(Table);
            BagWanted.Create(title, "Wanted Mob_Station");

            if (Table == "MOB_STATION") //select table <=> Yclass : YTable représente les stations Wanted (candidate)
            {

                YMobStationT YTable = new YMobStationT();
                YTable.Table = Table;
                YTable.Format("ID");
                YTable.Filter = OqlFilter;
                List<int> ListID = new List<int>();
                int countAdded = 0;
                for (YTable.OpenRs(); !YTable.IsEOF(); YTable.MoveNext())
                {
                    ListID.Add(YTable.m_id);
                    BagWanted.Add(YTable.m_id, ref countAdded, false, 1);
                }
                YTable.Close();
                if (ListID.Count == 0)
                {
                    MessageBox.Show(L.Txt("No station selected"));
                    Close();
                }
                else
                {
                    string OQL_id = ListID.CommaSep();
                    DbListWanted.Table = Table;
                    wantedStationsOQL = (OQL_id != "" ? "[ID] IN (" + OQL_id + ") OR [REC_ID] IN (" + OQL_id + ") OR [ID] IN (SELECT REC_ID FROM MOB_STATION WHERE ID IN (" + OQL_id + "))" : "");
                }
            }
            else if (Table == "MICROWA")//on récupère la selection de l'usr dans MWA puis on récupère les MWS associées
            {
                DbListWanted.Table = "MICROWS";
                wantedStationsOQL = OqlFilter.Replace("[", "[Microwave.");
            }
            else
            { //should never happens but just in case...
                MessageBox.Show(L.Txt("This table is not compatible with this tool for now."));
            }
            DbListWanted.Filter = wantedStationsOQL;
            DbListWanted.SetFilter(wantedStationsOQL);
            bagWantedId = BagWanted.Bag.m_id;
            DbListWanted.Requery();
        }

        private void getAllWantedStations(IMQueryMenuNode.Context ct)
        {
            //saveName
            string title = SaveBox.Checked ? SaveName.Text : "Search for potential interferer (" + IM.ConnectedUser() + ")";

            //Get(WantedStation) depending TableName
            IcsmBag BagWanted = new IcsmBag(ct.TableName);
            BagWanted.Create(title, "Wanted Mob_Station");

            if (ct.TableName == "MOB_STATION") //select table <=> Yclass : YTable représente les stations Wanted (candidate)
            {

                YMobStationT YTable = new YMobStationT();
                YTable.Table = ct.TableName;
                YTable.Format("ID");
                YTable.Filter = ct.DataList.GetOQLFilter(true);
                List<int> ListID = new List<int>();
                int countAdded = 0;
                for (YTable.OpenRs(); !YTable.IsEOF(); YTable.MoveNext())
                {
                    ListID.Add(YTable.m_id);
                    BagWanted.Add(YTable.m_id, ref countAdded, false, 1);
                }
                YTable.Close();
                if (ListID.Count == 0)
                {
                    MessageBox.Show(L.Txt("No station selected"));
                    Close();
                }
                else
                {
                    string OQL_id = ListID.CommaSep();
                    DbListWanted.Table = ct.TableName;
                    wantedStationsOQL = (OQL_id != "" ? "[ID] IN (" + OQL_id + ") OR [REC_ID] IN (" + OQL_id + ") OR [ID] IN (SELECT REC_ID FROM MOB_STATION WHERE ID IN (" + OQL_id + "))" : "");
                }
            }
            else if (ct.TableName == "MICROWA")//on récupère la selection de l'usr dans MWA puis on récupère les MWS associées
            {
                DbListWanted.Table = "MICROWS";
                wantedStationsOQL = ct.DataList.GetOQLFilter(true).Replace("[", "[Microwave.");
            }
            else
            { //should never happens but just in case...
                MessageBox.Show(L.Txt("This table is not compatible with this tool for now."));
            }
            DbListWanted.Filter = wantedStationsOQL;
            DbListWanted.SetFilter(wantedStationsOQL);
            bagWantedId = BagWanted.Bag.m_id;
            DbListWanted.Requery();
        }
        private void exportDataset(bool toHTZ)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {

                string title = folder.SelectedPath + "\\" + (SaveBox.Checked ? SaveName.Text : "Search for potential interferer (" + IM.ConnectedUser() + ")") + ".EWX";
                BagWanted = new IcsmBag(DbListWanted.Table.Replace("MICROWS", "MICROWA"));
                BagWanted.Create(title, "Wanted Mob_Station");
                int countAdded = 0;
                foreach (int ida in WantedID) { BagWanted.Add(ida, ref countAdded, false, 1); }
                List<RecPtr> Allbags = new List<RecPtr>();
                if (BagWanted.GetCount() > 0) { Allbags.Add(BagWanted.Bag.Rec); }
                if (BagUWantedMobSta.GetCount() > 0) { Allbags.Add(BagUWantedMobSta.Bag.Rec); }
                if (BagUWantedMobSta2.GetCount() > 0) { Allbags.Add(BagUWantedMobSta2.Bag.Rec); }
                if (BagUWantedMwa.GetCount() > 0) { Allbags.Add(BagUWantedMwa.Bag.Rec); }
                if (BagUWantedSfaf.GetCount() > 0) { Allbags.Add(BagUWantedSfaf.Bag.Rec); }

                IM.ExportToEWX(ref title, toHTZ, Allbags.ToArray());
            }
        }
        private void ClearBags()
        {
            if (BagUWantedMobSta2.Bag != null) OrmSchema.Linker.Execute("DELETE FROM %{0} WHERE ID={1}".Fmt(BagUWantedMobSta2.Bag.Table, BagUWantedMobSta2.Bag.m_id));
            if (BagUWantedMobSta.Bag != null) OrmSchema.Linker.Execute("DELETE FROM %{0} WHERE ID={1}".Fmt(BagUWantedMobSta.Bag.Table, BagUWantedMobSta.Bag.m_id));
            if (BagUWantedMwa.Bag != null) OrmSchema.Linker.Execute("DELETE FROM %{0} WHERE ID={1}".Fmt(BagUWantedMwa.Bag.Table, BagUWantedMwa.Bag.m_id));
            if (BagUWantedSfaf.Bag != null) OrmSchema.Linker.Execute("DELETE FROM %{0} WHERE ID={1}".Fmt(BagUWantedSfaf.Bag.Table, BagUWantedSfaf.Bag.m_id));
            if (BagWanted.Bag != null) OrmSchema.Linker.Execute("DELETE FROM %{0} WHERE ID={1}".Fmt(BagWanted.Bag.Table, BagWanted.Bag.m_id));
        }
        

    }
}


