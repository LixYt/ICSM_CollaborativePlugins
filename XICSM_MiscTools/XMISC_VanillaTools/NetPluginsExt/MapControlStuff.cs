using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetPlugins2;
using OrmCs;
using ICSM;
using System.Windows.Forms;
using System.Drawing;
using XICSM.VanillaTools.Tools;

namespace NetPlugins2Ext
{
    class StationN {
        public string key; //actually is the XB_NASSIGN.ID
        public double freq;
        public string name;
        public string All_Name;
        public string t_station;
        public string picode;
        public string switched_picode;
        public float longi;
        public float lati;
        public double distance_border;
        public string main_id_hex;
        public string sub_id_hex;
        public string main_id_dec;
        public string sub_id_dec;
        public string both_id_hex;
        public string table;
        public double UFS;
        public bool Visible;
        public bool isPolygon;
        public bool isCircle;
        public double radius;
        public string TypeViewCaption;
        public string Channel;
        public string LatLon;
        public string standard;
        public string licenceN;
        public string area;
        public string str_ngr;
        public string str_ens_id;
        public bool isStation;
        public bool isLink;
        public Transmitters SourceTransmitter;

        public string RelatedLinkKey; //used to delacre to which link (polygons or polylines) it's associated
        public List<string> RelatedStationKeys = new List<string>(); //used to declare to which Stations a link is related

        public string GetName(string typnm) {

            if (typnm == "Channel") return Channel;
            if (typnm == "LatLon") return LatLon;
            if (typnm=="Site name") return name;
            if (typnm == "AllName") return All_Name;
            if (typnm=="Frequency") return "{0} MHz".Fmt(freq);
            if (typnm == "Station") return t_station;
            if (typnm=="None") return null;
            if (typnm=="picode") return picode;
            if (typnm == "distance") return (distance_border!=IM.NullD ? distance_border.ToString("F1") : "");
            if (typnm == "mainid_hex") return main_id_hex;
            if (typnm == "subid_hex") return sub_id_hex;
            if (typnm == "mainid_dec") return main_id_dec;
            if (typnm == "subid_dec") return sub_id_dec;
            if (typnm == "bothid_hex") return both_id_hex;
            if (typnm == "Licence N") return licenceN;
            if (typnm == "ENS ID") return str_ens_id;
            if (typnm == "Area") return area;
            if (typnm == "NGR") return str_ngr;
            if (typnm == "UFS") return (UFS != IM.NullD ? UFS.ToString("F1") : "");
            if (typnm == "") return "";
            return "";
            }

        }


    class KmlProvider : VecLayer
    {
        public double Lat;
        public double Lon;
        public double Radius;
        public System.Drawing.PointF[] Pnts_x;
        public string CaptionPolygon;
        public KmlProvider()
        {
             
            Active = true;
            Refresh();
            StText = new StyleText(); StText.maxreso = 2400; StText.size = "12px"; StText.align = "start"; StText.offsetX = 10; StText.text = "normal";
            StFill = new StyleFill();
            StStroke = new StyleStroke(); StStroke.color = "#00FF00"; StStroke.width = 1;
            StImage = new StyleImage(); StImage.type = "crux"; StImage.fill.color = "rgba(0,0,255,0.4)";
        }
        public bool Active;
        public void Refresh() { foreach (string s in "Pt1,Poly1,Circle1,Circle2,Km1,Km2".Split(',')) FeatureNeedsUpdating(s); }
        private int number;

        public override string GetNewText(string key)
        {
            return key.StartsWith("Circle") ? null : key + " version " + number++;
        } //return updated text for feature

        public override void GetFeature(string key, FeatureDetails details)
        {
            details.Type = null;
            if (Active)
            {
                if ((Lon != IM.NullD) && (Lat != IM.NullD))
                {
                    if (key == "Circle2") { details.Type = "Circle"; details.Longi = Lon; details.Lati = Lat; details.RadiusM = Radius*1000; details.Text = null; return; }
                    if (key == "Circle1") { details.Type = "Circle"; details.Longi = Lon; details.Lati = Lat; details.RadiusM = (Radius * 1000)/100; details.Text = null; return; }
                    if (key == "Pt1") { details.Type = "Point"; details.Longi = Lon; details.Lati = Lat; details.Text = null; return; }
                }
                if (Pnts_x!=null)
                {
                    if (Pnts_x.Length>0)
                    {
                        if (key == "Poly1") { details.Type = "Polygon"; details.Points = Pnts_x; details.Text = CaptionPolygon; return; }
                    }
                }
            }
        }
    }

  
    public enum TypeHexDec
    {
        HEX,
        DEC
    }

