using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrmCs;
using FormsCs;
using ICSM;
using NetPlugins2;

namespace XICSM.TicketSystem.Forms
{
    public partial class TicketAdmin : EntityMainMetroForm
    {
        private YXticketTickets Ticket;
        static public bool NewRecord(IMQueryMenuNode.Context context)
        {
            YXticketTickets y = new YXticketTickets();
            TicketAdmin edt = new TicketAdmin(y);

            return (edt.ShowDialog() == DialogResult.OK ? true : false); //Return true if query should be refreshed due to modification of some record(s)
        }
        static public bool EditRecord(IMQueryMenuNode.Context context)
        {
            YXticketTickets y = new YXticketTickets(); y.Fetch(context.TableId);
            TicketAdmin edt = new TicketAdmin(y);
            return (edt.ShowDialog() == DialogResult.OK ? true : false); //Return true if query should be refreshed due to modification of some record(s)
        }
        public static bool EditRecord(int isId, IntPtr owner)
        {
            if (isId.IsNull()) return false;
            Cursor.Current = Cursors.WaitCursor;
            YXticketTickets y = new YXticketTickets();
            y.Fetch(isId);
            TicketAdmin dlg = new TicketAdmin(y);
            EntityEditOptions opt = new EntityEditOptions();
            opt.CurForm = owner;
            return dlg.Edit("XTICKET_TICKETS", isId, opt);
        }

        public TicketAdmin(YXticketTickets y)
        {
            InitializeComponent();
            Ticket = y;

            c_id.DataBindings.Add("Value", Ticket, "m_id", false, DataSourceUpdateMode.OnPropertyChanged);
            c_type.DataBindings.Add("Value", Ticket, "m_type", false, DataSourceUpdateMode.OnPropertyChanged);
            c_Title.DataBindings.Add("Text", Ticket, "m_title", false, DataSourceUpdateMode.OnPropertyChanged);
            c_status.DataBindings.Add("Value", Ticket, "m_status", false, DataSourceUpdateMode.OnPropertyChanged);
            c_category.DataBindings.Add("Value", Ticket, "m_category", false, DataSourceUpdateMode.OnPropertyChanged);
            c_subcategory.DataBindings.Add("Value", Ticket, "m_subcategory", false, DataSourceUpdateMode.OnPropertyChanged);
            c_Details.DataBindings.Add("Text", Ticket, "m_details", false, DataSourceUpdateMode.OnPropertyChanged);
            c_Response.DataBindings.Add("Text", Ticket, "m_response", false, DataSourceUpdateMode.OnPropertyChanged);
            c_KnowDb.DataBindings.Add("ID", Ticket, "m_knowledge_id", false, DataSourceUpdateMode.OnPropertyChanged);
            c_AssignedTo.DataBindings.Add("ID", Ticket, "m_assigned_to_id", false, DataSourceUpdateMode.OnPropertyChanged);
            c_AssignedTo.DataBindings.Add("table", Ticket, "m_assigned_to_table", false, DataSourceUpdateMode.OnPropertyChanged);
            c_RequestedBy.DataBindings.Add("ID", Ticket, "m_requested_by_id", false, DataSourceUpdateMode.OnPropertyChanged);
            c_RequestedBy.DataBindings.Add("table", Ticket, "m_requested_by_table", false, DataSourceUpdateMode.OnPropertyChanged);
            c_RequestedFor.DataBindings.Add("ID", Ticket, "m_requested_for_id", false, DataSourceUpdateMode.OnPropertyChanged);
            c_RequestedFor.DataBindings.Add("table", Ticket, "m_requested_for_table", false, DataSourceUpdateMode.OnPropertyChanged);

            c_CreatedModified.Text = $"{Ticket.m_created_by} {Ticket.m_date_created}\r\n";
            c_CreatedModified.Text += $"{Ticket.m_modified_by} {Ticket.m_date_modified}";

            c_Messages.Init(); c_Messages.SetFilter($"Ticket_ID = {Ticket.m_id}");
            c_Tasks.Init(); c_Tasks.SetFilter($"Ticket_ID = {Ticket.m_id}");

        }

        private void c_SaveExit_Click(object sender, EventArgs e)
        {
            Ticket.New();
            Ticket.AllocID();
            Ticket.CreatedByModifiedBy();
            Ticket.Save();  
        }
    }
}
