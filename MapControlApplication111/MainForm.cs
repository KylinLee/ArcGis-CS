using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.SystemUI;
using System;
using System.Windows.Forms;
using ESRI.ArcGIS.Output;
using ESRI.ArcGIS.Geodatabase;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.ADF;

using ESRI.ArcGIS.Geometry;


namespace MapControlApplication111 {
  public sealed partial class MainForm : Form {
    #region class private members
    private IMapControl3 m_mapControl = null;
    private string m_mapDocumentName = string.Empty;
    #endregion

    #region class constructor
    public MainForm() {
      InitializeComponent();
    }
    #endregion

    private void MainForm_Load(object sender, EventArgs e) {
      //get the MapControl
      m_mapControl = (IMapControl3)axMapControl1.Object;

      //disable the Save menu (since there is no document yet)
      menuSaveDoc.Enabled = false;
    }

    #region Main Menu event handlers
    private void menuNewDoc_Click(object sender, EventArgs e) {
      //execute New Document command
      ICommand command = new CreateNewDocument();
      command.OnCreate(m_mapControl.Object);
      command.OnClick();
    }

    private void menuOpenDoc_Click(object sender, EventArgs e) {
      //execute Open Document command
      ICommand command = new ControlsOpenDocCommandClass();
      command.OnCreate(m_mapControl.Object);
      command.OnClick();
    }

    private void menuSaveDoc_Click(object sender, EventArgs e) {
      //execute Save Document command
      if (m_mapControl.CheckMxFile(m_mapDocumentName)) {
        //create a new instance of a MapDocument
        IMapDocument mapDoc = new MapDocumentClass();
        mapDoc.Open(m_mapDocumentName, string.Empty);

        //Make sure that the MapDocument is not readonly
        if (mapDoc.get_IsReadOnly(m_mapDocumentName)) {
          MessageBox.Show("Map document is read only!");
          mapDoc.Close();
          return;
        }

        //Replace its contents with the current map
        mapDoc.ReplaceContents((IMxdContents)m_mapControl.Map);

        //save the MapDocument in order to persist it
        mapDoc.Save(mapDoc.UsesRelativePaths, false);

        //close the MapDocument
        mapDoc.Close();
      }
    }

    private void menuSaveAs_Click(object sender, EventArgs e) {
      //execute SaveAs Document command
      ICommand command = new ControlsSaveAsDocCommandClass();
      command.OnCreate(m_mapControl.Object);
      command.OnClick();
    }

    private void menuExitApp_Click(object sender, EventArgs e) {
      //exit the application
      Application.Exit();
    }
    #endregion

    //listen to MapReplaced evant in order to update the statusbar and the Save menu
    private void axMapControl1_OnMapReplaced(object sender, IMapControlEvents2_OnMapReplacedEvent e) {
      //get the current document name from the MapControl
      m_mapDocumentName = m_mapControl.DocumentFilename;

      //if there is no MapDocument, diable the Save menu and clear the statusbar
      if (m_mapDocumentName == string.Empty) {
        menuSaveDoc.Enabled = false;
        statusBarXY.Text = string.Empty;
      } else {
        //enable the Save manu and write the doc name to the statusbar
        menuSaveDoc.Enabled = true;
        statusBarXY.Text = System.IO.Path.GetFileName(m_mapDocumentName);
      }
    }

    private void axMapControl1_OnMouseMove(
        object sender,
        IMapControlEvents2_OnMouseMoveEvent e) {
      statusBarXY.Text = string.Format("{0}, {1}  {2}", e.mapX.ToString("#######.##"), e.mapY.ToString("#######.##"), axMapControl1.MapUnits.ToString().Substring(4));
    }

    private void axMapControl1_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e) {
      if(miAddFeature.Checked == true) {
        IPoint point = new PointClass();
        point.PutCoords(e.mapX, e.mapY);
        DataOperator dataOperator = new DataOperator(axMapControl1.Map);
        dataOperator.AddFeatureToLayer("Observation Stations", "�۲�վ", point);
      }
      return;
    }

    public void CreatBookmark(string sBookmarkName) {
      bool isExist = cbBookmarkList.Items.Contains(sBookmarkName);
      // �ж���ǩ���Ƿ��ظ�
      if (isExist) {
        MessageBox.Show("����ǩ�Ѵ���");
      } else {
        IAOIBookmark aoiBookmark = new AOIBookmarkClass();
        // ������ǩ�����ر���
        if (aoiBookmark != null) {
          aoiBookmark.Location = axMapControl1.ActiveView.Extent;
          aoiBookmark.Name = sBookmarkName;
        }
        IMapBookmarks bookmark = axMapControl1.Map as IMapBookmarks;
        // ������ǩ�������bookmark��
        if (bookmark != null) {
          bookmark.AddBookmark(aoiBookmark);
        }
        // ���������б�
        cbBookmarkList.Items.Add(aoiBookmark.Name);
      }
    }