    class Transmitters:VecLayer
    {
        public Transmitters()
        {
            posCentralPoint = new IMPosition(); posCentralPoint.Lat = IM.NullD; posCentralPoint.Lon = IM.NullD;
            Stns_Global = new Dictionary<string, StationN>();
            Stns = new Dictionary<string, StationN>();
            Stns_Distinct = new Dictionary<string, StationN>();
            L_Stns_Distinct = new List<KeyValuePair<int, Dictionary<string, StationN>>>();
            StText= new StyleText(); StText.maxreso=2400; StText.size="12px"; StText.align="start"; StText.offsetX=10; StText.text="normal";
            StFill= new StyleFill();
            StStroke= new StyleStroke(); StStroke.color="#00FF00"; StStroke.width=3;
            StImage= new StyleImage(); StImage.type="crux"; StImage.fill.color="rgba(0,255,0,0.4)";
        }
        public Dictionary<string,StationN> Stns_Global;
        public Dictionary<string, StationN> Stns;
        public Dictionary<string, StationN> Stns_Distinct;
        public List<KeyValuePair<int,Dictionary<string, StationN>>> L_Stns_Distinct;
        public IMPosition posCentralPoint;
        public int Filtre;
        public string TypeOfNaming; //"picode","freq","name"

        public void ChangeName(string typnam)
        {
            if (typnam!=TypeOfNaming) { TypeOfNaming=typnam; TextNeedsUpdating(); }
        }

        public void ChangeFilter(int filt)
        {
            Filtre= filt;
            foreach(var kp in Stns)
            {
                bool newVisi;
                StationN st= kp.Value;
                newVisi = true;
                if (newVisi!=st.Visible) { st.Visible=newVisi; FeatureNeedsUpdating(st.key); }
            }
        }
        public void Recalc()
        {
            foreach (KeyValuePair<string, StationN> item in Stns)
            {
                if ((posCentralPoint.Lon != IM.NullD) && (posCentralPoint.Lat != IM.NullD))
                {
                    double d1 = 111.3 * Math.Abs(item.Value.lati - posCentralPoint.Lat);
                    double d2_ext = Math.Cos(3.1415 * (0.5 * item.Value.lati + 0.5 * posCentralPoint.Lat) / 180);
                    double d2 = 111.3 * Math.Abs(item.Value.longi - posCentralPoint.Lon) * d2_ext;
                    double d = Math.Pow((Math.Pow(d1, 2) + Math.Pow(d2, 2)), 0.5);
                    item.Value.distance_border = d;
                }
            }
        }

