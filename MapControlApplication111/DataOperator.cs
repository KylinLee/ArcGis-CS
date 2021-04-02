using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;

using System.IO;

namespace MapControlApplication111 {
  class DataOperator {
    public IMap m_map;
    public DataOperator(IMap map) {
      m_map = map;
    }
    public ILayer GetLayerByName(String sLayerName) {
      if (sLayerName == "" || m_map == null) {
        return null;
      }
      for (int i = 0; i < m_map.LayerCount; i++) {
        if (m_map.get_Layer(i).Name == sLayerName) {
          return m_map.get_Layer(i);

        }
      }
      return null;
    }
    public DataTable GetContinentsNames() {
      ILayer layer = GetLayerByName("continent");
      IFeatureLayer featureLayer = layer as IFeatureLayer;
      if (featureLayer == null) {
        return null;
      }
      IFeature feature;
      IFeatureCursor featureCursor = featureLayer.Search(null, false);
      feature = featureCursor.NextFeature();
      if (feature == null) {
        return null;
      }
      DataTable dataTable = new DataTable();
      DataColumn dataColumn = new DataColumn();
      dataColumn.ColumnName = "序号";
      dataColumn.DataType = System.Type.GetType("System.Int32");
      dataTable.Columns.Add(dataColumn);

      dataColumn = new DataColumn();
      dataColumn.ColumnName = "名称";
      dataColumn.DataType = System.Type.GetType("System.String");
      dataTable.Columns.Add(dataColumn);

      DataRow dataRow;
      while (feature != null) {
        dataRow = dataTable.NewRow();
        dataRow[0] = feature.get_Value(0);
        dataRow[1] = feature.get_Value(2);
        dataTable.Rows.Add(dataRow);

        feature = featureCursor.NextFeature();
      }

      return dataTable;
    }
    // 清空指定的文件夹，但不删除文件夹
    /// </summary>
    /// <param name="dir"></param>
    public static void DeleteFolder(string dir) {
      foreach (string d in Directory.GetFileSystemEntries(dir)) {
        if (File.Exists(d)) {
          FileInfo fi = new FileInfo(d);
          if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
            fi.Attributes = FileAttributes.Normal;
          File.Delete(d);//直接删除其中的文件   
        } else {
          DirectoryInfo d1 = new DirectoryInfo(d);
          if (d1.GetFiles().Length != 0) {
            DeleteFolder(d1.FullName);
          }
          Directory.Delete(d);
        }
      }
    }
    public IFeatureClass CreateShapefile(string sParentDirectory, string sWorkspaceName, string sFileName) {
      DeleteFolder(sParentDirectory +"\\"+ sWorkspaceName);
      IWorkspaceFactory workspaceFactory = new ShapefileWorkspaceFactoryClass();
      IWorkspaceName workspaceName = workspaceFactory.Create(sParentDirectory, sWorkspaceName, null, 0);
      ESRI.ArcGIS.esriSystem.IName name = workspaceName as ESRI.ArcGIS.esriSystem.IName;
      IWorkspace workspace = (IWorkspace)name.Open();
      IFeatureWorkspace featureWorkspace = workspace as IFeatureWorkspace;
      IFields fields = new FieldsClass();
      IFieldsEdit fieldsEdit = fields as IFieldsEdit;
      IFieldEdit fieldEdit = new FieldClass();
      fieldEdit.Name_2 = "OID";
      fieldEdit.AliasName_2 = "序号";
      fieldEdit.Type_2 = esriFieldType.esriFieldTypeString;
      fieldsEdit.AddField((IField)fieldEdit);
      fieldEdit = new FieldClass();
      fieldEdit.Name_2 = "Name";
      fieldEdit.AliasName_2 = "名称";
      fieldEdit.Type_2 = esriFieldType.esriFieldTypeString;
      fieldsEdit.AddField((IField)fieldEdit);
      IGeometryDefEdit geoDefEdit = new GeometryDefClass();
      ISpatialReference spatialReference = m_map.SpatialReference;
      geoDefEdit.SpatialReference_2 = spatialReference;
      geoDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPoint;
      fieldEdit = new FieldClass();
      String sShapeFieldName = "Shape";
      fieldEdit.Name_2 = sShapeFieldName;
      fieldEdit.AliasName_2 = "形状";
      fieldEdit.Type_2 = esriFieldType.esriFieldTypeGeometry;
      fieldEdit.GeometryDef_2 = geoDefEdit;
      fieldsEdit.AddField((IField)fieldEdit);
      IFeatureClass featureClass = featureWorkspace.CreateFeatureClass(sFileName, fields, null, null, esriFeatureType.esriFTSimple, "Shape", "");
      if (featureClass == null) {
        return null;
      }
      return featureClass;
    }
    public bool AddFeatureClassToMap(IFeatureClass featureClass, String sLayerName) {
      if (featureClass == null) {
        return false;
      }
      IFeatureLayer featureLayer = new FeatureLayerClass();
      featureLayer.FeatureClass = featureClass;
      featureLayer.Name = sLayerName;
      ILayer layer = featureLayer as ILayer;
      if (layer == null) {
        return false;
      }
      m_map.AddLayer(layer);
      IActiveView activeView = m_map as IActiveView;
      if (activeView == null) {
        return false;
      }
      activeView.Refresh();
      return true;
    }
    public bool AddFeatureToLayer(string sLayerName, string sFeatureName, IPoint point) {
      if (sLayerName == "" || sFeatureName == "" || point == null || m_map == null) {
        return false;
      }
      ILayer layer = null;
      for (int i = 0; i < m_map.LayerCount; i++) {
        layer = m_map.get_Layer(i);
        if (layer.Name == sLayerName) {
          break;
        }
        layer = null;
      }
      if (layer == null) {
        return false;
      }
      IFeatureLayer featureLayer = layer as IFeatureLayer;
      IFeatureClass featureClass = featureLayer.FeatureClass;
      IFeature feature = featureClass.CreateFeature();
      if (feature == null) {
        return false;
      }
      feature.Shape = point;
      int index = feature.Fields.FindField("Name");
      feature.set_Value(index, sFeatureName);
      feature.Store();
      if (feature == null) {
        return false;
      }
      IActiveView activeView = m_map as IActiveView;
      if (activeView == null) {
        return false;
      }
      activeView.Refresh();
      return true;
    }

  }
}
