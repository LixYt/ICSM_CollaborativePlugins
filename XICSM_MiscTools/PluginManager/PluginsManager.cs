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
using DatalayerCs;

namespace XICSM.PluginManager
{
    public class PluginsManager
    {
        public static YXsysPfeatures RegisterPluginFeature(string pluginName, string pluginFeature, bool isEnable, string Description)
        {
            YXsysPfeatures feature;

            YXsysPfeatures ExistFeature = new YXsysPfeatures();
            ExistFeature.Filter = $"PLUGIN_NAME like '{pluginName}' AND FEATURE_NAME like '{pluginFeature}'";
            if (ExistFeature.Count(true) == 0)
            {
                feature = new YXsysPfeatures();
                feature.AllocID();
                
                feature.m_plugin_name = pluginName;
                feature.m_feature_name = pluginFeature;
                feature.m_enable = (isEnable ? 1 : 0);
                feature.m_description = Description;
                
                feature.Save();
            }
            else
            {
                feature = ExistFeature;
                feature.OpenRs();
            }
            
            
            return feature;
        }
        public static bool IsFeatureEnable(string pluginName, string pluginFeature)
        {
            YXsysPfeatures feature = new YXsysPfeatures();
            feature.Filter = $"PLUGIN_NAME like '{pluginName}' AND FEATURE_NAME like '{pluginFeature}'";
            feature.OpenRs();

            return (feature.m_enable == 1);
        }
        public static void TogglePluginEnableState(string pluginName, string pluginFeature)
        {
            YXsysPfeatures feature = new YXsysPfeatures();
            feature.Filter = $"PLUGIN_NAME like '{pluginName}' AND FEATURE_NAME like '{pluginFeature}'";
            feature.OpenRs();
            feature.m_enable = (feature.m_enable == 0 ? 1 : 0);
            feature.Save();
        }
        public static string GetFeatureSettings(string pluginName, string pluginFeature)
        {
            YXsysPfeatures feature = new YXsysPfeatures();
            feature.Filter = $"PLUGIN_NAME like '{pluginName}' AND FEATURE_NAME like '{pluginFeature}'";
            feature.OpenRs();

            return feature.m_settings;
        }
        public static YXsysPfeatures GetPluginFeature(string pluginName, string pluginFeature)
        {
            YXsysPfeatures feature = new YXsysPfeatures();
            feature.Filter = $"PLUGIN_NAME like '{pluginName}' AND FEATURE_NAME like '{pluginFeature}'";
            feature.OpenRs();

            return feature;
        }
        public static bool UserCanUseFeature(string pluginName, string pluginFeature)
        {
            //Is user DB owner ? Then it should show everything !
            if (IM.IsDataOwnerConnected()) return true;

            YXsysPfeatures feature = new YXsysPfeatures();
            feature.Filter = $"PLUGIN_NAME like '{pluginName}' AND FEATURE_NAME like '{pluginFeature}'";
            feature.OpenRs();

            //If feautre is not enable, who cares to check if it can use it ^^
            if (feature.m_enable == 0) return false;

            //Is feature linked to at least one taskforce ?
            YXsysPfRights rights = new YXsysPfRights();
            rights.format2("*");
            rights.Filter = $"SYS_PFEATURES_ID = {feature.m_id}";

            if (rights.Count(true) == 0) return true; 

            //Feature is linked to taskforces, is user member of one of them ?
            string s = "";
            for (rights.OpenRs(); !rights.IsEOF(); rights.MoveNext())
            {
                YTaskforce t = new YTaskforce();
                t.LoadWithComponents(rights.m_taskforce_id);
                s += $"{t.m_short_name}|";
            }
            s = s.Substring(0, s.Length - 1);

            return IM.IsConnUserInTaskforce(s);
        }
    }
}
