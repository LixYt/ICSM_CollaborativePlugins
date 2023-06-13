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
using XICSM.VanillaTools.Controls;
using DatalayerCs;

namespace XICSM.VanillaTools.EntityForms
{
    public partial class SfafEntityForm : EntityMainForm
    {
        private YSfaf Sfaf;
        private YSfafTx SfafTx;
        YSfafRx ActiveSfafRx = new YSfafRx();

        private Transmitters tp = new Transmitters(); 
        private Transmitters tpRx = new Transmitters(); 
        public static bool EditRecord(int isId, IntPtr owner)
        {
            if (isId.IsNull()) return false;
            Cursor.Current = Cursors.WaitCursor;
            YSfaf y = new YSfaf();
            y.Fetch(isId);
            SfafEntityForm dlg = new SfafEntityForm(y);
            EntityEditOptions opt = new EntityEditOptions
            {
                CurForm = owner
            };
            return dlg.Edit("SFAF", isId, opt);
        }

        public static bool EditRecord(IMQueryMenuNode.Context context)
        {
            YSfaf y = new YSfaf();
            y.format2("*");
            y.LoadWithComponents2(context.TableId);

            SfafEntityForm edt = new SfafEntityForm(y);
            edt.ShowDialog();

            return (edt.DialogResult == DialogResult.OK); //Return true if query should be refreshed due to modification of some record(s)
        }

        public SfafEntityForm(YSfaf ys)

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

            Text = $"SFAF.ID = {Sfaf.m_id} --- SFAF SERIAL = {Sfaf.m_sfaf_102} ({Sfaf.m_sfaf_005}) - {SfafTx.m_site_name}";

            c_MapDisplay.RegisterVectorLayer(tp);
            c_MapDisplay.RegisterVectorLayer(tpRx);
            tp.StStroke.color = "rgba(161,0,255,1)"; tp.StFill.color = "rgba(161,0,255,0.02)";
            tp.StImage.fill.color = "rgba(161,0,255,0.02)"; tp.StImage.type = "miliRadio2";

            tp.StStroke.color = "rgba(161,0,255,1)"; tp.StFill.color = "rgba(161,0,255,0.02)";
            tp.StImage.fill.color = "rgba(161,0,255,0.02)"; tp.StImage.type = "miliRadio";

            tp.LoadFromAllStation(ys.m_id, ys.m_table_name); //to modify in order to handle Tx and Rx positions + handle Radius

            YSfafRx All_Rx = new YSfafRx(); All_Rx.Format("*"); All_Rx.Filter = $"SFAF_ID = {Sfaf.m_id}";
            for (All_Rx.OpenRs(); !All_Rx.IsEOF(); All_Rx.MoveNext())
            {
                tpRx.LoadFromAllStation(All_Rx.m_id, All_Rx.Table);
            }

            c_MapDisplay.CenterOn(SfafTx.m_longitude, SfafTx.m_latitude);

            c_Recievers.Requery(); c_Recievers.ResetToDefaultQuery();
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
            c_Country.DataBindings.Add(new Binding("Value", SfafTx, "m_country_id"));  
            c_CreatedBy.DataBindings.Add(new Binding("Text", Sfaf, "m_created_by"));
            c_CreatedDate.DataBindings.Add(new Binding("Text", Sfaf, "m_date_created")); 
            c_DesignEm.DataBindings.Add(new Binding("Value", Sfaf, "m_desig_em"));
            c_EIRP.DataBindings.Add(new Binding("Value", Sfaf, "m_eirp"));
            c_EIRPmin.DataBindings.Add(new Binding("Value", Sfaf, "m_eirp_min"));
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
            c_classification.DataBindings.Add(new Binding("Text", Sfaf, "m_sfaf_005"));
            c_Status.DataBindings.Add(new Binding("Value", Sfaf, "m_sfaf_010"));
            c_Gain.DataBindings.Add(new Binding("Value", SfafTx, "m_gain"));
            
            c_Recievers.Filter = $"SFAF_ID = {Sfaf.m_id}";

        }
        public void SetLabel()
        {
            ItemsGroup1.Text = L.TxT("Administrative data");
            ItemsGroup2.Text = L.TxT("Emission characteristics");
            ItemsGroup3.Text = L.TxT("Time/Date information");
            Items2xx.Text = L.TxT("Organizational Information");
            Items3xx.Text = L.TxT("Transmitter data");
            Items4xx.Text = L.TxT("Recievers data");
            Items5xx.Text = L.TxT("Supplementary details");
            Items7xx.Text = L.TxT("Other assignment identifiers");
            Items8xx.Text = L.TxT("Additional information");
            Items9xx.Text = L.TxT("Additional information");
        }
        public void BindSfafToControls()
        {
            BindingTool(ItemsGroup1);
            BindingTool(ItemsGroup2);
            BindingTool(Items2xx);
            BindingTool(Items3xx, SfafTx);
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
            foreach (Control c_etb in c.Controls)
            {
                ExtentableTextBox etb = (ExtentableTextBox)c_etb;
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
            ActiveSfafRx = new YSfafRx();
            string oql = c_ListOfRx.GetSelectionAsOQLFilter(true);
            if (oql == "[ID] IN ()") return;
            ActiveSfafRx.Fetch(oql);
            BindingToolRx(Items4xx, ActiveSfafRx);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Sfaf.SaveWithTrace("Advanced SFAF editor save", "", "");
            SfafTx.SaveWithTrace("Advanced SFAF editor save", "", "");
        }

        private void SaveRx_Click(object sender, EventArgs e)
        {
            ActiveSfafRx.SaveWithTrace("Advanced SFAF editor save", "", "");
        }

        private void c_Recievers_OnDefColumns(object sender, EventArgs e)
        {
            c_Recievers.AddColumn("SFAF_RX.ID", L.Txt("ID"), "Auto", 29);
            c_Recievers.AddColumn("SFAF_RX.SFAF_ID", L.Txt("SFAF_ID (SFAF)"), "Auto", 90);
            c_Recievers.AddColumn("SFAF_RX.COUNTRY_ID", L.Txt("Country"), "Auto", 34);
            c_Recievers.AddColumn("SFAF_RX.LONGITUDE", L.Txt("Longitude"), "Auto", 94);
            c_Recievers.AddColumn("SFAF_RX.LATITUDE", L.Txt("Latitude"), "Auto", 106);
            c_Recievers.AddColumn("SFAF_RX.RADIUS", L.Txt("Radius (km)"), "Auto", 68);
            c_Recievers.AddColumn("SFAF_RX.AGL", L.Txt("AGL (m)"), "Auto", 67);
            c_Recievers.AddColumn("SFAF_RX.ANGLE_ELEV", L.Txt("Elevation (Â°)"), "Auto", 82);
            c_Recievers.AddColumn("SFAF_RX.AZIMUTH", L.Txt("Azimuth (Â°)"), "Auto", 67);
            c_Recievers.AddColumn("SFAF_RX.POLARIZATION", L.Txt("Polar"), "Auto", 56);
            c_Recievers.AddColumn("SFAF_RX.CALL_SIGN", L.Txt("Callsign"), "Auto", 59);
            c_Recievers.AddColumn("SFAF_RX.GAIN", L.Txt("Gain"), "Auto", 74);
            c_Recievers.SetParams(0, 0);

        }
    }
}