        public int DistinctStation()
        {
            int cnt = 0;
            L_Stns_Distinct.Clear();
            foreach (KeyValuePair<string, StationN> item in Stns) {
                IEnumerable<KeyValuePair<string, StationN>> Val_Fnd = Stns.Where(r => (Math.Abs(r.Value.lati - item.Value.lati) <= 0.00001) && (Math.Abs(r.Value.longi - item.Value.longi) <= 0.00001));
                foreach (KeyValuePair<string, StationN> vl in Val_Fnd) {
                    IEnumerable<KeyValuePair<string, StationN>> Val_Fnd2 = Stns_Distinct.Where(r => (Math.Abs(r.Value.lati - vl.Value.lati) <= 0.00001) && (Math.Abs(r.Value.longi - vl.Value.longi) <= 0.00001));
                    if ((!Stns_Distinct.ContainsKey(vl.Key)) && (Val_Fnd2.Count() == 0)) {
                        Stns_Distinct.Add(vl.Key, vl.Value);
                    }
                }
            }
           

            foreach (KeyValuePair<string, StationN> item in Stns_Distinct) {
                IEnumerable<KeyValuePair<string, StationN>> Val_Fnd = Stns.Where(r => (Math.Abs(r.Value.lati - item.Value.lati) <= 0.00001) && (Math.Abs(r.Value.longi - item.Value.longi) <= 0.00001));
                Dictionary<string, StationN> newVL = new Dictionary<string, StationN>();
                foreach (KeyValuePair<string, StationN> vl in Val_Fnd) {
                    newVL.Add(vl.Key, vl.Value);
                }
                L_Stns_Distinct.Add(new KeyValuePair<int, Dictionary<string, StationN>>(cnt, newVL)); 
                cnt++;
            }

            
         

            foreach (KeyValuePair<int, Dictionary<string, StationN>> it in L_Stns_Distinct) {
                string Name = ""; 
                foreach (KeyValuePair<string, StationN> iu in it.Value)  { 
                    if ("Frequency"==TypeOfNaming)
                        Name += iu.Value.GetName(TypeOfNaming) + Environment.NewLine;
                    else if (("Site name" == TypeOfNaming) || ("Station name" == TypeOfNaming))
                        Name += iu.Value.GetName(TypeOfNaming) + Environment.NewLine;  
                    else  if ("Station"==TypeOfNaming)
                        Name += iu.Value.GetName(TypeOfNaming) + Environment.NewLine;
                    else if ("ENS ID" == TypeOfNaming)
                        Name += iu.Value.GetName(TypeOfNaming) + Environment.NewLine;
                    else if ("Licence N" == TypeOfNaming)
                        Name += iu.Value.GetName(TypeOfNaming) + Environment.NewLine;
                    else if ("Area" == TypeOfNaming)
                        Name += iu.Value.GetName(TypeOfNaming) + Environment.NewLine;
                    else if ("NGR" == TypeOfNaming)
                        Name += iu.Value.GetName(TypeOfNaming) + Environment.NewLine;
                    else if ("picode"==TypeOfNaming)
                        Name += iu.Value.GetName(TypeOfNaming) + Environment.NewLine;  
                    else  if ("mainid_hex"==TypeOfNaming)
                        Name += iu.Value.GetName(TypeOfNaming) + Environment.NewLine;  
                    else  if ("subid_hex"==TypeOfNaming)
                        Name += iu.Value.GetName(TypeOfNaming) + Environment.NewLine;  
                    else  if ("mainid_dec"==TypeOfNaming)
                        Name += iu.Value.GetName(TypeOfNaming) + Environment.NewLine;  
                    else  if ("subid_dec"==TypeOfNaming)
                        Name += iu.Value.GetName(TypeOfNaming) + Environment.NewLine;  
                    else  if ("bothid_hex"==TypeOfNaming)
                        Name += iu.Value.GetName(TypeOfNaming) + Environment.NewLine;  
                    else if ("None"==TypeOfNaming)
                        Name += iu.Value.GetName(TypeOfNaming) + Environment.NewLine;  
                }
                foreach (KeyValuePair<string, StationN> iu in it.Value)  {
                       iu.Value.All_Name = Name;  
                }
            }
            cnt = L_Stns_Distinct.Count;
            return cnt;
        }

        public string UpdatePosition(YPosition pos,string key=null)
        {
            if (key == null) key = CreateKey(pos.m_id, pos.m_table_name); 
            StationN previous=null;
            Stns.TryGetValue(key,out previous);
            bool moved=false;
            if ((pos.m_longitude.IsNull() || pos.m_latitude.IsNull()) && pos.m_points.IsNull())
                Stns.Remove(key);
            else {
                StationN s = new StationN();
                s.distance_border = 0;
                s.table = pos.m_table_name;
                s.key= key;
                s.name = pos.m_name;
                
                s.longi = (float)pos.m_longitude;
                s.lati = (float)pos.m_latitude;
                if (pos.m_points == "") { s.isPolygon = false; }
                else { s.isPolygon = true; s.area = pos.m_points; }

                if (pos.m_radius != Null.D) { s.radius = pos.m_radius; s.isCircle = true; }
                s.Visible = true;
                Stns[key]= s;
                moved= previous==null || s.longi!=previous.longi || s.lati!=previous.lati;
                }
            FeatureNeedsUpdating(key);
            return key;
        }

        public string UpdatePosition(StationN s)
        {
            if (s.key == null) return s.key;
            StationN previous = null;
            Stns.TryGetValue(s.key, out previous);
            bool moved = false;
            if ((s.longi.IsNull() || s.lati.IsNull()) && s.area.IsNull())
                Stns.Remove(s.key);
            else
            {
                s.Visible = true;
                Stns[s.key] = s;
                moved = previous == null || s.longi != previous.longi || s.lati != previous.lati;
            }
            FeatureNeedsUpdating(s.key);
            return s.key;
        }

        public string UpdatePosition(YAllPositions pos, string key = null)
        {
            YPosition p = new YPosition();
            p.Table = pos.m_table_name; p.Fetch(pos.m_id);
            return UpdatePosition(p, key);
        }

