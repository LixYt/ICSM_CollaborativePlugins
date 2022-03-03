using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICSM;
using NetPlugins2;
using FormsCs;
using OrmCs;
using DatalayerCs;
using Image2;
using System.Windows.Forms;

namespace XICSM.TicketSystem
{
    public class Plugin : IPlugin
    {
        public string Description { get { return "Ticket System plugin"; } }
        public string Ident { get { return "TicketSystem"; } }
        public string Version = "0.0.0.0";

        public void RegisterSchema(IMSchema s) 
        {
            #region Tasks
            s.DeclareTable("XTICKET_TASKS|SOURCER", "Tickets Tasks", "PLUGIN_4,100");
            s.DeclareShortDesc("Tickets tasks table");
            s.DeclareFullDesc(
                 "Ticket = [Ticket.TITLE]\r\n"
                + "Task = [Name]\r\n"
                );
            s.DeclareField("ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareIndex("PK_XTICKET_TASK", "PRIMARY", "ID");

            s.DeclareField("TICKET_ID", "NUMBER(9,0)", null, null, null);
            s.DeclareJoin("Ticket", "XTICKET_TICKETS", "DBMS", "TICKET_ID", "ID"); s.Info(L.Txt("Ticket"));

            s.DeclareField("TYPE", "VARCHAR(250)", "lov_TaskType", null, null); s.Info(L.Txt("Type of task"));
            s.DeclareField("STATUS", "VARCHAR(250)", "stat_TASK", null, null); s.Info(L.Txt("Status of Task"));
            s.DeclareField("DETAILS", "VARCHAR(5000)", "Text", "NOTNULL", null); s.Info(L.Txt("Task Details"));

            s.DeclareField("ASSIGNED_TO_ID", "NUMBER(9,0)", null, null, null);
            s.DeclareField("ASSIGNED_TO_TABLE", "VARCHAR(50)", null, null, null);
            //s.DeclareJoin("AssignedTo", "ALL_PERSONS", "DBMS", "ASSIGNED_TO_ID,ASSIGNED_TO_TABLE", "TABLE_ID,TABLE_NAME"); s.Info(L.Txt("Ticket task assigned to person"));

            s.DeclareField("DATE_CREATED", "DATE", "Date", "NOTNULL", null); s.Info(L.Txt("Date/Time of creation"));
            s.DeclareField("CREATED_BY", "VARCHAR(30)", null, "NOTNULL", null); s.Info(L.Txt("Author"));
            s.DeclareField("DATE_MODIFIED", "DATE", "Date", "NOTNULL", null); s.Info(L.Txt("Date of modification"));
            s.DeclareField("MODIFIED_BY", "VARCHAR(30)", null, "NOTNULL", null); s.Info(L.Txt("Modified by"));
            #endregion

            #region Knowledge Database
            s.DeclareTable("XTICKET_KNOWDB|SOURCER", "Tickets Knowledge Database", "PLUGIN_4,100");
            s.DeclareShortDesc("Knowledge Database table");
            s.DeclareFullDesc(
                 "Title = [SUBJECT]\r\n"
                );
            s.DeclareField("ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareIndex("PK_XTICKET_KNOWDB", "PRIMARY", "ID");

            s.DeclareField("SUBJECT", "VARCHAR(250)", "lov_TaskType", null, null); s.Info(L.Txt("Subject"));
            s.DeclareField("STATUS", "VARCHAR(250)", "stat_TICKET", null, null); s.Info(L.Txt("Status of the knowledge entry"));
            s.DeclareField("TABLE_NAME", "VARCHAR(250)", null, null, null); s.Info(L.Txt("Table name related to this subject"));
            s.DeclareField("TOPIC", "VARCHAR(5000)", "Text", null, null); s.Info(L.Txt("Topic details"));

            s.DeclareField("DATE_CREATED", "DATE", "Date", "NOTNULL", null); s.Info(L.Txt("Date/Time of creation"));
            s.DeclareField("CREATED_BY", "VARCHAR(30)", null, "NOTNULL", null); s.Info(L.Txt("Author"));
            s.DeclareField("DATE_MODIFIED", "DATE", "Date", "NOTNULL", null); s.Info(L.Txt("Date of modification"));
            s.DeclareField("MODIFIED_BY", "VARCHAR(30)", null, "NOTNULL", null); s.Info(L.Txt("Modified by"));
            #endregion

            #region Tickets
            s.DeclareTable("XTICKET_TICKETS|SOURCER", "Tickets", "PLUGIN_4,100");
            s.DeclareShortDesc("Ticket table");
            s.DeclareFullDesc(
                 "Title = [TITLE]\r\n"
                + "Type = [TYPE], From = [AssignedTo.Name]\r\n"
                );
            s.DeclareField("ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareIndex("PK_XTICKET_TICKETS", "PRIMARY", "ID");

            s.DeclareField("TITLE", "VARCHAR(250)", "Text", "NOTNULL", null); s.Info(L.Txt("Ticket title"));
            s.DeclareField("TYPE", "VARCHAR(250)", "lov_TicketType", "NOTNULL", null); s.Info(L.Txt("Type of ticket"));
            s.DeclareField("CATEGORY", "VARCHAR(250)", "lov_CategoryTicket", null, null); s.Info(L.Txt("Category of the Ticket"));
            s.DeclareField("SUBCATEGORY", "VARCHAR(250)", "lov_SubCategoryTicket", null, null); s.Info(L.Txt("Subcategory of the Ticket"));
            s.DeclareField("STATUS", "VARCHAR(250)", "stat_TICKET", null, null); s.Info(L.Txt("Status of ticket"));
            s.DeclareField("DETAILS", "VARCHAR(5000)", "Text", "NOTNULL", null); s.Info(L.Txt("Ticket Details"));
            s.DeclareField("RESPONSE", "VARCHAR(5000)", "Text", null, null); s.Info(L.Txt("Ticket Response"));
            s.DeclareField("KNOWLEDGE_ID", "NUMBER(9,0)", null, null, null);
            s.DeclareJoin("KnowledgeDatabase", "XTICKET_KNOWDB", "DBMS", "KNOWLEDGE_ID", "ID"); s.Info(L.Txt("A subject from the Knowledge DB"));

            s.DeclareField("ASSIGNED_TO_ID", "NUMBER(9,0)", null, null, null);
            s.DeclareField("ASSIGNED_TO_TABLE", "VARCHAR(50)", null, null, null);
            //s.DeclareJoin("AssignedTo", "ALL_PERSONS", "DBMS", "ASSIGNED_TO_ID,ASSIGNED_TO_TABLE", "TABLE_ID,TABLE_NAME"); s.Info(L.Txt("Ticket Assigned To Person"));
            s.DeclareField("REQUESTED_BY_ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareField("REQUESTED_BY_TABLE", "VARCHAR(50)", null, null, null);
            //s.DeclareJoin("RequestedBy", "ALL_PERSONS", "DBMS", "REQUESTED_BY_ID,REQUESTED_BY_TABLE", "TABLE_ID,TABLE_NAME"); s.Info(L.Txt("Ticket Requested By Person"));
            s.DeclareField("REQUESTED_FOR_ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareField("REQUESTED_FOR_TABLE", "VARCHAR(50)", null, null, null);
            //s.DeclareJoin("RequestedFor", "ALL_PERSONS", "DBMS", "REQUESTED_FOR_ID,REQUESTED_FOR_TABLE", "TABLE_ID,TABLE_NAME"); s.Info(L.Txt("Ticket Requested For Person"));

            s.DeclareField("DATE_CREATED", "DATE", "Date", "NOTNULL", null); s.Info(L.Txt("Date/Time of creation"));
            s.DeclareField("CREATED_BY", "VARCHAR(30)", null, "NOTNULL", null); s.Info(L.Txt("Author"));
            s.DeclareField("DATE_MODIFIED", "DATE", "Date", "NOTNULL", null); s.Info(L.Txt("Date of modification"));
            s.DeclareField("MODIFIED_BY", "VARCHAR(30)", null, "NOTNULL", null); s.Info(L.Txt("Modified by"));
            #endregion

            #region Messages
            s.DeclareTable("XTICKET_MESSAGES|SOURCER", "Tickets messages", "PLUGIN_4,100");
            s.DeclareShortDesc("Tickets messages table");
            s.DeclareFullDesc(
                 "Ticket = [Ticket.TITLE]\r\n"
                );
            s.DeclareField("ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareIndex("PK_XTICKET_MESSAGE", "PRIMARY", "ID");

            s.DeclareField("TICKET_ID", "NUMBER(9,0)", null, null, null);
            s.DeclareJoin("Ticket", "XTICKET_TICKETS", "DBMS", "TICKET_ID", "ID"); s.Info(L.Txt("Ticket"));

            s.DeclareField("MESSAGE_FROM_ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareField("MESSAGE_FROM_TABLE", "VARCHAR(50)", null, "NOTNULL", null);
            //s.DeclareJoin("MessageFrom", "ALL_PERSONS", "DBMS", "MESSAGE_FROM_ID,MESSAGE_FROM_TABLE", "TABLE_ID,TABLE_NAME"); s.Info(L.Txt("Message From"));
            s.DeclareField("MESSAGE_TO_ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareField("MESSAGE_TO_TABLE", "VARCHAR(50)", null, "NOTNULL", null);
            //s.DeclareJoin("MessageTo", "ALL_PERSONS", "DBMS", "MESSAGE_TO_ID,MESSAGE_TO_TABLE", "TABLE_ID,TABLE_NAME"); s.Info(L.Txt("Message To"));

            s.DeclareField("MESSAGE", "VARCHAR(5000)", "Text", "NOTNULL", null); s.Info(L.Txt("Ticket Message"));

            s.DeclareField("DATE_CREATED", "DATE", "Date", "NOTNULL", null); s.Info(L.Txt("Date/Time of creation"));
            s.DeclareField("CREATED_BY", "VARCHAR(30)", null, "NOTNULL", null); s.Info(L.Txt("Author"));
            s.DeclareField("DATE_MODIFIED", "DATE", "Date", "NOTNULL", null); s.Info(L.Txt("Date of modification"));
            s.DeclareField("MODIFIED_BY", "VARCHAR(30)", null, "NOTNULL", null); s.Info(L.Txt("Modified by"));
            #endregion
            
            string appFolder = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            if (!OrmCs.OrmSchema.ParseSchema(appFolder, "TicketSystem", "XICSM_TicketSystem", out string err)) 
                MessageBox.Show("Unable to load 'TicketSystem.Schema' :" + err);


        }
        public double SchemaVersion { get { return 20220301.2007; } }
        public void RegisterBoard(IMBoard b)
        {
            b.RegisterQueryMenuBuilder("XTICKET_TICKETS", onGetQueryMenu);

        }
        public static List<IMQueryMenuNode> onGetQueryMenu(string tableName, int nbSelMin)
        {
            List<IMQueryMenuNode> lst = new List<IMQueryMenuNode>();
            if (tableName == "XTICKET_TICKETS")
            {
                lst.Add(new IMQueryMenuNode(L.Txt("New ticket"), null, Forms.TicketAdmin.NewRecord, IMQueryMenuNode.ExecMode.Table));
                if (nbSelMin == 1)
                {
                    lst.Add(new IMQueryMenuNode(L.Txt("Edit ticket"), null, Forms.TicketAdmin.EditRecord, IMQueryMenuNode.ExecMode.FirstRecord));
                }
                if (nbSelMin > 1)
                {

                }
            }

            return lst;
        }
        public void GetMainMenu(IMMainMenu mainMenu) 
        {
           mainMenu.SetInsertLocation("Tools", IMMainMenu.InsertLocation.Before);
           mainMenu.InsertItem("Ticket\\" + $"{Description} " + L.TxT("Version"), VersionInfo, "XMISC_TRANSLATIONS");
           mainMenu.InsertItem("Ticket\\" + $"{Description} " + L.TxT("Help and resources"), PluginResources, "XMISC_TRANSLATIONS");
        }
        public bool OtherMessage(string message, object inParam, ref object outParam) 
        {
            outParam = null;
            if (message == "EditRecord")
            {
                IntPtr owner = (IntPtr)IM.GetMainWindow();
                string[] s = ((string)inParam).Split('/');
                int id = s[1].Substring(1).ParseInt();
                bool ro = s[2] == "true"; //Readonly
                if (s[0] == "XTICKET_TICKETS") { outParam = Forms.TicketAdmin.EditRecord(id, owner); return true; }
                return false;
            }

            return false;
        }
        public bool UpgradeDatabase(IMSchema s, double dbCurVersion) 
        {
            if (dbCurVersion < 20210923.0000)
            {
                s.CreateTables("XTICKET_KNOWDB");
                s.CreateTables("XTICKET_TASK");
                s.CreateTables("XTICKET_TICKETS");
                s.CreateTables("XTICKET_MESSAGES");
                s.SetDatabaseVersion(20210923.0000);
            }
            if (dbCurVersion < 20220301.2007)
            {
                s.DeleteTables("XTICKET_KNOWDB,XTICKET_TASK,XTICKET_TICKETS,XTICKET_MESSAGES", false);
                s.CreateTables("XTICKET_KNOWDB");
                s.CreateTables("XTICKET_TASK");
                s.CreateTables("XTICKET_TICKETS");
                s.CreateTables("XTICKET_MESSAGES");
                s.SetDatabaseVersion(20220301.2007);
            }

            return true;
        }

        #region Translations
        #endregion
        public void VersionInfo()
        { MessageBox.Show(L.Txt("Plugin version is : " + Version) + L.Txt("\r\nPlugin schema version is : ") + 20210615.00) ; }
        public void PluginResources()
        { System.Diagnostics.Process.Start("https://github.com/LixYt/ICSM_CollaborativePlugins"); }
        
    }
}
