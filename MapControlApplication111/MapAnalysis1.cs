using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.esriSystem;

namespace MapControlApplication111 {
  class MapAnalysis1 {
    public bool Buffer(string layerName, string sWhere, int iSize, IMap iMap) {
      IFeatureClass featClass;
      IFeature feature;
      IGeometry iGeom;
      DataOperator dataOperator = new DataOperator(iMap);
      IFeatureLayer featLayer = (IFeatureLayer)dataOperator.GetLayerByName(layerName);
      IGraphicsContainer graphicsContainer = (IGraphicsContainer)iMap;
      graphicsContainer.DeleteAllElements();
      featClass = featLayer.FeatureClass;
      IQueryFilter queryFilter = new QueryFilter();
      queryFilter.WhereClause = sWhere;
      IFeatureCursor featCursor;
      featCursor = (IFeatureCursor)featClass.Search(queryFilter, false);
      int count = featClass.FeatureCount(queryFilter);
      feature = featCursor.NextFeature();
      iGeom = feature.Shape;
      IElement element = new PolygonElementClass();
      ITopologicalOperator ipTO = (ITopologicalOperator)iGeom;
      element.Geometry = ipTO.Buffer(iSize);
      graphicsContainer.AddElement(element, 0);
      return true;
    }
    public string Statistic(string layerName, string fieldName, IMap iMap) {
      DataOperator dataOperator = new DataOperator(iMap);
      IFeatureLayer featLayer = (IFeatureLayer)dataOperator.GetLayerByName(layerName);
      IFeatureClass featClass = featLayer.FeatureClass;
      IDataStatistics dataStatistics = new DataStatistics();
      IFeatureCursor featCursor;
      featCursor = featClass.Search(null, false);
      ICursor cursor = (ICursor)featCursor;
      dataStatistics.Cursor = cursor;
      dataStatistics.Field = fieldName;
      IStatisticsResults statResult;
      statResult = dataStatistics.Statistics;
      // double dMax;
      // double dMin;
      // double dMean;
      string sResult = "最大面积为：" + statResult.Maximum.ToString()
        + "\n最小面积为：" + statResult.Minimum.ToString()
        + "\n平均面积为：" + statResult.Mean.ToString();
      return sResult;
    }
  }
}