        public string LoadFromAllStation(int ID, string Table)
        {
            YAllStations s = new YAllStations();
            s.Format("*");
            s.Fetch("TABLE_ID = {0} AND TABLE_NAME='{1}'".Fmt(ID, Table));

            YPosition pos = new YPosition();
            pos.m_id = ID;
            pos.m_csys = s.m_csys;
            pos.m_table_name = Table;
            if (s.m_site_name == "") { pos.m_name = s.m_name;  } else { pos.m_name = s.m_site_name; }
            pos.m_longitude = s.m_longitude;
            pos.m_latitude = s.m_latitude;
            pos.m_points = s.m_points;
            if(pos.m_longitude.IsNotNull() && pos.m_latitude.IsNotNull())
            {
                Yyy y = Yyy.CreateObject(s.m_table_name); 
                if (y.IsPresent2("RADIUS"))
                { y.LoadWithComponents2(s.m_table_id); pos.m_radius = double.Parse(y.Get("RADIUS").ToString()); }
                else if (y.IsPresent2("Position.RADIUIS"))
                { y.LoadWithComponents2(s.m_table_id); pos.m_radius = double.Parse(y.Get("Positionn.RADIUS").ToString()); }
            }

            UpdatePosition(pos);

            return CreateKey(ID, Table);
        }

        public static string CreateKey(int ID, string table)  { return table + "." + ID.ToString(); }

        public List<string> LoadMwLink(int ID, string Table, YMicrowa mwa)
        {
            List<string> keys = new List<string>();
            YPosition A = new YPosition(); A.Table = mwa.m_StationA.m_Position.m_table_name;  A.Fetch(mwa.m_StationA.m_Position.m_id);
            YPosition B = new YPosition(); B.Table = A.Table;  B.Fetch(mwa.m_StationB.m_Position.m_id);
            YPosition Pa = new YPosition(); Pa.Table = A.Table; Pa.Fetch(mwa.m_StationPa.m_Position.m_id);
            YPosition Pb = new YPosition(); Pb.Table = A.Table; Pb.Fetch(mwa.m_StationPb.m_Position.m_id);
            
            YPosition Link = new YPosition();
            Link.m_id = ID;
            Link.m_csys = "4DEC";
            Link.m_table_name = Table;
            Link.m_latitude = A.m_latitude;
            Link.m_longitude= A.m_longitude;
            Link.m_name = mwa.m_name;
            Link.m_points = A.m_longitude.ToString() + "\t" + A.m_latitude.ToString();
            if (Pa.m_id != Null.I) { Link.m_points += "\r\n" + Pa.m_longitude.ToString() + "\t" + Pa.m_latitude.ToString(); }
            if (Pb.m_id != Null.I) { Link.m_points += "\r\n" + Pb.m_longitude.ToString() + "\t" + Pb.m_latitude.ToString(); }
            Link.m_points += "\r\n" + B.m_longitude.ToString() + "\t" + B.m_latitude.ToString();
            if (Pa.m_id != Null.I && Pb.m_id != Null.I) //closing polyline to polygone
            {
                Link.m_points += "\r\n" + Pb.m_longitude.ToString() + "\t" + Pb.m_latitude.ToString();
                Link.m_points += "\r\n" + Pa.m_longitude.ToString() + "\t" + Pa.m_latitude.ToString();
            }
            Link.m_points += "\r\n" + A.m_longitude.ToString() + "\t" + A.m_latitude.ToString();

            //set Station A
            string AKey = CreateKey(mwa.m_StationA.m_id, mwa.m_StationA.m_table_name);
            UpdatePosition(A, AKey);
            keys.Add(AKey);
            
            //set Station B
            string BKey = CreateKey(mwa.m_StationB.m_id, mwa.m_StationB.m_table_name);
            UpdatePosition(B, BKey);
            keys.Add(BKey);
            
            //set Passiv station(s)
            string PaKey="";
            if (Pa.m_id != Null.I)
            {
                PaKey = CreateKey(mwa.m_StationPa.m_id, mwa.m_StationPa.m_table_name);
                UpdatePosition(Pa, PaKey);
                keys.Add(PaKey);
            }
            string PbKey = "";
            if (Pb.m_id != Null.I)
            {
                PbKey = CreateKey(mwa.m_StationPb.m_id, mwa.m_StationPb.m_table_name);
                UpdatePosition(Pb, PbKey);
                keys.Add(PbKey);
            }

            //set links (polylines)
            string LinkKey = CreateKey(Link.m_id, Link.m_table_name);
            UpdatePosition(Link); keys.Add(LinkKey);
            //set relations between Station and Links
            List<string> StationsKeys = new List<string>();
            StationsKeys.Add(AKey); StationsKeys.Add(BKey); StationsKeys.Add(PaKey); StationsKeys.Add(PbKey);
            SetRelatedStations(LinkKey, StationsKeys);

            //set related stations to the link
            SetRelatedLink(AKey, LinkKey);
            SetRelatedLink(BKey, LinkKey);
            SetRelatedLink(PaKey, LinkKey);
            SetRelatedLink(PbKey, LinkKey);

            //set related stations to each others
            SetRelatedStations(AKey, StationsKeys);
            SetRelatedStations(BKey, StationsKeys);
            SetRelatedStations(PaKey, StationsKeys);
            SetRelatedStations(PbKey, StationsKeys);

            return keys;
        }