    private void micreateBookmark_Click(object sender, EventArgs e) {
      AdmitBookmarkName frmABN = new AdmitBookmarkName(this);
      frmABN.Show();
    }

    private void cbBookmarkList_selectedIndexChanged(object sender, EventArgs e) {
      // ��ȡArcGIS�����bookmark��������תΪ��ö��ֵ������ѭ��
      IMapBookmarks bookmark = axMapControl1.Map as IMapBookmarks;
      IEnumSpatialBookmark enumSpatialBookmark = bookmark.Bookmarks;
      enumSpatialBookmark.Reset();
      ISpatialBookmark spatialBookmark = enumSpatialBookmark.Next();
      while (spatialBookmark != null) {
        if (cbBookmarkList.SelectedItem.ToString() == spatialBookmark.Name) {
          // �������б�����ָ������ƺ�bookmark�����ƶ�Ӧʱ���������bookmark�Ƶ���Ұ��Χ
          spatialBookmark.ZoomTo((IMap)axMapControl1.ActiveView);
          axMapControl1.ActiveView.Refresh();
          break;
        }
        // û�����У�����ö��
        spatialBookmark = enumSpatialBookmark.Next();
      }
    }
    private void miAccessData_Click(object sender, EventArgs e) {
      DataOperator dataOperator = new DataOperator(axMapControl1.Map);
      DataBoard dataBoard = new DataBoard("", dataOperator.GetContinentsNames());
      dataBoard.Show();
    }

    private void axTOCControl1_OnMouseDown(object sender, ITOCControlEvents_OnMouseDownEvent e) {

    }
    private void miRenderSimply_Click(object sender, EventArgs e) {
      DataOperator dataOperator = new DataOperator(axMapControl1.Map);
      ILayer layer = dataOperator.GetLayerByName("cities");
      IRgbColor rgbColor = new RgbColorClass();
      rgbColor.Red = 240;
      rgbColor.Green = 0;
      rgbColor.Blue = 86;

      IColor color = rgbColor as IColor;
      bool bRes = MapComposer.RenderSimply(layer, color);
      if (bRes) {
        axTOCControl1.ActiveView.ContentsChanged();
        axMapControl1.ActiveView.Refresh();
        miRenderSimply.Enabled = false;
      } else {
        MessageBox.Show("��ͼ����Ⱦ");
      }
    }
    private void miGetRenderInfo_Click(object sender, EventArgs e) {
      miRenderSimply.Enabled = true;
      DataOperator dataOperator = new DataOperator(axMapControl1.Map);
      ILayer layer = dataOperator.GetLayerByName("cities");
      MessageBox.Show(MapComposer.GetRendererTypeByLayer(layer));
    }

    private void miPageLayer_Click(object sender, EventArgs e) {
      if (miPageLayer.Checked == false) {
        axToolbarControl1.SetBuddyControl(axPageLayoutControl1.Object);
        axTOCControl1.SetBuddyControl(axPageLayoutControl1.Object);
        axPageLayoutControl1.Show();
        axMapControl1.Hide();
        miPageLayer.Checked = true;
        miMap.Checked = false;
        miPrint.Enabled = true;
      } else {
        axToolbarControl1.SetBuddyControl(axMapControl1.Object);
        axTOCControl1.SetBuddyControl(axMapControl1.Object);
        axPageLayoutControl1.Hide();
        axMapControl1.Show();
        miPageLayer.Checked = false;
        miMap.Checked = true;
        miPrint.Enabled = false;
      }
    }

    private void miMap_Click(object sender, EventArgs e) {
      if (miMap.Checked == false) {
        axToolbarControl1.SetBuddyControl(axMapControl1.Object);
        axTOCControl1.SetBuddyControl(axMapControl1.Object);
        axPageLayoutControl1.Hide();
        axMapControl1.Show();
        miPageLayer.Checked = false;
        miMap.Checked = true;
        miPrint.Enabled = false;
      } else {
        axToolbarControl1.SetBuddyControl(axPageLayoutControl1.Object);
        axTOCControl1.SetBuddyControl(axPageLayoutControl1.Object);
        axPageLayoutControl1.Show();
        axMapControl1.Hide();
        miPageLayer.Checked = true;
        miMap.Checked = false;
        miPrint.Enabled = true;
      }
    }

