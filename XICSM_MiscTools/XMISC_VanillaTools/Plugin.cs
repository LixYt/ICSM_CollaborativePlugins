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

namespace XICSM.VanillaTools
{
    public class Plugin : IPlugin
    {
        public string Description { get { return L.TxT("Vanilla Tools (this plugin does not modify the database structure)"); } }
        public string Ident { get { return L.TxT("VanillaTools"); } }
        public string MenuGroupName { get { return L.TxT("Vanilla Tools"); } }
        public string Version = "1.3.0.0";

        public Plugin()
        {
            //Reset pending Smart copy process
            IM.SetWorkspaceString("SmartCopy_Fields", "");
            IM.SetWorkspaceString("SmartCopy_Table", "");
            IM.SetWorkspaceString("SmartCopy_SourceID", "");
        }
        public void RegisterSchema(IMSchema s)
        { /* Should never be used in this plugin */ }
        public double SchemaVersion { get { return 0; } }
        public void RegisterBoard(IMBoard b) 
        {
            b.RegisterQueryMenuBuilder(null, Contextual.onGetQueryMenu);
            /*b.RegisterQueryMenuBuilder("ALL_TXRX_FREQ", Contextual.onGetQueryMenu);
            b.RegisterQueryMenuBuilder("DOCLINK", Contextual.onGetQueryMenu);
            b.RegisterQueryMenuBuilder("MICROWA", Contextual.onGetQueryMenu);*/
        }
        public void GetMainMenu(IMMainMenu mainMenu)
        {
            mainMenu.SetInsertLocation("Tools\\Administrator", IMMainMenu.InsertLocation.After);
            mainMenu.InsertItem("Tools\\" + MenuGroupName + "\\" + L.Txt("Verify attached documents"), CheckDocLink, "DOCLINK");
            mainMenu.InsertItem("Tools\\" + MenuGroupName + "\\" + L.Txt("Version/info"), VersionBox, "DOCLINK");
            
            mainMenu.SetInsertLocation("Configuration\\User Preferences", IMMainMenu.InsertLocation.After);
            mainMenu.InsertItem("Configuration\\User Preferences" + "\\" + L.Txt("Show/Hide beta test and demo menu"), ToggleDemoMenu, "DOCLINK");
            mainMenu.InsertItem("Configuration\\User Preferences" + "\\" + L.Txt("Toggle Vanilla tools"), ToggleVanillaTools, "DOCLINK");

            //Demo and Test of new features
            if (IM.GetWorkspaceString("TestAndDemo") == "Display")
            {
                string demo = L.TxT("Test & Demo");
                mainMenu.SetInsertLocation("Tools", IMMainMenu.InsertLocation.After);
                mainMenu.InsertItem(demo + "\\" + L.Txt("Advanced Geoview"), GeoviewTester, "XMISC_TRANSLATIONS");
                mainMenu.InsertItem(demo + "\\" + L.Txt("Geoview Query on ANFR"), GeoviewQueryTester, "XMISC_TRANSLATIONS");
                mainMenu.InsertItem(demo + "\\" + L.Txt("Geoview Query on MOB_STATION"), GeoviewQueryTester2, "XMISC_TRANSLATIONS");
            }
            else if (IM.GetWorkspaceString("TestAndDemo") != "Hide")
            {
                IM.SetWorkspaceString("TestAndDemo", "Hide");
            }
            else { }

        }
        public bool OtherMessage(string message, object inParam, ref object outParam)
        {
            outParam = null;
            Debug.WriteLine($"Uncatched message : {message} | {inParam} | {outParam}");
            return false;
        }
        public bool UpgradeDatabase(IMSchema s, double dbCurVersion)
        {
            /* Should never be used in this plugin */
            return true;
        }
        

        #region MainMenu fonctions
        public void ToggleDemoMenu()
        {
            IM.SetWorkspaceString("TestAndDemo", 
                (IM.GetWorkspaceString("TestAndDemo") == "Display" ? "Hide" : "Display") );
            MessageBox.Show(L.TxT("Demo menu will appear or disappear after reopening your workspace."));
        }
        public void ToggleVanillaTools()
        {
            IM.SetWorkspaceString("VanillaContextualTools", 
                (IM.GetWorkspaceString("VanillaContextualTools") == "Display" ? "Hide" : "Display"));
        }

        public void VersionBox()
        {
            MessageBox.Show($"Plugin name : {Ident}\r\n" +
                $"Description : {Description}\r\n" +
                $"Version : {Version}\r\n" +
                $"More info at : https://github.com/LixYt/ICSM_CollaborativePlugins");
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
