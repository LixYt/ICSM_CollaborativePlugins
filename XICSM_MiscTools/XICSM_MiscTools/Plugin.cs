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

namespace XICSM.MiscTools
{
    public class Plugin : IPlugin
    {
        public string Description { get { return "Miscellaneous Tools"; } }
        public string Ident { get { return "MiscTools"; } }
        public string Version = "1.0.1.0";

        public void RegisterSchema(IMSchema s) 
        {
            #region QUERYSTORE
            s.DeclareTable("XMISC_QUERYSTORE|SOURCER", "Configuration store", "PLUGIN_4,100");
            s.DeclareShortDesc("Configuration store");
            s.DeclareFullDesc(
                 "Query = [ITEMSTORE]\r\n"
                + "Table = [TABLE_NAME], Type = [TYPE]\r\n"
                + "Description = [DESCRIPTION]");
            s.DeclareField("ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareIndex("PK_XMISC_QUERYSTORE", "PRIMARY", "ID");
            s.DeclareField("NAME", "VARCHAR(250)", "Text", null, null); s.Info("Title of this query configuration");
            s.DeclareField("TYPE", "VARCHAR(250)", "eri_QueryStoreType", null, null); s.Info("Type of element");
            s.DeclareField("TABLE_NAME", "VARCHAR(250)", null, null, null); s.Info("Source table of this configuration");
            s.DeclareField("DESCRIPTION", "VARCHAR(5000)", "Text", null, null); s.Info("Short description of this configuration");
            s.DeclareField("ITEMSTORE", "VARCHAR(8000)", "Text", null, null); s.Info("Configuration or item stored");
            s.DeclareField("DATE_CREATED", "DATE", "Date", null, null); s.Info("Date/Time of creation");
            s.DeclareField("CREATED_BY", "VARCHAR(30)", null, null, null); s.Info("Author");
            s.DeclareField("DATE_MODIFIED", "DATE", "Date", null, null); s.Info("Date of modification");
            s.DeclareField("MODIFIED_BY", "VARCHAR(30)", null, null, null); s.Info("Modified by");
            #endregion

            #region TRANSLATIONS
            s.DeclareTable("XMISC_TRANSLATIONS|SOURCER", "Translation tool", "PLUGIN_4,100");
            s.DeclareShortDesc("Table to import, edit and update translation files.");
            s.DeclareFullDesc(
                 "Source file = \r\n"
                + "Language = [LANG]");
            s.DeclareField("ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareIndex("PK_XMISC_TRANSLATIONS", "PRIMARY", "ID");
            s.DeclareField("IMPOP_ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareJoin("Import Operations", "IMPORT_OP", "DBMS", "IMPOP_ID", "ID");
            s.DeclareField("LANG", "VARCHAR(50)", null, null, null); s.Info("Translation Language");
            s.DeclareField("FROM_STRING", "VARCHAR(255)", null, "NOTNULL", null); s.Info("Original String in ICSM");
            s.DeclareField("TO_STRING", "VARCHAR(255)", null, null, null); s.Info("Translated String in ICSM");
            s.DeclareField("isFromStrings", "NUMBER(1,0)", "Bool", "NOTNULL", "0"); s.Info("This translation was added from STRINGS file");
            s.DeclareField("isObsolete", "NUMBER(1,0)", "Bool", "NOTNULL", "0"); s.Info("This translation was missing from STRINGS file");
            s.DeclareField("isCustomF", "NUMBER(1,0)", "Bool", "NOTNULL", "0"); s.Info("This translation is a Custom field (CUST_xxx in DB)");
            #endregion

            #region MGT_PLANNING
            /*s.DeclareTable("XMISC_EVENTTYPE|SOURCER", "Shared agenda event type", "PLUGIN_4,100");
            s.DeclareShortDesc("Shared agen event type configuration");
            s.DeclareFullDesc(
                 "Type of event = [EVENTTYPE_NAME]\r\n"
                + "Description = [DESCRIPTION]");
            s.DeclareField("ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareIndex("PK_MGT_XMISC_EVENTTYPE", "PRIMARY", "ID");
            s.DeclareField("EVENTTYPE_NAME", "VARCHAR(100)", null, null, null); s.Info("Name the event type");
            s.DeclareField("DESCRIPTION", "VARCHAR(500)", null, null, null);
            s.DeclareField("COLOR", "NUMBER(9,0)", null, null, null); s.Info("Windows color système");
            s.DeclareField("ACTIVE", "NUMBER(1,0)", "eri_NoYes", null, null); s.Info("Can this event type be used ?");
            s.DeclareField("IS_ONSITE", "NUMBER(1,0)", "eri_NoYes", null, null); s.Info("Is employee on working site ?");
            s.DeclareField("IS_WORKING", "NUMBER(1,0)", "eri_NoYes", null, null); s.Info("Is employee working ?");
            s.DeclareField("REQUIRE_VALIDATION", "NUMBER(1,0)", "eri_NoYes", null, null); s.Info("Does the event require validation ?");
            s.DeclareField("MAXDAY", "NUMBER(3,0)", "Integer", null, null); s.Info("How many day the employee can use this event type in the agenda");
            s.DeclareField("DATE_CREATED", "DATE", "Date", null, null); s.Info("Date/Time of creation");
            s.DeclareField("CREATED_BY", "VARCHAR(30)", null, null, null); s.Info("Author");
            s.DeclareField("DATE_MODIFIED", "DATE", "Date", null, null); s.Info("Date of modification");
            s.DeclareField("MODIFIED_BY", "VARCHAR(30)", null, null, null); s.Info("Modified by");*/
            #endregion

            #region MGT_SHAREDAGENDA
            /*s.DeclareTable("XMISC_SHAREDAGENGA|SOURCER", "Shared agenda", "PLUGIN_4,100");
            s.DeclareShortDesc("Shared agenda");
            s.DeclareFullDesc(
                 "From [DATE_BEGIN] to [DATE_END] \r\n" +
                 "Employee = [Employee.Name] \r\n" +
                 "Event [EventType.EVENTTYPE_NAME]");
            s.DeclareField("ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareIndex("PK_XMISC_QUERYSTORE", "PRIMARY", "ID");
            s.DeclareField("DATE_BEGIN", "DATETIME", null, null, null); s.Info("Title of this query configuration");
            s.DeclareField("DATE_END", "DATETIME", null, null, null); s.Info("Title of this query configuration");
            s.DeclareField("STATUS", "VARCHAR(4)", "stat_SHAREDAGENDA", null, null); s.Info("Status");
            s.DeclareField("XMISC_EVENTTYPE_ID", "NUMBER(9,0)", null, null, null);
            s.DeclareJoin("EventType", "XMISC_EVENTTYPE", "DBMS", "XMISC_EVENTTYPE_ID", "ID");
            s.DeclareField("EMPLOYEE_ID", "NUMBER(9,0)", null, null, null);
            s.DeclareJoin("Employee", "EMPLOYEE", "DBMS", "EMPLOYEE_ID", "ID");
            s.DeclareField("VALI_EMPLOYEE_ID", "NUMBER(9,0)", null, null, null);
            s.DeclareJoin("Validator", "EMPLOYEE", "DBMS", "VALI_EMPLOYEE_ID", "ID");
            s.DeclareField("VALIDATED", "NUMBER(1,0)", "eri_NoYes", null, null); s.Info("Is this event validated ?");
            s.DeclareField("DATE_CREATED", "DATE", "Date", null, null); s.Info("Date/Time of creation");
            s.DeclareField("CREATED_BY", "VARCHAR(30)", null, null, null); s.Info("Author");
            s.DeclareField("DATE_MODIFIED", "DATE", "Date", null, null); s.Info("Date of modification");
            s.DeclareField("MODIFIED_BY", "VARCHAR(30)", null, null, null); s.Info("Modified by");*/
            #endregion


            string appFolder = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            if (!OrmCs.OrmSchema.ParseSchema(appFolder, "MiscTools", "XICSM_MiscTools", out string err)) MessageBox.Show("Unable to load 'MiscTools.Schema' :" + err);


        }
        public double SchemaVersion { get { return 20210917.1901; } }
        public void RegisterBoard(IMBoard b)
        {
            b.RegisterQueryMenuBuilder("MICROWA", Contextual.onGetQueryMenu);
            b.RegisterQueryMenuBuilder("XMISC_QUERYSTORE", Contextual.onGetQueryMenu);
            b.RegisterQueryMenuBuilder("XMISC_TRANSLATIONS", Contextual.onGetQueryMenu);
        }
        public void GetMainMenu(IMMainMenu mainMenu) 
        {
           mainMenu.SetInsertLocation("Tools\\Administrator\\*", IMMainMenu.InsertLocation.After);
           mainMenu.InsertItem("Tools\\Translations\\" + L.Txt("Import SYS_LANG file in Translation table"), ImportLangFile, "XMISC_TRANSLATIONS");
           mainMenu.InsertItem("Tools\\Translations\\" + L.Txt("Export Translation records to SYS_LANG file"), ExportLangFile, "XMISC_TRANSLATIONS");
           mainMenu.InsertItem("Tools\\Translations\\" + L.Txt("Consolidate importe translation with STRINGS file"), ImportSTRINGSFile, "XMISC_TRANSLATIONS");
           mainMenu.InsertItem("Help\\Translations\\" + $"{Description}" + L.TxT("Version"), VersionInfo, "XMISC_TRANSLATIONS");
           mainMenu.InsertItem("Help\\Translations\\" + $"{Description}" + L.TxT("Help and resources"), PluginResources, "XMISC_TRANSLATIONS");
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
                if (s[0] == "XMISC_TRANSLATIONS") { outParam = TranslationEditor.EditRecord(id, owner); return true; }
                if (s[0] == "XMISC_QUERYSTORE") { outParam = QueryStoreEditor.EditRecord(id, owner); return true; }
                return false;
            }

            return false; 
        }
        public bool UpgradeDatabase(IMSchema s, double dbCurVersion) 
        {
            if (dbCurVersion < 20210615.00)
            {
                s.CreateTables("XMISC_QUERYSTORE");
                s.CreateTables("XMISC_TRANSLATIONS");
            }
            if (dbCurVersion < 20210917.1901)
            {
                s.CreateTableFields("XMISC_TRANSLATIONS", "isFromStrings,isObsolete,isCustomF");
            }

            s.SetDatabaseVersion(20210917.1901);
            return true;
        }
        
        #region Translations
        public void ImportLangFile()
        {
            Translations.ImportFile();
        }
        public void ImportSTRINGSFile()
        {
            Translations.ImportStrings();
        }
        public void ExportLangFile()
        {
            Translations.ExportFile();
        }
        #endregion


        public void VersionInfo()
        { MessageBox.Show(L.Txt("Plugin version is : " + Version) + L.Txt("\r\nPlugin schema version is : ") + 20210615.00) ; }
        public void PluginResources()
        {
            MessageBox.Show("A github page will open in your default browser. Feel free to give feedback and hints on this tool.");
            System.Diagnostics.Process.Start("https://github.com/LixYt/ICSM_CollaborativePlugins"); }
        
    }
}
