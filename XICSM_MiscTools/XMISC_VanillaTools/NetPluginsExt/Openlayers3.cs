using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Image2;
using OrmCs;
using ICSM;


namespace NetPlugins2Ext
{
    public class OpenLayers3Wrapper
    {
        IcsOpenlayers3 Ol;
        public OpenLayers3Wrapper(IcsOpenlayers3 ol) { Ol = ol; }
        public void RegisterMultimaps()
        {
            var r = IM.FindAllMaps(null, -1, "");
            Dictionary<string, MapHitSharp> maps = new Dictionary<string, MapHitSharp>();
            foreach (var h in r)
            {
                //if (h.m_nature!= &&h.m_nature!="GEO"
                //if (h.m_nature!="IMG") continue;
                string fname = Path.GetFileName(h.fimg);
                MapHitSharp deja;
                if (maps.TryGetValue(fname, out deja))
                { //prefer local!
                    if (!deja.local && h.local) maps[fname] = h;
                }
                else maps.Add(fname, h);
            }
            foreach (var kp in maps) Ol.RegisterMultimap(kp.Value.fimg, kp.Value.fpal);
        }
        public void saveKmlConfig(List<string> ls)
        {
            IM.WorkspaceConfigSave(Ol.KmlsNameCache, ls);
        }
        public List<string> loadKmlConfig() { return IM.WorkspaceConfigLoad(Ol.KmlsNameCache); }
    }
    public struct AtdiMap { 
        public string FName;
        public string FPalette;
        public AtdiMap(string fname,string fpal) { FName=fname; FPalette=fpal; }
        }

    public class MapClickedEventArgs : EventArgs
    {
        public int x,y;
        public double longi4DEC,lati4DEC;
        public string features; //pipe joined
        public string modifiers; //Ex: 'ctrl,alt,'
    }
    public class RectangleSelectedEventArgs : EventArgs
    {
        public int x,y;
        public ExtentJs extentDec;
    }
    [System.Runtime.InteropServices.ComVisible(true)]
    public class ExtentJs
    {
        public double MinLon;
        public double MinLat;
        public double MaxLon;
        public double MaxLat;
    }
    [System.Runtime.InteropServices.ComVisible(true)]
    public class StyleText { //check  http://openlayers.org/en/latest/examples/vector-labels.html?q=Text
        public StyleText() {
            text ="shorten"; maxreso=1200; align="center"; baseline="middle"; rotation=0; font="Arial"; weight="normal";
            size ="12px"; offsetX=offsetY=0; color="#aa3300"; outlineColor="#ffffff"; outlineWidth=3;
            }
        public string text; //"hide,normal,shorten,wrap" default shorten
        public int maxreso; //8 .. 38400  default 1200
        public string align; //"center"(default) "end" "left" "right" "start"
        public string baseline; //"alphabetic" "bottom" "hanging" "ideographic" "middle"(default) "top"
        public double rotation; //radians default 0 ; 0.785398164 = 45° 1.570796327=90°
        public string font; //"Arial"(Default) "Courier New" "Quattrocento Sans" "Verdana"
        public string weight; //"bold" "normal"(default)
        public string size; //"12px"
        public int offsetX,offsetY; //pixels 
        public string color; //"#aa3300"
        public string outlineColor; //"#ffffff"
        public int outlineWidth; //3
        }
    [System.Runtime.InteropServices.ComVisible(true)]
    public class StyleStroke {
        public StyleStroke() { color="#ffcc33"; width=2; }
        public string color; //Ex: "rgba(255, 255, 255, 0.2)", "#ffcc33"
        public int width; //Ex: default 2
        }
    [System.Runtime.InteropServices.ComVisible(true)]
    public class StyleFill {
        public StyleFill() { color="rgba(255, 255, 255, 0.2)"; }
        public string color; //Ex: "rgba(255, 255, 255, 0.2)"(default), "#ffcc33"
        }
    [System.Runtime.InteropServices.ComVisible(true)]
    public class StyleImage {
        public StyleImage() { type="circle"; radius=7; size=18; fill=new StyleFill(); stroke=new StyleStroke(); stroke.color="#000000"; stroke.width=1; }
        public string type; //"circle","crux"
        public int radius; //for circle
        public int size; //for crux
        public StyleFill fill; //for circle,crux
        public StyleStroke stroke; //for circle,crux
        }
    [System.Runtime.InteropServices.ComVisible(true)]
    public class FeatureDetails {
        public string Type; //null(no more existing feature), "KML", "Point", "Circle", "Polygon"
        public string Text; //if Point, Circle, Polygon 
        public string Kmldata; //if KML
        public double Longi,Lati; //4DEC for Point & Circle
        public double RadiusM; //if Circle, in meters
        public PointF[] Points; //if polygon: 4DEC !!
        }

