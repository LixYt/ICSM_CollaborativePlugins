namespace NetPlugins2Ext
{
    partial class IcsOpenlayers3
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
            this.butHelp = new System.Windows.Forms.Button();
            this.layerList = new System.Windows.Forms.ComboBox();
            this.tbPos = new System.Windows.Forms.TextBox();
            this.wb1 = new System.Windows.Forms.WebBrowser();
            this.kml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butHelp
            // 
            this.butHelp.Location = new System.Drawing.Point(341, 3);
            this.butHelp.Margin = new System.Windows.Forms.Padding(2);
            this.butHelp.Name = "butHelp";
            this.butHelp.Size = new System.Drawing.Size(19, 19);
            this.butHelp.TabIndex = 20;
            this.butHelp.Text = "?";
            this.butHelp.UseVisualStyleBackColor = true;
            this.butHelp.Click += new System.EventHandler(this.butHelp_Click);
            // 
            // layerList
            // 
            this.layerList.FormattingEnabled = true;
            this.layerList.Location = new System.Drawing.Point(3, 2);
            this.layerList.Margin = new System.Windows.Forms.Padding(2);
            this.layerList.Name = "layerList";
            this.layerList.Size = new System.Drawing.Size(158, 21);
            this.layerList.TabIndex = 19;
            this.layerList.SelectedIndexChanged += new System.EventHandler(this.layerList_SelectedIndexChanged);
            // 
            // tbPos
            // 
            this.tbPos.Location = new System.Drawing.Point(186, 3);
            this.tbPos.Margin = new System.Windows.Forms.Padding(2);
            this.tbPos.Name = "tbPos";
            this.tbPos.ReadOnly = true;
            this.tbPos.Size = new System.Drawing.Size(154, 20);
            this.tbPos.TabIndex = 17;
            // 
            // wb1
            // 
            this.wb1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wb1.Location = new System.Drawing.Point(0, 39);
            this.wb1.Margin = new System.Windows.Forms.Padding(2);
            this.wb1.MinimumSize = new System.Drawing.Size(15, 16);
            this.wb1.Name = "wb1";
            this.wb1.ScriptErrorsSuppressed = true;
            this.wb1.ScrollBarsEnabled = false;
            this.wb1.Size = new System.Drawing.Size(488, 522);
            this.wb1.TabIndex = 16;
            this.wb1.Url = new System.Uri("", System.UriKind.Relative);
            this.wb1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wb1_DocumentCompleted);
            // 
            // kml
            // 
            this.kml.Location = new System.Drawing.Point(162, 2);
            this.kml.Margin = new System.Windows.Forms.Padding(2);
            this.kml.Name = "kml";
            this.kml.Size = new System.Drawing.Size(21, 21);
            this.kml.TabIndex = 23;
            this.kml.Text = "...";
            this.kml.UseVisualStyleBackColor = true;
            this.kml.Click += new System.EventHandler(this.kml_Click);
            // 
            // IcsOpenlayers3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kml);
            this.Controls.Add(this.butHelp);
            this.Controls.Add(this.layerList);
            this.Controls.Add(this.tbPos);
            this.Controls.Add(this.wb1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IcsOpenlayers3";
            this.Size = new System.Drawing.Size(488, 561);
            this.Load += new System.EventHandler(this.IcsOpenlayers3_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.IcsOpenlayers3_Layout);
            this.Resize += new System.EventHandler(this.IcsOpenlayers3_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPos;
        private System.Windows.Forms.WebBrowser wb1;
        private System.Windows.Forms.ComboBox layerList;
        private System.Windows.Forms.Button butHelp;
        private System.Windows.Forms.Button kml;
    }
}
