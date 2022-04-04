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

namespace XICSM.VanillaTools.Tools
{
    public partial class MiscProgressBar : Form
    {
        private string BaseTitle = L.Txt("Progression");
        public int CurrentValue { get { return progressBar1.Value; } set { progressBar1.Value = value; } }
        public int MaxValue { get { return progressBar1.Maximum; }  set { progressBar1.Maximum = value; } }
        public int MinValue { get { return progressBar1.Minimum; }  set => progressBar1.Minimum = value;  }
        public int Step { get { return progressBar1.Step; } set => progressBar1.Step = value; }

        public MiscProgressBar(string Title)
        {
            InitializeComponent();
            Text = Title; BaseTitle = Title;
        }
        public void UpdateMessage(string Message)
        {
            Text = $"{BaseTitle} - {progressBar1.Value} / {MaxValue} ({Message})";
        }
        public void PerformStep(string Message="")
        {
            progressBar1.PerformStep();
            Text = $"{BaseTitle} - {progressBar1.Value} / {MaxValue} ({Message})";
        }
    }
}
