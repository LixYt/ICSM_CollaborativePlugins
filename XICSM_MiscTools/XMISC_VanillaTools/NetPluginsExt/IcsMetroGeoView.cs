using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using OrmCs;
using System.Windows.Forms;
using ICSM;
using DatalayerCs;
using System.IO.Compression;
using System.IO;
using FormsCs;
using NetPlugins2;
using XICSM.MiscTools;
using Transmitters2 = NetPlugins2.Transmitters;
using StationN2 = NetPlugins2.StationN;

namespace NetPlugins2Ext
{
    public partial class IcsMetroGeoView : IcsMetroUserControl
    {
        //To Do : Differents ways to dispay the control (Classic / Tab Control / H or V splitted)
        [Category("A_Ics")]
        [Description("Query Config Name")]
        public string ConfigName;

        private Transmitters2 tp= new Transmitters2(); //Sites
        private Transmitters2 tpFix = new Transmitters2(); //Microwa
        private Transmitters2 tpMob = new Transmitters2();  //MobSta(2)
        private Transmitters2 tpSat = new Transmitters2();  //EarthSta
        private Transmitters2 tpGsm = new Transmitters2(); //Gsm
        private Transmitters2 tpBoat = new Transmitters2(); //Boat
        private Transmitters2 tpBroadCast = new Transmitters2(); //Broadcast
        private Transmitters2 tpOther = new Transmitters2(); // default
        private Transmitters2 tpWarfare = new Transmitters2();  //SFAF
        private Transmitters2 tpNato = new Transmitters2(); //empty for now

        private Transmitters2 tpDeactivated = new Transmitters2(); //Deactivated

        bool isLoaded = false;
        bool firstRun = true; //used to provid              requery to display data on first load of the form


        #region Form Methods
        public IcsMetroGeoView()
        {
            InitializeComponent();
        }
        private void IcsMetroGeoView_Load(object sender, EventArgs e)
        {
            if (ConfigName == "" || ConfigName == null) { ConfigName = "Default_"; }
            #region Register Map Layers
            Map.RegisterVectorLayer(tp);
            Map.RegisterVectorLayer(tpFix);
            Map.RegisterVectorLayer(tpMob);
            Map.RegisterVectorLayer(tpSat);
            Map.RegisterVectorLayer(tpGsm);
            Map.RegisterVectorLayer(tpBoat);
            Map.RegisterVectorLayer(tpBroadCast);
            Map.RegisterVectorLayer(tpOther);
            Map.RegisterVectorLayer(tpWarfare);
            Map.RegisterVectorLayer(tpDeactivated);
             
            #endregion
            SetTransmittersSettings();
            #region Set objects titles
            setName("Site name", tp);
            setName("Site name", tpFix);
            setName("Site name", tpMob);
            setName("Site name", tpSat);
            setName("Site name", tpGsm);
            setName("Site name", tpBoat);
            setName("Site name", tpBroadCast);
            setName("Site name", tpOther);
            setName("Site name", tpWarfare);
            setName("Site name", tpDeactivated);
            #endregion
            #region UpdateMarkersStyle
            UpdateMarkersStyle(tp);
            UpdateMarkersStyle(tpFix);
            UpdateMarkersStyle(tpMob);
            UpdateMarkersStyle(tpSat);
            UpdateMarkersStyle(tpGsm);
            UpdateMarkersStyle(tpBoat);
            UpdateMarkersStyle(tpBroadCast);
            UpdateMarkersStyle(tpOther);
            UpdateMarkersStyle(tpWarfare);
            UpdateMarkersStyle(tpDeactivated);
            #endregion
            #region DbList init
            DbListSites.Table = "ALL_POSITIONS"; 
            DbListSites.ConfigName = ConfigName+"DbListSelector-ALL_SITES";
            DbListSites.Init();

            DbListStations.Table = "ALL_STATIONS";
            DbListStations.ConfigName = ConfigName+"DbListSelector-ALL_STATIONS";
            DbListStations.Init();

            DbListLinks.Table = "MICROWA";
            DbListLinks.ConfigName = ConfigName+"DbListSelector-ALL_LINKS";
            DbListLinks.Init();
            #endregion
            //refresh 
            DisplayManager();
        }
        private void IcsMetroGeoView_Resize(object sender, EventArgs e)
        {
            DisplayManager();
        }
        private void QuerySelectorMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayManager();
        }        
        public static void Open(string manualConfigName="")
        {
            IcsMetroForm f = new IcsMetroForm();
            IcsMetroGeoView g = new IcsMetroGeoView();
            if (manualConfigName != "") { g.ConfigName = manualConfigName; }
            g.Dock = DockStyle.Fill;
            f.Controls.Add(g);
            f.ShowDialog();
        }
        #endregion

