using OrmCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICSM;
using DatalayerCs;

namespace XICSM.MiscTools
{
    public partial class TranslationEditor : Form
    {
        public YXmiscTranslations YTranslation;

        public TranslationEditor(YXmiscTranslations y)
        {
            InitializeComponent();
            YTranslation = y;
            c_SourceString.Text = y.m_from_string;
            c_TranslatedString.Text = y.m_to_string;

            l_fromString.Text = L.Txt("Original string");
            l_toString.Text = L.Txt("Translated string");

        }

        private void SaveExit_Click(object sender, EventArgs e)
        {
            YTranslation.m_to_string = c_TranslatedString.Text;
            YTranslation.Save();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
