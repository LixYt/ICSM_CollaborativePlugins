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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryStoreEditor));
            this.CancelExit = new FormsCs.IcsMetroButton();
            this.Save = new FormsCs.IcsMetroButton();
            this.SaveExit = new FormsCs.IcsMetroButton();
            this.l_name = new FormsCs.IcsMetroLabel();
            this.l_desc = new FormsCs.IcsMetroLabel();
            this.l_item = new FormsCs.IcsMetroLabel();
            this.c_paste = new FormsCs.IcsMetroButton();
            this.c_name = new FormsCs.IcsMetroTextBox();
            this.c_desc = new FormsCs.IcsMetroTextBox();
            this.c_item = new FormsCs.IcsMetroTextBox();
            this.l_type = new FormsCs.IcsMetroLabel();
            this.l_tablename = new FormsCs.IcsMetroLabel();
            this.c_table = new System.Windows.Forms.ComboBox();
            this.c_type = new NetPlugins2.IcsCombo();
            this.C_CreatedDate = new FormsCs.IcsMetroTextBox();
            this.C_ModifiedDate = new FormsCs.IcsMetroTextBox();
            this.C_CreatedBy = new FormsCs.IcsMetroTextBox();
            this.C_ModifiedBy = new FormsCs.IcsMetroTextBox();
            this.l_created = new FormsCs.IcsMetroLabel();
            this.l_modified = new FormsCs.IcsMetroLabel();
            this.l_dbEngines = new FormsCs.IcsMetroLabel();
            this.c_Engines = new NetPlugins2.IcsControls.IcsComboList();
            this.SuspendLayout();
            // 
            // CancelExit
            // 
            this.CancelExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelExit.Location = new System.Drawing.Point(482, 429);
            this.CancelExit.Name = "CancelExit";
            this.CancelExit.Size = new System.Drawing.Size(96, 23);
            this.CancelExit.TabIndex = 0;
            this.CancelExit.Text = "Cancel and exit";
            this.CancelExit.Click += new System.EventHandler(this.CancelExit_Click);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Location = new System.Drawing.Point(401, 429);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveExit
            // 
            this.SaveExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveExit.Location = new System.Drawing.Point(584, 429);
            this.SaveExit.Name = "SaveExit";
            this.SaveExit.Size = new System.Drawing.Size(98, 23);
            this.SaveExit.TabIndex = 2;
            this.SaveExit.Text = "Save and exit";
            this.SaveExit.Click += new System.EventHandler(this.SaveExit_Click);
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.BackColor = System.Drawing.Color.Transparent;
            this.l_name.Location = new System.Drawing.Point(22, 70);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(42, 19);
            this.l_name.TabIndex = 3;
            this.l_name.Text = "name";
            // 
            // l_desc
            // 
            this.l_desc.AutoSize = true;
            this.l_desc.BackColor = System.Drawing.Color.Transparent;
            this.l_desc.Location = new System.Drawing.Point(22, 196);
            this.l_desc.Name = "l_desc";
            this.l_desc.Size = new System.Drawing.Size(74, 19);
            this.l_desc.TabIndex = 4;
            this.l_desc.Text = "Description";
            // 
            // l_item
            // 
            this.l_item.AutoSize = true;
            this.l_item.BackColor = System.Drawing.Color.Transparent;
            this.l_item.Location = new System.Drawing.Point(22, 252);
            this.l_item.Name = "l_item";
            this.l_item.Size = new System.Drawing.Size(76, 19);
            this.l_item.TabIndex = 5;
            this.l_item.Text = "Item stored";
            // 
            // c_paste
            // 
            this.c_paste.Location = new System.Drawing.Point(21, 312);
            this.c_paste.Name = "c_paste";
            this.c_paste.Size = new System.Drawing.Size(82, 54);
            this.c_paste.TabIndex = 6;
            this.c_paste.Text = "import from\r\nclipboard";
            this.c_paste.Click += new System.EventHandler(this.c_paste_Click);
            // 
            // c_name
            // 
            this.c_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_name.Location = new System.Drawing.Point(109, 67);
            this.c_name.Name = "c_name";
            this.c_name.Size = new System.Drawing.Size(573, 20);
            this.c_name.TabIndex = 7;
            // 
            // c_desc
            // 
            this.c_desc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_desc.Location = new System.Drawing.Point(109, 193);
            this.c_desc.Multiline = true;
            this.c_desc.Name = "c_desc";
            this.c_desc.Size = new System.Drawing.Size(573, 50);
            this.c_desc.TabIndex = 8;
            // 
            // c_item
            // 
            this.c_item.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_item.Location = new System.Drawing.Point(109, 249);
            this.c_item.Multiline = true;
            this.c_item.Name = "c_item";
            this.c_item.Size = new System.Drawing.Size(573, 117);
            this.c_item.TabIndex = 9;
            // 
            // l_type
            // 
            this.l_type.AutoSize = true;
            this.l_type.BackColor = System.Drawing.Color.Transparent;
            this.l_type.Location = new System.Drawing.Point(22, 96);
            this.l_type.Name = "l_type";
            this.l_type.Size = new System.Drawing.Size(34, 19);
            this.l_type.TabIndex = 3;
            this.l_type.Text = "type";
            // 
            // l_tablename
            // 
            this.l_tablename.AutoSize = true;
            this.l_tablename.BackColor = System.Drawing.Color.Transparent;
            this.l_tablename.Location = new System.Drawing.Point(22, 165);
            this.l_tablename.Name = "l_tablename";
            this.l_tablename.Size = new System.Drawing.Size(76, 19);
            this.l_tablename.TabIndex = 11;
            this.l_tablename.Text = "Table name";
            // 
            // c_table
            // 
            this.c_table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_table.Location = new System.Drawing.Point(109, 162);
            this.c_table.Margin = new System.Windows.Forms.Padding(0);
            this.c_table.Name = "c_table";
            this.c_table.Size = new System.Drawing.Size(573, 21);
            this.c_table.TabIndex = 12;
            // 
            // c_type
            // 
            this.c_type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_type.BackColor = System.Drawing.Color.Transparent;
            this.c_type.Coded = true;
            this.c_type.Location = new System.Drawing.Point(109, 96);
            this.c_type.Margin = new System.Windows.Forms.Padding(0);
            this.c_type.MaxLen = 50;
            this.c_type.Name = "c_type";
            this.c_type.ReadOnly = false;
            this.c_type.Size = new System.Drawing.Size(573, 25);
            this.c_type.Subtype = "eri_QueryStoreType";
            this.c_type.TabIndex = 13;
            this.c_type.Upperc = false;
            this.c_type.Value = "";
            // 
            // C_CreatedDate
            // 
            this.C_CreatedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.C_CreatedDate.BackColor = System.Drawing.SystemColors.Info;
            this.C_CreatedDate.Location = new System.Drawing.Point(530, 372);
            this.C_CreatedDate.Name = "C_CreatedDate";
            this.C_CreatedDate.ReadOnly = true;
            this.C_CreatedDate.Size = new System.Drawing.Size(152, 20);
            this.C_CreatedDate.TabIndex = 14;
            // 
            // C_ModifiedDate
            // 
            this.C_ModifiedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.C_ModifiedDate.BackColor = System.Drawing.SystemColors.Info;
            this.C_ModifiedDate.Location = new System.Drawing.Point(530, 403);
            this.C_ModifiedDate.Name = "C_ModifiedDate";
            this.C_ModifiedDate.ReadOnly = true;
            this.C_ModifiedDate.Size = new System.Drawing.Size(152, 20);
            this.C_ModifiedDate.TabIndex = 15;
            // 
            // C_CreatedBy
            // 
            this.C_CreatedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.C_CreatedBy.BackColor = System.Drawing.SystemColors.Info;
            this.C_CreatedBy.Location = new System.Drawing.Point(372, 372);
            this.C_CreatedBy.Name = "C_CreatedBy";
            this.C_CreatedBy.ReadOnly = true;
            this.C_CreatedBy.Size = new System.Drawing.Size(152, 20);
            this.C_CreatedBy.TabIndex = 16;
            // 
            // C_ModifiedBy
            // 
            this.C_ModifiedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.C_ModifiedBy.BackColor = System.Drawing.SystemColors.Info;
            this.C_ModifiedBy.Location = new System.Drawing.Point(372, 403);
            this.C_ModifiedBy.Name = "C_ModifiedBy";
            this.C_ModifiedBy.ReadOnly = true;
            this.C_ModifiedBy.Size = new System.Drawing.Size(152, 20);
            this.C_ModifiedBy.TabIndex = 17;
            // 
            // l_created
            // 
            this.l_created.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.l_created.AutoSize = true;
            this.l_created.BackColor = System.Drawing.Color.Transparent;
            this.l_created.Location = new System.Drawing.Point(303, 375);
            this.l_created.Name = "l_created";
            this.l_created.Size = new System.Drawing.Size(56, 19);
            this.l_created.TabIndex = 5;
            this.l_created.Text = "Created";
            // 
            // l_modified
            // 
            this.l_modified.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.l_modified.AutoSize = true;
            this.l_modified.BackColor = System.Drawing.Color.Transparent;
            this.l_modified.Location = new System.Drawing.Point(303, 406);
            this.l_modified.Name = "l_modified";
            this.l_modified.Size = new System.Drawing.Size(62, 19);
            this.l_modified.TabIndex = 5;
            this.l_modified.Text = "Modified";
            // 
            // l_dbEngines
            // 
            this.l_dbEngines.AutoSize = true;
            this.l_dbEngines.BackColor = System.Drawing.Color.Transparent;
            this.l_dbEngines.Location = new System.Drawing.Point(22, 127);
            this.l_dbEngines.Name = "l_dbEngines";
            this.l_dbEngines.Size = new System.Drawing.Size(185, 19);
            this.l_dbEngines.TabIndex = 18;
            this.l_dbEngines.Text = "Database engine compatibility";
            // 
            // c_Engines
            // 
            this.c_Engines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_Engines.BackColor = System.Drawing.Color.Transparent;
            this.c_Engines.EnclosingComma = true;
            this.c_Engines.EriLovName = "eri_DbEngines";
            this.c_Engines.Location = new System.Drawing.Point(212, 127);
            this.c_Engines.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.c_Engines.Name = "c_Engines";
            this.c_Engines.Size = new System.Drawing.Size(470, 22);
            this.c_Engines.TabIndex = 19;
            this.c_Engines.Value = "";
            // 
            // QueryStoreEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 475);
            this.Controls.Add(this.c_Engines);
            this.Controls.Add(this.l_dbEngines);
            this.Controls.Add(this.C_ModifiedBy);
            this.Controls.Add(this.C_CreatedBy);
            this.Controls.Add(this.C_ModifiedDate);
            this.Controls.Add(this.C_CreatedDate);
            this.Controls.Add(this.c_type);
            this.Controls.Add(this.c_table);
            this.Controls.Add(this.l_tablename);
            this.Controls.Add(this.c_item);
            this.Controls.Add(this.c_desc);
            this.Controls.Add(this.c_name);
            this.Controls.Add(this.c_paste);
            this.Controls.Add(this.l_modified);
            this.Controls.Add(this.l_created);
            this.Controls.Add(this.l_item);
            this.Controls.Add(this.l_desc);
            this.Controls.Add(this.l_type);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.SaveExit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.CancelExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(574, 475);
            this.Name = "QueryStoreEditor";
            this.Style = "Purple";
            this.Text = "Query configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QueryStoreEditor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FormsCs.IcsMetroButton CancelExit;
        private FormsCs.IcsMetroButton Save;
        private FormsCs.IcsMetroButton SaveExit;
        private FormsCs.IcsMetroLabel l_name;
        private FormsCs.IcsMetroLabel l_desc;
        private FormsCs.IcsMetroLabel l_item;
        private FormsCs.IcsMetroButton c_paste;
        private FormsCs.IcsMetroTextBox c_name;
        private FormsCs.IcsMetroTextBox c_desc;
        private FormsCs.IcsMetroTextBox c_item;
        private FormsCs.IcsMetroLabel l_type;
        private FormsCs.IcsMetroLabel l_tablename;
        private System.Windows.Forms.ComboBox c_table;
        private NetPlugins2.IcsCombo c_type;
        private FormsCs.IcsMetroTextBox C_CreatedDate;
        private FormsCs.IcsMetroTextBox C_ModifiedDate;
        private FormsCs.IcsMetroTextBox C_CreatedBy;
        private FormsCs.IcsMetroTextBox C_ModifiedBy;
        private FormsCs.IcsMetroLabel l_created;
        private FormsCs.IcsMetroLabel l_modified;
        private FormsCs.IcsMetroLabel l_dbEngines;
        private NetPlugins2.IcsControls.IcsComboList c_Engines;
    }
}