        #region Buttons/Controls
        private void Links_Click(object sender, EventArgs e)
        {
            IcsMetroDbListSelector l = new IcsMetroDbListSelector("MICROWA");
            if (l.ShowDialog() == DialogResult.OK)
            {
                Load_Links(l.ResultFilter);
            }
        }
        private void All_Sites_Click(object sender, EventArgs e)
        {
            IcsMetroDbListSelector l = new IcsMetroDbListSelector("ALL_POSITIONS");
            if (l.ShowDialog() == DialogResult.OK)
            {
                Load_Sites(l.ResultFilter);
            }
        }
        private void AllStations_Click(object sender, EventArgs e)
        {
            IcsMetroDbListSelector l = new IcsMetroDbListSelector("ALL_STATIONS");
            if (l.ShowDialog() == DialogResult.OK)
            {
                Load_Stations(l.ResultFilter);
            }

        }
        private void ClearMap_Click(object sender, EventArgs e)
        {
            UpdateAllTransmitters(null);
        }
        private void ToMap_Click(object sender, EventArgs e)
        {
            List<Transmitters2> ltps = new List<Transmitters2>();
            ltps.Add(tp); ltps.Add(tpFix); ltps.Add(tpMob); ltps.Add(tpSat); ltps.Add(tpGsm); ltps.Add(tpBoat);
            ltps.Add(tpBroadCast); ltps.Add(tpOther); ltps.Add(tpWarfare); ltps.Add(tpNato); ltps.Add(tpDeactivated);

            List<IcsmBag> LIcsmBag = new List<IcsmBag>();
            int i = 1;
            foreach( Transmitters2 t in ltps)
            {
                foreach(string key in t.Stns.Keys)
                {
                    string table = key.Split('.')[0];
                    string id = key.Split('.')[1];

                    IcsmBag Bag = new IcsmBag(table);
                    Bag.Create("GeoView Layer {0}".Fmt(t.Ident), "");

                    LIcsmBag.Add(Bag);

                }
                i++;
            }

            List<RecPtr> Allbags = new List<RecPtr>();
            foreach(IcsmBag b in LIcsmBag)  { Allbags.Add(b.Bag.Rec); }

            string x = "c:\\tmp.XML";
            IM.ExportToEWX(ref x, true, Allbags.ToArray());
        }
        private void ForceRefresh_Click(object sender, EventArgs e)
        {
            firstRun = false;
            DbListSites.Requery();
        }
        private void QueryPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResizeSplitScreen();
        }
        #endregion

        #region Right Click options
        //Right Click event
        private void Map_OnMapClicked(object sender, MapClickedEventArgs e)
        {
            if (e.features == "") return;

            ContextMenu menu = new ContextMenu();
            foreach (string key in e.features.Split('|'))
            {
                string[] keyElements = key.Split('.');
                string name = GetStation(key).name;
                MenuItem menuItem = new MenuItem(keyElements[0] + " ID=" + keyElements[1] + " ({0})".Fmt(name));
                foreach (MenuItem mi in subMenu(key))
                {
                    menuItem.MenuItems.Add(mi);
                }
                menu.MenuItems.Add(menuItem);
            }
            menu.Show(Map, (new Point(e.x, e.y)));
        }
        //Right Click menu items
        private List<MenuItem> subMenu(string key)
        {
            Transmitters2 tTest = LocateStation(key);
            string Table = key.Split('.')[0];
            List<MenuItem> menu = new List<MenuItem>(); MenuItem Remove = new MenuItem("Remove");
            
            MenuItem edit = new MenuItem(L.Txt("Edit Record"));
            edit.Name = "edit-" + key; edit.Click += OpenRecord;
            MenuItem isolate = new MenuItem(L.Txt("Isolate"));
            isolate.Name = "isolate-" + key; isolate.Click += IsolateObj;
            MenuItem ExportToIcsT = new MenuItem(L.Txt("Export to ICS Telecom Map"));
            ExportToIcsT.Name = "ToMap-" + key; //ExportToIcsT.Click += SearchInterfOnThisItem;
            MenuItem clearAllButThis = new MenuItem(L.Txt("Clear all except this one"));
            clearAllButThis.Name = "clearAllButThis-" + key; clearAllButThis.Click += KeepThisLink;
            if (tTest != tp && tTest != tpDeactivated && !Table.Contains("SITE") && !Table.Contains("POSITION"))
            {
                MenuItem RemoveThisLink = new MenuItem(L.Txt("Remove this Link"));
                RemoveThisLink.Name = "RemoveThisLink-" + key; RemoveThisLink.Click += RemoveLink;
                Remove.MenuItems.Add(RemoveThisLink);
            }
            MenuItem RemoveThisObject = new MenuItem(L.Txt("Remove this object"));
            RemoveThisObject.Name = "RemoveThisObject-" + key; RemoveThisObject.Click += RemoveObj;
            Remove.MenuItems.Add(RemoveThisObject);
            MenuItem RemoveThisSameName = new MenuItem(L.Txt("Remove all object with same name"));
            RemoveThisSameName.Name = "RemoveThisSameName-" + key; RemoveThisSameName.Click += RemoveObjByName;
            Remove.MenuItems.Add(RemoveThisSameName);
            
            if (tTest == tpDeactivated)
            {
                MenuItem Reactivate = new MenuItem(L.Txt("Reactivate"));
                Reactivate.Name = "Reactivate-" + key; Reactivate.Click += ReactivateItem;
                menu.Add(Reactivate);
            }
            if (tTest != tp && tTest != tpDeactivated && !Table.Contains("SITE") && !Table.Contains("POSITION") )
            {
                MenuItem Reactivate = new MenuItem(L.Txt("Display Covergage"));
                Reactivate.Name = "Coverage-" + key; Reactivate.Click += DisplayCoverage;
                menu.Add(Reactivate);
            }

            if (Table == "MOB_STATION" || Table == "MOB_STATION2" || Table == "MICROWA" || Table == "MICROWS")
            {
                MenuItem searchInterf = new MenuItem(L.Txt("Search for potential interferer"));
                searchInterf.Name = "searchInterf-" + key; searchInterf.Click += SearchInterfOnThisItem;
                menu.Add(searchInterf);
            }

            menu.Add(edit);
            menu.Add(isolate);
            menu.Add(clearAllButThis);
            menu.Add(Remove);
            return menu;
        }
        //Right Click menu item clicked events
        private void SearchInterfOnThisItem(object sender, EventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            string key = mi.Name.Split('-')[1];
            if (key.Split('.')[0] == "MICROWS")
            {
                YMicrows sta = new YMicrows(); sta.Fetch(int.Parse(key.Split('.')[1]));
                SearchInterf.builder("[ID]={0}".Fmt(sta.m_mw_id), "MICROWA");
            }
            else { SearchInterf.builder("[ID]=" + key.Split('.')[1], key.Split('.')[0]); }
            
        }
        private void ReactivateItem(object sender, EventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            string key = mi.Name.Split('-')[1];
            ReactivateObject(key);
        }
        private void DisplayCoverage(object sender, EventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            string key = mi.Name.Split('-')[1];
            DisplayStationCoverage(key);
        }
        private void OpenRecord(object sender, EventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            string[] key = mi.Name.Split('-')[1].Split('.');

            RecordPtr a = new RecordPtr(key[0], int.Parse(key[1]));
            a.UserEdit(this.Handle);
        }
        private void RemoveLink(object sender, EventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            string k = mi.Name.Split('-')[1];
            DeleteLink(k);
        }
        private void RemoveObj(object sender, EventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            string k = mi.Name.Split('-')[1];
            DeleteObject(k);
        }
        private void RemoveObjByName(object sender, EventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            string k = mi.Name.Split('-')[1];
            DeleteByName(k);
        }
        private void KeepThisLink(object sender, EventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            string k = mi.Name.Split('-')[1];
            DeleteAllButThisLink(k);
        }
        private void IsolateObj(object sender, EventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            string k = mi.Name.Split('-')[1];
            Isolate(k);
        }
        private void ReactivateObject(string key)
        {
             Transmitters2 tSource = LocateStation(key);
             Transmitters2 tDest = tSource.Stns[key].SourceTransmitter;
            tDest.Stns.Add(key, tSource.Stns[key]);
            tSource.Stns.Remove(key);
            tDest.FeatureNeedsUpdating(key);
            tSource.FeatureNeedsUpdating(key);
        }
        private void DeleteLink(string key)
        {
            string[] Key = key.Split('.');

             Transmitters2 t = LocateStation(key);
            if (t != null)
            {
                if (t.Stns[key].RelatedLinkKey != "" && t.Stns[key].RelatedLinkKey != null)
                {
                    string kTmp = t.Stns[key].RelatedLinkKey;
                    DeleteLink(kTmp);
                }

                 Transmitters2 t2 = LocateStation(key);
                if (t2 == null) return;
                if (t.Stns[key].RelatedStationKeys.Count > 0)
                {
                    foreach (string k in t.Stns[key].RelatedStationKeys)
                    {
                        t.Stns.Remove(k);
                        t.FeatureNeedsUpdating(k);
                    }
                    t.Stns.Remove(key);
                    t.FeatureNeedsUpdating(key);
                }
            }
        }
        private void DeleteObject(string key)
        {
            string[] Key = key.Split('.');

             Transmitters2 t = LocateStation(key);
            t.Stns.Remove(key);
            t.FeatureNeedsUpdating(key);
        }
        private void DeleteByName(string key)
        {
            string[] Key = key.Split('.');
            string name = "";
             Transmitters2 t = LocateStation(key);
            if (t != null)
            {
                name = t.Stns[key].name;
                List<string> keys = LocateStations(name);
                foreach (string k in keys)
                {
                    DeleteObject(k);
                    t.FeatureNeedsUpdating(k);
                }
            }
        }
        private void DeleteAllButThisLink(string key)
        {
            string[] Key = key.Split('.');

             Transmitters2 t = LocateStation(key);
            if (t != null)
            {
                List<string> KeysToBeKept = new List<string>();
                KeysToBeKept = t.Stns[key].RelatedStationKeys;
                if (t.Stns[key].RelatedLinkKey != "" && t.Stns[key].RelatedStationKeys.Count > 0)
                {
                    if (t.Stns[key].RelatedLinkKey == null) { KeysToBeKept.Add(key); }
                    else { KeysToBeKept.Add(t.Stns[key].RelatedLinkKey); }
                }

                UpdateAllTransmitters(KeysToBeKept);
            }
        }
        private void Isolate(string key)
        {
            string[] Key = key.Split('.');

             Transmitters2 t = LocateStation(key);
            if (t != null)
            {
                List<string> KeysToBeKept = new List<string>();
                KeysToBeKept.Add(key);
                KeysToBeKept = t.Stns[key].RelatedStationKeys;
                if (t.Stns[key].RelatedLinkKey != "" && t.Stns[key].RelatedStationKeys.Count > 0)
                {
                    if (t.Stns[key].RelatedLinkKey == null) { KeysToBeKept.Add(key); }
                    else { KeysToBeKept.Add(t.Stns[key].RelatedLinkKey); }
                }

                MoveAllTransmitters(tpDeactivated, KeysToBeKept);
                
            }
        }
        private void DisplayStationCoverage(string key)
        {
            string[] Key = key.Split('.');
            string Table = Key[0]; int ID = int.Parse(Key[1]);

            Yyy y = Yyy.CreateObject(Table); y.LoadWithComponents2(ID);
            string dataId = y.Get("ID").ToString(); string dataTable = y.Table;
            YIcstData c = new YIcstData(); c.format2("*");
            c.Fetch("[OBJ_TBID]={0} AND [OBJ_TBNM]='{1}'".Fmt(dataId, dataTable));
            int count = c.Count();
            if (count == 0)
            {
                IcsMetroMessageBox.Show(L.Txt("No coverage found"));
            }
            else if (count == 1)
            {
                ANetDb db = OrmSchema.Linker.GetDb("ICST_DATA");
                ANetRs rs = null;
                try
                {
                    rs = db.NewRecordset();
                    string sql = "SELECT ICS_VALUE FROM %ICST_DATA WHERE OBJ_TBID={0} AND OBJ_TBNM='{1}'".Fmt(ID, Table);
                    string sql2 = db.TranslateExpr(sql, OrmSchema.Linker.TranslateTable);
                    rs.Open(sql2);
                    byte[] binarch = null;
                    string decompStr = "";
                    if (!rs.IsEOF())
                    {
                        if (binarch != null || binarch.Length != 0)
                        {

                        
                        }
                    }
                }
                finally { if (rs != null) rs.Destroy(); }
            }
            else
            {
                IcsMetroMessageBox.Show(L.Txt("{0} coverages found").Fmt(count.ToString()));
            }
        }

       
        #endregion

        #region Load data methods
        private void Load_Sites(string filter)
        {
            List<string> CurrStations = new List<string>();
            int i = 0;
            
            YAllPositions yAllP = new YAllPositions();
            yAllP.format2("*");
            yAllP.Filter = filter;
            int c = yAllP.Count(true);

            if (c > 50)
            {
                IMProgress.Create(L.Txt("Loading positions"));
                IMProgress.ShowProgress(i, c);
            }

            for (yAllP.OpenRs(); !yAllP.IsEOF(); yAllP.MoveNext())
            {
                i++;
                CurrStations.Add(tp.UpdatePosition(yAllP));
                IMProgress.ShowProgress(i, c);
            }

            //remove station no more in the query
            if (ClearOrAdd.Checked) { UpdateAllTransmitters(CurrStations); }


            isLoaded = true;
            firstRun = false;
            IMProgress.Destroy();
        }
        private void Load_Stations(string filter)
        {
            List<string> CurrStations = new List<string>();
            int i = 0;
            
            YAllStations yAllP = new YAllStations();
            yAllP.format2("*");
            yAllP.Filter = filter;
            int c = yAllP.Count();

            IMProgress.Create(L.Txt("Loading stations"));
            IMProgress.ShowProgress(i, c);

            for (yAllP.OpenRs(); !yAllP.IsEOF(); yAllP.MoveNext())
            {
                i++;
                string key = "";
                switch (yAllP.m_table_name)
                {
                    case "EARTH_STATION":
                        key = tpSat.LoadFromAllStation(yAllP.m_table_id, yAllP.m_table_name);
                        break;
                    case "MOB_STATION":
                    case "MOB_STATION2":
                    case "PMR_FREQ":
                    case "MOB_ASSIGN":
                    case "WIEN_COORD_MOB":
                        key = tpMob.LoadFromAllStation(yAllP.m_table_id, yAllP.m_table_name);
                        break;
                    case "MICROWA":
                    case "MICROWS":
                        key = tpFix.LoadFromAllStation(yAllP.m_table_id, yAllP.m_table_name);
                        break;
                    case "SFAF":
                    case "SFAF_TX":
                    case "SFAF_RX":
                        key = tpWarfare.LoadFromAllStation(yAllP.m_table_id, yAllP.m_table_name);
                        break;
                    case "S4_STATION":
                    case "S4_ANTENNA":
                    case "S4_FREQ":
                    case "S4_LINK":
                        key = tpNato.LoadFromAllStation(yAllP.m_table_id, yAllP.m_table_name);
                        break;  
                    case "GSM":
                        key = tpGsm.LoadFromAllStation(yAllP.m_table_id, yAllP.m_table_name);
                        break;
                    case "T15":
                        key = tpBoat.LoadFromAllStation(yAllP.m_table_id, yAllP.m_table_name);
                        break;
                    case "ANFR":
                        key = tp.LoadFromAllStation(yAllP.m_table_id, yAllP.m_table_name);
                        break;
                    case "HF":
                    case "TV_STATION":
                    case "TDAB_STATION":
                    case "FMTV_STATION":
                    case "FM_STATION":
                    case "DVBT_STATION":
                        key = tpBroadCast.LoadFromAllStation(yAllP.m_table_id, yAllP.m_table_name);
                        break;
                    default:
                        key = tpOther.LoadFromAllStation(yAllP.m_table_id, yAllP.m_table_name);
                        break;
                }

                CurrStations.Add(key);
                IMProgress.ShowProgress(i, c);
            }

            //remove station no more in the query
            if (ClearOrAdd.Checked) { UpdateAllTransmitters(CurrStations); }

            isLoaded = true;
            firstRun = false;
            IMProgress.Destroy();
        }
        private void Load_Links(string filter)
        {
            List<string> CurrStations = new List<string>();
            int i = 0;
            YMicrowa yAllP = new YMicrowa();
            yAllP.format2("ID,NAME," +
                "StationA(ID,TABLE_NAME,Position(ID,TABLE_NAME))," +
                "StationB(ID,TABLE_NAME,Position(ID,TABLE_NAME))," +
                "StationPa(ID,TABLE_NAME,Position(ID,TABLE_NAME))," +
                "StationPb(ID,TABLE_NAME,Position(ID,TABLE_NAME))");
            yAllP.Filter = filter;
            int c = yAllP.Count();

            {
                IMProgress.Create(L.Txt("Loading links"));
                IMProgress.ShowProgress(i, c);
            }

            for (yAllP.OpenRs(); !yAllP.IsEOF(); yAllP.MoveNext())
            {
                i++;
                List<string> s = tpFix.LoadMwLink(yAllP.m_id, yAllP.Table, yAllP);
                CurrStations = CurrStations.Concat(s).ToList();
                IMProgress.ShowProgress(i, c);
            }
            IMProgress.Destroy();

            //remove station no more in the query
            if (ClearOrAdd.Checked) { UpdateAllTransmitters(CurrStations); }

            isLoaded = true;
            firstRun = false;
            IMProgress.Destroy();
        }
        #endregion

        #region Transmitters/Stations tools

        private void SetTransmittersSettings()
        {//If Images are missing, a lot of JS errors happens. Maybe a way to fix this issue ??? (ex : testing before declaration in C# ?)


            // Violet for Positions
            tp.StStroke.color = "rgba(161,0,255,1)"; tp.StFill.color = "rgba(161,0,255,0.02)";
            tp.StImage.fill.color = "rgba(161,0,255,0.02)"; tp.StImage.type = "position";
            
            // Violet for Boat
            tpBoat.StStroke.color = "rgba(161,0,255,1)"; tpBoat.StFill.color = "rgba(161,0,255,0.02)";
            tpBoat.StImage.fill.color = "rgba(161,0,255,0.02)"; tpBoat.StImage.type = "boat";
            //Dark Cyan for Sat
            tpSat.StStroke.color = "rgba(84,163,157,1)"; tpSat.StFill.color = "rgba(84,163,157,0.02)";
            tpSat.StImage.fill.color = "rgba(84,163,157,0.02)"; tpSat.StImage.type = "sat";
            //Bleu for Microwaves
            tpFix.StStroke.color = "Blue"; tpFix.StFill.color = "rgba(0, 0, 255, 0)";
            tpFix.StImage.fill.color = "rgba(0, 0, 255, 1)"; tpFix.StImage.type = "microws";
            //Vert for Mobile
            tpMob.StStroke.color = "rgba(0,255,0,1)"; tpMob.StFill.color = "rgba(0,255,0,0.02)";
            tpMob.StImage.fill.color = "rgba(0,255,0,0.02)"; tpMob.StImage.type = "mobile";
            //Vert for Gsm
            tpGsm.StStroke.color = "rgba(0,255,0,1)"; tpGsm.StFill.color = "rgba(0,255,0,0.02)";
            tpGsm.StImage.fill.color = "rgba(0,255,0,0.02)"; tpGsm.StImage.type = "gsm";
            //Rouge for Fix
            tpOther.StStroke.color = "Red"; tpOther.StFill.color = "rgba(255, 0, 0, 0)";
            tpOther.StImage.fill.color = "rgba(255, 0, 0, 1)"; tpOther.StImage.type = "fix";
            //Rouge for Broadcast
            tpBroadCast.StStroke.color = "Red"; tpBroadCast.StFill.color = "rgba(255, 0, 0, 0)";
            tpBroadCast.StImage.fill.color = "rgba(255, 0, 0, 1)"; tpBroadCast.StImage.type = "broadcast";
            //Orange for Military Warfare
            tpWarfare.StStroke.color = "rgba(255,148,0,1)"; tpWarfare.StFill.color = "rgba(255,148,0,1)";
            tpWarfare.StImage.fill.color = "rgba(255,148,0,1)"; tpWarfare.StImage.type = "warfare";
            //Orange for Military NATO
            tpNato.StStroke.color = "rgba(255,148,0,1)"; tpNato.StFill.color = "rgba(255,148,0,1)";
            tpNato.StImage.fill.color = "rgba(255,148,0,1)"; tpNato.StImage.type = "nato";

            //Black for Deactivated items
            tpDeactivated.StStroke.color = "rgba(0,0,0,1)"; tpNato.StFill.color = "rgba(0,0,0,1)";
            tpDeactivated.StImage.fill.color = "rgba(0,0,0,0.02)"; tpDeactivated.StImage.type = "crux";

        }
        private void ClearTransmitters()
        {
            tp.Stns.Clear();
            tpFix.Stns.Clear();  
            tpMob.Stns.Clear();   
            tpSat.Stns.Clear();   
            tpGsm.Stns.Clear();   
            tpBoat.Stns.Clear();
            tpBroadCast.Stns.Clear(); 
            tpWarfare.Stns.Clear();  
            tpNato.Stns.Clear();  
            tpDeactivated.Stns.Clear();
            
        }
        private StationN2 GetStation(string key)
        {
            List<Transmitters2> ltps = new List<Transmitters2>();
            ltps.Add(tp); ltps.Add(tpFix); ltps.Add(tpMob); ltps.Add(tpSat); ltps.Add(tpGsm); ltps.Add(tpBoat);
            ltps.Add(tpBroadCast); ltps.Add(tpOther); ltps.Add(tpWarfare); ltps.Add(tpNato); ltps.Add(tpDeactivated);

            foreach ( Transmitters2 t in ltps)
            {
                if (t.Stns.ContainsKey(key)) { return t.Stns[key]; }
            }

            return null;
        }
        private void RecalcGrouping(Transmitters2 t)
        {

            setName(t.TypeOfNaming, t);
            if (isLoaded)
            {
                if (tp.TypeOfNaming != "distance")
                {
                    t.Refresh();
                    t.DistinctStation();
                    t.Stns.Clear();

                    foreach (KeyValuePair<int, Dictionary<string, StationN2>> it in t.L_Stns_Distinct)
                    {
                        foreach (KeyValuePair<string, StationN2> iu in it.Value)
                        {
                            if (!t.Stns.ContainsKey(iu.Key))
                            {
                                t.Stns.Add(iu.Key, iu.Value);
                                t.FeatureNeedsUpdating(iu.Key);
                            }
                            break;
                        }
                    }
                    setName("Site name", t);
                }
            }
            //t.Recalc(); 
            //t.Refresh();
            //UpdateMarkersStyle(t);
            //t.DistinctStation();
            //tp.StyleNeedsUpdating();
        }
        private void UpdateMarkersStyle( Transmitters2 t)
        {
            t.StyleNeedsUpdating();
            foreach (KeyValuePair<string, StationN2> item in t.Stns)
            {
                t.FeatureNeedsUpdating(item.Key);
            }
                                     
        }
        void setName(string typNm, Transmitters2 t)
        {
            if (t.TypeOfNaming != typNm)
            {
                t.ChangeName(typNm);
            }
            UpdateMarkersStyle(t);
        }
        private void UpdateTransmitters( Transmitters2 t, List<string> CurrStations)
        {
            if (CurrStations == null) CurrStations = new List<string>();

            List<string> keysToRemove = new List<string>();

            int i = 0; int c = t.Stns.Count();
            IMProgress.Create(L.Txt("Updating map")); IMProgress.ShowProgress(0, c); 
            foreach (KeyValuePair<string, StationN2> item in t.Stns)
            {
                i++;
                IMProgress.ShowProgress(i, c);
                if (!CurrStations.Contains(item.Key)) { keysToRemove.Add(item.Key); }
            }
            c += keysToRemove.Count();
            foreach (string k in keysToRemove)
            {
                i++;
                IMProgress.ShowProgress(i, c);
                t.Stns.Remove(k); t.FeatureNeedsUpdating(k);
            }

            IMProgress.Destroy();
        }
        private void MoveTransmitters( Transmitters2 tSource, List<string> StationsToStayInSource,  Transmitters2 tTarget)
        {
            List<string> keysToMove = new List<string>();

            int i = 0; int c = tSource.Stns.Count();
            IMProgress.Create(L.Txt("Deactivating objects")); IMProgress.ShowProgress(0, c);
            foreach (KeyValuePair<string, StationN2> item in tSource.Stns)
            {
                i++;
                IMProgress.ShowProgress(i, c);
                if (!StationsToStayInSource.Contains(item.Key))
                {
                    if (!tTarget.Stns.ContainsKey(item.Key))
                    {
                        tTarget.Stns.Add(item.Key, item.Value);
                        tTarget.Stns[item.Key].SourceTransmitter = tSource;
                        tTarget.FeatureNeedsUpdating(item.Key);
                    }
                    keysToMove.Add(item.Key);
                }
            }
            c += keysToMove.Count();

            foreach(string k in keysToMove)
            {
                i++;
                tSource.Stns.Remove(k);
                tSource.FeatureNeedsUpdating(k);
                IMProgress.ShowProgress(i, c);
            }
            

            IMProgress.Destroy();
        }
        private void UpdateAllTransmitters(List<string> CurrStations)
        {
            UpdateTransmitters(tp, CurrStations);
            UpdateTransmitters(tpMob, CurrStations);
            UpdateTransmitters(tpFix, CurrStations);
            UpdateTransmitters(tpSat, CurrStations);
            UpdateTransmitters(tpGsm, CurrStations);
            UpdateTransmitters(tpBoat, CurrStations);
            UpdateTransmitters(tpBroadCast, CurrStations);
            UpdateTransmitters(tpWarfare, CurrStations);
            UpdateTransmitters(tpNato, CurrStations);
            UpdateTransmitters(tpOther, CurrStations);
            UpdateTransmitters(tpDeactivated, null);
        }
        private void MoveAllTransmitters( Transmitters2 ToThisTp, List<string> ExeptThisStations)
        {
            MoveTransmitters(tp, ExeptThisStations, ToThisTp);
            MoveTransmitters(tpMob, ExeptThisStations, ToThisTp);
            MoveTransmitters(tpFix, ExeptThisStations, ToThisTp);
            MoveTransmitters(tpSat, ExeptThisStations, ToThisTp);
            MoveTransmitters(tpGsm, ExeptThisStations, ToThisTp);
            MoveTransmitters(tpBoat, ExeptThisStations, ToThisTp);
            MoveTransmitters(tpBroadCast, ExeptThisStations, ToThisTp);
            MoveTransmitters(tpWarfare, ExeptThisStations, ToThisTp);
            MoveTransmitters(tpNato, ExeptThisStations, ToThisTp);
            MoveTransmitters(tpOther, ExeptThisStations, ToThisTp);
        }
        private  Transmitters2 LocateStation(string key)
        {
            List<Transmitters2> ltps = new List<Transmitters2>();
            ltps.Add(tp); ltps.Add(tpFix); ltps.Add(tpMob); ltps.Add(tpSat); ltps.Add(tpGsm); ltps.Add(tpBoat);
            ltps.Add(tpBroadCast); ltps.Add(tpOther); ltps.Add(tpWarfare); ltps.Add(tpNato); ltps.Add(tpDeactivated);

            foreach ( Transmitters2 t in ltps)
            {
                if (t.Stns.ContainsKey(key)) { return t; }
            }

            return null;
        }
        private List<string> LocateStations(string name)
        {
            List<string> keys = new List<string>();
            List<Transmitters2> ltps = new List<Transmitters2>();
            ltps.Add(tp); ltps.Add(tpFix); ltps.Add(tpMob); ltps.Add(tpSat); ltps.Add(tpGsm); ltps.Add(tpBoat);
            ltps.Add(tpBroadCast); ltps.Add(tpOther); ltps.Add(tpWarfare); ltps.Add(tpNato); ltps.Add(tpDeactivated);

            foreach ( Transmitters2 t in ltps)
            {
                foreach(KeyValuePair<string, StationN2> StN in t.Stns)
                {
                    if (StN.Value.name == name)
                    {
                        keys.Add(StN.Value.key);
                    }
                }
            }
            return keys;
        }

        #endregion

        #region Query stuff
        private void DBList_OnDefColumns(object sender, EventArgs e)
        {
            IcsDBList l = (IcsDBList)sender;
            Yyy y = Yyy.CreateObject(l.Table);
            string MustBeIn;
            if (y.IsPresent2("ID")) { MustBeIn = "ID"; }
            else if (y.IsPresent2("TBNM") && y.IsPresent2("TBID")) { MustBeIn = "TBID,TBNM"; }
            else if (y.IsPresent2("OBJ_TBID") && y.IsPresent2("OBJ_TBNM")) { MustBeIn = "TBID,TBNM"; }
            else { return; }
            l.MustBePresent(MustBeIn);
        }

        private void DBList_OnRequery(object sender, EventArgs e)
        {
            if (firstRun) return;

            bool DoSites = (QueryTab.SelectedTab == QueryPageSites && ClearOrAdd.Checked) || !ClearOrAdd.Checked;
            if (DoSites && DbListSites.Filter != "" && DbListSites.GetSelectionAsOQLFilter(false) != "")
            {
                string f = IcsMetroDbListSelector.GenerateGlobalFilter(DbListSites);
                if (f != "") { Load_Sites(f); }
            }

            bool DoStations = (QueryTab.SelectedTab == QueryPageStations && ClearOrAdd.Checked) || !ClearOrAdd.Checked;
            if (DoStations && DbListStations.Filter != "" && DbListStations.GetSelectionAsOQLFilter(false) != "")
            {
                string f = IcsMetroDbListSelector.GenerateGlobalFilter(DbListStations);
                if (f != "") { Load_Stations(f); }
            }

            bool DoLinks = (QueryTab.SelectedTab == QueryPageLinks && ClearOrAdd.Checked) || !ClearOrAdd.Checked;
            if (DoLinks && DbListLinks.Filter != "" && DbListLinks.GetSelectionAsOQLFilter(false) != "")
            {
                string f = IcsMetroDbListSelector.GenerateGlobalFilter(DbListLinks);
                if (f != "") { Load_Links(f); }
            }
        }

        #endregion

        #region display tools
        private void DisplayManager()
        {
            if (Parent != null)
            {
                int w = Parent.Size.Width; int h = Parent.Size.Height;
                if (Parent.Size.Width < MinimumSize.Width) { w = MinimumSize.Width+50; }
                if (Parent.Size.Height < MinimumSize.Height) { h = MinimumSize.Height+50; }
                if (Parent.Size.Width != w && Parent.Size.Height != h) { Parent.MinimumSize = new Size(w, h); }
            }

            if (QuerySelectorMode.Text == "Select items by query windows")
            {
                QuerryButtonVisibility(true); ResizeMapFullSize(); QueryTab.Visible = false;
            }
            else if (QuerySelectorMode.Text == "Select items by query side panel")
            {
                QuerryButtonVisibility(false); ResizeSplitScreen(); QueryTab.Visible = true;
            }
            else { QuerryButtonVisibility(true); ResizeMapFullSize(); QueryTab.Visible = false; }
        }

        private void QuerryButtonVisibility(bool visible)
        {
            Links.Visible = visible;
            All_Sites.Visible = visible;
            AllStations.Visible = visible;
            ForceRefresh.Visible = !visible;
            QueryPosition.Visible = !visible;
            QueryTab.Visible = !visible;
        }
        

        private void ResizeSplitScreen()
        {
            int y = SelectPanel.Location.Y + SelectPanel.Height;
            
            switch (QueryPosition.Text)
            {
                case "Top":
                    QueryTab.Location = new Point(0, y);
                    QueryTab.Size = new Size(Size.Width, (Size.Height - y)/ 2 );
                    Map.Location = new Point(0, y + ((Size.Height - y)/2) );
                    Map.Size = new Size(Size.Width, (Size.Height - y) / 2);
                    break;

                case "Right":
                    QueryTab.Location = new Point(Size.Width / 2 + 1, y);
                    QueryTab.Size = new Size(Size.Width / 2, Size.Height - y);
                    Map.Location = new Point(0, y);
                    Map.Size = new Size(Size.Width / 2, Size.Height - y);
                    break;

                case "Bottom":
                    Map.Location = new Point(0, y);
                    Map.Size = new Size(Size.Width, (Size.Height - y) / 2);
                    QueryTab.Location = new Point(0, y + ((Size.Height - y) / 2));
                    QueryTab.Size = new Size(Size.Width, (Size.Height - y) / 2);
                    break;

                case "Left":
                    Map.Location = new Point(Size.Width / 2 + 1, y);
                    Map.Size = new Size(Size.Width / 2, Size.Height - y);
                    QueryTab.Location = new Point(0, y);
                    QueryTab.Size = new Size(Size.Width / 2, Size.Height - y);
                    break;

                case "":
                default:
                    QueryTab.Location = new Point(Size.Width / 2 + 1, y);
                    QueryTab.Size = new Size(Size.Width / 2, Size.Height - y);
                    Map.Location = new Point(0, y);
                    Map.Size = new Size(Size.Width / 2, Size.Height - y);
                    break;
            }
            
            
        }

        private void ResizeMapFullSize()
        {
            int y = SelectPanel.Location.Y + SelectPanel.Height;
            Map.Location = new Point(0, y);
            Map.Size = new Size(Size.Width, Size.Height - y);
        }
        #endregion

        

        
    }
}

