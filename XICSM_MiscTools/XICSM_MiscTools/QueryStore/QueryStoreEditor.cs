using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatalayerCs;
using OrmCs;
using ICSM;
using NetPlugins2;
using XICSM.VanillaTools.Tools;

namespace XICSM.MiscTools
{
    public partial class QueryStoreEditor : EntityMainMetroForm
    {
        YXmiscQuerystore yQS;

        public static bool EditRecord(int isId, IntPtr owner)
        {
            if (isId.IsNull()) return false;
            Cursor.Current = Cursors.WaitCursor;
            YXmiscQuerystore y = new YXmiscQuerystore();
            y.Fetch(isId);
            QueryStoreEditor dlg = new QueryStoreEditor(y);
            EntityEditOptions opt = new EntityEditOptions();
            opt.CurForm = owner;
            return dlg.Edit("XMISC_QUERYSTORE", isId, opt);
        }
        public static bool EditRecord(IMQueryMenuNode.Context context)
        {
            YXmiscQuerystore y = new YXmiscQuerystore();
            y.Fetch(context.TableId);

            QueryStoreEditor edt = new QueryStoreEditor(y);
            edt.ShowDialog();

            return (edt.DialogResult == DialogResult.OK ? true : false); //Return true if query should be refreshed due to modification of some record(s)
        }
        public QueryStoreEditor()
        {
            InitializeComponent();
            yQS = new YXmiscQuerystore();
            Bindings();
        }

        public QueryStoreEditor(string s)
        {
            InitializeComponent();

            l_desc.Text = L.Txt("Description");
            l_name.Text = L.Txt("Name");
            l_type.Text = L.Txt("Type");
            l_tablename.Text = L.Txt("Table name");
            l_dbEngines.Text = L.Txt("Database engine compatibility");
            l_item.Text = L.Txt("Item stored");
            c_paste.Text = L.Txt("query config from clipboard");
            Save.Text = L.Txt("Save");
            SaveExit.Text = L.Txt("Save and Exit");
            CancelExit.Text = L.Txt("Cancel and Exit");
            Text = L.Txt("Query Store Editor");
            l_created.Text = L.Txt("Created");
            l_created.Text = L.Txt("Modified");

            yQS = new YXmiscQuerystore();
            yQS.m_itemstore = s;
            Bindings();
        }

        public QueryStoreEditor(YXmiscQuerystore y)
        {
            InitializeComponent();
            yQS = y;
            Bindings();
        }

        public void Bindings()
        {
            c_table.Items.AddRange(XTools.GetICSmTables().ToArray());

            c_type.DataBindings.Add(new Binding("Value", yQS, "m_type"));
            c_Engines.DataBindings.Add(new Binding("Value", yQS, "m_engine"));
            c_table.DataBindings.Add(new Binding("Text", yQS, "m_table_name"));

            c_name.DataBindings.Add(new Binding("Text", yQS, "m_name"));
            c_desc.DataBindings.Add(new Binding("Text", yQS, "m_description"));
            c_item.DataBindings.Add(new Binding("Text", yQS, "m_itemstore"));
            C_CreatedBy.DataBindings.Add(new Binding("Text", yQS, "m_created_by"));
            C_ModifiedBy.DataBindings.Add(new Binding("Text", yQS, "m_modified_by"));

            C_CreatedDate.DataBindings.Add(new Binding("Text", yQS, "m_date_created"));
            C_ModifiedDate.DataBindings.Add(new Binding("Text", yQS, "m_date_modified"));
            
        }
        public void SaveY()
        {
            yQS.CreatedByModifiedBy();
            yQS.AllocID();
            yQS.Save();
        }


        private void Save_Click(object sender, EventArgs e)
        {
            if (yQS.m_name != "" && yQS.m_engine != "" && yQS.m_table_name != "") { SaveY(); }
            else { MessageBox.Show(L.Txt("Please define a name and set the table name and database engines compatibility")); }
            //DialogResult = DialogResult.OK;
        }

        private void SaveExit_Click(object sender, EventArgs e)
        {
            SaveY();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelExit_Click(object sender, EventArgs e)
        {
            DialogResult = (DialogResult == DialogResult.OK ? DialogResult : DialogResult.Cancel);
            Close();
        }

        private void c_paste_Click(object sender, EventArgs e)
        {
            c_item.Text = Clipboard.GetText();
            c_table.Text = FindTableName(c_item.Text);
        }

        private void QueryStoreEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private string FindTableName(string query)
        {
            foreach(string line in query.Split(new string[] { Environment.NewLine, "\n", "\r\n", "\r"}, 
                StringSplitOptions.RemoveEmptyEntries))
            {
                if (line.Contains("Table="))
                {
                    return line.Split('=')[1].Trim();
                }
            }
            return "";
        }
    }
}
