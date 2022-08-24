using DatalayerCs;
using ICSM;
using OrmCs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XICSM.MiscTools;
using XICSM.VanillaTools.Tools;

namespace XICSM.VanillaTools
{
    class Contextual
    {
        public static List<IMQueryMenuNode> onGetQueryMenu(string tableName, int nbSelMin)
        {
            List<IMQueryMenuNode> lst = new List<IMQueryMenuNode>();
            if (nbSelMin == 1)
            {
                lst.Add(new IMQueryMenuNode(L.Txt("Export as Json"), null, ExportAsJson, IMQueryMenuNode.ExecMode.FirstRecord));
            }
            if (tableName == "ALL_TXRX_FREQ" && nbSelMin >= 1)
            {
                lst.Add(new IMQueryMenuNode(L.Txt("Search for potential interferer"), null, SearchInterf.builder, IMQueryMenuNode.ExecMode.FirstRecord));
            }
            if (tableName == "MICROWA" && nbSelMin == 1 && IM.SpecialRightsActivated())
            {
                lst.Add(new IMQueryMenuNode(L.Txt("Convert to Other Terrestrial Stations"), null, Converter.ConvertMwToOt, IMQueryMenuNode.ExecMode.FirstRecord));
            }
            if (tableName == "DOCLINK" && nbSelMin == 1)
            {
                lst.Add(new IMQueryMenuNode(L.Txt("Does this document exist ?"), null, TableTools.DocLinkTools.CheckDoc, IMQueryMenuNode.ExecMode.FirstRecord));
                lst.Add(new IMQueryMenuNode(L.Txt("Open Document"), null, TableTools.DocLinkTools.OpenDoc, IMQueryMenuNode.ExecMode.FirstRecord));
                lst.Add(new IMQueryMenuNode(L.Txt("Open related Directory"), null, TableTools.DocLinkTools.OpenRelatedDir, IMQueryMenuNode.ExecMode.FirstRecord));
            }
            return lst;
        }

        public static bool ExportAsJson(IMQueryMenuNode.Context context)
        {
            Yyy y = Yyy.CreateObject(context.TableName);
            y.LoadWithComponents2(context.TableId);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                DefaultExt = "*.json",
                Filter = "json files (*.json)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, y.ToJson());
            }
            return false;
        }
    }
}
