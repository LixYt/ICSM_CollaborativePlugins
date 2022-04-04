using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICSM;
using OrmCs;
using FormsCs;
using System.Windows.Forms;
using DatalayerCs;

namespace XICSM.MiscTools
{
    class Contextual
    {
        public static List<IMQueryMenuNode> onGetQueryMenu(string tableName, int nbSelMin)
        {
            List<IMQueryMenuNode> lst = new List<IMQueryMenuNode>();
            if (tableName == "XMISC_QUERYSTORE")
            {
                lst.Add(new IMQueryMenuNode(L.Txt("New query configuration"), null, QueryStore.NewRecord, IMQueryMenuNode.ExecMode.Table));
                lst.Add(new IMQueryMenuNode(L.Txt("New query configuration from clipboard"), null, QueryStore.NewRecordFromClipboard, IMQueryMenuNode.ExecMode.Table));
                if (nbSelMin == 1)
                {
                    lst.Add(new IMQueryMenuNode(L.Txt("Get the query configuration"), null, QueryStore.GetConfig, IMQueryMenuNode.ExecMode.FirstRecord));
                    lst.Add(new IMQueryMenuNode(L.Txt("Edit query record"), null, QueryStoreEditor.EditRecord, IMQueryMenuNode.ExecMode.FirstRecord));
                    lst.Add(new IMQueryMenuNode(L.Txt("Delete query record"), null, QueryStore.DeleteRecord, IMQueryMenuNode.ExecMode.FirstRecord));
                }
                if (nbSelMin > 1)
                {
                    lst.Add(new IMQueryMenuNode(L.Txt("Delete query configuration selection"), null, QueryStore.DeleteRecords, IMQueryMenuNode.ExecMode.SelectionOfRecords));
                }
            }         
            if (tableName == "XMISC_TRANSLATIONS")
            {
                if (nbSelMin == 1)
                {
                    lst.Add(new IMQueryMenuNode(L.Txt("Edit translation"), null, TranslationEditor.EditRecord, IMQueryMenuNode.ExecMode.FirstRecord));
                    
                }
                if (nbSelMin >= 1)
                {
                    lst.Add(new IMQueryMenuNode(L.Txt("Export as LANG File"), null, Translations.ExportAsLangFile, IMQueryMenuNode.ExecMode.SelectionOfRecords));
                    lst.Add(new IMQueryMenuNode(L.Txt("Delete record(s)"), null, Translations.DeleteRecords, IMQueryMenuNode.ExecMode.SelectionOfRecords));
                }
            }

            return lst;
        }

    }
}
