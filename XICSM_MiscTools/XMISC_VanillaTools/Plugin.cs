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

namespace XICSM.VanillaTools
{
    public class Plugin : IPlugin
    {
        public string Description { get { return "Vanilla Tools (this plugin does not modify the database structure)"; } }
        public string Ident { get { return "VanillaTools"; } }
        public string Version = "1.0.0.1";

        public void RegisterSchema(IMSchema s)
        { /* Should never be used in this plugin */ }
        public double SchemaVersion { get { return 0; } }
        public void RegisterBoard(IMBoard b) 
        {
            b.RegisterQueryMenuBuilder("MICROWA", Contextual.onGetQueryMenu);
        }
        public void GetMainMenu(IMMainMenu mainMenu)
        {
            mainMenu.SetInsertLocation("Tools\\Administrator", IMMainMenu.InsertLocation.After);
            mainMenu.InsertItem("Tools\\Vanilla Tools\\" + L.Txt("Verify attached documents"), CheckDocLink, "DOCLINK");
            mainMenu.InsertItem("Tools\\Vanilla Tools\\" + L.Txt("Version/info"), VersionBox, "DOCLINK");

        }
        public bool OtherMessage(string message, object inParam, ref object outParam)
        {
            outParam = null;



            return false;
        }
        public bool UpgradeDatabase(IMSchema s, double dbCurVersion)
        {
            /* Should never be used in this plugin */
            return true;
        }

        #region MainMenu fonctions
        public void VersionBox()
        {
            MessageBox.Show($"Plugin name : {Ident}\r\n" +
                $"Description : {Description}\r\n" +
                $"Version : {Version}\r\n" +
                $"More info at : https://github.com/LixYt/ICSM_CollaborativePlugins");
        }
        public void CheckDocLink()
        {
            Checkers.AttachedDocuements();
        }
        #endregion
    }
}
