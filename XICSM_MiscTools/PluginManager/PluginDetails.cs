using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XICSM.PluginManager
{
    public interface IPluginDetails
    {
        string GitURL { get; }
        string DocumentationUrl { get; }
        void RegisterPluginFeatures(); 

    }
}
