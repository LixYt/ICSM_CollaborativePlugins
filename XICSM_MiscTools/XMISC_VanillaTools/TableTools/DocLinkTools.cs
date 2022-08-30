using DatalayerCs;
using ICSM;
using OrmCs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XICSM.VanillaTools.Tools;

namespace XICSM.VanillaTools.TableTools
{
    static class DocLinkTools
    {
        public static bool CheckDoc(IMQueryMenuNode.Context context)
        {
            YDoclink doc = new YDoclink();
            doc.LoadWithComponents2(context.TableId);

            MessageBox.Show(doc.m_path.DocumentExists() ? L.TxT("This document has been found.") : L.TxT("This document path is broken."));

            return false;
        }
        public static bool OpenDoc(IMQueryMenuNode.Context context)
        {
            string SharedDirPath = ICSMConfig.Item("SHDIR-DOC");

            YDoclink doc = new YDoclink();
            doc.LoadWithComponents2(context.TableId);

            if (!doc.m_path.DocumentExists()) { MessageBox.Show(L.Txt("Document does not exist.")); return false; }

            if (doc.m_path.Substring(1, 2) == @":\" || doc.m_path.StartsWith(@"\\") ||
                doc.m_path.StartsWith(@"http://") || doc.m_path.StartsWith(@"https://") || doc.m_path.StartsWith(@"ftp://")
               )
            { Process.Start(doc.m_path); }

            else if (SharedDirPath.Substring(1, 2) == @":\" || SharedDirPath.StartsWith(@"\\") ||
                SharedDirPath.StartsWith(@"http://") || SharedDirPath.StartsWith(@"https://") || SharedDirPath.StartsWith(@"ftp://")
                    )
            { Process.Start($@"{SharedDirPath}\{doc.m_path}"); }

            else
            { MessageBox.Show(L.Txt("Unable to open document.")); }

            return false;
        }
        public static bool OpenRelatedDir(IMQueryMenuNode.Context context)
        {
            string SharedDirPath = ICSMConfig.Item("SHDIR-DOC");

            YDoclink doc = new YDoclink();
            doc.LoadWithComponents2(context.TableId);

            if (doc.m_path.StartsWith(@"http://") || doc.m_path.StartsWith(@"https://") || doc.m_path.StartsWith(@"ftp://"))
            { MessageBox.Show(L.Txt("It's not possible to open a directory for an URL/URI.")); return false; }
            else
            {
                if (doc.m_path.Substring(1, 2) == @":\" || doc.m_path.StartsWith(@"\\"))
                {
                    Process.Start(new ProcessStartInfo
                    {
                        Arguments = Path.GetDirectoryName(doc.m_path),
                        FileName = "explorer.exe",
                    });
            }
                else if (SharedDirPath.Substring(1, 2) == @":\" || SharedDirPath.StartsWith(@"\\"))
                {
                    Process.Start(new ProcessStartInfo
                    {
                        Arguments = Path.GetDirectoryName($@"{SharedDirPath}\{doc.m_path}"),
                        FileName = "explorer.exe",
                    });
                }
                else { MessageBox.Show(L.Txt("Unable to open directory.")); return false; }
            }
            return false;
        }
    }
}
