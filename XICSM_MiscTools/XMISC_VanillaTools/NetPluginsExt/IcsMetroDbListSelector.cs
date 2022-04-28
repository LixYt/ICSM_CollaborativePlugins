using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OrmCs;
using FormsCs;
using NetPlugins2;

namespace NetPlugins2Ext
{
    public partial class IcsMetroDbListSelector: IcsMetroForm
    {
        public string ResultFilter { set; get; }
        private string TbNm;
        public IcsMetroDbListSelector(string TableName)
        {
            InitializeComponent();
            DialogResult = DialogResult.None;
            DBList.Table = TableName; TbNm = TableName;
            DBList.ConfigName = "DbListSelector" + TableName;
            DBList.Init();
            //DBList.OnRequery += new EventHandler(OnRequery);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            /*string mainFilter = DBList.GetSelectionAsOQLFilter(false);
            ResultFilter = (Null.IsNull(mainFilter) ? "" : mainFilter)
                + (Null.IsNull(mainFilter) || Null.IsNull(DBList.Filter) ? "": " AND ")
                + (DBList.Filter == "" ? DBList.Filter : "");*/
            ResultFilter = GenerateGlobalFilter(DBList);
            DialogResult = DialogResult.OK;
            Close();
        }

        public static string GenerateGlobalFilter(IcsDBList l)
        {
            string mainFilter = l.GetSelectionAsOQLFilter(false);
            return (Null.IsNull(mainFilter) ? "" : mainFilter)
                + (Null.IsNull(mainFilter) || Null.IsNull(l.Filter) ? "" : " AND ")
                + (l.Filter == "" ? l.Filter : "");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void DBList_OnRequery(object sender, EventArgs e)
        {
            ResultFilter = DBList.Filter;
        }

        private void DBList_OnDefColumns(object sender, EventArgs e)
        {
            Yyy y = Yyy.CreateObject(TbNm);
            string MustBeIn;
            if (y.IsPresent2("ID")) { MustBeIn = "ID"; }
            else if (y.IsPresent2("TBNM") && y.IsPresent2("TBID")) { MustBeIn = "TBID,TBNM"; }
            else if (y.IsPresent2("OBJ_TBID") && y.IsPresent2("OBJ_TBNM")) { MustBeIn = "TBID,TBNM"; }
            else { return; }
            DBList.MustBePresent(MustBeIn);
        }

        private void IcsMetroDbListSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.None) { DialogResult = DialogResult.Cancel; }
        }
    }
}
