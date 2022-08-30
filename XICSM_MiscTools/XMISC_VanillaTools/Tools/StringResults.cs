using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DifferenceEngine;

namespace DiffCalc
{
	/// <summary>
	/// Summary description for Results.
	/// </summary>
	public class Results : Form
	{
		private ListView lvSource;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ListView lvDestination;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
        private SplitContainer splitContainer1;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public Results(DiffList_TextFile source, DiffList_TextFile destination, ArrayList DiffLines, double seconds)
		{
			InitializeComponent();
			this.Text = string.Format("Results: {0} secs.",seconds.ToString("#0.00"));

			ListViewItem lviS;
			ListViewItem lviD;
			int cnt = 1;
			int i;

			foreach (DiffResultSpan drs in DiffLines)
			{				
				switch (drs.Status)
				{
					case DiffResultSpanStatus.DeleteSource:
						for (i = 0; i < drs.Length; i++)
						{
							lviS = new ListViewItem(cnt.ToString("00000"));
							lviD = new ListViewItem(cnt.ToString("00000"));
							lviS.BackColor = Color.Red;
							lviS.SubItems.Add(((TextLine)source.GetByIndex(drs.SourceIndex + i)).Line);
							lviD.BackColor = Color.LightGray;
							lviD.SubItems.Add("");

							lvSource.Items.Add(lviS);
							lvDestination.Items.Add(lviD);
							cnt++;
						}
						
						break;
					case DiffResultSpanStatus.NoChange:
						for (i = 0; i < drs.Length; i++)
						{
							lviS = new ListViewItem(cnt.ToString("00000"));
							lviD = new ListViewItem(cnt.ToString("00000"));
							lviS.BackColor = Color.White;
							lviS.SubItems.Add(((TextLine)source.GetByIndex(drs.SourceIndex+i)).Line);
							lviD.BackColor = Color.White;
							lviD.SubItems.Add(((TextLine)destination.GetByIndex(drs.DestIndex+i)).Line);

							lvSource.Items.Add(lviS);
							lvDestination.Items.Add(lviD);
							cnt++;
						}
						
						break;
					case DiffResultSpanStatus.AddDestination:
						for (i = 0; i < drs.Length; i++)
						{
							lviS = new ListViewItem(cnt.ToString("00000"));
							lviD = new ListViewItem(cnt.ToString("00000"));
							lviS.BackColor = Color.LightGray;
							lviS.SubItems.Add("");
							lviD.BackColor = Color.LightGreen;
							lviD.SubItems.Add(((TextLine)destination.GetByIndex(drs.DestIndex+i)).Line);

							lvSource.Items.Add(lviS);
							lvDestination.Items.Add(lviD);
							cnt++;
						}
						
						break;
					case DiffResultSpanStatus.Replace:
						for (i = 0; i < drs.Length; i++)
						{
							lviS = new ListViewItem(cnt.ToString("00000"));
							lviD = new ListViewItem(cnt.ToString("00000"));
							lviS.BackColor = Color.Red;
							lviS.SubItems.Add(((TextLine)source.GetByIndex(drs.SourceIndex+i)).Line);
							lviD.BackColor = Color.LightGreen;
							lviD.SubItems.Add(((TextLine)destination.GetByIndex(drs.DestIndex+i)).Line);

							lvSource.Items.Add(lviS);
							lvDestination.Items.Add(lviD);
							cnt++;
						}
						
						break;
				}
				
			}
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.lvSource = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDestination = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvSource
            // 
            this.lvSource.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSource.FullRowSelect = true;
            this.lvSource.HideSelection = false;
            this.lvSource.Location = new System.Drawing.Point(0, 0);
            this.lvSource.MultiSelect = false;
            this.lvSource.Name = "lvSource";
            this.lvSource.Size = new System.Drawing.Size(436, 347);
            this.lvSource.TabIndex = 0;
            this.lvSource.UseCompatibleStateImageBehavior = false;
            this.lvSource.View = System.Windows.Forms.View.Details;
            this.lvSource.SelectedIndexChanged += new System.EventHandler(this.lvSource_SelectedIndexChanged);
            this.lvSource.Resize += new System.EventHandler(this.lvSource_Resize);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Line";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Text (Source)";
            this.columnHeader2.Width = 147;
            // 
            // lvDestination
            // 
            this.lvDestination.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDestination.FullRowSelect = true;
            this.lvDestination.HideSelection = false;
            this.lvDestination.Location = new System.Drawing.Point(0, 0);
            this.lvDestination.MultiSelect = false;
            this.lvDestination.Name = "lvDestination";
            this.lvDestination.Size = new System.Drawing.Size(449, 347);
            this.lvDestination.TabIndex = 2;
            this.lvDestination.UseCompatibleStateImageBehavior = false;
            this.lvDestination.View = System.Windows.Forms.View.Details;
            this.lvDestination.SelectedIndexChanged += new System.EventHandler(this.lvDestination_SelectedIndexChanged);
            this.lvDestination.Resize += new System.EventHandler(this.lvDestination_Resize);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Line";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Text (Destination)";
            this.columnHeader4.Width = 198;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvSource);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvDestination);
            this.splitContainer1.Size = new System.Drawing.Size(889, 347);
            this.splitContainer1.SplitterDistance = 436;
            this.splitContainer1.TabIndex = 3;
            // 
            // Results
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(889, 347);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Results";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            this.Resize += new System.EventHandler(this.Results_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void lvSource_Resize(object sender, System.EventArgs e)
		{
			/*if (lvSource.Width > 100)
			{
				lvSource.Columns[1].Width = -2;
			}*/
		}

		private void lvDestination_Resize(object sender, System.EventArgs e)
		{
			/*if (lvDestination.Width > 100)
			{
				lvDestination.Columns[1].Width = -2;
			}*/
		}

		private void Results_Resize(object sender, System.EventArgs e)
		{
			/*int w = this.ClientRectangle.Width/2;
			lvSource.Location = new Point(0,0);
			lvSource.Width = w;
			lvSource.Height = this.ClientRectangle.Height;

			lvDestination.Location = new Point(w+1,0);
			lvDestination.Width = this.ClientRectangle.Width - (w+1);
			lvDestination.Height = this.ClientRectangle.Height;*/
		}

		private void Results_Load(object sender, System.EventArgs e)
		{
			Results_Resize(sender,e);
		}

		private void lvSource_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lvSource.SelectedItems.Count > 0)
			{
				ListViewItem lvi = lvDestination.Items[lvSource.SelectedItems[0].Index];
				lvi.Selected = true;
				lvi.EnsureVisible();
			}
		}

		private void lvDestination_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lvDestination.SelectedItems.Count > 0)
			{
				ListViewItem lvi = lvSource.Items[lvDestination.SelectedItems[0].Index];
				lvi.Selected = true;
				lvi.EnsureVisible();
			}
		}
	}
}
