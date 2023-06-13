namespace XICSM.VanillaTools.EntityForms
{
    partial class SfafEntityForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Summary = new System.Windows.Forms.TabPage();
            this.c_Recievers = new NetPlugins2.IcsDBList();
            this.SummaryTransmitter = new System.Windows.Forms.GroupBox();
            this.c_Gain = new NetPlugins2.IcsDouble();
            this.c_Lat = new NetPlugins2.IcsDouble();
            this.c_Long = new NetPlugins2.IcsDouble();
            this.c_Azimuth = new NetPlugins2.IcsDouble();
            this.label11 = new System.Windows.Forms.Label();
            this.c_Elev = new NetPlugins2.IcsDouble();
            this.label10 = new System.Windows.Forms.Label();
            this.c_Country = new NetPlugins2.IcsControls.IcsComboList();
            this.c_AGL = new NetPlugins2.IcsDouble();
            this.c_Callsign = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.c_Polar = new NetPlugins2.IcsControls.IcsComboList();
            this.c_Radius = new NetPlugins2.IcsDouble();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.c_LocationName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.c_ModifiedDate = new System.Windows.Forms.TextBox();
            this.c_CreatedDate = new System.Windows.Forms.TextBox();
            this.c_ModifiedBy = new System.Windows.Forms.TextBox();
            this.c_CreatedBy = new System.Windows.Forms.TextBox();
            this.c_ClassSta = new NetPlugins2.IcsControls.IcsComboList();
            this.c_MapDisplay = new NetPlugins2.IcsOpenlayers3();
            this.c_EOUSE = new NetPlugins2.IcsDateTime();
            this.c_BIUSE = new NetPlugins2.IcsDateTime();
            this.c_DesignEm = new NetPlugins2.IcsDesigEmiss();
            this.c_EIRPmin = new NetPlugins2.IcsDoublePower();
            this.c_EIRP = new NetPlugins2.IcsDoublePower();
            this.c_BwMin = new NetPlugins2.IcsDouble();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.c_classification = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.c_Bw = new NetPlugins2.IcsDouble();
            this.label24 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.c_Freq = new NetPlugins2.IcsDouble();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainSFAF_1 = new System.Windows.Forms.TabPage();
            this.ItemsGroup3 = new System.Windows.Forms.GroupBox();
            this.Save1 = new System.Windows.Forms.Button();
            this.ItemsGroup2 = new System.Windows.Forms.GroupBox();
            this.ItemsGroup1 = new System.Windows.Forms.GroupBox();
            this.MainSFAF_2 = new System.Windows.Forms.TabPage();
            this.Save2 = new System.Windows.Forms.Button();
            this.Items8xx = new System.Windows.Forms.GroupBox();
            this.Items2xx = new System.Windows.Forms.GroupBox();
            this.Items5xx = new System.Windows.Forms.GroupBox();
            this.Items7xx = new System.Windows.Forms.GroupBox();
            this.MainSFAF_3 = new System.Windows.Forms.TabPage();
            this.Save3 = new System.Windows.Forms.Button();
            this.Items9xx = new System.Windows.Forms.GroupBox();
            this.SFAF_TX = new System.Windows.Forms.TabPage();
            this.SaveTx = new System.Windows.Forms.Button();
            this.Items3xx = new System.Windows.Forms.GroupBox();
            this.SFAF_RX = new System.Windows.Forms.TabPage();
            this.SaveThisRx = new System.Windows.Forms.Button();
            this.Items4xx = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.c_ListOfRx = new NetPlugins2.IcsDBList();
            this.c_Status = new NetPlugins2.IcsCombo();
            this.SFAF_130 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_140 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_141 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_144 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_152 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_142 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_147 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_145 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_151 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_131 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_146 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_143 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_116 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_113 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_115 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_112 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_114 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_111 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_110 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_118 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_117 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_020 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_014 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_107 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_018 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_010 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_019 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_013 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_017 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_007 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_016 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_006 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_015 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_106 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_005 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_102 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_108 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_103 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_105 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_807 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_801 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_805 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_804 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_803 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_806 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_209 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_208 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_207 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_203 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_204 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_205 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_200 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_206 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_201 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_202 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_531 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_521 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_513 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_511 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_503 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_530 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_504 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_520 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_512 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_506 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_505 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_500 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_501 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_502 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_716 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_715 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_711 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_701 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_707 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_704 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_702 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_710 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_999 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_998 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_994 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_988 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_997 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_993 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_952 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_986 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_996 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_992 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_950 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_985 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_990 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_928 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_983 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_989 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_926 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_982 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_924 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_965 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_995 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_991 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_922 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_984 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_927 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_964 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_911 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_963 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_959 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_910 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_953 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_907 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_958 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_901 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_957 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_905 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_956 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_904 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_903 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_906 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_300 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_361 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_304 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_342 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_301 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_360 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_347 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_374 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_302 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_341 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_344 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_359 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_303 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_363 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_345 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_340 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_346 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_357 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_306 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_362 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_343 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_319 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_315 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_356 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_348 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_318 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_349 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_355 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_316 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_373 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_354 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_317 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_321 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_358 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_400 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_404 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_401 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_461 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_442 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_402 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_460 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_403 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_459 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_463 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_406 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_440 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_443 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_457 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_415 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_462 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_419 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_456 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_416 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_418 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_454 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_455 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_473 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_458 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.SFAF_417 = new XICSM.VanillaTools.Controls.ExtentableTextBox();
            this.tabControl1.SuspendLayout();
            this.Summary.SuspendLayout();
            this.SummaryTransmitter.SuspendLayout();
            this.MainSFAF_1.SuspendLayout();
            this.ItemsGroup3.SuspendLayout();
            this.ItemsGroup2.SuspendLayout();
            this.ItemsGroup1.SuspendLayout();
            this.MainSFAF_2.SuspendLayout();
            this.Items8xx.SuspendLayout();
            this.Items2xx.SuspendLayout();
            this.Items5xx.SuspendLayout();
            this.Items7xx.SuspendLayout();
            this.MainSFAF_3.SuspendLayout();
            this.Items9xx.SuspendLayout();
            this.SFAF_TX.SuspendLayout();
            this.Items3xx.SuspendLayout();
            this.SFAF_RX.SuspendLayout();
            this.Items4xx.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Summary);
            this.tabControl1.Controls.Add(this.MainSFAF_1);
            this.tabControl1.Controls.Add(this.MainSFAF_2);
            this.tabControl1.Controls.Add(this.MainSFAF_3);
            this.tabControl1.Controls.Add(this.SFAF_TX);
            this.tabControl1.Controls.Add(this.SFAF_RX);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1150, 568);
            this.tabControl1.TabIndex = 0;
            // 
            // Summary
            // 
            this.Summary.Controls.Add(this.c_Status);
            this.Summary.Controls.Add(this.c_Recievers);
            this.Summary.Controls.Add(this.SummaryTransmitter);
            this.Summary.Controls.Add(this.c_ModifiedDate);
            this.Summary.Controls.Add(this.c_CreatedDate);
            this.Summary.Controls.Add(this.c_ModifiedBy);
            this.Summary.Controls.Add(this.c_CreatedBy);
            this.Summary.Controls.Add(this.c_ClassSta);
            this.Summary.Controls.Add(this.c_MapDisplay);
            this.Summary.Controls.Add(this.c_EOUSE);
            this.Summary.Controls.Add(this.c_BIUSE);
            this.Summary.Controls.Add(this.c_DesignEm);
            this.Summary.Controls.Add(this.c_EIRPmin);
            this.Summary.Controls.Add(this.c_EIRP);
            this.Summary.Controls.Add(this.c_BwMin);
            this.Summary.Controls.Add(this.label21);
            this.Summary.Controls.Add(this.label20);
            this.Summary.Controls.Add(this.c_classification);
            this.Summary.Controls.Add(this.label25);
            this.Summary.Controls.Add(this.c_Bw);
            this.Summary.Controls.Add(this.label24);
            this.Summary.Controls.Add(this.label2);
            this.Summary.Controls.Add(this.label9);
            this.Summary.Controls.Add(this.label7);
            this.Summary.Controls.Add(this.label8);
            this.Summary.Controls.Add(this.label5);
            this.Summary.Controls.Add(this.label6);
            this.Summary.Controls.Add(this.label4);
            this.Summary.Controls.Add(this.label3);
            this.Summary.Controls.Add(this.c_Freq);
            this.Summary.Controls.Add(this.label22);
            this.Summary.Controls.Add(this.label1);
            this.Summary.Location = new System.Drawing.Point(4, 22);
            this.Summary.Name = "Summary";
            this.Summary.Padding = new System.Windows.Forms.Padding(3);
            this.Summary.Size = new System.Drawing.Size(1142, 542);
            this.Summary.TabIndex = 0;
            this.Summary.Text = "Synthèse de l\'assignation";
            this.Summary.UseVisualStyleBackColor = true;
            // 
            // c_Recievers
            // 
            this.c_Recievers.AllowFilter = false;
            this.c_Recievers.BackColor = System.Drawing.SystemColors.Control;
            this.c_Recievers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c_Recievers.ConfigName = "AdvSFAF_Recievers";
            this.c_Recievers.Filter = null;
            this.c_Recievers.Location = new System.Drawing.Point(296, 384);
            this.c_Recievers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.c_Recievers.Name = "c_Recievers";
            this.c_Recievers.Param1 = 0;
            this.c_Recievers.Param2 = 0;
            this.c_Recievers.Size = new System.Drawing.Size(828, 148);
            this.c_Recievers.TabIndex = 32;
            this.c_Recievers.Table = "SFAF_RX";
            this.c_Recievers.OnDefColumns += new System.EventHandler(this.c_Recievers_OnDefColumns);
            this.c_Recievers.OnRequery += new System.EventHandler(this.c_Recievers_OnRequery);
            // 
            // SummaryTransmitter
            // 
            this.SummaryTransmitter.Controls.Add(this.c_Gain);
            this.SummaryTransmitter.Controls.Add(this.c_Lat);
            this.SummaryTransmitter.Controls.Add(this.c_Long);
            this.SummaryTransmitter.Controls.Add(this.c_Azimuth);
            this.SummaryTransmitter.Controls.Add(this.label11);
            this.SummaryTransmitter.Controls.Add(this.c_Elev);
            this.SummaryTransmitter.Controls.Add(this.label10);
            this.SummaryTransmitter.Controls.Add(this.c_Country);
            this.SummaryTransmitter.Controls.Add(this.c_AGL);
            this.SummaryTransmitter.Controls.Add(this.c_Callsign);
            this.SummaryTransmitter.Controls.Add(this.label13);
            this.SummaryTransmitter.Controls.Add(this.c_Polar);
            this.SummaryTransmitter.Controls.Add(this.c_Radius);
            this.SummaryTransmitter.Controls.Add(this.label12);
            this.SummaryTransmitter.Controls.Add(this.label17);
            this.SummaryTransmitter.Controls.Add(this.label16);
            this.SummaryTransmitter.Controls.Add(this.label15);
            this.SummaryTransmitter.Controls.Add(this.c_LocationName);
            this.SummaryTransmitter.Controls.Add(this.label14);
            this.SummaryTransmitter.Controls.Add(this.label19);
            this.SummaryTransmitter.Controls.Add(this.label27);
            this.SummaryTransmitter.Controls.Add(this.label18);
            this.SummaryTransmitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryTransmitter.Location = new System.Drawing.Point(296, 7);
            this.SummaryTransmitter.Name = "SummaryTransmitter";
            this.SummaryTransmitter.Size = new System.Drawing.Size(298, 355);
            this.SummaryTransmitter.TabIndex = 31;
            this.SummaryTransmitter.TabStop = false;
            this.SummaryTransmitter.Text = "Transmitter";
            // 
            // c_Gain
            // 
            this.c_Gain.Location = new System.Drawing.Point(137, 323);
            this.c_Gain.Margin = new System.Windows.Forms.Padding(0);
            this.c_Gain.Name = "c_Gain";
            this.c_Gain.ReadOnly = true;
            this.c_Gain.Size = new System.Drawing.Size(139, 20);
            this.c_Gain.Subtype = "dB";
            this.c_Gain.TabIndex = 36;
            // 
            // c_Lat
            // 
            this.c_Lat.Location = new System.Drawing.Point(137, 111);
            this.c_Lat.Margin = new System.Windows.Forms.Padding(0);
            this.c_Lat.Name = "c_Lat";
            this.c_Lat.ReadOnly = true;
            this.c_Lat.Size = new System.Drawing.Size(145, 20);
            this.c_Lat.Subtype = "Latitude";
            this.c_Lat.TabIndex = 35;
            // 
            // c_Long
            // 
            this.c_Long.Location = new System.Drawing.Point(137, 80);
            this.c_Long.Margin = new System.Windows.Forms.Padding(0);
            this.c_Long.Name = "c_Long";
            this.c_Long.ReadOnly = true;
            this.c_Long.Size = new System.Drawing.Size(145, 20);
            this.c_Long.Subtype = "Longitude";
            this.c_Long.TabIndex = 34;
            // 
            // c_Azimuth
            // 
            this.c_Azimuth.Location = new System.Drawing.Point(137, 229);
            this.c_Azimuth.Margin = new System.Windows.Forms.Padding(0);
            this.c_Azimuth.Name = "c_Azimuth";
            this.c_Azimuth.ReadOnly = true;
            this.c_Azimuth.Size = new System.Drawing.Size(145, 20);
            this.c_Azimuth.Subtype = "deg";
            this.c_Azimuth.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Country";
            // 
            // c_Elev
            // 
            this.c_Elev.Location = new System.Drawing.Point(137, 198);
            this.c_Elev.Margin = new System.Windows.Forms.Padding(0);
            this.c_Elev.Name = "c_Elev";
            this.c_Elev.ReadOnly = true;
            this.c_Elev.Size = new System.Drawing.Size(145, 20);
            this.c_Elev.Subtype = "deg";
            this.c_Elev.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Location name";
            // 
            // c_Country
            // 
            this.c_Country.EnclosingComma = false;
            this.c_Country.EriLovName = "eri_COUNTRY";
            this.c_Country.Location = new System.Drawing.Point(137, 16);
            this.c_Country.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.c_Country.Name = "c_Country";
            this.c_Country.ReadOnly = true;
            this.c_Country.Size = new System.Drawing.Size(145, 20);
            this.c_Country.TabIndex = 28;
            this.c_Country.Value = "";
            // 
            // c_AGL
            // 
            this.c_AGL.Location = new System.Drawing.Point(137, 168);
            this.c_AGL.Margin = new System.Windows.Forms.Padding(0);
            this.c_AGL.Name = "c_AGL";
            this.c_AGL.ReadOnly = true;
            this.c_AGL.Size = new System.Drawing.Size(145, 20);
            this.c_AGL.Subtype = "AGL";
            this.c_AGL.TabIndex = 30;
            // 
            // c_Callsign
            // 
            this.c_Callsign.Location = new System.Drawing.Point(137, 291);
            this.c_Callsign.Name = "c_Callsign";
            this.c_Callsign.ReadOnly = true;
            this.c_Callsign.Size = new System.Drawing.Size(139, 20);
            this.c_Callsign.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Longitude";
            // 
            // c_Polar
            // 
            this.c_Polar.EnclosingComma = false;
            this.c_Polar.EriLovName = "eri_ANT_POLAR";
            this.c_Polar.Location = new System.Drawing.Point(139, 262);
            this.c_Polar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.c_Polar.Name = "c_Polar";
            this.c_Polar.ReadOnly = true;
            this.c_Polar.Size = new System.Drawing.Size(139, 20);
            this.c_Polar.TabIndex = 28;
            this.c_Polar.Value = "";
            // 
            // c_Radius
            // 
            this.c_Radius.Location = new System.Drawing.Point(137, 140);
            this.c_Radius.Margin = new System.Windows.Forms.Padding(0);
            this.c_Radius.Name = "c_Radius";
            this.c_Radius.ReadOnly = true;
            this.c_Radius.Size = new System.Drawing.Size(145, 20);
            this.c_Radius.Subtype = "Dist";
            this.c_Radius.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Latitude";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Radius";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "AGL";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 203);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Angle of elevation";
            // 
            // c_LocationName
            // 
            this.c_LocationName.Location = new System.Drawing.Point(137, 50);
            this.c_LocationName.Name = "c_LocationName";
            this.c_LocationName.ReadOnly = true;
            this.c_LocationName.Size = new System.Drawing.Size(145, 20);
            this.c_LocationName.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 233);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Azimuth";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 263);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "Polarization";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(16, 323);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 13);
            this.label27.TabIndex = 21;
            this.label27.Text = "Gain";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 293);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Call sign";
            // 
            // c_ModifiedDate
            // 
            this.c_ModifiedDate.Location = new System.Drawing.Point(83, 512);
            this.c_ModifiedDate.Name = "c_ModifiedDate";
            this.c_ModifiedDate.ReadOnly = true;
            this.c_ModifiedDate.Size = new System.Drawing.Size(203, 20);
            this.c_ModifiedDate.TabIndex = 29;
            // 
            // c_CreatedDate
            // 
            this.c_CreatedDate.Location = new System.Drawing.Point(83, 460);
            this.c_CreatedDate.Name = "c_CreatedDate";
            this.c_CreatedDate.ReadOnly = true;
            this.c_CreatedDate.Size = new System.Drawing.Size(203, 20);
            this.c_CreatedDate.TabIndex = 29;
            // 
            // c_ModifiedBy
            // 
            this.c_ModifiedBy.Location = new System.Drawing.Point(83, 486);
            this.c_ModifiedBy.Name = "c_ModifiedBy";
            this.c_ModifiedBy.ReadOnly = true;
            this.c_ModifiedBy.Size = new System.Drawing.Size(203, 20);
            this.c_ModifiedBy.TabIndex = 29;
            // 
            // c_CreatedBy
            // 
            this.c_CreatedBy.Location = new System.Drawing.Point(83, 432);
            this.c_CreatedBy.Name = "c_CreatedBy";
            this.c_CreatedBy.ReadOnly = true;
            this.c_CreatedBy.Size = new System.Drawing.Size(203, 20);
            this.c_CreatedBy.TabIndex = 29;
            // 
            // c_ClassSta
            // 
            this.c_ClassSta.EnclosingComma = false;
            this.c_ClassSta.EriLovName = null;
            this.c_ClassSta.Location = new System.Drawing.Point(142, 90);
            this.c_ClassSta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.c_ClassSta.Name = "c_ClassSta";
            this.c_ClassSta.ReadOnly = true;
            this.c_ClassSta.Size = new System.Drawing.Size(144, 20);
            this.c_ClassSta.TabIndex = 28;
            this.c_ClassSta.Value = "";
            // 
            // c_MapDisplay
            // 
            this.c_MapDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c_MapDisplay.CoverageName = null;
            this.c_MapDisplay.DisplayCsys = "4DEC";
            this.c_MapDisplay.InputGeomPoints = null;
            this.c_MapDisplay.InputGeomRadiusM = 0D;
            this.c_MapDisplay.InputMode = null;
            this.c_MapDisplay.InputType = null;
            this.c_MapDisplay.KmlsMaxCached = 20;
            this.c_MapDisplay.Location = new System.Drawing.Point(599, 5);
            this.c_MapDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.c_MapDisplay.Name = "c_MapDisplay";
            this.c_MapDisplay.Size = new System.Drawing.Size(525, 357);
            this.c_MapDisplay.StartLati = 40D;
            this.c_MapDisplay.StartLongi = -4D;
            this.c_MapDisplay.TabIndex = 27;
            // 
            // c_EOUSE
            // 
            this.c_EOUSE.Location = new System.Drawing.Point(134, 330);
            this.c_EOUSE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.c_EOUSE.Name = "c_EOUSE";
            this.c_EOUSE.ReadOnly = true;
            this.c_EOUSE.Size = new System.Drawing.Size(152, 20);
            this.c_EOUSE.TabIndex = 25;
            this.c_EOUSE.Value = new System.DateTime(((long)(0)));
            // 
            // c_BIUSE
            // 
            this.c_BIUSE.Location = new System.Drawing.Point(134, 302);
            this.c_BIUSE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.c_BIUSE.Name = "c_BIUSE";
            this.c_BIUSE.ReadOnly = true;
            this.c_BIUSE.Size = new System.Drawing.Size(152, 20);
            this.c_BIUSE.TabIndex = 25;
            this.c_BIUSE.Value = new System.DateTime(((long)(0)));
            // 
            // c_DesignEm
            // 
            this.c_DesignEm.Location = new System.Drawing.Point(142, 118);
            this.c_DesignEm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.c_DesignEm.Name = "c_DesignEm";
            this.c_DesignEm.Size = new System.Drawing.Size(144, 20);
            this.c_DesignEm.TabIndex = 24;
            this.c_DesignEm.Value = null;
            // 
            // c_EIRPmin
            // 
            this.c_EIRPmin.ConfigName = null;
            this.c_EIRPmin.Location = new System.Drawing.Point(142, 236);
            this.c_EIRPmin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.c_EIRPmin.Name = "c_EIRPmin";
            this.c_EIRPmin.ReadOnly = true;
            this.c_EIRPmin.Size = new System.Drawing.Size(144, 20);
            this.c_EIRPmin.Subtype = "dBm";
            this.c_EIRPmin.TabIndex = 23;
            // 
            // c_EIRP
            // 
            this.c_EIRP.ConfigName = null;
            this.c_EIRP.Location = new System.Drawing.Point(142, 210);
            this.c_EIRP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.c_EIRP.Name = "c_EIRP";
            this.c_EIRP.ReadOnly = true;
            this.c_EIRP.Size = new System.Drawing.Size(144, 20);
            this.c_EIRP.Subtype = "dBm";
            this.c_EIRP.TabIndex = 23;
            // 
            // c_BwMin
            // 
            this.c_BwMin.Location = new System.Drawing.Point(142, 180);
            this.c_BwMin.Margin = new System.Windows.Forms.Padding(0);
            this.c_BwMin.Name = "c_BwMin";
            this.c_BwMin.ReadOnly = true;
            this.c_BwMin.Size = new System.Drawing.Size(144, 20);
            this.c_BwMin.Subtype = "F/kHz";
            this.c_BwMin.TabIndex = 22;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 63);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 13);
            this.label21.TabIndex = 21;
            this.label21.Text = "Classification";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "Status";
            // 
            // c_classification
            // 
            this.c_classification.Location = new System.Drawing.Point(142, 63);
            this.c_classification.Name = "c_classification";
            this.c_classification.ReadOnly = true;
            this.c_classification.Size = new System.Drawing.Size(144, 20);
            this.c_classification.TabIndex = 29;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(15, 491);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 13);
            this.label25.TabIndex = 21;
            this.label25.Text = "Modified";
            // 
            // c_Bw
            // 
            this.c_Bw.Location = new System.Drawing.Point(142, 147);
            this.c_Bw.Margin = new System.Windows.Forms.Padding(0);
            this.c_Bw.Name = "c_Bw";
            this.c_Bw.ReadOnly = true;
            this.c_Bw.Size = new System.Drawing.Size(144, 20);
            this.c_Bw.Subtype = "F/kHz";
            this.c_Bw.TabIndex = 22;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(15, 436);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 13);
            this.label24.TabIndex = 21;
            this.label24.Text = "Created";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "End of use";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Bring in use";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Lowest EIRP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "EIRP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Narrowest bandwidth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bandwidth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Designation of emission";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Classes of station";
            // 
            // c_Freq
            // 
            this.c_Freq.Location = new System.Drawing.Point(142, 5);
            this.c_Freq.Margin = new System.Windows.Forms.Padding(0);
            this.c_Freq.Name = "c_Freq";
            this.c_Freq.ReadOnly = true;
            this.c_Freq.Size = new System.Drawing.Size(144, 20);
            this.c_Freq.Subtype = "F/MHz";
            this.c_Freq.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(300, 369);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Recievers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Frequency";
            // 
            // MainSFAF_1
            // 
            this.MainSFAF_1.Controls.Add(this.ItemsGroup3);
            this.MainSFAF_1.Controls.Add(this.Save1);
            this.MainSFAF_1.Controls.Add(this.ItemsGroup2);
            this.MainSFAF_1.Controls.Add(this.ItemsGroup1);
            this.MainSFAF_1.Location = new System.Drawing.Point(4, 22);
            this.MainSFAF_1.Name = "MainSFAF_1";
            this.MainSFAF_1.Padding = new System.Windows.Forms.Padding(3);
            this.MainSFAF_1.Size = new System.Drawing.Size(1142, 542);
            this.MainSFAF_1.TabIndex = 1;
            this.MainSFAF_1.Text = " SFAF 1/3";
            this.MainSFAF_1.UseVisualStyleBackColor = true;
            // 
            // ItemsGroup3
            // 
            this.ItemsGroup3.Controls.Add(this.SFAF_130);
            this.ItemsGroup3.Controls.Add(this.SFAF_140);
            this.ItemsGroup3.Controls.Add(this.SFAF_141);
            this.ItemsGroup3.Controls.Add(this.SFAF_144);
            this.ItemsGroup3.Controls.Add(this.SFAF_152);
            this.ItemsGroup3.Controls.Add(this.SFAF_142);
            this.ItemsGroup3.Controls.Add(this.SFAF_147);
            this.ItemsGroup3.Controls.Add(this.SFAF_145);
            this.ItemsGroup3.Controls.Add(this.SFAF_151);
            this.ItemsGroup3.Controls.Add(this.SFAF_131);
            this.ItemsGroup3.Controls.Add(this.SFAF_146);
            this.ItemsGroup3.Controls.Add(this.SFAF_143);
            this.ItemsGroup3.Location = new System.Drawing.Point(693, 6);
            this.ItemsGroup3.Name = "ItemsGroup3";
            this.ItemsGroup3.Size = new System.Drawing.Size(370, 413);
            this.ItemsGroup3.TabIndex = 4;
            this.ItemsGroup3.TabStop = false;
            this.ItemsGroup3.Text = "ItemsGroup3";
            // 
            // Save1
            // 
            this.Save1.Location = new System.Drawing.Point(1057, 511);
            this.Save1.Name = "Save1";
            this.Save1.Size = new System.Drawing.Size(79, 23);
            this.Save1.TabIndex = 3;
            this.Save1.Text = "Save";
            this.Save1.UseVisualStyleBackColor = true;
            this.Save1.Click += new System.EventHandler(this.Save_Click);
            // 
            // ItemsGroup2
            // 
            this.ItemsGroup2.Controls.Add(this.SFAF_116);
            this.ItemsGroup2.Controls.Add(this.SFAF_113);
            this.ItemsGroup2.Controls.Add(this.SFAF_115);
            this.ItemsGroup2.Controls.Add(this.SFAF_112);
            this.ItemsGroup2.Controls.Add(this.SFAF_114);
            this.ItemsGroup2.Controls.Add(this.SFAF_111);
            this.ItemsGroup2.Controls.Add(this.SFAF_110);
            this.ItemsGroup2.Controls.Add(this.SFAF_118);
            this.ItemsGroup2.Controls.Add(this.SFAF_117);
            this.ItemsGroup2.Location = new System.Drawing.Point(356, 6);
            this.ItemsGroup2.Name = "ItemsGroup2";
            this.ItemsGroup2.Size = new System.Drawing.Size(331, 413);
            this.ItemsGroup2.TabIndex = 2;
            this.ItemsGroup2.TabStop = false;
            this.ItemsGroup2.Text = "ItemsGroup2";
            // 
            // ItemsGroup1
            // 
            this.ItemsGroup1.Controls.Add(this.SFAF_020);
            this.ItemsGroup1.Controls.Add(this.SFAF_014);
            this.ItemsGroup1.Controls.Add(this.SFAF_107);
            this.ItemsGroup1.Controls.Add(this.SFAF_018);
            this.ItemsGroup1.Controls.Add(this.SFAF_010);
            this.ItemsGroup1.Controls.Add(this.SFAF_019);
            this.ItemsGroup1.Controls.Add(this.SFAF_013);
            this.ItemsGroup1.Controls.Add(this.SFAF_017);
            this.ItemsGroup1.Controls.Add(this.SFAF_007);
            this.ItemsGroup1.Controls.Add(this.SFAF_016);
            this.ItemsGroup1.Controls.Add(this.SFAF_006);
            this.ItemsGroup1.Controls.Add(this.SFAF_015);
            this.ItemsGroup1.Controls.Add(this.SFAF_106);
            this.ItemsGroup1.Controls.Add(this.SFAF_005);
            this.ItemsGroup1.Controls.Add(this.SFAF_102);
            this.ItemsGroup1.Controls.Add(this.SFAF_108);
            this.ItemsGroup1.Controls.Add(this.SFAF_103);
            this.ItemsGroup1.Controls.Add(this.SFAF_105);
            this.ItemsGroup1.Location = new System.Drawing.Point(8, 6);
            this.ItemsGroup1.Name = "ItemsGroup1";
            this.ItemsGroup1.Size = new System.Drawing.Size(342, 528);
            this.ItemsGroup1.TabIndex = 2;
            this.ItemsGroup1.TabStop = false;
            this.ItemsGroup1.Text = "ItemsGroup1";
            // 
            // MainSFAF_2
            // 
            this.MainSFAF_2.Controls.Add(this.Save2);
            this.MainSFAF_2.Controls.Add(this.Items8xx);
            this.MainSFAF_2.Controls.Add(this.Items2xx);
            this.MainSFAF_2.Controls.Add(this.Items5xx);
            this.MainSFAF_2.Controls.Add(this.Items7xx);
            this.MainSFAF_2.Location = new System.Drawing.Point(4, 22);
            this.MainSFAF_2.Name = "MainSFAF_2";
            this.MainSFAF_2.Padding = new System.Windows.Forms.Padding(3);
            this.MainSFAF_2.Size = new System.Drawing.Size(1142, 542);
            this.MainSFAF_2.TabIndex = 4;
            this.MainSFAF_2.Text = "SFAF 2/3";
            this.MainSFAF_2.UseVisualStyleBackColor = true;
            // 
            // Save2
            // 
            this.Save2.Location = new System.Drawing.Point(1055, 513);
            this.Save2.Name = "Save2";
            this.Save2.Size = new System.Drawing.Size(79, 23);
            this.Save2.TabIndex = 9;
            this.Save2.Text = "Save";
            this.Save2.UseVisualStyleBackColor = true;
            this.Save2.Click += new System.EventHandler(this.Save_Click);
            // 
            // Items8xx
            // 
            this.Items8xx.Controls.Add(this.SFAF_807);
            this.Items8xx.Controls.Add(this.SFAF_801);
            this.Items8xx.Controls.Add(this.SFAF_805);
            this.Items8xx.Controls.Add(this.SFAF_804);
            this.Items8xx.Controls.Add(this.SFAF_803);
            this.Items8xx.Controls.Add(this.SFAF_806);
            this.Items8xx.Location = new System.Drawing.Point(709, 260);
            this.Items8xx.Name = "Items8xx";
            this.Items8xx.Size = new System.Drawing.Size(379, 242);
            this.Items8xx.TabIndex = 8;
            this.Items8xx.TabStop = false;
            this.Items8xx.Text = "Items 8xx";
            // 
            // Items2xx
            // 
            this.Items2xx.Controls.Add(this.SFAF_209);
            this.Items2xx.Controls.Add(this.SFAF_208);
            this.Items2xx.Controls.Add(this.SFAF_207);
            this.Items2xx.Controls.Add(this.SFAF_203);
            this.Items2xx.Controls.Add(this.SFAF_204);
            this.Items2xx.Controls.Add(this.SFAF_205);
            this.Items2xx.Controls.Add(this.SFAF_200);
            this.Items2xx.Controls.Add(this.SFAF_206);
            this.Items2xx.Controls.Add(this.SFAF_201);
            this.Items2xx.Controls.Add(this.SFAF_202);
            this.Items2xx.Location = new System.Drawing.Point(8, 6);
            this.Items2xx.Name = "Items2xx";
            this.Items2xx.Size = new System.Drawing.Size(342, 305);
            this.Items2xx.TabIndex = 7;
            this.Items2xx.TabStop = false;
            this.Items2xx.Text = "Items 2xx";
            // 
            // Items5xx
            // 
            this.Items5xx.Controls.Add(this.SFAF_531);
            this.Items5xx.Controls.Add(this.SFAF_521);
            this.Items5xx.Controls.Add(this.SFAF_513);
            this.Items5xx.Controls.Add(this.SFAF_511);
            this.Items5xx.Controls.Add(this.SFAF_503);
            this.Items5xx.Controls.Add(this.SFAF_530);
            this.Items5xx.Controls.Add(this.SFAF_504);
            this.Items5xx.Controls.Add(this.SFAF_520);
            this.Items5xx.Controls.Add(this.SFAF_512);
            this.Items5xx.Controls.Add(this.SFAF_506);
            this.Items5xx.Controls.Add(this.SFAF_505);
            this.Items5xx.Controls.Add(this.SFAF_500);
            this.Items5xx.Controls.Add(this.SFAF_501);
            this.Items5xx.Controls.Add(this.SFAF_502);
            this.Items5xx.Location = new System.Drawing.Point(356, 6);
            this.Items5xx.Name = "Items5xx";
            this.Items5xx.Size = new System.Drawing.Size(732, 248);
            this.Items5xx.TabIndex = 6;
            this.Items5xx.TabStop = false;
            this.Items5xx.Text = "Items 5xx";
            // 
            // Items7xx
            // 
            this.Items7xx.Controls.Add(this.SFAF_716);
            this.Items7xx.Controls.Add(this.SFAF_715);
            this.Items7xx.Controls.Add(this.SFAF_711);
            this.Items7xx.Controls.Add(this.SFAF_701);
            this.Items7xx.Controls.Add(this.SFAF_707);
            this.Items7xx.Controls.Add(this.SFAF_704);
            this.Items7xx.Controls.Add(this.SFAF_702);
            this.Items7xx.Controls.Add(this.SFAF_710);
            this.Items7xx.Location = new System.Drawing.Point(356, 260);
            this.Items7xx.Name = "Items7xx";
            this.Items7xx.Size = new System.Drawing.Size(347, 242);
            this.Items7xx.TabIndex = 5;
            this.Items7xx.TabStop = false;
            this.Items7xx.Text = "Items 7xx";
            // 
            // MainSFAF_3
            // 
            this.MainSFAF_3.Controls.Add(this.Save3);
            this.MainSFAF_3.Controls.Add(this.Items9xx);
            this.MainSFAF_3.Location = new System.Drawing.Point(4, 22);
            this.MainSFAF_3.Name = "MainSFAF_3";
            this.MainSFAF_3.Size = new System.Drawing.Size(1142, 542);
            this.MainSFAF_3.TabIndex = 5;
            this.MainSFAF_3.Text = "SFAF 3/3";
            this.MainSFAF_3.UseVisualStyleBackColor = true;
            // 
            // Save3
            // 
            this.Save3.Location = new System.Drawing.Point(1055, 511);
            this.Save3.Name = "Save3";
            this.Save3.Size = new System.Drawing.Size(79, 23);
            this.Save3.TabIndex = 5;
            this.Save3.Text = "Save";
            this.Save3.UseVisualStyleBackColor = true;
            this.Save3.Click += new System.EventHandler(this.Save_Click);
            // 
            // Items9xx
            // 
            this.Items9xx.Controls.Add(this.SFAF_999);
            this.Items9xx.Controls.Add(this.SFAF_998);
            this.Items9xx.Controls.Add(this.SFAF_994);
            this.Items9xx.Controls.Add(this.SFAF_988);
            this.Items9xx.Controls.Add(this.SFAF_997);
            this.Items9xx.Controls.Add(this.SFAF_993);
            this.Items9xx.Controls.Add(this.SFAF_952);
            this.Items9xx.Controls.Add(this.SFAF_986);
            this.Items9xx.Controls.Add(this.SFAF_996);
            this.Items9xx.Controls.Add(this.SFAF_992);
            this.Items9xx.Controls.Add(this.SFAF_950);
            this.Items9xx.Controls.Add(this.SFAF_985);
            this.Items9xx.Controls.Add(this.SFAF_990);
            this.Items9xx.Controls.Add(this.SFAF_928);
            this.Items9xx.Controls.Add(this.SFAF_983);
            this.Items9xx.Controls.Add(this.SFAF_989);
            this.Items9xx.Controls.Add(this.SFAF_926);
            this.Items9xx.Controls.Add(this.SFAF_982);
            this.Items9xx.Controls.Add(this.SFAF_924);
            this.Items9xx.Controls.Add(this.SFAF_965);
            this.Items9xx.Controls.Add(this.SFAF_995);
            this.Items9xx.Controls.Add(this.SFAF_991);
            this.Items9xx.Controls.Add(this.SFAF_922);
            this.Items9xx.Controls.Add(this.SFAF_984);
            this.Items9xx.Controls.Add(this.SFAF_927);
            this.Items9xx.Controls.Add(this.SFAF_964);
            this.Items9xx.Controls.Add(this.SFAF_911);
            this.Items9xx.Controls.Add(this.SFAF_963);
            this.Items9xx.Controls.Add(this.SFAF_959);
            this.Items9xx.Controls.Add(this.SFAF_910);
            this.Items9xx.Controls.Add(this.SFAF_953);
            this.Items9xx.Controls.Add(this.SFAF_907);
            this.Items9xx.Controls.Add(this.SFAF_958);
            this.Items9xx.Controls.Add(this.SFAF_901);
            this.Items9xx.Controls.Add(this.SFAF_957);
            this.Items9xx.Controls.Add(this.SFAF_905);
            this.Items9xx.Controls.Add(this.SFAF_956);
            this.Items9xx.Controls.Add(this.SFAF_904);
            this.Items9xx.Controls.Add(this.SFAF_903);
            this.Items9xx.Controls.Add(this.SFAF_906);
            this.Items9xx.Location = new System.Drawing.Point(8, 3);
            this.Items9xx.Name = "Items9xx";
            this.Items9xx.Size = new System.Drawing.Size(985, 426);
            this.Items9xx.TabIndex = 4;
            this.Items9xx.TabStop = false;
            this.Items9xx.Text = "Items 9xx";
            // 
            // SFAF_TX
            // 
            this.SFAF_TX.Controls.Add(this.SaveTx);
            this.SFAF_TX.Controls.Add(this.Items3xx);
            this.SFAF_TX.Location = new System.Drawing.Point(4, 22);
            this.SFAF_TX.Name = "SFAF_TX";
            this.SFAF_TX.Padding = new System.Windows.Forms.Padding(3);
            this.SFAF_TX.Size = new System.Drawing.Size(1142, 542);
            this.SFAF_TX.TabIndex = 2;
            this.SFAF_TX.Text = "Transmitter";
            this.SFAF_TX.UseVisualStyleBackColor = true;
            // 
            // SaveTx
            // 
            this.SaveTx.Location = new System.Drawing.Point(1055, 511);
            this.SaveTx.Name = "SaveTx";
            this.SaveTx.Size = new System.Drawing.Size(79, 23);
            this.SaveTx.TabIndex = 100;
            this.SaveTx.Text = "Save";
            this.SaveTx.UseVisualStyleBackColor = true;
            this.SaveTx.Click += new System.EventHandler(this.Save_Click);
            // 
            // Items3xx
            // 
            this.Items3xx.Controls.Add(this.SFAF_300);
            this.Items3xx.Controls.Add(this.SFAF_361);
            this.Items3xx.Controls.Add(this.SFAF_304);
            this.Items3xx.Controls.Add(this.SFAF_342);
            this.Items3xx.Controls.Add(this.SFAF_301);
            this.Items3xx.Controls.Add(this.SFAF_360);
            this.Items3xx.Controls.Add(this.SFAF_347);
            this.Items3xx.Controls.Add(this.SFAF_374);
            this.Items3xx.Controls.Add(this.SFAF_302);
            this.Items3xx.Controls.Add(this.SFAF_341);
            this.Items3xx.Controls.Add(this.SFAF_344);
            this.Items3xx.Controls.Add(this.SFAF_359);
            this.Items3xx.Controls.Add(this.SFAF_303);
            this.Items3xx.Controls.Add(this.SFAF_363);
            this.Items3xx.Controls.Add(this.SFAF_345);
            this.Items3xx.Controls.Add(this.SFAF_340);
            this.Items3xx.Controls.Add(this.SFAF_346);
            this.Items3xx.Controls.Add(this.SFAF_357);
            this.Items3xx.Controls.Add(this.SFAF_306);
            this.Items3xx.Controls.Add(this.SFAF_362);
            this.Items3xx.Controls.Add(this.SFAF_343);
            this.Items3xx.Controls.Add(this.SFAF_319);
            this.Items3xx.Controls.Add(this.SFAF_315);
            this.Items3xx.Controls.Add(this.SFAF_356);
            this.Items3xx.Controls.Add(this.SFAF_348);
            this.Items3xx.Controls.Add(this.SFAF_318);
            this.Items3xx.Controls.Add(this.SFAF_349);
            this.Items3xx.Controls.Add(this.SFAF_355);
            this.Items3xx.Controls.Add(this.SFAF_316);
            this.Items3xx.Controls.Add(this.SFAF_373);
            this.Items3xx.Controls.Add(this.SFAF_354);
            this.Items3xx.Controls.Add(this.SFAF_317);
            this.Items3xx.Controls.Add(this.SFAF_321);
            this.Items3xx.Controls.Add(this.SFAF_358);
            this.Items3xx.Location = new System.Drawing.Point(8, 6);
            this.Items3xx.Name = "Items3xx";
            this.Items3xx.Size = new System.Drawing.Size(1053, 372);
            this.Items3xx.TabIndex = 99;
            this.Items3xx.TabStop = false;
            this.Items3xx.Text = "items3xx";
            // 
            // SFAF_RX
            // 
            this.SFAF_RX.Controls.Add(this.SaveThisRx);
            this.SFAF_RX.Controls.Add(this.Items4xx);
            this.SFAF_RX.Controls.Add(this.label23);
            this.SFAF_RX.Controls.Add(this.c_ListOfRx);
            this.SFAF_RX.Location = new System.Drawing.Point(4, 22);
            this.SFAF_RX.Name = "SFAF_RX";
            this.SFAF_RX.Size = new System.Drawing.Size(1142, 542);
            this.SFAF_RX.TabIndex = 3;
            this.SFAF_RX.Text = "Recievers";
            this.SFAF_RX.UseVisualStyleBackColor = true;
            // 
            // SaveThisRx
            // 
            this.SaveThisRx.Location = new System.Drawing.Point(1024, 511);
            this.SaveThisRx.Name = "SaveThisRx";
            this.SaveThisRx.Size = new System.Drawing.Size(110, 23);
            this.SaveThisRx.TabIndex = 136;
            this.SaveThisRx.Text = "Save active Rx";
            this.SaveThisRx.UseVisualStyleBackColor = true;
            this.SaveThisRx.Click += new System.EventHandler(this.SaveRx_Click);
            // 
            // Items4xx
            // 
            this.Items4xx.Controls.Add(this.SFAF_400);
            this.Items4xx.Controls.Add(this.SFAF_404);
            this.Items4xx.Controls.Add(this.SFAF_401);
            this.Items4xx.Controls.Add(this.SFAF_461);
            this.Items4xx.Controls.Add(this.SFAF_442);
            this.Items4xx.Controls.Add(this.SFAF_402);
            this.Items4xx.Controls.Add(this.SFAF_460);
            this.Items4xx.Controls.Add(this.SFAF_403);
            this.Items4xx.Controls.Add(this.SFAF_459);
            this.Items4xx.Controls.Add(this.SFAF_463);
            this.Items4xx.Controls.Add(this.SFAF_406);
            this.Items4xx.Controls.Add(this.SFAF_440);
            this.Items4xx.Controls.Add(this.SFAF_443);
            this.Items4xx.Controls.Add(this.SFAF_457);
            this.Items4xx.Controls.Add(this.SFAF_415);
            this.Items4xx.Controls.Add(this.SFAF_462);
            this.Items4xx.Controls.Add(this.SFAF_419);
            this.Items4xx.Controls.Add(this.SFAF_456);
            this.Items4xx.Controls.Add(this.SFAF_416);
            this.Items4xx.Controls.Add(this.SFAF_418);
            this.Items4xx.Controls.Add(this.SFAF_454);
            this.Items4xx.Controls.Add(this.SFAF_455);
            this.Items4xx.Controls.Add(this.SFAF_473);
            this.Items4xx.Controls.Add(this.SFAF_458);
            this.Items4xx.Controls.Add(this.SFAF_417);
            this.Items4xx.Location = new System.Drawing.Point(10, 213);
            this.Items4xx.Name = "Items4xx";
            this.Items4xx.Size = new System.Drawing.Size(1124, 281);
            this.Items4xx.TabIndex = 135;
            this.Items4xx.TabStop = false;
            this.Items4xx.Text = "Selected reciever (SFAF_RX)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(8, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(194, 13);
            this.label23.TabIndex = 134;
            this.label23.Text = "Recievers attached to this SFAF station";
            // 
            // c_ListOfRx
            // 
            this.c_ListOfRx.BackColor = System.Drawing.SystemColors.Control;
            this.c_ListOfRx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c_ListOfRx.ConfigName = "AdvSFAF_ListOfRx";
            this.c_ListOfRx.Filter = null;
            this.c_ListOfRx.Location = new System.Drawing.Point(8, 27);
            this.c_ListOfRx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.c_ListOfRx.Name = "c_ListOfRx";
            this.c_ListOfRx.Param1 = 0;
            this.c_ListOfRx.Param2 = 0;
            this.c_ListOfRx.Size = new System.Drawing.Size(1128, 177);
            this.c_ListOfRx.TabIndex = 133;
            this.c_ListOfRx.Table = "SFAF_RX";
            this.c_ListOfRx.OnRequery += new System.EventHandler(this.c_ListOfRx_OnRequery);
            this.c_ListOfRx.OnSelChanged += new System.EventHandler(this.c_ListOfRx_OnSelChanged);
            // 
            // c_Status
            // 
            this.c_Status.Coded = true;
            this.c_Status.Location = new System.Drawing.Point(142, 31);
            this.c_Status.Margin = new System.Windows.Forms.Padding(0);
            this.c_Status.MaxLen = 50;
            this.c_Status.Name = "c_Status";
            this.c_Status.ReadOnly = true;
            this.c_Status.Size = new System.Drawing.Size(144, 22);
            this.c_Status.Subtype = "eri_SfafAdminDataTypeAction";
            this.c_Status.TabIndex = 33;
            this.c_Status.Upperc = false;
            this.c_Status.Value = "";
            // 
            // SFAF_130
            // 
            this.SFAF_130.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_130.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_130.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_130.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_130.LabelText = "Label28";
            this.SFAF_130.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_130.Location = new System.Drawing.Point(17, 19);
            this.SFAF_130.Name = "SFAF_130";
            this.SFAF_130.Size = new System.Drawing.Size(315, 22);
            this.SFAF_130.TabIndex = 37;
            this.SFAF_130.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_130.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_130.TextValue = "";
            // 
            // SFAF_140
            // 
            this.SFAF_140.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_140.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_140.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_140.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_140.LabelText = "Label30";
            this.SFAF_140.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_140.Location = new System.Drawing.Point(17, 75);
            this.SFAF_140.Name = "SFAF_140";
            this.SFAF_140.Size = new System.Drawing.Size(315, 22);
            this.SFAF_140.TabIndex = 35;
            this.SFAF_140.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_140.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_140.TextValue = "";
            // 
            // SFAF_141
            // 
            this.SFAF_141.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_141.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_141.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_141.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_141.LabelText = "Label31";
            this.SFAF_141.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_141.Location = new System.Drawing.Point(17, 103);
            this.SFAF_141.Name = "SFAF_141";
            this.SFAF_141.Size = new System.Drawing.Size(315, 22);
            this.SFAF_141.TabIndex = 34;
            this.SFAF_141.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_141.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_141.TextValue = "";
            // 
            // SFAF_144
            // 
            this.SFAF_144.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_144.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_144.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_144.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_144.LabelText = "Label34";
            this.SFAF_144.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_144.Location = new System.Drawing.Point(17, 187);
            this.SFAF_144.Name = "SFAF_144";
            this.SFAF_144.Size = new System.Drawing.Size(315, 22);
            this.SFAF_144.TabIndex = 34;
            this.SFAF_144.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_144.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_144.TextValue = "";
            // 
            // SFAF_152
            // 
            this.SFAF_152.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_152.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_152.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_152.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_152.LabelText = "Label39";
            this.SFAF_152.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_152.Location = new System.Drawing.Point(17, 327);
            this.SFAF_152.Name = "SFAF_152";
            this.SFAF_152.Size = new System.Drawing.Size(315, 22);
            this.SFAF_152.TabIndex = 36;
            this.SFAF_152.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_152.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_152.TextValue = "";
            // 
            // SFAF_142
            // 
            this.SFAF_142.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_142.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_142.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_142.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_142.LabelText = "Label32";
            this.SFAF_142.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_142.Location = new System.Drawing.Point(17, 131);
            this.SFAF_142.Name = "SFAF_142";
            this.SFAF_142.Size = new System.Drawing.Size(315, 22);
            this.SFAF_142.TabIndex = 37;
            this.SFAF_142.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_142.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_142.TextValue = "";
            // 
            // SFAF_147
            // 
            this.SFAF_147.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_147.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_147.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_147.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_147.LabelText = "Label37";
            this.SFAF_147.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_147.Location = new System.Drawing.Point(17, 271);
            this.SFAF_147.Name = "SFAF_147";
            this.SFAF_147.Size = new System.Drawing.Size(315, 22);
            this.SFAF_147.TabIndex = 36;
            this.SFAF_147.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_147.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_147.TextValue = "";
            // 
            // SFAF_145
            // 
            this.SFAF_145.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_145.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_145.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_145.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_145.LabelText = "Label35";
            this.SFAF_145.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_145.Location = new System.Drawing.Point(17, 215);
            this.SFAF_145.Name = "SFAF_145";
            this.SFAF_145.Size = new System.Drawing.Size(315, 22);
            this.SFAF_145.TabIndex = 37;
            this.SFAF_145.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_145.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_145.TextValue = "";
            // 
            // SFAF_151
            // 
            this.SFAF_151.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_151.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_151.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_151.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_151.LabelText = "Label38";
            this.SFAF_151.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_151.Location = new System.Drawing.Point(17, 299);
            this.SFAF_151.Name = "SFAF_151";
            this.SFAF_151.Size = new System.Drawing.Size(315, 22);
            this.SFAF_151.TabIndex = 36;
            this.SFAF_151.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_151.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_151.TextValue = "";
            // 
            // SFAF_131
            // 
            this.SFAF_131.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_131.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_131.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_131.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_131.LabelText = "Label29";
            this.SFAF_131.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_131.Location = new System.Drawing.Point(17, 47);
            this.SFAF_131.Name = "SFAF_131";
            this.SFAF_131.Size = new System.Drawing.Size(315, 22);
            this.SFAF_131.TabIndex = 36;
            this.SFAF_131.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_131.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_131.TextValue = "";
            // 
            // SFAF_146
            // 
            this.SFAF_146.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_146.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_146.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_146.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_146.LabelText = "Label36";
            this.SFAF_146.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_146.Location = new System.Drawing.Point(17, 243);
            this.SFAF_146.Name = "SFAF_146";
            this.SFAF_146.Size = new System.Drawing.Size(315, 22);
            this.SFAF_146.TabIndex = 36;
            this.SFAF_146.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_146.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_146.TextValue = "";
            // 
            // SFAF_143
            // 
            this.SFAF_143.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_143.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_143.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_143.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_143.LabelText = "Label33";
            this.SFAF_143.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_143.Location = new System.Drawing.Point(17, 159);
            this.SFAF_143.Name = "SFAF_143";
            this.SFAF_143.Size = new System.Drawing.Size(315, 22);
            this.SFAF_143.TabIndex = 36;
            this.SFAF_143.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_143.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_143.TextValue = "";
            // 
            // SFAF_116
            // 
            this.SFAF_116.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_116.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_116.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_116.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_116.LabelText = "Label25";
            this.SFAF_116.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_116.Location = new System.Drawing.Point(6, 185);
            this.SFAF_116.Name = "SFAF_116";
            this.SFAF_116.Size = new System.Drawing.Size(315, 22);
            this.SFAF_116.TabIndex = 36;
            this.SFAF_116.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_116.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_116.TextValue = "";
            // 
            // SFAF_113
            // 
            this.SFAF_113.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_113.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_113.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_113.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_113.LabelText = "Label22";
            this.SFAF_113.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_113.Location = new System.Drawing.Point(6, 101);
            this.SFAF_113.Name = "SFAF_113";
            this.SFAF_113.Size = new System.Drawing.Size(315, 22);
            this.SFAF_113.TabIndex = 36;
            this.SFAF_113.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_113.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_113.TextValue = "";
            // 
            // SFAF_115
            // 
            this.SFAF_115.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_115.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_115.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_115.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_115.LabelText = "Label24";
            this.SFAF_115.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_115.Location = new System.Drawing.Point(6, 157);
            this.SFAF_115.Name = "SFAF_115";
            this.SFAF_115.Size = new System.Drawing.Size(315, 22);
            this.SFAF_115.TabIndex = 36;
            this.SFAF_115.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_115.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_115.TextValue = "";
            // 
            // SFAF_112
            // 
            this.SFAF_112.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_112.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_112.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_112.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_112.LabelText = "Label21";
            this.SFAF_112.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_112.Location = new System.Drawing.Point(6, 73);
            this.SFAF_112.Name = "SFAF_112";
            this.SFAF_112.Size = new System.Drawing.Size(315, 22);
            this.SFAF_112.TabIndex = 36;
            this.SFAF_112.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_112.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_112.TextValue = "";
            // 
            // SFAF_114
            // 
            this.SFAF_114.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_114.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_114.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_114.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_114.LabelText = "Label23";
            this.SFAF_114.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_114.Location = new System.Drawing.Point(6, 129);
            this.SFAF_114.Name = "SFAF_114";
            this.SFAF_114.Size = new System.Drawing.Size(315, 22);
            this.SFAF_114.TabIndex = 37;
            this.SFAF_114.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_114.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_114.TextValue = "";
            // 
            // SFAF_111
            // 
            this.SFAF_111.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_111.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_111.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_111.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_111.LabelText = "Label20";
            this.SFAF_111.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_111.Location = new System.Drawing.Point(6, 45);
            this.SFAF_111.Name = "SFAF_111";
            this.SFAF_111.Size = new System.Drawing.Size(315, 22);
            this.SFAF_111.TabIndex = 37;
            this.SFAF_111.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_111.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_111.TextValue = "";
            // 
            // SFAF_110
            // 
            this.SFAF_110.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_110.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_110.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_110.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_110.LabelText = "Label19";
            this.SFAF_110.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_110.Location = new System.Drawing.Point(6, 17);
            this.SFAF_110.Name = "SFAF_110";
            this.SFAF_110.Size = new System.Drawing.Size(315, 22);
            this.SFAF_110.TabIndex = 34;
            this.SFAF_110.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_110.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_110.TextValue = "";
            // 
            // SFAF_118
            // 
            this.SFAF_118.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_118.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_118.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_118.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_118.LabelText = "Label27";
            this.SFAF_118.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_118.Location = new System.Drawing.Point(6, 241);
            this.SFAF_118.Name = "SFAF_118";
            this.SFAF_118.Size = new System.Drawing.Size(315, 22);
            this.SFAF_118.TabIndex = 34;
            this.SFAF_118.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_118.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_118.TextValue = "";
            // 
            // SFAF_117
            // 
            this.SFAF_117.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_117.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_117.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_117.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_117.LabelText = "Label26";
            this.SFAF_117.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_117.Location = new System.Drawing.Point(6, 213);
            this.SFAF_117.Name = "SFAF_117";
            this.SFAF_117.Size = new System.Drawing.Size(315, 22);
            this.SFAF_117.TabIndex = 35;
            this.SFAF_117.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_117.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_117.TextValue = "";
            // 
            // SFAF_020
            // 
            this.SFAF_020.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_020.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_020.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_020.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_020.LabelText = "Label12";
            this.SFAF_020.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_020.Location = new System.Drawing.Point(6, 325);
            this.SFAF_020.Name = "SFAF_020";
            this.SFAF_020.Size = new System.Drawing.Size(315, 22);
            this.SFAF_020.TabIndex = 36;
            this.SFAF_020.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_020.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_020.TextValue = "";
            // 
            // SFAF_014
            // 
            this.SFAF_014.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_014.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_014.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_014.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_014.LabelText = "Label6";
            this.SFAF_014.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_014.Location = new System.Drawing.Point(5, 157);
            this.SFAF_014.Name = "SFAF_014";
            this.SFAF_014.Size = new System.Drawing.Size(315, 22);
            this.SFAF_014.TabIndex = 36;
            this.SFAF_014.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_014.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_014.TextValue = "";
            // 
            // SFAF_107
            // 
            this.SFAF_107.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_107.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_107.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_107.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_107.LabelText = "Label17";
            this.SFAF_107.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_107.Location = new System.Drawing.Point(6, 465);
            this.SFAF_107.Name = "SFAF_107";
            this.SFAF_107.Size = new System.Drawing.Size(315, 22);
            this.SFAF_107.TabIndex = 36;
            this.SFAF_107.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_107.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_107.TextValue = "";
            // 
            // SFAF_018
            // 
            this.SFAF_018.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_018.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_018.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_018.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_018.LabelText = "Label11";
            this.SFAF_018.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_018.Location = new System.Drawing.Point(6, 269);
            this.SFAF_018.Name = "SFAF_018";
            this.SFAF_018.Size = new System.Drawing.Size(315, 22);
            this.SFAF_018.TabIndex = 36;
            this.SFAF_018.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_018.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_018.TextValue = "";
            // 
            // SFAF_010
            // 
            this.SFAF_010.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_010.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_010.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_010.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_010.LabelText = "Label3";
            this.SFAF_010.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_010.Location = new System.Drawing.Point(5, 101);
            this.SFAF_010.Name = "SFAF_010";
            this.SFAF_010.Size = new System.Drawing.Size(315, 22);
            this.SFAF_010.TabIndex = 36;
            this.SFAF_010.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_010.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_010.TextValue = "";
            // 
            // SFAF_019
            // 
            this.SFAF_019.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_019.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_019.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_019.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_019.LabelText = "Label10";
            this.SFAF_019.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_019.Location = new System.Drawing.Point(6, 297);
            this.SFAF_019.Name = "SFAF_019";
            this.SFAF_019.Size = new System.Drawing.Size(315, 22);
            this.SFAF_019.TabIndex = 37;
            this.SFAF_019.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_019.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_019.TextValue = "";
            // 
            // SFAF_013
            // 
            this.SFAF_013.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_013.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_013.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_013.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_013.LabelText = "Label5";
            this.SFAF_013.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_013.Location = new System.Drawing.Point(5, 129);
            this.SFAF_013.Name = "SFAF_013";
            this.SFAF_013.Size = new System.Drawing.Size(315, 22);
            this.SFAF_013.TabIndex = 37;
            this.SFAF_013.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_013.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_013.TextValue = "";
            // 
            // SFAF_017
            // 
            this.SFAF_017.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_017.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_017.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_017.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_017.LabelText = "Label9";
            this.SFAF_017.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_017.Location = new System.Drawing.Point(6, 241);
            this.SFAF_017.Name = "SFAF_017";
            this.SFAF_017.Size = new System.Drawing.Size(315, 22);
            this.SFAF_017.TabIndex = 37;
            this.SFAF_017.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_017.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_017.TextValue = "";
            // 
            // SFAF_007
            // 
            this.SFAF_007.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_007.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_007.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_007.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_007.LabelText = "Label4";
            this.SFAF_007.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_007.Location = new System.Drawing.Point(5, 73);
            this.SFAF_007.Name = "SFAF_007";
            this.SFAF_007.Size = new System.Drawing.Size(315, 22);
            this.SFAF_007.TabIndex = 37;
            this.SFAF_007.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_007.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_007.TextValue = "";
            // 
            // SFAF_016
            // 
            this.SFAF_016.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_016.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_016.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_016.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_016.LabelText = "Label8";
            this.SFAF_016.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_016.Location = new System.Drawing.Point(6, 213);
            this.SFAF_016.Name = "SFAF_016";
            this.SFAF_016.Size = new System.Drawing.Size(315, 22);
            this.SFAF_016.TabIndex = 34;
            this.SFAF_016.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_016.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_016.TextValue = "";
            // 
            // SFAF_006
            // 
            this.SFAF_006.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_006.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_006.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_006.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_006.LabelText = "Label2";
            this.SFAF_006.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_006.Location = new System.Drawing.Point(5, 45);
            this.SFAF_006.Name = "SFAF_006";
            this.SFAF_006.Size = new System.Drawing.Size(315, 22);
            this.SFAF_006.TabIndex = 34;
            this.SFAF_006.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_006.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_006.TextValue = "";
            // 
            // SFAF_015
            // 
            this.SFAF_015.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_015.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_015.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_015.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_015.LabelText = "Label7";
            this.SFAF_015.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_015.Location = new System.Drawing.Point(6, 185);
            this.SFAF_015.Name = "SFAF_015";
            this.SFAF_015.Size = new System.Drawing.Size(315, 22);
            this.SFAF_015.TabIndex = 35;
            this.SFAF_015.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_015.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_015.TextValue = "";
            // 
            // SFAF_106
            // 
            this.SFAF_106.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_106.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_106.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_106.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_106.LabelText = "Label16";
            this.SFAF_106.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_106.Location = new System.Drawing.Point(6, 437);
            this.SFAF_106.Name = "SFAF_106";
            this.SFAF_106.Size = new System.Drawing.Size(315, 22);
            this.SFAF_106.TabIndex = 36;
            this.SFAF_106.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_106.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_106.TextValue = "";
            // 
            // SFAF_005
            // 
            this.SFAF_005.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_005.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_005.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_005.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_005.LabelText = "Label1";
            this.SFAF_005.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_005.Location = new System.Drawing.Point(5, 17);
            this.SFAF_005.Name = "SFAF_005";
            this.SFAF_005.Size = new System.Drawing.Size(315, 22);
            this.SFAF_005.TabIndex = 35;
            this.SFAF_005.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_005.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_005.TextValue = "";
            // 
            // SFAF_102
            // 
            this.SFAF_102.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_102.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_102.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_102.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_102.LabelText = "Label13";
            this.SFAF_102.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_102.Location = new System.Drawing.Point(6, 353);
            this.SFAF_102.Name = "SFAF_102";
            this.SFAF_102.Size = new System.Drawing.Size(315, 22);
            this.SFAF_102.TabIndex = 35;
            this.SFAF_102.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_102.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_102.TextValue = "";
            // 
            // SFAF_108
            // 
            this.SFAF_108.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_108.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_108.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_108.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_108.LabelText = "Label18";
            this.SFAF_108.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_108.Location = new System.Drawing.Point(6, 493);
            this.SFAF_108.Name = "SFAF_108";
            this.SFAF_108.Size = new System.Drawing.Size(315, 22);
            this.SFAF_108.TabIndex = 35;
            this.SFAF_108.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_108.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_108.TextValue = "";
            // 
            // SFAF_103
            // 
            this.SFAF_103.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_103.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_103.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_103.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_103.LabelText = "Label14";
            this.SFAF_103.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_103.Location = new System.Drawing.Point(6, 381);
            this.SFAF_103.Name = "SFAF_103";
            this.SFAF_103.Size = new System.Drawing.Size(315, 22);
            this.SFAF_103.TabIndex = 34;
            this.SFAF_103.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_103.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_103.TextValue = "";
            // 
            // SFAF_105
            // 
            this.SFAF_105.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_105.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_105.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_105.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_105.LabelText = "Label15";
            this.SFAF_105.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_105.Location = new System.Drawing.Point(6, 409);
            this.SFAF_105.Name = "SFAF_105";
            this.SFAF_105.Size = new System.Drawing.Size(315, 22);
            this.SFAF_105.TabIndex = 37;
            this.SFAF_105.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_105.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_105.TextValue = "";
            // 
            // SFAF_807
            // 
            this.SFAF_807.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_807.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_807.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_807.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_807.LabelText = "Label72";
            this.SFAF_807.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_807.Location = new System.Drawing.Point(9, 161);
            this.SFAF_807.Name = "SFAF_807";
            this.SFAF_807.Size = new System.Drawing.Size(315, 22);
            this.SFAF_807.TabIndex = 49;
            this.SFAF_807.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_807.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_807.TextValue = "";
            // 
            // SFAF_801
            // 
            this.SFAF_801.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_801.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_801.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_801.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_801.LabelText = "Label73";
            this.SFAF_801.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_801.Location = new System.Drawing.Point(9, 21);
            this.SFAF_801.Name = "SFAF_801";
            this.SFAF_801.Size = new System.Drawing.Size(315, 22);
            this.SFAF_801.TabIndex = 46;
            this.SFAF_801.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_801.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_801.TextValue = "";
            // 
            // SFAF_805
            // 
            this.SFAF_805.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_805.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_805.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_805.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_805.LabelText = "Label74";
            this.SFAF_805.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_805.Location = new System.Drawing.Point(9, 105);
            this.SFAF_805.Name = "SFAF_805";
            this.SFAF_805.Size = new System.Drawing.Size(315, 22);
            this.SFAF_805.TabIndex = 47;
            this.SFAF_805.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_805.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_805.TextValue = "";
            // 
            // SFAF_804
            // 
            this.SFAF_804.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_804.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_804.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_804.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_804.LabelText = "Label75";
            this.SFAF_804.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_804.Location = new System.Drawing.Point(9, 77);
            this.SFAF_804.Name = "SFAF_804";
            this.SFAF_804.Size = new System.Drawing.Size(315, 22);
            this.SFAF_804.TabIndex = 48;
            this.SFAF_804.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_804.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_804.TextValue = "";
            // 
            // SFAF_803
            // 
            this.SFAF_803.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_803.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_803.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_803.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_803.LabelText = "Label76";
            this.SFAF_803.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_803.Location = new System.Drawing.Point(9, 49);
            this.SFAF_803.Name = "SFAF_803";
            this.SFAF_803.Size = new System.Drawing.Size(315, 22);
            this.SFAF_803.TabIndex = 44;
            this.SFAF_803.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_803.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_803.TextValue = "";
            // 
            // SFAF_806
            // 
            this.SFAF_806.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_806.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_806.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_806.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_806.LabelText = "Label77";
            this.SFAF_806.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_806.Location = new System.Drawing.Point(9, 133);
            this.SFAF_806.Name = "SFAF_806";
            this.SFAF_806.Size = new System.Drawing.Size(315, 22);
            this.SFAF_806.TabIndex = 45;
            this.SFAF_806.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_806.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_806.TextValue = "";
            // 
            // SFAF_209
            // 
            this.SFAF_209.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_209.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_209.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_209.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_209.LabelText = "Label49";
            this.SFAF_209.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_209.Location = new System.Drawing.Point(6, 271);
            this.SFAF_209.Name = "SFAF_209";
            this.SFAF_209.Size = new System.Drawing.Size(315, 22);
            this.SFAF_209.TabIndex = 36;
            this.SFAF_209.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_209.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_209.TextValue = "";
            // 
            // SFAF_208
            // 
            this.SFAF_208.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_208.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_208.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_208.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_208.LabelText = "Label48";
            this.SFAF_208.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_208.Location = new System.Drawing.Point(5, 243);
            this.SFAF_208.Name = "SFAF_208";
            this.SFAF_208.Size = new System.Drawing.Size(315, 22);
            this.SFAF_208.TabIndex = 36;
            this.SFAF_208.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_208.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_208.TextValue = "";
            // 
            // SFAF_207
            // 
            this.SFAF_207.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_207.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_207.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_207.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_207.LabelText = "Label47";
            this.SFAF_207.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_207.Location = new System.Drawing.Point(6, 215);
            this.SFAF_207.Name = "SFAF_207";
            this.SFAF_207.Size = new System.Drawing.Size(315, 22);
            this.SFAF_207.TabIndex = 36;
            this.SFAF_207.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_207.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_207.TextValue = "";
            // 
            // SFAF_203
            // 
            this.SFAF_203.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_203.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_203.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_203.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_203.LabelText = "Label43";
            this.SFAF_203.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_203.Location = new System.Drawing.Point(6, 103);
            this.SFAF_203.Name = "SFAF_203";
            this.SFAF_203.Size = new System.Drawing.Size(315, 22);
            this.SFAF_203.TabIndex = 36;
            this.SFAF_203.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_203.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_203.TextValue = "";
            // 
            // SFAF_204
            // 
            this.SFAF_204.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_204.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_204.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_204.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_204.LabelText = "Label46";
            this.SFAF_204.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_204.Location = new System.Drawing.Point(6, 131);
            this.SFAF_204.Name = "SFAF_204";
            this.SFAF_204.Size = new System.Drawing.Size(315, 22);
            this.SFAF_204.TabIndex = 35;
            this.SFAF_204.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_204.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_204.TextValue = "";
            // 
            // SFAF_205
            // 
            this.SFAF_205.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_205.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_205.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_205.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_205.LabelText = "Label45";
            this.SFAF_205.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_205.Location = new System.Drawing.Point(6, 159);
            this.SFAF_205.Name = "SFAF_205";
            this.SFAF_205.Size = new System.Drawing.Size(315, 22);
            this.SFAF_205.TabIndex = 34;
            this.SFAF_205.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_205.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_205.TextValue = "";
            // 
            // SFAF_200
            // 
            this.SFAF_200.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_200.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_200.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_200.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_200.LabelText = "Label40";
            this.SFAF_200.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_200.Location = new System.Drawing.Point(6, 19);
            this.SFAF_200.Name = "SFAF_200";
            this.SFAF_200.Size = new System.Drawing.Size(315, 22);
            this.SFAF_200.TabIndex = 35;
            this.SFAF_200.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_200.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_200.TextValue = "";
            // 
            // SFAF_206
            // 
            this.SFAF_206.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_206.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_206.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_206.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_206.LabelText = "Label44";
            this.SFAF_206.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_206.Location = new System.Drawing.Point(6, 187);
            this.SFAF_206.Name = "SFAF_206";
            this.SFAF_206.Size = new System.Drawing.Size(315, 22);
            this.SFAF_206.TabIndex = 37;
            this.SFAF_206.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_206.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_206.TextValue = "";
            // 
            // SFAF_201
            // 
            this.SFAF_201.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_201.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_201.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_201.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_201.LabelText = "Label41";
            this.SFAF_201.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_201.Location = new System.Drawing.Point(6, 47);
            this.SFAF_201.Name = "SFAF_201";
            this.SFAF_201.Size = new System.Drawing.Size(315, 22);
            this.SFAF_201.TabIndex = 34;
            this.SFAF_201.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_201.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_201.TextValue = "";
            // 
            // SFAF_202
            // 
            this.SFAF_202.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_202.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_202.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_202.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_202.LabelText = "Label42";
            this.SFAF_202.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_202.Location = new System.Drawing.Point(6, 75);
            this.SFAF_202.Name = "SFAF_202";
            this.SFAF_202.Size = new System.Drawing.Size(315, 22);
            this.SFAF_202.TabIndex = 37;
            this.SFAF_202.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_202.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_202.TextValue = "";
            // 
            // SFAF_531
            // 
            this.SFAF_531.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_531.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_531.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_531.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_531.LabelText = "Label63";
            this.SFAF_531.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_531.Location = new System.Drawing.Point(362, 185);
            this.SFAF_531.Name = "SFAF_531";
            this.SFAF_531.Size = new System.Drawing.Size(315, 22);
            this.SFAF_531.TabIndex = 36;
            this.SFAF_531.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_531.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_531.TextValue = "";
            // 
            // SFAF_521
            // 
            this.SFAF_521.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_521.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_521.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_521.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_521.LabelText = "Label61";
            this.SFAF_521.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_521.Location = new System.Drawing.Point(362, 129);
            this.SFAF_521.Name = "SFAF_521";
            this.SFAF_521.Size = new System.Drawing.Size(315, 22);
            this.SFAF_521.TabIndex = 36;
            this.SFAF_521.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_521.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_521.TextValue = "";
            // 
            // SFAF_513
            // 
            this.SFAF_513.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_513.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_513.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_513.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_513.LabelText = "Label59";
            this.SFAF_513.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_513.Location = new System.Drawing.Point(362, 74);
            this.SFAF_513.Name = "SFAF_513";
            this.SFAF_513.Size = new System.Drawing.Size(315, 22);
            this.SFAF_513.TabIndex = 36;
            this.SFAF_513.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_513.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_513.TextValue = "";
            // 
            // SFAF_511
            // 
            this.SFAF_511.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_511.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_511.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_511.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_511.LabelText = "Label57";
            this.SFAF_511.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_511.Location = new System.Drawing.Point(362, 18);
            this.SFAF_511.Name = "SFAF_511";
            this.SFAF_511.Size = new System.Drawing.Size(315, 22);
            this.SFAF_511.TabIndex = 36;
            this.SFAF_511.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_511.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_511.TextValue = "";
            // 
            // SFAF_503
            // 
            this.SFAF_503.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_503.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_503.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_503.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_503.LabelText = "Label55";
            this.SFAF_503.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_503.Location = new System.Drawing.Point(6, 103);
            this.SFAF_503.Name = "SFAF_503";
            this.SFAF_503.Size = new System.Drawing.Size(315, 22);
            this.SFAF_503.TabIndex = 36;
            this.SFAF_503.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_503.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_503.TextValue = "";
            // 
            // SFAF_530
            // 
            this.SFAF_530.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_530.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_530.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_530.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_530.LabelText = "Label62";
            this.SFAF_530.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_530.Location = new System.Drawing.Point(362, 157);
            this.SFAF_530.Name = "SFAF_530";
            this.SFAF_530.Size = new System.Drawing.Size(315, 22);
            this.SFAF_530.TabIndex = 37;
            this.SFAF_530.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_530.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_530.TextValue = "";
            // 
            // SFAF_504
            // 
            this.SFAF_504.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_504.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_504.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_504.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_504.LabelText = "Label54";
            this.SFAF_504.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_504.Location = new System.Drawing.Point(6, 131);
            this.SFAF_504.Name = "SFAF_504";
            this.SFAF_504.Size = new System.Drawing.Size(315, 22);
            this.SFAF_504.TabIndex = 35;
            this.SFAF_504.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_504.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_504.TextValue = "";
            // 
            // SFAF_520
            // 
            this.SFAF_520.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_520.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_520.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_520.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_520.LabelText = "Label60";
            this.SFAF_520.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_520.Location = new System.Drawing.Point(362, 101);
            this.SFAF_520.Name = "SFAF_520";
            this.SFAF_520.Size = new System.Drawing.Size(315, 22);
            this.SFAF_520.TabIndex = 37;
            this.SFAF_520.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_520.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_520.TextValue = "";
            // 
            // SFAF_512
            // 
            this.SFAF_512.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_512.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_512.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_512.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_512.LabelText = "Label58";
            this.SFAF_512.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_512.Location = new System.Drawing.Point(362, 46);
            this.SFAF_512.Name = "SFAF_512";
            this.SFAF_512.Size = new System.Drawing.Size(315, 22);
            this.SFAF_512.TabIndex = 37;
            this.SFAF_512.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_512.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_512.TextValue = "";
            // 
            // SFAF_506
            // 
            this.SFAF_506.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_506.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_506.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_506.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_506.LabelText = "Label56";
            this.SFAF_506.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_506.Location = new System.Drawing.Point(6, 187);
            this.SFAF_506.Name = "SFAF_506";
            this.SFAF_506.Size = new System.Drawing.Size(315, 22);
            this.SFAF_506.TabIndex = 37;
            this.SFAF_506.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_506.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_506.TextValue = "";
            // 
            // SFAF_505
            // 
            this.SFAF_505.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_505.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_505.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_505.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_505.LabelText = "Label53";
            this.SFAF_505.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_505.Location = new System.Drawing.Point(6, 159);
            this.SFAF_505.Name = "SFAF_505";
            this.SFAF_505.Size = new System.Drawing.Size(315, 22);
            this.SFAF_505.TabIndex = 34;
            this.SFAF_505.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_505.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_505.TextValue = "";
            // 
            // SFAF_500
            // 
            this.SFAF_500.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_500.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_500.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_500.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_500.LabelText = "Label52";
            this.SFAF_500.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_500.Location = new System.Drawing.Point(6, 19);
            this.SFAF_500.Name = "SFAF_500";
            this.SFAF_500.Size = new System.Drawing.Size(315, 22);
            this.SFAF_500.TabIndex = 35;
            this.SFAF_500.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_500.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_500.TextValue = "";
            // 
            // SFAF_501
            // 
            this.SFAF_501.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_501.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_501.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_501.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_501.LabelText = "Label51";
            this.SFAF_501.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_501.Location = new System.Drawing.Point(6, 47);
            this.SFAF_501.Name = "SFAF_501";
            this.SFAF_501.Size = new System.Drawing.Size(315, 22);
            this.SFAF_501.TabIndex = 34;
            this.SFAF_501.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_501.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_501.TextValue = "";
            // 
            // SFAF_502
            // 
            this.SFAF_502.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_502.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_502.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_502.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_502.LabelText = "Label50";
            this.SFAF_502.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_502.Location = new System.Drawing.Point(6, 75);
            this.SFAF_502.Name = "SFAF_502";
            this.SFAF_502.Size = new System.Drawing.Size(315, 22);
            this.SFAF_502.TabIndex = 37;
            this.SFAF_502.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_502.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_502.TextValue = "";
            // 
            // SFAF_716
            // 
            this.SFAF_716.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_716.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_716.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_716.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_716.LabelText = "Label70";
            this.SFAF_716.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_716.Location = new System.Drawing.Point(9, 213);
            this.SFAF_716.Name = "SFAF_716";
            this.SFAF_716.Size = new System.Drawing.Size(315, 22);
            this.SFAF_716.TabIndex = 45;
            this.SFAF_716.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_716.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_716.TextValue = "";
            // 
            // SFAF_715
            // 
            this.SFAF_715.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_715.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_715.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_715.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_715.LabelText = "Label71";
            this.SFAF_715.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_715.Location = new System.Drawing.Point(9, 185);
            this.SFAF_715.Name = "SFAF_715";
            this.SFAF_715.Size = new System.Drawing.Size(315, 22);
            this.SFAF_715.TabIndex = 44;
            this.SFAF_715.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_715.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_715.TextValue = "";
            // 
            // SFAF_711
            // 
            this.SFAF_711.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_711.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_711.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_711.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_711.LabelText = "Label69";
            this.SFAF_711.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_711.Location = new System.Drawing.Point(9, 157);
            this.SFAF_711.Name = "SFAF_711";
            this.SFAF_711.Size = new System.Drawing.Size(315, 22);
            this.SFAF_711.TabIndex = 43;
            this.SFAF_711.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_711.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_711.TextValue = "";
            // 
            // SFAF_701
            // 
            this.SFAF_701.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_701.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_701.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_701.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_701.LabelText = "Label66";
            this.SFAF_701.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_701.Location = new System.Drawing.Point(9, 17);
            this.SFAF_701.Name = "SFAF_701";
            this.SFAF_701.Size = new System.Drawing.Size(315, 22);
            this.SFAF_701.TabIndex = 40;
            this.SFAF_701.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_701.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_701.TextValue = "";
            // 
            // SFAF_707
            // 
            this.SFAF_707.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_707.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_707.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_707.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_707.LabelText = "Label64";
            this.SFAF_707.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_707.Location = new System.Drawing.Point(9, 101);
            this.SFAF_707.Name = "SFAF_707";
            this.SFAF_707.Size = new System.Drawing.Size(315, 22);
            this.SFAF_707.TabIndex = 41;
            this.SFAF_707.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_707.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_707.TextValue = "";
            // 
            // SFAF_704
            // 
            this.SFAF_704.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_704.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_704.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_704.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_704.LabelText = "Label68";
            this.SFAF_704.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_704.Location = new System.Drawing.Point(9, 73);
            this.SFAF_704.Name = "SFAF_704";
            this.SFAF_704.Size = new System.Drawing.Size(315, 22);
            this.SFAF_704.TabIndex = 42;
            this.SFAF_704.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_704.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_704.TextValue = "";
            // 
            // SFAF_702
            // 
            this.SFAF_702.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_702.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_702.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_702.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_702.LabelText = "Label67";
            this.SFAF_702.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_702.Location = new System.Drawing.Point(9, 45);
            this.SFAF_702.Name = "SFAF_702";
            this.SFAF_702.Size = new System.Drawing.Size(315, 22);
            this.SFAF_702.TabIndex = 38;
            this.SFAF_702.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_702.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_702.TextValue = "";
            // 
            // SFAF_710
            // 
            this.SFAF_710.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_710.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_710.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_710.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_710.LabelText = "Label65";
            this.SFAF_710.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_710.Location = new System.Drawing.Point(9, 129);
            this.SFAF_710.Name = "SFAF_710";
            this.SFAF_710.Size = new System.Drawing.Size(315, 22);
            this.SFAF_710.TabIndex = 39;
            this.SFAF_710.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_710.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_710.TextValue = "";
            // 
            // SFAF_999
            // 
            this.SFAF_999.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_999.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_999.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_999.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_999.LabelText = "Label118";
            this.SFAF_999.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_999.Location = new System.Drawing.Point(648, 353);
            this.SFAF_999.Name = "SFAF_999";
            this.SFAF_999.Size = new System.Drawing.Size(315, 22);
            this.SFAF_999.TabIndex = 60;
            this.SFAF_999.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_999.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_999.TextValue = "";
            // 
            // SFAF_998
            // 
            this.SFAF_998.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_998.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_998.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_998.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_998.LabelText = "Label117";
            this.SFAF_998.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_998.Location = new System.Drawing.Point(648, 325);
            this.SFAF_998.Name = "SFAF_998";
            this.SFAF_998.Size = new System.Drawing.Size(315, 22);
            this.SFAF_998.TabIndex = 60;
            this.SFAF_998.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_998.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_998.TextValue = "";
            // 
            // SFAF_994
            // 
            this.SFAF_994.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_994.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_994.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_994.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_994.LabelText = "Label113";
            this.SFAF_994.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_994.Location = new System.Drawing.Point(648, 213);
            this.SFAF_994.Name = "SFAF_994";
            this.SFAF_994.Size = new System.Drawing.Size(315, 22);
            this.SFAF_994.TabIndex = 60;
            this.SFAF_994.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_994.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_994.TextValue = "";
            // 
            // SFAF_988
            // 
            this.SFAF_988.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_988.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_988.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_988.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_988.LabelText = "Label107";
            this.SFAF_988.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_988.Location = new System.Drawing.Point(648, 45);
            this.SFAF_988.Name = "SFAF_988";
            this.SFAF_988.Size = new System.Drawing.Size(315, 22);
            this.SFAF_988.TabIndex = 60;
            this.SFAF_988.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_988.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_988.TextValue = "";
            // 
            // SFAF_997
            // 
            this.SFAF_997.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_997.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_997.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_997.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_997.LabelText = "Label116";
            this.SFAF_997.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_997.Location = new System.Drawing.Point(648, 297);
            this.SFAF_997.Name = "SFAF_997";
            this.SFAF_997.Size = new System.Drawing.Size(315, 22);
            this.SFAF_997.TabIndex = 59;
            this.SFAF_997.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_997.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_997.TextValue = "";
            // 
            // SFAF_993
            // 
            this.SFAF_993.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_993.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_993.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_993.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_993.LabelText = "Label112";
            this.SFAF_993.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_993.Location = new System.Drawing.Point(648, 185);
            this.SFAF_993.Name = "SFAF_993";
            this.SFAF_993.Size = new System.Drawing.Size(315, 22);
            this.SFAF_993.TabIndex = 59;
            this.SFAF_993.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_993.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_993.TextValue = "";
            // 
            // SFAF_952
            // 
            this.SFAF_952.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_952.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_952.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_952.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_952.LabelText = "Label86";
            this.SFAF_952.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_952.Location = new System.Drawing.Point(327, 17);
            this.SFAF_952.Name = "SFAF_952";
            this.SFAF_952.Size = new System.Drawing.Size(315, 22);
            this.SFAF_952.TabIndex = 60;
            this.SFAF_952.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_952.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_952.TextValue = "";
            // 
            // SFAF_986
            // 
            this.SFAF_986.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_986.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_986.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_986.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_986.LabelText = "Label106";
            this.SFAF_986.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_986.Location = new System.Drawing.Point(648, 17);
            this.SFAF_986.Name = "SFAF_986";
            this.SFAF_986.Size = new System.Drawing.Size(315, 22);
            this.SFAF_986.TabIndex = 59;
            this.SFAF_986.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_986.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_986.TextValue = "";
            // 
            // SFAF_996
            // 
            this.SFAF_996.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_996.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_996.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_996.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_996.LabelText = "Label115";
            this.SFAF_996.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_996.Location = new System.Drawing.Point(648, 269);
            this.SFAF_996.Name = "SFAF_996";
            this.SFAF_996.Size = new System.Drawing.Size(315, 22);
            this.SFAF_996.TabIndex = 58;
            this.SFAF_996.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_996.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_996.TextValue = "";
            // 
            // SFAF_992
            // 
            this.SFAF_992.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_992.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_992.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_992.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_992.LabelText = "Label111";
            this.SFAF_992.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_992.Location = new System.Drawing.Point(648, 157);
            this.SFAF_992.Name = "SFAF_992";
            this.SFAF_992.Size = new System.Drawing.Size(315, 22);
            this.SFAF_992.TabIndex = 58;
            this.SFAF_992.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_992.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_992.TextValue = "";
            // 
            // SFAF_950
            // 
            this.SFAF_950.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_950.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_950.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_950.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_950.LabelText = "Label87";
            this.SFAF_950.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_950.Location = new System.Drawing.Point(6, 381);
            this.SFAF_950.Name = "SFAF_950";
            this.SFAF_950.Size = new System.Drawing.Size(315, 22);
            this.SFAF_950.TabIndex = 59;
            this.SFAF_950.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_950.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_950.TextValue = "";
            // 
            // SFAF_985
            // 
            this.SFAF_985.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_985.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_985.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_985.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_985.LabelText = "Label105";
            this.SFAF_985.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_985.Location = new System.Drawing.Point(327, 353);
            this.SFAF_985.Name = "SFAF_985";
            this.SFAF_985.Size = new System.Drawing.Size(315, 22);
            this.SFAF_985.TabIndex = 58;
            this.SFAF_985.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_985.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_985.TextValue = "";
            // 
            // SFAF_990
            // 
            this.SFAF_990.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_990.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_990.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_990.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_990.LabelText = "Label110";
            this.SFAF_990.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_990.Location = new System.Drawing.Point(648, 101);
            this.SFAF_990.Name = "SFAF_990";
            this.SFAF_990.Size = new System.Drawing.Size(315, 22);
            this.SFAF_990.TabIndex = 56;
            this.SFAF_990.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_990.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_990.TextValue = "";
            // 
            // SFAF_928
            // 
            this.SFAF_928.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_928.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_928.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_928.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_928.LabelText = "Label88";
            this.SFAF_928.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_928.Location = new System.Drawing.Point(6, 353);
            this.SFAF_928.Name = "SFAF_928";
            this.SFAF_928.Size = new System.Drawing.Size(315, 22);
            this.SFAF_928.TabIndex = 58;
            this.SFAF_928.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_928.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_928.TextValue = "";
            // 
            // SFAF_983
            // 
            this.SFAF_983.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_983.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_983.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_983.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_983.LabelText = "Label104";
            this.SFAF_983.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_983.Location = new System.Drawing.Point(327, 297);
            this.SFAF_983.Name = "SFAF_983";
            this.SFAF_983.Size = new System.Drawing.Size(315, 22);
            this.SFAF_983.TabIndex = 56;
            this.SFAF_983.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_983.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_983.TextValue = "";
            // 
            // SFAF_989
            // 
            this.SFAF_989.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_989.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_989.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_989.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_989.LabelText = "Label109";
            this.SFAF_989.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_989.Location = new System.Drawing.Point(648, 73);
            this.SFAF_989.Name = "SFAF_989";
            this.SFAF_989.Size = new System.Drawing.Size(315, 22);
            this.SFAF_989.TabIndex = 57;
            this.SFAF_989.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_989.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_989.TextValue = "";
            // 
            // SFAF_926
            // 
            this.SFAF_926.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_926.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_926.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_926.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_926.LabelText = "Label89";
            this.SFAF_926.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_926.Location = new System.Drawing.Point(6, 297);
            this.SFAF_926.Name = "SFAF_926";
            this.SFAF_926.Size = new System.Drawing.Size(315, 22);
            this.SFAF_926.TabIndex = 56;
            this.SFAF_926.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_926.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_926.TextValue = "";
            // 
            // SFAF_982
            // 
            this.SFAF_982.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_982.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_982.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_982.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_982.LabelText = "Label103";
            this.SFAF_982.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_982.Location = new System.Drawing.Point(327, 269);
            this.SFAF_982.Name = "SFAF_982";
            this.SFAF_982.Size = new System.Drawing.Size(315, 22);
            this.SFAF_982.TabIndex = 57;
            this.SFAF_982.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_982.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_982.TextValue = "";
            // 
            // SFAF_924
            // 
            this.SFAF_924.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_924.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_924.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_924.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_924.LabelText = "Label90";
            this.SFAF_924.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_924.Location = new System.Drawing.Point(6, 269);
            this.SFAF_924.Name = "SFAF_924";
            this.SFAF_924.Size = new System.Drawing.Size(315, 22);
            this.SFAF_924.TabIndex = 57;
            this.SFAF_924.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_924.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_924.TextValue = "";
            // 
            // SFAF_965
            // 
            this.SFAF_965.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_965.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_965.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_965.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_965.LabelText = "Label102";
            this.SFAF_965.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_965.Location = new System.Drawing.Point(327, 241);
            this.SFAF_965.Name = "SFAF_965";
            this.SFAF_965.Size = new System.Drawing.Size(315, 22);
            this.SFAF_965.TabIndex = 54;
            this.SFAF_965.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_965.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_965.TextValue = "";
            // 
            // SFAF_995
            // 
            this.SFAF_995.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_995.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_995.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_995.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_995.LabelText = "Label114";
            this.SFAF_995.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_995.Location = new System.Drawing.Point(648, 241);
            this.SFAF_995.Name = "SFAF_995";
            this.SFAF_995.Size = new System.Drawing.Size(315, 22);
            this.SFAF_995.TabIndex = 55;
            this.SFAF_995.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_995.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_995.TextValue = "";
            // 
            // SFAF_991
            // 
            this.SFAF_991.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_991.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_991.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_991.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_991.LabelText = "Label108";
            this.SFAF_991.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_991.Location = new System.Drawing.Point(648, 129);
            this.SFAF_991.Name = "SFAF_991";
            this.SFAF_991.Size = new System.Drawing.Size(315, 22);
            this.SFAF_991.TabIndex = 55;
            this.SFAF_991.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_991.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_991.TextValue = "";
            // 
            // SFAF_922
            // 
            this.SFAF_922.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_922.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_922.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_922.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_922.LabelText = "Label91";
            this.SFAF_922.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_922.Location = new System.Drawing.Point(6, 241);
            this.SFAF_922.Name = "SFAF_922";
            this.SFAF_922.Size = new System.Drawing.Size(315, 22);
            this.SFAF_922.TabIndex = 54;
            this.SFAF_922.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_922.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_922.TextValue = "";
            // 
            // SFAF_984
            // 
            this.SFAF_984.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_984.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_984.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_984.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_984.LabelText = "Label101";
            this.SFAF_984.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_984.Location = new System.Drawing.Point(327, 325);
            this.SFAF_984.Name = "SFAF_984";
            this.SFAF_984.Size = new System.Drawing.Size(315, 22);
            this.SFAF_984.TabIndex = 55;
            this.SFAF_984.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_984.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_984.TextValue = "";
            // 
            // SFAF_927
            // 
            this.SFAF_927.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_927.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_927.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_927.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_927.LabelText = "Label92";
            this.SFAF_927.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_927.Location = new System.Drawing.Point(6, 325);
            this.SFAF_927.Name = "SFAF_927";
            this.SFAF_927.Size = new System.Drawing.Size(315, 22);
            this.SFAF_927.TabIndex = 55;
            this.SFAF_927.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_927.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_927.TextValue = "";
            // 
            // SFAF_964
            // 
            this.SFAF_964.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_964.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_964.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_964.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_964.LabelText = "Label100";
            this.SFAF_964.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_964.Location = new System.Drawing.Point(327, 213);
            this.SFAF_964.Name = "SFAF_964";
            this.SFAF_964.Size = new System.Drawing.Size(315, 22);
            this.SFAF_964.TabIndex = 53;
            this.SFAF_964.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_964.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_964.TextValue = "";
            // 
            // SFAF_911
            // 
            this.SFAF_911.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_911.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_911.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_911.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_911.LabelText = "Label78";
            this.SFAF_911.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_911.Location = new System.Drawing.Point(6, 213);
            this.SFAF_911.Name = "SFAF_911";
            this.SFAF_911.Size = new System.Drawing.Size(315, 22);
            this.SFAF_911.TabIndex = 53;
            this.SFAF_911.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_911.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_911.TextValue = "";
            // 
            // SFAF_963
            // 
            this.SFAF_963.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_963.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_963.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_963.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_963.LabelText = "Label99";
            this.SFAF_963.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_963.Location = new System.Drawing.Point(327, 185);
            this.SFAF_963.Name = "SFAF_963";
            this.SFAF_963.Size = new System.Drawing.Size(315, 22);
            this.SFAF_963.TabIndex = 52;
            this.SFAF_963.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_963.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_963.TextValue = "";
            // 
            // SFAF_959
            // 
            this.SFAF_959.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_959.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_959.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_959.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_959.LabelText = "Label98";
            this.SFAF_959.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_959.Location = new System.Drawing.Point(327, 157);
            this.SFAF_959.Name = "SFAF_959";
            this.SFAF_959.Size = new System.Drawing.Size(315, 22);
            this.SFAF_959.TabIndex = 51;
            this.SFAF_959.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_959.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_959.TextValue = "";
            // 
            // SFAF_910
            // 
            this.SFAF_910.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_910.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_910.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_910.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_910.LabelText = "Label79";
            this.SFAF_910.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_910.Location = new System.Drawing.Point(6, 185);
            this.SFAF_910.Name = "SFAF_910";
            this.SFAF_910.Size = new System.Drawing.Size(315, 22);
            this.SFAF_910.TabIndex = 52;
            this.SFAF_910.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_910.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_910.TextValue = "";
            // 
            // SFAF_953
            // 
            this.SFAF_953.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_953.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_953.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_953.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_953.LabelText = "Label97";
            this.SFAF_953.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_953.Location = new System.Drawing.Point(327, 45);
            this.SFAF_953.Name = "SFAF_953";
            this.SFAF_953.Size = new System.Drawing.Size(315, 22);
            this.SFAF_953.TabIndex = 48;
            this.SFAF_953.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_953.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_953.TextValue = "";
            // 
            // SFAF_907
            // 
            this.SFAF_907.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_907.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_907.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_907.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_907.LabelText = "Label80";
            this.SFAF_907.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_907.Location = new System.Drawing.Point(6, 157);
            this.SFAF_907.Name = "SFAF_907";
            this.SFAF_907.Size = new System.Drawing.Size(315, 22);
            this.SFAF_907.TabIndex = 51;
            this.SFAF_907.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_907.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_907.TextValue = "";
            // 
            // SFAF_958
            // 
            this.SFAF_958.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_958.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_958.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_958.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_958.LabelText = "Label96";
            this.SFAF_958.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_958.Location = new System.Drawing.Point(327, 129);
            this.SFAF_958.Name = "SFAF_958";
            this.SFAF_958.Size = new System.Drawing.Size(315, 22);
            this.SFAF_958.TabIndex = 49;
            this.SFAF_958.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_958.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_958.TextValue = "";
            // 
            // SFAF_901
            // 
            this.SFAF_901.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_901.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_901.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_901.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_901.LabelText = "Label81";
            this.SFAF_901.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_901.Location = new System.Drawing.Point(6, 17);
            this.SFAF_901.Name = "SFAF_901";
            this.SFAF_901.Size = new System.Drawing.Size(315, 22);
            this.SFAF_901.TabIndex = 48;
            this.SFAF_901.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_901.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_901.TextValue = "";
            // 
            // SFAF_957
            // 
            this.SFAF_957.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_957.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_957.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_957.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_957.LabelText = "Label95";
            this.SFAF_957.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_957.Location = new System.Drawing.Point(327, 101);
            this.SFAF_957.Name = "SFAF_957";
            this.SFAF_957.Size = new System.Drawing.Size(315, 22);
            this.SFAF_957.TabIndex = 50;
            this.SFAF_957.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_957.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_957.TextValue = "";
            // 
            // SFAF_905
            // 
            this.SFAF_905.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_905.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_905.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_905.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_905.LabelText = "Label82";
            this.SFAF_905.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_905.Location = new System.Drawing.Point(6, 101);
            this.SFAF_905.Name = "SFAF_905";
            this.SFAF_905.Size = new System.Drawing.Size(315, 22);
            this.SFAF_905.TabIndex = 49;
            this.SFAF_905.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_905.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_905.TextValue = "";
            // 
            // SFAF_956
            // 
            this.SFAF_956.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_956.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_956.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_956.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_956.LabelText = "Label94";
            this.SFAF_956.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_956.Location = new System.Drawing.Point(327, 73);
            this.SFAF_956.Name = "SFAF_956";
            this.SFAF_956.Size = new System.Drawing.Size(315, 22);
            this.SFAF_956.TabIndex = 46;
            this.SFAF_956.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_956.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_956.TextValue = "";
            // 
            // SFAF_904
            // 
            this.SFAF_904.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_904.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_904.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_904.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_904.LabelText = "Label83";
            this.SFAF_904.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_904.Location = new System.Drawing.Point(6, 73);
            this.SFAF_904.Name = "SFAF_904";
            this.SFAF_904.Size = new System.Drawing.Size(315, 22);
            this.SFAF_904.TabIndex = 50;
            this.SFAF_904.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_904.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_904.TextValue = "";
            // 
            // SFAF_903
            // 
            this.SFAF_903.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_903.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_903.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_903.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_903.LabelText = "Label84";
            this.SFAF_903.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_903.Location = new System.Drawing.Point(6, 45);
            this.SFAF_903.Name = "SFAF_903";
            this.SFAF_903.Size = new System.Drawing.Size(315, 22);
            this.SFAF_903.TabIndex = 46;
            this.SFAF_903.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_903.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_903.TextValue = "";
            // 
            // SFAF_906
            // 
            this.SFAF_906.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_906.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_906.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_906.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_906.LabelText = "Label85";
            this.SFAF_906.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_906.Location = new System.Drawing.Point(6, 129);
            this.SFAF_906.Name = "SFAF_906";
            this.SFAF_906.Size = new System.Drawing.Size(315, 22);
            this.SFAF_906.TabIndex = 47;
            this.SFAF_906.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_906.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_906.TextValue = "";
            // 
            // SFAF_300
            // 
            this.SFAF_300.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_300.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_300.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_300.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_300.LabelText = "Label152";
            this.SFAF_300.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_300.Location = new System.Drawing.Point(6, 19);
            this.SFAF_300.Name = "SFAF_300";
            this.SFAF_300.Size = new System.Drawing.Size(315, 22);
            this.SFAF_300.TabIndex = 65;
            this.SFAF_300.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_300.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_300.TextValue = "";
            // 
            // SFAF_361
            // 
            this.SFAF_361.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_361.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_361.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_361.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_361.LabelText = "Label122";
            this.SFAF_361.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_361.Location = new System.Drawing.Point(648, 159);
            this.SFAF_361.Name = "SFAF_361";
            this.SFAF_361.Size = new System.Drawing.Size(315, 22);
            this.SFAF_361.TabIndex = 98;
            this.SFAF_361.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_361.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_361.TextValue = "";
            // 
            // SFAF_304
            // 
            this.SFAF_304.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_304.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_304.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_304.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_304.LabelText = "Label159";
            this.SFAF_304.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_304.Location = new System.Drawing.Point(6, 131);
            this.SFAF_304.Name = "SFAF_304";
            this.SFAF_304.Size = new System.Drawing.Size(315, 22);
            this.SFAF_304.TabIndex = 63;
            this.SFAF_304.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_304.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_304.TextValue = "";
            // 
            // SFAF_342
            // 
            this.SFAF_342.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_342.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_342.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_342.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_342.LabelText = "Label125";
            this.SFAF_342.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_342.Location = new System.Drawing.Point(327, 75);
            this.SFAF_342.Name = "SFAF_342";
            this.SFAF_342.Size = new System.Drawing.Size(315, 22);
            this.SFAF_342.TabIndex = 97;
            this.SFAF_342.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_342.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_342.TextValue = "";
            // 
            // SFAF_301
            // 
            this.SFAF_301.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_301.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_301.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_301.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_301.LabelText = "Label158";
            this.SFAF_301.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_301.Location = new System.Drawing.Point(6, 47);
            this.SFAF_301.Name = "SFAF_301";
            this.SFAF_301.Size = new System.Drawing.Size(315, 22);
            this.SFAF_301.TabIndex = 61;
            this.SFAF_301.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_301.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_301.TextValue = "";
            // 
            // SFAF_360
            // 
            this.SFAF_360.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_360.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_360.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_360.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_360.LabelText = "Label126";
            this.SFAF_360.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_360.Location = new System.Drawing.Point(648, 131);
            this.SFAF_360.Name = "SFAF_360";
            this.SFAF_360.Size = new System.Drawing.Size(315, 22);
            this.SFAF_360.TabIndex = 93;
            this.SFAF_360.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_360.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_360.TextValue = "";
            // 
            // SFAF_347
            // 
            this.SFAF_347.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_347.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_347.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_347.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_347.LabelText = "Label157";
            this.SFAF_347.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_347.Location = new System.Drawing.Point(327, 215);
            this.SFAF_347.Name = "SFAF_347";
            this.SFAF_347.Size = new System.Drawing.Size(315, 22);
            this.SFAF_347.TabIndex = 64;
            this.SFAF_347.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_347.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_347.TextValue = "";
            // 
            // SFAF_374
            // 
            this.SFAF_374.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_374.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_374.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_374.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_374.LabelText = "Label128";
            this.SFAF_374.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_374.Location = new System.Drawing.Point(648, 271);
            this.SFAF_374.Name = "SFAF_374";
            this.SFAF_374.Size = new System.Drawing.Size(315, 22);
            this.SFAF_374.TabIndex = 89;
            this.SFAF_374.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_374.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_374.TextValue = "";
            // 
            // SFAF_302
            // 
            this.SFAF_302.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_302.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_302.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_302.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_302.LabelText = "Label156";
            this.SFAF_302.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_302.Location = new System.Drawing.Point(6, 75);
            this.SFAF_302.Name = "SFAF_302";
            this.SFAF_302.Size = new System.Drawing.Size(315, 22);
            this.SFAF_302.TabIndex = 70;
            this.SFAF_302.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_302.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_302.TextValue = "";
            // 
            // SFAF_341
            // 
            this.SFAF_341.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_341.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_341.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_341.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_341.LabelText = "Label129";
            this.SFAF_341.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_341.Location = new System.Drawing.Point(327, 47);
            this.SFAF_341.Name = "SFAF_341";
            this.SFAF_341.Size = new System.Drawing.Size(315, 22);
            this.SFAF_341.TabIndex = 96;
            this.SFAF_341.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_341.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_341.TextValue = "";
            // 
            // SFAF_344
            // 
            this.SFAF_344.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_344.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_344.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_344.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_344.LabelText = "Label155";
            this.SFAF_344.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_344.Location = new System.Drawing.Point(327, 131);
            this.SFAF_344.Name = "SFAF_344";
            this.SFAF_344.Size = new System.Drawing.Size(315, 22);
            this.SFAF_344.TabIndex = 62;
            this.SFAF_344.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_344.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_344.TextValue = "";
            // 
            // SFAF_359
            // 
            this.SFAF_359.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_359.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_359.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_359.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_359.LabelText = "Label130";
            this.SFAF_359.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_359.Location = new System.Drawing.Point(648, 103);
            this.SFAF_359.Name = "SFAF_359";
            this.SFAF_359.Size = new System.Drawing.Size(315, 22);
            this.SFAF_359.TabIndex = 91;
            this.SFAF_359.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_359.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_359.TextValue = "";
            // 
            // SFAF_303
            // 
            this.SFAF_303.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_303.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_303.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_303.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_303.LabelText = "Label154";
            this.SFAF_303.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_303.Location = new System.Drawing.Point(6, 103);
            this.SFAF_303.Name = "SFAF_303";
            this.SFAF_303.Size = new System.Drawing.Size(315, 22);
            this.SFAF_303.TabIndex = 67;
            this.SFAF_303.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_303.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_303.TextValue = "";
            // 
            // SFAF_363
            // 
            this.SFAF_363.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_363.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_363.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_363.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_363.LabelText = "Label131";
            this.SFAF_363.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_363.Location = new System.Drawing.Point(648, 215);
            this.SFAF_363.Name = "SFAF_363";
            this.SFAF_363.Size = new System.Drawing.Size(315, 22);
            this.SFAF_363.TabIndex = 85;
            this.SFAF_363.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_363.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_363.TextValue = "";
            // 
            // SFAF_345
            // 
            this.SFAF_345.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_345.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_345.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_345.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_345.LabelText = "Label153";
            this.SFAF_345.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_345.Location = new System.Drawing.Point(327, 159);
            this.SFAF_345.Name = "SFAF_345";
            this.SFAF_345.Size = new System.Drawing.Size(315, 22);
            this.SFAF_345.TabIndex = 69;
            this.SFAF_345.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_345.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_345.TextValue = "";
            // 
            // SFAF_340
            // 
            this.SFAF_340.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_340.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_340.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_340.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_340.LabelText = "Label132";
            this.SFAF_340.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_340.Location = new System.Drawing.Point(327, 19);
            this.SFAF_340.Name = "SFAF_340";
            this.SFAF_340.Size = new System.Drawing.Size(315, 22);
            this.SFAF_340.TabIndex = 92;
            this.SFAF_340.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_340.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_340.TextValue = "";
            // 
            // SFAF_346
            // 
            this.SFAF_346.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_346.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_346.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_346.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_346.LabelText = "Label151";
            this.SFAF_346.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_346.Location = new System.Drawing.Point(327, 187);
            this.SFAF_346.Name = "SFAF_346";
            this.SFAF_346.Size = new System.Drawing.Size(315, 22);
            this.SFAF_346.TabIndex = 68;
            this.SFAF_346.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_346.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_346.TextValue = "";
            // 
            // SFAF_357
            // 
            this.SFAF_357.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_357.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_357.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_357.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_357.LabelText = "Label133";
            this.SFAF_357.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_357.Location = new System.Drawing.Point(648, 47);
            this.SFAF_357.Name = "SFAF_357";
            this.SFAF_357.Size = new System.Drawing.Size(315, 22);
            this.SFAF_357.TabIndex = 84;
            this.SFAF_357.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_357.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_357.TextValue = "";
            // 
            // SFAF_306
            // 
            this.SFAF_306.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_306.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_306.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_306.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_306.LabelText = "Label150";
            this.SFAF_306.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_306.Location = new System.Drawing.Point(6, 159);
            this.SFAF_306.Name = "SFAF_306";
            this.SFAF_306.Size = new System.Drawing.Size(315, 22);
            this.SFAF_306.TabIndex = 72;
            this.SFAF_306.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_306.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_306.TextValue = "";
            // 
            // SFAF_362
            // 
            this.SFAF_362.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_362.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_362.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_362.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_362.LabelText = "Label134";
            this.SFAF_362.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_362.Location = new System.Drawing.Point(648, 187);
            this.SFAF_362.Name = "SFAF_362";
            this.SFAF_362.Size = new System.Drawing.Size(315, 22);
            this.SFAF_362.TabIndex = 87;
            this.SFAF_362.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_362.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_362.TextValue = "";
            // 
            // SFAF_343
            // 
            this.SFAF_343.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_343.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_343.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_343.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_343.LabelText = "Label149";
            this.SFAF_343.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_343.Location = new System.Drawing.Point(327, 103);
            this.SFAF_343.Name = "SFAF_343";
            this.SFAF_343.Size = new System.Drawing.Size(315, 22);
            this.SFAF_343.TabIndex = 66;
            this.SFAF_343.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_343.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_343.TextValue = "";
            // 
            // SFAF_319
            // 
            this.SFAF_319.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_319.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_319.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_319.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_319.LabelText = "Label135";
            this.SFAF_319.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_319.Location = new System.Drawing.Point(6, 299);
            this.SFAF_319.Name = "SFAF_319";
            this.SFAF_319.Size = new System.Drawing.Size(315, 22);
            this.SFAF_319.TabIndex = 83;
            this.SFAF_319.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_319.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_319.TextValue = "";
            // 
            // SFAF_315
            // 
            this.SFAF_315.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_315.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_315.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_315.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_315.LabelText = "Label148";
            this.SFAF_315.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_315.Location = new System.Drawing.Point(6, 187);
            this.SFAF_315.Name = "SFAF_315";
            this.SFAF_315.Size = new System.Drawing.Size(315, 22);
            this.SFAF_315.TabIndex = 74;
            this.SFAF_315.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_315.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_315.TextValue = "";
            // 
            // SFAF_356
            // 
            this.SFAF_356.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_356.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_356.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_356.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_356.LabelText = "Label136";
            this.SFAF_356.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_356.Location = new System.Drawing.Point(648, 19);
            this.SFAF_356.Name = "SFAF_356";
            this.SFAF_356.Size = new System.Drawing.Size(315, 22);
            this.SFAF_356.TabIndex = 86;
            this.SFAF_356.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_356.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_356.TextValue = "";
            // 
            // SFAF_348
            // 
            this.SFAF_348.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_348.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_348.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_348.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_348.LabelText = "Label147";
            this.SFAF_348.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_348.Location = new System.Drawing.Point(327, 243);
            this.SFAF_348.Name = "SFAF_348";
            this.SFAF_348.Size = new System.Drawing.Size(315, 22);
            this.SFAF_348.TabIndex = 71;
            this.SFAF_348.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_348.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_348.TextValue = "";
            // 
            // SFAF_318
            // 
            this.SFAF_318.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_318.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_318.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_318.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_318.LabelText = "Label137";
            this.SFAF_318.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_318.Location = new System.Drawing.Point(6, 271);
            this.SFAF_318.Name = "SFAF_318";
            this.SFAF_318.Size = new System.Drawing.Size(315, 22);
            this.SFAF_318.TabIndex = 88;
            this.SFAF_318.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_318.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_318.TextValue = "";
            // 
            // SFAF_349
            // 
            this.SFAF_349.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_349.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_349.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_349.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_349.LabelText = "Label146";
            this.SFAF_349.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_349.Location = new System.Drawing.Point(327, 271);
            this.SFAF_349.Name = "SFAF_349";
            this.SFAF_349.Size = new System.Drawing.Size(315, 22);
            this.SFAF_349.TabIndex = 73;
            this.SFAF_349.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_349.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_349.TextValue = "";
            // 
            // SFAF_355
            // 
            this.SFAF_355.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_355.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_355.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_355.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_355.LabelText = "Label138";
            this.SFAF_355.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_355.Location = new System.Drawing.Point(327, 327);
            this.SFAF_355.Name = "SFAF_355";
            this.SFAF_355.Size = new System.Drawing.Size(315, 22);
            this.SFAF_355.TabIndex = 78;
            this.SFAF_355.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_355.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_355.TextValue = "";
            // 
            // SFAF_316
            // 
            this.SFAF_316.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_316.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_316.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_316.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_316.LabelText = "Label145";
            this.SFAF_316.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_316.Location = new System.Drawing.Point(6, 215);
            this.SFAF_316.Name = "SFAF_316";
            this.SFAF_316.Size = new System.Drawing.Size(315, 22);
            this.SFAF_316.TabIndex = 75;
            this.SFAF_316.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_316.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_316.TextValue = "";
            // 
            // SFAF_373
            // 
            this.SFAF_373.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_373.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_373.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_373.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_373.LabelText = "Label140";
            this.SFAF_373.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_373.Location = new System.Drawing.Point(648, 243);
            this.SFAF_373.Name = "SFAF_373";
            this.SFAF_373.Size = new System.Drawing.Size(315, 22);
            this.SFAF_373.TabIndex = 81;
            this.SFAF_373.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_373.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_373.TextValue = "";
            // 
            // SFAF_354
            // 
            this.SFAF_354.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_354.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_354.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_354.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_354.LabelText = "Label144";
            this.SFAF_354.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_354.Location = new System.Drawing.Point(327, 299);
            this.SFAF_354.Name = "SFAF_354";
            this.SFAF_354.Size = new System.Drawing.Size(315, 22);
            this.SFAF_354.TabIndex = 76;
            this.SFAF_354.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_354.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_354.TextValue = "";
            // 
            // SFAF_317
            // 
            this.SFAF_317.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_317.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_317.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_317.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_317.LabelText = "Label141";
            this.SFAF_317.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_317.Location = new System.Drawing.Point(6, 243);
            this.SFAF_317.Name = "SFAF_317";
            this.SFAF_317.Size = new System.Drawing.Size(315, 22);
            this.SFAF_317.TabIndex = 77;
            this.SFAF_317.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_317.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_317.TextValue = "";
            // 
            // SFAF_321
            // 
            this.SFAF_321.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_321.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_321.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_321.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_321.LabelText = "Label143";
            this.SFAF_321.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_321.Location = new System.Drawing.Point(6, 327);
            this.SFAF_321.Name = "SFAF_321";
            this.SFAF_321.Size = new System.Drawing.Size(315, 22);
            this.SFAF_321.TabIndex = 79;
            this.SFAF_321.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_321.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_321.TextValue = "";
            // 
            // SFAF_358
            // 
            this.SFAF_358.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_358.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_358.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_358.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_358.LabelText = "Label142";
            this.SFAF_358.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_358.Location = new System.Drawing.Point(648, 75);
            this.SFAF_358.Name = "SFAF_358";
            this.SFAF_358.Size = new System.Drawing.Size(315, 22);
            this.SFAF_358.TabIndex = 80;
            this.SFAF_358.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_358.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_358.TextValue = "";
            // 
            // SFAF_400
            // 
            this.SFAF_400.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_400.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_400.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_400.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_400.LabelText = "Label179";
            this.SFAF_400.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_400.Location = new System.Drawing.Point(6, 19);
            this.SFAF_400.Name = "SFAF_400";
            this.SFAF_400.Size = new System.Drawing.Size(315, 22);
            this.SFAF_400.TabIndex = 103;
            this.SFAF_400.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_400.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_400.TextValue = "";
            // 
            // SFAF_404
            // 
            this.SFAF_404.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_404.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_404.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_404.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_404.LabelText = "Label186";
            this.SFAF_404.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_404.Location = new System.Drawing.Point(6, 131);
            this.SFAF_404.Name = "SFAF_404";
            this.SFAF_404.Size = new System.Drawing.Size(315, 22);
            this.SFAF_404.TabIndex = 101;
            this.SFAF_404.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_404.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_404.TextValue = "";
            // 
            // SFAF_401
            // 
            this.SFAF_401.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_401.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_401.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_401.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_401.LabelText = "Label185";
            this.SFAF_401.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_401.Location = new System.Drawing.Point(6, 47);
            this.SFAF_401.Name = "SFAF_401";
            this.SFAF_401.Size = new System.Drawing.Size(315, 22);
            this.SFAF_401.TabIndex = 99;
            this.SFAF_401.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_401.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_401.TextValue = "";
            // 
            // SFAF_461
            // 
            this.SFAF_461.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_461.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_461.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_461.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_461.LabelText = "Label119";
            this.SFAF_461.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_461.Location = new System.Drawing.Point(648, 131);
            this.SFAF_461.Name = "SFAF_461";
            this.SFAF_461.Size = new System.Drawing.Size(315, 22);
            this.SFAF_461.TabIndex = 132;
            this.SFAF_461.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_461.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_461.TextValue = "";
            // 
            // SFAF_442
            // 
            this.SFAF_442.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_442.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_442.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_442.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_442.LabelText = "Label120";
            this.SFAF_442.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_442.Location = new System.Drawing.Point(327, 103);
            this.SFAF_442.Name = "SFAF_442";
            this.SFAF_442.Size = new System.Drawing.Size(315, 22);
            this.SFAF_442.TabIndex = 131;
            this.SFAF_442.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_442.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_442.TextValue = "";
            // 
            // SFAF_402
            // 
            this.SFAF_402.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_402.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_402.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_402.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_402.LabelText = "Label183";
            this.SFAF_402.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_402.Location = new System.Drawing.Point(6, 75);
            this.SFAF_402.Name = "SFAF_402";
            this.SFAF_402.Size = new System.Drawing.Size(315, 22);
            this.SFAF_402.TabIndex = 108;
            this.SFAF_402.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_402.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_402.TextValue = "";
            // 
            // SFAF_460
            // 
            this.SFAF_460.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_460.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_460.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_460.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_460.LabelText = "Label121";
            this.SFAF_460.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_460.Location = new System.Drawing.Point(648, 103);
            this.SFAF_460.Name = "SFAF_460";
            this.SFAF_460.Size = new System.Drawing.Size(315, 22);
            this.SFAF_460.TabIndex = 129;
            this.SFAF_460.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_460.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_460.TextValue = "";
            // 
            // SFAF_403
            // 
            this.SFAF_403.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_403.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_403.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_403.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_403.LabelText = "Label181";
            this.SFAF_403.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_403.Location = new System.Drawing.Point(6, 103);
            this.SFAF_403.Name = "SFAF_403";
            this.SFAF_403.Size = new System.Drawing.Size(315, 22);
            this.SFAF_403.TabIndex = 105;
            this.SFAF_403.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_403.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_403.TextValue = "";
            // 
            // SFAF_459
            // 
            this.SFAF_459.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_459.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_459.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_459.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_459.LabelText = "Label127";
            this.SFAF_459.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_459.Location = new System.Drawing.Point(648, 75);
            this.SFAF_459.Name = "SFAF_459";
            this.SFAF_459.Size = new System.Drawing.Size(315, 22);
            this.SFAF_459.TabIndex = 127;
            this.SFAF_459.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_459.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_459.TextValue = "";
            // 
            // SFAF_463
            // 
            this.SFAF_463.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_463.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_463.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_463.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_463.LabelText = "Label139";
            this.SFAF_463.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_463.Location = new System.Drawing.Point(648, 187);
            this.SFAF_463.Name = "SFAF_463";
            this.SFAF_463.Size = new System.Drawing.Size(315, 22);
            this.SFAF_463.TabIndex = 122;
            this.SFAF_463.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_463.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_463.TextValue = "";
            // 
            // SFAF_406
            // 
            this.SFAF_406.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_406.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_406.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_406.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_406.LabelText = "Label177";
            this.SFAF_406.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_406.Location = new System.Drawing.Point(6, 159);
            this.SFAF_406.Name = "SFAF_406";
            this.SFAF_406.Size = new System.Drawing.Size(315, 22);
            this.SFAF_406.TabIndex = 110;
            this.SFAF_406.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_406.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_406.TextValue = "";
            // 
            // SFAF_440
            // 
            this.SFAF_440.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_440.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_440.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_440.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_440.LabelText = "Label160";
            this.SFAF_440.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_440.Location = new System.Drawing.Point(327, 75);
            this.SFAF_440.Name = "SFAF_440";
            this.SFAF_440.Size = new System.Drawing.Size(315, 22);
            this.SFAF_440.TabIndex = 128;
            this.SFAF_440.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_440.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_440.TextValue = "";
            // 
            // SFAF_443
            // 
            this.SFAF_443.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_443.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_443.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_443.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_443.LabelText = "Label176";
            this.SFAF_443.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_443.Location = new System.Drawing.Point(327, 131);
            this.SFAF_443.Name = "SFAF_443";
            this.SFAF_443.Size = new System.Drawing.Size(315, 22);
            this.SFAF_443.TabIndex = 104;
            this.SFAF_443.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_443.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_443.TextValue = "";
            // 
            // SFAF_457
            // 
            this.SFAF_457.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_457.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_457.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_457.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_457.LabelText = "Label161";
            this.SFAF_457.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_457.Location = new System.Drawing.Point(648, 19);
            this.SFAF_457.Name = "SFAF_457";
            this.SFAF_457.Size = new System.Drawing.Size(315, 22);
            this.SFAF_457.TabIndex = 121;
            this.SFAF_457.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_457.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_457.TextValue = "";
            // 
            // SFAF_415
            // 
            this.SFAF_415.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_415.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_415.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_415.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_415.LabelText = "Label175";
            this.SFAF_415.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_415.Location = new System.Drawing.Point(6, 187);
            this.SFAF_415.Name = "SFAF_415";
            this.SFAF_415.Size = new System.Drawing.Size(315, 22);
            this.SFAF_415.TabIndex = 112;
            this.SFAF_415.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_415.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_415.TextValue = "";
            // 
            // SFAF_462
            // 
            this.SFAF_462.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_462.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_462.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_462.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_462.LabelText = "Label162";
            this.SFAF_462.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_462.Location = new System.Drawing.Point(648, 159);
            this.SFAF_462.Name = "SFAF_462";
            this.SFAF_462.Size = new System.Drawing.Size(315, 22);
            this.SFAF_462.TabIndex = 124;
            this.SFAF_462.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_462.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_462.TextValue = "";
            // 
            // SFAF_419
            // 
            this.SFAF_419.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_419.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_419.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_419.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_419.LabelText = "Label163";
            this.SFAF_419.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_419.Location = new System.Drawing.Point(327, 47);
            this.SFAF_419.Name = "SFAF_419";
            this.SFAF_419.Size = new System.Drawing.Size(315, 22);
            this.SFAF_419.TabIndex = 120;
            this.SFAF_419.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_419.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_419.TextValue = "";
            // 
            // SFAF_456
            // 
            this.SFAF_456.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_456.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_456.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_456.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_456.LabelText = "Label164";
            this.SFAF_456.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_456.Location = new System.Drawing.Point(327, 215);
            this.SFAF_456.Name = "SFAF_456";
            this.SFAF_456.Size = new System.Drawing.Size(315, 22);
            this.SFAF_456.TabIndex = 123;
            this.SFAF_456.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_456.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_456.TextValue = "";
            // 
            // SFAF_416
            // 
            this.SFAF_416.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_416.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_416.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_416.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_416.LabelText = "Label172";
            this.SFAF_416.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_416.Location = new System.Drawing.Point(6, 215);
            this.SFAF_416.Name = "SFAF_416";
            this.SFAF_416.Size = new System.Drawing.Size(315, 22);
            this.SFAF_416.TabIndex = 113;
            this.SFAF_416.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_416.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_416.TextValue = "";
            // 
            // SFAF_418
            // 
            this.SFAF_418.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_418.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_418.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_418.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_418.LabelText = "Label165";
            this.SFAF_418.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_418.Location = new System.Drawing.Point(327, 19);
            this.SFAF_418.Name = "SFAF_418";
            this.SFAF_418.Size = new System.Drawing.Size(315, 22);
            this.SFAF_418.TabIndex = 125;
            this.SFAF_418.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_418.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_418.TextValue = "";
            // 
            // SFAF_454
            // 
            this.SFAF_454.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_454.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_454.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_454.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_454.LabelText = "Label171";
            this.SFAF_454.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_454.Location = new System.Drawing.Point(327, 159);
            this.SFAF_454.Name = "SFAF_454";
            this.SFAF_454.Size = new System.Drawing.Size(315, 22);
            this.SFAF_454.TabIndex = 114;
            this.SFAF_454.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_454.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_454.TextValue = "";
            // 
            // SFAF_455
            // 
            this.SFAF_455.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_455.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_455.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_455.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_455.LabelText = "Label166";
            this.SFAF_455.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_455.Location = new System.Drawing.Point(327, 187);
            this.SFAF_455.Name = "SFAF_455";
            this.SFAF_455.Size = new System.Drawing.Size(315, 22);
            this.SFAF_455.TabIndex = 116;
            this.SFAF_455.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_455.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_455.TextValue = "";
            // 
            // SFAF_473
            // 
            this.SFAF_473.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_473.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_473.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_473.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_473.LabelText = "Label167";
            this.SFAF_473.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_473.Location = new System.Drawing.Point(648, 215);
            this.SFAF_473.Name = "SFAF_473";
            this.SFAF_473.Size = new System.Drawing.Size(315, 22);
            this.SFAF_473.TabIndex = 119;
            this.SFAF_473.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_473.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_473.TextValue = "";
            // 
            // SFAF_458
            // 
            this.SFAF_458.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_458.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_458.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_458.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_458.LabelText = "Label169";
            this.SFAF_458.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_458.Location = new System.Drawing.Point(648, 47);
            this.SFAF_458.Name = "SFAF_458";
            this.SFAF_458.Size = new System.Drawing.Size(315, 22);
            this.SFAF_458.TabIndex = 118;
            this.SFAF_458.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_458.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_458.TextValue = "";
            // 
            // SFAF_417
            // 
            this.SFAF_417.BackColor = System.Drawing.Color.Transparent;
            this.SFAF_417.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFAF_417.ButtonBackColor = System.Drawing.Color.Transparent;
            this.SFAF_417.ButtonColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_417.LabelText = "Label168";
            this.SFAF_417.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.SFAF_417.Location = new System.Drawing.Point(6, 243);
            this.SFAF_417.Name = "SFAF_417";
            this.SFAF_417.Size = new System.Drawing.Size(315, 22);
            this.SFAF_417.TabIndex = 115;
            this.SFAF_417.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.SFAF_417.TextBoxColor = System.Drawing.SystemColors.WindowText;
            this.SFAF_417.TextValue = "";
            // 
            // SfafEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 568);
            this.Controls.Add(this.tabControl1);
            this.Name = "SfafEntityForm";
            this.Text = "SFAF";
            this.tabControl1.ResumeLayout(false);
            this.Summary.ResumeLayout(false);
            this.Summary.PerformLayout();
            this.SummaryTransmitter.ResumeLayout(false);
            this.SummaryTransmitter.PerformLayout();
            this.MainSFAF_1.ResumeLayout(false);
            this.ItemsGroup3.ResumeLayout(false);
            this.ItemsGroup2.ResumeLayout(false);
            this.ItemsGroup1.ResumeLayout(false);
            this.MainSFAF_2.ResumeLayout(false);
            this.Items8xx.ResumeLayout(false);
            this.Items2xx.ResumeLayout(false);
            this.Items5xx.ResumeLayout(false);
            this.Items7xx.ResumeLayout(false);
            this.MainSFAF_3.ResumeLayout(false);
            this.Items9xx.ResumeLayout(false);
            this.SFAF_TX.ResumeLayout(false);
            this.Items3xx.ResumeLayout(false);
            this.SFAF_RX.ResumeLayout(false);
            this.SFAF_RX.PerformLayout();
            this.Items4xx.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Summary;
        private System.Windows.Forms.TabPage MainSFAF_1;
        private System.Windows.Forms.TabPage SFAF_TX;
        private System.Windows.Forms.TabPage SFAF_RX;
        private NetPlugins2.IcsControls.IcsComboList c_Polar;
        private NetPlugins2.IcsControls.IcsComboList c_ClassSta;
        private NetPlugins2.IcsOpenlayers3 c_MapDisplay;
        private NetPlugins2.IcsDateTime c_EOUSE;
        private NetPlugins2.IcsDateTime c_BIUSE;
        private NetPlugins2.IcsDesigEmiss c_DesignEm;
        private NetPlugins2.IcsDoublePower c_EIRPmin;
        private NetPlugins2.IcsDoublePower c_EIRP;
        private NetPlugins2.IcsDouble c_BwMin;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private NetPlugins2.IcsDouble c_Bw;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private NetPlugins2.IcsDouble c_Freq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox SummaryTransmitter;
        private NetPlugins2.IcsDouble c_Azimuth;
        private System.Windows.Forms.Label label11;
        private NetPlugins2.IcsDouble c_Elev;
        private System.Windows.Forms.Label label10;
        private NetPlugins2.IcsDouble c_AGL;
        private System.Windows.Forms.Label label13;
        private NetPlugins2.IcsDouble c_Radius;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox c_LocationName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox c_Callsign;
        private System.Windows.Forms.TextBox c_ModifiedBy;
        private System.Windows.Forms.TextBox c_CreatedBy;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox ItemsGroup2;
        private System.Windows.Forms.GroupBox ItemsGroup1;
        private System.Windows.Forms.TabPage MainSFAF_2;
        private Controls.ExtentableTextBox SFAF_116;
        private Controls.ExtentableTextBox SFAF_113;
        private Controls.ExtentableTextBox SFAF_107;
        private Controls.ExtentableTextBox SFAF_115;
        private Controls.ExtentableTextBox SFAF_112;
        private Controls.ExtentableTextBox SFAF_152;
        private Controls.ExtentableTextBox SFAF_147;
        private Controls.ExtentableTextBox SFAF_151;
        private Controls.ExtentableTextBox SFAF_146;
        private Controls.ExtentableTextBox SFAF_143;
        private Controls.ExtentableTextBox SFAF_131;
        private Controls.ExtentableTextBox SFAF_106;
        private Controls.ExtentableTextBox SFAF_114;
        private Controls.ExtentableTextBox SFAF_111;
        private Controls.ExtentableTextBox SFAF_145;
        private Controls.ExtentableTextBox SFAF_142;
        private Controls.ExtentableTextBox SFAF_130;
        private Controls.ExtentableTextBox SFAF_105;
        private Controls.ExtentableTextBox SFAF_110;
        private Controls.ExtentableTextBox SFAF_144;
        private Controls.ExtentableTextBox SFAF_141;
        private Controls.ExtentableTextBox SFAF_118;
        private Controls.ExtentableTextBox SFAF_103;
        private Controls.ExtentableTextBox SFAF_108;
        private Controls.ExtentableTextBox SFAF_140;
        private Controls.ExtentableTextBox SFAF_117;
        private Controls.ExtentableTextBox SFAF_102;
        private Controls.ExtentableTextBox SFAF_020;
        private Controls.ExtentableTextBox SFAF_014;
        private Controls.ExtentableTextBox SFAF_018;
        private Controls.ExtentableTextBox SFAF_010;
        private Controls.ExtentableTextBox SFAF_019;
        private Controls.ExtentableTextBox SFAF_013;
        private Controls.ExtentableTextBox SFAF_017;
        private Controls.ExtentableTextBox SFAF_007;
        private Controls.ExtentableTextBox SFAF_016;
        private Controls.ExtentableTextBox SFAF_006;
        private Controls.ExtentableTextBox SFAF_015;
        private Controls.ExtentableTextBox SFAF_005;
        private Controls.ExtentableTextBox SFAF_361;
        private Controls.ExtentableTextBox SFAF_342;
        private Controls.ExtentableTextBox SFAF_360;
        private Controls.ExtentableTextBox SFAF_374;
        private Controls.ExtentableTextBox SFAF_341;
        private Controls.ExtentableTextBox SFAF_359;
        private Controls.ExtentableTextBox SFAF_363;
        private Controls.ExtentableTextBox SFAF_340;
        private Controls.ExtentableTextBox SFAF_357;
        private Controls.ExtentableTextBox SFAF_362;
        private Controls.ExtentableTextBox SFAF_319;
        private Controls.ExtentableTextBox SFAF_356;
        private Controls.ExtentableTextBox SFAF_318;
        private Controls.ExtentableTextBox SFAF_355;
        private Controls.ExtentableTextBox SFAF_373;
        private Controls.ExtentableTextBox SFAF_317;
        private Controls.ExtentableTextBox SFAF_358;
        private Controls.ExtentableTextBox SFAF_321;
        private Controls.ExtentableTextBox SFAF_354;
        private Controls.ExtentableTextBox SFAF_316;
        private Controls.ExtentableTextBox SFAF_349;
        private Controls.ExtentableTextBox SFAF_348;
        private Controls.ExtentableTextBox SFAF_315;
        private Controls.ExtentableTextBox SFAF_343;
        private Controls.ExtentableTextBox SFAF_306;
        private Controls.ExtentableTextBox SFAF_346;
        private Controls.ExtentableTextBox SFAF_300;
        private Controls.ExtentableTextBox SFAF_345;
        private Controls.ExtentableTextBox SFAF_303;
        private Controls.ExtentableTextBox SFAF_344;
        private Controls.ExtentableTextBox SFAF_302;
        private Controls.ExtentableTextBox SFAF_347;
        private Controls.ExtentableTextBox SFAF_301;
        private Controls.ExtentableTextBox SFAF_304;
        private System.Windows.Forms.Label label23;
        private NetPlugins2.IcsDBList c_ListOfRx;
        private Controls.ExtentableTextBox SFAF_461;
        private Controls.ExtentableTextBox SFAF_442;
        private Controls.ExtentableTextBox SFAF_460;
        private Controls.ExtentableTextBox SFAF_459;
        private Controls.ExtentableTextBox SFAF_463;
        private Controls.ExtentableTextBox SFAF_440;
        private Controls.ExtentableTextBox SFAF_457;
        private Controls.ExtentableTextBox SFAF_462;
        private Controls.ExtentableTextBox SFAF_419;
        private Controls.ExtentableTextBox SFAF_456;
        private Controls.ExtentableTextBox SFAF_418;
        private Controls.ExtentableTextBox SFAF_455;
        private Controls.ExtentableTextBox SFAF_473;
        private Controls.ExtentableTextBox SFAF_417;
        private Controls.ExtentableTextBox SFAF_458;
        private Controls.ExtentableTextBox SFAF_454;
        private Controls.ExtentableTextBox SFAF_416;
        private Controls.ExtentableTextBox SFAF_415;
        private Controls.ExtentableTextBox SFAF_443;
        private Controls.ExtentableTextBox SFAF_406;
        private Controls.ExtentableTextBox SFAF_400;
        private Controls.ExtentableTextBox SFAF_403;
        private Controls.ExtentableTextBox SFAF_402;
        private Controls.ExtentableTextBox SFAF_401;
        private Controls.ExtentableTextBox SFAF_404;
        private System.Windows.Forms.GroupBox Items8xx;
        private Controls.ExtentableTextBox SFAF_807;
        private Controls.ExtentableTextBox SFAF_801;
        private Controls.ExtentableTextBox SFAF_805;
        private Controls.ExtentableTextBox SFAF_804;
        private Controls.ExtentableTextBox SFAF_803;
        private Controls.ExtentableTextBox SFAF_806;
        private System.Windows.Forms.GroupBox Items2xx;
        private Controls.ExtentableTextBox SFAF_209;
        private Controls.ExtentableTextBox SFAF_208;
        private Controls.ExtentableTextBox SFAF_207;
        private Controls.ExtentableTextBox SFAF_203;
        private Controls.ExtentableTextBox SFAF_204;
        private Controls.ExtentableTextBox SFAF_205;
        private Controls.ExtentableTextBox SFAF_200;
        private Controls.ExtentableTextBox SFAF_206;
        private Controls.ExtentableTextBox SFAF_201;
        private Controls.ExtentableTextBox SFAF_202;
        private System.Windows.Forms.GroupBox Items5xx;
        private Controls.ExtentableTextBox SFAF_531;
        private Controls.ExtentableTextBox SFAF_521;
        private Controls.ExtentableTextBox SFAF_513;
        private Controls.ExtentableTextBox SFAF_511;
        private Controls.ExtentableTextBox SFAF_503;
        private Controls.ExtentableTextBox SFAF_530;
        private Controls.ExtentableTextBox SFAF_504;
        private Controls.ExtentableTextBox SFAF_520;
        private Controls.ExtentableTextBox SFAF_512;
        private Controls.ExtentableTextBox SFAF_506;
        private Controls.ExtentableTextBox SFAF_505;
        private Controls.ExtentableTextBox SFAF_500;
        private Controls.ExtentableTextBox SFAF_501;
        private Controls.ExtentableTextBox SFAF_502;
        private System.Windows.Forms.GroupBox Items7xx;
        private Controls.ExtentableTextBox SFAF_716;
        private Controls.ExtentableTextBox SFAF_715;
        private Controls.ExtentableTextBox SFAF_711;
        private Controls.ExtentableTextBox SFAF_701;
        private Controls.ExtentableTextBox SFAF_707;
        private Controls.ExtentableTextBox SFAF_704;
        private Controls.ExtentableTextBox SFAF_702;
        private Controls.ExtentableTextBox SFAF_710;
        private System.Windows.Forms.TabPage MainSFAF_3;
        private System.Windows.Forms.GroupBox Items9xx;
        private Controls.ExtentableTextBox SFAF_999;
        private Controls.ExtentableTextBox SFAF_998;
        private Controls.ExtentableTextBox SFAF_994;
        private Controls.ExtentableTextBox SFAF_988;
        private Controls.ExtentableTextBox SFAF_997;
        private Controls.ExtentableTextBox SFAF_993;
        private Controls.ExtentableTextBox SFAF_952;
        private Controls.ExtentableTextBox SFAF_986;
        private Controls.ExtentableTextBox SFAF_996;
        private Controls.ExtentableTextBox SFAF_992;
        private Controls.ExtentableTextBox SFAF_950;
        private Controls.ExtentableTextBox SFAF_985;
        private Controls.ExtentableTextBox SFAF_990;
        private Controls.ExtentableTextBox SFAF_928;
        private Controls.ExtentableTextBox SFAF_983;
        private Controls.ExtentableTextBox SFAF_989;
        private Controls.ExtentableTextBox SFAF_926;
        private Controls.ExtentableTextBox SFAF_982;
        private Controls.ExtentableTextBox SFAF_924;
        private Controls.ExtentableTextBox SFAF_965;
        private Controls.ExtentableTextBox SFAF_995;
        private Controls.ExtentableTextBox SFAF_991;
        private Controls.ExtentableTextBox SFAF_922;
        private Controls.ExtentableTextBox SFAF_984;
        private Controls.ExtentableTextBox SFAF_927;
        private Controls.ExtentableTextBox SFAF_964;
        private Controls.ExtentableTextBox SFAF_911;
        private Controls.ExtentableTextBox SFAF_963;
        private Controls.ExtentableTextBox SFAF_959;
        private Controls.ExtentableTextBox SFAF_910;
        private Controls.ExtentableTextBox SFAF_953;
        private Controls.ExtentableTextBox SFAF_907;
        private Controls.ExtentableTextBox SFAF_958;
        private Controls.ExtentableTextBox SFAF_901;
        private Controls.ExtentableTextBox SFAF_957;
        private Controls.ExtentableTextBox SFAF_905;
        private Controls.ExtentableTextBox SFAF_956;
        private Controls.ExtentableTextBox SFAF_904;
        private Controls.ExtentableTextBox SFAF_903;
        private Controls.ExtentableTextBox SFAF_906;
        private NetPlugins2.IcsDBList c_Recievers;
        private System.Windows.Forms.TextBox c_CreatedDate;
        private System.Windows.Forms.TextBox c_ModifiedDate;
        private NetPlugins2.IcsDouble c_Long;
        private NetPlugins2.IcsDouble c_Lat;
        private NetPlugins2.IcsDouble c_Gain;
        private System.Windows.Forms.Label label27;
        private NetPlugins2.IcsControls.IcsComboList c_Country;
        private System.Windows.Forms.GroupBox Items4xx;
        private System.Windows.Forms.GroupBox Items3xx;
        private System.Windows.Forms.Button Save1;
        private System.Windows.Forms.Button Save2;
        private System.Windows.Forms.Button Save3;
        private System.Windows.Forms.Button SaveTx;
        private System.Windows.Forms.Button SaveThisRx;
        private System.Windows.Forms.GroupBox ItemsGroup3;
        private System.Windows.Forms.TextBox c_classification;
        private NetPlugins2.IcsCombo c_Status;
    }
}