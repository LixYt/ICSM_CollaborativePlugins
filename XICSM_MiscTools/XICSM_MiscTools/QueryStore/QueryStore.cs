using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICSM;
using OrmCs;
using FormsCs;
using System.Windows.Forms;

namespace XICSM.MiscTools
{
    class QueryStore
    {
        static public bool NewRecord(IMQueryMenuNode.Context context)
        {
            QueryStoreEditor edt = new QueryStoreEditor();
            
            return (edt.ShowDialog() == DialogResult.OK ? true : false); //Return true if query should be refreshed due to modification of some record(s)
        }
        static public bool NewRecordFromClipboard(IMQueryMenuNode.Context context)
        {
            QueryStoreEditor edt = new QueryStoreEditor(Clipboard.GetText());

            return (edt.ShowDialog() == DialogResult.OK ? true : false); //Return true if query should be refreshed due to modification of some record(s)
        }
        static public bool DeleteRecord(IMQueryMenuNode.Context context)
        {
            YXmiscQuerystore y = new YXmiscQuerystore(); y.Fetch(context.TableId);
            y.Delete();

            return true; //Return true if query should be refreshed due to modification of some record(s)
        }
        static public bool DeleteRecords(IMQueryMenuNode.Context context)
        {
            YXmiscQuerystore y = new YXmiscQuerystore();
            y.Filter = context.DataList.GetOQLFilter(true);
            for (y.OpenRs(); !y.IsEOF(); y.MoveNext())
            {
                y.DeleteNotUsingPK();
            }
           

            return true; //Return true if query should be refreshed due to modification of some record(s)
        }
        static public bool GetConfig(IMQueryMenuNode.Context context)
        {
            YXmiscQuerystore y = new YXmiscQuerystore(); y.Fetch(context.TableId);
            Clipboard.SetText(y.m_itemstore);
            MessageBox.Show("Query configuration set into clipboard. Go into the correct query and past it into the query editor.");
            return false; //Return true if query should be refreshed due to modification of some record(s)
        }
    }
}
