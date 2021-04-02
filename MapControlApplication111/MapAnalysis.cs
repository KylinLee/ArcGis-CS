using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Display;

namespace MapControlApplication111 {
  class MapAnalysis {
    public bool QueryInter(string srcLayerName, string tgtLayerName, IMap iMap, esriSpatialRelationEnum spatialRel) {
      DataOperator dataOperator = new DataOperator(iMap);
      IFeatureLayer iSrcLayer = (IFeatureLayer)dataOperator.GetLayerByName(srcLayerName);
      IFeatureLayer iTgtLayer = (IFeatureLayer)dataOperator.GetLayerByName(tgtLayerName);
      IGeometry geom;
      IFeature feature;
      IFeatureCursor featureCursor;
      IFeatureClass srcFeatClass;
      IQueryFilter queryFilter = new QueryFilter();
      queryFilter.WhereClause = "CONTINENT='Asia'";
      featureCursor = iTgtLayer.FeatureClass.Search(queryFilter, false);
      feature = featureCursor.NextFeature();
      geom = feature.Shape;
      srcFeatClass = iSrcLayer.FeatureClass;
      ISpatialFilter spatialFilter = new SpatialFilter();
      spatialFilter.Geometry = geom;
      spatialFilter.WhereClause = "POPULATION=1060000";
      spatialFilter.SpatialRel = (esriSpatialRelEnum)spatialRel;
      IFeatureSelection featureSelect = (IFeatureSelection)iSrcLayer;
      featureSelect.SelectFeatures(spatialFilter, esriSelectionResultEnum.esriSelectionResultNew, false);
      return true;
    }
  }
}
