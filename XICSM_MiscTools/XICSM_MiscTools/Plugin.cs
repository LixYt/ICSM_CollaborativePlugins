using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICSM;
using OrmCs;
using DatalayerCs;
using NetPlugins2;
using System.Windows.Forms;
using XICSM.PluginManager;
using System.Diagnostics;

namespace XICSM.MiscTools
{
    public class Plugin : IPlugin, IPluginDetails
    {
        public int Interface => 2;
        DateTime IPlugin.Version => new DateTime(2023, 2, 15, 10, 34, 0);

        public string Description { get { return "Miscellaneous Tools"; } }
        public string Ident { get { return "MiscTools"; } }
        public string MenuGroupName { get { return "Miscellaneous"; } }
        public string Version = "1.1.0.0";

        public void RegisterSchema(IMSchema s) 
        {
            #region QUERYSTORE
            s.DeclareTable("XMISC_QUERYSTORE|SOURCER", L.Txt("Queries and customizations"), "PLUGIN_4,100");
            s.DeclareShortDesc(L.Txt("Query and query customization sharing table"));
            s.DeclareFullDesc(
                 "Query = [ITEMSTORE]\r\n"
                + "Table = [TABLE_NAME], Type = [TYPE]\r\n"
                + "Description = [DESCRIPTION]");
            s.DeclareField("ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareIndex("PK_XMISC_QUERYSTORE", "PRIMARY", "ID");
            s.DeclareField("NAME", "VARCHAR(250)", "Text", "NOTNULL", null); s.Info(L.TxT("Title of this query configuration"));
            s.DeclareField("TYPE", "VARCHAR(250)", "eri_QueryStoreType", null, null); s.Info(L.TxT("Type of element"));
            s.DeclareField("TABLE_NAME", "VARCHAR(250)", null, "NOTNULL", null); s.Info(L.TxT("Source table of this configuration"));
            s.DeclareField("DESCRIPTION", "VARCHAR(5000)", "Text", null, null); s.Info(L.TxT("Short description of this configuration"));
            s.DeclareField("ITEMSTORE", "VARCHAR(8000)", "Text", null, null); s.Info(L.TxT("Configuration or item stored"));
            s.DeclareField("ENGINE", "VARCHAR(1000)", "eri_DbEngines", "NOTNULL", null); s.Info(L.TxT("Database engine comaptibility"));
            s.DeclareField("DATE_CREATED", "DATE", "Date", null, null); s.Info(L.TxT("Date/Time of creation"));
            s.DeclareField("CREATED_BY", "VARCHAR(30)", null, null, null); s.Info(L.TxT("Author"));
            s.DeclareField("DATE_MODIFIED", "DATE", "Date", null, null); s.Info(L.TxT("Date of modification"));
            s.DeclareField("MODIFIED_BY", "VARCHAR(30)", null, null, null); s.Info(L.TxT("Modified by"));
            #endregion

            #region TRANSLATIONS
            s.DeclareTable("XMISC_TRANSLATIONS|SOURCER", L.Txt("Translations tool"), "PLUGIN_4,100");
            s.DeclareShortDesc(L.Txt("Table to import, edit and update translation files."));
            s.DeclareFullDesc(
                 "Source file = \r\n"
                + "Language = [LANG]");
            s.DeclareField("ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareIndex("PK_XMISC_TRANSLATIONS", "PRIMARY", "ID");
            s.DeclareField("IMPOP_ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareJoin("Import Operations", "IMPORT_OP", "DBMS", "IMPOP_ID", "ID");
            s.DeclareField("LANG", "VARCHAR(50)", null, null, null); s.Info(L.TxT("Translation Language"));
            s.DeclareField("FROM_STRING", "VARCHAR(255)", null, "NOTNULL", null); s.Info(L.TxT("Original String in ICSM"));
            s.DeclareField("TO_STRING", "VARCHAR(255)", null, null, null); s.Info(L.TxT("Translated String in ICSM"));
            s.DeclareField("isFromStrings", "NUMBER(1,0)", "Bool", "NOTNULL", "0"); s.Info(L.TxT("New String - This translation was added from STRINGS file"));
            s.DeclareField("isObsolete", "NUMBER(1,0)", "Bool", "NOTNULL", "0"); s.Info(L.TxT("Deleted string - This translation was missing in STRINGS file"));
            s.DeclareField("isCustomF", "NUMBER(1,0)", "Bool", "NOTNULL", "0"); s.Info(L.TxT("Cust_* - This translation is a Custom field (CUST_xxx in DB)"));
            #endregion

            string appFolder = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            if (!OrmCs.OrmSchema.ParseSchema(appFolder, "MiscTools", "XICSM_MiscTools", out string err)) MessageBox.Show(L.TxT("Unable to load 'MiscTools.Schema' :") + err);
        }
        public double SchemaVersion { get { return 20221015.1503; } }

        public string GitURL => "https://github.com/LixYt/ICSM_CollaborativePlugins";

        public string DocumentationUrl => "https://github.com/LixYt/ICSM_CollaborativePlugins/wiki/Misc-Plugin";

        public void RegisterBoard(IMBoard b)
        {
            b.RegisterQueryMenuBuilder("XMISC_QUERYSTORE", Contextual.onGetQueryMenu);
            b.RegisterQueryMenuBuilder("XMISC_TRANSLATIONS", Contextual.onGetQueryMenu);
        }
        public void GetMainMenu(IMMainMenu mainMenu) 
        {
            if (PluginsManager.UserCanUseFeature("MiscTools", "Translations"))
            {
                string TranslationName = L.TxT("Translations");
                mainMenu.SetInsertLocation("Tools\\Administrator", IMMainMenu.InsertLocation.After);
                mainMenu.InsertItem("Tools\\" + TranslationName + "\\" + L.Txt("Import SYS_LANG file in Translation table"), ImportLangFile, "XMISC_TRANSLATIONS");
                mainMenu.InsertItem("Tools\\" + TranslationName + "\\" + L.Txt("Export Translation records to SYS_LANG file"), ExportLangFile, "XMISC_TRANSLATIONS");
                mainMenu.InsertItem("Tools\\" + TranslationName + "\\" + L.Txt("Consolidate imported translations with STRINGS file"), ImportSTRINGSFile, "XMISC_TRANSLATIONS");
            }

            mainMenu.SetInsertLocation("Help\\*", IMMainMenu.InsertLocation.Top);
            mainMenu.InsertItem("Help\\" + MenuGroupName + "\\" + L.TxT("Version"), VersionInfo, "XMISC_TRANSLATIONS");
            mainMenu.InsertItem("Help\\" + MenuGroupName + "\\" + L.TxT("Help and resources"), PluginResources, "XMISC_TRANSLATIONS");
            
        }

        public bool OtherMessage(string message, object inParam, ref object outParam) 
        {
            outParam = null;
            if (message == "ON_OPEN_WORKSPACE")
            {
                RegisterPluginFeatures();
            }
            else if (message == "EditRecord")
            {
                IntPtr owner = (IntPtr)IM.GetMainWindow();
                string[] s = ((string)inParam).Split('/');
                int id = s[1].Substring(1).ParseInt();
                bool ro = s[2] == "true"; //Readonly
                if (s[0] == "XMISC_TRANSLATIONS") { outParam = TranslationEditor.EditRecord(id, owner); return true; }
                if (s[0] == "XMISC_QUERYSTORE") { outParam = QueryStoreEditor.EditRecord(id, owner); return true; }
                return false;
            }
            else
            {
                Debug.WriteLine($"Uncatched message : {message} | {inParam} | {outParam}");
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
            if (dbCurVersion < 20221015.1503)
            {
                s.CreateTables("XMISC_QUERYSTORE");                
            }

            s.SetDatabaseVersion(20221015.1503);
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
        { 
            MessageBox.Show(L.Txt("Plugin version is : " + Version) + L.Txt("\r\nPlugin schema version is : ") + 20210615.00) ;
        }
        public void PluginResources()
        {
            MessageBox.Show(L.TxT("A github page will open in your default browser. Feel free to give feedback and hints on this tool."));
            System.Diagnostics.Process.Start("https://github.com/LixYt/ICSM_CollaborativePlugins"); }

        public void RegisterPluginFeatures()
        {
            PluginsManager.RegisterPluginFeature("MiscTools", "Translations", true, L.Txt("Helps manage, update and store translations of ICS Manager"));
            PluginsManager.RegisterPluginFeature("MiscTools", "QueryStore", true, L.Txt("Helps store and share queries and custom expressions for ICS Manager"));
        }
    }
}
