namespace MapControlApplication111 {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      //Ensures that any ESRI libraries that have been used are unloaded in the correct order. 
      //Failure to do this may result in random crashes on exit due to the operating system unloading 
      //the libraries in the incorrect order. 
      ESRI.ArcGIS.ADF.COMSupport.AOUninitialize.Shutdown();

      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
      this.menuNewDoc = new System.Windows.Forms.ToolStripMenuItem();
      this.menuOpenDoc = new System.Windows.Forms.ToolStripMenuItem();
      this.menuSaveDoc = new System.Windows.Forms.ToolStripMenuItem();
      this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
      this.miPrint = new System.Windows.Forms.ToolStripMenuItem();
      this.menuSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.menuExitApp = new System.Windows.Forms.ToolStripMenuItem();
      this.miOutput = new System.Windows.Forms.ToolStripMenuItem();
      this.miCreateBookmark = new System.Windows.Forms.ToolStripMenuItem();
      this.cbBookmarkList = new System.Windows.Forms.ToolStripComboBox();
      this.miSpaceData = new System.Windows.Forms.ToolStripMenuItem();
      this.miAccessData = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.miRenderSimply = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      this.miMap = new System.Windows.Forms.ToolStripMenuItem();
      this.miPageLayer = new System.Windows.Forms.ToolStripMenuItem();
      this.miData = new System.Windows.Forms.ToolStripMenuItem();
      this.miCreateShapefile = new System.Windows.Forms.ToolStripMenuItem();
      this.miAddFeature = new System.Windows.Forms.ToolStripMenuItem();
      this.miSpaceAnalysis = new System.Windows.Forms.ToolStripMenuItem();
      this.miSpaceFilter = new System.Windows.Forms.ToolStripMenuItem();
      this.miInfo = new System.Windows.Forms.ToolStripMenuItem();
      this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
      this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
      this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
      this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.statusBarXY = new System.Windows.Forms.ToolStripStatusLabel();
      this.axPageLayoutControl1 = new ESRI.ArcGIS.Controls.AxPageLayoutControl();
      this.miTopo = new System.Windows.Forms.ToolStripMenuItem();
      this.miBuffer = new System.Windows.Forms.ToolStripMenuItem();
      this.miSearch = new System.Windows.Forms.ToolStripMenuItem();
      this.miTableList = new System.Windows.Forms.ToolStripMenuItem();
      this.miStatistics = new System.Windows.Forms.ToolStripMenuItem();
      this.miStat = new System.Windows.Forms.ToolStripMenuItem();
      this.miShowLength = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
      this.statusStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.axPageLayoutControl1)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.miCreateBookmark,
            this.cbBookmarkList,
            this.miSpaceData,
            this.toolStripMenuItem1,
            this.miData,
            this.miSpaceAnalysis,
            this.miTopo,
            this.miStatistics});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1145, 32);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // menuFile
      // 
      this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewDoc,
            this.menuOpenDoc,
            this.menuSaveDoc,
            this.menuSaveAs,
            this.miPrint,
            this.menuSeparator,
            this.menuExitApp,
            this.miOutput});
      this.menuFile.Name = "menuFile";
      this.menuFile.Size = new System.Drawing.Size(53, 28);
      this.menuFile.Text = "文件";
      // 
      // menuNewDoc
      // 
      this.menuNewDoc.Image = ((System.Drawing.Image)(resources.GetObject("menuNewDoc.Image")));
      this.menuNewDoc.ImageTransparentColor = System.Drawing.Color.White;
      this.menuNewDoc.Name = "menuNewDoc";
      this.menuNewDoc.Size = new System.Drawing.Size(152, 26);
      this.menuNewDoc.Text = "新建";
      this.menuNewDoc.Click += new System.EventHandler(this.menuNewDoc_Click);
      // 
      // menuOpenDoc
      // 
      this.menuOpenDoc.Image = ((System.Drawing.Image)(resources.GetObject("menuOpenDoc.Image")));
      this.menuOpenDoc.ImageTransparentColor = System.Drawing.Color.White;
      this.menuOpenDoc.Name = "menuOpenDoc";
      this.menuOpenDoc.Size = new System.Drawing.Size(152, 26);
      this.menuOpenDoc.Text = "打开";
      this.menuOpenDoc.Click += new System.EventHandler(this.menuOpenDoc_Click);
      // 
      // menuSaveDoc
      // 
      this.menuSaveDoc.Image = ((System.Drawing.Image)(resources.GetObject("menuSaveDoc.Image")));
      this.menuSaveDoc.ImageTransparentColor = System.Drawing.Color.White;
      this.menuSaveDoc.Name = "menuSaveDoc";
      this.menuSaveDoc.Size = new System.Drawing.Size(152, 26);
      this.menuSaveDoc.Text = "保存";
      this.menuSaveDoc.Click += new System.EventHandler(this.menuSaveDoc_Click);
      // 
      // menuSaveAs
      // 
      this.menuSaveAs.Name = "menuSaveAs";
      this.menuSaveAs.Size = new System.Drawing.Size(152, 26);
      this.menuSaveAs.Text = "另存为";
      this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
      // 
      // miPrint
      // 
      this.miPrint.Enabled = false;
      this.miPrint.Name = "miPrint";
      this.miPrint.Size = new System.Drawing.Size(152, 26);
      this.miPrint.Text = "打印";
      this.miPrint.Click += new System.EventHandler(this.miPrint_Click);
      // 
      // menuSeparator
      // 
      this.menuSeparator.Name = "menuSeparator";
      this.menuSeparator.Size = new System.Drawing.Size(149, 6);
      // 
      // menuExitApp
      // 
      this.menuExitApp.Name = "menuExitApp";
      this.menuExitApp.Size = new System.Drawing.Size(152, 26);
      this.menuExitApp.Text = "Exit";
      this.menuExitApp.Click += new System.EventHandler(this.menuExitApp_Click);
      // 
      // miOutput
      // 
      this.miOutput.Name = "miOutput";
      this.miOutput.Size = new System.Drawing.Size(152, 26);
      this.miOutput.Text = "地图输出";
      this.miOutput.Click += new System.EventHandler(this.miOutput_Click);
      // 
      // miCreateBookmark
      // 
      this.miCreateBookmark.Name = "miCreateBookmark";
      this.miCreateBookmark.Size = new System.Drawing.Size(83, 28);
      this.miCreateBookmark.Text = "创建书签";
      this.miCreateBookmark.Click += new System.EventHandler(this.micreateBookmark_Click);
      // 
      // cbBookmarkList
      // 
      this.cbBookmarkList.Name = "cbBookmarkList";
      this.cbBookmarkList.Size = new System.Drawing.Size(160, 28);
      this.cbBookmarkList.SelectedIndexChanged += new System.EventHandler(this.cbBookmarkList_selectedIndexChanged);
      // 
      // miSpaceData
      // 
      this.miSpaceData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAccessData});
      this.miSpaceData.Name = "miSpaceData";
      this.miSpaceData.Size = new System.Drawing.Size(83, 28);
      this.miSpaceData.Text = "空间数据";
      // 
      // miAccessData
      // 
      this.miAccessData.Name = "miAccessData";
      this.miAccessData.Size = new System.Drawing.Size(182, 26);
      this.miAccessData.Text = "访问图层数据";
      this.miAccessData.Click += new System.EventHandler(this.miAccessData_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRenderSimply,
            this.toolStripMenuItem3,
            this.miMap,
            this.miPageLayer});
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(83, 28);
      this.toolStripMenuItem1.Text = "地图表现";
      // 
      // miRenderSimply
      // 
      this.miRenderSimply.Name = "miRenderSimply";
      this.miRenderSimply.Size = new System.Drawing.Size(197, 26);
      this.miRenderSimply.Text = "简单地图渲染";
      this.miRenderSimply.Click += new System.EventHandler(this.miRenderSimply_Click);
      // 
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size(197, 26);
      this.toolStripMenuItem3.Text = "获取渲染器信息";
      this.toolStripMenuItem3.Click += new System.EventHandler(this.miGetRenderInfo_Click);
      // 
      // miMap
      // 
      this.miMap.Checked = true;
      this.miMap.CheckState = System.Windows.Forms.CheckState.Checked;
      this.miMap.Name = "miMap";
      this.miMap.Size = new System.Drawing.Size(197, 26);
      this.miMap.Text = "显示地图";
      this.miMap.Click += new System.EventHandler(this.miMap_Click);
      // 
      // miPageLayer
      // 
      this.miPageLayer.Name = "miPageLayer";
      this.miPageLayer.Size = new System.Drawing.Size(197, 26);
      this.miPageLayer.Text = "显示页面布局";
      this.miPageLayer.Click += new System.EventHandler(this.miPageLayer_Click);
      // 
      // miData
      // 
      this.miData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCreateShapefile,
            this.miAddFeature});
      this.miData.Name = "miData";
      this.miData.Size = new System.Drawing.Size(83, 28);
      this.miData.Text = "数据操作";
      // 
      // miCreateShapefile
      // 
      this.miCreateShapefile.Name = "miCreateShapefile";
      this.miCreateShapefile.Size = new System.Drawing.Size(197, 26);
      this.miCreateShapefile.Text = "创建Shape文件";
      this.miCreateShapefile.Click += new System.EventHandler(this.miCreatShapefile_Click);
      // 
      // miAddFeature
      // 
      this.miAddFeature.Enabled = false;
      this.miAddFeature.Name = "miAddFeature";
      this.miAddFeature.Size = new System.Drawing.Size(197, 26);
      this.miAddFeature.Text = "添加要素";
      this.miAddFeature.Click += new System.EventHandler(this.miAddFeature_Click);
      // 
      // miSpaceAnalysis
      // 
      this.miSpaceAnalysis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSpaceFilter,
            this.miInfo});
      this.miSpaceAnalysis.Name = "miSpaceAnalysis";
      this.miSpaceAnalysis.Size = new System.Drawing.Size(83, 28);
      this.miSpaceAnalysis.Text = "空间分析";
      // 
      // miSpaceFilter
      // 
      this.miSpaceFilter.Name = "miSpaceFilter";
      this.miSpaceFilter.Size = new System.Drawing.Size(224, 26);
      this.miSpaceFilter.Text = "空间查询";
      this.miSpaceFilter.Click += new System.EventHandler(this.miSpaceFilter_Click);
      // 
      // miInfo
      // 
      this.miInfo.Name = "miInfo";
      this.miInfo.Size = new System.Drawing.Size(224, 26);
      this.miInfo.Text = "属性信息";
      // 
      // axMapControl1
      // 
      this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.axMapControl1.Location = new System.Drawing.Point(0, 0);
      this.axMapControl1.Margin = new System.Windows.Forms.Padding(4);
      this.axMapControl1.Name = "axMapControl1";
      this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
      this.axMapControl1.Size = new System.Drawing.Size(1145, 676);
      this.axMapControl1.TabIndex = 2;
      this.axMapControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl1_OnMouseDown);
      this.axMapControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl1_OnMouseMove);
      this.axMapControl1.OnMapReplaced += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMapReplacedEventHandler(this.axMapControl1_OnMapReplaced);
      // 
      // axToolbarControl1
      // 
      this.axToolbarControl1.Dock = System.Windows.Forms.DockStyle.Top;
      this.axToolbarControl1.Location = new System.Drawing.Point(0, 32);
      this.axToolbarControl1.Margin = new System.Windows.Forms.Padding(4);
      this.axToolbarControl1.Name = "axToolbarControl1";
      this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
      this.axToolbarControl1.Size = new System.Drawing.Size(1145, 28);
      this.axToolbarControl1.TabIndex = 3;
      // 
      // axTOCControl1
      // 
      this.axTOCControl1.Dock = System.Windows.Forms.DockStyle.Left;
      this.axTOCControl1.Location = new System.Drawing.Point(4, 60);
      this.axTOCControl1.Margin = new System.Windows.Forms.Padding(4);
      this.axTOCControl1.Name = "axTOCControl1";
      this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
      this.axTOCControl1.Size = new System.Drawing.Size(235, 590);
      this.axTOCControl1.TabIndex = 4;
      this.axTOCControl1.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.axTOCControl1_OnMouseDown);
      // 
      // axLicenseControl1
      // 
      this.axLicenseControl1.Enabled = true;
      this.axLicenseControl1.Location = new System.Drawing.Point(466, 278);
      this.axLicenseControl1.Margin = new System.Windows.Forms.Padding(4);
      this.axLicenseControl1.Name = "axLicenseControl1";
      this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
      this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
      this.axLicenseControl1.TabIndex = 5;
      // 
      // splitter1
      // 
      this.splitter1.Location = new System.Drawing.Point(0, 60);
      this.splitter1.Margin = new System.Windows.Forms.Padding(4);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(4, 616);
      this.splitter1.TabIndex = 6;
      this.splitter1.TabStop = false;
      // 
      // statusStrip1
      // 
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarXY});
      this.statusStrip1.Location = new System.Drawing.Point(4, 650);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
      this.statusStrip1.Size = new System.Drawing.Size(1141, 26);
      this.statusStrip1.Stretch = false;
      this.statusStrip1.TabIndex = 7;
      this.statusStrip1.Text = "statusBar1";
      // 
      // statusBarXY
      // 
      this.statusBarXY.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
      this.statusBarXY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.statusBarXY.Name = "statusBarXY";
      this.statusBarXY.Size = new System.Drawing.Size(54, 20);
      this.statusBarXY.Text = "@麒麟";
      // 
      // axPageLayoutControl1
      // 
      this.axPageLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.axPageLayoutControl1.Location = new System.Drawing.Point(0, 0);
      this.axPageLayoutControl1.Name = "axPageLayoutControl1";
      this.axPageLayoutControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPageLayoutControl1.OcxState")));
      this.axPageLayoutControl1.Size = new System.Drawing.Size(1145, 676);
      this.axPageLayoutControl1.TabIndex = 8;
      this.axPageLayoutControl1.Visible = false;
      this.axPageLayoutControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IPageLayoutControlEvents_Ax_OnMouseDownEventHandler(this.axPageLayoutControl1_OnMouseDown);
      // 
      // miTopo
      // 
      this.miTopo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miBuffer});
      this.miTopo.Name = "miTopo";
      this.miTopo.Size = new System.Drawing.Size(83, 28);
      this.miTopo.Text = "拓扑分析";
      // 
      // miBuffer
      // 
      this.miBuffer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSearch,
            this.miTableList});
      this.miBuffer.Name = "miBuffer";
      this.miBuffer.Size = new System.Drawing.Size(224, 26);
      this.miBuffer.Text = "缓冲区分析";
      // 
      // miSearch
      // 
      this.miSearch.Name = "miSearch";
      this.miSearch.Size = new System.Drawing.Size(224, 26);
      this.miSearch.Text = "查询";
      this.miSearch.Click += new System.EventHandler(this.miSearch_Click);
      // 
      // miTableList
      // 
      this.miTableList.Name = "miTableList";
      this.miTableList.Size = new System.Drawing.Size(224, 26);
      this.miTableList.Text = "属性列表";
      // 
      // miStatistics
      // 
      this.miStatistics.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miStat,
            this.miShowLength});
      this.miStatistics.Name = "miStatistics";
      this.miStatistics.Size = new System.Drawing.Size(83, 28);
      this.miStatistics.Text = "数据统计";
      // 
      // miStat
      // 
      this.miStat.Name = "miStat";
      this.miStat.Size = new System.Drawing.Size(224, 26);
      this.miStat.Text = "要素统计";
      this.miStat.Click += new System.EventHandler(this.miStat_Click);
      // 
      // miShowLength
      // 
      this.miShowLength.Name = "miShowLength";
      this.miShowLength.Size = new System.Drawing.Size(224, 26);
      this.miShowLength.Text = "长度测定";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1145, 676);
      this.Controls.Add(this.axLicenseControl1);
      this.Controls.Add(this.axTOCControl1);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.splitter1);
      this.Controls.Add(this.axToolbarControl1);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.axMapControl1);
      this.Controls.Add(this.axPageLayoutControl1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "MainForm";
      this.Text = "ArcEngine Controls Application";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.Click += new System.EventHandler(this.micreateBookmark_Click);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.axPageLayoutControl1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem menuFile;
    private System.Windows.Forms.ToolStripMenuItem menuNewDoc;
    private System.Windows.Forms.ToolStripMenuItem menuOpenDoc;
    private System.Windows.Forms.ToolStripMenuItem menuSaveDoc;
    private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
    private System.Windows.Forms.ToolStripMenuItem menuExitApp;
    private System.Windows.Forms.ToolStripSeparator menuSeparator;
    private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
    private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
    private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
    private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
    private System.Windows.Forms.Splitter splitter1;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel statusBarXY;
    private System.Windows.Forms.ToolStripMenuItem miCreateBookmark;
    private System.Windows.Forms.ToolStripComboBox cbBookmarkList;
    private System.Windows.Forms.ToolStripMenuItem miSpaceData;
    private System.Windows.Forms.ToolStripMenuItem miAccessData;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem miRenderSimply;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem miPrint;
    private System.Windows.Forms.ToolStripMenuItem miMap;
    private System.Windows.Forms.ToolStripMenuItem miPageLayer;
    private ESRI.ArcGIS.Controls.AxPageLayoutControl axPageLayoutControl1;
    private System.Windows.Forms.ToolStripMenuItem miOutput;
    private System.Windows.Forms.ToolStripMenuItem miData;
    private System.Windows.Forms.ToolStripMenuItem miCreateShapefile;
    private System.Windows.Forms.ToolStripMenuItem miAddFeature;
    private System.Windows.Forms.ToolStripMenuItem miSpaceAnalysis;
    private System.Windows.Forms.ToolStripMenuItem miSpaceFilter;
    private System.Windows.Forms.ToolStripMenuItem miInfo;
    private System.Windows.Forms.ToolStripMenuItem miTopo;
    private System.Windows.Forms.ToolStripMenuItem miBuffer;
    private System.Windows.Forms.ToolStripMenuItem miSearch;
    private System.Windows.Forms.ToolStripMenuItem miTableList;
    private System.Windows.Forms.ToolStripMenuItem miStatistics;
    private System.Windows.Forms.ToolStripMenuItem miStat;
    private System.Windows.Forms.ToolStripMenuItem miShowLength;
  }
}

