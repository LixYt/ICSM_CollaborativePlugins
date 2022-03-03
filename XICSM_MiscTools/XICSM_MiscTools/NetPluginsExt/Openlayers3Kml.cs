using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DatalayerCs;
using NetPlugins2;

namespace NetPlugins2Ext {
    public partial class Openlayers3Kml : Form {
        public Openlayers3Kml(IcsOpenlayers3 ctrl,Openlayers3 ol3)
        {
            Ctrl= ctrl;
            Ol3= ol3;
            InitializeComponent();
        }
        private Openlayers3 Ol3;
        private IcsOpenlayers3 Ctrl;

        class comboItem {
            public string Name { get; set; }
            public string Code { get; set; }
            public comboItem(string code) { Code=code; Name= Path.GetFileName(code)+" ("+Path.GetDirectoryName(code)+")"; }
            }
        public void SetRecent(List<string> l)
        {
            lstRecent.DisplayMember = "Name";
            lstRecent.ValueMember = "Code";
            if (l!=null) foreach(string s in l)
                lstRecent.Items.Add(new comboItem(s));
        }
        public List<string> GetRecentList() {
            List<string> res= new List<string>();
            for(int i=0;i<lstRecent.Items.Count;i++) {
                comboItem ci= lstRecent.Items[i] as comboItem;
                res.Add(ci.Code);
                }
            return res;
           }
        public void SetCurrent(string[] l)
        {
            lstDist.DisplayMember = "Name";
            lstDist.ValueMember = "Code";
            if (l!=null) foreach(string s in l)
                lstDist.Items.Add(new comboItem(s));
        }
        public string[] GetCurrent()
        {
            int cnt= lstDist.Items.Count;
            string[] res= new string[cnt];
            for(int i=0;i<cnt;i++) {
                comboItem ci= lstDist.Items[i] as comboItem;
                res[i]= ci.Code;
                }
            return res;
        }
        private void saveRecent(string fname)
        {
            int idx= -1;
            for(int i=0;i<lstRecent.Items.Count;i++) {
                comboItem ci= lstRecent.Items[i] as comboItem;
                if (ci.Code==fname) { idx= i; break; }
                }
            if (idx<0 && Ctrl.KmlsMaxCached>0 && lstRecent.Items.Count>Ctrl.KmlsMaxCached) idx= lstRecent.Items.Count-1;
            if (idx>0) lstRecent.Items.RemoveAt(idx);
            if (idx!=0) lstRecent.Items.Insert(0, new comboItem(fname));
        }
        private void addCurrent(string fname)
        {
            for(int i=0;i<lstDist.Items.Count;i++) {
                comboItem ci= lstDist.Items[i] as comboItem;
                if (ci.Code==fname) return;
                }
            lstDist.Items.Add(new comboItem(fname));
        }
        private void kmlAdd_Click(object sender,EventArgs e)
        {
            OpenFileDialog dlg= new OpenFileDialog();
            dlg.Title = L.Txt("Select KML file to display");
            dlg.FileName= "";
            dlg.Filter = L.Txt("KML file|*.kml|All Files (*.*)|*.*");
            if (dlg.ShowDialog() != DialogResult.OK) return;
            saveRecent(dlg.FileName);
            addCurrent(dlg.FileName);
        }

        private void lstDist_DoubleClick(object sender,EventArgs e)
        {
            int idx= lstDist.SelectedIndex;
            if (idx>=0) lstDist.Items.RemoveAt(idx);
        }

        private void lstRecent_DoubleClick(object sender,EventArgs e)
        {
            int idx= lstRecent.SelectedIndex;
            if (idx>=0) {
                comboItem ci= lstRecent.Items[idx] as comboItem;
                addCurrent(ci.Code);
                saveRecent(ci.Code);
                }
        }

        private void Openlayers3Kml_Load(object sender,EventArgs e)
        {

        }

        private void buClearRecent_Click(object sender,EventArgs e)
        {
            lstRecent.Items.Clear();
        }
    }
}
