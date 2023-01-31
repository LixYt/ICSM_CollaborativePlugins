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
using DatalayerCs;

namespace XICSM.VanillaTools.EntityForms
{
    public partial class SFAF : EntityMainForm
    {
        private YSfaf Sfaf;
        private YSfafTx SfafTx;
        private Transmitters tp = new Transmitters(); 
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
            c_Recievers.ResetToDefaultQuery();
            c_ListOfRx.ResetToDefaultQuery();

            c_Recievers.Init(); 
            c_ListOfRx.Init();
            

            Sfaf = ys;
            SfafTx = new YSfafTx(); SfafTx.Fetch(Sfaf.m_id);
            FillSumaryTab();
            BindSfafToControls();

            Text = $"SFAF SERIAL = {Sfaf.m_sfaf_102} ({Sfaf.m_sfaf_005}) - {SfafTx.m_site_name}";

            c_MapDisplay.RegisterVectorLayer(tp);
            tp.StStroke.color = "rgba(161,0,255,1)"; tp.StFill.color = "rgba(161,0,255,0.02)";
            tp.StImage.fill.color = "rgba(161,0,255,0.02)"; tp.StImage.type = "crux";
            
            tp.LoadFromAllStation(ys.m_id, ys.m_table_name); //to modify in order to handle Tx and Rx positions + handle Radius
            
            c_MapDisplay.CenterOn(SfafTx.m_longitude, SfafTx.m_latitude);

            c_Recievers.Requery();
            c_ListOfRx.Requery();
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

        }

        public void BindSfafToControls()
        {
            BindingTool(Items0xx);
            BindingTool(Items1xx);
            BindingTool(Items2xx);
            BindingTool(SFAF_TX, SfafTx);
            BindingTool(Items5xx);
            BindingTool(Items7xx);
            BindingTool(Items8xx);
            BindingTool(Items9xx);

            c_ListOfRx.Filter = $"SFAF_ID = {Sfaf.m_id}"; 
        }

        public void BindingTool(Control c)
        {
            foreach (ExtentableTextBox etb in c.Controls)
            {
                string propName = "m_" + etb.Name.ToLower();
                string LTxt = "label_" + etb.Name;
                etb.LabelText = L.Txt(LTxt);
                etb.DataBindings.Add(new Binding("TextValue", Sfaf, propName));
            }
        }

        public void BindingTool(Control c, YSfafTx tx)
        {
            foreach (ExtentableTextBox etb in c.Controls)
            {
                string propName = "m_" + etb.Name.ToLower();
                string LTxt = "label_" + etb.Name;
                etb.LabelText = L.Txt(LTxt);
                etb.DataBindings.Add(new Binding("TextValue", tx, propName));
            }
        }

        public void BindingToolRx(Control c, YSfafRx rx)
        {
            foreach (ExtentableTextBox etb in c.Controls)
            {
                etb.DataBindings.Clear();
                string propName = "m_" + etb.Name.ToLower();
                string LTxt = "label_" + etb.Name;
                etb.LabelText = L.Txt(LTxt);
                etb.DataBindings.Add(new Binding("TextValue", rx, propName));
            }
        }

        private void c_ListOfRx_OnRequery(object sender, EventArgs e)
        {
            c_ListOfRx.MustBePresent("ID");
            c_ListOfRx.SetFilter(c_ListOfRx.Filter);
        }

        private void c_Recievers_OnRequery(object sender, EventArgs e)
        {
            c_Recievers.MustBePresent("ID");
            c_Recievers.SetFilter(c_Recievers.Filter);
        }

        private void c_ListOfRx_OnSelChanged(object sender, EventArgs e)
        {   
            YSfafRx rx = new YSfafRx();
            string oql = c_ListOfRx.GetSelectionAsOQLFilter(true);
            if (oql == "[ID] IN ()") return;
            rx.Fetch(oql);
            BindingToolRx(Items4xx, rx);
        }
    }
}
