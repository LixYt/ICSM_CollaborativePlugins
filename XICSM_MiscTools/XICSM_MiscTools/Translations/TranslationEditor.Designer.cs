
namespace XICSM.MiscTools
{
    partial class TranslationEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.CancelExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.c_SourceString = new System.Windows.Forms.TextBox();
            this.c_TranslatedString = new System.Windows.Forms.TextBox();
            this.SaveExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Native string";
            // 
            // CancelExit
            // 
            this.CancelExit.Location = new System.Drawing.Point(234, 123);
            this.CancelExit.Name = "CancelExit";
            this.CancelExit.Size = new System.Drawing.Size(95, 23);
            this.CancelExit.TabIndex = 2;
            this.CancelExit.Text = "Cancel and Exit";
            this.CancelExit.UseVisualStyleBackColor = true;
            this.CancelExit.Click += new System.EventHandler(this.CancelExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Translated String";
            // 
            // c_SourceString
            // 
            this.c_SourceString.Location = new System.Drawing.Point(12, 25);
            this.c_SourceString.Name = "c_SourceString";
            this.c_SourceString.ReadOnly = true;
            this.c_SourceString.Size = new System.Drawing.Size(317, 20);
            this.c_SourceString.TabIndex = 4;
            // 
            // c_TranslatedString
            // 
            this.c_TranslatedString.Location = new System.Drawing.Point(12, 80);
            this.c_TranslatedString.Name = "c_TranslatedString";
            this.c_TranslatedString.Size = new System.Drawing.Size(317, 20);
            this.c_TranslatedString.TabIndex = 5;
            // 
            // SaveExit
            // 
            this.SaveExit.Location = new System.Drawing.Point(133, 123);
            this.SaveExit.Name = "SaveExit";
            this.SaveExit.Size = new System.Drawing.Size(95, 23);
            this.SaveExit.TabIndex = 6;
            this.SaveExit.Text = "Save and Exit";
            this.SaveExit.UseVisualStyleBackColor = true;
            this.SaveExit.Click += new System.EventHandler(this.SaveExit_Click);
            // 
            // TranslationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 154);
            this.Controls.Add(this.SaveExit);
            this.Controls.Add(this.c_TranslatedString);
            this.Controls.Add(this.c_SourceString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelExit);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(362, 193);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(362, 193);
            this.Name = "TranslationEditor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TranslationEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox c_SourceString;
        private System.Windows.Forms.TextBox c_TranslatedString;
        private System.Windows.Forms.Button SaveExit;
    }
}