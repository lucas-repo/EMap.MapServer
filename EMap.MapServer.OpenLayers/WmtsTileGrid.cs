using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.MapServer.OpenLayers
{
    public class WmtsTileGrid : TileGrid
    {
        /// <summary>
        /// matrix IDs. The length of this array needs to match the length of the `resolutions` array.
        /// </summary>
        public string[] matrixIds { get; set; }
        /// <summary>
        ///  Number of tile columns that cover the grid's extent for each zoom level.Only required when used with a source that has `wrapX` set to `true`, and only when the grid's origin differs from the one of the projection's extent. The array length has to match the length of the `resolutions` array, i.e.each resolution will have a matching entry here.
        /// </summary>
        public double[] widths { get; set; }
        public WmtsTileGrid() : base("ol.tilegrid.WMTS")
        {
        }
    }
}
