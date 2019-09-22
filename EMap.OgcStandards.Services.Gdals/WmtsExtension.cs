using EMap.OgcStandards.Wmts1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMap.OgcStandards.Services.Gdals
{
    public static class WmtsExtension
    {
        public static bool GetIsDegreeByLocalDb(this TileMatrixSet tileMatrixSet)
        {
            bool ret = false;
            var SupportedCRS = tileMatrixSet.SupportedCRS;
            if (string.IsNullOrEmpty(SupportedCRS) || !SupportedCRS.Contains(":EPSG:"))
            {
                return ret;
            }
            string[] array = SupportedCRS.Split(':');
            bool convertResult = int.TryParse(array[array.Length - 1], out int epsg);
            String projcs = SpatialReferenceHelper.GetProjcs(epsg);
            String geogcs = SpatialReferenceHelper.GetGeogcs(epsg);
            ret = string.IsNullOrEmpty(projcs) && !string.IsNullOrEmpty(geogcs);
            return ret;
        }
        public static List<double> GetResolutions(this TileMatrixSet tileMatrixSet,IEnumerable<string> tileMatrixIdentifiers)
        {
            List<double> resolutions = new List<double>();
            bool isDegree = tileMatrixSet.GetIsDegreeByLocalDb();
            foreach (var tileMatrixIdentifier in tileMatrixIdentifiers)
            {
                TileMatrix tileMatrix = tileMatrixSet.TileMatrix.FirstOrDefault(x => x.Identifier.Value == tileMatrixIdentifier);
                if (tileMatrix != null)
                {
                    double res = tileMatrix.GetResolution(isDegree);
                    resolutions.Add(res);
                }
            }
            return resolutions;
        }
    }
}
