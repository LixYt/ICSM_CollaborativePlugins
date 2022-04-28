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
using DatalayerCs;
using XICSM.VanillaTools.Tools;

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
        private IcsmBag BagWanted = new IcsmBag("ALL_TXRXFREQ");
        //hashset
        private HashSet<int> WantedID = new HashSet<int>();

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
        

        #region Initialization And Instanciation
        public SearchInterf()        { InitializeComponent(); }
        private void TextTranslation()
        {
            geoParam.Text = L.Txt("Frequency limits");
            t.SetToolTip(N2, "Rec. ITU-R SM.329-7");
            N2.Text = L.Txt("Spurious Domain\r\n(in accordance with ITU)");
            N1.Text = L.Txt("tight mode\r\nadjacent channel");
            N0.Text = L.Txt("very tight mode\r\ncochannel");
            freqParams.Text = L.Txt("Computing mode");
            ComputingHorizon.Text = L.Txt("radio horizon limit");
            ComputingFreeSpaceLoss.Text = L.Txt("free space loss limit");
            importOnMap.Text = L.Txt("Export to HTZ map");
            tabConfig.Text = L.Txt("Configuration");
            OtherFilters.Text = L.Txt("Status Filtering options by tables");
            DefaultKtbfArea.Text = L.Txt("default ktbf");
            saveParam.Text = L.Txt("Save result bags");
            labelSave.Text = L.Txt("enter a save name");
            EouseFilter.Text = L.Txt("End of use between");
            and2.Text = L.Txt("and");
            BiuseFilter.Text = L.Txt("Bring in use between");
            and1.Text = L.Txt("and");
            toEWX.Text = L.Txt("Export result as EWX file");
            RunSearch.Text = L.Txt("Search");
            tabWanted.Text = L.Txt("wanted stations");
            Text = L.Txt("Search for potential inteferer");
            cancelThread.Text = L.Txt("Cancel");
        }
        public static bool builder(IMQueryMenuNode.Context ct)
        {
            SearchInterf Me = new SearchInterf();
            Me.getAllWantedStations(ct);
            Me.ShowDialog();
            return false;
        }

        public static bool builder(string OqlFilter, string Table)
        {
            SearchInterf Me = new SearchInterf();
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
        private void DbListUnwanted_OnRequery(object sender, EventArgs e)
        {
            DbListRxUnwanted.MustBePresent("ID");
            //DbListUnwanted.SetFilter(wantedStationsOQL);
        }
        private void DatasetBuilder_Load(object sender, EventArgs e)
        {
            IcsMetroMessageBox.Show(L.TxT("This feature is still under development (WIP) and does not work or might not work as intended."));
            DbListWanted.Init();
            DbListRxUnwanted.Init();
            DbListTxUnwanted.Init();
            DbListWantedExcluded.Init();

            TextTranslation();
        }

        private void buildDatasets_Click(object sender, EventArgs e)
        {
            ANetDb db = null; string nameIndb = null;
            OrmSchema.Linker.GetTableMapping("LICENCE", ref db, ref nameIndb);
            string schemaPrefix = OrmSchema.Linker.GetSchemaPrefix("MOB_STATION");

            //saveName
            title = SaveBox.Checked ? SaveName.Text : "Search for potential interferer (" + IM.ConnectedUser() + ")";

            workerThread = new Thread(() => { this.DoWork(db, schemaPrefix); });
            workerThread.Start();

            //if (BagUWantedMobSta.Bag != null || BagUWantedMobSta2.Bag != null || BagUWantedMwa.Bag != null || BagUWantedSfaf.Bag != null || BagWanted != null)
            {
                ClearBags(); // clear bags then reinit them
                /*BagUWantedMobSta = new IcsmBag("MOB_STATION");
                BagUWantedMobSta2 = new IcsmBag("MOB_STATION2");
                BagUWantedMwa = new IcsmBag("MICROWA");
                BagUWantedSfaf = new IcsmBag("SFAF");*/
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
                    string FormatAllTxRxFreq = "ALLSTA_ID,TX_FREQ,RX_FREQ,TX_BW,RX_BW,X,Y,CSYS,ASL,POINTS,RADIUS,AGL,Plan(LOWER_FREQ,UPPER_FREQ),BIUSE_DATE,EOUSE_DATE";

                    YAllTxrxFreq UnwantedStations = new YAllTxrxFreq();
                    UnwantedStations.Format(FormatAllTxRxFreq);
                    List<int> UnwantedRxStationIds = new List<int>();
                    List<int> UnwantedTxStationIds = new List<int>();
                    List<int> FailedUnwantedStationIds = new List<int>();

                    //Bag wanted
                    IcsmBag BagWanted = new IcsmBag(DbListWanted.Table);
                    IcsmBag BagUnwantedTx = new IcsmBag(DbListTxUnwanted.Table);
                    IcsmBag BagUnwantedRx = new IcsmBag(DbListRxUnwanted.Table);
                    IcsmBag BagWantedExcluded = new IcsmBag(DbListWantedExcluded.Table);

                    //on cherche les stations unwanted en bouclant sur les wanted
                    YAllTxrxFreq WantedStations = new YAllTxrxFreq();
                    WantedStations.Format("ALLSTA_ID,TX_FREQ,EIRP,RX_FREQ,TX_BW,RX_BW,X,Y,ASL,POINTS,RADIUS,SITE_NAME,AGL,PLAN_ID,Plan(LOWER_FREQ,UPPER_FREQ),BIUSE_DATE,EOUSE_DATE");
                    WantedStations.Filter = DbListWanted.Filter;

                    //Step 1: Get Potential Tx/Rx Unwanted station based on Freq Ops range
                    for (WantedStations.OpenRs(); !WantedStations.IsEOF(); WantedStations.MoveNext())
                    {
                        double TxLowerLimit = WantedStations.m_tx_freq - WantedStations.m_tx_bw;
                        double TxUpperLimit = WantedStations.m_tx_freq + WantedStations.m_tx_bw;

                        double RxLowerLimit = WantedStations.m_tx_freq - WantedStations.m_tx_bw;
                        double RxUpperLimit = WantedStations.m_tx_freq + WantedStations.m_tx_bw;

                        if (WantedStations.m_tx_freq != Null.D && WantedStations.m_rx_freq != Null.D)
                        {
                            //Search for potential Unwanted Rx stations based on Frequency limits
                            YAllTxrxFreq Rx_PotentialUnwanted = new YAllTxrxFreq();
                            Rx_PotentialUnwanted.Format(FormatAllTxRxFreq);
                            Rx_PotentialUnwanted.Filter =
                                $"(([RX_FREQ]/1000 - ([RX_BW] * {Ln} / 2) >= {TxLowerLimit} AND [RX_FREQ]/1000 - ([RX_BW] * {Ln} / 2) <= {TxUpperLimit})" +
                                $"OR " +
                                $"([RX_FREQ]/1000 + ([RX_BW] * {Ln} / 2) <= {TxUpperLimit} AND [RX_FREQ]/1000 + ([RX_BW] * {Ln} / 2) >= {TxLowerLimit}))";

                            if (Rx_PotentialUnwanted.Count() > 0)
                            {
                                for (Rx_PotentialUnwanted.OpenRs(); !Rx_PotentialUnwanted.IsEOF(); Rx_PotentialUnwanted.MoveNext())
                                {
                                    UnwantedRxStationIds.Add(Rx_PotentialUnwanted.m_allsta_id);
                                }
                            }

                            //Search for potential Unwanted Tx stations based on Frequency limits
                            YAllTxrxFreq Tx_PotentialUnwanted = new YAllTxrxFreq();
                            Tx_PotentialUnwanted.Format(FormatAllTxRxFreq);
                            Tx_PotentialUnwanted.Filter =
                                $"(([TX_FREQ]/1000 - ([TX_BW] * {Ln} / 2) >= {RxLowerLimit} AND [TX_FREQ]/1000 - ([TX_BW] * {Ln} / 2) <= {RxUpperLimit})" +
                                $"OR " +
                                $"([TX_FREQ]/1000 + ([TX_BW] * {Ln} / 2) <= {RxUpperLimit} AND [TX_FREQ]/1000 + ([TX_BW] * {Ln} / 2) >= {RxLowerLimit}))";

                            if (Tx_PotentialUnwanted.Count() > 0)
                            {
                                for (Tx_PotentialUnwanted.OpenRs(); !Tx_PotentialUnwanted.IsEOF(); Tx_PotentialUnwanted.MoveNext())
                                {
                                    UnwantedTxStationIds.Add(Tx_PotentialUnwanted.m_allsta_id);
                                }
                            }
                        }
                        else if (WantedStations.m_plan_id != Null.I) // no freq assigned but there is a Freq_Plan
                        {
                            double PlanLowerLimit = WantedStations.m_Plan.m_lower_freq - (WantedStations.m_tx_bw.Max(WantedStations.m_rx_bw));
                            double PlanUpperLimit = WantedStations.m_Plan.m_lower_freq + (WantedStations.m_tx_bw.Max(WantedStations.m_rx_bw));

                            //Search for potential Unwanted Rx stations based on Frequency limits
                            YAllTxrxFreq Rx_PotentialUnwanted = new YAllTxrxFreq();
                            Rx_PotentialUnwanted.Format(FormatAllTxRxFreq);
                            Rx_PotentialUnwanted.Filter =
                                $"(([RX_FREQ]/1000 - ([RX_BW] * {Ln} / 2) >= {PlanLowerLimit} AND [RX_FREQ]/1000 - ([RX_BW] * {Ln} / 2) <= {PlanUpperLimit})" +
                                $"OR " +
                                $"([RX_FREQ]/1000 + ([RX_BW] * {Ln} / 2) <= {PlanUpperLimit} AND [RX_FREQ]/1000 + ([RX_BW] * {Ln} / 2) >= {PlanLowerLimit}))";

                            if (Rx_PotentialUnwanted.Count() > 0)
                            {
                                for (Rx_PotentialUnwanted.OpenRs(); !Rx_PotentialUnwanted.IsEOF(); Rx_PotentialUnwanted.MoveNext())
                                {
                                    UnwantedRxStationIds.Add(Rx_PotentialUnwanted.m_allsta_id);
                                }
                            }

                            //Search for potential Unwanted Tx stations based on Frequency limits
                            YAllTxrxFreq Tx_PotentialUnwanted = new YAllTxrxFreq();
                            Tx_PotentialUnwanted.Format(FormatAllTxRxFreq);
                            Tx_PotentialUnwanted.Filter =
                                $"(([TX_FREQ]/1000 - ([TX_BW] * {Ln} / 2) >= {PlanLowerLimit} AND [TX_FREQ]/1000 - ([TX_BW] * {Ln} / 2) <= {PlanUpperLimit})" +
                                $"OR " +
                                $"([TX_FREQ]/1000 + ([TX_BW] * {Ln} / 2) <= {PlanUpperLimit} AND [TX_FREQ]/1000 + ([TX_BW] * {Ln} / 2) >= {PlanLowerLimit}))";

                            if (Tx_PotentialUnwanted.Count() > 0)
                            {
                                for (Tx_PotentialUnwanted.OpenRs(); !Tx_PotentialUnwanted.IsEOF(); Tx_PotentialUnwanted.MoveNext())
                                {
                                    UnwantedTxStationIds.Add(Tx_PotentialUnwanted.m_allsta_id);
                                }
                            }
                        }
                        else if (1 != 1) //TODO: this section will handle equipments if there is no plan nor frequencies
                        { }
                        else //no way to handle this station 
                        { FailedUnwantedStationIds.Add(WantedStations.m_allsta_id); } 
                    }

                    //Step 2: Exlcude Unwanted Rx Stations and Unwanted Tx Stations based on geo filtering
                    YAllTxrxFreq All_Tx_PotentialUnwanted = new YAllTxrxFreq();
                    All_Tx_PotentialUnwanted.Format(FormatAllTxRxFreq);
                    All_Tx_PotentialUnwanted.Filter = $"[ALLSTA_ID] IN ({UnwantedTxStationIds.ToCsvString()})";

                    YAllTxrxFreq All_Rx_PotentialUnwanted = new YAllTxrxFreq();
                    All_Rx_PotentialUnwanted.Format(FormatAllTxRxFreq);
                    All_Rx_PotentialUnwanted.Filter = $"[ALLSTA_ID] IN ({UnwantedRxStationIds.ToCsvString()})";

                    for (WantedStations.OpenRs(); !WantedStations.IsEOF(); WantedStations.MoveNext())
                    {
                        PolygonEtudeExt PolyWanted = new PolygonEtudeExt();
                        ComputePolygonEtude(WantedStations, ref PolyWanted);

                        for (All_Tx_PotentialUnwanted.OpenRs(); !All_Tx_PotentialUnwanted.IsEOF(); All_Tx_PotentialUnwanted.MoveNext())
                        {
                            PolygonEtudeExt PolyTxUnwanted = new PolygonEtudeExt();
                            ComputePolygonEtude(All_Tx_PotentialUnwanted, ref PolyTxUnwanted);
                            if (!PolyTxUnwanted.Intersects(PolyWanted)) UnwantedTxStationIds.Remove(All_Tx_PotentialUnwanted.m_allsta_id);
                        }

                        for (All_Rx_PotentialUnwanted.OpenRs(); !All_Rx_PotentialUnwanted.IsEOF(); All_Rx_PotentialUnwanted.MoveNext())
                        {
                            PolygonEtudeExt PolyRxUnwanted = new PolygonEtudeExt();
                            ComputePolygonEtude(All_Rx_PotentialUnwanted, ref PolyRxUnwanted);
                            if (!PolyRxUnwanted.Intersects(PolyWanted)) UnwantedTxStationIds.Remove(All_Rx_PotentialUnwanted.m_allsta_id);
                        }
                    }

                    //Step 3: Return Results


                }
            }
            
        }

        private void ComputePolygonEtude(YAllTxrxFreq Station, ref PolygonEtudeExt PolyEdtude)
        {
            if (ComputingHorizon.Checked) //Radio Horizon
            {
                if (Station.m_points != "")
                { PolyEdtude.CalculeVisibiliteRadioPolygone(Station.m_points, Station.m_csys, Station.m_agl); }
                else if (Station.m_radius != Null.D)
                { PolyEdtude.CalculeVisibiliteRadioCercle(Station.m_x, Station.m_y, Station.m_csys, Station.m_radius, Station.m_agl); }
                else
                { PolyEdtude.CalculeVisibiliteRadioPoint(Station.m_x, Station.m_y, Station.m_csys, Station.m_asl, Station.m_agl); }
            }
            else //Free Space Loss contouring
            {
                List<AzimAtten> pattern = AzimAtten.LoadPattern(Station.Table, Station.m_table_id);
                double F = Station.m_rx_freq.Max(Station.m_tx_freq);

                //double Seuil = Station.m_high_sensitivity < Null.D ? Station.m_high_sensitivity : Station.m_sensitivity;
                double Seuil = Null.D; //while data is not yet in the YAllTxRxFreq Query
                if (Seuil == Null.D) { Seuil = DefaultKtbf.Value; }
                double range = (299.792 / F) / (4 * Math.PI) * Math.Pow(10, (Station.m_eirp - 30 - Seuil) / 20) / 1000;//en Km

                if (Station.m_points != "")
                { PolyEdtude.CalculeCouverturePolygone(Station.m_points, Station.m_csys, pattern, range); }
                else if (Station.m_radius != Null.D)
                { PolyEdtude.CalculeCouvertureCercle(Station.m_x, Station.m_y, Station.m_csys, Station.m_radius, pattern, range); }
                else
                { PolyEdtude.CalculeCouverturePoint(Station.m_x, Station.m_y, Station.m_csys, pattern, range); }
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
            IcsmBag BagWanted = new IcsmBag("ALL_TXRX_FREQ");
            BagWanted.Create(title, "Wanted Mob_Station");

            List<int> ListID = new List<int>();
            Yyy YTable = new Yyy(); YTable.Table = ct.TableName;
            YTable.Filter = ct.DataList.GetOQLFilter(true);
            for (YTable.OpenRs(); !YTable.IsEOF(); YTable.MoveNext())
            {
                ListID.Add(YTable.Get("ID").ToString().ParseInt());
            }

                
            DbListWanted.Filter = $"[ID] IN ({ListID.ToCsvString()})";
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
                /*if (BagUWantedMobSta.GetCount() > 0) { Allbags.Add(BagUWantedMobSta.Bag.Rec); }
                if (BagUWantedMobSta2.GetCount() > 0) { Allbags.Add(BagUWantedMobSta2.Bag.Rec); }
                if (BagUWantedMwa.GetCount() > 0) { Allbags.Add(BagUWantedMwa.Bag.Rec); }
                if (BagUWantedSfaf.GetCount() > 0) { Allbags.Add(BagUWantedSfaf.Bag.Rec); }*/

                IM.ExportToEWX(ref title, toHTZ, Allbags.ToArray());
            }
        }
        private void ClearBags()
        {
            /*if (BagUWantedMobSta2.Bag != null) OrmSchema.Linker.Execute("DELETE FROM %{0} WHERE ID={1}".Fmt(BagUWantedMobSta2.Bag.Table, BagUWantedMobSta2.Bag.m_id));
            if (BagUWantedMobSta.Bag != null) OrmSchema.Linker.Execute("DELETE FROM %{0} WHERE ID={1}".Fmt(BagUWantedMobSta.Bag.Table, BagUWantedMobSta.Bag.m_id));
            if (BagUWantedMwa.Bag != null) OrmSchema.Linker.Execute("DELETE FROM %{0} WHERE ID={1}".Fmt(BagUWantedMwa.Bag.Table, BagUWantedMwa.Bag.m_id));
            if (BagUWantedSfaf.Bag != null) OrmSchema.Linker.Execute("DELETE FROM %{0} WHERE ID={1}".Fmt(BagUWantedSfaf.Bag.Table, BagUWantedSfaf.Bag.m_id));*/
            if (BagWanted.Bag != null) OrmSchema.Linker.Execute("DELETE FROM %{0} WHERE ID={1}".Fmt(BagWanted.Bag.Table, BagWanted.Bag.m_id));
        }
    }
}


