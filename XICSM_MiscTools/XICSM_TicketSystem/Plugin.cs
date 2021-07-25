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
            #region Tickets
            s.DeclareTable("XTICKET_TICKETS|SOURCER", "Tickets", "PLUGIN_4,100");
            s.DeclareShortDesc("Ticket table");
            s.DeclareFullDesc(
                 "Title = [TITLE]\r\n"
                + "Type = [TYPE], From = [AsignedTo.Name]\r\n"
                );
            s.DeclareField("ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareIndex("PK_XTICKET_TICKETS", "PRIMARY", "ID");
            
            s.DeclareField("TITLE", "VARCHAR(250)", "Text", null, null); s.Info(L.Txt("Ticket title"));
            s.DeclareField("TYPE", "VARCHAR(250)", "lov_TicketType", null, null); s.Info(L.Txt("Type of ticket"));
            s.DeclareField("STATUS", "VARCHAR(250)", "stat_TICKET", null, null); s.Info(L.Txt("Status of ticket"));
            s.DeclareField("DETAILS", "VARCHAR(5000)", "Text", null, null); s.Info(L.Txt("Ticket Details"));
            s.DeclareField("RESPONSE", "VARCHAR(5000)", "Text", null, null); s.Info(L.Txt("Ticket Response"));
            s.DeclareField("KNOWLEDGE_ID", "NUMBER(9,0)", null, null, null);
            s.DeclareJoin("KnowledgeDatabase", "XTICKET_KNOWDB", "DBMS", "KNOWLEDGE_ID", "ID"); s.Info(L.Txt("A subject from the Knowledge DB"));

            s.DeclareField("ASSIGNED_TO_ID", "NUMBER(9,0)", null, null, null);
            s.DeclareJoin("AssignedTo", "ALL_PERSONS", "DBMS", "ASSIGNED_TO_ID", "ID"); s.Info(L.Txt("Ticket Assigned To Person"));
            s.DeclareField("REQUESTED_BY_ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareJoin("RequestedBy", "ALL_PERSONS", "DBMS", "REQUESTED_BY_ID", "ID"); s.Info(L.Txt("Ticket Requested By Person"));
            s.DeclareField("REQUESTED_FOR_ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareJoin("RequestedFor", "ALL_PERSONS", "DBMS", "REQUESTED_FOR_ID", "ID"); s.Info(L.Txt("Ticket Requested For Person"));

            s.DeclareField("DATE_CREATED", "DATE", "Date", null, null); s.Info(L.Txt("Date/Time of creation"));
            s.DeclareField("CREATED_BY", "VARCHAR(30)", null, null, null); s.Info(L.Txt("Author"));
            s.DeclareField("DATE_MODIFIED", "DATE", "Date", null, null); s.Info(L.Txt("Date of modification"));
            s.DeclareField("MODIFIED_BY", "VARCHAR(30)", null, null, null); s.Info(L.Txt("Modified by"));
            #endregion

            #region Messages
            s.DeclareTable("XTICKET_MESSAGES|SOURCER", "Tickets", "PLUGIN_4,100");
            s.DeclareShortDesc("Tickets messages table");
            s.DeclareFullDesc(
                 "Ticket = [Ticket.TITLE]\r\n"
                );
            s.DeclareField("ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareIndex("PK_XTICKET_MESSAGE", "PRIMARY", "ID");

            s.DeclareField("TICKET_ID", "NUMBER(9,0)", null, null, null);
            s.DeclareJoin("Ticket", "XTICKET_TICKETS", "DBMS", "TICKET_ID", "ID"); s.Info(L.Txt("Ticket"));

            s.DeclareField("MESSAGE_FROM_ID", "NUMBER(9,0)", null, null, null);
            s.DeclareJoin("MessageFrom", "ALL_PERSONS", "DBMS", "MESSAGE_FROM_ID", "ID"); s.Info(L.Txt("Message From"));
            s.DeclareField("MESSAGE_TO_ID", "NUMBER(9,0)", null, null, null);
            s.DeclareJoin("MessageTo", "ALL_PERSONS", "DBMS", "MESSAGE_TO_ID", "ID"); s.Info(L.Txt("Message To"));

            s.DeclareField("MESSAGE", "VARCHAR(5000)", "Text", null, null); s.Info(L.Txt("Ticket Message"));

            s.DeclareField("DATE_CREATED", "DATE", "Date", null, null); s.Info(L.Txt("Date/Time of creation"));
            s.DeclareField("CREATED_BY", "VARCHAR(30)", null, null, null); s.Info(L.Txt("Author"));
            s.DeclareField("DATE_MODIFIED", "DATE", "Date", null, null); s.Info(L.Txt("Date of modification"));
            s.DeclareField("MODIFIED_BY", "VARCHAR(30)", null, null, null); s.Info(L.Txt("Modified by"));
            #endregion

            #region Tasks
            s.DeclareTable("XTICKET_TASK|SOURCER", "Tickets", "PLUGIN_4,100");
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
            s.DeclareField("DETAILS", "VARCHAR(5000)", "Text", null, null); s.Info(L.Txt("Task Details"));

            s.DeclareField("ASSIGNED_TO_ID", "NUMBER(9,0)", null, null, null);
            s.DeclareJoin("AssignedTo", "ALL_PERSONS", "DBMS", "ASSIGNED_TO_ID", "ID"); s.Info(L.Txt("Ticket task assigned to person"));

            s.DeclareField("DATE_CREATED", "DATE", "Date", null, null); s.Info(L.Txt("Date/Time of creation"));
            s.DeclareField("CREATED_BY", "VARCHAR(30)", null, null, null); s.Info(L.Txt("Author"));
            s.DeclareField("DATE_MODIFIED", "DATE", "Date", null, null); s.Info(L.Txt("Date of modification"));
            s.DeclareField("MODIFIED_BY", "VARCHAR(30)", null, null, null); s.Info(L.Txt("Modified by"));
            #endregion

            #region Knowledge Database
            s.DeclareTable("XTICKET_KNOWDB|SOURCER", "Tickets", "PLUGIN_4,100");
            s.DeclareShortDesc("Knowledge Database table");
            s.DeclareFullDesc(
                 "Title = [SUBJECT]\r\n"
                );
            s.DeclareField("ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareIndex("PK_XTICKET_TASK", "PRIMARY", "ID");

            s.DeclareField("SUBJECT", "VARCHAR(250)", "lov_TaskType", null, null); s.Info(L.Txt("Subject"));
            s.DeclareField("TABLE_NAME", "VARCHAR(250)", null, null, null); s.Info(L.Txt("Table name related to this subject"));
            s.DeclareField("TOPIC", "VARCHAR(5000)", "Text", null, null); s.Info(L.Txt("Topic details"));

            s.DeclareField("DATE_CREATED", "DATE", "Date", null, null); s.Info(L.Txt("Date/Time of creation"));
            s.DeclareField("CREATED_BY", "VARCHAR(30)", null, null, null); s.Info(L.Txt("Author"));
            s.DeclareField("DATE_MODIFIED", "DATE", "Date", null, null); s.Info(L.Txt("Date of modification"));
            s.DeclareField("MODIFIED_BY", "VARCHAR(30)", null, null, null); s.Info(L.Txt("Modified by"));
            #endregion



            string appFolder = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            if (!OrmCs.OrmSchema.ParseSchema(appFolder, "TicketSystem", "XICSM_TicketSystem", out string err)) MessageBox.Show("Unable to load 'MiscTools.Schema' :" + err);


        }
        public double SchemaVersion { get { return 20210722.0000; } }
        public void RegisterBoard(IMBoard b)
        {
           
            
        }
        public void GetMainMenu(IMMainMenu mainMenu) 
        {
           mainMenu.SetInsertLocation("Ticket\\*", IMMainMenu.InsertLocation.After);
           mainMenu.InsertItem("Ticket\\" + $"{Description} Version", VersionInfo, "XMISC_TRANSLATIONS");
           mainMenu.InsertItem("Ticket\\" + $"{Description} Help and resources", PluginResources, "XMISC_TRANSLATIONS");
        }
        public bool OtherMessage(string message, object inParam, ref object outParam) 
        {
            return false; 
        }
        public bool UpgradeDatabase(IMSchema s, double dbCurVersion) 
        {
            if (dbCurVersion < 20210722.0000)
            {
                s.CreateTables("XTICKET_TICKETS");
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
