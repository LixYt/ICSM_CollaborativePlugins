using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICSM;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace XICSM.MiscTools.Translations
{
    class Translations
    {
        public static void ImportFile()
        {
            List<string> LangFiles = new List<string>();
            
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (FileInfo flInfo in dir.GetFiles())
            {
                if (flInfo.Name.StartsWith("SYS_") && flInfo.Name.EndsWith(".txt")) LangFiles.Add(flInfo.Name);
            }

            LangSelection l = new LangSelection(LangFiles);
            if (l.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(l.SelectedItem);
            }
            
        }
    }
}
