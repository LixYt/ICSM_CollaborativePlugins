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
            List<IMQueryMenuNode> lst_DataCopy = new List<IMQueryMenuNode>();
            
            //All tables
            if (nbSelMin >= 1 && IM.GetWorkspaceString("VanillaContextualTools") == "Display")
            {
                if (nbSelMin == 1)
                {
                    lst.Add(new IMQueryMenuNode(L.Txt("Export as Json"), null, ExportAsJson, IMQueryMenuNode.ExecMode.FirstRecord));
                    lst_DataCopy.Add(new IMQueryMenuNode(L.Txt("Copy (Select data/fields to copy)"), null, SelectDataToCopy, IMQueryMenuNode.ExecMode.FirstRecord));
                }
                else if (nbSelMin > 1)
                {
                    lst.Add(new IMQueryMenuNode(L.Txt("Export as Json"), null, ExportAllAsJson, IMQueryMenuNode.ExecMode.EachRecord));
                }
                else { }

                if (nbSelMin >= 1 && IM.GetWorkspaceString("SmartCopy_Table") == tableName)
                {      
                    lst_DataCopy.Add(new IMQueryMenuNode(L.Txt("Paste"), null, SetSelectedData, IMQueryMenuNode.ExecMode.SelectionOfRecords));
                }
            }

            //Microwaves
            if (tableName == "MICROWA" && nbSelMin == 1 &&
                IM.GetWorkspaceString("VanillaContextualTools") == "Display")
            {
                lst.Add(new IMQueryMenuNode(L.Txt("Convert to Other Terrestrial Stations"), null, Converter.ConvertMwToOt, IMQueryMenuNode.ExecMode.FirstRecord));
            }
            
            //Other Terrestrial Stations
            if (tableName.Contains("MOB_STATION") && 
                    IM.GetWorkspaceString("VanillaContextualTools") == "Display")
            {
                List<IMQueryMenuNode> lst2 = new List<IMQueryMenuNode>();
                if (nbSelMin == 1)
                {
                    lst2.Add(new IMQueryMenuNode(L.Txt("Swap Tx and Rx frequencies"), null, Converter.ReverseTxRx, IMQueryMenuNode.ExecMode.FirstRecord));
                    lst2.Add(new IMQueryMenuNode(L.Txt("Set Tx/Rx frequencies from Simplex to Half-duplex"), null, Converter.SetFreqsSimplexToHalfDuplex, IMQueryMenuNode.ExecMode.FirstRecord));
                }
                else if (nbSelMin > 1)
                {
                    lst2.Add(new IMQueryMenuNode(L.Txt("Swap Tx and Rx frequencies"), null, Converter.AllReverseTxRx, IMQueryMenuNode.ExecMode.SelectionOfRecords));
                    lst2.Add(new IMQueryMenuNode(L.Txt("Set Tx/Rx frequencies from Simplex to Half-duplex"), null, Converter.AllSetFreqsSimplexToHalfDuplex, IMQueryMenuNode.ExecMode.SelectionOfRecords));
                }

                lst.Add(new IMQueryMenuNode(L.Txt("Frequencies tools"), lst2));
            }

            //Views
            if (tableName == "ALL_TXRX_FREQ" && nbSelMin >= 1)
            {
                lst.Add(new IMQueryMenuNode(L.Txt("Search for potential interferer"), null, SearchInterf.builder, IMQueryMenuNode.ExecMode.SelectionOfRecords));
            }

            //Attached documents
            if (tableName == "DOCLINK" && nbSelMin == 1)
            {
                List<IMQueryMenuNode> lst_DocLink = new List<IMQueryMenuNode>();
                    lst.Add(new IMQueryMenuNode(L.Txt("Does this document exist ?"), null, TableTools.DocLinkTools.CheckDoc, IMQueryMenuNode.ExecMode.FirstRecord));
                    lst.Add(new IMQueryMenuNode(L.Txt("Open Document"), null, TableTools.DocLinkTools.OpenDoc, IMQueryMenuNode.ExecMode.FirstRecord));
                    lst.Add(new IMQueryMenuNode(L.Txt("Open related Directory"), null, TableTools.DocLinkTools.OpenRelatedDir, IMQueryMenuNode.ExecMode.FirstRecord));
                lst.Add(new IMQueryMenuNode(L.Txt("Document tools"), lst_DocLink));
            }
            
            //Allocations
            if (tableName == "RR_NOTE" && nbSelMin == 1)
            {
                lst.Add(new IMQueryMenuNode(L.Txt("Compare to previous version"), null, TableTools.AllocationsTools.CheckNote, IMQueryMenuNode.ExecMode.FirstRecord));
            }

            if (lst_DataCopy.Count > 0 ) lst.Add(new IMQueryMenuNode(L.Txt("Smart copy"), lst_DataCopy));
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

        public static bool SelectDataToCopy(IMQueryMenuNode.Context context)
        {
            Yyy obj = Yyy.CreateObject(context.TableName);
            obj.LoadWithComponents2(context.TableId);

            FieldSelector f = new FieldSelector(obj);
            if (f.ShowDialog() == DialogResult.OK)
            {
                IM.SetWorkspaceString("SmartCopy_Fields", f.SelectedFields.ToCsvString());
                IM.SetWorkspaceString("SmartCopy_Table", context.TableName);
                IM.SetWorkspaceString("SmartCopy_SourceID", context.TableId.ToString());
            }

            return false;
        }

        public static bool SetSelectedData(IMQueryMenuNode.Context context)
        {
            if (context.TableName != IM.GetWorkspaceString("SmartCopy_Table"))
            {
                MessageBox.Show(L.TxT("Unable to copy data because data source is not from the same table."));
                return false;
            }

            Yyy ySource = Yyy.CreateObject(context.TableName);
            ySource.LoadWithComponents2(int.Parse(IM.GetWorkspaceString("SmartCopy_SourceID")));

            Yyy yTarget = Yyy.CreateObject(context.TableName);
            yTarget.Format("*");
            yTarget.Filter = context.DataList.GetOQLFilter(true);

            
            for (yTarget.OpenRs(); !yTarget.IsEOF(); yTarget.MoveNext())
            {
                string changes = "";
                List<string> fields = IM.GetWorkspaceString("SmartCopy_Fields").FromCsvString();
                foreach (string s in fields)
                {
                    changes += s.ToUpper() + L.TxT(" was ") + yTarget.Get(s.ToUpper()).ToString() + L.TxT(" and changed to ") 
                        + ySource.Get(s.ToUpper()).ToString() + "\r\n";
                    object src = ySource.Get(s.ToUpper());
                    yTarget.Set(s.ToUpper(), src);
                }
                yTarget.Save();
                yTarget.SaveTrace(
                    L.TxT("Smart copy"), 
                    $"Data source is {context.TableName}.ID={IM.GetWorkspaceString("SmartCopy_SourceID")}", 
                    changes);
            }

            IM.SetWorkspaceString("SmartCopy_Fields", "");
            IM.SetWorkspaceString("SmartCopy_Table", "");
            IM.SetWorkspaceString("SmartCopy_SourceID", "");
            return true;
        }
    }
}
