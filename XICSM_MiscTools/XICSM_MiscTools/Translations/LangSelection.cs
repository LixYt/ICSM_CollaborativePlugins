using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XICSM.MiscTools
{
    public partial class LangSelection : Form
    {
        public string SelectedItem { get { return c_lang.SelectedItem.ToString(); } }

        public LangSelection(List<string> Langs)
        {
            InitializeComponent();

            c_lang.Items.AddRange(Langs.ToArray());
        }

        private void c_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void c_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
