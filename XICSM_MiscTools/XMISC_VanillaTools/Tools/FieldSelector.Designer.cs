
namespace XICSM.VanillaTools.Tools
{
    partial class FieldSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FieldSelector));
            this.ListOfFields = new System.Windows.Forms.TreeView();
            this.c_ok = new System.Windows.Forms.Button();
            this.c_cancel = new System.Windows.Forms.Button();
            this.Filtering = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListOfFields
            // 
            this.ListOfFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListOfFields.CheckBoxes = true;
            this.ListOfFields.Location = new System.Drawing.Point(12, 34);
            this.ListOfFields.Name = "ListOfFields";
            this.ListOfFields.Size = new System.Drawing.Size(699, 335);
            this.ListOfFields.TabIndex = 0;
            // 
            // c_ok
            // 
            this.c_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c_ok.Location = new System.Drawing.Point(555, 375);
            this.c_ok.Name = "c_ok";
            this.c_ok.Size = new System.Drawing.Size(75, 23);
            this.c_ok.TabIndex = 1;
            this.c_ok.Text = "OK";
            this.c_ok.UseVisualStyleBackColor = true;
            this.c_ok.Click += new System.EventHandler(this.c_ok_Click);
            // 
            // c_cancel
            // 
            this.c_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c_cancel.Location = new System.Drawing.Point(636, 375);
            this.c_cancel.Name = "c_cancel";
            this.c_cancel.Size = new System.Drawing.Size(75, 23);
            this.c_cancel.TabIndex = 1;
            this.c_cancel.Text = "Cancel";
            this.c_cancel.UseVisualStyleBackColor = true;
            this.c_cancel.Click += new System.EventHandler(this.c_cancel_Click);
            // 
            // Filtering
            // 
            this.Filtering.Location = new System.Drawing.Point(184, 8);
            this.Filtering.Name = "Filtering";
            this.Filtering.Size = new System.Drawing.Size(373, 20);
            this.Filtering.TabIndex = 2;
            this.Filtering.TextChanged += new System.EventHandler(this.Filtering_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Highlight elements contening ";
            // 
            // FieldSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Filtering);
            this.Controls.Add(this.c_cancel);
            this.Controls.Add(this.c_ok);
            this.Controls.Add(this.ListOfFields);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(739, 449);
            this.Name = "FieldSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Field Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView ListOfFields;
        private System.Windows.Forms.Button c_ok;
        private System.Windows.Forms.Button c_cancel;
        private System.Windows.Forms.TextBox Filtering;
        private System.Windows.Forms.Label label1;
    }
}