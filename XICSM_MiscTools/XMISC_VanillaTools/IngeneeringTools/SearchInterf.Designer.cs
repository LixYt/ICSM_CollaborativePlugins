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
            this.ComputingHorizon = new FormsCs.IcsMetroRadioButton();
            this.ComputingFreeSpaceLoss = new FormsCs.IcsMetroRadioButton();
            this.importOnMap = new FormsCs.IcsMetroButton();
            this.SearchTabGrid = new FormsCs.IcsMetroTabControl();
            this.tabConfig = new FormsCs.IcsMetroTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OtherFilters = new System.Windows.Forms.GroupBox();
            this.label2 = new FormsCs.IcsMetroLabel();
            this.CopyEtoB = new FormsCs.IcsMetroTile();
            this.CopyBtoE = new FormsCs.IcsMetroTile();
            this.BiuseFilter = new System.Windows.Forms.GroupBox();
            this.BiuseBox = new FormsCs.IcsMetroCheckBox();
            this.BiuseEnd = new NetPlugins2.IcsDateTime();
            this.and1 = new FormsCs.IcsMetroLabel();
            this.BiuseStart = new NetPlugins2.IcsDateTime();
            this.EouseFilter = new System.Windows.Forms.GroupBox();
            this.EouseBox = new FormsCs.IcsMetroCheckBox();
            this.EouseEnd = new NetPlugins2.IcsDateTime();
            this.and2 = new FormsCs.IcsMetroLabel();
            this.EouseStart = new NetPlugins2.IcsDateTime();
            this.DefaultKtbfArea = new System.Windows.Forms.GroupBox();
            this.DefaultKtbf = new NetPlugins2.IcsDoublePowerMetro();
            this.saveParam = new System.Windows.Forms.GroupBox();
            this.SaveName = new FormsCs.IcsMetroTextBox();
            this.labelSave = new FormsCs.IcsMetroLabel();
            this.SaveBox = new FormsCs.IcsMetroCheckBox();
            this.toEWX = new FormsCs.IcsMetroButton();
            this.RunSearch = new FormsCs.IcsMetroButton();
            this.tabWanted = new FormsCs.IcsMetroTabPage();
            this.DbListWanted = new NetPlugins2.IcsDBList();
            this.tabExcludedWanted = new MetroFramework.Controls.MetroTabPage();
            this.DbListWantedExcluded = new NetPlugins2.IcsDBList();
            this.tabUnwantedTx = new MetroFramework.Controls.MetroTabPage();
            this.DbListTxUnwanted = new NetPlugins2.IcsDBList();
            this.tabUnwantedRx = new MetroFramework.Controls.MetroTabPage();
            this.DbListRxUnwanted = new NetPlugins2.IcsDBList();
            this.cancelThread = new FormsCs.IcsMetroTile();
            this.ProgressBarMain = new FormsCs.IcsMetroProgressBar();
            this.ProgressBarSub = new FormsCs.IcsMetroProgressBar();
            this.StateFamX_P = new System.Windows.Forms.CheckBox();
            this.StateFamX_U = new System.Windows.Forms.CheckBox();
            this.StateFamX_X = new System.Windows.Forms.CheckBox();
            this.StateFamX_Z = new System.Windows.Forms.CheckBox();
            this.geoParam.SuspendLayout();
            this.freqParams.SuspendLayout();
            this.SearchTabGrid.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.OtherFilters.SuspendLayout();
            this.BiuseFilter.SuspendLayout();
            this.EouseFilter.SuspendLayout();
            this.DefaultKtbfArea.SuspendLayout();
            this.saveParam.SuspendLayout();
            this.tabWanted.SuspendLayout();
            this.tabExcludedWanted.SuspendLayout();
            this.tabUnwantedTx.SuspendLayout();
            this.tabUnwantedRx.SuspendLayout();
            this.SuspendLayout();
            // 
            // geoParam
            // 
            this.geoParam.Controls.Add(this.N0);
            this.geoParam.Controls.Add(this.N1);
            this.geoParam.Controls.Add(this.N2);
            this.geoParam.Location = new System.Drawing.Point(187, 6);
            this.geoParam.Name = "geoParam";
            this.geoParam.Size = new System.Drawing.Size(447, 91);
            this.geoParam.TabIndex = 1;
            this.geoParam.TabStop = false;
            this.geoParam.Text = "Frequency limits";
            // 
            // N0
            // 
            this.N0.AutoSize = true;
            this.N0.Location = new System.Drawing.Point(7, 62);
            this.N0.Name = "N0";
            this.N0.Size = new System.Drawing.Size(233, 15);
            this.N0.TabIndex = 2;
            this.N0.Text = "Very tight mode (sharing same channel)";
            // 
            // N1
            // 
            this.N1.AutoSize = true;
            this.N1.Location = new System.Drawing.Point(7, 41);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(185, 15);
            this.N1.TabIndex = 1;
            this.N1.Text = "Tight mode (adjacent channel)";
            // 
            // N2
            // 
            this.N2.AutoSize = true;
            this.N2.Checked = true;
            this.N2.Location = new System.Drawing.Point(7, 20);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(245, 15);
            this.N2.TabIndex = 0;
            this.N2.TabStop = true;
            this.N2.Text = "Spurious Domain (in accordance with ITU)";
            this.N2.Click += new System.EventHandler(this.N2_Click);
            this.N2.MouseHover += new System.EventHandler(this.N2_MouseHover);
            // 
            // freqParams
            // 
            this.freqParams.Controls.Add(this.ComputingHorizon);
            this.freqParams.Controls.Add(this.ComputingFreeSpaceLoss);
            this.freqParams.Location = new System.Drawing.Point(8, 6);
            this.freqParams.Name = "freqParams";
            this.freqParams.Size = new System.Drawing.Size(173, 73);
            this.freqParams.TabIndex = 3;
            this.freqParams.TabStop = false;
            this.freqParams.Text = "Computing mode";
            // 
            // ComputingHorizon
            // 
            this.ComputingHorizon.AutoSize = true;
            this.ComputingHorizon.Checked = true;
            this.ComputingHorizon.Location = new System.Drawing.Point(6, 20);
            this.ComputingHorizon.Name = "ComputingHorizon";
            this.ComputingHorizon.Size = new System.Drawing.Size(120, 15);
            this.ComputingHorizon.TabIndex = 1;
            this.ComputingHorizon.TabStop = true;
            this.ComputingHorizon.Text = "radio horizon limit";
            // 
            // ComputingFreeSpaceLoss
            // 
            this.ComputingFreeSpaceLoss.AutoSize = true;
            this.ComputingFreeSpaceLoss.Location = new System.Drawing.Point(6, 47);
            this.ComputingFreeSpaceLoss.Name = "ComputingFreeSpaceLoss";
            this.ComputingFreeSpaceLoss.Size = new System.Drawing.Size(126, 15);
            this.ComputingFreeSpaceLoss.TabIndex = 0;
            this.ComputingFreeSpaceLoss.Text = "free space loss limit";
            // 
            // importOnMap
            // 
            this.importOnMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.importOnMap.Enabled = false;
            this.importOnMap.Location = new System.Drawing.Point(713, 321);
            this.importOnMap.Name = "importOnMap";
            this.importOnMap.Size = new System.Drawing.Size(232, 23);
            this.importOnMap.TabIndex = 4;
            this.importOnMap.Text = "Export to HTZ map";
            this.importOnMap.Click += new System.EventHandler(this.importOnMap_Click);
            // 
            // SearchTabGrid
            // 
            this.SearchTabGrid.Controls.Add(this.tabConfig);
            this.SearchTabGrid.Controls.Add(this.tabWanted);
            this.SearchTabGrid.Controls.Add(this.tabExcludedWanted);
            this.SearchTabGrid.Controls.Add(this.tabUnwantedTx);
            this.SearchTabGrid.Controls.Add(this.tabUnwantedRx);
            this.SearchTabGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchTabGrid.Location = new System.Drawing.Point(20, 60);
            this.SearchTabGrid.Name = "SearchTabGrid";
            this.SearchTabGrid.SelectedIndex = 0;
            this.SearchTabGrid.Size = new System.Drawing.Size(960, 410);
            this.SearchTabGrid.TabIndex = 5;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.groupBox1);
            this.tabConfig.Controls.Add(this.OtherFilters);
            this.tabConfig.Controls.Add(this.DefaultKtbfArea);
            this.tabConfig.Controls.Add(this.saveParam);
            this.tabConfig.Controls.Add(this.toEWX);
            this.tabConfig.Controls.Add(this.freqParams);
            this.tabConfig.Controls.Add(this.geoParam);
            this.tabConfig.Controls.Add(this.RunSearch);
            this.tabConfig.Controls.Add(this.importOnMap);
            this.tabConfig.HorizontalScrollbarBarColor = true;
            this.tabConfig.Location = new System.Drawing.Point(4, 28);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(952, 378);
            this.tabConfig.TabIndex = 4;
            this.tabConfig.Text = "Configuration";
            this.tabConfig.VerticalScrollbarBarColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StateFamX_X);
            this.groupBox1.Controls.Add(this.StateFamX_Z);
            this.groupBox1.Controls.Add(this.StateFamX_U);
            this.groupBox1.Controls.Add(this.StateFamX_P);
            this.groupBox1.Location = new System.Drawing.Point(8, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 145);
            this.groupBox1.TabIndex = 120;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exclude unwanted stations by Familly Status (checked = excluded)";
            this.groupBox1.Visible = false;
            // 
            // OtherFilters
            // 
            this.OtherFilters.Controls.Add(this.label2);
            this.OtherFilters.Controls.Add(this.CopyEtoB);
            this.OtherFilters.Controls.Add(this.CopyBtoE);
            this.OtherFilters.Controls.Add(this.BiuseFilter);
            this.OtherFilters.Controls.Add(this.EouseFilter);
            this.OtherFilters.Location = new System.Drawing.Point(640, 7);
            this.OtherFilters.Name = "OtherFilters";
            this.OtherFilters.Size = new System.Drawing.Size(305, 182);
            this.OtherFilters.TabIndex = 14;
            this.OtherFilters.TabStop = false;
            this.OtherFilters.Text = "Use date";
            this.OtherFilters.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 0);
            this.label2.TabIndex = 2;
            // 
            // CopyEtoB
            // 
            this.CopyEtoB.Location = new System.Drawing.Point(179, 84);
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
            this.CopyBtoE.Location = new System.Drawing.Point(109, 84);
            this.CopyBtoE.Margin = new System.Windows.Forms.Padding(0);
            this.CopyBtoE.Name = "CopyBtoE";
            this.CopyBtoE.Size = new System.Drawing.Size(26, 26);
            this.CopyBtoE.TabIndex = 15;
            this.CopyBtoE.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CopyBtoE.UseTileImage = true;
            this.CopyBtoE.Visible = false;
            this.CopyBtoE.Click += new System.EventHandler(this.CopyBtoE_Click);
            // 
            // BiuseFilter
            // 
            this.BiuseFilter.Controls.Add(this.BiuseBox);
            this.BiuseFilter.Controls.Add(this.BiuseEnd);
            this.BiuseFilter.Controls.Add(this.and1);
            this.BiuseFilter.Controls.Add(this.BiuseStart);
            this.BiuseFilter.Location = new System.Drawing.Point(17, 26);
            this.BiuseFilter.Name = "BiuseFilter";
            this.BiuseFilter.Size = new System.Drawing.Size(275, 47);
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
            // EouseFilter
            // 
            this.EouseFilter.Controls.Add(this.EouseBox);
            this.EouseFilter.Controls.Add(this.EouseEnd);
            this.EouseFilter.Controls.Add(this.and2);
            this.EouseFilter.Controls.Add(this.EouseStart);
            this.EouseFilter.Location = new System.Drawing.Point(17, 117);
            this.EouseFilter.Name = "EouseFilter";
            this.EouseFilter.Size = new System.Drawing.Size(275, 47);
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
            // DefaultKtbfArea
            // 
            this.DefaultKtbfArea.Controls.Add(this.DefaultKtbf);
            this.DefaultKtbfArea.Location = new System.Drawing.Point(8, 85);
            this.DefaultKtbfArea.Name = "DefaultKtbfArea";
            this.DefaultKtbfArea.Size = new System.Drawing.Size(173, 54);
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
            this.DefaultKtbf.Size = new System.Drawing.Size(149, 20);
            this.DefaultKtbf.Subtype = "dBm";
            this.DefaultKtbf.TabIndex = 0;
            // 
            // saveParam
            // 
            this.saveParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveParam.Controls.Add(this.SaveName);
            this.saveParam.Controls.Add(this.labelSave);
            this.saveParam.Controls.Add(this.SaveBox);
            this.saveParam.Location = new System.Drawing.Point(714, 195);
            this.saveParam.Name = "saveParam";
            this.saveParam.Size = new System.Drawing.Size(232, 85);
            this.saveParam.TabIndex = 12;
            this.saveParam.TabStop = false;
            this.saveParam.Text = "Save result bags";
            // 
            // SaveName
            // 
            this.SaveName.Location = new System.Drawing.Point(9, 45);
            this.SaveName.Name = "SaveName";
            this.SaveName.Size = new System.Drawing.Size(217, 20);
            this.SaveName.TabIndex = 2;
            this.SaveName.Visible = false;
            // 
            // labelSave
            // 
            this.labelSave.BackColor = System.Drawing.Color.Transparent;
            this.labelSave.FontSize = MetroFramework.Drawing.MetroFontSize.Small;
            this.labelSave.FontWeight = MetroFramework.Drawing.MetroFontWeight.Regular;
            this.labelSave.Location = new System.Drawing.Point(9, 24);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(116, 19);
            this.labelSave.TabIndex = 1;
            this.labelSave.Text = "Bag Name";
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
            // toEWX
            // 
            this.toEWX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toEWX.Enabled = false;
            this.toEWX.Location = new System.Drawing.Point(713, 349);
            this.toEWX.Name = "toEWX";
            this.toEWX.Size = new System.Drawing.Size(232, 23);
            this.toEWX.TabIndex = 8;
            this.toEWX.Text = "Export result as EWX file";
            this.toEWX.Click += new System.EventHandler(this.toEWX_Click);
            // 
            // RunSearch
            // 
            this.RunSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RunSearch.Location = new System.Drawing.Point(713, 293);
            this.RunSearch.Name = "RunSearch";
            this.RunSearch.Size = new System.Drawing.Size(232, 23);
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
            this.tabWanted.Size = new System.Drawing.Size(952, 378);
            this.tabWanted.TabIndex = 3;
            this.tabWanted.Text = "wanted stations";
            this.tabWanted.VerticalScrollbarBarColor = true;
            // 
            // DbListWanted
            // 
            this.DbListWanted.BackColor = System.Drawing.SystemColors.Control;
            this.DbListWanted.ConfigName = "spi_wanted";
            this.DbListWanted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DbListWanted.Filter = "[ALLSTA_ID]=0";
            this.DbListWanted.Location = new System.Drawing.Point(3, 3);
            this.DbListWanted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DbListWanted.Name = "DbListWanted";
            this.DbListWanted.Param1 = 0;
            this.DbListWanted.Param2 = 0;
            this.DbListWanted.Size = new System.Drawing.Size(946, 372);
            this.DbListWanted.TabIndex = 3;
            this.DbListWanted.Table = "ALL_TXRX_FREQ";
            this.DbListWanted.OnRequery += new System.EventHandler(this.DbListWanted_OnRequery);
            // 
            // tabExcludedWanted
            // 
            this.tabExcludedWanted.Controls.Add(this.DbListWantedExcluded);
            this.tabExcludedWanted.HorizontalScrollbarBarColor = true;
            this.tabExcludedWanted.Location = new System.Drawing.Point(4, 28);
            this.tabExcludedWanted.Name = "tabExcludedWanted";
            this.tabExcludedWanted.Padding = new System.Windows.Forms.Padding(2);
            this.tabExcludedWanted.Size = new System.Drawing.Size(952, 378);
            this.tabExcludedWanted.TabIndex = 8;
            this.tabExcludedWanted.Text = "Excluded or failed wanted stations";
            this.tabExcludedWanted.VerticalScrollbarBarColor = true;
            // 
            // DbListWantedExcluded
            // 
            this.DbListWantedExcluded.BackColor = System.Drawing.SystemColors.Control;
            this.DbListWantedExcluded.ConfigName = "spi_ExcludedWanted";
            this.DbListWantedExcluded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DbListWantedExcluded.Filter = "[ALLSTA_ID]=0";
            this.DbListWantedExcluded.Location = new System.Drawing.Point(2, 2);
            this.DbListWantedExcluded.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DbListWantedExcluded.Name = "DbListWantedExcluded";
            this.DbListWantedExcluded.Param1 = 0;
            this.DbListWantedExcluded.Param2 = 0;
            this.DbListWantedExcluded.Size = new System.Drawing.Size(948, 374);
            this.DbListWantedExcluded.TabIndex = 5;
            this.DbListWantedExcluded.Table = "ALL_TXRX_FREQ";
            this.DbListWantedExcluded.OnRequery += new System.EventHandler(this.DbListWantedExcluded_OnRequery);
            // 
            // tabUnwantedTx
            // 
            this.tabUnwantedTx.Controls.Add(this.DbListTxUnwanted);
            this.tabUnwantedTx.HorizontalScrollbarBarColor = true;
            this.tabUnwantedTx.Location = new System.Drawing.Point(4, 28);
            this.tabUnwantedTx.Name = "tabUnwantedTx";
            this.tabUnwantedTx.Padding = new System.Windows.Forms.Padding(2);
            this.tabUnwantedTx.Size = new System.Drawing.Size(952, 378);
            this.tabUnwantedTx.TabIndex = 7;
            this.tabUnwantedTx.Text = "Unwanted Tx station / Wanted Rx";
            this.tabUnwantedTx.VerticalScrollbarBarColor = true;
            // 
            // DbListTxUnwanted
            // 
            this.DbListTxUnwanted.BackColor = System.Drawing.SystemColors.Control;
            this.DbListTxUnwanted.ConfigName = "spi_UnwantedTx";
            this.DbListTxUnwanted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DbListTxUnwanted.Filter = "[ALLSTA_ID]=0";
            this.DbListTxUnwanted.Location = new System.Drawing.Point(2, 2);
            this.DbListTxUnwanted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DbListTxUnwanted.Name = "DbListTxUnwanted";
            this.DbListTxUnwanted.Param1 = 0;
            this.DbListTxUnwanted.Param2 = 0;
            this.DbListTxUnwanted.Size = new System.Drawing.Size(948, 374);
            this.DbListTxUnwanted.TabIndex = 5;
            this.DbListTxUnwanted.Table = "ALL_TXRX_FREQ";
            this.DbListTxUnwanted.OnRequery += new System.EventHandler(this.DbListTxUnwanted_OnRequery);
            // 
            // tabUnwantedRx
            // 
            this.tabUnwantedRx.Controls.Add(this.DbListRxUnwanted);
            this.tabUnwantedRx.HorizontalScrollbarBarColor = true;
            this.tabUnwantedRx.Location = new System.Drawing.Point(4, 28);
            this.tabUnwantedRx.Name = "tabUnwantedRx";
            this.tabUnwantedRx.Padding = new System.Windows.Forms.Padding(2);
            this.tabUnwantedRx.Size = new System.Drawing.Size(952, 378);
            this.tabUnwantedRx.TabIndex = 6;
            this.tabUnwantedRx.Text = "Unwanted Rx Station / Wanted Tx";
            this.tabUnwantedRx.VerticalScrollbarBarColor = true;
            // 
            // DbListRxUnwanted
            // 
            this.DbListRxUnwanted.BackColor = System.Drawing.SystemColors.Control;
            this.DbListRxUnwanted.ConfigName = "spi_UnwantedRx";
            this.DbListRxUnwanted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DbListRxUnwanted.Filter = "[ALLSTA_ID]=0";
            this.DbListRxUnwanted.Location = new System.Drawing.Point(2, 2);
            this.DbListRxUnwanted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DbListRxUnwanted.Name = "DbListRxUnwanted";
            this.DbListRxUnwanted.Param1 = 0;
            this.DbListRxUnwanted.Param2 = 0;
            this.DbListRxUnwanted.Size = new System.Drawing.Size(948, 374);
            this.DbListRxUnwanted.TabIndex = 4;
            this.DbListRxUnwanted.Table = "ALL_TXRX_FREQ";
            this.DbListRxUnwanted.OnRequery += new System.EventHandler(this.DbListRxUnwanted_OnRequery);
            // 
            // cancelThread
            // 
            this.cancelThread.Location = new System.Drawing.Point(754, 35);
            this.cancelThread.Name = "cancelThread";
            this.cancelThread.Size = new System.Drawing.Size(80, 23);
            this.cancelThread.TabIndex = 12;
            this.cancelThread.Text = "Annuler";
            this.cancelThread.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelThread.Visible = false;
            this.cancelThread.Click += new System.EventHandler(this.cancelThread_Click);
            // 
            // ProgressBarMain
            // 
            this.ProgressBarMain.HideProgressText = false;
            this.ProgressBarMain.Location = new System.Drawing.Point(485, 8);
            this.ProgressBarMain.MarqueeAnimating = true;
            this.ProgressBarMain.Name = "ProgressBarMain";
            this.ProgressBarMain.Size = new System.Drawing.Size(263, 23);
            this.ProgressBarMain.TabIndex = 13;
            // 
            // ProgressBarSub
            // 
            this.ProgressBarSub.HideProgressText = false;
            this.ProgressBarSub.Location = new System.Drawing.Point(485, 35);
            this.ProgressBarSub.MarqueeAnimating = true;
            this.ProgressBarSub.Name = "ProgressBarSub";
            this.ProgressBarSub.Size = new System.Drawing.Size(263, 23);
            this.ProgressBarSub.TabIndex = 14;
            // 
            // StateFamX_P
            // 
            this.StateFamX_P.AutoSize = true;
            this.StateFamX_P.Location = new System.Drawing.Point(10, 49);
            this.StateFamX_P.Name = "StateFamX_P";
            this.StateFamX_P.Size = new System.Drawing.Size(81, 17);
            this.StateFamX_P.TabIndex = 0;
            this.StateFamX_P.Text = "P - Planned";
            this.StateFamX_P.UseVisualStyleBackColor = true;
            // 
            // StateFamX_U
            // 
            this.StateFamX_U.AutoSize = true;
            this.StateFamX_U.Location = new System.Drawing.Point(10, 72);
            this.StateFamX_U.Name = "StateFamX_U";
            this.StateFamX_U.Size = new System.Drawing.Size(73, 17);
            this.StateFamX_U.TabIndex = 1;
            this.StateFamX_U.Text = "U - in Use";
            this.StateFamX_U.UseVisualStyleBackColor = true;
            // 
            // StateFamX_X
            // 
            this.StateFamX_X.AutoSize = true;
            this.StateFamX_X.Location = new System.Drawing.Point(10, 118);
            this.StateFamX_X.Name = "StateFamX_X";
            this.StateFamX_X.Size = new System.Drawing.Size(86, 17);
            this.StateFamX_X.TabIndex = 3;
            this.StateFamX_X.Text = "X - unknown";
            this.StateFamX_X.UseVisualStyleBackColor = true;
            // 
            // StateFamX_Z
            // 
            this.StateFamX_Z.AutoSize = true;
            this.StateFamX_Z.Location = new System.Drawing.Point(10, 95);
            this.StateFamX_Z.Name = "StateFamX_Z";
            this.StateFamX_Z.Size = new System.Drawing.Size(96, 17);
            this.StateFamX_Z.TabIndex = 2;
            this.StateFamX_Z.Text = "Z - suppressed";
            this.StateFamX_Z.UseVisualStyleBackColor = true;
            // 
            // SearchInterf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 490);
            this.Controls.Add(this.ProgressBarSub);
            this.Controls.Add(this.ProgressBarMain);
            this.Controls.Add(this.cancelThread);
            this.Controls.Add(this.SearchTabGrid);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold);
            this.MinimumSize = new System.Drawing.Size(1000, 490);
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
            this.SearchTabGrid.ResumeLayout(false);
            this.tabConfig.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.OtherFilters.ResumeLayout(false);
            this.OtherFilters.PerformLayout();
            this.BiuseFilter.ResumeLayout(false);
            this.BiuseFilter.PerformLayout();
            this.EouseFilter.ResumeLayout(false);
            this.EouseFilter.PerformLayout();
            this.DefaultKtbfArea.ResumeLayout(false);
            this.saveParam.ResumeLayout(false);
            this.tabWanted.ResumeLayout(false);
            this.tabExcludedWanted.ResumeLayout(false);
            this.tabUnwantedTx.ResumeLayout(false);
            this.tabUnwantedRx.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox geoParam;
        private IcsMetroRadioButton N0;
        private IcsMetroRadioButton N1;
        private IcsMetroRadioButton N2;
        private System.Windows.Forms.GroupBox freqParams;
        private IcsMetroRadioButton ComputingHorizon;
        private IcsMetroRadioButton ComputingFreeSpaceLoss;
        private IcsMetroButton importOnMap;
        private IcsMetroTabControl SearchTabGrid;
        private IcsMetroTabPage tabWanted;
        
        private IcsMetroButton RunSearch;
        private IcsMetroButton toEWX;
        //private PLUG_GE06.PlanEntryPanel planEntryPanel1;
        private IcsDBList DbListWanted;
        private IcsMetroTabPage tabConfig;
        private System.Windows.Forms.GroupBox EouseFilter;
        private System.Windows.Forms.GroupBox BiuseFilter;
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
        private IcsMetroCheckBox EouseBox;
        private IcsMetroCheckBox BiuseBox;
        private System.Windows.Forms.GroupBox DefaultKtbfArea;
        private IcsDoublePowerMetro DefaultKtbf;
        private System.Windows.Forms.GroupBox OtherFilters;
        private IcsMetroLabel label2;
        private IcsMetroTile CopyEtoB;
        private IcsMetroTile CopyBtoE;
        private IcsMetroTile cancelThread;
        private MetroFramework.Controls.MetroTabPage tabUnwantedRx;
        private IcsDBList DbListRxUnwanted;
        private MetroFramework.Controls.MetroTabPage tabUnwantedTx;
        private IcsDBList DbListTxUnwanted;
        private MetroFramework.Controls.MetroTabPage tabExcludedWanted;
        private IcsDBList DbListWantedExcluded;
        private System.Windows.Forms.GroupBox groupBox1;
        private IcsMetroProgressBar ProgressBarMain;
        private IcsMetroProgressBar ProgressBarSub;
        private System.Windows.Forms.CheckBox StateFamX_X;
        private System.Windows.Forms.CheckBox StateFamX_Z;
        private System.Windows.Forms.CheckBox StateFamX_U;
        private System.Windows.Forms.CheckBox StateFamX_P;
    }
}