using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsCs;
using NetPlugins2;
using OrmCs;
using ICSM;
using FormsCs;
using XICSM.VanillaTools.Controls;

namespace XICSM.VanillaTools.EntityForms
{
    public partial class SFAF : EntityMainForm
    {
        private YSfaf Sfaf;
        private YSfafTx SfafTx;

        public static bool EditRecord(int isId, IntPtr owner)
        {
            if (isId.IsNull()) return false;
            Cursor.Current = Cursors.WaitCursor;
            YSfaf y = new YSfaf();
            y.Fetch(isId);
            SFAF dlg = new SFAF(y);
            EntityEditOptions opt = new EntityEditOptions
            {
                CurForm = owner
            };
            //dlg.ShowDialog();
            return dlg.Edit("SFAF", isId, opt);
        }

        public static bool EditRecord(IMQueryMenuNode.Context context)
        {
            YSfaf y = new YSfaf();
            y.format2("*");
            y.LoadWithComponents2(context.TableId);

            SFAF edt = new SFAF(y);
            edt.ShowDialog();

            return (edt.DialogResult == DialogResult.OK); //Return true if query should be refreshed due to modification of some record(s)
        }

        public SFAF(YSfaf ys)

        {
            InitializeComponent();
            Sfaf = ys;
            SfafTx = new YSfafTx(); SfafTx.Fetch(Sfaf.m_id);
            FillSumaryTab();
            BindSfafToControls();

            Text = $"SFAF SERIAL = {Sfaf.m_sfaf_102} ({Sfaf.m_sfaf_005}) - {SfafTx.m_site_name}";
        }

        public void FillSumaryTab()
        {
            c_AGL.DataBindings.Add(new Binding("Value", SfafTx, "m_agl"));
            c_Azimuth.DataBindings.Add(new Binding("Value", SfafTx, "m_azimuth"));
            c_BIUSE.DataBindings.Add(new Binding("Value", Sfaf, "m_biuse_date")); 
            c_Bw.DataBindings.Add(new Binding("Value", Sfaf, "m_bw")); 
            c_BwMin.DataBindings.Add(new Binding("Value", Sfaf, "m_bw_min"));
            c_Callsign.DataBindings.Add(new Binding("Text", SfafTx, "m_call_sign")); 
            c_ClassSta.DataBindings.Add(new Binding("Value", Sfaf, "m_classes"));
            c_Country.DataBindings.Add(new Binding("Text", SfafTx, "m_country_id"));  
            c_CreatedBy.DataBindings.Add(new Binding("Text", Sfaf, "m_created_by"));
            c_CreatedDate.DataBindings.Add(new Binding("Text", Sfaf, "m_date_created")); 
            c_DesignEm.DataBindings.Add(new Binding("Value", Sfaf, "m_desig_em"));
            c_EIRP.DataBindings.Add(new Binding("Value", Sfaf, "m_eirp"));
            c_Elev.DataBindings.Add(new Binding("Value", SfafTx, "m_angle_elev"));
            c_EOUSE.DataBindings.Add(new Binding("Value", Sfaf, "m_eouse_date"));
            c_Freq.DataBindings.Add(new Binding("Value", Sfaf, "m_freq"));
            c_Lat.DataBindings.Add(new Binding("Value", SfafTx, "m_latitude"));
            c_LocationName.DataBindings.Add(new Binding("Text", SfafTx, "m_site_name"));
            c_Long.DataBindings.Add(new Binding("Value", SfafTx, "m_longitude"));
            c_ModifiedBy.DataBindings.Add(new Binding("Text", Sfaf, "m_modified_by"));
            c_ModifiedDate.DataBindings.Add(new Binding("Text", Sfaf, "m_date_modified"));
            c_Polar.DataBindings.Add(new Binding("Value", SfafTx, "m_polarization"));
            c_Radius.DataBindings.Add(new Binding("Value", SfafTx, "m_radius")); 
            c_classification.DataBindings.Add(new Binding("Value", Sfaf, "m_sfaf_005"));
            c_Status.DataBindings.Add(new Binding("Value", Sfaf, "m_sfaf_010"));

            c_Recievers.Filter = $"SFAF_ID = {Sfaf.m_id}";
            c_Recievers.Requery();

        }

        public void BindSfafToControls()
        {
            BindingTool(Items0xx);
            BindingTool(Items1xx);
            BindingTool(Items2xx);
            BindingTool(SFAF_TX);
            BindingTool(Items5xx);
            BindingTool(Items7xx);
            BindingTool(Items8xx);
            BindingTool(Items9xx);
        }

        public void BindingTool(Control c)
        {
            foreach (ExtentableTextBox etb in c.Controls)
            {
                string propName = "m_" + etb.LabelText.ToLower();
                etb.DataBindings.Add(new Binding("TextValue", Sfaf, propName));
            }
        }
    }
}
