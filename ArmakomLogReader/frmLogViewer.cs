using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraGrid.Columns;

namespace ArmakomLogReader
{
    public partial class frmLogViewer : Form
    {
        #region Members
        private const string RecentlyUsedFileXmlFileName = "RecenlyUsedFiles.xml";

        private List<LogRecord>     mdataSource          = null;
        private frmLogDetail        mLogDetailViewerForm = null;
        private List<string>        mRecentFiles         = null;        
        #endregion

        #region Constructors
        public frmLogViewer()
        {
            InitializeComponent();
            openFileDialog.Multiselect = false;            
            LogLevels.FillLevelColors();
            DetachEvents();
            AttachEvents();
            FillLevelCombo();
            GetDefaultPath();
            ReadRecenltyUsedFilesFromXmlFile();            
        }
        #endregion

        #region Private Methods
        private void AttachEvents()
        {
            btnBrowseFile.Click              += OnBrowseFileClick;
            grdViewerLogViewer.RowClick      += OnGridViewRowClick;
            cmbLogLevel.SelectedIndexChanged += OnLevelFilterSelectedIndexChanged;
            grdViewerLogViewer.RowStyle      += OnViewerLogViewerRowStyle;
            btnRefresh.Click                 += OnRefreshClick;
            btnClear.Click                   += OnClearClick;
            btnShowSampleConfig.Click        += OnShowSampleConfigClick;            
            this.FormClosing                 += OnFormClosing;
            chkListLoggers.ItemCheck         += OnchkListLoggersItemCheck;
        }                 

        private void DetachEvents()
        {
            btnBrowseFile.Click              -= OnBrowseFileClick;
            grdViewerLogViewer.RowClick      -= OnGridViewRowClick;
            cmbLogLevel.SelectedIndexChanged -= OnLevelFilterSelectedIndexChanged;
            grdViewerLogViewer.RowStyle      -= OnViewerLogViewerRowStyle;
            btnRefresh.Click                 -= OnRefreshClick;
            btnClear.Click                   -= OnClearClick;
            btnShowSampleConfig.Click        -= OnShowSampleConfigClick;
        }

        private bool OpenFolderDialog()
        {
            return openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK;
        }

        private void OpenLogFile()
        {
            string          fileName    = openFileDialog.FileName;            
            LogRecord       logRecord   = null;

            ClearDataSource();

            try
            {
                //StringBuilder sb = GetFileToString(fileName);
                //string[] logTextLines = sb.ToString().Split(new string[] { "|;#;|" }, StringSplitOptions.None);
                string line = null;

                using (StreamReader reader = new StreamReader(fileName))            
                {
                    while (!reader.EndOfStream)
                    {
                        //logRecord = GetLogRecord(reader.ReadLine().Replace("|;#;|", ""));
                        line += reader.ReadLine();
                        if (line.Contains("|;#;|"))
                        {   
                            logRecord = GetLogRecord(line.Replace("|;#;|", ""));
                            if (logRecord != null)
                            {
                                mdataSource.Add(logRecord);
                            }
                            line = null;
                        }
                    }                    
                }

                SetGridDataSource(mdataSource);
                OnLevelFilterSelectedIndexChanged(this, EventArgs.Empty);
                lblLogName.Text = openFileDialog.SafeFileName;
                AddToLastUsedFiles(openFileDialog.FileName);                
                SetCheckBoxes();
            }
            catch (Exception ex)
            {                
                MessageBox.Show(string.Format("Error when reading file. {0}", ex.ToString()));
            }            
        }

        private StringBuilder GetFileToString(string fileName)
        {
            //string logText = File.ReadAllText(fileName);
            //return logText.Split(new string[] { "|;#;|" }, StringSplitOptions.None);
            StringBuilder logText = null;
            using (StreamReader reader = new StreamReader(fileName))
            {
                logText = new StringBuilder(reader.ReadToEnd());
            }
            return logText;            
        }        

        private void SetGridDataSource(List<LogRecord> logs)
        {
            grdControlLogViewer.DataSource = null;
            grdControlLogViewer.DataSource = logs;            
            CheckLevelFilterEnablity();            
        }