    [System.Runtime.InteropServices.ComVisible(true)]
    public class Openlayers3
    {
        public IcsOpenlayers3 ctrl;
        public WebBrowser wb1;

        //Initialization
        public double StartLongi= -4; //4DMS
        public double StartLati= 40; //4DMS
        public int StartZoom= 6;
        //Fit
        public bool FitRequested;
        public ExtentJs FitExtentRequested;
        //Center
        public double CenterRequestedLongi;
        public double CenterRequestedLati;
        public bool CenterRequested= false;

        //Rectangle selected
        public void RectangleSelected(double minx,double miny,double maxx,double maxy,int x,int y)
        {
            RectangleSelectedEventArgs args= new RectangleSelectedEventArgs();
            args.x= x+wb1.Left; args.y=y+wb1.Top;
            args.extentDec= new ExtentJs();
            args.extentDec.MinLon= minx; args.extentDec.MaxLon= maxx;  
            args.extentDec.MinLat= miny; args.extentDec.MaxLat= maxy;  
            ctrl.onRectangleSelected(args);
            }
        
        //MapClicked
        public void MapClicked(int x,int y,double longi,double lati,string features,string modifiers) {
            MapClickedEventArgs args= new MapClickedEventArgs();
            args.x= x+wb1.Left; args.y=y+wb1.Top;
            args.longi4DEC= longi; args.lati4DEC=lati;
            args.features= features;
            args.modifiers= modifiers;
            ctrl.onMapClicked(args);
            }
        //InputGeometry
        public string InputType; //('','Pg','Ci','Re','Pt')
        public string InputMode; //'','Host'(will reflect InputGeom), 'Mouse'(will write Geom and call InputGeometryChanged
        public double InputGeomRadiusM; //if InputType=='Ci'
        public string InputGeomPointsJson; //if InputType=Pt(1),Re(2)Ci(1)Pg(n)
        public void InputGeometryChanged() {
            ctrl.onUpdateGeometry();
            }

        static public string ToJSON(PointF[] par)
        {
            StringBuilder sb= new StringBuilder();
            sb.Append("["); string com="";
            if (par!=null) foreach(PointF pt in par) {
                sb.Append(com); com=",";
                sb.Append("["); sb.Append(Math.Round((double)pt.X,5).ToSql()); 
                sb.Append(","); sb.Append(Math.Round((double)pt.Y,5).ToSql()); sb.Append("]");
                }
            sb.Append("]");
            return sb.ToString();
        }
        static public PointF[] FromJSON(string pointsJson)
        {
            if (pointsJson.IsNull()) return new PointF[0];
            List<PointF> res= new List<PointF>();
            pointsJson= pointsJson.Replace(',',':');
            int imax= pointsJson.Length;
            int i= pointsJson.IndexFirstNonWhite(0);
            if (i>=imax) return new PointF[0]; 
            if (pointsJson[i]!='[') return null;
            ++i; 
            for(;;) {
                i= pointsJson.IndexFirstNonWhite(i);
                if (i>=imax) return null; 
                if (pointsJson[i]==']') return res.ToArray();
                if (res.Count>0) {
                    if (pointsJson[i]!=':') return null;
                    i= pointsJson.IndexFirstNonWhite(i+1);
                    }
                if (pointsJson[i]!='[') return null;
                ++i; 
                double X,Y;
                if (!pointsJson.ParseDouble2(ref i,out X)) return null;
                i= pointsJson.IndexFirstNonWhite(i);
                if (i>=imax || pointsJson[i]!=':') return null; 
                ++i;
                if (!pointsJson.ParseDouble2(ref i,out Y)) return null;
                i= pointsJson.IndexFirstNonWhite(i);
                if (i>=imax || pointsJson[i]!=']') return null; 
                ++i;
                res.Add(new PointF((float)X,(float)Y));
                }
            }
    
        //Update position
        public void UpdatePosition(double x,double y) { ctrl.onShowLocation(x,y); }

        #region KML
        private string[] _KmlFiles;
        public string[] KmlFiles //changed by ctrl, watched by map control
            { get { return _KmlFiles; } set { _KmlFiles=value; ++KmlFiles_ver; }}
        public int KmlFiles_ver;  // watched by map control
        public int KmlFiles_count { get { return _KmlFiles==null ? 0 : _KmlFiles.Length; } }  
        public string GetIthKmlFile(int ith) { return _KmlFiles[ith]; }  
        public string GetKmlData(string kmlPath) {
            string res="";
            try { res= File.ReadAllText(kmlPath); }
            catch(Exception e) { MessageBox.Show("Error reading "+kmlPath+"\r\n"+e.Message); }
            return res;
            }
        #endregion
        //Layers
        public string LayerCode; //changed by ctrl, watched by wb1

