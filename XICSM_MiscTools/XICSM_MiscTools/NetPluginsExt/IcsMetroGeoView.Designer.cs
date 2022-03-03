using FormsCs;
using NetPlugins2;

namespace NetPlugins2Ext
{
    partial class IcsMetroGeoView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Map = new NetPlugins2Ext.IcsOpenlayers3();
            this.SelectPanel = new FormsCs.IcsMetroPanel();
            this.ForceRefresh = new FormsCs.IcsMetroButton();
            this.QueryPosition = new FormsCs.IcsMetroComboBox();
            this.ToMap = new FormsCs.IcsMetroButton();
            this.QuerySelectorMode = new FormsCs.IcsMetroComboBox();
            this.ClearMap = new FormsCs.IcsMetroButton();
            this.ClearOrAdd = new FormsCs.IcsMetroToggle();
            this.All_Sites = new FormsCs.IcsMetroButton();
            this.QueryTab = new FormsCs.IcsMetroTabControl();
            this.QueryPageSites = new MetroFramework.Controls.MetroTabPage();
            this.DbListSites = new NetPlugins2.IcsDBList();
            this.QueryPageStations = new MetroFramework.Controls.MetroTabPage();
            this.DbListStations = new NetPlugins2.IcsDBList();
            this.QueryPageLinks = new MetroFramework.Controls.MetroTabPage();
            this.DbListLinks = new NetPlugins2.IcsDBList();
            this.Links = new FormsCs.IcsMetroButton();
            this.AllStations = new FormsCs.IcsMetroButton();
            this.SelectPanel.SuspendLayout();
            this.QueryTab.SuspendLayout();
            this.QueryPageSites.SuspendLayout();
            this.QueryPageStations.SuspendLayout();
            this.QueryPageLinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // Map
            // 
            this.Map.DisplayCsys = null;
            this.Map.InputGeomPoints = null;
            this.Map.InputGeomRadiusM = 0D;
            this.Map.InputMode = null;
            this.Map.InputType = null;
            this.Map.KmlsMaxCached = 20;
            this.Map.Location = new System.Drawing.Point(22, 91);
            this.Map.Margin = new System.Windows.Forms.Padding(2);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(353, 284);
            this.Map.StartLati = 48.53D;
            this.Map.StartLongi = 2.25D;
            this.Map.StartZoom = 5;
            this.Map.TabIndex = 1;
            this.Map.OnMapClicked += new System.EventHandler<NetPlugins2Ext.MapClickedEventArgs>(this.Map_OnMapClicked);
            // 
            // SelectPanel
            // 
            this.SelectPanel.Controls.Add(this.ForceRefresh);
            this.SelectPanel.Controls.Add(this.QueryPosition);
            this.SelectPanel.Controls.Add(this.ToMap);
            this.SelectPanel.Controls.Add(this.QuerySelectorMode);
            this.SelectPanel.Controls.Add(this.ClearMap);
            this.SelectPanel.Controls.Add(this.ClearOrAdd);
            this.SelectPanel.Controls.Add(this.Links);
            this.SelectPanel.Controls.Add(this.AllStations);
            this.SelectPanel.Controls.Add(this.All_Sites);
            this.SelectPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectPanel.HorizontalScrollbarBarColor = true;
            this.SelectPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.SelectPanel.HorizontalScrollbarSize = 10;
            this.SelectPanel.Location = new System.Drawing.Point(0, 0);
            this.SelectPanel.Name = "SelectPanel";
            this.SelectPanel.Size = new System.Drawing.Size(800, 64);
            this.SelectPanel.TabIndex = 0;
            this.SelectPanel.VerticalScrollbarBarColor = true;
            this.SelectPanel.VerticalScrollbarHighlightOnWheel = false;
            this.SelectPanel.VerticalScrollbarSize = 10;
            // 
            // ForceRefresh
            // 
            this.ForceRefresh.Location = new System.Drawing.Point(336, 38);
            this.ForceRefresh.Name = "ForceRefresh";
            this.ForceRefresh.Size = new System.Drawing.Size(179, 23);
            this.ForceRefresh.TabIndex = 10;
            this.ForceRefresh.Text = "Update map data";
            this.ForceRefresh.Click += new System.EventHandler(this.ForceRefresh_Click);
            // 
            // QueryPosition
            // 
            this.QueryPosition.FormattingEnabled = true;
            this.QueryPosition.ItemHeight = 23;
            this.QueryPosition.Items.AddRange(new object[] {
            "Top",
            "Right",
            "Bottom",
            "Left"});
            this.QueryPosition.Location = new System.Drawing.Point(222, 3);
            this.QueryPosition.MenuItemColor = System.Drawing.SystemColors.Control;
            this.QueryPosition.Name = "QueryPosition";
            this.QueryPosition.Size = new System.Drawing.Size(103, 29);
            this.QueryPosition.TabIndex = 9;
            this.QueryPosition.SelectedIndexChanged += new System.EventHandler(this.QueryPosition_SelectedIndexChanged);
            // 
            // ToMap
            // 
            this.ToMap.Location = new System.Drawing.Point(524, 38);
            this.ToMap.Name = "ToMap";
            this.ToMap.Size = new System.Drawing.Size(179, 23);
            this.ToMap.TabIndex = 8;
            this.ToMap.Text = "Export to ICS Telecom Map";
            this.ToMap.Click += new System.EventHandler(this.ToMap_Click);
            // 
            // QuerySelectorMode
            // 
            this.QuerySelectorMode.FormattingEnabled = true;
            this.QuerySelectorMode.ItemHeight = 23;
            this.QuerySelectorMode.Items.AddRange(new object[] {
            "Select items by query windows",
            "Select items by query side panel"});
            this.QuerySelectorMode.Location = new System.Drawing.Point(3, 3);
            this.QuerySelectorMode.MenuItemColor = System.Drawing.SystemColors.Control;
            this.QuerySelectorMode.Name = "QuerySelectorMode";
            this.QuerySelectorMode.Size = new System.Drawing.Size(213, 29);
            this.QuerySelectorMode.TabIndex = 7;
            this.QuerySelectorMode.SelectedIndexChanged += new System.EventHandler(this.QuerySelectorMode_SelectedIndexChanged);
            // 
            // ClearMap
            // 
            this.ClearMap.Location = new System.Drawing.Point(591, 7);
            this.ClearMap.Name = "ClearMap";
            this.ClearMap.Size = new System.Drawing.Size(112, 23);
            this.ClearMap.TabIndex = 6;
            this.ClearMap.Text = "Clear Map";
            this.ClearMap.Click += new System.EventHandler(this.ClearMap_Click);
            // 
            // ClearOrAdd
            // 
            this.ClearOrAdd.AutoSize = true;
            this.ClearOrAdd.Checked = true;
            this.ClearOrAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ClearOrAdd.ColorChecked = System.Drawing.Color.Lime;
            this.ClearOrAdd.ColorUnchecked = System.Drawing.Color.Red;
            this.ClearOrAdd.LabelCheked = "Clear map when loading new data";
            this.ClearOrAdd.LabelPosition = System.Windows.Forms.DockStyle.Right;
            this.ClearOrAdd.LabelUnchecked = "Add station to current map";
            this.ClearOrAdd.LabelWidth = 190;
            this.ClearOrAdd.Location = new System.Drawing.Point(336, 9);
            this.ClearOrAdd.Name = "ClearOrAdd";
            this.ClearOrAdd.Size = new System.Drawing.Size(240, 17);
            this.ClearOrAdd.TabIndex = 5;
            this.ClearOrAdd.Text = "Clear map when loading new data";
            this.ClearOrAdd.UseCustomColors = false;
            // 
            // All_Sites
            // 
            this.All_Sites.Location = new System.Drawing.Point(3, 38);
            this.All_Sites.Name = "All_Sites";
            this.All_Sites.Size = new System.Drawing.Size(103, 23);
            this.All_Sites.TabIndex = 2;
            this.All_Sites.Text = "Display sites";
            this.All_Sites.Click += new System.EventHandler(this.All_Sites_Click);
            // 
            // QueryTab
            // 
            this.QueryTab.Controls.Add(this.QueryPageSites);
            this.QueryTab.Controls.Add(this.QueryPageStations);
            this.QueryTab.Controls.Add(this.QueryPageLinks);
            this.QueryTab.Location = new System.Drawing.Point(380, 91);
            this.QueryTab.Name = "QueryTab";
            this.QueryTab.SelectedIndex = 0;
            this.QueryTab.Size = new System.Drawing.Size(382, 350);
            this.QueryTab.TabIndex = 2;
            this.QueryTab.Visible = false;
            // 
            // QueryPageSites
            // 
            this.QueryPageSites.Controls.Add(this.DbListSites);
            this.QueryPageSites.HorizontalScrollbarBarColor = true;
            this.QueryPageSites.Location = new System.Drawing.Point(4, 28);
            this.QueryPageSites.Name = "QueryPageSites";
            this.QueryPageSites.Padding = new System.Windows.Forms.Padding(3);
            this.QueryPageSites.Size = new System.Drawing.Size(374, 318);
            this.QueryPageSites.TabIndex = 0;
            this.QueryPageSites.Text = "Sites";
            this.QueryPageSites.VerticalScrollbarBarColor = true;
            // 
            // DbListSites
            // 
            this.DbListSites.BackColor = System.Drawing.SystemColors.Control;
            this.DbListSites.ConfigName = null;
            this.DbListSites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DbListSites.Filter = null;
            this.DbListSites.Location = new System.Drawing.Point(3, 3);
            this.DbListSites.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DbListSites.Name = "DbListSites";
            this.DbListSites.Param1 = 0;
            this.DbListSites.Param2 = 0;
            this.DbListSites.Size = new System.Drawing.Size(368, 312);
            this.DbListSites.TabIndex = 2;
            this.DbListSites.Table = null;
            this.DbListSites.OnDefColumns += new System.EventHandler(this.DBList_OnDefColumns);
            this.DbListSites.OnRequery += new System.EventHandler(this.DBList_OnRequery);
            // 
            // QueryPageStations
            // 
            this.QueryPageStations.Controls.Add(this.DbListStations);
            this.QueryPageStations.HorizontalScrollbarBarColor = true;
            this.QueryPageStations.Location = new System.Drawing.Point(4, 28);
            this.QueryPageStations.Name = "QueryPageStations";
            this.QueryPageStations.Padding = new System.Windows.Forms.Padding(3);
            this.QueryPageStations.Size = new System.Drawing.Size(374, 318);
            this.QueryPageStations.TabIndex = 1;
            this.QueryPageStations.Text = "Stations";
            this.QueryPageStations.VerticalScrollbarBarColor = true;
            // 
            // DbListStations
            // 
            this.DbListStations.BackColor = System.Drawing.SystemColors.Control;
            this.DbListStations.ConfigName = null;
            this.DbListStations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DbListStations.Filter = null;
            this.DbListStations.Location = new System.Drawing.Point(3, 3);
            this.DbListStations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DbListStations.Name = "DbListStations";
            this.DbListStations.Param1 = 0;
            this.DbListStations.Param2 = 0;
            this.DbListStations.Size = new System.Drawing.Size(368, 312);
            this.DbListStations.TabIndex = 2;
            this.DbListStations.Table = null;
            this.DbListStations.OnDefColumns += new System.EventHandler(this.DBList_OnDefColumns);
            this.DbListStations.OnRequery += new System.EventHandler(this.DBList_OnRequery);
            // 
            // QueryPageLinks
            // 
            this.QueryPageLinks.Controls.Add(this.DbListLinks);
            this.QueryPageLinks.HorizontalScrollbarBarColor = true;
            this.QueryPageLinks.Location = new System.Drawing.Point(4, 28);
            this.QueryPageLinks.Name = "QueryPageLinks";
            this.QueryPageLinks.Padding = new System.Windows.Forms.Padding(3);
            this.QueryPageLinks.Size = new System.Drawing.Size(374, 318);
            this.QueryPageLinks.TabIndex = 2;
            this.QueryPageLinks.Text = "Microwave Links";
            this.QueryPageLinks.VerticalScrollbarBarColor = true;
            // 
            // DbListLinks
            // 
            this.DbListLinks.BackColor = System.Drawing.SystemColors.Control;
            this.DbListLinks.ConfigName = null;
            this.DbListLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DbListLinks.Filter = null;
            this.DbListLinks.Location = new System.Drawing.Point(3, 3);
            this.DbListLinks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DbListLinks.Name = "DbListLinks";
            this.DbListLinks.Padding = new System.Windows.Forms.Padding(3);
            this.DbListLinks.Param1 = 0;
            this.DbListLinks.Param2 = 0;
            this.DbListLinks.Size = new System.Drawing.Size(368, 312);
            this.DbListLinks.TabIndex = 2;
            this.DbListLinks.Table = null;
            this.DbListLinks.OnDefColumns += new System.EventHandler(this.DBList_OnDefColumns);
            this.DbListLinks.OnRequery += new System.EventHandler(this.DBList_OnRequery);
            // 
            // Links
            // 
            this.Links.Location = new System.Drawing.Point(222, 38);
            this.Links.Name = "Links";
            this.Links.Size = new System.Drawing.Size(103, 23);
            this.Links.TabIndex = 4;
            this.Links.Text = "Display Links";
            this.Links.Click += new System.EventHandler(this.Links_Click);
            // 
            // AllStations
            // 
            this.AllStations.Location = new System.Drawing.Point(113, 38);
            this.AllStations.Name = "AllStations";
            this.AllStations.Size = new System.Drawing.Size(103, 23);
            this.AllStations.TabIndex = 3;
            this.AllStations.Text = "Display stations";
            this.AllStations.Click += new System.EventHandler(this.AllStations_Click);
            // 
            // IcsMetroGeoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.Controls.Add(this.QueryTab);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.SelectPanel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "IcsMetroGeoView";
            this.Size = new System.Drawing.Size(800, 500);
            this.Style = "Purple";
            this.Load += new System.EventHandler(this.IcsMetroGeoView_Load);
            this.Resize += new System.EventHandler(this.IcsMetroGeoView_Resize);
            this.SelectPanel.ResumeLayout(false);
            this.SelectPanel.PerformLayout();
            this.QueryTab.ResumeLayout(false);
            this.QueryPageSites.ResumeLayout(false);
            this.QueryPageStations.ResumeLayout(false);
            this.QueryPageLinks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private IcsMetroPanel SelectPanel;
        private IcsOpenlayers3 Map;
        private IcsMetroButton All_Sites;
        private IcsMetroToggle ClearOrAdd;
        private IcsMetroButton ClearMap;
        private IcsMetroComboBox QuerySelectorMode;
        private IcsMetroButton ToMap;
        private IcsMetroTabControl QueryTab;
        private MetroFramework.Controls.MetroTabPage QueryPageSites;
        private IcsDBList DbListSites;
        private MetroFramework.Controls.MetroTabPage QueryPageStations;
        private IcsDBList DbListStations;
        private MetroFramework.Controls.MetroTabPage QueryPageLinks;
        private IcsDBList DbListLinks;
        private IcsMetroComboBox QueryPosition;
        private IcsMetroButton ForceRefresh;
        private IcsMetroButton Links;
        private IcsMetroButton AllStations;
    }
}