        private void SetCheckBoxes()
        {
            if (grdControlLogViewer.DataSource != null)
            {
                List<string> loggers = (from l in (grdControlLogViewer.DataSource as List<LogRecord>)
                                    group l by l.Logger into loggerList
                                    select loggerList.Key).ToList();
            
                chkListLoggers.DataSource = loggers;
            }
        }

        private void CheckLevelFilterEnablity()
        {
            cmbLogLevel.Enabled = mdataSource != null && mdataSource.Count > 0;
        }

        private LogRecord GetLogRecord(string line)
        {
            if (string.IsNullOrEmpty(line) || line == Environment.NewLine)
                return null;

            string[] fields  = line.Split(new string[] {"|#|"}, StringSplitOptions.None);
            LogRecord record = null;
            try
            {
                record = new LogRecord
                {
                    LogTime   = DateTime.Parse(fields[(int)LogRecord.FieldIndex.LogTime]),
                    Logger    = fields[(int)LogRecord.FieldIndex.Logger],                
                    Level     = fields[(int)LogRecord.FieldIndex.Level],
                    Message   = fields[(int)LogRecord.FieldIndex.Message],
                    Exception = fields[(int)LogRecord.FieldIndex.Exception],
                    CallSite  = fields[(int)LogRecord.FieldIndex.CallSite],                
                };
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Error when parsing line: {0}. Exception: {1}", line, ex.ToString()));
            }           
            
            return record;
        }

        private void OpenDetailViewer(LogRecord record)
        {
            LogDetailViewerForm.DisplayLogDetails(record);
        }

        private void ClearDataSource()
        {
            mdataSource = new List<LogRecord>();            
            SetGridDataSource(null);
        }

        private void FillLevelCombo()
        {
            List<string> Levels = new List<string>();
            Levels.Add(string.Empty);
            foreach (var level in LogLevels.GetLevelEnum())
            {
                Levels.Add(level.ToString());
            }
            cmbLogLevel.DataSource = Levels;            
            CheckLevelFilterEnablity();
        }

        private void GetDefaultPath()
        {
            txtFilePath.Text                = Properties.Settings.Default.DefaultFileName;
            openFileDialog.InitialDirectory = Properties.Settings.Default.DefaultFileName;
        }

        private bool ValidateFile()
        {
            bool result             = false;
            openFileDialog.FileName = txtFilePath.Text;
            if (File.Exists(txtFilePath.Text))
            {
                result = true;
            } 
            else
            {
                MessageBox.Show("Böyle bir dosya yok.");
            }
            return result;
        }

        private void AddToLastUsedFiles(string fileName)
        {
            if (!mRecentFiles.Contains(fileName))
            {
                mRecentFiles.Add(fileName);
            }
            RefreshRecentFilesMenuBar();
        }

        private void RefreshRecentFilesMenuBar()
        {
            barSubItemRecentUsed.ItemLinks.Clear();
            foreach (string fileName in mRecentFiles)
            {
                DevExpress.XtraBars.BarButtonItem barButton = new DevExpress.XtraBars.BarButtonItem(barManager, fileName);                
                barButton.ItemClick += OnBarItemClick;
                barSubItemRecentUsed.ItemLinks.Add(barButton);
            }
        }

        private void WriteRecentlyUsedFiles()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.TableName = "RecentlyUsedFiles";
                dt.Columns.Add("fileName", typeof(string));

                foreach (string fileName in mRecentFiles)
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = fileName;
                    dt.Rows.Add(dr);
                }

