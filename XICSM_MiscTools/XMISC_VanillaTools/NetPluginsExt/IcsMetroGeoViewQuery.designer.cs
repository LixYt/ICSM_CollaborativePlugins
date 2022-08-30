using FormsCs;
using NetPlugins2;

namespace NetPlugins2Ext
{
    partial class IcsMetroGeoViewQuery
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
            this.SelectPanel = new FormsCs.IcsMetroPanel();
            this.ForceRefresh = new FormsCs.IcsMetroButton();
            this.QueryPosition = new FormsCs.IcsMetroComboBox();
            this.ToMap = new FormsCs.IcsMetroButton();
            this.ClearMap = new FormsCs.IcsMetroButton();
            this.SplitGeoQueryBrowser = new System.Windows.Forms.SplitContainer();
            this.Map = new NetPlugins2Ext.IcsOpenlayers3();
            this.DbListTable = new NetPlugins2.IcsDBList();
            this.icsOpenlayers61 = new NetPlugins2.IcsOpenlayers6();
            this.SelectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitGeoQueryBrowser)).BeginInit();
            this.SplitGeoQueryBrowser.Panel1.SuspendLayout();
            this.SplitGeoQueryBrowser.Panel2.SuspendLayout();
            this.SplitGeoQueryBrowser.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectPanel
            // 
            this.SelectPanel.Controls.Add(this.ForceRefresh);
            this.SelectPanel.Controls.Add(this.QueryPosition);
            this.SelectPanel.Controls.Add(this.ToMap);
            this.SelectPanel.Controls.Add(this.ClearMap);
            this.SelectPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectPanel.HorizontalScrollbarBarColor = true;
            this.SelectPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.SelectPanel.HorizontalScrollbarSize = 10;
            this.SelectPanel.Location = new System.Drawing.Point(0, 0);
            this.SelectPanel.Name = "SelectPanel";
            this.SelectPanel.Size = new System.Drawing.Size(800, 38);
            this.SelectPanel.TabIndex = 0;
            this.SelectPanel.VerticalScrollbarBarColor = true;
            this.SelectPanel.VerticalScrollbarHighlightOnWheel = false;
            this.SelectPanel.VerticalScrollbarSize = 10;
            // 
            // ForceRefresh
            // 
            this.ForceRefresh.Location = new System.Drawing.Point(419, 3);
            this.ForceRefresh.Name = "ForceRefresh";
            this.ForceRefresh.Size = new System.Drawing.Size(114, 23);
            this.ForceRefresh.TabIndex = 10;
            this.ForceRefresh.Text = "Update map data";
            this.ForceRefresh.Click += new System.EventHandler(this.ForceRefresh_Click);
            // 
            // QueryPosition
            // 
            this.QueryPosition.FormattingEnabled = true;
            this.QueryPosition.ItemHeight = 23;
            this.QueryPosition.Items.AddRange(new object[] {
            "Vertical",
            "Horizontal"});
            this.QueryPosition.Location = new System.Drawing.Point(3, 3);
            this.QueryPosition.MenuItemColor = System.Drawing.SystemColors.Control;
            this.QueryPosition.Name = "QueryPosition";
            this.QueryPosition.Size = new System.Drawing.Size(164, 29);
            this.QueryPosition.TabIndex = 9;
            this.QueryPosition.SelectedIndexChanged += new System.EventHandler(this.QueryPosition_SelectedIndexChanged);
            // 
            // ToMap
            // 
            this.ToMap.Location = new System.Drawing.Point(633, 3);
            this.ToMap.Name = "ToMap";
            this.ToMap.Size = new System.Drawing.Size(129, 23);
            this.ToMap.TabIndex = 8;
            this.ToMap.Text = "Export to ICS Telecom Map";
            this.ToMap.Click += new System.EventHandler(this.ToMap_Click);
            // 
            // ClearMap
            // 
            this.ClearMap.Location = new System.Drawing.Point(539, 3);
            this.ClearMap.Name = "ClearMap";
            this.ClearMap.Size = new System.Drawing.Size(88, 23);
            this.ClearMap.TabIndex = 6;
            this.ClearMap.Text = "Clear Map";
            this.ClearMap.Click += new System.EventHandler(this.ClearMap_Click);
            // 
            // SplitGeoQueryBrowser
            // 
            this.SplitGeoQueryBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitGeoQueryBrowser.Location = new System.Drawing.Point(0, 38);
            this.SplitGeoQueryBrowser.Name = "SplitGeoQueryBrowser";
            // 
            // SplitGeoQueryBrowser.Panel1
            // 
            this.SplitGeoQueryBrowser.Panel1.Controls.Add(this.icsOpenlayers61);
            this.SplitGeoQueryBrowser.Panel1.Controls.Add(this.Map);
            // 
            // SplitGeoQueryBrowser.Panel2
            // 
            this.SplitGeoQueryBrowser.Panel2.Controls.Add(this.DbListTable);
            this.SplitGeoQueryBrowser.Size = new System.Drawing.Size(800, 462);
            this.SplitGeoQueryBrowser.SplitterDistance = 402;
            this.SplitGeoQueryBrowser.TabIndex = 4;
            // 
            // Map
            // 
            this.Map.DisplayCsys = null;
            this.Map.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Map.InputGeomPoints = null;
            this.Map.InputGeomRadiusM = 0D;
            this.Map.InputMode = null;
            this.Map.InputType = null;
            this.Map.KmlsMaxCached = 20;
            this.Map.Location = new System.Drawing.Point(0, 301);
            this.Map.Margin = new System.Windows.Forms.Padding(2);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(402, 161);
            this.Map.StartLati = 48.53D;
            this.Map.StartLongi = 2.25D;
            this.Map.StartZoom = 5;
            this.Map.TabIndex = 2;
            this.Map.OnMapClicked += new System.EventHandler<NetPlugins2Ext.MapClickedEventArgs>(this.Map_OnMapClicked);
            // 
            // DbListTable
            // 
            this.DbListTable.BackColor = System.Drawing.SystemColors.Control;
            this.DbListTable.ConfigName = null;
            this.DbListTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DbListTable.Filter = null;
            this.DbListTable.Location = new System.Drawing.Point(0, 0);
            this.DbListTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DbListTable.Name = "DbListTable";
            this.DbListTable.Param1 = 0;
            this.DbListTable.Param2 = 0;
            this.DbListTable.Size = new System.Drawing.Size(394, 462);
            this.DbListTable.TabIndex = 4;
            this.DbListTable.Table = null;
            this.DbListTable.OnDefColumns += new System.EventHandler(this.DBList_OnDefColumns);
            this.DbListTable.OnRequery += new System.EventHandler(this.DBList_OnRequery);
            // 
            // icsOpenlayers61
            // 
            this.icsOpenlayers61.DisplayCsys = null;
            this.icsOpenlayers61.Dock = System.Windows.Forms.DockStyle.Top;
            this.icsOpenlayers61.InputGeomPoints = null;
            this.icsOpenlayers61.InputMode = null;
            this.icsOpenlayers61.InputType = null;
            this.icsOpenlayers61.KmlsMaxCached = 20;
            this.icsOpenlayers61.Location = new System.Drawing.Point(0, 0);
            this.icsOpenlayers61.Margin = new System.Windows.Forms.Padding(2);
            this.icsOpenlayers61.Name = "icsOpenlayers61";
            this.icsOpenlayers61.Size = new System.Drawing.Size(402, 253);
            this.icsOpenlayers61.StartLati = 40D;
            this.icsOpenlayers61.StartLongi = -4D;
            this.icsOpenlayers61.TabIndex = 11;
            // 
            // IcsMetroGeoViewQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.Controls.Add(this.SplitGeoQueryBrowser);
            this.Controls.Add(this.SelectPanel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "IcsMetroGeoViewQuery";
            this.Size = new System.Drawing.Size(800, 500);
            this.Style = "Purple";
            this.Load += new System.EventHandler(this.IcsMetroGeoView_Load);
            this.Resize += new System.EventHandler(this.IcsMetroGeoView_Resize);
            this.SelectPanel.ResumeLayout(false);
            this.SplitGeoQueryBrowser.Panel1.ResumeLayout(false);
            this.SplitGeoQueryBrowser.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitGeoQueryBrowser)).EndInit();
            this.SplitGeoQueryBrowser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private IcsMetroPanel SelectPanel;
        private IcsMetroButton ClearMap;
        private IcsMetroButton ToMap;
        private IcsMetroButton ForceRefresh;
        private IcsMetroComboBox QueryPosition;
        private System.Windows.Forms.SplitContainer SplitGeoQueryBrowser;
        private IcsOpenlayers3 Map;
        private IcsDBList DbListTable;
        private IcsOpenlayers6 icsOpenlayers61;
    }
}
