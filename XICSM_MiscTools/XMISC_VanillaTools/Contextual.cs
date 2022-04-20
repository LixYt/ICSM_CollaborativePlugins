using DatalayerCs;
using ICSM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XICSM.VanillaTools
{
    class Contextual
    {
        public static List<IMQueryMenuNode> onGetQueryMenu(string tableName, int nbSelMin)
        {
            List<IMQueryMenuNode> lst = new List<IMQueryMenuNode>();
            if (tableName == "MICROWA" && nbSelMin == 1 && IM.SpecialRightsActivated())
            {
                lst.Add(new IMQueryMenuNode(L.Txt("Convert to Other Terrestrial Stations"), null, Converter.ConvertMwToOt, IMQueryMenuNode.ExecMode.FirstRecord));
            }
            if (tableName == "DOCLINK" && nbSelMin == 1)
            {
                lst.Add(new IMQueryMenuNode(L.Txt("Does this document exist ?"), null, TableTools.DocLinkTools.CheckDoc, IMQueryMenuNode.ExecMode.FirstRecord));
                lst.Add(new IMQueryMenuNode(L.Txt("Open Document"), null, TableTools.DocLinkTools.OpenDoc, IMQueryMenuNode.ExecMode.FirstRecord));
                lst.Add(new IMQueryMenuNode(L.Txt("Open related Directory"), null, TableTools.DocLinkTools.OpenRelatedDir, IMQueryMenuNode.ExecMode.FirstRecord));
            }
            return lst;
        }


    }
}
