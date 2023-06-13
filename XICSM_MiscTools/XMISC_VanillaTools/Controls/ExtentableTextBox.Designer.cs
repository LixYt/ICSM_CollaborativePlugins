
namespace XICSM.VanillaTools.Controls
{
    partial class ExtentableTextBox
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TheLabel = new System.Windows.Forms.Label();
            this.TheValue = new System.Windows.Forms.TextBox();
            this.TheButton = new System.Windows.Forms.Button();
            this.ButtonMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // TheLabel
            // 
            this.TheLabel.Location = new System.Drawing.Point(4, 1);
            this.TheLabel.Name = "TheLabel";
            this.TheLabel.Size = new System.Drawing.Size(150, 20);
            this.TheLabel.TabIndex = 0;
            this.TheLabel.Text = "label1";
            this.TheLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TheValue
            // 
            this.TheValue.Location = new System.Drawing.Point(160, 1);
            this.TheValue.Name = "TheValue";
            this.TheValue.Size = new System.Drawing.Size(150, 20);
            this.TheValue.TabIndex = 1;
            // 
            // TheButton
            // 
            this.TheButton.ContextMenuStrip = this.ButtonMenu;
            this.TheButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TheButton.Location = new System.Drawing.Point(286, 1);
            this.TheButton.Name = "TheButton";
            this.TheButton.Size = new System.Drawing.Size(25, 20);
            this.TheButton.TabIndex = 2;
            this.TheButton.Text = "...";
            this.TheButton.UseVisualStyleBackColor = true;
            this.TheButton.Visible = false;
            this.TheButton.Click += new System.EventHandler(this.TheButton_Click);
            // 
            // ButtonMenu
            // 
            this.ButtonMenu.Name = "ButtonMenu";
            this.ButtonMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // ExtentableTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TheButton);
            this.Controls.Add(this.TheValue);
            this.Controls.Add(this.TheLabel);
            this.Name = "ExtentableTextBox";
            this.Size = new System.Drawing.Size(315, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TheLabel;
        private System.Windows.Forms.TextBox TheValue;
        private System.Windows.Forms.Button TheButton;
        public System.Windows.Forms.ContextMenuStrip ButtonMenu;
    }
}
