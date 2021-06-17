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

namespace XICSM.MiscTools.Translations
{
    class Translations
    {
        public static void ImportFile()
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
                try
                {
                    YImportOp import = new YImportOp();
                    import.m_imported_by = IM.ConnectedUser();
                    import.m_source_name = l.SelectedItem;
                    import.AllocID();
                    import.Save();

                    //string fileContent = File.ReadAllText(l.SelectedItem);
                    YXmiscTranslations itemTranslation = null;
                    int i = 1;

                    FileStream fileStream = File.OpenRead(l.SelectedItem);
                    StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128);

                    string line; 
                    while ((line = streamReader.ReadLine()) != null)
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
                            streamReader.Close();
                            fileStream.Close(); throw new Exception($"Unexcepted line {i} = {line}"); 
                        }
                        i++;
                    }
                }
                catch (Exception e) { Debug.WriteLine(e); }

            }

            

        }
    }
}