        public void SetRelatedStations(string LinkKey, List<string> StationsKeys)
        {
            StationN previous = null;
            Stns.TryGetValue(LinkKey, out previous);

            if (previous != null)
            {
                foreach(string StationKey in StationsKeys)
                {
                    StationN St = null;
                    Stns.TryGetValue(StationKey, out St);
                    if (St != null)
                    {
                        previous.RelatedStationKeys.Add(StationKey);
                    }
                }
            }
        }

        public void SetRelatedLink(string StationKey, string LinkKey)
        {
            StationN previous = null;
            Stns.TryGetValue(StationKey, out previous);

            if (previous != null)
            {
                StationN St = null;
                Stns.TryGetValue(LinkKey, out St);
                if (St != null)
                {
                    previous.RelatedLinkKey = LinkKey;
                }
            }
        }

        public void Refresh()
        { foreach(var kp in Stns) if (kp.Value.Visible) FeatureNeedsUpdating(kp.Value.key);}

        public override string GetNewText(string key) {
            StationN st; return (Stns.TryGetValue(key,out st) && st.Visible) ? st.GetName(TypeOfNaming) : null; 
            }

        public PointF[] buildCirclePoints(double X, double Y, string CSYS, double RADIUS_KM)
        {
            IMPosition pos = new IMPosition(X, Y, CSYS);
            IMPosition pos4DEC = IMPosition.Convert(pos, "4DEC");
            int stepDeg = 10; int siz = 360 / stepDeg;
            PointF[] points = new PointF[siz];
            for (int i = 0; i < siz; i++)
            {
                double x = 0, y = 0;
                IM.GeoJump(ref x, ref y, pos4DEC.Lon, pos4DEC.Lat, RADIUS_KM, (siz - 1 - i) * stepDeg);
                points[i] = new PointF((float)x, (float)y);
            }
            return points;
        }
        public override void GetFeature(string key,FeatureDetails details) {
            details.Type=null;
            StationN st1; Stns.TryGetValue(key, out st1);
            StationN st;
            if (Stns.TryGetValue(key,out st) && st.Visible && !st.isPolygon && !st.isCircle) { 
                details.Type="Point";
                details.Longi= st.longi; details.Lati= st.lati; 
                details.Text= st.GetName(TypeOfNaming);
                }
            else {
                if (Stns.TryGetValue(key, out st) && st.Visible && (st.isPolygon))
                {
                    details.Type = "Polygon";
                    double[] pts4DEC = null;
                    string parseError = null;
                    IM.ParsePolygon(ref pts4DEC, ref parseError, st.area, "4DEC", "4DEC");
                    int npts = pts4DEC.Length / 2;
                    PointF[] PointsF = new PointF[npts];
                    for (int i = 0; i < npts; i++)
                    {
                        PointsF[i] = new PointF((float)pts4DEC[2 * i], (float)pts4DEC[2 * i + 1]);
                    }
                    details.Points = PointsF;
                    details.Longi = st.longi; details.Lati = st.lati;
                    details.Text = st.GetName(st.TypeViewCaption);
                }
                else if (Stns.TryGetValue(key, out st) && st.Visible && (st.isCircle))
                {
                    
                    details.Longi = st.longi; details.Lati = st.lati;
                    //details.RadiusM = st.radius * 1000;
                    details.Type = "Polygon";
                    PointF[] p = buildCirclePoints(st.longi, st.lati, "4DEC", st.radius);
                    details.Points = p;
                    
                    details.Text = st.GetName(st.TypeViewCaption);
                    
                }
                else { /* what is it ? */}
            }
        }
    }
}
