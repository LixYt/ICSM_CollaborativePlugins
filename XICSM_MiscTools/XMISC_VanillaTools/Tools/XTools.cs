using OrmCs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


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
                System.Reflection.Assembly myAssembly = Assembly.Load(CurrentAssembly);

                foreach (Type t in myAssembly.GetTypes())
                {
                    if (!t.Name.StartsWith("Y") || t.Name == "Yyy") continue;
                    try
                    {
                        Yyy obj = (Yyy)Activator.CreateInstance(t);
                        Tables.Add(obj.Table);
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
    }

    
}