    private void miPrint_Click(object sender, EventArgs e) {
      IPrinter printer = axPageLayoutControl1.Printer;
      if (printer == null) {
        MessageBox.Show("�޷����Ӵ�ӡ��");
      }
      String sMsg = "�Ƿ�ʹ��Ĭ�ϴ�ӡ����" + printer.Name + "��";
      if (MessageBox.Show(sMsg, "", MessageBoxButtons.OKCancel) == DialogResult.Cancel) {
        return;
      }
      IPaper paper = printer.Paper;
      paper.Orientation = 1;
      IPage page = axPageLayoutControl1.Page;
      page.PageToPrinterMapping = esriPageToPrinterMapping.esriPageMappingScale;
      axPageLayoutControl1.PrintPageLayout(1, 1, 0);
    }

    private void axPageLayoutControl1_OnMouseDown(object sender, IPageLayoutControlEvents_OnMouseDownEvent e) {

    }
    private void miOutput_Click(object sender, EventArgs e) {
      SaveFileDialog pSaveDialog = new SaveFileDialog();
      pSaveDialog.FileName = "";
      pSaveDialog.Filter = "JPEGͼƬ��*.JPG��|*.jpg|TIFFͼƬ��*.TIF��|*.tif|PDF�ĵ���*.PDF��|*.pdf��";
      if (pSaveDialog.ShowDialog() == DialogResult.OK) {
        double iScreenDisplayResolution = axPageLayoutControl1.ActiveView.ScreenDisplay.DisplayTransformation.Resolution;
        IExporter pExporter = null;
        if (pSaveDialog.FilterIndex == 1) {
          pExporter = new JpegExporterClass();

        } else if (pSaveDialog.FilterIndex == 2) {
          pExporter = new TiffExporterClass();
        } else if (pSaveDialog.FilterIndex == 3) {
          pExporter = new PDFExporterClass();
        }
        pExporter.ExportFileName = pSaveDialog.FileName;
        pExporter.Resolution = (short)iScreenDisplayResolution;
        tagRECT deviceRect = axPageLayoutControl1.ActiveView.ScreenDisplay.DisplayTransformation.get_DeviceFrame();
        IEnvelope pDeviceEnvelope = new EnvelopeClass();
        pDeviceEnvelope.PutCoords(deviceRect.left, deviceRect.bottom, deviceRect.right, deviceRect.top);
        pExporter.PixelBounds = pDeviceEnvelope;
        ITrackCancel pCancel = new CancelTrackerClass();
        axPageLayoutControl1.ActiveView.Output(pExporter.StartExporting(), pExporter.Resolution, ref deviceRect, axPageLayoutControl1.ActiveView.Extent, pCancel);
        Application.DoEvents();
        pExporter.FinishExporting();
      }
    }

    private void toolStripTextBox1_Click(object sender, EventArgs e) {

    }
    private void miCreatShapefile_Click(object sender, EventArgs e) {
      DataOperator dataOperator = new DataOperator(axMapControl1.Map);
      IFeatureClass featureClass = dataOperator.CreateShapefile("F:\\ProjectFiles\\GIS\\MapControlApplication111", "ShapefileWorkSpace", "ShapefileSample");
      if (featureClass == null) {
        MessageBox.Show("����Shape�ļ�ʧ��");
        return;
      }
      bool bRes = dataOperator.AddFeatureClassToMap(featureClass, "Observation Stations");
      if (bRes) {
        miCreateShapefile.Enabled = false;
        miAddFeature.Enabled = true;
        return;
      } else {
        MessageBox.Show("���½���Shape�ļ������ͼʧ��");
      }
    }


    private void miAddFeature_Click(object sender, EventArgs e) {
      if (miAddFeature.Checked == false) {
        miAddFeature.Checked = true;
      } else {
        miAddFeature.Checked = false;
      }
    }
    private void miSpaceFilter_Click(object sender, EventArgs e) 
      {
      MapAnalysis mapAnalysis = new MapAnalysis();
      mapAnalysis.QueryInter("cities", "continent", axMapControl1.Map, esriSpatialRelationEnum.esriSpatialRelationIntersection);
      IActiveView activeView = axMapControl1.ActiveView;
      activeView = axMapControl1.ActiveView;
      activeView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, 0, axMapControl1.Extent);
      }
    private void miSearch_Click(object sender, EventArgs e) {
      MapAnalysis1 mapAnalysis1 = new MapAnalysis1();
      mapAnalysis1.Buffer("cities", "NAME='Tangshan'",1, axMapControl1.Map);
      IActiveView activeView = axMapControl1.ActiveView;
      activeView = axMapControl1.ActiveView;
      activeView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, 0, axMapControl1.Extent);
    }

    private void miStat_Click(object sender, EventArgs e) {
      MapAnalysis1 mapAnalysis = new MapAnalysis1();
      string msg = mapAnalysis.Statistic("continent", "SQMI", axMapControl1.Map);
      MessageBox.Show(msg);
    }
  }
}