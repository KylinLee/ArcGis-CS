using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Display;

namespace MapControlApplication111 {
  public class MapComposer {
    public static String GetRendererTypeByLayer(ILayer layer) {
      if (layer == null) {
        return "图层获取失败!";
      }
      IFeatureLayer featureLayer = layer as IFeatureLayer;
      IGeoFeatureLayer geoFeatureLayer = layer as IGeoFeatureLayer;
      IFeatureRenderer featureRender = geoFeatureLayer.Renderer;

      if (featureRender is ISimpleRenderer) {
        return "SimpleRenderer";
      } else if (featureRender is IUniqueValueRenderer) {
        return "UniqueValueRenderer";
      }
      return "未知或获取渲染器失败!";
    }

    public static ISymbol GetSymbolFromLayer(ILayer layer) {
      if (layer == null) {
        return null;
      }
      IFeatureLayer featureLayer = layer as IFeatureLayer;
      IFeatureCursor featureCursor = featureLayer.Search(null, false);
      IFeature feature = featureCursor.NextFeature();
      if (feature == null) {
        return null;
      }
      IGeoFeatureLayer geoFeatureLayer = featureLayer as IGeoFeatureLayer;
      IFeatureRenderer featureRenderer = geoFeatureLayer.Renderer;
      if (featureRenderer == null) {
        return null;
      }
      ISymbol symbol = featureRenderer.get_SymbolByFeature(feature);
      return symbol;
    }
    public static bool RenderSimply(ILayer layer, IColor color) {
      IFeatureLayer featureLayer = (IFeatureLayer)layer;
      esriGeometryType geotype = featureLayer.FeatureClass.ShapeType;
      ISymbol symbol = GetSymbolFromLayer(layer);

      switch (geotype) {
        case esriGeometryType.esriGeometryPoint: {
            IMarkerSymbol markerSymbol = symbol as IMarkerSymbol;
            markerSymbol.Color = color;
            break;
          }
        case esriGeometryType.esriGeometryMultipoint: {
            IMarkerSymbol markerSymbol = symbol as IMarkerSymbol;
            markerSymbol.Color = color;
            break;
          }
        case esriGeometryType.esriGeometryPolyline: {
            ISimpleLineSymbol simpleLineSymbol = symbol as ISimpleLineSymbol;
            simpleLineSymbol.Color = color;
            break;
          }
        case esriGeometryType.esriGeometryPolygon: {
            IFillSymbol fillSymbol = symbol as IFillSymbol;
            fillSymbol.Color = color;
            break;
          }
        default:
          return false;
      }

      ISimpleRenderer simpleRenderer = new SimpleRendererClass();
      simpleRenderer.Symbol = symbol;
      IFeatureRenderer featureRender = simpleRenderer as IFeatureRenderer;
      if (featureRender == null) {
        return false;
      }
      IGeoFeatureLayer geoFeatureLayer = featureLayer as IGeoFeatureLayer;
      geoFeatureLayer.Renderer = featureRender;
      return true;
    }
  }
}

