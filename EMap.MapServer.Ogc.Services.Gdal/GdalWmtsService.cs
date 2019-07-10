using System;
using System.Collections.Generic;
using System.Text;
using EMap.MapServer.Ogc.Wmts1;
using OSGeo.GDAL;
using OSGeo.OGR;
using EMap.MapServer.Ogc.Ows1_1;
using System.IO;
using System.Linq;

namespace EMap.MapServer.Ogc.Services.Gdals
{
    public class GdalWmtsService : WmtsService, IGdalWmtsService
    {

        public override LayerType AddContent(Capabilities capabilities, string dataPath)
        {
            LayerType layerType = null;
            if (capabilities == null)
            {
                return layerType;
            }
            string name = Path.GetFileNameWithoutExtension(dataPath);
            try
            {
                using (Dataset dataset = Gdal.Open(dataPath, Access.GA_ReadOnly))
                {
                    if (dataset != null)
                    {
                        layerType = dataset.AddToCapabilities(capabilities);
                    }
                }
            }
            catch (Exception e)
            {
                try
                {
                    using (DataSource dataSource = Ogr.Open(dataPath, 0))
                    {
                        if (dataSource != null)
                        {
                            layerType = dataSource.AddToCapabilities(name, capabilities);
                        }
                    }
                }
                catch (Exception exc)
                { }
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