                dt.WriteXml(RecentlyUsedFileXmlFileName);            
            }
            catch (Exception)
            {                
                
            }            
        }

        private void ReadRecenltyUsedFilesFromXmlFile()
        {
            mRecentFiles = new List<string>();
            if (File.Exists(RecentlyUsedFileXmlFileName))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(RecentlyUsedFileXmlFileName);

                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        mRecentFiles.Add((string)dr[0]);
                    }
                    RefreshRecentFilesMenuBar();
                }                
            }
        }
        #endregion

        #region Event Handlers
        private void OnBrowseFileClick(object sender, EventArgs e)
        {
            bool result = OpenFolderDialog();
            if (result)
            {
                txtFilePath.Text = openFileDialog.FileName;
                OpenLogFile();
            }            
        }

        private void OnGridViewRowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                LogRecord record = grdViewerLogViewer.GetRow(e.RowHandle) as LogRecord;
                if (record != null)
                {
                    OpenDetailViewer(record);
                }                
            }
        }    

        private void OnLevelFilterSelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbLogLevel.SelectedValue as string;
            if (selectedValue != string.Empty)
            {                
                SetGridDataSource(mdataSource.Where(x => x.Level == selectedValue).ToList());
            }
            else
            {
                if (mdataSource != null)
                {
                    SetGridDataSource(mdataSource);
                }
            }
        }

        private void OnViewerLogViewerRowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                string level = grdViewerLogViewer.GetRowCellValue(e.RowHandle, colLevel) as string;
                if (level != null)
                {
                    e.Appearance.BackColor = LogLevels.GetLevelColor(level);
                }
            }            
        }

        private void OnRefreshClick(object sender, EventArgs e)
        {
            if (txtFilePath.Text != null && ValidateFile())
            {
                OpenLogFile();
            }
        }

        private void OnClearClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                grdControlLogViewer.DataSource = null;
                if (File.Exists(txtFilePath.Text))
                {
                    //File.Delete(txtFilePath.Text);
                    File.WriteAllText(txtFilePath.Text, string.Empty);
                }
            }            
        }

        private void OnShowSampleConfigClick(object sender, EventArgs e)
        {
            frmConfigDisplayer displayer = new frmConfigDisplayer();
            displayer.Show();
        }

        private void OnBarItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtFilePath.Text = e.Item.Caption;
            OnRefreshClick(this, EventArgs.Empty);            
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            WriteRecentlyUsedFiles();            
        }

        private delegate void refreshCallBack(object sender, EventArgs e);
        private void OnTimerElapsed(object sender, EventArgs e)
        {
            if (grdControlLogViewer.InvokeRequired)
            {
                refreshCallBack callBack = new refreshCallBack(OnTimerElapsed);
                grdControlLogViewer.Invoke(callBack, new object[] { sender, e });
            }
            else
            {
                OnRefreshClick(this, EventArgs.Empty);
            }            
        }          

        private void OnchkListLoggersItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            string filterInfo = "";
            foreach (var s in chkListLoggers.CheckedItems)
            {
                filterInfo += string.Format("OR [Logger] = '{0}'", s);
            }

            if (filterInfo.Length > 2 && filterInfo.Substring(0, 2) == "OR")
            {
                filterInfo = filterInfo.Substring(3);
            }

            if (string.IsNullOrEmpty(filterInfo.Trim()))
            {
                colLogger.ClearFilter();
            }
            else
            {
                colLogger.FilterInfo = new ColumnFilterInfo(filterInfo);
            } 
        }   
        #endregion        

        #region Properties
        public frmLogDetail LogDetailViewerForm
        {
            get
            {
                if (mLogDetailViewerForm == null)
                {
                    mLogDetailViewerForm = new frmLogDetail();
                }
                return mLogDetailViewerForm;
            }
        }
        #endregion

        private void bbQuickLogSHS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string path = @"C:\Program Files (x86)\JEMUS\Santral Haberlesme Servisi\AppLog\SHS.log";
            txtFilePath.Text = path;
            OnRefreshClick(null, null);
            
        }

        private void bbQuickLogConsole_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string path = @"C:\Program Files (x86)\JEMUS\Telsiz Çağrı ve Takip Uygulama Yazılımı\AppLog\JEMUSConsole.log";
            txtFilePath.Text = path;
            OnRefreshClick(null, null);
        }

        private void bbQuickLog156_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string path = @"C:\Program Files (x86)\JEMUS\156 Jandarma İmdat Uygulama Yazılımı\AppLog\Jemus156Log.log";
            txtFilePath.Text = path;
            OnRefreshClick(null, null);
        }
    }
}
