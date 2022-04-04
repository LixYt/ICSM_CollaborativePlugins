using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrmCs;
using ICSM;
using DatalayerCs;
using XICSM.VanillaTools.Tools;

namespace XICSM.VanillaTools
{
    class Checkers
    {
        
        public Checkers()
        {
            
        }

        public static void AttachedDocuements()
        {
            YDoclink docs = new YDoclink();
            IMLogFile log = new IMLogFile();
            log.Create("AttachedDocumentsChecker");
            log.Info("===============================================================\r\n");
            log.Info("        Checking Attached Documents database integrity \r\n");
            log.Info("===============================================================\r\n");

            string SharedDirPath = ICSMConfig.Item("SHDIR-DOC");
            //IM.ExecuteScalar(ref SharedDirPath, "SELECT WHAT FROM SYS_CONFIG WHERE ITEM = 'SHDIR-DOC'");
            
            MiscProgressBar bar = new MiscProgressBar(L.Txt("Checking Attached docs"));
            docs.Format("*,Storage,DocPath"); docs.Fetch("REC_ID <> 0");
            bar.MaxValue = docs.Count(true);
            bar.Show();
            for (docs.OpenRs(); !docs.IsEOF(); docs.MoveNext())
            {
                if (docs.m_Storage == "F")
                {
                    if (docs.m_path.StartsWith("http://") || docs.m_path.StartsWith("https://") || docs.m_path.StartsWith("ftp://")) //is URL
                    {
                        bar.UpdateMessage("Checking an URL...");
                        if (!docs.m_DocPath.isReachableURL())
                        {
                            log.Warning($"{docs.m_rec_tab}.ID={docs.m_rec_id} => Can't reach the follwing URL : {docs.m_DocPath}\r\n");
                        }
                    }
                    else //is probably file so let's test if it exists
                    {
                        bar.UpdateMessage("Checking a file...");
                        if (!File.Exists(docs.m_DocPath) 
                            && !File.Exists($@"{SharedDirPath}\{docs.m_DocPath}") 
                            && !File.Exists($@"{SharedDirPath}{docs.m_DocPath}"))
                        {
                            log.Error($"{docs.m_rec_tab}.ID={docs.m_rec_id} => Document does not exist {docs.m_DocPath}\r\n");
                        }
                    }
                }
                bar.PerformStep($"Checked {docs.m_rec_tab}.{docs.m_rec_id}");
            }
            bar.Close();
            log.Display("Attached documents integrity repport");
        }

    }
}
