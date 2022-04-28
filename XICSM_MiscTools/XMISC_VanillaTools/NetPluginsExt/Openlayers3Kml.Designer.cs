namespace NetPlugins2Ext {
    partial class Openlayers3Kml {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components=null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing&&(components!=null)) {
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
            this.kmlAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstRecent = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstDist = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buClearRecent = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kmlAdd
            // 
            this.kmlAdd.Location = new System.Drawing.Point(318, 12);
            this.kmlAdd.Name = "kmlAdd";
            this.kmlAdd.Size = new System.Drawing.Size(200, 23);
            this.kmlAdd.TabIndex = 24;
            this.kmlAdd.Text = "Search file ...";
            this.kmlAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kmlAdd.UseVisualStyleBackColor = true;
            this.kmlAdd.Click += new System.EventHandler(this.kmlAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buClearRecent);
            this.groupBox1.Controls.Add(this.lstRecent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(318, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 287);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recent files";
            // 
            // lstRecent
            // 
            this.lstRecent.FormattingEnabled = true;
            this.lstRecent.ItemHeight = 16;
            this.lstRecent.Location = new System.Drawing.Point(7, 24);
            this.lstRecent.Name = "lstRecent";
            this.lstRecent.Size = new System.Drawing.Size(268, 228);
            this.lstRecent.TabIndex = 29;
            this.lstRecent.DoubleClick += new System.EventHandler(this.lstRecent_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Double click = Display";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstDist);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 316);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Displayed files";
            // 
            // lstDist
            // 
            this.lstDist.FormattingEnabled = true;
            this.lstDist.ItemHeight = 16;
            this.lstDist.Location = new System.Drawing.Point(9, 24);
            this.lstDist.Name = "lstDist";
            this.lstDist.Size = new System.Drawing.Size(268, 260);
            this.lstDist.TabIndex = 27;
            this.lstDist.DoubleClick += new System.EventHandler(this.lstDist_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Double click = Remove";
            // 
            // buClearRecent
            // 
            this.buClearRecent.Location = new System.Drawing.Point(200, 256);
            this.buClearRecent.Name = "buClearRecent";
            this.buClearRecent.Size = new System.Drawing.Size(75, 23);
            this.buClearRecent.TabIndex = 30;
            this.buClearRecent.Text = "clear";
            this.buClearRecent.UseVisualStyleBackColor = true;
            this.buClearRecent.Click += new System.EventHandler(this.buClearRecent_Click);
            // 
            // Openlayers3Kml
            // 
            this.AcceptButton = this.kmlAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 338);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kmlAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Openlayers3Kml";
            this.Text = "Displayed KML Files";
            this.Load += new System.EventHandler(this.Openlayers3Kml_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kmlAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstRecent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstDist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buClearRecent;
    }
}