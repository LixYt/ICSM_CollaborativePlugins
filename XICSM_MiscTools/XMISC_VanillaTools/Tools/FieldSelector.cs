using DatalayerCs;
using ICSM;
using OrmCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XICSM.VanillaTools.Tools
{

    public partial class FieldSelector : Form
    {
        private List<KeyValuePair<string, string>> TreeViewNodes = new List<KeyValuePair<string, string>>();
        Yyy yObject;
        public List<string> SelectedFields = new List<string>();
        public FieldSelector(Yyy yO)
        {
            InitializeComponent();

            Text = L.Txt("Field selector");

            yObject = yO;
            GetListOfField(yObject);

        }

        public void GetListOfField(Yyy y)
        {
            foreach (var prop in y.GetType().GetProperties().ToList().OrderBy(x => x.Name.Substring(2)).ToList())
            {
                if (!prop.Name.StartsWith("m_")) continue;
                if (Char.IsUpper(prop.Name, 2)) { }
                else
                {
                    string commonName = y.zeta.Fields.ToList().FindLast(x => x.Name.ToLower() == prop.Name.Substring(2)).Info;
                    try
                    {
                        TreeViewNodes.Add(new KeyValuePair<string, string>(prop.Name, $"{prop.Name.Substring(2)} ({commonName}) ==> {prop.GetValue(y, null)}"));
                    }
                    catch(Exception ex) { Debug.WriteLine(ex.Message); }
                }
            }

            TreeViewNodes = TreeViewNodes.OrderBy(x => x.Key).ToList();
            foreach (KeyValuePair<string, string> KVP in TreeViewNodes)
            {
                ListOfFields.Nodes.Add(KVP.Key, KVP.Value);
            }
        }

        private void c_ok_Click(object sender, EventArgs e)
        {
            foreach(TreeNode t in ListOfFields.Nodes)
            {
                if (t.Checked) { SelectedFields.Add(t.Name.Substring(2)); }
            }
            DialogResult = DialogResult.OK;
        }

        private void c_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Filtering_TextChanged(object sender, EventArgs e)
        {
            foreach (TreeNode n in ListOfFields.Nodes)
            {
                n.ForeColor = n.Text.Contains(Filtering.Text) ? Color.Red : Color.Black;
            }
        }
    }
}
