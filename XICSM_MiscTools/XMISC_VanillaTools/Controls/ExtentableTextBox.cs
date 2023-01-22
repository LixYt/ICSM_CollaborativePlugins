﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XICSM.VanillaTools.Controls
{
    public partial class ExtentableTextBox : UserControl
    {
        [Category("_ExtentableTextBox")]
        [Description("Extentable TextBox label")]
        public string LabelText { get { return TheLabel.Text; } set { TheLabel.Text = value; } }

        [Category("_ExtentableTextBox")]
        [Description("Extentable Label Text Color")]
        public Color LabelTextColor { get { return TheLabel.ForeColor; } set { TheLabel.ForeColor = value; } }

        [Category("_ExtentableTextBox")]
        [Description("Extentable TextBox Text")]
        public string TextValue { 
            get { return TheValue.Text; } 
            set { if (value.Length > 20) { ActivateContextOption_DisplayMore(); } TheValue.Text = value; } 
        }

        [Category("_ExtentableTextBox")]
        [Description("Extentable TextBox Background Color")]
        public Color TextBoxBackColor { get { return TheValue.BackColor; } set { TheValue.BackColor = value; } }

        [Category("_ExtentableTextBox")]
        [Description("Extentable TextBox Text Color")]
        public Color TextBoxColor { get { return TheValue.ForeColor; } set { TheValue.ForeColor = value; } }

        [Category("_ExtentableTextBox")]
        [Description("Extentable Button Background Color")]
        public Color ButtonBackColor { get { return TheButton.BackColor; } set { TheButton.BackColor = value; } }

        [Category("_ExtentableTextBox")]
        [Description("Extentable Button Text Color")]
        public Color ButtonColor { get { return TheButton.ForeColor; } set { TheButton.ForeColor = value; } }

        [Category("_ExtentableTextBox")]
        [Description("Control background color")]
        public Color BackgroundColor { get { return BackColor; } set { BackColor = value; } }

        [Category("_ExtentableTextBox")]
        [Description("Show Button")]
        [DefaultValue(false)]
        public bool ShowButton {
            get { return TheButton.Visible; } set { SetTextBoxSize(); TheButton.Visible = value; } 
        }

        [Category("_ExtentableTextBox")]
        [Description("Read Only")]
        [DefaultValue(false)]
        public bool ReadOnly
        {
            get { return TheValue.ReadOnly; }
            set { TheButton.Enabled = value; TheValue.ReadOnly = value; }
        }

        public ExtentableTextBox()
        {
            InitializeComponent();
        }

        public void SetTextBoxSize()
        {
            TheValue.Width = ShowButton ? 150 : 120;
        }

        public void ActivateContextOption_DisplayMore()
        {
            MenuItem m = new MenuItem("Display field full size", DisplayMore);
            ContextMenu.MenuItems.Add(m);
        }
        public void DisplayMore(object sender, EventArgs e)
        {
            MessageBox.Show(TheValue.Text);
        }

    }
}
