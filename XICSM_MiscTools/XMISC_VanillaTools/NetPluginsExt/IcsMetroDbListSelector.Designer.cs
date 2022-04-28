using FormsCs;
using NetPlugins2;

namespace NetPlugins2Ext
{
    partial class IcsMetroDbListSelector
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
            this.Cancel = new IcsMetroButton();
            this.OK = new IcsMetroButton();
            this.DBList = new NetPlugins2.IcsDBList();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(862, 32);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(96, 23);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(760, 32);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(96, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // DBList
            // 
            this.DBList.BackColor = System.Drawing.SystemColors.Control;
            this.DBList.ConfigName = null;
            this.DBList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DBList.Filter = null;
            this.DBList.Location = new System.Drawing.Point(20, 60);
            this.DBList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DBList.Name = "DBList";
            this.DBList.Param1 = 0;
            this.DBList.Param2 = 0;
            this.DBList.Size = new System.Drawing.Size(1084, 512);
            this.DBList.TabIndex = 1;
            this.DBList.Table = null;
            this.DBList.OnDefColumns += new System.EventHandler(this.DBList_OnDefColumns);
            this.DBList.OnRequery += new System.EventHandler(this.DBList_OnRequery);
            // 
            // IcsMetroDbListSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1124, 592);
            this.Controls.Add(this.DBList);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold);
            this.Name = "IcsMetroDbListSelector";
            this.Style = "Orange";
            this.Text = "Selection of Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IcsMetroDbListSelector_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private IcsMetroButton OK;
        private IcsMetroButton Cancel;
        private IcsDBList DBList;
    }
}
