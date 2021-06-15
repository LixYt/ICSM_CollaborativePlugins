namespace XICSM.MiscTools
{
    partial class QueryStoreEditor
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
            this.CancelExit = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SaveExit = new System.Windows.Forms.Button();
            this.l_name = new System.Windows.Forms.Label();
            this.l_desc = new System.Windows.Forms.Label();
            this.l_query = new System.Windows.Forms.Label();
            this.c_paste = new System.Windows.Forms.Button();
            this.c_name = new System.Windows.Forms.TextBox();
            this.c_desc = new System.Windows.Forms.TextBox();
            this.c_query = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelExit
            // 
            this.CancelExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelExit.Location = new System.Drawing.Point(336, 338);
            this.CancelExit.Name = "CancelExit";
            this.CancelExit.Size = new System.Drawing.Size(96, 23);
            this.CancelExit.TabIndex = 0;
            this.CancelExit.Text = "Cancel and exit";
            this.CancelExit.UseVisualStyleBackColor = true;
            this.CancelExit.Click += new System.EventHandler(this.CancelExit_Click);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Location = new System.Drawing.Point(255, 338);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveExit
            // 
            this.SaveExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveExit.Location = new System.Drawing.Point(438, 338);
            this.SaveExit.Name = "SaveExit";
            this.SaveExit.Size = new System.Drawing.Size(98, 23);
            this.SaveExit.TabIndex = 2;
            this.SaveExit.Text = "Save and exit";
            this.SaveExit.UseVisualStyleBackColor = true;
            this.SaveExit.Click += new System.EventHandler(this.SaveExit_Click);
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(5, 9);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(33, 13);
            this.l_name.TabIndex = 3;
            this.l_name.Text = "name";
            // 
            // l_desc
            // 
            this.l_desc.AutoSize = true;
            this.l_desc.Location = new System.Drawing.Point(5, 35);
            this.l_desc.Name = "l_desc";
            this.l_desc.Size = new System.Drawing.Size(58, 13);
            this.l_desc.TabIndex = 4;
            this.l_desc.Text = "description";
            // 
            // l_query
            // 
            this.l_query.AutoSize = true;
            this.l_query.Location = new System.Drawing.Point(5, 94);
            this.l_query.Name = "l_query";
            this.l_query.Size = new System.Drawing.Size(65, 13);
            this.l_query.TabIndex = 5;
            this.l_query.Text = "query config";
            // 
            // c_paste
            // 
            this.c_paste.Location = new System.Drawing.Point(76, 296);
            this.c_paste.Name = "c_paste";
            this.c_paste.Size = new System.Drawing.Size(173, 23);
            this.c_paste.TabIndex = 6;
            this.c_paste.Text = "query config from clipboard";
            this.c_paste.UseVisualStyleBackColor = true;
            this.c_paste.Click += new System.EventHandler(this.c_paste_Click);
            // 
            // c_name
            // 
            this.c_name.Location = new System.Drawing.Point(76, 6);
            this.c_name.Name = "c_name";
            this.c_name.Size = new System.Drawing.Size(457, 20);
            this.c_name.TabIndex = 7;
            // 
            // c_desc
            // 
            this.c_desc.Location = new System.Drawing.Point(76, 32);
            this.c_desc.Multiline = true;
            this.c_desc.Name = "c_desc";
            this.c_desc.Size = new System.Drawing.Size(457, 50);
            this.c_desc.TabIndex = 8;
            // 
            // c_query
            // 
            this.c_query.Location = new System.Drawing.Point(76, 91);
            this.c_query.Multiline = true;
            this.c_query.Name = "c_query";
            this.c_query.Size = new System.Drawing.Size(457, 199);
            this.c_query.TabIndex = 9;
            // 
            // QueryStoreEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 373);
            this.Controls.Add(this.c_query);
            this.Controls.Add(this.c_desc);
            this.Controls.Add(this.c_name);
            this.Controls.Add(this.c_paste);
            this.Controls.Add(this.l_query);
            this.Controls.Add(this.l_desc);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.SaveExit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.CancelExit);
            this.Name = "QueryStoreEditor";
            this.Text = "QueryStoreEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelExit;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button SaveExit;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label l_desc;
        private System.Windows.Forms.Label l_query;
        private System.Windows.Forms.Button c_paste;
        private System.Windows.Forms.TextBox c_name;
        private System.Windows.Forms.TextBox c_desc;
        private System.Windows.Forms.TextBox c_query;
    }
}