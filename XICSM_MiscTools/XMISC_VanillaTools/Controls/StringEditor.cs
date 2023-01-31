using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XICSM.VanillaTools.Controls
{
    public partial class StringEditor : Form
    {
        public string TextValue { get { return textBox1.Text; } set { textBox1.Text = value; } }

        public StringEditor(string txt = "")
        {
            InitializeComponent();
            TextValue = txt;

            textBox1.Multiline = TextValue.Contains(Environment.NewLine);
            Height += TextValue.Split('\n').Count() * 15;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
