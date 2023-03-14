using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICSM;
using DatalayerCs;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using OrmCs;

namespace XICSM.PluginManager
{
    public class Plugin : IPlugin, IPluginDetails
    {
        public double SchemaVersion => 20230309.1449;

        public int Interface => 2;

        public DateTime Version => new DateTime(2023, 2, 24, 0, 0, 0);

        public string Description => L.Txt("Base plugin for open source plugins");

        public string Ident => "PluginManager";

        public string GitURL => "URL not defined";

        public string DocumentationUrl => "URL not defined";

        public void RegisterSchema(IMSchema s)
        {
            s.DeclareTable("XSYS_PFEATURES|SOURCER", L.Txt("Plugins features management table"), "WORKFLOW,58");
            s.DeclareShortDesc(L.Txt("[PLUGIN] feature [NAME]"));
            s.DeclareFullDesc(
                 "Plugin = [PLUGIN]\r\n"
                + "Feature = [NAME]\r\n"
                + "Description = [DESCRIPTION]");
            s.DeclareField("ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareIndex("PK_SYS_PLUGINS", "PRIMARY", "ID");
            s.DeclareField("PLUGIN_NAME", "VARCHAR(255)", "Text", "NOTNULL", null); s.Info(L.TxT("Plugin name"));
            s.DeclareField("FEATURE_NAME", "VARCHAR(255)", "Text", "NOTNULL", null); s.Info(L.TxT("Plugin feature name"));
            s.DeclareField("ENABLE", "NUMBER(1,0)", "Bool", "NOTNULL", "0"); s.Info(L.TxT("Is plugin feature enable"));
            s.DeclareField("SETTINGS", "VARCHAR(255)", "Text", null, null); s.Info(L.TxT("Plugin feature settings"));
            s.DeclareField("DESCRIPTION", "VARCHAR(255)", "Text", null, null); s.Info(L.TxT("Plugin feature description"));
            s.DeclareField("CUST_TXT1", "VARCHAR(255)", "String", null, "0"); s.Info(L.TxT("PF_TXT1"));
            s.DeclareField("CUST_TXT2", "VARCHAR(255)", "String", null, "0"); s.Info(L.TxT("PF_TXT2"));
            s.DeclareField("CUST_TXT3", "VARCHAR(255)", "String", null, "0"); s.Info(L.TxT("PF_TXT3"));
            s.DeclareField("CUST_DAT1", "DATE", "Date", null, "0"); s.Info(L.TxT("PF_DAT1"));
            s.DeclareField("CUST_DAT2", "DATE", "Date", null, "0"); s.Info(L.TxT("PF_DAT2"));
            s.DeclareField("CUST_CHB1", "NUMBER(1,0)", "Bool", null, "0"); s.Info(L.TxT("PF_CHB1"));
            s.DeclareField("CUST_CHB2", "NUMBER(1,0)", "Bool", null, "0"); s.Info(L.TxT("PF_CHB2"));
            s.DeclareField("CUST_CHB3", "NUMBER(1,0)", "Bool", null, "0"); s.Info(L.TxT("PF_CHB3"));
            s.DeclareJoin("Plugins_rights", "XSYS_PF_RIGHTS", null, "ID", "SYS_PFEATURES_ID");

            s.DeclareTable("XSYS_PF_RIGHTS|SOURCER", L.Txt("Open source plugins rights"), "WORKFLOW,58");
            s.DeclareShortDesc(L.Txt("[Plugin_Feature.PLUGIN] for [Taskforce.Name]"));
            s.DeclareFullDesc(
                 "Plugin = [Plugin_Feature.PLUGIN]\r\n"
                + "Feature = [Plugin_Feature.NAME]\r\n"
                + "Taskforce = [Taskforce.Name]");
            s.DeclareField("SYS_PFEATURES_ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareJoin("Plugin_Feature", "XSYS_PFEATURES", "DBMS", "SYS_PFEATURES_ID", "ID"); s.Info(L.Txt("Plugin feature"));
            s.DeclareField("TASKFORCE_ID", "NUMBER(9,0)", null, "NOTNULL", null);
            s.DeclareJoin("Taskforce", "TASKFORCE", "DBMS", "TASKFORCE_ID", "ID"); s.Info(L.Txt("Taskforce"));
            s.DeclareField("DESCRIPTION", "VARCHAR(255)", "Text", null, null); s.Info(L.TxT("Plugin rights description"));
            s.DeclareField("CUST_TXT1", "VARCHAR(255)", "String", null, "0"); s.Info(L.TxT("PFR_TXT1"));
            s.DeclareField("CUST_TXT2", "VARCHAR(255)", "String", null, "0"); s.Info(L.TxT("PFR_TXT2"));
            s.DeclareField("CUST_TXT3", "VARCHAR(255)", "String", null, "0"); s.Info(L.TxT("PFR_TXT3"));
            s.DeclareField("CUST_DAT1", "DATE", "Date", null, "0"); s.Info(L.TxT("PFR_DAT1"));
            s.DeclareField("CUST_DAT2", "DATE", "Date", null, "0"); s.Info(L.TxT("PFR_DAT2"));
            s.DeclareField("CUST_CHB1", "NUMBER(1,0)", "Bool", null, "0"); s.Info(L.TxT("PFR_CHB1"));
            s.DeclareField("CUST_CHB2", "NUMBER(1,0)", "Bool", null, "0"); s.Info(L.TxT("PFR_CHB2"));
            s.DeclareField("CUST_CHB3", "NUMBER(1,0)", "Bool", null, "0"); s.Info(L.TxT("PFR_CHB3"));

            string appFolder = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            if (!OrmCs.OrmSchema.ParseSchema(appFolder, "PluginManager", "XICSM_PluginManager", out string err)) MessageBox.Show(L.TxT("Unable to load 'PluginManager.Schema' :") + err);

        }

        public bool UpgradeDatabase(IMSchema s, double dbCurVersion)
        {
            if (dbCurVersion < 20230307.1844)
            {
                s.CreateTables("XSYS_PFEATURES");
                s.CreateTables("XSYS_PF_RIGHTS");
                s.SetDatabaseVersion(20230307.1844);
            }
            if (dbCurVersion < 20230308.1040)
            {
                s.UpdateTableFields("XSYS_PFEATURES", "CUST_TXT1,CUST_TXT2,CUST_TXT3,CUST_DAT1,CUST_DAT2,CUST_CHB1,CUST_CHB2,CUST_CHB3,DESCRIPTION");
                s.UpdateTableFields("XSYS_PF_RIGHTS", "CUST_TXT1,CUST_TXT2,CUST_TXT3,CUST_DAT1,CUST_DAT2,CUST_CHB1,CUST_CHB2,CUST_CHB3,DESCRIPTION");
                s.SetDatabaseVersion(20230308.1040);
            }
            if (dbCurVersion < 20230309.1449)
            {
                s.UpdateTableFields("XSYS_PFEATURES", "SETTINGS");
                s.DeleteTableFields("XSYS_PF_RIGHTS", "ENABLE");
                s.SetDatabaseVersion(20230309.1449);
            }

            return true;
        }

        public void RegisterBoard(IMBoard b) {
            b.RegisterQueryMenuBuilder("XSYS_PFEATURES", Contextual.onGetQueryMenu);
            b.RegisterQueryMenuBuilder("XSYS_PF_RIGHTS", Contextual.onGetQueryMenu);
        }

        public void GetMainMenu(IMMainMenu mainMenu)
        {
            mainMenu.SetInsertLocation("Tools\\Administrator", IMMainMenu.InsertLocation.After);
            //mainMenu.InsertItem("Tools\\" + L.Txt("Manage plugins rights"), PluginFeaturesManager.OpenPluginFeaturesManager, "DOCLINK");
        }

        public bool OtherMessage(string message, object inParam, ref object outParam)
        {
            if (message == "ON_OPEN_WORKSPACE")
            {
                RegisterPluginFeatures();
            }
            else
            {
                Debug.WriteLine($"Uncatched message : {message} | {inParam} | {outParam}");
            }
            return false;
        }

        public void RegisterPluginFeatures()
        {
            PluginsManager.RegisterPluginFeature("PluginManager", "PluginsRights", true, L.Txt("Allows to manage who can use plugins features, using Tasks forces"));
        }


    }

    class Contextual
    {
        public static List<IMQueryMenuNode> onGetQueryMenu(string tableName, int nbSelMin)
        {
            List<IMQueryMenuNode> lst = new List<IMQueryMenuNode>();

            if (tableName == "XSYS_PFEATURES" && PluginsManager.UserCanUseFeature("PluginManager", "PluginsRights")) 
            {
                lst.Add(new IMQueryMenuNode(L.Txt("Allow a taskforce to use this feature"), null, Contextual.AddTaskforce, IMQueryMenuNode.ExecMode.FirstRecord));
                lst.Add(new IMQueryMenuNode(L.Txt("Toggle enable state"), null, Contextual.ToggleEnable, IMQueryMenuNode.ExecMode.FirstRecord));
            }

            if (tableName == "XSYS_PF_RIGHTS" && nbSelMin == 1 && PluginsManager.UserCanUseFeature("PluginManager", "PluginsRights"))
            {
                lst.Add(new IMQueryMenuNode(L.Txt("Remove this taskforce rights"), null, Contextual.DeletePF_Rights, IMQueryMenuNode.ExecMode.SelectionOfRecords));
            }

            return lst;
        }
        public static bool ToggleEnable(IMQueryMenuNode.Context context)
        {
            YXsysPfeatures feature = new YXsysPfeatures();
            feature.LoadWithComponents(context.TableId);
            feature.m_enable = feature.m_enable == 1 ? 0 : 1;
            feature.Save();
            return true;
        }
        public static bool DeletePF_Rights(IMQueryMenuNode.Context context)
        {
            YXsysPfRights rights = new YXsysPfRights();
            rights.Format("*");
            rights.Filter = context.DataList.GetOQLFilter(true);
            for (rights.OpenRs(); !rights.IsEOF(); rights.MoveNext())
            {
                rights.Delete();
            }

            return true;
        }
        public static bool AddTaskforce(IMQueryMenuNode.Context context)
        {
            SelectTaskForce STF = new SelectTaskForce();
            if (STF.ShowDialog() == DialogResult.OK)
            {
                if (STF.TaskForceID > 0)
                {
                    StringEditor desc = new StringEditor(L.Txt("Description for this Taskforce to use this feature"));
                    desc.ShowDialog();

                    YXsysPfRights right = new YXsysPfRights();
                    right.m_description = desc.TextValue;
                    right.m_sys_pfeatures_id = context.TableId;
                    right.m_taskforce_id = STF.TaskForceID;
                    right.Save();

                    return true;
                }
            }
            
            return false;
        }
    }
}