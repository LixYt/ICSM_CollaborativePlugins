
namespace XICSM.TicketSystem.Forms
{
    partial class TicketAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketAdmin));
            this.l_ticket = new System.Windows.Forms.GroupBox();
            this.c_type = new NetPlugins2.IcsComboEdt();
            this.c_subcategory = new NetPlugins2.IcsComboEdt();
            this.c_category = new NetPlugins2.IcsComboEdt();
            this.l_subcategory = new System.Windows.Forms.Label();
            this.l_category = new System.Windows.Forms.Label();
            this.c_Save = new System.Windows.Forms.Button();
            this.c_CancelExit = new System.Windows.Forms.Button();
            this.c_RequestedFor = new NetPlugins2.IcsEditSelectDetach();
            this.c_SaveExit = new System.Windows.Forms.Button();
            this.l_requestedFor = new System.Windows.Forms.Label();
            this.c_RequestedBy = new NetPlugins2.IcsEditSelectDetach();
            this.c_CreatedModified = new System.Windows.Forms.TextBox();
            this.c_Response = new System.Windows.Forms.TextBox();
            this.c_Details = new System.Windows.Forms.TextBox();
            this.c_Title = new System.Windows.Forms.TextBox();
            this.c_AssignedTo = new NetPlugins2.IcsEditSelectDetach();
            this.c_KnowDb = new NetPlugins2.IcsEditSelectDetach();
            this.c_id = new NetPlugins2.IcsInteger();
            this.c_status = new NetPlugins2.IcsStatus();
            this.l_requestedBy = new System.Windows.Forms.Label();
            this.l_assignedTo = new System.Windows.Forms.Label();
            this.l_knowdb = new System.Windows.Forms.Label();
            this.l_type = new System.Windows.Forms.Label();
            this.l_status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l_response = new System.Windows.Forms.Label();
            this.l_title = new System.Windows.Forms.Label();
            this.l_id = new System.Windows.Forms.Label();
            this.c_Messages = new NetPlugins2.IcsDBList();
            this.l_tasks = new System.Windows.Forms.GroupBox();
            this.c_Tasks = new NetPlugins2.IcsDBList();
            this.l_messages = new System.Windows.Forms.GroupBox();
            this.l_ticket.SuspendLayout();
            this.l_tasks.SuspendLayout();
            this.l_messages.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_ticket
            // 
            this.l_ticket.BackColor = System.Drawing.Color.Transparent;
            this.l_ticket.Controls.Add(this.c_type);
            this.l_ticket.Controls.Add(this.c_subcategory);
            this.l_ticket.Controls.Add(this.c_category);
            this.l_ticket.Controls.Add(this.l_subcategory);
            this.l_ticket.Controls.Add(this.l_category);
            this.l_ticket.Controls.Add(this.c_Save);
            this.l_ticket.Controls.Add(this.c_CancelExit);
            this.l_ticket.Controls.Add(this.c_RequestedFor);
            this.l_ticket.Controls.Add(this.c_SaveExit);
            this.l_ticket.Controls.Add(this.l_requestedFor);
            this.l_ticket.Controls.Add(this.c_RequestedBy);
            this.l_ticket.Controls.Add(this.c_CreatedModified);
            this.l_ticket.Controls.Add(this.c_Response);
            this.l_ticket.Controls.Add(this.c_Details);
            this.l_ticket.Controls.Add(this.c_Title);
            this.l_ticket.Controls.Add(this.c_AssignedTo);
            this.l_ticket.Controls.Add(this.c_KnowDb);
            this.l_ticket.Controls.Add(this.c_id);
            this.l_ticket.Controls.Add(this.c_status);
            this.l_ticket.Controls.Add(this.l_requestedBy);
            this.l_ticket.Controls.Add(this.l_assignedTo);
            this.l_ticket.Controls.Add(this.l_knowdb);
            this.l_ticket.Controls.Add(this.l_type);
            this.l_ticket.Controls.Add(this.l_status);
            this.l_ticket.Controls.Add(this.label4);
            this.l_ticket.Controls.Add(this.l_response);
            this.l_ticket.Controls.Add(this.l_title);
            this.l_ticket.Controls.Add(this.l_id);
            this.l_ticket.Location = new System.Drawing.Point(12, 63);
            this.l_ticket.Name = "l_ticket";
            this.l_ticket.Size = new System.Drawing.Size(1064, 365);
            this.l_ticket.TabIndex = 0;
            this.l_ticket.TabStop = false;
            this.l_ticket.Text = "Ticket";
            // 
            // c_type
            // 
            this.c_type.Coded = true;
            this.c_type.Location = new System.Drawing.Point(452, 14);
            this.c_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c_type.MaxLen = 50;
            this.c_type.Name = "c_type";
            this.c_type.ReadOnly = false;
            this.c_type.Size = new System.Drawing.Size(158, 27);
            this.c_type.Subtype = "lov_TicketType";
            this.c_type.TabIndex = 25;
            this.c_type.Upperc = false;
            this.c_type.Value = "";
            // 
            // c_subcategory
            // 
            this.c_subcategory.Coded = true;
            this.c_subcategory.Location = new System.Drawing.Point(377, 44);
            this.c_subcategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c_subcategory.MaxLen = 50;
            this.c_subcategory.Name = "c_subcategory";
            this.c_subcategory.ReadOnly = false;
            this.c_subcategory.Size = new System.Drawing.Size(233, 27);
            this.c_subcategory.Subtype = "lov_SubCategoryTicket";
            this.c_subcategory.TabIndex = 24;
            this.c_subcategory.Upperc = false;
            this.c_subcategory.Value = "";
            // 
            // c_category
            // 
            this.c_category.Coded = true;
            this.c_category.Location = new System.Drawing.Point(62, 44);
            this.c_category.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c_category.MaxLen = 50;
            this.c_category.Name = "c_category";
            this.c_category.ReadOnly = false;
            this.c_category.Size = new System.Drawing.Size(233, 27);
            this.c_category.Subtype = "lov_CategoryTicket";
            this.c_category.TabIndex = 23;
            this.c_category.Upperc = false;
            this.c_category.Value = "";
            // 
            // l_subcategory
            // 
            this.l_subcategory.AutoSize = true;
            this.l_subcategory.Location = new System.Drawing.Point(302, 48);
            this.l_subcategory.Name = "l_subcategory";
            this.l_subcategory.Size = new System.Drawing.Size(68, 13);
            this.l_subcategory.TabIndex = 22;
            this.l_subcategory.Text = "SubCategory";
            // 
            // l_category
            // 
            this.l_category.AutoSize = true;
            this.l_category.Location = new System.Drawing.Point(6, 48);
            this.l_category.Name = "l_category";
            this.l_category.Size = new System.Drawing.Size(49, 13);
            this.l_category.TabIndex = 22;
            this.l_category.Text = "Category";
            // 
            // c_Save
            // 
            this.c_Save.Location = new System.Drawing.Point(970, 325);
            this.c_Save.Name = "c_Save";
            this.c_Save.Size = new System.Drawing.Size(88, 23);
            this.c_Save.TabIndex = 4;
            this.c_Save.Text = "Save changes";
            this.c_Save.UseVisualStyleBackColor = true;
            // 
            // c_CancelExit
            // 
            this.c_CancelExit.Location = new System.Drawing.Point(862, 325);
            this.c_CancelExit.Name = "c_CancelExit";
            this.c_CancelExit.Size = new System.Drawing.Size(102, 23);
            this.c_CancelExit.TabIndex = 3;
            this.c_CancelExit.Text = "Cancel and Exit";
            this.c_CancelExit.UseVisualStyleBackColor = true;
            // 
            // c_RequestedFor
            // 
            this.c_RequestedFor.Filter = null;
            this.c_RequestedFor.Location = new System.Drawing.Point(845, 32);
            this.c_RequestedFor.Margin = new System.Windows.Forms.Padding(2);
            this.c_RequestedFor.Name = "c_RequestedFor";
            this.c_RequestedFor.ReadOnly = false;
            this.c_RequestedFor.Size = new System.Drawing.Size(210, 62);
            this.c_RequestedFor.TabIndex = 18;
            this.c_RequestedFor.Table = "ALL_PERSONS";
            // 
            // c_SaveExit
            // 
            this.c_SaveExit.Location = new System.Drawing.Point(765, 325);
            this.c_SaveExit.Name = "c_SaveExit";
            this.c_SaveExit.Size = new System.Drawing.Size(91, 23);
            this.c_SaveExit.TabIndex = 2;
            this.c_SaveExit.Text = "Save and Exit";
            this.c_SaveExit.UseVisualStyleBackColor = true;
            this.c_SaveExit.Click += new System.EventHandler(this.c_SaveExit_Click);
            // 
            // l_requestedFor
            // 
            this.l_requestedFor.AutoSize = true;
            this.l_requestedFor.Location = new System.Drawing.Point(845, 15);
            this.l_requestedFor.Name = "l_requestedFor";
            this.l_requestedFor.Size = new System.Drawing.Size(83, 13);
            this.l_requestedFor.TabIndex = 17;
            this.l_requestedFor.Text = "Requested for...";
            // 
            // c_RequestedBy
            // 
            this.c_RequestedBy.Filter = null;
            this.c_RequestedBy.Location = new System.Drawing.Point(631, 32);
            this.c_RequestedBy.Margin = new System.Windows.Forms.Padding(2);
            this.c_RequestedBy.Name = "c_RequestedBy";
            this.c_RequestedBy.ReadOnly = false;
            this.c_RequestedBy.Size = new System.Drawing.Size(210, 62);
            this.c_RequestedBy.TabIndex = 16;
            this.c_RequestedBy.Table = "ALL_PERSONS";
            // 
            // c_CreatedModified
            // 
            this.c_CreatedModified.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.c_CreatedModified.Location = new System.Drawing.Point(848, 207);
            this.c_CreatedModified.Multiline = true;
            this.c_CreatedModified.Name = "c_CreatedModified";
            this.c_CreatedModified.Size = new System.Drawing.Size(207, 77);
            this.c_CreatedModified.TabIndex = 15;
            // 
            // c_Response
            // 
            this.c_Response.Location = new System.Drawing.Point(9, 236);
            this.c_Response.Multiline = true;
            this.c_Response.Name = "c_Response";
            this.c_Response.Size = new System.Drawing.Size(599, 112);
            this.c_Response.TabIndex = 14;
            // 
            // c_Details
            // 
            this.c_Details.Location = new System.Drawing.Point(9, 115);
            this.c_Details.Multiline = true;
            this.c_Details.Name = "c_Details";
            this.c_Details.Size = new System.Drawing.Size(599, 102);
            this.c_Details.TabIndex = 13;
            // 
            // c_Title
            // 
            this.c_Title.Location = new System.Drawing.Point(40, 75);
            this.c_Title.Name = "c_Title";
            this.c_Title.Size = new System.Drawing.Size(568, 20);
            this.c_Title.TabIndex = 11;
            // 
            // c_AssignedTo
            // 
            this.c_AssignedTo.Filter = null;
            this.c_AssignedTo.Location = new System.Drawing.Point(631, 114);
            this.c_AssignedTo.Margin = new System.Windows.Forms.Padding(2);
            this.c_AssignedTo.Name = "c_AssignedTo";
            this.c_AssignedTo.ReadOnly = false;
            this.c_AssignedTo.Size = new System.Drawing.Size(210, 62);
            this.c_AssignedTo.TabIndex = 10;
            this.c_AssignedTo.Table = "ALL_PERSONS";
            // 
            // c_KnowDb
            // 
            this.c_KnowDb.Filter = null;
            this.c_KnowDb.Location = new System.Drawing.Point(631, 207);
            this.c_KnowDb.Margin = new System.Windows.Forms.Padding(2);
            this.c_KnowDb.Name = "c_KnowDb";
            this.c_KnowDb.ReadOnly = false;
            this.c_KnowDb.Size = new System.Drawing.Size(210, 77);
            this.c_KnowDb.TabIndex = 10;
            this.c_KnowDb.Table = "XTICKET_KNOWDB";
            // 
            // c_id
            // 
            this.c_id.Location = new System.Drawing.Point(87, 15);
            this.c_id.Margin = new System.Windows.Forms.Padding(0);
            this.c_id.MinValue = 0;
            this.c_id.Name = "c_id";
            this.c_id.ReadOnly = true;
            this.c_id.Size = new System.Drawing.Size(93, 23);
            this.c_id.Subtype = null;
            this.c_id.TabIndex = 8;
            // 
            // c_status
            // 
            this.c_status.Location = new System.Drawing.Point(225, 15);
            this.c_status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.c_status.MaxLen = 50;
            this.c_status.Name = "c_status";
            this.c_status.ReadOnly = false;
            this.c_status.Size = new System.Drawing.Size(182, 26);
            this.c_status.Subtype = "stat_TICKET";
            this.c_status.TabIndex = 7;
            this.c_status.Value = "";
            // 
            // l_requestedBy
            // 
            this.l_requestedBy.AutoSize = true;
            this.l_requestedBy.Location = new System.Drawing.Point(632, 15);
            this.l_requestedBy.Name = "l_requestedBy";
            this.l_requestedBy.Size = new System.Drawing.Size(82, 13);
            this.l_requestedBy.TabIndex = 6;
            this.l_requestedBy.Text = "Requested by...";
            // 
            // l_assignedTo
            // 
            this.l_assignedTo.AutoSize = true;
            this.l_assignedTo.Location = new System.Drawing.Point(635, 99);
            this.l_assignedTo.Name = "l_assignedTo";
            this.l_assignedTo.Size = new System.Drawing.Size(71, 13);
            this.l_assignedTo.TabIndex = 6;
            this.l_assignedTo.Text = "Assigned to...";
            // 
            // l_knowdb
            // 
            this.l_knowdb.AutoSize = true;
            this.l_knowdb.Location = new System.Drawing.Point(628, 190);
            this.l_knowdb.Name = "l_knowdb";
            this.l_knowdb.Size = new System.Drawing.Size(107, 13);
            this.l_knowdb.TabIndex = 6;
            this.l_knowdb.Text = "Knowledge database";
            // 
            // l_type
            // 
            this.l_type.AutoSize = true;
            this.l_type.Location = new System.Drawing.Point(412, 18);
            this.l_type.Name = "l_type";
            this.l_type.Size = new System.Drawing.Size(31, 13);
            this.l_type.TabIndex = 5;
            this.l_type.Text = "Type";
            // 
            // l_status
            // 
            this.l_status.AutoSize = true;
            this.l_status.Location = new System.Drawing.Point(183, 18);
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(37, 13);
            this.l_status.TabIndex = 4;
            this.l_status.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Details";
            // 
            // l_response
            // 
            this.l_response.AutoSize = true;
            this.l_response.Location = new System.Drawing.Point(7, 220);
            this.l_response.Name = "l_response";
            this.l_response.Size = new System.Drawing.Size(55, 13);
            this.l_response.TabIndex = 2;
            this.l_response.Text = "Response";
            // 
            // l_title
            // 
            this.l_title.AutoSize = true;
            this.l_title.Location = new System.Drawing.Point(7, 78);
            this.l_title.Name = "l_title";
            this.l_title.Size = new System.Drawing.Size(27, 13);
            this.l_title.TabIndex = 1;
            this.l_title.Text = "Title";
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Location = new System.Drawing.Point(6, 18);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(77, 13);
            this.l_id.TabIndex = 0;
            this.l_id.Text = "Ticket Number";
            // 
            // c_Messages
            // 
            this.c_Messages.BackColor = System.Drawing.SystemColors.Control;
            this.c_Messages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c_Messages.ConfigName = "TicketAdminResponseList";
            this.c_Messages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_Messages.Filter = null;
            this.c_Messages.Location = new System.Drawing.Point(3, 16);
            this.c_Messages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.c_Messages.Name = "c_Messages";
            this.c_Messages.Param1 = 0;
            this.c_Messages.Param2 = 0;
            this.c_Messages.Size = new System.Drawing.Size(549, 185);
            this.c_Messages.TabIndex = 9;
            this.c_Messages.Table = "XTICKET_MESSAGES";
            // 
            // l_tasks
            // 
            this.l_tasks.BackColor = System.Drawing.Color.Transparent;
            this.l_tasks.Controls.Add(this.c_Tasks);
            this.l_tasks.Location = new System.Drawing.Point(573, 434);
            this.l_tasks.Name = "l_tasks";
            this.l_tasks.Size = new System.Drawing.Size(503, 204);
            this.l_tasks.TabIndex = 1;
            this.l_tasks.TabStop = false;
            this.l_tasks.Text = "Tasks";
            // 
            // c_Tasks
            // 
            this.c_Tasks.BackColor = System.Drawing.SystemColors.Control;
            this.c_Tasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c_Tasks.ConfigName = "TicketAdminResponseList";
            this.c_Tasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_Tasks.Filter = null;
            this.c_Tasks.Location = new System.Drawing.Point(3, 16);
            this.c_Tasks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.c_Tasks.Name = "c_Tasks";
            this.c_Tasks.Param1 = 0;
            this.c_Tasks.Param2 = 0;
            this.c_Tasks.Size = new System.Drawing.Size(497, 185);
            this.c_Tasks.TabIndex = 9;
            this.c_Tasks.Table = "XTICKET_TASKS";
            // 
            // l_messages
            // 
            this.l_messages.BackColor = System.Drawing.Color.Transparent;
            this.l_messages.Controls.Add(this.c_Messages);
            this.l_messages.Location = new System.Drawing.Point(12, 434);
            this.l_messages.Name = "l_messages";
            this.l_messages.Size = new System.Drawing.Size(555, 204);
            this.l_messages.TabIndex = 1;
            this.l_messages.TabStop = false;
            this.l_messages.Text = "Messages";
            // 
            // TicketAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 650);
            this.Controls.Add(this.l_messages);
            this.Controls.Add(this.l_tasks);
            this.Controls.Add(this.l_ticket);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicketAdmin";
            this.Style = "Purple";
            this.Text = "Ticket (admin)";
            this.l_ticket.ResumeLayout(false);
            this.l_ticket.PerformLayout();
            this.l_tasks.ResumeLayout(false);
            this.l_messages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox l_ticket;
        private System.Windows.Forms.Label l_type;
        private System.Windows.Forms.Label l_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_response;
        private System.Windows.Forms.Label l_title;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.Label l_knowdb;
        private NetPlugins2.IcsDBList c_Messages;
        private NetPlugins2.IcsInteger c_id;
        private NetPlugins2.IcsStatus c_status;
        private System.Windows.Forms.TextBox c_Details;
        private System.Windows.Forms.TextBox c_Title;
        private NetPlugins2.IcsEditSelectDetach c_KnowDb;
        private System.Windows.Forms.TextBox c_Response;
        private System.Windows.Forms.GroupBox l_tasks;
        private System.Windows.Forms.GroupBox l_messages;
        private System.Windows.Forms.TextBox c_CreatedModified;
        private NetPlugins2.IcsEditSelectDetach c_RequestedFor;
        private System.Windows.Forms.Label l_requestedFor;
        private NetPlugins2.IcsEditSelectDetach c_RequestedBy;
        private NetPlugins2.IcsEditSelectDetach c_AssignedTo;
        private System.Windows.Forms.Label l_requestedBy;
        private System.Windows.Forms.Label l_assignedTo;
        private NetPlugins2.IcsDBList c_Tasks;
        private System.Windows.Forms.Button c_SaveExit;
        private System.Windows.Forms.Button c_CancelExit;
        private System.Windows.Forms.Button c_Save;
        private System.Windows.Forms.Label l_subcategory;
        private System.Windows.Forms.Label l_category;
        private NetPlugins2.IcsComboEdt c_subcategory;
        private NetPlugins2.IcsComboEdt c_type;
        private NetPlugins2.IcsComboEdt c_category;
    }
}