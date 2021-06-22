using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XICSM.MiscTools.Tools
{
    public partial class MiscProgressBar : Form
    {
        public string Title { get { return Text; } set { Text = value; } }
        public int CurrentValue { get { return progressBar1.Value; } set { progressBar1.Value = value; labelMin.Text = value.ToString(); } }
        public int MaxValue { get { return progressBar1.Maximum; }  set { progressBar1.Maximum = value; labelMax.Text = value.ToString(); } }
        public int MinValue { get { return progressBar1.Minimum; }  set => progressBar1.Minimum = value;  }
        public int Step { get { return progressBar1.Step; } set => progressBar1.Step = value; }

        public MiscProgressBar()
        {
            InitializeComponent();
        }
        public void PerformStep()
        {
            progressBar1.PerformStep();
            labelMin.Text = progressBar1.Value.ToString();
            labelMax.Text = progressBar1.Value.ToString();
        }
    }
}
