using System;
using System.Collections.Generic;
using System.Text;
using IMap.MapServer.Ogc.Wmts1;
using OSGeo.GDAL;
using OSGeo.OGR;
using IMap.MapServer.Ogc.Ows1_1;
using System.IO;
using System.Linq;

namespace IMap.MapServer.Ogc.Services.Gdals
{
    public class GdalWmtsService : WmtsService, IGdalWmtsService
    {
        static GdalWmtsService()
        {
            Gdal.AllRegister();
            // 为了支持中文路径，请添加下面这句代码  
            Gdal.SetConfigOption("GDAL_FILENAME_IS_UTF8", "NO");
            // 为了使属性表字段支持中文，请添加下面这句  
            Gdal.SetConfigOption("SHAPE_ENCODING", "");
            Ogr.RegisterAll();
        }

        public override LayerType AddContent(Capabilities capabilities, string dataPath)
        {
            LayerType layerType = null;
            if (capabilities == null)
            {
                return layerType;
            }
            Dataset dataset = Gdal.Open(dataPath, Access.GA_ReadOnly);
            if (dataset != null)
            {
                layerType = dataset.AddToCapabilities(capabilities);
                dataset.Dispose();
            }
            else
            {
                DataSource dataSource = Ogr.Open(dataPath, 0);
                layerType = dataSource.AddToCapabilities(capabilities);
                dataSource.Dispose();
            }
            return layerType;
        }


        public override FeatureInfoResponse GetFeatureInfo(string path, GetFeatureInfo getFeatureInfo)
        {
            throw new NotImplementedException();
        }

        public override byte[] GetTile(Capabilities capabilities, string path, GetTile getTile)
        {
            throw new NotImplementedException();
        }
    }
}
