using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;

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
  }
}
