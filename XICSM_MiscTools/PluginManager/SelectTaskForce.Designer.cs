
namespace XICSM.PluginManager
{
    partial class SelectTaskForce
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
            this.TaskForceESD = new NetPlugins2.IcsEditSelectDetach();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskForceESD
            // 
            this.TaskForceESD.Filter = null;
            this.TaskForceESD.Location = new System.Drawing.Point(11, 11);
            this.TaskForceESD.Margin = new System.Windows.Forms.Padding(2);
            this.TaskForceESD.Name = "TaskForceESD";
            this.TaskForceESD.ReadOnly = false;
            this.TaskForceESD.Size = new System.Drawing.Size(261, 73);
            this.TaskForceESD.TabIndex = 0;
            this.TaskForceESD.Table = "TASKFORCE";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(11, 89);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(197, 89);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // SelectTaskForce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 117);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.TaskForceESD);
            this.Name = "SelectTaskForce";
            this.Text = "Select a taskfroce";
            this.ResumeLayout(false);

        }

        #endregion

        private NetPlugins2.IcsEditSelectDetach TaskForceESD;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
    }
}