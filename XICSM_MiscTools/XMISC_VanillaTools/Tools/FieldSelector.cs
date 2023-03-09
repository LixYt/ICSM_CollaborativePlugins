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
            foreach (var prop in y.GetType().GetProperties())
            {
                if (!prop.Name.StartsWith("m_")) continue;
                if (Char.IsUpper(prop.Name, 2)) { }
                else
                {
                    string commonName = y.zeta.Fields.ToList().FindLast(x => x.Name.ToLower() == prop.Name.Substring(2)).Info;
                    try
                    {
                        ListOfFields.Nodes.Add(prop.Name, $"{prop.Name.Substring(2)} ({commonName}) ==> {prop.GetValue(y, null)}");
                    }
                    catch(Exception ex) { Debug.WriteLine(ex.Message); }
                }
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
    }
}
