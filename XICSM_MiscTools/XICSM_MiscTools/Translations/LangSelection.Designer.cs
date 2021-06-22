
namespace XICSM.MiscTools
{
    partial class LangSelection
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
            this.c_lang = new System.Windows.Forms.ListBox();
            this.c_OK = new System.Windows.Forms.Button();
            this.c_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // c_lang
            // 
            this.c_lang.FormattingEnabled = true;
            this.c_lang.Location = new System.Drawing.Point(12, 12);
            this.c_lang.Name = "c_lang";
            this.c_lang.Size = new System.Drawing.Size(275, 290);
            this.c_lang.TabIndex = 0;
            // 
            // c_OK
            // 
            this.c_OK.Location = new System.Drawing.Point(13, 306);
            this.c_OK.Name = "c_OK";
            this.c_OK.Size = new System.Drawing.Size(75, 23);
            this.c_OK.TabIndex = 1;
            this.c_OK.Text = "OK";
            this.c_OK.UseVisualStyleBackColor = true;
            this.c_OK.Click += new System.EventHandler(this.c_OK_Click);
            // 
            // c_Cancel
            // 
            this.c_Cancel.Location = new System.Drawing.Point(212, 306);
            this.c_Cancel.Name = "c_Cancel";
            this.c_Cancel.Size = new System.Drawing.Size(75, 23);
            this.c_Cancel.TabIndex = 2;
            this.c_Cancel.Text = "Cancel";
            this.c_Cancel.UseVisualStyleBackColor = true;
            this.c_Cancel.Click += new System.EventHandler(this.c_Cancel_Click);
            // 
            // LangSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 341);
            this.Controls.Add(this.c_Cancel);
            this.Controls.Add(this.c_OK);
            this.Controls.Add(this.c_lang);
            this.Name = "LangSelection";
            this.Text = "LangSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox c_lang;
        private System.Windows.Forms.Button c_OK;
        private System.Windows.Forms.Button c_Cancel;
    }
}