using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Image2;
using OrmCs;
using ICSM;
using DatalayerCs;

namespace NetPlugins2Ext
{
    public partial class IcsOpenlayers3 : UserControl
    {
        [Category("A_Ics")]
        [Description("Display csys")]
        [DefaultValue("4DMS")]
        public string DisplayCsys { get { return _displayCsys; } set { _displayCsys=value;} }
        string _displayCsys;

        [Category("A_Ics")]
        [Description("Initial longitude 4DEC")]
        [DefaultValue(-4)]
        public double StartLongi { get { return ol3.StartLongi; } set { ol3.StartLongi=value;} }

        [Category("A_Ics")]
        [Description("Initial latitude 4DEC")]
        [DefaultValue(40)]
        public double StartLati { get { return ol3.StartLati; } set { ol3.StartLati=value;} }

        [Category("A_Ics")]
        [Description("Initial zoom")]
        [DefaultValue(6)]
        public int StartZoom { get { return ol3.StartZoom; } set { ol3.StartZoom=value;} }

        [Category("A_Ics")]
        [Description("KMLs: How many to cache")]
        [DefaultValue(10)]
        public int KmlsMaxCached { get { return _KmlsMaxCached;} set{ _KmlsMaxCached=value; } }
        int _KmlsMaxCached;

        [Category("A_Ics")]
        [Description("KMLs: Name of the cache in workspace")]
        [DefaultValue("KMLsDefLst")]
        public string KmlsNameCache { get { return _KmlsNameCache; } set { _KmlsNameCache=value;} }
        string _KmlsNameCache;

        [Category("A_Ics")]
        [Description("On map clicked")]
        public event EventHandler<MapClickedEventArgs> OnMapClicked;
        [Category("A_Ics")]
        [Description("On Rectangle selected")]
        public event EventHandler<RectangleSelectedEventArgs> OnRectangleSelected;

        [Category("A_Ics")]
        [Description("Input type('','Pg','Ci','Re','Pt')")]
        public string InputType { get { return ol3.InputType; } set { ol3.InputType=value;} }
        [Category("A_Ics")]
        [Description("Input mode('','Host','Mouse')")]
        public string InputMode { get { return ol3.InputMode; } set { ol3.InputMode=value;} }
        [Category("A_Ics")]
        [Description("Input geometry: radius(M)")]
        public double InputGeomRadiusM { get { return ol3.InputGeomRadiusM; } set { ol3.InputGeomRadiusM=value;} }
        [Category("A_Ics")]
        [Description("Input geometry: points(4DEC)")]
        public PointF[] InputGeomPoints { 
            get { return _InputGeomPoints; }
            set { _InputGeomPoints=value; ol3.InputGeomPointsJson= Openlayers3.ToJSON(value); } }
        internal PointF[] _InputGeomPoints;
        [Category("A_Ics")]
        [Description("On Input Geometry changed")]
        public event EventHandler OnInputGeometryChanged;


        bool designTime;
        OpenLayers3Wrapper w;
        public IcsOpenlayers3()
        {
            designTime= LicenseManager.UsageMode==LicenseUsageMode.Designtime; //ne marche que dans le constructeur
            _KmlsNameCache= "KMLsDefLst";
            _KmlsMaxCached= 20;
            InitializeComponent();
            if (!designTime) w= new OpenLayers3Wrapper(this);
            ol3= new Openlayers3();
            ol3.ctrl= this; ol3.wb1=wb1;
            ol3.multimaps = new List<AtdiMap>();
            wb1.ObjectForScripting= ol3;
        }
        private Openlayers3 ol3;
        public void DisplayExtent(ExtentJs extentDec)
        {
            ol3.FitExtentRequested= extentDec;
            ol3.FitRequested= true;
        }
        public void CenterOn(double longi4Dec,double lati4Dec)
        {
            if (longi4Dec!=Null.D && lati4Dec!=Null.D) {
                ol3.CenterRequestedLongi= longi4Dec;
                ol3.CenterRequestedLati= lati4Dec;
                ol3.CenterRequested= true;
                }
        }
        public void RegisterMultimap(string mapPath,string palettePath) {
            int i= ol3.multimaps.Count;
            ol3.multimaps.Add(new AtdiMap(mapPath,palettePath));
            if (layerListLoaded)
                layerList.Items.Add(new comboItem("multimap"+i,Path.GetFileName(mapPath)));
            }
        public void RegisterVectorLayer(VecLayer vl) { ol3.RegisterVectorLayer(vl); }
        public void UnregisterLayer(VecLayer vl) { ol3.UnregisterLayer(vl); }

