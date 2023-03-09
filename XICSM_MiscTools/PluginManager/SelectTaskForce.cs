using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XICSM.PluginManager
{
    public partial class SelectTaskForce : Form
    {
        public int TaskForceID { get { return TaskForceESD.ID; } set { TaskForceESD.ID = TaskForceID; } }

        public SelectTaskForce()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (TaskForceESD.ID != 0)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}