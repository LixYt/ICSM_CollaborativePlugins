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
using System.Data.OleDb;
using System.Windows.Forms;
using System.Diagnostics;

namespace XICSM.VanillaTools
{
    class Checkers
    {
        public List<KeyValuePair<int, string>> LostDoc = new List<KeyValuePair<int, string>>();
        public Checkers()
        {
            
        }
        public void AttachedDocuements()
        {
            YDoclink docs = new YDoclink();
            IMLogFile log = new IMLogFile();
            log.Create("AttachedDocumentsChecker");
            log.Info("===============================================================\r\n");
            log.Info(L.TxT("        Checking Attached Documents database integrity \r\n"));
            log.Info("===============================================================\r\n");
          
            MiscProgressBar bar = new MiscProgressBar(L.Txt("Checking Attached docs"));
            docs.Format("*,Storage,DocPath"); docs.Fetch("REC_ID <> 0");
            bar.MaxValue = docs.Count(true);
            bar.Show();
            for (docs.OpenRs(); !docs.IsEOF(); docs.MoveNext())
            {
                if (docs.m_Storage == "F")
                {
                    if (!docs.m_path.DocumentExists()) 
                    {
                        log.Error($"{docs.m_rec_tab}.ID={docs.m_rec_id};Document does not exist;{docs.m_DocPath}\r\n");
                        LostDoc.Add(new KeyValuePair<int, string>(docs.m_id, docs.m_path));
                    }
                }
                bar.PerformStep($"Checked {docs.m_rec_tab}.{docs.m_rec_id}");
            }
            bar.Close();
            log.Display(L.TxT("Attached documents integrity repport"));

            if (MessageBox.Show(L.TxT("Dou you want to let ICS Manager try to repair broken document link ? "), L.TxT("Auto repair ?"), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SearchAndRepairBrokenDocuments();
            }

        }
        public string ReplaceDocument(int id, string NewDoc, string file)
        {
            YDoclink docs = new YDoclink();
            docs.LoadWithComponents2(id);
            string OriginalDoc = docs.m_path;
            docs.m_path = $@"{NewDoc}\{file}";
            string str = $@"Original document link is = {OriginalDoc}.\r\n New document link is {NewDoc}\{file}";
            docs.SaveWithTrace(L.TxT("Fixing broken path"), L.TxT("VanillaTools auto repair"), str);
            return str;
        }
        public void SearchAndRepairBrokenDocuments()
        {
            IMLogFile log = new IMLogFile();
            log.Create("AttachedDocumentsChecker");
            log.Info("===============================================================\r\n");
            log.Info(L.TxT("        Auto-replacement for broken document links \r\n"));
            log.Info("===============================================================\r\n");

            MiscProgressBar bar = new MiscProgressBar(L.Txt("Auto repair broken doc link"));
            bar.MaxValue = LostDoc.Count;
            bar.Show();

            FolderBrowserDialog fbd = new FolderBrowserDialog()
            {
                ShowNewFolderButton = false,
                RootFolder = Environment.SpecialFolder.MyComputer,
                Description = L.TxT("Select a root folder to search in"),
            };
            
            if (fbd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show(L.TxT("Repair is cancel..."));
            }

            string SharedDirPath = ICSMConfig.Item("SHDIR-DOC");

            var connection = new OleDbConnection(@"Provider=Search.CollatorDSO;Extended Properties=""Application=Windows""");
            connection.Open();

            foreach (KeyValuePair<int, string> kvp in LostDoc)
            {
                string file = "";
                if (kvp.Value.StartsWith(@"http://") || kvp.Value.StartsWith(@"https://") || kvp.Value.StartsWith(@"ftp://")) { bar.PerformStep(); continue; }
                else if (kvp.Value.StartsWith(@"\\") || kvp.Value.Substring(1, 2) == @":\" || 
                    SharedDirPath.StartsWith(@"\\") || SharedDirPath.Substring(1, 2) == @":\")
                {
                    string[] f = kvp.Value.Split('\\');
                    file = f[f.Length - 1];
                }
                else
                {
                    bar.PerformStep(); continue;
                }

                log.Info(L.TxT("Search for document ") + kvp.Value + "\r\n");
                var query1 = @"SELECT System.ItemFolderPathDisplay FROM SystemIndex " +
                $@"WHERE scope ='file:{fbd.SelectedPath}' AND System.ItemName LIKE '%{file}%'";

                List<string> Lreplace = new List<string>();
                var command = new OleDbCommand(query1, connection);
                using (var r = command.ExecuteReader())
                {
                    while (r.Read())
                    {
                        Lreplace.Add(r[0].ToString());
                    }
                }

                if (Lreplace.Count == 1)
                {
                    log.Info(L.TxT("Document found and replaced by : ") + Lreplace.First() + "\r\n");
                    ReplaceDocument(kvp.Key, Lreplace.First(), file);
                }
                else if (Lreplace.Count > 1)
                {
                    SelectCombox s = new SelectCombox()
                    {
                        Title = L.TxT($"List of Path where {file} file has been detected."),
                    };
                    s.Items.AddRange(Lreplace.ToArray());
                    if (s.ShowDialog() == DialogResult.OK)
                    {
                        log.Info(L.TxT("Document found and replaced by user selection : ") + s.SelectedItem + "\r\n");
                        ReplaceDocument(kvp.Key, s.SelectedItem, file);
                    }
                    else { log.Info(L.TxT("User canceled selection. No replacement done even if some files were found.\r\n")); }
                }
                else
                {
                    log.Info(L.TxT("No document found.\r\n"));
                }
            }
            connection.Close();
            bar.PerformStep();
            bar.Close();

            log.Display(L.TxT("Result of Auto-replacement for broken document links"));
        }
    }
}