        private void butHelp_Click(object sender, EventArgs e)
        {
            string msg= "ZoomIn: Dblclk -or- Shift+Drag\r\n";
            msg+= "ZoomOut: Shift+DblClk\r\n";
            msg+= "Scroll: Drag\r\n";
            msg+= "AreaSelect: Ctrl+Drag\r\n";
            MessageBox.Show(msg,"Help");
        }
        private List<string> recentKmls;
        private List<string> loadKmlConfig() { return designTime? null : w.loadKmlConfig(); }

        //public void SetKmlList(List<string> paths) {
        //    if (paths==null) paths= new List<string>();
        //    if (kmlListLoaded) {
        //        kmlList.Items.Clear();
        //        kmlList.Items.Add(new comboItem(null,"<No KML>"));
        //        if (paths!=null) foreach(var s in paths) if (s.IsNotNull()) kmlList.Items.Add(new comboItem(s,Path.GetFileName(s)));
        //        }
        //    }
        //private void saveKmlConfig() {
        //    if (!designTime) w.saveKmlConfig(GetKmlList());
        //    }
        //private void loadKmlList() {
        //    kmlList.DisplayMember = "Name";
        //    kmlList.ValueMember = "Code";
        //    kmlList.Items.Add(new comboItem(null,"<No KML>"));
        //    List<string> l= loadKmlConfig();
        //    if (l!=null) foreach(string s in l)
        //        kmlList.Items.Add(new comboItem(s,Path.GetFileName(s)));
        //    kmlListLoaded=true;
        //    kmlList.SelectedIndex= 0;
        //    ol3.KmlFiles= null;
        //}
        //public List<string> GetKmlList() {
        //    if (!kmlListLoaded) return null;
        //    List<string> res= new List<string>();
        //    for(int i=1;i<kmlList.Items.Count;i++) {
        //        comboItem ci= kmlList.Items[i] as comboItem;
        //        res.Add(ci.Code);
        //        }
        //    return res;
        //   }
        //public void SelectKml(string kmlPath) {
        //    if (!kmlListLoaded) return;
        //    if (kmlPath.IsNull()) {  kmlList.SelectedIndex= 0; return; }
        //    for(int i=1;i<kmlList.Items.Count;i++) {
        //        comboItem ci= kmlList.Items[i] as comboItem;
        //        if (ci.Code==kmlPath) {
        //            kmlList.SelectedIndex= i;
        //            kmlList_DropDownClosed(null,null);
        //            return; 
        //            }
        //        }
        //    kmlList.SelectedIndex= -1;
        //    if (KmlsMaxCached>0 && kmlList.Items.Count>KmlsMaxCached) kmlList.Items.RemoveAt(kmlList.Items.Count-1);
        //    kmlList.Items.Insert(1,new comboItem(kmlPath,Path.GetFileName(kmlPath)));
        //    kmlList.SelectedIndex= 1;
        //    saveKmlConfig();
        //    }
        //private void kmlList_DropDownClosed(object sender, EventArgs e) {
        //    int idx= kmlList.SelectedIndex;
        //    if (idx>1) {
        //        object ob= kmlList.Items[idx];
        //        kmlList.Items.Insert(1,ob);
        //        kmlList.SelectedIndex= 1;
        //        kmlList.Items.RemoveAt(idx+1);
        //        saveKmlConfig();
        //        }
        //    }
        //private void kmlList_SelectedIndexChanged(object sender,EventArgs e) {
        //    comboItem it= kmlList.SelectedItem as comboItem;
        //    ol3.KmlFiles= it==null? null : new string[]{it.Code};
        //    }
        //private void kmlAdd_Click(object sender,EventArgs e) {
        //    OpenFileDialog dlg= new OpenFileDialog();
        //    dlg.Title = L.Txt("Select KML file to display");
        //    dlg.FileName= "";
        //    dlg.Filter = L.Txt("KML file|*.kml|All Files (*.*)|*.*");
        //    if (dlg.ShowDialog() != DialogResult.OK) return;
        //    SelectKml(dlg.FileName);
        //    }
                
