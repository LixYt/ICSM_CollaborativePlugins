using DatalayerCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XICSM.VanillaTools.Tools
{
    public partial class SelectCombox : Form
    {
        public ComboBox.ObjectCollection Items { get { return comboBox1.Items; } }
        public string Title { get => Text; set => Text = value; }
        public string SelectedItem { get => comboBox1.SelectedItem.ToString(); }

        public SelectCombox()
        {
            InitializeComponent();
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) { MessageBox.Show(L.Txt("Select a replacement or cancel the dialog")); return; }
            DialogResult = DialogResult.OK;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
