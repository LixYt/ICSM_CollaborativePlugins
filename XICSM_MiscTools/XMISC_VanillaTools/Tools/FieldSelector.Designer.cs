
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
            this.ListOfFields = new System.Windows.Forms.TreeView();
            this.c_ok = new System.Windows.Forms.Button();
            this.c_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListOfFields
            // 
            this.ListOfFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListOfFields.CheckBoxes = true;
            this.ListOfFields.Location = new System.Drawing.Point(12, 12);
            this.ListOfFields.Name = "ListOfFields";
            this.ListOfFields.Size = new System.Drawing.Size(699, 357);
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
            // FieldSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 410);
            this.Controls.Add(this.c_cancel);
            this.Controls.Add(this.c_ok);
            this.Controls.Add(this.ListOfFields);
            this.Name = "FieldSelector";
            this.Text = "FieldSelector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView ListOfFields;
        private System.Windows.Forms.Button c_ok;
        private System.Windows.Forms.Button c_cancel;
    }
}