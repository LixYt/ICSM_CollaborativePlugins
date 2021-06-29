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

namespace XICSM.MiscTools
{
    class Translations
    {
        public static void ImportFile()
        {
            List<string> LangFiles = new List<string>();

            Tools.MiscProgressBar bar = new Tools.MiscProgressBar();

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
                    YImportOp import = new YImportOp
                    {
                        m_imported_by = IM.ConnectedUser(),
                        m_source_name = l.SelectedItem
                    };
                    import.AllocID();
                    import.Save();
                    
                    //string fileContent = File.ReadAllText(l.SelectedItem);
                    YXmiscTranslations itemTranslation = null;

                    FileStream fileStream = File.OpenRead(l.SelectedItem);
                    StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128);

                    int NbLines = 0;
                    while (( streamReader.ReadLine()) != null) { NbLines++; }
                    streamReader.Close();

                    bar.MaxValue = NbLines;
                    bar.Title = "Import of Translations";
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
        static public bool GenerateFile(IMQueryMenuNode.Context context)
        {
            

            return true; //Return true if query should be refreshed due to modification of some record(s)
        }
        
    }
}
