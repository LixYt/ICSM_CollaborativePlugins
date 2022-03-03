using FormsCs;
using NetPlugins2;

namespace XICSM.MiscTools
{
    partial class SearchInterf
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
            this.geoParam = new System.Windows.Forms.GroupBox();
            this.N0 = new FormsCs.IcsMetroRadioButton();
            this.N1 = new FormsCs.IcsMetroRadioButton();
            this.N2 = new FormsCs.IcsMetroRadioButton();
            this.freqParams = new System.Windows.Forms.GroupBox();
            this.radioDistance = new FormsCs.IcsMetroRadioButton();
            this.coverMode = new FormsCs.IcsMetroRadioButton();
            this.importOnMap = new FormsCs.IcsMetroButton();
            this.tabControl1 = new FormsCs.IcsMetroTabControl();
            this.tabConfig = new FormsCs.IcsMetroTabPage();
            this.CopyEtoB = new FormsCs.IcsMetroTile();
            this.CopyBtoE = new FormsCs.IcsMetroTile();
            this.StatusFilters = new System.Windows.Forms.GroupBox();
            this.panelSfaf = new FormsCs.IcsMetroPanel();
            this.LikeSfafState = new System.Windows.Forms.CheckBox();
            this.Sfaf_State = new NetPlugins2.IcsComboMetro();
            this.label7 = new FormsCs.IcsMetroLabel();
            this.panelMicrowa = new FormsCs.IcsMetroPanel();
            this.Microwa_State = new NetPlugins2.IcsComboMetro();
            this.LikeMwStatus = new System.Windows.Forms.CheckBox();
            this.LikeMwState = new System.Windows.Forms.CheckBox();
            this.label6 = new FormsCs.IcsMetroLabel();
            this.Microwa_Status = new NetPlugins2.IcsStatus();
            this.panelMobStation2 = new FormsCs.IcsMetroPanel();
            this.MobStation2_State = new NetPlugins2.IcsComboMetro();
            this.LikeMs2State = new System.Windows.Forms.CheckBox();
            this.LikeMs2Status = new System.Windows.Forms.CheckBox();
            this.label5 = new FormsCs.IcsMetroLabel();
            this.MobStation2_Status = new NetPlugins2.IcsStatus();
            this.label3 = new FormsCs.IcsMetroLabel();
            this.label2 = new FormsCs.IcsMetroLabel();
            this.panelMobStation = new FormsCs.IcsMetroPanel();
            this.LikeMsStatus = new System.Windows.Forms.CheckBox();
            this.LikeMsState = new System.Windows.Forms.CheckBox();
            this.label4 = new FormsCs.IcsMetroLabel();
            this.MobStation_Status = new NetPlugins2.IcsStatus();
            this.MobStation_State = new NetPlugins2.IcsComboMetro();
            this.DefaultKtbfArea = new System.Windows.Forms.GroupBox();
            this.DefaultKtbf = new NetPlugins2.IcsDoublePowerMetro();
            this.saveParam = new System.Windows.Forms.GroupBox();
            this.SaveName = new FormsCs.IcsMetroTextBox();
            this.labelSave = new FormsCs.IcsMetroLabel();
            this.SaveBox = new FormsCs.IcsMetroCheckBox();
            this.Tables = new System.Windows.Forms.GroupBox();
            this.inSfaf = new FormsCs.IcsMetroCheckBox();
            this.inMicrowa = new FormsCs.IcsMetroCheckBox();
            this.inMobStation2 = new FormsCs.IcsMetroCheckBox();
            this.inMobStation = new FormsCs.IcsMetroCheckBox();
            this.EouseFilter = new System.Windows.Forms.GroupBox();
            this.EouseBox = new FormsCs.IcsMetroCheckBox();
            this.EouseEnd = new NetPlugins2.IcsDateTime();
            this.and2 = new FormsCs.IcsMetroLabel();
            this.EouseStart = new NetPlugins2.IcsDateTime();
            this.BiuseFilter = new System.Windows.Forms.GroupBox();
            this.BiuseBox = new FormsCs.IcsMetroCheckBox();
            this.BiuseEnd = new NetPlugins2.IcsDateTime();
            this.and1 = new FormsCs.IcsMetroLabel();
            this.BiuseStart = new NetPlugins2.IcsDateTime();
            this.toEWX = new FormsCs.IcsMetroButton();
            this.RunSearch = new FormsCs.IcsMetroButton();
            this.tabWanted = new FormsCs.IcsMetroTabPage();
            this.DbListWanted = new NetPlugins2.IcsDBList();
            this.tabUW_MobStation = new FormsCs.IcsMetroTabPage();
            this.DbListMobStation = new NetPlugins2.IcsDBList();
            this.tabUW_MobStation2 = new FormsCs.IcsMetroTabPage();
            this.DbListMobStation2 = new NetPlugins2.IcsDBList();
            this.tabUW_Microwa = new FormsCs.IcsMetroTabPage();
            this.DbListMwa = new NetPlugins2.IcsDBList();
            this.tabUW_Sfaf = new FormsCs.IcsMetroTabPage();
            this.DbListSfaf = new NetPlugins2.IcsDBList();
            this.cancelThread = new FormsCs.IcsMetroTile();
            this.PendingSpinner = new FormsCs.IcsMetroProgressSpinner();
            this.geoParam.SuspendLayout();
            this.freqParams.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.StatusFilters.SuspendLayout();
            this.panelSfaf.SuspendLayout();
            this.panelMicrowa.SuspendLayout();
            this.panelMobStation2.SuspendLayout();
            this.panelMobStation.SuspendLayout();
            this.DefaultKtbfArea.SuspendLayout();
            this.saveParam.SuspendLayout();
            this.Tables.SuspendLayout();
            this.EouseFilter.SuspendLayout();
            this.BiuseFilter.SuspendLayout();
            this.tabWanted.SuspendLayout();
            this.tabUW_MobStation.SuspendLayout();
            this.tabUW_MobStation2.SuspendLayout();
            this.tabUW_Microwa.SuspendLayout();
            this.tabUW_Sfaf.SuspendLayout();
            this.SuspendLayout();
            // 
            // geoParam
            // 
            this.geoParam.Controls.Add(this.N0);
            this.geoParam.Controls.Add(this.N1);
            this.geoParam.Controls.Add(this.N2);
            this.geoParam.Location = new System.Drawing.Point(153, 6);
            this.geoParam.Name = "geoParam";
            this.geoParam.Size = new System.Drawing.Size(161, 134);
            this.geoParam.TabIndex = 1;
            this.geoParam.TabStop = false;
            this.geoParam.Text = "Frequency limits";
            // 
            // N0
            // 
            this.N0.AutoSize = true;
            this.N0.Location = new System.Drawing.Point(7, 92);
            this.N0.Name = "N0";
            this.N0.Size = new System.Drawing.Size(107, 30);
            this.N0.TabIndex = 2;
            this.N0.Text = "very tight mode\r\ncochannel";
            // 
            // N1
            // 
            this.N1.AutoSize = true;
            this.N1.Location = new System.Drawing.Point(7, 56);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(113, 30);
            this.N1.TabIndex = 1;
            this.N1.Text = "tight mode\r\nadjacent channel";
            // 
            // N2
            // 
            this.N2.AutoSize = true;
            this.N2.Checked = true;
            this.N2.Location = new System.Drawing.Point(7, 20);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(151, 30);
            this.N2.TabIndex = 0;
            this.N2.TabStop = true;
            this.N2.Text = "Spurious Domain\r\n(in accordance with ITU)";
            this.N2.Click += new System.EventHandler(this.N2_Click);
            this.N2.MouseHover += new System.EventHandler(this.N2_MouseHover);
            // 
            // freqParams
            // 
            this.freqParams.Controls.Add(this.radioDistance);
            this.freqParams.Controls.Add(this.coverMode);
            this.freqParams.Location = new System.Drawing.Point(8, 6);
            this.freqParams.Name = "freqParams";
            this.freqParams.Size = new System.Drawing.Size(139, 73);
            this.freqParams.TabIndex = 3;
            this.freqParams.TabStop = false;
            this.freqParams.Text = "Computing mode";
            // 
            // radioDistance
            // 
            this.radioDistance.AutoSize = true;
            this.radioDistance.Checked = true;
            this.radioDistance.Location = new System.Drawing.Point(6, 20);
            this.radioDistance.Name = "radioDistance";
            this.radioDistance.Size = new System.Drawing.Size(120, 15);
            this.radioDistance.TabIndex = 1;
            this.radioDistance.TabStop = true;
            this.radioDistance.Text = "radio horizon limit";
            // 
            // coverMode
            // 
            this.coverMode.AutoSize = true;
            this.coverMode.Location = new System.Drawing.Point(6, 47);
            this.coverMode.Name = "coverMode";
            this.coverMode.Size = new System.Drawing.Size(126, 15);
            this.coverMode.TabIndex = 0;
            this.coverMode.Text = "free space loss limit";
            // 
            // importOnMap
            // 
            this.importOnMap.Enabled = false;
            this.importOnMap.Location = new System.Drawing.Point(651, 282);
            this.importOnMap.Name = "importOnMap";
            this.importOnMap.Size = new System.Drawing.Size(141, 23);
            this.importOnMap.TabIndex = 4;
            this.importOnMap.Text = "Export to HTZ map";
            this.importOnMap.Click += new System.EventHandler(this.importOnMap_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabConfig);
            this.tabControl1.Controls.Add(this.tabWanted);
            this.tabControl1.Controls.Add(this.tabUW_MobStation);
            this.tabControl1.Controls.Add(this.tabUW_MobStation2);
            this.tabControl1.Controls.Add(this.tabUW_Microwa);
            this.tabControl1.Controls.Add(this.tabUW_Sfaf);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 395);
            this.tabControl1.TabIndex = 5;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.CopyEtoB);
            this.tabConfig.Controls.Add(this.CopyBtoE);
            this.tabConfig.Controls.Add(this.StatusFilters);
            this.tabConfig.Controls.Add(this.DefaultKtbfArea);
            this.tabConfig.Controls.Add(this.saveParam);
            this.tabConfig.Controls.Add(this.Tables);
            this.tabConfig.Controls.Add(this.EouseFilter);
            this.tabConfig.Controls.Add(this.BiuseFilter);
            this.tabConfig.Controls.Add(this.toEWX);
            this.tabConfig.Controls.Add(this.freqParams);
            this.tabConfig.Controls.Add(this.geoParam);
            this.tabConfig.Controls.Add(this.RunSearch);
            this.tabConfig.Controls.Add(this.importOnMap);
            this.tabConfig.HorizontalScrollbarBarColor = true;
            this.tabConfig.Location = new System.Drawing.Point(4, 28);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(792, 363);
            this.tabConfig.TabIndex = 4;
            this.tabConfig.Text = "Configuration";
            this.tabConfig.VerticalScrollbarBarColor = true;
            // 
            // CopyEtoB
            // 
            this.CopyEtoB.Location = new System.Drawing.Point(639, 60);
            this.CopyEtoB.Margin = new System.Windows.Forms.Padding(0);
            this.CopyEtoB.Name = "CopyEtoB";
            this.CopyEtoB.Size = new System.Drawing.Size(26, 26);
            this.CopyEtoB.TabIndex = 16;
            this.CopyEtoB.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CopyEtoB.UseTileImage = true;
            this.CopyEtoB.Visible = false;
            this.CopyEtoB.Click += new System.EventHandler(this.CopyEtoB_Click);
            // 
            // CopyBtoE
            // 
            this.CopyBtoE.Location = new System.Drawing.Point(604, 60);
            this.CopyBtoE.Margin = new System.Windows.Forms.Padding(0);
            this.CopyBtoE.Name = "CopyBtoE";
            this.CopyBtoE.Size = new System.Drawing.Size(26, 26);
            this.CopyBtoE.TabIndex = 15;
            this.CopyBtoE.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CopyBtoE.UseTileImage = true;
            this.CopyBtoE.Visible = false;
            this.CopyBtoE.Click += new System.EventHandler(this.CopyBtoE_Click);
            // 
            // StatusFilters
            // 
            this.StatusFilters.Controls.Add(this.panelSfaf);
            this.StatusFilters.Controls.Add(this.panelMicrowa);
            this.StatusFilters.Controls.Add(this.panelMobStation2);
            this.StatusFilters.Controls.Add(this.label3);
            this.StatusFilters.Controls.Add(this.label2);
            this.StatusFilters.Controls.Add(this.panelMobStation);
            this.StatusFilters.Location = new System.Drawing.Point(8, 146);
            this.StatusFilters.Name = "StatusFilters";
            this.StatusFilters.Size = new System.Drawing.Size(616, 196);
            this.StatusFilters.TabIndex = 14;
            this.StatusFilters.TabStop = false;
            this.StatusFilters.Text = "Status Filtering options by tables";
            // 
            // panelSfaf
            // 
            this.panelSfaf.Controls.Add(this.LikeSfafState);
            this.panelSfaf.Controls.Add(this.Sfaf_State);
            this.panelSfaf.Controls.Add(this.label7);
            this.panelSfaf.HorizontalScrollbarBarColor = true;
            this.panelSfaf.HorizontalScrollbarHighlightOnWheel = false;
            this.panelSfaf.HorizontalScrollbarSize = 10;
            this.panelSfaf.Location = new System.Drawing.Point(7, 154);
            this.panelSfaf.Name = "panelSfaf";
            this.panelSfaf.Size = new System.Drawing.Size(378, 34);
            this.panelSfaf.TabIndex = 6;
            this.panelSfaf.VerticalScrollbarBarColor = true;
            this.panelSfaf.VerticalScrollbarHighlightOnWheel = false;
            this.panelSfaf.VerticalScrollbarSize = 10;
            // 
            // LikeSfafState
            // 
            this.LikeSfafState.Appearance = System.Windows.Forms.Appearance.Button;
            this.LikeSfafState.Checked = true;
            this.LikeSfafState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LikeSfafState.Location = new System.Drawing.Point(182, 5);
            this.LikeSfafState.Name = "LikeSfafState";
            this.LikeSfafState.Size = new System.Drawing.Size(56, 21);
            this.LikeSfafState.TabIndex = 116;
            this.LikeSfafState.Text = "Like";
            this.LikeSfafState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LikeSfafState.CheckedChanged += new System.EventHandler(this.LikeMsState_CheckedChanged);
            // 
            // Sfaf_State
            // 
            this.Sfaf_State.Coded = true;
            this.Sfaf_State.Location = new System.Drawing.Point(241, 3);
            this.Sfaf_State.Margin = new System.Windows.Forms.Padding(0);
            this.Sfaf_State.MaxLen = 50;
            this.Sfaf_State.Name = "Sfaf_State";
            this.Sfaf_State.ReadOnly = false;
            this.Sfaf_State.Size = new System.Drawing.Size(131, 29);
            this.Sfaf_State.Subtype = "eri_StateFamilyX";
            this.Sfaf_State.TabIndex = 18;
            this.Sfaf_State.Upperc = false;
            this.Sfaf_State.Value = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "SFAF";
            // 
            // panelMicrowa
            // 
            this.panelMicrowa.Controls.Add(this.Microwa_State);
            this.panelMicrowa.Controls.Add(this.LikeMwStatus);
            this.panelMicrowa.Controls.Add(this.LikeMwState);
            this.panelMicrowa.Controls.Add(this.label6);
            this.panelMicrowa.Controls.Add(this.Microwa_Status);
            this.panelMicrowa.HorizontalScrollbarBarColor = true;
            this.panelMicrowa.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMicrowa.HorizontalScrollbarSize = 10;
            this.panelMicrowa.Location = new System.Drawing.Point(7, 114);
            this.panelMicrowa.Name = "panelMicrowa";
            this.panelMicrowa.Size = new System.Drawing.Size(580, 34);
            this.panelMicrowa.TabIndex = 5;
            this.panelMicrowa.VerticalScrollbarBarColor = true;
            this.panelMicrowa.VerticalScrollbarHighlightOnWheel = false;
            this.panelMicrowa.VerticalScrollbarSize = 10;
            // 
            // Microwa_State
            // 
            this.Microwa_State.Coded = true;
            this.Microwa_State.Location = new System.Drawing.Point(241, 5);
            this.Microwa_State.Margin = new System.Windows.Forms.Padding(0);
            this.Microwa_State.MaxLen = 50;
            this.Microwa_State.Name = "Microwa_State";
            this.Microwa_State.ReadOnly = false;
            this.Microwa_State.Size = new System.Drawing.Size(131, 29);
            this.Microwa_State.Subtype = "eri_StateFamilyX";
            this.Microwa_State.TabIndex = 19;
            this.Microwa_State.Upperc = false;
            this.Microwa_State.Value = "";
            // 
            // LikeMwStatus
            // 
            this.LikeMwStatus.Appearance = System.Windows.Forms.Appearance.Button;
            this.LikeMwStatus.Checked = true;
            this.LikeMwStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LikeMwStatus.Location = new System.Drawing.Point(379, 9);
            this.LikeMwStatus.Name = "LikeMwStatus";
            this.LikeMwStatus.Size = new System.Drawing.Size(56, 21);
            this.LikeMwStatus.TabIndex = 117;
            this.LikeMwStatus.Text = "Like";
            this.LikeMwStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LikeMwStatus.CheckedChanged += new System.EventHandler(this.LikeMsState_CheckedChanged);
            // 
            // LikeMwState
            // 
            this.LikeMwState.Appearance = System.Windows.Forms.Appearance.Button;
            this.LikeMwState.Checked = true;
            this.LikeMwState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LikeMwState.Location = new System.Drawing.Point(182, 9);
            this.LikeMwState.Name = "LikeMwState";
            this.LikeMwState.Size = new System.Drawing.Size(56, 21);
            this.LikeMwState.TabIndex = 117;
            this.LikeMwState.Text = "Like";
            this.LikeMwState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LikeMwState.CheckedChanged += new System.EventHandler(this.LikeMsState_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Microwaves stations";
            // 
            // Microwa_Status
            // 
            this.Microwa_Status.Location = new System.Drawing.Point(440, 9);
            this.Microwa_Status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Microwa_Status.MaxLen = 50;
            this.Microwa_Status.Name = "Microwa_Status";
            this.Microwa_Status.ReadOnly = false;
            this.Microwa_Status.Size = new System.Drawing.Size(135, 23);
            this.Microwa_Status.Subtype = null;
            this.Microwa_Status.TabIndex = 1;
            this.Microwa_Status.Value = "";
            // 
            // panelMobStation2
            // 
            this.panelMobStation2.Controls.Add(this.MobStation2_State);
            this.panelMobStation2.Controls.Add(this.LikeMs2State);
            this.panelMobStation2.Controls.Add(this.LikeMs2Status);
            this.panelMobStation2.Controls.Add(this.label5);
            this.panelMobStation2.Controls.Add(this.MobStation2_Status);
            this.panelMobStation2.HorizontalScrollbarBarColor = true;
            this.panelMobStation2.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMobStation2.HorizontalScrollbarSize = 10;
            this.panelMobStation2.Location = new System.Drawing.Point(7, 74);
            this.panelMobStation2.Name = "panelMobStation2";
            this.panelMobStation2.Size = new System.Drawing.Size(580, 34);
            this.panelMobStation2.TabIndex = 4;
            this.panelMobStation2.VerticalScrollbarBarColor = true;
            this.panelMobStation2.VerticalScrollbarHighlightOnWheel = false;
            this.panelMobStation2.VerticalScrollbarSize = 10;
            // 
            // MobStation2_State
            // 
            this.MobStation2_State.Coded = true;
            this.MobStation2_State.Location = new System.Drawing.Point(241, 3);
            this.MobStation2_State.Margin = new System.Windows.Forms.Padding(0);
            this.MobStation2_State.MaxLen = 50;
            this.MobStation2_State.Name = "MobStation2_State";
            this.MobStation2_State.ReadOnly = false;
            this.MobStation2_State.Size = new System.Drawing.Size(131, 29);
            this.MobStation2_State.Subtype = "eri_StateFamilyX";
            this.MobStation2_State.TabIndex = 20;
            this.MobStation2_State.Upperc = false;
            this.MobStation2_State.Value = "";
            // 
            // LikeMs2State
            // 
            this.LikeMs2State.Appearance = System.Windows.Forms.Appearance.Button;
            this.LikeMs2State.Checked = true;
            this.LikeMs2State.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LikeMs2State.Location = new System.Drawing.Point(182, 7);
            this.LikeMs2State.Name = "LikeMs2State";
            this.LikeMs2State.Size = new System.Drawing.Size(56, 21);
            this.LikeMs2State.TabIndex = 118;
            this.LikeMs2State.Text = "Like";
            this.LikeMs2State.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LikeMs2State.CheckedChanged += new System.EventHandler(this.LikeMsState_CheckedChanged);
            // 
            // LikeMs2Status
            // 
            this.LikeMs2Status.Appearance = System.Windows.Forms.Appearance.Button;
            this.LikeMs2Status.Checked = true;
            this.LikeMs2Status.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LikeMs2Status.Location = new System.Drawing.Point(379, 9);
            this.LikeMs2Status.Name = "LikeMs2Status";
            this.LikeMs2Status.Size = new System.Drawing.Size(56, 21);
            this.LikeMs2Status.TabIndex = 115;
            this.LikeMs2Status.Text = "Like";
            this.LikeMs2Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LikeMs2Status.CheckedChanged += new System.EventHandler(this.LikeMsState_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yet other terrestrial stations";
            // 
            // MobStation2_Status
            // 
            this.MobStation2_Status.Location = new System.Drawing.Point(440, 9);
            this.MobStation2_Status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MobStation2_Status.MaxLen = 50;
            this.MobStation2_Status.Name = "MobStation2_Status";
            this.MobStation2_Status.ReadOnly = false;
            this.MobStation2_Status.Size = new System.Drawing.Size(135, 28);
            this.MobStation2_Status.Subtype = "stat_MOB_STATION2";
            this.MobStation2_Status.TabIndex = 1;
            this.MobStation2_Status.Value = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(442, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Process status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(236, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Familly Status";
            // 
            // panelMobStation
            // 
            this.panelMobStation.Controls.Add(this.LikeMsStatus);
            this.panelMobStation.Controls.Add(this.LikeMsState);
            this.panelMobStation.Controls.Add(this.label4);
            this.panelMobStation.Controls.Add(this.MobStation_Status);
            this.panelMobStation.Controls.Add(this.MobStation_State);
            this.panelMobStation.HorizontalScrollbarBarColor = true;
            this.panelMobStation.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMobStation.HorizontalScrollbarSize = 10;
            this.panelMobStation.Location = new System.Drawing.Point(7, 34);
            this.panelMobStation.Name = "panelMobStation";
            this.panelMobStation.Size = new System.Drawing.Size(580, 34);
            this.panelMobStation.TabIndex = 0;
            this.panelMobStation.VerticalScrollbarBarColor = true;
            this.panelMobStation.VerticalScrollbarHighlightOnWheel = false;
            this.panelMobStation.VerticalScrollbarSize = 10;
            // 
            // LikeMsStatus
            // 
            this.LikeMsStatus.Appearance = System.Windows.Forms.Appearance.Button;
            this.LikeMsStatus.Checked = true;
            this.LikeMsStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LikeMsStatus.Location = new System.Drawing.Point(379, 7);
            this.LikeMsStatus.Name = "LikeMsStatus";
            this.LikeMsStatus.Size = new System.Drawing.Size(56, 21);
            this.LikeMsStatus.TabIndex = 116;
            this.LikeMsStatus.Text = "Like";
            this.LikeMsStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LikeMsStatus.CheckedChanged += new System.EventHandler(this.LikeMsState_CheckedChanged);
            // 
            // LikeMsState
            // 
            this.LikeMsState.Appearance = System.Windows.Forms.Appearance.Button;
            this.LikeMsState.Checked = true;
            this.LikeMsState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LikeMsState.Location = new System.Drawing.Point(182, 7);
            this.LikeMsState.Name = "LikeMsState";
            this.LikeMsState.Size = new System.Drawing.Size(56, 21);
            this.LikeMsState.TabIndex = 119;
            this.LikeMsState.Text = "Like";
            this.LikeMsState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LikeMsState.CheckedChanged += new System.EventHandler(this.LikeMsState_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Other terrestrial stations";
            // 
            // MobStation_Status
            // 
            this.MobStation_Status.Location = new System.Drawing.Point(440, 7);
            this.MobStation_Status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MobStation_Status.MaxLen = 50;
            this.MobStation_Status.Name = "MobStation_Status";
            this.MobStation_Status.ReadOnly = false;
            this.MobStation_Status.Size = new System.Drawing.Size(135, 28);
            this.MobStation_Status.Subtype = "stat_MOB_STATION";
            this.MobStation_Status.TabIndex = 1;
            this.MobStation_Status.Value = "";
            // 
            // MobStation_State
            // 
            this.MobStation_State.Coded = true;
            this.MobStation_State.Location = new System.Drawing.Point(241, 4);
            this.MobStation_State.Margin = new System.Windows.Forms.Padding(0);
            this.MobStation_State.MaxLen = 50;
            this.MobStation_State.Name = "MobStation_State";
            this.MobStation_State.ReadOnly = false;
            this.MobStation_State.Size = new System.Drawing.Size(131, 29);
            this.MobStation_State.Subtype = "eri_StateFamilyX";
            this.MobStation_State.TabIndex = 17;
            this.MobStation_State.Upperc = false;
            this.MobStation_State.Value = "";
            // 
            // DefaultKtbfArea
            // 
            this.DefaultKtbfArea.Controls.Add(this.DefaultKtbf);
            this.DefaultKtbfArea.Location = new System.Drawing.Point(8, 86);
            this.DefaultKtbfArea.Name = "DefaultKtbfArea";
            this.DefaultKtbfArea.Size = new System.Drawing.Size(139, 54);
            this.DefaultKtbfArea.TabIndex = 13;
            this.DefaultKtbfArea.TabStop = false;
            this.DefaultKtbfArea.Text = "default ktbf";
            // 
            // DefaultKtbf
            // 
            this.DefaultKtbf.ConfigName = null;
            this.DefaultKtbf.Location = new System.Drawing.Point(10, 21);
            this.DefaultKtbf.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DefaultKtbf.Name = "DefaultKtbf";
            this.DefaultKtbf.Size = new System.Drawing.Size(122, 20);
            this.DefaultKtbf.Subtype = "dBm";
            this.DefaultKtbf.TabIndex = 0;
            // 
            // saveParam
            // 
            this.saveParam.Controls.Add(this.SaveName);
            this.saveParam.Controls.Add(this.labelSave);
            this.saveParam.Controls.Add(this.SaveBox);
            this.saveParam.Location = new System.Drawing.Point(651, 159);
            this.saveParam.Name = "saveParam";
            this.saveParam.Size = new System.Drawing.Size(141, 85);
            this.saveParam.TabIndex = 12;
            this.saveParam.TabStop = false;
            this.saveParam.Text = "Save result bags";
            // 
            // SaveName
            // 
            this.SaveName.Location = new System.Drawing.Point(9, 45);
            this.SaveName.Name = "SaveName";
            this.SaveName.Size = new System.Drawing.Size(122, 20);
            this.SaveName.TabIndex = 2;
            this.SaveName.Visible = false;
            // 
            // labelSave
            // 
            this.labelSave.BackColor = System.Drawing.Color.Transparent;
            this.labelSave.Location = new System.Drawing.Point(6, 27);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(116, 19);
            this.labelSave.TabIndex = 1;
            this.labelSave.Text = "enter a save name";
            this.labelSave.Visible = false;
            // 
            // SaveBox
            // 
            this.SaveBox.Location = new System.Drawing.Point(95, -2);
            this.SaveBox.Name = "SaveBox";
            this.SaveBox.Size = new System.Drawing.Size(16, 16);
            this.SaveBox.TabIndex = 0;
            this.SaveBox.CheckedChanged += new System.EventHandler(this.SaveBox_CheckedChanged);
            // 
            // Tables
            // 
            this.Tables.Controls.Add(this.inSfaf);
            this.Tables.Controls.Add(this.inMicrowa);
            this.Tables.Controls.Add(this.inMobStation2);
            this.Tables.Controls.Add(this.inMobStation);
            this.Tables.Location = new System.Drawing.Point(320, 6);
            this.Tables.Name = "Tables";
            this.Tables.Size = new System.Drawing.Size(180, 134);
            this.Tables.TabIndex = 11;
            this.Tables.TabStop = false;
            this.Tables.Text = "Search in the following tables";
            // 
            // inSfaf
            // 
            this.inSfaf.Checked = true;
            this.inSfaf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inSfaf.Location = new System.Drawing.Point(9, 88);
            this.inSfaf.Name = "inSfaf";
            this.inSfaf.Size = new System.Drawing.Size(143, 15);
            this.inSfaf.TabIndex = 3;
            this.inSfaf.Text = "SFAF (warfare ed. only)";
            this.inSfaf.CheckedChanged += new System.EventHandler(this.inSfaf_CheckedChanged);
            // 
            // inMicrowa
            // 
            this.inMicrowa.Checked = true;
            this.inMicrowa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inMicrowa.Location = new System.Drawing.Point(9, 65);
            this.inMicrowa.Name = "inMicrowa";
            this.inMicrowa.Size = new System.Drawing.Size(108, 15);
            this.inMicrowa.TabIndex = 2;
            this.inMicrowa.Text = "Microwave links";
            this.inMicrowa.CheckedChanged += new System.EventHandler(this.inMicrowa_CheckedChanged);
            // 
            // inMobStation2
            // 
            this.inMobStation2.Checked = true;
            this.inMobStation2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inMobStation2.Location = new System.Drawing.Point(9, 43);
            this.inMobStation2.Name = "inMobStation2";
            this.inMobStation2.Size = new System.Drawing.Size(166, 15);
            this.inMobStation2.TabIndex = 1;
            this.inMobStation2.Text = "Yet other terrestrial stations";
            this.inMobStation2.CheckedChanged += new System.EventHandler(this.inMobStation2_CheckedChanged);
            // 
            // inMobStation
            // 
            this.inMobStation.Checked = true;
            this.inMobStation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inMobStation.Location = new System.Drawing.Point(9, 21);
            this.inMobStation.Name = "inMobStation";
            this.inMobStation.Size = new System.Drawing.Size(149, 15);
            this.inMobStation.TabIndex = 0;
            this.inMobStation.Text = "Other terrestrial stations";
            this.inMobStation.CheckedChanged += new System.EventHandler(this.inMobStation_CheckedChanged);
            // 
            // EouseFilter
            // 
            this.EouseFilter.Controls.Add(this.EouseBox);
            this.EouseFilter.Controls.Add(this.EouseEnd);
            this.EouseFilter.Controls.Add(this.and2);
            this.EouseFilter.Controls.Add(this.EouseStart);
            this.EouseFilter.Location = new System.Drawing.Point(506, 93);
            this.EouseFilter.Name = "EouseFilter";
            this.EouseFilter.Size = new System.Drawing.Size(286, 47);
            this.EouseFilter.TabIndex = 10;
            this.EouseFilter.TabStop = false;
            this.EouseFilter.Text = "End of use between";
            // 
            // EouseBox
            // 
            this.EouseBox.Location = new System.Drawing.Point(121, -2);
            this.EouseBox.Name = "EouseBox";
            this.EouseBox.Size = new System.Drawing.Size(16, 16);
            this.EouseBox.TabIndex = 13;
            this.EouseBox.CheckedChanged += new System.EventHandler(this.EouseBox_CheckedChanged);
            // 
            // EouseEnd
            // 
            this.EouseEnd.Location = new System.Drawing.Point(162, 17);
            this.EouseEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EouseEnd.Name = "EouseEnd";
            this.EouseEnd.Size = new System.Drawing.Size(98, 22);
            this.EouseEnd.TabIndex = 5;
            this.EouseEnd.Value = new System.DateTime(9999, 12, 31, 0, 0, 0, 0);
            this.EouseEnd.Visible = false;
            this.EouseEnd.ValueChanged += new System.EventHandler(this.BiuseStart_ValueChanged);
            // 
            // and2
            // 
            this.and2.AutoSize = true;
            this.and2.BackColor = System.Drawing.Color.Transparent;
            this.and2.Location = new System.Drawing.Point(123, 17);
            this.and2.Name = "and2";
            this.and2.Size = new System.Drawing.Size(31, 19);
            this.and2.TabIndex = 4;
            this.and2.Text = "and";
            this.and2.Visible = false;
            // 
            // EouseStart
            // 
            this.EouseStart.Location = new System.Drawing.Point(20, 18);
            this.EouseStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EouseStart.Name = "EouseStart";
            this.EouseStart.Size = new System.Drawing.Size(98, 22);
            this.EouseStart.TabIndex = 3;
            this.EouseStart.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.EouseStart.Visible = false;
            this.EouseStart.ValueChanged += new System.EventHandler(this.BiuseStart_ValueChanged);
            // 
            // BiuseFilter
            // 
            this.BiuseFilter.Controls.Add(this.BiuseBox);
            this.BiuseFilter.Controls.Add(this.BiuseEnd);
            this.BiuseFilter.Controls.Add(this.and1);
            this.BiuseFilter.Controls.Add(this.BiuseStart);
            this.BiuseFilter.Location = new System.Drawing.Point(506, 6);
            this.BiuseFilter.Name = "BiuseFilter";
            this.BiuseFilter.Size = new System.Drawing.Size(286, 47);
            this.BiuseFilter.TabIndex = 9;
            this.BiuseFilter.TabStop = false;
            this.BiuseFilter.Text = "Bring in use between";
            // 
            // BiuseBox
            // 
            this.BiuseBox.Location = new System.Drawing.Point(121, 0);
            this.BiuseBox.Name = "BiuseBox";
            this.BiuseBox.Size = new System.Drawing.Size(16, 16);
            this.BiuseBox.TabIndex = 13;
            this.BiuseBox.CheckedChanged += new System.EventHandler(this.BiuseBox_CheckedChanged);
            // 
            // BiuseEnd
            // 
            this.BiuseEnd.Location = new System.Drawing.Point(162, 18);
            this.BiuseEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BiuseEnd.Name = "BiuseEnd";
            this.BiuseEnd.Size = new System.Drawing.Size(98, 22);
            this.BiuseEnd.TabIndex = 2;
            this.BiuseEnd.Value = new System.DateTime(9999, 12, 31, 0, 0, 0, 0);
            this.BiuseEnd.Visible = false;
            this.BiuseEnd.ValueChanged += new System.EventHandler(this.BiuseStart_ValueChanged);
            // 
            // and1
            // 
            this.and1.AutoSize = true;
            this.and1.BackColor = System.Drawing.Color.Transparent;
            this.and1.Location = new System.Drawing.Point(123, 18);
            this.and1.Name = "and1";
            this.and1.Size = new System.Drawing.Size(31, 19);
            this.and1.TabIndex = 1;
            this.and1.Text = "and";
            this.and1.Visible = false;
            // 
            // BiuseStart
            // 
            this.BiuseStart.Location = new System.Drawing.Point(20, 20);
            this.BiuseStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BiuseStart.Name = "BiuseStart";
            this.BiuseStart.Size = new System.Drawing.Size(98, 22);
            this.BiuseStart.TabIndex = 0;
            this.BiuseStart.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.BiuseStart.Visible = false;
            this.BiuseStart.ValueChanged += new System.EventHandler(this.BiuseStart_ValueChanged);
            // 
            // toEWX
            // 
            this.toEWX.Enabled = false;
            this.toEWX.Location = new System.Drawing.Point(651, 310);
            this.toEWX.Name = "toEWX";
            this.toEWX.Size = new System.Drawing.Size(141, 23);
            this.toEWX.TabIndex = 8;
            this.toEWX.Text = "Export result as EWX file";
            this.toEWX.Click += new System.EventHandler(this.toEWX_Click);
            // 
            // RunSearch
            // 
            this.RunSearch.Location = new System.Drawing.Point(651, 254);
            this.RunSearch.Name = "RunSearch";
            this.RunSearch.Size = new System.Drawing.Size(141, 23);
            this.RunSearch.TabIndex = 7;
            this.RunSearch.Text = "Search";
            this.RunSearch.Click += new System.EventHandler(this.buildDatasets_Click);
            // 
            // tabWanted
            // 
            this.tabWanted.BackColor = System.Drawing.Color.Transparent;
            this.tabWanted.Controls.Add(this.DbListWanted);
            this.tabWanted.HorizontalScrollbarBarColor = true;
            this.tabWanted.Location = new System.Drawing.Point(4, 28);
            this.tabWanted.Name = "tabWanted";
            this.tabWanted.Padding = new System.Windows.Forms.Padding(3);
            this.tabWanted.Size = new System.Drawing.Size(792, 363);
            this.tabWanted.TabIndex = 3;
            this.tabWanted.Text = "wanted stations";
            this.tabWanted.VerticalScrollbarBarColor = true;
            // 
            // DbListWanted
            // 
            this.DbListWanted.BackColor = System.Drawing.SystemColors.Control;
            this.DbListWanted.ConfigName = "SI_wanted";
            this.DbListWanted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DbListWanted.Filter = "[ID]=-1";
            this.DbListWanted.Location = new System.Drawing.Point(3, 3);
            this.DbListWanted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DbListWanted.Name = "DbListWanted";
            this.DbListWanted.Param1 = 0;
            this.DbListWanted.Param2 = 0;
            this.DbListWanted.Size = new System.Drawing.Size(786, 357);
            this.DbListWanted.TabIndex = 3;
            this.DbListWanted.Table = null;
            this.DbListWanted.OnRequery += new System.EventHandler(this.DbListWanted_OnRequery);
            // 
            // tabUW_MobStation
            // 
            this.tabUW_MobStation.BackColor = System.Drawing.Color.Transparent;
            this.tabUW_MobStation.Controls.Add(this.DbListMobStation);
            this.tabUW_MobStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabUW_MobStation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabUW_MobStation.HorizontalScrollbarBarColor = true;
            this.tabUW_MobStation.Location = new System.Drawing.Point(4, 28);
            this.tabUW_MobStation.Name = "tabUW_MobStation";
            this.tabUW_MobStation.Padding = new System.Windows.Forms.Padding(3);
            this.tabUW_MobStation.Size = new System.Drawing.Size(792, 363);
            this.tabUW_MobStation.TabIndex = 0;
            this.tabUW_MobStation.Text = "Other Terrestrials Unwanted Stations";
            this.tabUW_MobStation.VerticalScrollbarBarColor = true;
            // 
            // DbListMobStation
            // 
            this.DbListMobStation.BackColor = System.Drawing.SystemColors.Control;
            this.DbListMobStation.ConfigName = "SI_UW_MS";
            this.DbListMobStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DbListMobStation.Filter = "[ID]=-1";
            this.DbListMobStation.Location = new System.Drawing.Point(3, 3);
            this.DbListMobStation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DbListMobStation.Name = "DbListMobStation";
            this.DbListMobStation.Param1 = 0;
            this.DbListMobStation.Param2 = 0;
            this.DbListMobStation.Size = new System.Drawing.Size(786, 357);
            this.DbListMobStation.TabIndex = 0;
            this.DbListMobStation.Table = "MOB_STATION";
            this.DbListMobStation.OnDefColumns += new System.EventHandler(this.DbListMobStation_OnDefColumns);
            this.DbListMobStation.OnRequery += new System.EventHandler(this.DbListMobStation_OnRequery);
            this.DbListMobStation.OnSelChanged += new System.EventHandler(this.DbListMobStation_OnSelChanged);
            // 
            // tabUW_MobStation2
            // 
            this.tabUW_MobStation2.Controls.Add(this.DbListMobStation2);
            this.tabUW_MobStation2.HorizontalScrollbarBarColor = true;
            this.tabUW_MobStation2.Location = new System.Drawing.Point(4, 28);
            this.tabUW_MobStation2.Name = "tabUW_MobStation2";
            this.tabUW_MobStation2.Padding = new System.Windows.Forms.Padding(3);
            this.tabUW_MobStation2.Size = new System.Drawing.Size(792, 363);
            this.tabUW_MobStation2.TabIndex = 5;
            this.tabUW_MobStation2.Text = "Yet Other Terrestrials Unwanted Stations";
            this.tabUW_MobStation2.VerticalScrollbarBarColor = true;
            // 
            // DbListMobStation2
            // 
            this.DbListMobStation2.BackColor = System.Drawing.SystemColors.Control;
            this.DbListMobStation2.ConfigName = "SI_UW_MS2";
            this.DbListMobStation2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DbListMobStation2.Filter = "[ID]=-1";
            this.DbListMobStation2.Location = new System.Drawing.Point(3, 3);
            this.DbListMobStation2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DbListMobStation2.Name = "DbListMobStation2";
            this.DbListMobStation2.Param1 = 0;
            this.DbListMobStation2.Param2 = 0;
            this.DbListMobStation2.Size = new System.Drawing.Size(786, 357);
            this.DbListMobStation2.TabIndex = 1;
            this.DbListMobStation2.Table = "MOB_STATION2";
            this.DbListMobStation2.OnRequery += new System.EventHandler(this.DbListMobStation2_OnRequery);
            // 
            // tabUW_Microwa
            // 
            this.tabUW_Microwa.Controls.Add(this.DbListMwa);
            this.tabUW_Microwa.HorizontalScrollbarBarColor = true;
            this.tabUW_Microwa.Location = new System.Drawing.Point(4, 28);
            this.tabUW_Microwa.Name = "tabUW_Microwa";
            this.tabUW_Microwa.Padding = new System.Windows.Forms.Padding(3);
            this.tabUW_Microwa.Size = new System.Drawing.Size(792, 363);
            this.tabUW_Microwa.TabIndex = 1;
            this.tabUW_Microwa.Text = "Unwanted Microwave Stations";
            this.tabUW_Microwa.VerticalScrollbarBarColor = true;
            // 
            // DbListMwa
            // 
            this.DbListMwa.BackColor = System.Drawing.SystemColors.Control;
            this.DbListMwa.ConfigName = "SI_UW_MW";
            this.DbListMwa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DbListMwa.Filter = "[ID]=-1";
            this.DbListMwa.Location = new System.Drawing.Point(3, 3);
            this.DbListMwa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DbListMwa.Name = "DbListMwa";
            this.DbListMwa.Param1 = 0;
            this.DbListMwa.Param2 = 0;
            this.DbListMwa.Size = new System.Drawing.Size(786, 357);
            this.DbListMwa.TabIndex = 1;
            this.DbListMwa.Table = "MICROWA";
            this.DbListMwa.OnRequery += new System.EventHandler(this.DbListMwa_OnRequery);
            // 
            // tabUW_Sfaf
            // 
            this.tabUW_Sfaf.Controls.Add(this.DbListSfaf);
            this.tabUW_Sfaf.HorizontalScrollbarBarColor = true;
            this.tabUW_Sfaf.Location = new System.Drawing.Point(4, 28);
            this.tabUW_Sfaf.Name = "tabUW_Sfaf";
            this.tabUW_Sfaf.Padding = new System.Windows.Forms.Padding(3);
            this.tabUW_Sfaf.Size = new System.Drawing.Size(792, 363);
            this.tabUW_Sfaf.TabIndex = 2;
            this.tabUW_Sfaf.Text = "Unwanted SFAF";
            this.tabUW_Sfaf.VerticalScrollbarBarColor = true;
            // 
            // DbListSfaf
            // 
            this.DbListSfaf.BackColor = System.Drawing.SystemColors.Control;
            this.DbListSfaf.ConfigName = "SI_UW_SFAF";
            this.DbListSfaf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DbListSfaf.Filter = "[ID]=-1";
            this.DbListSfaf.Location = new System.Drawing.Point(3, 3);
            this.DbListSfaf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DbListSfaf.Name = "DbListSfaf";
            this.DbListSfaf.Param1 = 0;
            this.DbListSfaf.Param2 = 0;
            this.DbListSfaf.Size = new System.Drawing.Size(786, 357);
            this.DbListSfaf.TabIndex = 1;
            this.DbListSfaf.Table = "SFAF";
            this.DbListSfaf.OnRequery += new System.EventHandler(this.DbListSfaf_OnRequery);
            // 
            // cancelThread
            // 
            this.cancelThread.Location = new System.Drawing.Point(561, 22);
            this.cancelThread.Name = "cancelThread";
            this.cancelThread.Size = new System.Drawing.Size(23, 23);
            this.cancelThread.TabIndex = 12;
            this.cancelThread.Text = "Annuler";
            this.cancelThread.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelThread.Visible = false;
            this.cancelThread.Click += new System.EventHandler(this.cancelThread_Click);
            // 
            // PendingSpinner
            // 
            this.PendingSpinner.BackColor = System.Drawing.Color.Transparent;
            this.PendingSpinner.Location = new System.Drawing.Point(590, 19);
            this.PendingSpinner.Maximum = 100;
            this.PendingSpinner.Name = "PendingSpinner";
            this.PendingSpinner.Size = new System.Drawing.Size(35, 35);
            this.PendingSpinner.Speed = 2F;
            this.PendingSpinner.Spinning = false;
            this.PendingSpinner.TabIndex = 11;
            this.PendingSpinner.Visible = false;
            // 
            // SearchInterf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 475);
            this.Controls.Add(this.cancelThread);
            this.Controls.Add(this.PendingSpinner);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold);
            this.Name = "SearchInterf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = "Orange";
            this.Text = "Search for potential inteferer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchInterf_FormClosed);
            this.Load += new System.EventHandler(this.DatasetBuilder_Load);
            this.geoParam.ResumeLayout(false);
            this.geoParam.PerformLayout();
            this.freqParams.ResumeLayout(false);
            this.freqParams.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabConfig.ResumeLayout(false);
            this.StatusFilters.ResumeLayout(false);
            this.StatusFilters.PerformLayout();
            this.panelSfaf.ResumeLayout(false);
            this.panelSfaf.PerformLayout();
            this.panelMicrowa.ResumeLayout(false);
            this.panelMicrowa.PerformLayout();
            this.panelMobStation2.ResumeLayout(false);
            this.panelMobStation2.PerformLayout();
            this.panelMobStation.ResumeLayout(false);
            this.panelMobStation.PerformLayout();
            this.DefaultKtbfArea.ResumeLayout(false);
            this.saveParam.ResumeLayout(false);
            this.Tables.ResumeLayout(false);
            this.EouseFilter.ResumeLayout(false);
            this.EouseFilter.PerformLayout();
            this.BiuseFilter.ResumeLayout(false);
            this.BiuseFilter.PerformLayout();
            this.tabWanted.ResumeLayout(false);
            this.tabUW_MobStation.ResumeLayout(false);
            this.tabUW_MobStation2.ResumeLayout(false);
            this.tabUW_Microwa.ResumeLayout(false);
            this.tabUW_Sfaf.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox geoParam;
        private IcsMetroRadioButton N0;
        private IcsMetroRadioButton N1;
        private IcsMetroRadioButton N2;
        private System.Windows.Forms.GroupBox freqParams;
        private IcsMetroRadioButton radioDistance;
        private IcsMetroRadioButton coverMode;
        private IcsMetroButton importOnMap;
        private IcsMetroTabControl tabControl1;
        private IcsMetroTabPage tabUW_Microwa;
        private IcsMetroTabPage tabUW_Sfaf;
        private IcsDBList DbListMobStation;
        private IcsDBList DbListMwa;
        private IcsDBList DbListSfaf;
        private IcsMetroTabPage tabWanted;
        
        private IcsMetroButton RunSearch;
        private IcsMetroButton toEWX;
        //private PLUG_GE06.PlanEntryPanel planEntryPanel1;
        private IcsDBList DbListWanted;
        private IcsMetroTabPage tabConfig;
        private System.Windows.Forms.GroupBox EouseFilter;
        private System.Windows.Forms.GroupBox BiuseFilter;
        private System.Windows.Forms.GroupBox Tables;
        private IcsMetroTabPage tabUW_MobStation2;
        private IcsDBList DbListMobStation2;
        private System.Windows.Forms.GroupBox saveParam;
        private IcsMetroTextBox SaveName;
        private IcsMetroLabel labelSave;
        private IcsMetroCheckBox SaveBox;
        private IcsDateTime EouseEnd;
        private IcsMetroLabel and2;
        private IcsDateTime EouseStart;
        private IcsDateTime BiuseEnd;
        private IcsMetroLabel and1;
        private IcsDateTime BiuseStart;
        private IcsMetroCheckBox inSfaf;
        private IcsMetroCheckBox inMicrowa;
        private IcsMetroCheckBox inMobStation2;
        private IcsMetroCheckBox inMobStation;
        private IcsMetroCheckBox EouseBox;
        private IcsMetroCheckBox BiuseBox;
        private System.Windows.Forms.GroupBox DefaultKtbfArea;
        private IcsDoublePowerMetro DefaultKtbf;
        private System.Windows.Forms.GroupBox StatusFilters;
        private IcsMetroPanel panelMicrowa;
        private IcsMetroLabel label6;
        private IcsStatus Microwa_Status;
        private IcsMetroPanel panelMobStation2;
        private IcsMetroLabel label5;
        private IcsStatus MobStation2_Status;
        private IcsMetroLabel label3;
        private IcsMetroLabel label2;
        private IcsMetroPanel panelMobStation;
        private IcsMetroLabel label4;
        private IcsStatus MobStation_Status;
        private IcsMetroPanel panelSfaf;
        private IcsMetroLabel label7;
        private IcsMetroTile CopyEtoB;
        private IcsMetroTile CopyBtoE;
        private System.Windows.Forms.CheckBox LikeSfafState;
        private System.Windows.Forms.CheckBox LikeMwStatus;
        private System.Windows.Forms.CheckBox LikeMwState;
        private System.Windows.Forms.CheckBox LikeMs2State;
        private System.Windows.Forms.CheckBox LikeMs2Status;
        private System.Windows.Forms.CheckBox LikeMsStatus;
        private System.Windows.Forms.CheckBox LikeMsState;
        private IcsMetroTabPage tabUW_MobStation;
        private IcsComboMetro MobStation2_State;
        private IcsComboMetro Microwa_State;
        private IcsComboMetro Sfaf_State;
        private IcsComboMetro MobStation_State;
        private IcsMetroTile cancelThread;
        private IcsMetroProgressSpinner PendingSpinner;
    }
}