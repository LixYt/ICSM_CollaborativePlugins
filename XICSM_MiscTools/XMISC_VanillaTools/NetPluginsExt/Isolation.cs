using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSM;
using OrmCs;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using FormsCs;
using System.Runtime.InteropServices;

namespace NetPlugins2 {

    public static class WinApi  
    {  
        [DllImport("user32.dll")]  
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);  
    }  
 
    [ComVisible(true)]  
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]  
    [Guid("81CD3AA4-593B-4C57-B4E7-22E11B11409F")]  
    public interface IWin32FormsInterop  
    {  
        [DispId(1)]  
        void ShowParented(uint Hwnd);  
    }  
 
    [ComVisible(true)]  
    [ClassInterface(ClassInterfaceType.None)]  
    [Guid("CA645972-8330-4FD1-B7D6-9935750F6F18")]  
    public partial class Win32CtrlOpenlayers3 : IWin32FormsInterop
    {  
        private IcsOpenlayers3 uc;  
 
        public void ShowParented(uint Hwnd)  
        {  
            uc = new IcsOpenlayers3();  
            WinApi.SetParent(uc.Handle, new IntPtr(Hwnd));  
            uc.Visible = true;  
        }  
    }  

    public class ComboItem
    {
        public string Code;
        public string Descr;
        public ComboItem(string cod, string label) { Code = cod; Descr = label; }
        public override string ToString()
        {
            return Descr.IsNull()? Code : string.Format("{0} - {1}", Code, Descr);
        }
    }
    public class IcsStatusWrapper
    {
        public static void comboInit(ComboBox cb, string tb)
        {            
            var statuses= IM.GetProcessControlStatusesList(tb);
            if (statuses.IsNotNull()) foreach(var code in statuses.Split(',')) {
                string descr= IM.GetProcessControlStatusLibel(tb,code);
                int idx= descr.IndexOf(" - ");
                if (idx>0) descr= descr.Substring(idx+3);
                cb.Items.Add(new ComboItem(code,descr));
                }
        }
    }
    public class DiagAHVDrawerWrapper {
        public static bool Edit(IntPtr hDlg,ref string diaga,ref string diagh,ref string diagv,double freq,bool readOnly)
            { return DiagAHVDrawer.Edit(hDlg,ref diaga,ref diagh,ref diagv,freq,readOnly); }
        public static void Paint(Graphics gr,ValueType re,string diaga,string diagh,string diagv)
            {  DiagAHVDrawer.Paint(gr,re,diaga,diagh,diagv); }
        public static bool EditH(IntPtr hDlg,ref string diagh,bool readOnly)
            { return DiagAHVDrawer.EditH(hDlg,ref diagh,readOnly); }
        public static void PaintH(Graphics gr,ValueType re,string diagh)
            {  DiagAHVDrawer.PaintH(gr,re,diagh); }
        }
    public class IcsDateTimeWrapper {
        IcsDateTime Dt;
        TextBox textBox1;
        DateTimePicker dateTimePicker1;
        public IcsDateTimeWrapper(IcsDateTime dt,TextBox tb1,DateTimePicker dtp1) { Dt=dt; textBox1=tb1; dateTimePicker1=dtp1;}
        public void Enter() {
            Semant sp= Semant.Get("Date");
            TextBox tb = textBox1;
            tb.Text= sp.Display(Dt.Value,true,null);
            tb.Select(0, 99999999);
            //Play(Job.DataGotfocus,ida,dat,0);
            }
        public void Leave() {
                Semant sp= Semant.Get("Date");
                TextBox tb= textBox1;
                object newv; string anErrMsg; int nbOk;
                if (!sp.Analyze(out newv,out anErrMsg,out nbOk,tb.Text)) {
                    MessageBox.Show(anErrMsg);
                    if (!textBox1.ReadOnly) {
                        Dt.enterNeutralize= true;
                        tb.Focus();
                        tb.Select(nbOk, 1000);
                        }
                    return;
                    }
                DateTime newt= newv==null? new DateTime() : (DateTime)newv;
                if (Dt._Val!=newt) { 
                    Dt._Val= newt;
                    displayControls(true,true);
                    Dt.triggerValueChanged();
                    }
                displayControls(true,false);
                }
        public void ValueChanged() {
            DateTime newt= dateTimePicker1.Value.Date;
            if (newt!=Dt._Val && !textBox1.ReadOnly) {
                Semant sp= Semant.Get("Date");
                Dt._Val= newt;
                displayControls(true,false);
                Dt.triggerValueChanged();
                }
            }
        public void displayControls(bool tb,bool dtp) {
            if (tb) {
                Semant sp= Semant.Get("Date");
                textBox1.Text= sp.Display(Dt._Val,false,null);
                }
            if (dtp) {
                Dt.unplugDTPChg();
                try { dateTimePicker1.Value= Dt._Val; } catch { dateTimePicker1.Value= DateTime.Now; }
                Dt.replugDTPChg();
                }
            }

        }
    public class MyIMEfhgtWrapper {
        private MyIMEfhgtWrapper(IMEfhgtHandler hr) { Dbl= IMEfhgtWrapper.New(hr); } 
        private IMEfhgtWrapper Dbl;
        public bool eventHandled;
        public IMEfhgtHandler EventHandler;
        public object EventParam;
        public static MyIMEfhgtWrapper New(IMEfhgtHandler hr) { return new MyIMEfhgtWrapper(hr); }
		public int From { set { Dbl.From=value; }}
		public bool Readonly { set { Dbl.Readonly=value; }} 
		public string EFHGT { get { return Dbl.EFHGT; } set { Dbl.EFHGT=value; }}
		public double EFHGTMax { get { return Dbl.EFHGTMax; } set { Dbl.EFHGTMax=value; }}
		public double AGL { get { return Dbl.AGL; } set { Dbl.AGL=value; }}
		public double ASL { get { return Dbl.ASL; } set { Dbl.ASL=value; }}
		public double X { get { return Dbl.X; } set { Dbl.X=value; }}
		public double Y { get { return Dbl.Y; } set { Dbl.Y=value; }}
		public string CSYS { get { return Dbl.CSYS; } set { Dbl.CSYS=value; }}
		
		public bool IsCtrlCreated() { return Dbl.IsCtrlCreated(); }
		public void CreateCtrl(IntPtr parent) { Dbl.CreateCtrl(parent); }
        public void Destroy(){ Dbl.Destroy(); }
    }
    internal class AttachDocWrapper {
        IcsAttachDocs Ad;
        public AttachDocWrapper(IcsAttachDocs ad) { Ad=ad; }
        public List<IcsAttachDocs.Document> LoadList() {
            List<IcsAttachDocs.Document> list=new List<IcsAttachDocs.Document>();
            using(YDoclink y= new YDoclink()) {
                y.Filter= "[REC_TAB]={0} AND [REC_ID]={1}".Fmt(Ad.RecordTable.ToSql(),Ad.RecordId);
                y.Order= "[BLOB_ID] ASC";
                for(y.OpenRs();!y.IsEOF();y.MoveNext()) {
                    IcsAttachDocs.Document doc= new IcsAttachDocs.Document();
                    doc.BlobId= y.m_blob_id;
                    doc.FileName= y.m_path;
                    doc.Comment= y.m_name;
                    doc.status="I";
                    list.Add(doc);
                    }
                }
            return list;
         }
        private void saveNew(YDoclink dl,string tab,int id,IcsAttachDocs.Document doc) {
            dl.New();
            dl.m_rec_tab= tab;
            dl.m_rec_id= id;
            dl.m_path= doc.FileName;
            dl.m_name= doc.Comment;
            dl.m_is_url= 0;
            dl.m_blob_id= doc.BlobId;
            dl.Save();
        }
        public bool SaveList(string tab,int id,List<IcsAttachDocs.Document> list) {
            list.Sort((IcsAttachDocs.Document a,IcsAttachDocs.Document b)=>{return a.BlobId-b.BlobId; });
            YDoclink dl= new YDoclink();
            using(YDoclink y= new YDoclink()) {
                y.Filter= "[REC_TAB]={0} AND [REC_ID]={1}".Fmt(tab.ToSql(),id);
                y.Order= "[BLOB_ID] ASC";
                y.OpenRs();
                int idx= 0;
                for(;;) {
                    if (y.IsEOF()) {
                        if (idx==list.Count) break;
                        else { saveNew(dl,tab,id,list[idx]); idx++; }
                        }
                    else if (idx==list.Count) { y.Delete(); y.MoveNext(); }
                    else if (y.m_blob_id<list[idx].BlobId) { y.Delete(); y.MoveNext(); }
                    else if (y.m_blob_id>list[idx].BlobId) { saveNew(dl,tab,id,list[idx]); idx++; }
                    else { y.m_name= list[idx].Comment; y.m_path= list[idx].FileName; y.Save(); y.MoveNext(); idx++; }
                    }
                }
            return true;
            }
        public IcsAttachDocs.Document AddNew() {
            int blobId; string fileSelPath;
            bool res= Doclink.SelectFileAndSaveItToBlob(out fileSelPath,out blobId);
            if (res) { 
                YDoclink z= new YDoclink(); 
                if (FormUtils.Input(z.z_name,"Description","Comment")) {
                    IcsAttachDocs.Document doc= new IcsAttachDocs.Document();
                    doc.BlobId= blobId;
                    doc.Comment= z.m_name;
                    doc.FileName= Path.GetFileName(fileSelPath);
                    doc.status= "N";
                    return doc;
                    }
                }
            return null;
            }
        public IcsAttachDocs.Document AddEmailFromClipboard() {
            IDataObject data = Clipboard.GetDataObject();
            //OutlookDataObject dataObject = new OutlookDataObject(data);
            return null;
            }
        public void ExportFile(IcsAttachDocs.Document doc) {
            string ext= Path.GetExtension(doc.FileName);
            string filt;
            if (ext!=null && ext.StartsWith("."))
                filt= "{0}|{0} file|*.{0}|All Files(*.*)|*.*|".Fmt(ext.Substring(1));
            else filt= "DOC|Document file(*.BMP;*.JPG;*.JPEG;*.AVI;*.WAV;*.MP3;*.DOC(X);*.XLS(X);*.PDF;*.RTF;*.OS;*.LIS)|*.BMP;*.JPG;*.JPEG;*.AVI;*.WAV;*.MP3;*.DOC;*.DOCX;*.XLS;*.XLSX;*.PDF;*.RTF;*.OS;*.LIS|All Files(*.*)|*.*|"; 
            SaveFileDialog dlg= new SaveFileDialog();
            dlg.Title= "Select document to generate";
            dlg.FileName= doc.FileName;
            dlg.Filter= filt;
            if (dlg.ShowDialog()==DialogResult.OK) {
                if (Doclink.ExtractBlobToFile(doc.BlobId,dlg.FileName)) 
                    MessageBox.Show("Extracted as "+dlg.FileName);
				}
            }
          private void myProcess_Exited(object sender, System.EventArgs e)   {
            Process p= (Process)sender;
            //MessageBox.Show(p.StartInfo.FileName+ " exited");
            try { File.Delete(p.StartInfo.FileName); } catch {  }
            }

        public void OpenFile(IcsAttachDocs.Document doc) {
            string ext= Path.GetExtension(doc.FileName).ToLower();
            string fnam= Path.GetFileNameWithoutExtension(doc.FileName);
            for(int i=1;i<=10;i++) {
                string filepath= Path.Combine(IM.GetWorkspaceFolder(),"tmpdoc "+fnam+i+ext);
                bool ok=true;
                if (File.Exists(filepath)) {
                    try { File.Delete(filepath); ok=true; }
                    catch { ok=false; }
                    }
                if (ok) {
                    if (Doclink.ExtractBlobToFile(doc.BlobId, filepath)) {
                        Process p= new Process();
                        p.StartInfo.FileName = filepath;
                        p.EnableRaisingEvents = true;
                        p.Exited += new EventHandler(myProcess_Exited);
                        try {
                            p.Start();
                            }
                        catch(Exception e) {
                            MessageBox.Show("Failed to open document - "+e.Message);
                            try { File.Delete(filepath); } catch {}
                            }
                        return;
                        }
                    }
                }
            }
        public Image GetImage(IcsAttachDocs.Document doc) {
            string ext= Path.GetExtension(doc.FileName).ToLower();
            if (ext==".bmp" || ext==".png" || ext==".jpg" || ext==".jpeg") {
                for(int i=1;i<=10;i++) {
                    string filepath= Path.Combine(IM.GetWorkspaceFolder(),"tmpBitmap"+i+ext);
                    bool ok=true;
                    if (File.Exists(filepath)) {
                        try { File.Delete(filepath); ok=true; }
                        catch { ok=false; }
                        }
                    if (ok) {
                        if (Doclink.ExtractBlobToFile(doc.BlobId,filepath))
                            return Image.FromFile(filepath);
                        return null;
                        }
                    }
                }
            return null;
            }


        }
    public class OpenLayers3Wrapper {
        IcsOpenlayers3 Ol;
        public OpenLayers3Wrapper(IcsOpenlayers3 ol) { Ol=ol; }
        public void RegisterMultimaps() {
            var r= IM.FindAllMaps(null,-1,"");
            Dictionary<string,MapHitSharp> maps= new Dictionary<string,MapHitSharp>();
            foreach(var h in r) {
                //if (h.m_nature!= &&h.m_nature!="GEO"
                //if (h.m_nature!="IMG") continue;
                string fname= Path.GetFileName(h.fimg);
                MapHitSharp deja;
                if (maps.TryGetValue(fname,out deja)) { //prefer local!
                    if (!deja.local && h.local) maps[fname]=h;
                    }
                else maps.Add(fname,h);
                }
            foreach(var kp in maps) Ol.RegisterMultimap(kp.Value.fimg,kp.Value.fpal);
            }
        public void saveKmlConfig(List<string> ls) {
            IM.WorkspaceConfigSave(Ol.KmlsNameCache,ls);
            }
        public List<string> loadKmlConfig() { return IM.WorkspaceConfigLoad(Ol.KmlsNameCache); }
        }
    public class MyIMDBListWrapper {
        private MyIMDBListWrapper(IMDBListHandler hr) { Dbl= IMDBListWrapper.New(hr); } 
        private IMDBListWrapper Dbl;
        public bool eventHandled;
        public IMDBListHandler EventHandler;
        public object EventParam;
        public static MyIMDBListWrapper New(IMDBListHandler hr) { return new MyIMDBListWrapper(hr); }
        public void AddColumn(string path,string Title,string Fmt,int colWidth){ Dbl.AddColumn(path,Title,Fmt,colWidth); }
        public void AddSortField(string path,OrderDirection dir){ Dbl.AddSortField(path,dir); }
        public void AllowUserFilter(bool yesno){ Dbl.AllowUserFilter(yesno); }
        public void AllowUserOrder(bool yesno){ Dbl.AllowUserOrder(yesno); }
        public void CreateCtrl(IntPtr parent){ Dbl.CreateCtrl(parent); }
        public void Destroy(){ Dbl.Destroy(); }
        public bool GetCurrentLineData(string path,ref double i){return Dbl.GetCurrentLineData(path,ref i); }
        public bool GetCurrentLineData(string path,ref int i){return Dbl.GetCurrentLineData(path,ref i); }
        public bool GetCurrentLineData(string path,ref string i){return Dbl.GetCurrentLineData(path,ref i); }
        public int GetSelectedCount(){ return Dbl.GetSelectedCount(); }
        public bool GetSelectedLineData(string path,ref double i){return Dbl.GetSelectedLineData(path,ref i);  }
        public bool GetSelectedLineData(string path,ref int i){return Dbl.GetSelectedLineData(path,ref i); }
        public bool GetSelectedLineData(string path,ref string i){return Dbl.GetSelectedLineData(path,ref i); }
        public bool GetSelectionAsOQLFilter(ref string s,bool selOnly){return Dbl.GetSelectionAsOQLFilter(ref s,selOnly); }
        public void InitIfNotDoneYet(){ Dbl.InitIfNotDoneYet(); }
        public bool IsCtrlCreated(){return Dbl.IsCtrlCreated(); }
        public bool MoveNextSelectedLine(ref int i){ return Dbl.MoveNextSelectedLine(ref i); }
        public void MustBePresent(string path){ Dbl.MustBePresent(path); }
        public void ReCreateCtrl(){ Dbl.ReCreateCtrl(); }
        public void Resize(IntPtr hpanel) {  Dbl.Resize(hpanel); }
        public void Requery(){ Dbl.Requery(); }
        public void ResetFilter(){ Dbl.ResetFilter(); }
        public void ResetOrder(){ Dbl.ResetOrder(); }
        public void ResetToDefaultQuery(){ Dbl.ResetToDefaultQuery(); }
        public void SetConfigName(string confgN){ Dbl.SetConfigName(confgN); }
        public void SetFilter(string oqlFilter){ Dbl.SetFilter(oqlFilter); }
        public void SetParams(int param1,int param2){ Dbl.SetParams(param1,param2); }
        public bool SetInBag(int bagid) { return Dbl.SetInBag(bagid); } 
        public void SetTable(string Table){ Dbl.SetTable(Table); }
    }
    //public interface IIMDBListWrapper {
    //    bool eventHandled;
    //    IMDBListHandler EventHandler;
    //    object EventParam;

    //    void AddColumn(string path,string Title,string Fmt,int colWidth);
    //    void AddSortField(string path,OrderDirection dir);
    //    void AllowUserFilter(bool yesno);
    //    void AllowUserOrder(bool yesno);
    //    void CreateCtrl(IntPtr parent);
    //    void Destroy();
    //    static void Free(int num);
    //    static IMDBListWrapper Get(int num);
    //    bool GetCurrentLineData(string path,ref double i);
    //    bool GetCurrentLineData(string path,ref int i);
    //    bool GetCurrentLineData(string path,ref string i);
    //    int GetSelectedCount();
    //    bool GetSelectedLineData(string path,ref double i);
    //    bool GetSelectedLineData(string path,ref int i);
    //    bool GetSelectedLineData(string path,ref string i);
    //    bool GetSelectionAsOQLFilter(ref string s,bool selOnly);
    //    void InitIfNotDoneYet();
    //    bool IsCtrlCreated();
    //    bool MoveNextSelectedLine(ref int i);
    //    void MustBePresent(string path);
    //    static IMDBListWrapper New(IMDBListHandler hr);
    //    void ReCreateCtrl();
    //    void Requery();
    //    void ResetFilter();
    //    void ResetOrder();
    //    void ResetToDefaultQuery();
    //    void SetConfigName(string confgN);
    //    void SetFilter(string oqlFilter);
    //    void SetParams(int param1,int param2);
    //    void SetTable(string Table);
    //}
}
