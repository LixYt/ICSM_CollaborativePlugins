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

namespace XICSM.MiscTools
{
    class Translations
    {
        public static void ImportFile()
        {
            List<string> LangFiles = new List<string>();

            Tools.MiscProgressBar bar = new Tools.MiscProgressBar(L.Txt("Importing LANG file"));

            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            DirectoryInfo dir = new DirectoryInfo(new Uri(path).LocalPath);
            foreach (FileInfo flInfo in dir.GetFiles())
            {
                if (flInfo.Name.StartsWith("SYS_") && flInfo.Name.EndsWith(".txt")) LangFiles.Add(flInfo.Name);
            }

            LangSelection l = new LangSelection(LangFiles);
            if (l.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    YXmiscTranslations itemTranslation = null;

                    FileStream fileStream = File.OpenRead(l.SelectedItem);
                    StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128);

                    int NbLines = 0;
                    while (( streamReader.ReadLine()) != null) { NbLines++; }
                    streamReader.Close();

                    YImportOp import = new YImportOp
                    {
                        m_imported_by = IM.ConnectedUser(),
                        m_source_name = l.SelectedItem,
                        m_creat_date = DateTime.Now,
                        m_dest_table = "XMISC_TRANSLATIONS",
                        m_nb_imp = NbLines,
                        m_source_fmt = L.Txt("Native ICS Manager language txt file"),
                    };
                    import.AllocID();
                    import.Save();

                    bar.MaxValue = NbLines;
                    bar.Show();

                    string line; int i = 1;
                    FileStream fileStream2 = File.OpenRead(l.SelectedItem);
                    StreamReader streamReader2 = new StreamReader(fileStream2, Encoding.UTF8, true, 128);

                    while ((line = streamReader2.ReadLine()) != null)
                    {
                        if (line.StartsWith("\"") && itemTranslation == null)
                        {
                            itemTranslation = new YXmiscTranslations(); itemTranslation.AllocID();

                            itemTranslation.m_from_string = line.Trim('"');
                            itemTranslation.m_impop_id = import.m_id;
                            itemTranslation.m_lang = l.SelectedItem.Trim("SYS_".ToCharArray()).Trim(".txt".ToCharArray());
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
                            throw new Exception("Looks like there is a new line but a previous one is not translated");
                        }
                        else if (line.StartsWith(">") && itemTranslation == null)
                        {
                            streamReader.Close();
                            fileStream.Close();
                            throw new Exception("Looks like the line is a target translation but has no source string");
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
                catch (Exception e) { Debug.WriteLine(e); }

                bar.Close();
                bar.Dispose();
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
        static public bool EditRecord(IMQueryMenuNode.Context context)
        {
            YXmiscTranslations y = new YXmiscTranslations();
            y.Fetch(context.TableId);

            TranslationEditor edt = new TranslationEditor(y);
            edt.ShowDialog();
    
            return (edt.DialogResult == DialogResult.OK ? true : false); //Return true if query should be refreshed due to modification of some record(s)
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
                Tools.MiscProgressBar bar = new Tools.MiscProgressBar(L.Txt("Exporting LANG file"));
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
                    string OutFile = $"LANGUAGE  \r\n";

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
