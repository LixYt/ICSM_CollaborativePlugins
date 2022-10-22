using DatalayerCs;
using FormsCs;
using ICSM;
using Newtonsoft.Json;
using OrmCs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XICSM.VanillaTools.Tools
{
    public static class XTools
    {
        public static List<string> GetICSmTables()
        {
            List<string> Assemblies = new List<string>();
            List<string> Tables = new List<string>();
            List<string> Errors = new List<string>();
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies().Where(x => x.GetName().Name.StartsWith("XICSM_")))
            {
                Assemblies.Add(assembly.GetName().Name);
            }

            Assemblies.Add("OrmCs");
            foreach (string CurrentAssembly in Assemblies)
            {
                Assembly myAssembly = Assembly.Load(CurrentAssembly);

                foreach (Type t in myAssembly.GetTypes())
                {
                    if (!t.Name.StartsWith("Y") || t.Name == "Yyy") continue;
                    try
                    {
                        Yyy obj = (Yyy)Activator.CreateInstance(t);
                        Tables.Add(obj.Table);
                        if (obj.Table.EndsWith("_T"))
                        {
                            Tables.Add(obj.Table.Replace("_T", ""));
                        }
                    }
                    catch (Exception ex) { Errors.Add($"{t.Name} : {ex.Message}"); }
                }
            }

            Tables.Sort();
            return Tables;
        }
        static public bool Compatible(this DateTime d)
        {
            return (d >= DateTime.MinValue && d <= DateTime.MaxValue);
        }
        static public bool IsNull(this float f)
        {
            double d = float.Parse(f.ToString());
            return (d.IsNull());
        }
        static public bool isReachableURL(this string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Timeout = 5000;
            request.Method = "HEAD"; // As per Lasse's comment
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    return response.StatusCode == HttpStatusCode.OK;
                }
            }
            catch (WebException)
            {
                return false;
            }
        }
        static public bool DocumentExists(this string Path)
        {
            string SharedDirPath = ICSMConfig.Item("SHDIR-DOC");
            if (Path.StartsWith("http://") || Path.StartsWith("https://") || Path.StartsWith("ftp://")) //is URL
            {
                if (!Path.isReachableURL())
                {
                    return false;
                }
            }
            else //is probably file or a directory so let's test if it exists
            {
                if (!File.Exists(Path) && !Directory.Exists($@"{Path}")
                    && !File.Exists($@"{SharedDirPath}\{Path}")
                    && !File.Exists($@"{SharedDirPath}{Path}")
                    && !Directory.Exists($@"{SharedDirPath}{Path}")
                    && !Directory.Exists($@"{SharedDirPath}\{Path}")
                    )
                {
                    return false;
                }
            }
            return true;
        }
        static public double Max(this double d1, double d2)
        {
            return new List<double>() { d1, d2 }.Max();
        }
        static public string ToCsvString(this List<int> Li, bool FinalComa = false)
        {
            if (Li.Count() == 0) return "";
            string str = "";
            foreach(int i in Li) { str += $"{i},"; }
            return FinalComa ? str : str.Remove(str.Length - 1, 1);
        }
        static public string ToCsvString(this List<string> Li, bool FinalComa = false)
        {
            if (Li.Count() == 0) return "";
            string str = "";
            foreach (string i in Li) { str += $"{i},"; }
            return FinalComa ? str : str.Remove(str.Length - 1, 1);
        }
        static public List<string> FromCsvString(this string s)
        {
            return s.Split(',').ToList();
        }
        static public string ToJson(this Yyy y)
        {
            XElement x = y.AsXml(); 
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(x.ToString());
            string json = JsonConvert.SerializeXmlNode(doc);

            return json;
        }
    }

    public class PolygonEtudeExt : NetPlugins2.PolygoneEtude
    {
        public List<Tuple<double, double>> PolygonExtent = new List<Tuple<double, double>>(); //X,Y

        public void CompteHorizon(IMPosition pos, double PositionAGL, double PositionASL, string PositionName, bool silent = true)
        {
            double[] Elevations = new double[72]; double[] Distances = new double[72];
            bool computed = IM.ComputeHorizon(pos, (PositionAGL + PositionASL), 5, ref Elevations, ref Distances);
            if (!computed && !silent)
            {
                IcsMetroMessageBox.Show(L.Txt("Radio horizon has not been computed for {0}".Fmt(PositionName)),
                                    L.Txt("Missing DTM"),
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }

            double longNode = Null.D, latNode = Null.D;
            for (int i = 71; i >= 0; i--)
            {
                IM.GeoJump(ref longNode, ref latNode, pos.Lon, pos.Lat, Distances[i] * 4 / 3, i * 5);
                PolygonExtent.Add(new Tuple<double, double>(longNode, latNode));
            }

        }
        public bool Intersects(PolygonEtudeExt p)
        {
            if (p.Extent.maxX == Null.D || p.Extent.maxY == Null.D || p.Extent.minX == Null.D || p.Extent.minY == Null.D) return false;
            if (Extent == null) return false;

            if (
                (p.Extent.minX <= Extent.maxX && p.Extent.minX >= Extent.minX) || (p.Extent.maxX <= Extent.maxX && p.Extent.maxX >= Extent.minX)
                &&
                (p.Extent.minY <= Extent.maxY && p.Extent.minY >= Extent.minY) || (p.Extent.maxY <= Extent.maxY && p.Extent.maxY >= Extent.minY)
                ) return true;
            else return false;
        }
        public bool Intersects(NetPlugins2.PolygoneEtude p)
        {
            if (p.Extent.maxX == Null.D || p.Extent.maxY == Null.D || p.Extent.minX == Null.D || p.Extent.minY == Null.D) return false;
            if (Extent == null) return false;

            if (
                (p.Extent.minX <= Extent.maxX && p.Extent.minX >= Extent.minX) || (p.Extent.maxX <= Extent.maxX && p.Extent.maxX >= Extent.minX)
                &&
                (p.Extent.minY <= Extent.maxY && p.Extent.minY >= Extent.minY) || (p.Extent.maxY <= Extent.maxY && p.Extent.maxY >= Extent.minY)
                ) return true;
            else return false;
        }
    }



    
}
