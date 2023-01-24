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

        public SFAF(YSfaf ys)
        {
            InitializeComponent();
            Sfaf = ys;
            BindSfafToControls();
            FillSumaryTab();
        }

        public void FillSumaryTab()
        {
            c_AGL.DataBindings.Add(new Binding("Value", Sfaf, "m_AGL"));
            c_Azimuth.DataBindings.Add(new Binding("Value", Sfaf.m_Transmitter, "m_azimuth"));
            c_BIUSE.DataBindings.Add(new Binding("Value", Sfaf, "m_biuse_date")); 
            c_Bw.DataBindings.Add(new Binding("Value", Sfaf, "m_bw")); 
            c_BwMin.DataBindings.Add(new Binding("Value", Sfaf, "m_bw_min")); 
            c_Callsign.DataBindings.Add(new Binding("Value", Sfaf.m_Transmitter, "m_call_sign")); 
            c_ClassSta.DataBindings.Add(new Binding("Value", Sfaf, "m_classes")); 
            c_Country.DataBindings.Add(new Binding("Value", Sfaf, "AGL")); 
            c_CreatedBy.DataBindings.Add(new Binding("Value", Sfaf, "m_created_by")); 
            c_CreatedDate.DataBindings.Add(new Binding("Value", Sfaf, "m_date_created")); 
            c_DesignEm.DataBindings.Add(new Binding("Value", Sfaf, "m_desig_em"));
            c_EIRP.DataBindings.Add(new Binding("Value", Sfaf, "m_eirp"));
            c_Elev.DataBindings.Add(new Binding("Value", Sfaf.m_Transmitter, "m_angle_elev"));
            c_EOUSE.DataBindings.Add(new Binding("Value", Sfaf, "m_eouse_date"));
            c_Freq.DataBindings.Add(new Binding("Value", Sfaf, "m_freq"));
            c_Lat.DataBindings.Add(new Binding("Value", Sfaf.m_Transmitter, "m_latitude"));
            c_LocationName.DataBindings.Add(new Binding("Value", Sfaf, "m_longitude"));
            c_Long.DataBindings.Add(new Binding("Value", Sfaf.m_Transmitter, "m_longitude"));
            c_ModifiedBy.DataBindings.Add(new Binding("Value", Sfaf, "m_modified_by"));
            c_ModifiedDate.DataBindings.Add(new Binding("Value", Sfaf, "m_date_modified"));
            c_Polar.DataBindings.Add(new Binding("Value", Sfaf, "m_polarization"));
            c_Radius.DataBindings.Add(new Binding("Value", Sfaf, "m_radius"));
            //c_State.DataBindings.Add(new Binding("Value", Sfaf, "AGL"));
            //c_Status.DataBindings.Add(new Binding("Value", Sfaf, "m_sfaf_010"));

            c_Recievers.Filter = $"SFAF_ID = {Sfaf.m_id}";
            c_Recievers.Requery();

        }

        public void BindSfafToControls()
        {
            foreach(ExtentableTextBox etb in MainSFAF_1.Controls)
            {
                etb.DataBindings.Add(new Binding(etb.TextValue, Sfaf, etb.LabelText));
            }
            foreach (ExtentableTextBox etb in MainSFAF_2.Controls)
            {
                etb.DataBindings.Add(new Binding(etb.TextValue, Sfaf, etb.LabelText));
            }
            foreach (ExtentableTextBox etb in MainSFAF_3.Controls)
            {
                etb.DataBindings.Add(new Binding(etb.TextValue, Sfaf, etb.LabelText));
            }
            foreach (ExtentableTextBox etb in SFAF_TX.Controls)
            {
                etb.DataBindings.Add(new Binding(etb.TextValue, Sfaf, etb.LabelText));
            }
        }
    }
}
