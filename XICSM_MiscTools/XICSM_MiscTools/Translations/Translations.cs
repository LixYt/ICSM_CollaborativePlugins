using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICSM;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using OrmCs;
using System.Diagnostics;
using DatalayerCs;
using XICSM.VanillaTools.Tools;

namespace XICSM.MiscTools
{
    class Translations
    {
        public static void ImportStrings()
        {
            List<string> LangFiles = new List<string>();

            MiscProgressBar bar = new MiscProgressBar(L.Txt("Importing STRINGS file"));
            MiscProgressBar bar2 = new MiscProgressBar(L.Txt("Added STRINGS file to selected language translation"));

            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            DirectoryInfo dir = new DirectoryInfo(new Uri(path).LocalPath);
            foreach (FileInfo flInfo in dir.GetFiles())
            {
                if (flInfo.Name.StartsWith("SYS_") && flInfo.Name.EndsWith(".txt")) LangFiles.Add(flInfo.Name);
            }

            LangSelection l = new LangSelection(LangFiles);
            if (l.ShowDialog() == DialogResult.OK)
            {
                string lang = l.SelectedItem.Trim("SYS_".ToCharArray()).Trim(".txt".ToCharArray());
                DateTime start = DateTime.Now;
                int i = 1; int j = 1; int k = 0;
                List<string> stringsItems = new List<string>();
                try
                {
                    YXmiscTranslations itemTranslation = null;

                    FileStream fileStream = File.OpenRead("STRINGS.txt");
                    StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128);

                    string str;
                    while ((str = streamReader.ReadLine()) != null) { stringsItems.Add(str); }
                    streamReader.Close();

                    DialogResult q = MessageBox.Show(L.Txt("Do you want to skip adding STRINGS and go to tag obsolete strings ?"), L.Txt("Skip ?"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (q == DialogResult.No)
                    {
                        YImportOp import = new YImportOp
                        {
                            m_imported_by = IM.ConnectedUser(),
                            m_source_name = l.SelectedItem,
                            m_creat_date = DateTime.Now,
                            m_dest_table = "XMISC_TRANSLATIONS",
                            m_nb_imp = stringsItems.Count,
                            m_source_fmt = L.Txt("ICS Manager STRINGS txt file"),
                        };
                        import.AllocID();
                        import.Save();

                        bar.MaxValue = stringsItems.Count;
                        bar2.MaxValue = stringsItems.Count;
                        bar.Show();
                        bar2.Location = new System.Drawing.Point(bar.Location.X + 100, bar.Location.Y + 100);
                        bar2.Show();
                        bar2.Location = new System.Drawing.Point(bar.Location.X + 100, bar.Location.Y + 100);

                        foreach (string line in stringsItems)
                        {
                            string TrimedLine = line.Trim('"').Replace("'", "''");
                            i++;
                            if (TrimedLine.Contains("[") || TrimedLine.Contains("]")) continue;
                            itemTranslation = new YXmiscTranslations();
                            itemTranslation.Filter = $@"lang like '{lang}' AND from_string like '{TrimedLine}'";
                            int c = itemTranslation.Count();
                            if (itemTranslation.Count() == 0)
                            {
                                itemTranslation = new YXmiscTranslations();
                                itemTranslation.AllocID();
                                itemTranslation.m_impop_id = import.m_id;
                                itemTranslation.m_from_string = TrimedLine.ToSql();
                                itemTranslation.m_to_string = "??";
                                itemTranslation.m_lang = lang;
                                itemTranslation.m_isfromstrings = 1;
                                itemTranslation.Save();
                                j++;
                                bar2.PerformStep();
                            }

                            bar.PerformStep();
                        }

                        bar.Close(); bar2.Close();
                        bar.Dispose(); bar2.Dispose();
                    }
                    
                    MiscProgressBar bar3 = new MiscProgressBar(L.Txt("Detecting OBSOLETE strings"));
                    bar3.Show();
                    MiscProgressBar bar4 = new MiscProgressBar(L.Txt("Marked OBSOLETE translation"));
                    bar4.Show();
                    bar4.Location = new System.Drawing.Point(bar3.Location.X + 100, bar3.Location.Y + 100);

                   
                    YXmiscTranslations transLang = new YXmiscTranslations();
                    transLang.Format("*"); transLang.Fetch($@"lang LIKE '{lang}'");
                    bar3.MaxValue = transLang.Count(); 
                    bar4.MaxValue = transLang.Count();
                    for (transLang.OpenRs(); !transLang.IsEOF(); transLang.MoveNext())
                    {
                        if (!stringsItems.Contains($"\"{transLang.m_from_string}\""))
                        {
                            transLang.m_isobsolete = 1;
                            transLang.Save();
                            bar4.PerformStep();
                            k++;
                        }
                        bar3.PerformStep();
                    }

                    bar3.Close(); bar4.Close();
                    bar3.Dispose(); bar4.Dispose();
                    
                    TimeSpan duration = start - DateTime.Now;
                    MessageBox.Show($"{j} "+ L.Txt("strings added to ") + $"{ lang}. {k} " + L.Txt("strings marked as obsolete."));
                    MessageBox.Show(L.Txt("Update ended in") + $"{duration}");
                }
                catch (Exception e) 
                {
                    Debug.WriteLine($"{e}"); 
                }

            }
            else
            {
                MessageBox.Show(L.Txt("STRINGS import cancelled"));
            }


        }
        public static void ImportFile()
        {
            List<string> LangFiles = new List<string>();
            List<string> stringsItems = new List<string>();
            List<string> CustomDbNames = new List<string>() { "TXT","NBR","CHB","DAT" };

            MiscProgressBar bar = new MiscProgressBar(L.Txt("Importing LANG file"));

            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            DirectoryInfo dir = new DirectoryInfo(new Uri(path).LocalPath);
            foreach (FileInfo flInfo in dir.GetFiles())
            {
                if (flInfo.Name.StartsWith("SYS_") && flInfo.Name.EndsWith(".txt")) LangFiles.Add(flInfo.Name);
            }

            LangSelection l = new LangSelection(LangFiles);
            if (l.ShowDialog() == DialogResult.OK)
            {
                DateTime start = DateTime.Now;
                try
                {
                    YXmiscTranslations itemTranslation = null;
                    string filePath = new Uri($@"{path}\{l.SelectedItem}").LocalPath;
                    FileStream fileStream = File.OpenRead(filePath);
                    StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128);

                    string str;
                    while ((str = streamReader.ReadLine()) != null) { stringsItems.Add(str); }
                    streamReader.Close();

                    YImportOp import = new YImportOp
                    {
                        m_imported_by = IM.ConnectedUser(),
                        m_source_name = l.SelectedItem,
                        m_creat_date = DateTime.Now,
                        m_dest_table = "XMISC_TRANSLATIONS",
                        m_nb_imp = stringsItems.Count,
                        m_source_fmt = L.Txt("Native ICS Manager language txt file"),
                    };
                    import.AllocID();
                    import.Save();

                    bar.MaxValue = stringsItems.Count;
                    bar.Show();

                    int i = 1;
                    string lang = l.SelectedItem.Trim("SYS_".ToCharArray()).Trim(".txt".ToCharArray());
                    string sql = $"DELETE FROM %XMISC_TRANSLATIONS WHERE LANG like '{lang}'";
                    IM.Execute(sql);

                    foreach(string line in stringsItems)
                    {
                        if (line.StartsWith("\"") && itemTranslation == null)
                        {
                            itemTranslation = new YXmiscTranslations(); itemTranslation.AllocID();
                            string TrimmedLine = line.Trim('"');
                            string TestCustomField = TrimmedLine.Substring(TrimmedLine.Length >= 5 ? TrimmedLine.Length - 5 : 0);
                            if (TestCustomField.Substring(0, 1) == "_" && CustomDbNames.Contains(TestCustomField.Substring(1, 3)))
                                {itemTranslation.m_iscustomf = 1; }
                            TestCustomField = TrimmedLine.Substring(TrimmedLine.Length >= 6 ? TrimmedLine.Length - 6 : 0);
                            if (TestCustomField.Substring(0, 1) == "_" && CustomDbNames.Contains(TestCustomField.Substring(1, 3)))
                            { itemTranslation.m_iscustomf = 1; }
                            itemTranslation.m_from_string = TrimmedLine;
                            itemTranslation.m_impop_id = import.m_id;
                            itemTranslation.m_lang = lang;
                        }
                        else if (line.StartsWith(">") && itemTranslation != null)
                        {
                            itemTranslation.m_to_string = line.Substring(2).Trim('"');
                            itemTranslation.Save();

                            itemTranslation = null;
                        }
                        else if (line.StartsWith("\"") && itemTranslation != null)
                        {
                            streamReader.Close();
                            fileStream.Close();
                            throw new Exception(L.Txt("Looks like there is a new line but a previous one is not translated"));
                        }
                        else if (line.StartsWith(">") && itemTranslation == null)
                        {
                            streamReader.Close();
                            fileStream.Close();
                            throw new Exception(L.Txt("Looks like the line is a target translation but has no source string"));
                        }
                        else if (line == "LANGUAGE  ") { }
                        else 
                        {
                            Debug.WriteLine($"[Misc] Unexpected case");
                        }
                        i++;
                        bar.PerformStep();
                    }

                    
                }
                catch (Exception e) { MessageBox.Show(e.Message); }

                bar.Close();
                bar.Dispose();

                TimeSpan duration = start - DateTime.Now;
                MessageBox.Show(L.Txt("Import ended in") + $"{duration}");
            }
            else
            {
                MessageBox.Show(L.Txt("Language import cancelled"));
            }
            

        }
        public static void ExportFile()
        {
            List<string> LangFiles = new List<string>();

            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            DirectoryInfo dir = new DirectoryInfo(new Uri(path).LocalPath);
            foreach (FileInfo flInfo in dir.GetFiles())
            {
                if (flInfo.Name.StartsWith("SYS_") && flInfo.Name.EndsWith(".txt")) LangFiles.Add(flInfo.Name);
            }

            LangSelection l = new LangSelection(LangFiles);
            if (l.ShowDialog() == DialogResult.OK)
            {
                YXmiscTranslations translations = new YXmiscTranslations();
                string lang = l.SelectedItem.Trim("SYS_".ToCharArray()).Trim(".txt".ToCharArray());
                translations.Filter = $"LANG like '{lang}'";

                GenerateLangFile(translations);
            }
            else
            {
                MessageBox.Show(L.Txt("Language export cancelled"));
            }

        }
        static public bool DeleteRecord(IMQueryMenuNode.Context context)
        {
            YXmiscTranslations y = new YXmiscTranslations(); y.Fetch(context.TableId);
            y.Delete();

            return true; //Return true if query should be refreshed due to modification of some record(s)
        }
        static public bool DeleteRecords(IMQueryMenuNode.Context context)
        {
            YXmiscTranslations y = new YXmiscTranslations();
            y.Filter = context.DataList.GetOQLFilter(true);
            for (y.OpenRs(); !y.IsEOF(); y.MoveNext())
            {
                y.DeleteNotUsingPK();
            }


            return true; //Return true if query should be refreshed due to modification of some record(s)
        }
        static public bool ExportAsLangFile(IMQueryMenuNode.Context context)
        {
            YXmiscTranslations translations = new YXmiscTranslations
            {
                Filter = context.DataList.GetOQLFilter(true),
            };

            GenerateLangFile(translations);

            return false;
        }
        static public void GenerateLangFile(YXmiscTranslations translations)
        {
            try
            {
                MiscProgressBar bar = new MiscProgressBar(L.Txt("Exporting LANG file"));
                bar.MaxValue = translations.Count();

                SaveFileDialog saveFileDialog1 = new SaveFileDialog
                {
                    Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                    FilterIndex = 2,
                    RestoreDirectory = true,
                };

                bar.Show();

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string OutFile = L.TxT("LANGUAGE  \r\n");

                    for (translations.OpenRs(); !translations.IsEOF(); translations.MoveNext())
                    {
                        string replacement = (translations.m_to_string == "??") ? translations.m_to_string : $"\"{translations.m_to_string}\"";
                        OutFile += $"\"{translations.m_from_string}\"\r\n> {replacement}\r\n";
                        bar.PerformStep();
                    }
                    File.WriteAllText(saveFileDialog1.FileName, OutFile, Encoding.Unicode);
                }

                MessageBox.Show(L.Txt($"Language {translations.m_lang} exported"));

                bar.Close();
                bar.Dispose(); 
            } 
            catch (Exception e) { Debug.WriteLine(e); }
        }
        
    }
}
