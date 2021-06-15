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

namespace XICSM.MiscTools
{
    public partial class QueryStoreEditor : Form
    {
        YXmiscQuerystore yQS;

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
            l_query.Text = L.Txt("Query config");
            c_paste.Text = L.Txt("query config from clipboard");
            Save.Text = L.Txt("Save");
            SaveExit.Text = L.Txt("Save and Exit");
            CancelExit.Text = L.Txt("Cancel and Exit");
            Text = L.Txt("QueryStoreEditor");


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
            c_name.DataBindings.Add(new Binding("Text", yQS, "m_name"));
            c_desc.DataBindings.Add(new Binding("Text", yQS, "m_description"));
            c_query.DataBindings.Add(new Binding("Text", yQS, "m_query"));
        }
        public void SaveY()
        {
            yQS.CreatedByModifiedBy();
            yQS.AllocID();
            yQS.Save();
        }


        private void Save_Click(object sender, EventArgs e)
        {
            SaveY();
            DialogResult = DialogResult.OK;
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
            c_query.Text = Clipboard.GetText();
        }
    }
}
