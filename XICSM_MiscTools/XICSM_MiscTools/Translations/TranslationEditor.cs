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
using NetPlugins2;

namespace XICSM.MiscTools
{
    public partial class TranslationEditor : EntityMainMetroForm
    {
        public YXmiscTranslations YTranslation;

        public static bool EditRecord(int isId, IntPtr owner)
        {
            if (isId.IsNull()) return false;
            Cursor.Current = Cursors.WaitCursor;
            YXmiscTranslations y = new YXmiscTranslations();
            y.Fetch(isId);
            TranslationEditor dlg = new TranslationEditor(y);
            EntityEditOptions opt = new EntityEditOptions
            {
                CurForm = owner
            };
            //dlg.ShowDialog();
            return dlg.Edit("XMISC_TRANSLATIONS", isId, opt);
        }
        public static bool EditRecord(IMQueryMenuNode.Context context)
        {
            YXmiscTranslations y = new YXmiscTranslations();
            y.Fetch(context.TableId);

            TranslationEditor edt = new TranslationEditor(y);
            edt.ShowDialog();

            return (edt.DialogResult == DialogResult.OK); //Return true if query should be refreshed due to modification of some record(s)
        }

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
