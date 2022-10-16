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
            else if (nbSelMin > 1)
            {
                lst.Add(new IMQueryMenuNode(L.Txt("Export as Json"), null, ExportAllAsJson, IMQueryMenuNode.ExecMode.EachRecord));
            }
            if (tableName == "ALL_TXRX_FREQ" && nbSelMin >= 1)
            {
                //lst.Add(new IMQueryMenuNode(L.Txt("Search for potential interferer"), null, SearchInterf.builder, IMQueryMenuNode.ExecMode.SelectionOfRecords));
            }
            if (tableName == "MICROWA" && nbSelMin == 1 && IM.SpecialRightsActivated())
            {
                lst.Add(new IMQueryMenuNode(L.Txt("Convert to Other Terrestrial Stations"), null, Converter.ConvertMwToOt, IMQueryMenuNode.ExecMode.FirstRecord));
            }
            if (tableName.Contains("MOB_STATION") && nbSelMin == 1 && IM.SpecialRightsActivated())
            {
                List<IMQueryMenuNode> lst2 = new List<IMQueryMenuNode>();
                if (nbSelMin == 1)
                {
                    lst2.Add(new IMQueryMenuNode(L.Txt("Swap Tx and Rx frequencies"), null, Converter.ReverseTxRx, IMQueryMenuNode.ExecMode.FirstRecord));
                    lst2.Add(new IMQueryMenuNode(L.Txt("Set Tx/Rx frequencies from Simplex to Half-duplex"), null, Converter.SetFreqsSimplexToHalfDuplex, IMQueryMenuNode.ExecMode.FirstRecord));
                }
                else if (nbSelMin > 1)
                {
                    lst2.Add(new IMQueryMenuNode(L.Txt("Swap Tx and Rx frequencies"), null, Converter.AllReverseTxRx, IMQueryMenuNode.ExecMode.FirstRecord));
                    lst2.Add(new IMQueryMenuNode(L.Txt("Set Tx/Rx frequencies from Simplex to Half-duplex"), null, Converter.AllSetFreqsSimplexToHalfDuplex, IMQueryMenuNode.ExecMode.FirstRecord));
                }

                lst.Add(new IMQueryMenuNode("Frequencies", lst2));
            }
            if (tableName == "DOCLINK" && nbSelMin == 1)
            {
                lst.Add(new IMQueryMenuNode(L.Txt("Does this document exist ?"), null, TableTools.DocLinkTools.CheckDoc, IMQueryMenuNode.ExecMode.FirstRecord));
                lst.Add(new IMQueryMenuNode(L.Txt("Open Document"), null, TableTools.DocLinkTools.OpenDoc, IMQueryMenuNode.ExecMode.FirstRecord));
                lst.Add(new IMQueryMenuNode(L.Txt("Open related Directory"), null, TableTools.DocLinkTools.OpenRelatedDir, IMQueryMenuNode.ExecMode.FirstRecord));
            }
            if (tableName == "RR_NOTE" && nbSelMin == 1)
            {
                lst.Add(new IMQueryMenuNode(L.Txt("Compare to previous version"), null, TableTools.AllocationsTools.CheckNote, IMQueryMenuNode.ExecMode.FirstRecord));
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
                Filter = "json files (*.json)|*.json",
                FilterIndex = 2,
                RestoreDirectory = true,
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, y.ToJson());
            }
            return false;
        }

        public static bool ExportAllAsJson(IMQueryMenuNode.Context context)
        {
            string json = "";

            Yyy y = Yyy.CreateObject(context.TableName);
            string oql = context.DataList.GetOQLFilter(true);
            y.Filter = context.DataList.GetOQLFilter(true);

            for (y.OpenRs(); !y.IsEOF(); y.MoveNext())
            {
                json += y.ToJson()+"\r\n";
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                DefaultExt = "*.json",
                Filter = "json files (*.json)|*.json",
                FilterIndex = 2,
                RestoreDirectory = true,
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, json);
            }
            return false;
        }
    }
}
