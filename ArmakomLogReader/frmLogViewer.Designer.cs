namespace ArmakomLogReader
{
    partial class frmLogViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogViewer));
            this.grdControlLogViewer = new DevExpress.XtraGrid.GridControl();
            this.grdViewerLogViewer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLogTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogger = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colException = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCallSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbLogLevel = new System.Windows.Forms.ComboBox();
            this.lblFilterByLevel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShowSampleConfig = new System.Windows.Forms.Button();
            this.lblLogName = new System.Windows.Forms.Label();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItemRecentUsed = new DevExpress.XtraBars.BarSubItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.chkListLoggers = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.bbQuick = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.bbQuickLogSHS = new DevExpress.XtraBars.BarButtonItem();
            this.bbQuickLogConsole = new DevExpress.XtraBars.BarButtonItem();
            this.bbQuickLog156 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlLogViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewerLogViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkListLoggers)).BeginInit();
            this.SuspendLayout();
            // 
            // grdControlLogViewer
            // 
            this.grdControlLogViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdControlLogViewer.Location = new System.Drawing.Point(12, 82);
            this.grdControlLogViewer.MainView = this.grdViewerLogViewer;
            this.grdControlLogViewer.Name = "grdControlLogViewer";
            this.grdControlLogViewer.Size = new System.Drawing.Size(1252, 646);
            this.grdControlLogViewer.TabIndex = 0;
            this.grdControlLogViewer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewerLogViewer});
            // 
            // grdViewerLogViewer
            // 
            this.grdViewerLogViewer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLogTime,
            this.colLogger,
            this.colLevel,
            this.colMessage,
            this.colException,
            this.colCallSite});
            this.grdViewerLogViewer.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdViewerLogViewer.GridControl = this.grdControlLogViewer;
            this.grdViewerLogViewer.Name = "grdViewerLogViewer";
            this.grdViewerLogViewer.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdViewerLogViewer.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdViewerLogViewer.OptionsBehavior.Editable = false;
            this.grdViewerLogViewer.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdViewerLogViewer.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.grdViewerLogViewer.OptionsView.ShowAutoFilterRow = true;
            this.grdViewerLogViewer.OptionsView.ShowGroupPanel = false;
            this.grdViewerLogViewer.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colLogTime, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colLogTime
            // 
            this.colLogTime.Caption = "Log Time";
            this.colLogTime.DisplayFormat.FormatString = "MM:dd:yyyy HH:mm:ss.fff";
            this.colLogTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLogTime.FieldName = "LogTime";
            this.colLogTime.Name = "colLogTime";
            this.colLogTime.Visible = true;
            this.colLogTime.VisibleIndex = 0;
            // 
            // colLogger
            // 
            this.colLogger.Caption = "Logger";
            this.colLogger.FieldName = "Logger";
            this.colLogger.Name = "colLogger";
            this.colLogger.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.colLogger.Visible = true;
            this.colLogger.VisibleIndex = 1;
            // 
            // colLevel
            // 
            this.colLevel.Caption = "Level";
            this.colLevel.FieldName = "Level";
            this.colLevel.Name = "colLevel";
            this.colLevel.Visible = true;
            this.colLevel.VisibleIndex = 2;
            // 
            // colMessage
            // 
            this.colMessage.Caption = "Message";
            this.colMessage.FieldName = "Message";
            this.colMessage.Name = "colMessage";
            this.colMessage.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMessage.Visible = true;
            this.colMessage.VisibleIndex = 3;
            // 
            // colException
            // 
            this.colException.Caption = "Exception";
            this.colException.FieldName = "Exception";
            this.colException.Name = "colException";
            this.colException.Visible = true;
            this.colException.VisibleIndex = 4;
            // 
            // colCallSite
            // 
            this.colCallSite.Caption = "Call Site";
            this.colCallSite.FieldName = "CallSite";
            this.colCallSite.Name = "colCallSite";
            this.colCallSite.Visible = true;
            this.colCallSite.VisibleIndex = 5;
            // 
            // cmbLogLevel
            // 
            this.cmbLogLevel.FormattingEnabled = true;
            this.cmbLogLevel.Location = new System.Drawing.Point(95, 55);
            this.cmbLogLevel.Name = "cmbLogLevel";
            this.cmbLogLevel.Size = new System.Drawing.Size(184, 21);
            this.cmbLogLevel.TabIndex = 1;
            // 
            // lblFilterByLevel
            // 
            this.lblFilterByLevel.AutoSize = true;
            this.lblFilterByLevel.Location = new System.Drawing.Point(12, 58);
            this.lblFilterByLevel.Name = "lblFilterByLevel";
            this.lblFilterByLevel.Size = new System.Drawing.Size(54, 13);
            this.lblFilterByLevel.TabIndex = 2;
            this.lblFilterByLevel.Text = "Log Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log File";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(95, 21);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(284, 20);
            this.txtFilePath.TabIndex = 4;
            this.txtFilePath.Text = "D:\\Projects\\ArmakomLogReader\\LogTesterLib.txt";
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(385, 20);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(47, 23);
            this.btnBrowseFile.TabIndex = 5;
            this.btnBrowseFile.Text = "...";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "D:\\Projects\\ArmakomUpdater\\ArmakomUpdaterWebService\\AppLog\\ArmakomUpdaterWebServi" +
    "ce\\ArmakomUpdaterWebService.App_Code.CommonUtility.txt";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(438, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Güncelle";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(558, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnShowSampleConfig
            // 
            this.btnShowSampleConfig.Location = new System.Drawing.Point(672, 22);
            this.btnShowSampleConfig.Name = "btnShowSampleConfig";
            this.btnShowSampleConfig.Size = new System.Drawing.Size(114, 23);
            this.btnShowSampleConfig.TabIndex = 8;
            this.btnShowSampleConfig.Text = "Örnek Konfig";
            this.btnShowSampleConfig.UseVisualStyleBackColor = true;
            // 
            // lblLogName
            // 
            this.lblLogName.AutoSize = true;
            this.lblLogName.Location = new System.Drawing.Point(857, 24);
            this.lblLogName.Name = "lblLogName";
            this.lblLogName.Size = new System.Drawing.Size(63, 13);
            this.lblLogName.TabIndex = 9;
            this.lblLogName.Text = "lblLogName";
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barSubItemRecentUsed,
            this.bbQuick,
            this.barSubItem2,
            this.bbQuickLogSHS,
            this.bbQuickLogConsole,
            this.bbQuickLog156});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Dosya";
            this.barSubItem1.Id = 0;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemRecentUsed),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barSubItemRecentUsed
            // 
            this.barSubItemRecentUsed.Caption = "Son Kullanılanlar";
            this.barSubItemRecentUsed.Id = 2;
            this.barSubItemRecentUsed.Name = "barSubItemRecentUsed";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1276, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 742);
            this.barDockControlBottom.Size = new System.Drawing.Size(1276, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 720);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1276, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 720);
            // 
            // chkListLoggers
            // 
            this.chkListLoggers.CheckOnClick = true;
            this.chkListLoggers.Location = new System.Drawing.Point(966, 12);
            this.chkListLoggers.Name = "chkListLoggers";
            this.chkListLoggers.Size = new System.Drawing.Size(298, 59);
            this.chkListLoggers.TabIndex = 25;
            // 
            // bbQuick
            // 
            this.bbQuick.Caption = "Varsayılan Loglar";
            this.bbQuick.Id = 3;
            this.bbQuick.Name = "bbQuick";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Varsayılan Loglar";
            this.barSubItem2.Id = 4;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbQuickLogSHS),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbQuickLogConsole),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbQuickLog156)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // bbQuickLogSHS
            // 
            this.bbQuickLogSHS.Caption = "SHS x86";
            this.bbQuickLogSHS.Id = 5;
            this.bbQuickLogSHS.Name = "bbQuickLogSHS";
            this.bbQuickLogSHS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbQuickLogSHS_ItemClick);
            // 
            // bbQuickLogConsole
            // 
            this.bbQuickLogConsole.Caption = "Konsol x86";
            this.bbQuickLogConsole.Id = 6;
            this.bbQuickLogConsole.Name = "bbQuickLogConsole";
            this.bbQuickLogConsole.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbQuickLogConsole_ItemClick);
            // 
            // bbQuickLog156
            // 
            this.bbQuickLog156.Caption = "156 x86";
            this.bbQuickLog156.Id = 7;
            this.bbQuickLog156.Name = "bbQuickLog156";
            this.bbQuickLog156.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbQuickLog156_ItemClick);
            // 
            // frmLogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 742);
            this.Controls.Add(this.chkListLoggers);
            this.Controls.Add(this.lblLogName);
            this.Controls.Add(this.btnShowSampleConfig);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFilterByLevel);
            this.Controls.Add(this.cmbLogLevel);
            this.Controls.Add(this.grdControlLogViewer);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogViewer";
            this.Text = "Armakom Log Reader";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grdControlLogViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewerLogViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkListLoggers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdControlLogViewer;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewerLogViewer;
        private System.Windows.Forms.ComboBox cmbLogLevel;
        private System.Windows.Forms.Label lblFilterByLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevExpress.XtraGrid.Columns.GridColumn colLogTime;
        private DevExpress.XtraGrid.Columns.GridColumn colLogger;
        private DevExpress.XtraGrid.Columns.GridColumn colLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colException;
        private DevExpress.XtraGrid.Columns.GridColumn colCallSite;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShowSampleConfig;
        private System.Windows.Forms.Label lblLogName;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItemRecentUsed;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.CheckedListBoxControl chkListLoggers;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem bbQuickLogSHS;
        private DevExpress.XtraBars.BarButtonItem bbQuickLogConsole;
        private DevExpress.XtraBars.BarButtonItem bbQuickLog156;
        private DevExpress.XtraBars.BarButtonItem bbQuick;
    }
}