        private void wb1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        class comboItem {
            public string Name { get; set; }
            public string Code { get; set; }
            public comboItem(string code,string name) { Code=code; Name=name; }
            }
        private bool layerListLoaded=false;
        private bool recentListLoaded=false;
        private void IcsOpenlayers3_Load(object sender, EventArgs e)
        {
            layerList.DisplayMember = "Name";
            layerList.ValueMember = "Code";
            layerList.Items.Add(new comboItem("layerOSM","Open street Map"));
            layerList.SelectedIndex=0; ol3.LayerCode="layerOSM";
            layerList.Items.Add(new comboItem("layerBingAerialLab","Bing aerial+labels"));
            layerList.Items.Add(new comboItem("layerBingRoads","Bing roads"));
            layerList.Items.Add(new comboItem("layerBingAerial","Bing aerial"));
            for(int i=0;i<ol3.multimaps.Count;i++)
                layerList.Items.Add(new comboItem("multimap"+i,Path.GetFileName(ol3.multimaps[i].FName)));
            layerListLoaded=true;
            if (!designTime) {
                w.RegisterMultimaps();
                string loc= System.Reflection.Assembly.GetExecutingAssembly().Location;
                string html= Path.Combine(Path.GetDirectoryName(loc), "OpenLayers3.html");
                wb1.Navigate(html);
                }
            //loadKmlList();
            recentKmls= loadKmlConfig();
            recentListLoaded= true;
        }
        internal void onMapClicked(MapClickedEventArgs args) { if (OnMapClicked!=null) OnMapClicked(this, args); }
        internal void onRectangleSelected(RectangleSelectedEventArgs args) { if (OnRectangleSelected!=null) OnRectangleSelected(this, args); }
        internal void onUpdateGeometry() { 
            _InputGeomPoints= Openlayers3.FromJSON(ol3.InputGeomPointsJson);
            if (OnInputGeometryChanged!=null) OnInputGeometryChanged(this,null);
        }
        internal void onShowLocation(double longi,double lati) {
            string res;
            if (_displayCsys.IsNull()) _displayCsys="4DMS";
            DPoint frm= new DPoint(longi,lati);
            DPoint to= Geo.Convert(_displayCsys,frm,"4DEC");
            if (_displayCsys.EndsWith("DMS")||_displayCsys.EndsWith("DEC"))
                res= "{0} {1}".Fmt(to.X.RoundDeci(6),to.Y.RoundDeci(6));
            else if ("4NGR,NIGR".Has(_displayCsys))
                res= (new IMPosition(to.X,to.Y,_displayCsys)).FormatUK_GridCoord(6, 10, true);
            else res= "{0} {1}".Fmt(to.X.RoundDeci(2),to.Y.RoundDeci(2));
            this.tbPos.Text= res;
        }

        private void layerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboItem itm= layerList.SelectedItem as comboItem;
            ol3.LayerCode= (itm!=null) ? itm.Code : "layerOSM";
        }

        private void IcsOpenlayers3_Layout(object sender,LayoutEventArgs e)
        {
            IcsOpenlayers3_Resize(sender,EventArgs.Empty);
        }

        private void IcsOpenlayers3_Resize(object sender,EventArgs e)
        {
            //int margin= wb1.Location.X;
            //wb1.Size= new Size(Size.Width-2*margin,Size.Height-margin-wb1.Location.Y);
            wb1.Size = new Size(wb1.Size.Width, this.Size.Height - layerList.Size.Height - 5);
        }

        private void kml_Click(object sender,EventArgs e)
        {
            if (!designTime) {
                Openlayers3Kml frm= new Openlayers3Kml(this,ol3);
                frm.SetRecent(recentKmls);
                frm.SetCurrent(ol3.KmlFiles);
                frm.ShowDialog();
                recentKmls= frm.GetRecentList();
                if (recentListLoaded) w.saveKmlConfig(recentKmls);
                ol3.KmlFiles= frm.GetCurrent();
                }
        }



    }
}
