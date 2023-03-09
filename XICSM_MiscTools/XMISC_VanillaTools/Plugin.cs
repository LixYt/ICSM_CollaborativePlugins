using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICSM;
using DatalayerCs;
using NetPlugins2Ext;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using XICSM.PluginManager;

namespace XICSM.VanillaTools
{
    public class Plugin : IPlugin, IPluginDetails
    {
        public string Ident { get { return L.TxT("VanillaTools"); } }
        public int Interface => 2;
        
        DateTime IPlugin.Version => new DateTime(2023,2,15,10,34,0);
        public double SchemaVersion { get { return 0; } }

        public string Description { get { return L.TxT("Vanilla Tools (this plugin does not modify the database structure)"); } }

        public string MenuGroupName { get { return L.TxT("Vanilla Tools"); } }
        public string GitURL => "URL not defined";
        public string DocumentationUrl => "URL not defined";
        public Plugin()
        {
            //Reset pending Smart copy process
            IM.SetWorkspaceString("SmartCopy_Fields", "");
            IM.SetWorkspaceString("SmartCopy_Table", "");
            IM.SetWorkspaceString("SmartCopy_SourceID", "");
        }
        public void RegisterSchema(IMSchema s)
        {
            /* Should never be used in this plugin */
        }
        public void RegisterBoard(IMBoard b) 
        {
            b.RegisterQueryMenuBuilder(null, Contextual.onGetQueryMenu);
        }
        public void GetMainMenu(IMMainMenu mainMenu)
        {
            mainMenu.SetInsertLocation("Tools\\Administrator", IMMainMenu.InsertLocation.After);
            
            if (PluginsManager.UserCanUseFeature("VanillaTools", "CleanWorkspaceDir"))
            {
                mainMenu.InsertItem("Tools\\" + MenuGroupName + "\\" + L.Txt("Clean workspace directory"), CleanWorkspaceDir, "DOCLINK");
            }
            
            if (PluginsManager.UserCanUseFeature("VanillaTools", "CheckDocLink"))
            {
                mainMenu.InsertItem("Tools\\" + MenuGroupName + "\\" + L.Txt("Verify attached documents"), CheckDocLink, "DOCLINK");
            }

            //Demo and Test of new features
            if (PluginsManager.UserCanUseFeature("VanillaTools", "BetaTestFeatures"))
            {
                string demo = L.TxT("Test & Demo");
                mainMenu.SetInsertLocation("Tools", IMMainMenu.InsertLocation.After);
                mainMenu.InsertItem(demo + "\\" + L.Txt("Advanced Geoview"), GeoviewTester, "XMISC_TRANSLATIONS");
                mainMenu.InsertItem(demo + "\\" + L.Txt("Geoview Query on ANFR"), GeoviewQueryTester, "XMISC_TRANSLATIONS");
                mainMenu.InsertItem(demo + "\\" + L.Txt("Geoview Query on MOB_STATION"), GeoviewQueryTester2, "XMISC_TRANSLATIONS");
            }
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
            
            outParam = null;
            return false;
        }
        public bool UpgradeDatabase(IMSchema s, double dbCurVersion)
        {
            /* Should never be used in this plugin */
            return true;
        }

        #region Plugin Manager
        public void RegisterPluginFeatures()
        {
            PluginsManager.RegisterPluginFeature("VanillaTools", "BetaTestFeatures", true, L.TxT("Features that aren't yet stable. Use at your own risks.")); ;

            PluginsManager.RegisterPluginFeature("VanillaTools", "CheckDocLink", true, L.Txt("Helps to find borken documents link and fix it"));
            PluginsManager.RegisterPluginFeature("VanillaTools", "CleanWorkspaceDir", true, L.TxT("Clean the opened workspace directory of trash and temp file such as ICS Manager crashdump files or .tmp files"));
            PluginsManager.RegisterPluginFeature("VanillaTools", "EntityFormSFAF", true, L.TxT("Replace the default SFAF window with a more advanded one"));
            PluginsManager.RegisterPluginFeature("VanillaTools", "ConverterMwToMobSta", false, L.TxT("A very simple converter that transforms a Microwave link in a pair of Other Terrestrial station."));
            PluginsManager.RegisterPluginFeature("VanillaTools", "ConverterMobStaFreqs", true, L.TxT("A bunch of tools to modify and correct Other Terrestrial Stations (invert Tx/Rx freq for instance).")); ;
            PluginsManager.RegisterPluginFeature("VanillaTools", "SmartCopy", true, L.TxT("A powerfull tool to copy some fields from a record to other(s) record(s) of the same table.")); ;
            
        }
        #endregion

        #region MainMenu fonctions
        public void CleanWorkspaceDir()
        {
            string dir = IM.GetWorkspaceFolder();
            string[] fileEntries = Directory.GetFiles(dir);

            IMLogFile log = new IMLogFile();
            log.Create("CleanUp.txt");

            foreach (string fileName in fileEntries)
            { 
                if (fileName.EndsWith(".dmp", true, System.Globalization.CultureInfo.CurrentCulture) || 
                    fileName.EndsWith(".tmp", true, System.Globalization.CultureInfo.CurrentCulture) ||
                    fileName.EndsWith(".cgn", true, System.Globalization.CultureInfo.CurrentCulture) || 
                    fileName.EndsWith(".gxt", true, System.Globalization.CultureInfo.CurrentCulture)
                    )
                { File.Delete(fileName); log.Info(L.Txt("Delete file : ") + fileName); }
            }
            log.Display(L.Txt("Deleted files after workspace clean up"));
        }
        public void CheckDocLink()
        {
            Checkers c = new Checkers();
            c.AttachedDocuements();
        }
        #endregion
        
        #region Demo and test menu call functions
        public void GeoviewTester()
        {
            Form f = new Form();
            IcsMetroGeoView g = new IcsMetroGeoView();
            g.Dock = DockStyle.Fill;
            f.Controls.Add(g);
            f.ShowDialog();
        }
        public void GeoviewQueryTester()
        {
            Form f = new Form(); f.Size = new System.Drawing.Size(1280, 720);
            IcsMetroGeoViewQuery g = new IcsMetroGeoViewQuery
            {
                TableName = "ANFR",
                Dock = DockStyle.Fill,
            };
            f.Controls.Add(g);
            f.ShowDialog();
        }
        public void GeoviewQueryTester2()
        {
            Form f = new Form(); f.Size = new System.Drawing.Size(1280, 720);
            IcsMetroGeoViewQuery g = new IcsMetroGeoViewQuery
            {
                TableName = "MOB_STATION",
                Dock = DockStyle.Fill,

            };
            f.Controls.Add(g);
            f.ShowDialog();
        }

        

        #endregion
    }
}