        #region Multimap!
        internal List<AtdiMap> multimaps;
        IntPtr img;
        Image2Dll.RASTERIMAGEINFO imgInfo;
        public string imgPath;
        public string imgPalPath;
        public void CloseImage() {
            IntPtr c= img;
            imgPath=imgPalPath=null;
            img=IntPtr.Zero; if (c!=IntPtr.Zero) Image2Dll.RasterImageClose(c);
            }
        public ExtentJs OpenImage(string imageCode) {
            CloseImage();
            Debug.Assert(imageCode.StartsWith("multimap")); 
            try { int idx= int.Parse(imageCode.Substring(8));
                imgPath= multimaps[idx].FName;
                imgPalPath= multimaps[idx].FPalette;
                img= Image2Dll.RasterImageOpenFile(ref imgInfo,imgPath, imgPalPath);
                return getExtent(imgInfo); }
            catch(Exception e) {  CloseImage(); MessageBox.Show(e.ToString()); return null; }
            }
        static int num = 0;
        static string lastTile;
        public string GetImage(string src)
        {
            Wmsquery q = new Wmsquery();
            if (q.Parse(src)) {
                using (Bitmap b = new Bitmap(q.rec.Width,q.rec.Height,PixelFormat.Format32bppArgb)) {
                    BitmapData bd = b.LockBits(q.rec, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                    Image2Dll.BGRAlpha nullColor = new Image2Dll.BGRAlpha();
                    nullColor.Alpha=0; nullColor.Red= nullColor.Green= nullColor.Blue=255;
                    Image2Dll.RasterImageGetData2(img, bd.Scan0,bd.Stride,ref q.lat, ref q.re,4,nullColor,false,1.0,IntPtr.Zero);
                    b.UnlockBits(bd);
                    if (lastTile!=null) File.Delete(lastTile);
                    lastTile= Path.Combine(IM.GetWorkspaceFolder(),string.Format("Tile_{0}.png", ++num));
                    //lastTile= string.Format(@"C:/temp/Tile_{0}.png", ++num);
                    b.Save(lastTile, ImageFormat.Png);
                    }
                }
            return "file://"+lastTile;
        }
        #endregion

        #region Coverage
        public string CoverageName; //is watched by map control
        IntPtr cov;
        string covName;
        Image2Dll.RASTERIMAGEINFO covInfo;
        private void covClose() { IntPtr c=cov; covName=null; cov=IntPtr.Zero; if (c!=IntPtr.Zero) Image2Dll.RasterImageClose(c); }
        private void covOpen() {
            if (CoverageName==covName) return;
            covClose();
            if (CoverageName==null) return;
            cov= Image2Dll.RasterImageOpenFile(ref covInfo,covName= CoverageName, null);
        }
        public ExtentJs GetCoverageExtent() { covOpen(); return getExtent(covInfo); }
        static int numC = 0;
        static string lastTileC;
        public string GetCoverage(string src)
        {
            covOpen();
            if (cov==IntPtr.Zero) return "";
            Wmsquery q = new Wmsquery();
            if (q.Parse(src)) {
                using (Bitmap b = new Bitmap(q.rec.Width,q.rec.Height,PixelFormat.Format32bppArgb)) {
                    BitmapData bd = b.LockBits(q.rec, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                    Image2Dll.BGRAlpha nullColor = new Image2Dll.BGRAlpha();
                    nullColor.Alpha=0; nullColor.Red= nullColor.Green= nullColor.Blue=255;
                    Image2Dll.RasterImageGetData2(cov, bd.Scan0,bd.Stride,ref q.lat, ref q.re,4,nullColor,false,1.0,IntPtr.Zero);
                    b.UnlockBits(bd);
                    if (lastTileC!=null) File.Delete(lastTileC);
                    lastTileC= Path.Combine(IM.GetWorkspaceFolder(),string.Format("Tile_C{0}.png", ++numC));
                    //lastTileC= string.Format(@"C:/temp/Tile_C{0}.png", ++numC);
                    b.Save(lastTileC, ImageFormat.Png);
                    }
                }
            return "file://"+lastTileC;
        }
        public ExtentJs getExtent(Image2Dll.RASTERIMAGEINFO info)
        {
            ExtentJs js = new ExtentJs(); //DEC!
            if (info.lat.csys=="4SEC") {
                js.MinLon= info.lat.ox/3600.0;
                js.MaxLon= (info.lat.ox+info.rect.right*info.lat.dx)/3600.0;
                js.MinLat= (info.lat.oy+info.rect.bottom*info.lat.dy)/3600.0;
                js.MaxLat= info.lat.oy/3600.0;
                }
            else {
                for(int i=0;i<3;i++) for(int j=0;j<3;j++) {
                    double ix= info.lat.ox;
                    if (i==1) ix+= (info.rect.right/2)*info.lat.dx;
                    if (i==2) ix+= (info.rect.right-1)*info.lat.dx;
                    double iy= info.lat.oy;
                    if (j==1) iy+= (info.rect.bottom/2)*info.lat.dy;
                    if (j==2) iy+= (info.rect.bottom-1)*info.lat.dy;
                    DPoint pt= Geo.Convert("4DEC", new DPoint(ix,iy), info.lat.csys);
                    if (i==0&&j==0) { js.MinLon=js.MaxLon=pt.X; js.MinLat=js.MaxLat=pt.Y; }
                    else {
                        if (js.MinLon > pt.X) js.MinLon = pt.X;
                        if (js.MaxLon < pt.X) js.MaxLon = pt.X;
                        if (js.MinLat > pt.Y) js.MinLat = pt.Y;
                        if (js.MaxLat < pt.Y) js.MaxLat = pt.Y;
                        }
                    }
                }
            return js;
        }
        #endregion

        #region Vectors!
        public bool VectorsDirty; //watched by WebCtrl
        public string GetVectorsList() {
            StringBuilder bl= new StringBuilder(); string prfx="";
            foreach(var vl in vectorLayers) {  bl.Append(prfx+vl.Ident); prfx="|"; }
            return bl.ToString();
            }
        private VecLayer lstVl; private string lstVlName;
        private VecLayer vlayerFromName(string name) {
            if (name==lstVlName) return lstVl;
            foreach(VecLayer vl in vectorLayers) if (vl.Ident==name) { lstVl=vl; lstVlName=name; return vl; }
            return null;
            }
        public bool VectorsIsDirty(string vlname) { return vlayerFromName(vlname).IsDirty; }
        public bool VectorsIsStyleDirty(string vlname) { return vlayerFromName(vlname).IsStyleDirty; }
        public StyleFill VectorsGetStyleFill(string vlname) { return vlayerFromName(vlname).StFill??defStFill; }
        private StyleFill defStFill= new StyleFill();
        public StyleStroke VectorsGetStyleStroke(string vlname) { return vlayerFromName(vlname).StStroke??defStStroke; }
        private StyleStroke defStStroke= new StyleStroke();
        public StyleImage VectorsGetStyleImage(string vlname) { return vlayerFromName(vlname).StImage??defStImage; }
        private StyleImage defStImage= new StyleImage();
        public StyleText VectorsGetStyleText(string vlname) { return vlayerFromName(vlname).StText??defStText; }
        private StyleText defStText= new StyleText();
        public bool VectorsIsTextDirty(string vlname) { return vlayerFromName(vlname).IsTextDirty; }
        public string VectorsGetDirtyKeys(string vlname) { return vlayerFromName(vlname).DirtyKeys; }
        public string VectorsGetNewName(string vlname,string keyName) { return vlayerFromName(vlname).GetNewText(keyName); }
        public void VectorsDirtyUpdated(string vlname) { vlayerFromName(vlname).DirtyUpdated(); }
        private FeatureDetails vlDet= new FeatureDetails();
        public FeatureDetails VectorsGetDetails(string vlname,string keyName)  { vlayerFromName(vlname).GetFeature(keyName,vlDet); return vlDet; }
        public double VectorsGetDetailsNbPoints() { return vlDet.Points.Length; }
        public double VectorsGetDetailsNthLon(int i) { return vlDet.Points[i].X; }
        public double VectorsGetDetailsNthLat(int i) { return vlDet.Points[i].Y; }
        List<VecLayer> vectorLayers= new List<VecLayer>();
        private int vlayerCounter;
        internal void RegisterVectorLayer(VecLayer vl) {
            if (vl.Ident== null) vl.Ident= "#veclayer"+vlayerCounter++;
            vectorLayers.Add(vl);
            vl.Ctrl= this;
            VectorsDirty= true;
            }
        internal void UnregisterLayer(VecLayer vl) {
            if (lstVl==vl) {lstVlName=null;lstVl=null; }
            if (vectorLayers.Remove(vl)) VectorsDirty= true;
            vl.Ctrl= null;
            }
        #endregion
    }
    internal class Wmsquery
    {
        public int width = 0, height = 0;
        public double minx = 1e-99, maxx = 1e-99, miny = 1e-99, maxy = 1e-99;
        public Rectangle rec;
        public Image2Dll.RECT re;
        public Image2Dll.LATTI lat;
        public bool Parse(string src)
        {
            width = height = 0;
            minx = maxx = miny = maxy = 1e-99;
            string[] pars= src.Replace("%2F", "/").Replace("%2C", ",").Replace("%3A", ":").Split('&');
            foreach(string s in pars) {
                int i= s.IndexOf('=');
                if (i>0) { 
                    string parm= s.Substring(0,i).ToUpper();
                    string val= s.Substring(i+1);
                    if (parm == "WIDTH") width = int.Parse(val);
                    else if (parm == "HEIGHT") height = int.Parse(val);
                    else if (parm == "BBOX") {
                        string[] xys = val.Split(',');
                        minx= double.Parse(xys[0]);
                        miny= double.Parse(xys[1]);
                        maxx= double.Parse(xys[2]);
                        maxy= double.Parse(xys[3]);
                        }
                    }
                }
            if (width > 0 && height > 0 && minx != 1e-99 && miny != 1e-99 && maxx != 1e-99 && maxy != 1e-99) {
                rec = new Rectangle(0, 0, width, height);
                re = new Image2Dll.RECT(rec);
                lat = new Image2Dll.LATTI();
                lat.csys = "WMAS";
                lat.ox = minx;
                lat.oy = maxy;
                lat.dx = (maxx - minx) / width;
                lat.dy = (miny - maxy) / height;
                return true;
                }
            return false;
        }
    }

    public class VecLayer
    {
        public VecLayer() { dirtyStyleWaiting=true; }
        public string Ident; //initialize or not, do not change after
        internal Openlayers3 Ctrl;
        //callbacks from WebCtrl:
        public virtual string GetNewText(string key) { return null; } //return updated text for feature
        public virtual void GetFeature(string key,FeatureDetails details) { details.Type=null; } //must be overriden
        
        public StyleText StText;
        public StyleFill StFill;
        public StyleStroke StStroke;
        public StyleImage StImage;
        public bool IsDirty; //Signals to the WebCtrl some dirty stuff to handle
        public bool IsTextDirty; //Text change being handled by WebCtrl
        public bool IsStyleDirty; //style change being handled by WebCtrl
        public string DirtyKeys; //Dirty features list being handled by WebCtrl

        public void TextNeedsUpdating() { //called by Form to ask the WebCtrl to update the feature names (after creation)
            lock(dirtyStuffWaiting) {
                dirtyTextWaiting=true;
                dirty();
                }
            }
        public void StyleNeedsUpdating() { //called by Form after updating XStyle
            lock(dirtyStuffWaiting) {
                dirtyStyleWaiting=true;
                dirty();
                }
            }
        public void FeatureNeedsUpdating(string key) { //called by Form (feature deleted and recreated)
            lock(dirtyStuffWaiting) {
                dirtyStuffWaiting.Add(key);
                dirty();
                }
            }
        private List<string> dirtyStuffWaiting= new List<string>();
        private bool dirtyTextWaiting;
        private bool dirtyStyleWaiting;
        private void dirty() { //execs in lock! we know something is dirty
            if (!IsDirty) {
                DirtyKeys = pipeArray(dirtyStuffWaiting,"|"); dirtyStuffWaiting.Clear();
                IsTextDirty=dirtyTextWaiting; dirtyTextWaiting=false; 
                IsStyleDirty=dirtyStyleWaiting; dirtyStyleWaiting=false; 
                IsDirty =true;
                if (Ctrl!=null) Ctrl.VectorsDirty=true;
                }
            }
        private string pipeArray(IEnumerable<string> lst,string separ) {
            StringBuilder sb= new StringBuilder(); string nxtSep="";
            foreach(string s in lst) { sb.Append(nxtSep+s); nxtSep=separ; }
            return sb.ToString();
            }
        //also callbacks from WebCtrl:
        public void DirtyUpdated() { //called by WebCtrl:
            lock(dirtyStuffWaiting) {
                DirtyKeys=null; IsDirty=IsTextDirty=IsStyleDirty=false;
                if (dirtyStuffWaiting.Count>0||dirtyTextWaiting||dirtyStyleWaiting) dirty();
                }
            }
    }
}
