using ICSM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrmCs;
using System.IO;
using DifferenceEngine;
using System.Windows.Forms;
using System.Collections;
using DiffCalc;

namespace XICSM.VanillaTools.TableTools
{
    class AllocationsTools
    {
        public static bool CheckNote(IMQueryMenuNode.Context context)
        {
            YRrNote CurrentNote = new YRrNote();
            CurrentNote.Format("*");
            CurrentNote.LoadWithComponents2(context.TableId);

            YRrTable table = new YRrTable();
            table.LoadWithComponents(CurrentNote.m_tab_id);
            YRrTable PrevTable = new YRrTable();
            PrevTable.Fetch($"cod = '{table.m_cod_prev}'");

            YRrNote PrevNote = new YRrNote();
            PrevNote.Fetch($"tab_id  = {PrevTable.m_id} and number = '{CurrentNote.m_number}'");

            File.WriteAllText(IM.GetWorkspaceFolder() + "\\string1.tmp.txt", CurrentNote.m_description);
            File.WriteAllText(IM.GetWorkspaceFolder() + "\\string2.tmp.txt", PrevNote.m_description);

			DiffList_TextFile sLF = null;
			DiffList_TextFile dLF = null;

			try
			{
				sLF = new DiffList_TextFile(IM.GetWorkspaceFolder() + "\\string1.tmp.txt");
				dLF = new DiffList_TextFile(IM.GetWorkspaceFolder() + "\\string2.tmp.txt");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "File Error");
				return false;
			}

			try
			{
				DiffEngineLevel _level = DiffEngineLevel.SlowPerfect;

				double time = 0;
				DiffEngine de = new DiffEngine();
				time = de.ProcessDiff(sLF, dLF, _level);

				ArrayList rep = de.DiffReport();
				Results dlg = new Results(sLF, dLF, rep, time);
				dlg.ShowDialog();
				dlg.Dispose();
			}
			catch (Exception ex)
			{
				string tmp = string.Format("{0}{1}{1}***STACK***{1}{2}",
					ex.Message,
					Environment.NewLine,
					ex.StackTrace);
				MessageBox.Show(tmp, "Compare Error");
			}

			return false;
        }

    }
}
