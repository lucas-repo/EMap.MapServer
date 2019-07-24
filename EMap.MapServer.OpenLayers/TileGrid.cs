namespace EMap.MapServer.OpenLayers
{
    public class TileGrid:JavaScriptConverter
    {
        /// <summary>
        /// Extent for the tile grid. No tiles outside this extent will be requested by {@link module:ol/source/Tile } sources.When no `origin` or `origins` are configured, the `origin` will be set to the top-left corner of the extent.
        /// </summary>
        public double[] extent { get; set; }
        /// <summary>
        /// Minimum zoom.
        /// </summary>
        public int minZoom { get; set; } = 0;
        /// <summary>
        /// The tile grid origin, i.e. where the `x` and `y` axes meet(`[z, 0, 0]`). Tile coordinates increase left to right and upwards.If not specified, `extent` or `origins` must be provided.
        /// </summary>
        public double[] origin { get; set; }
        /// <summary>
        /// Tile grid origins, i.e.where the `x` and `y` axes meet(`[z, 0, 0]`), for each zoom level.If given, the array length should match the length of the `resolutions` array, i.e. each resolution can have a different origin.Tile coordinates increase left to right and upwards.If not specified, `extent` or `origin` must be provided.
        /// </summary>
        public double[][] origins { get; set; }
        /// <summary>
        /// Resolutions. The array index of each resolution needs to match the zoom level.This means that even if a `minZoom` is configured, the resolutions array will have a length of `maxZoom + 1`
        /// </summary>
        public double[] resolutions { get; set; }
        /// <summary>
        ///  Number of tile rows and columns of the grid for each zoom level.The values here are the `TileMatrixWidth` and `TileMatrixHeight` advertised in the GetCapabilities response of the WMTS, and define the grid's extent together with the `origin`. An `extent` can be configured in addition, and will further limit the extent for which tile requests are made by sources.If the bottom-left corner of the `extent` is used as `origin` or `origins`, then the `y` value must be negative because OpenLayers tile coordinates use the top left as the origin.
        /// </summary>
        public double[][] sizes { get; set; }
        /// <summary>
        /// Tile size.
        /// </summary>
        public double[] tileSize { get; set; }
        /// <summary>
        /// Tile sizes. The length of this array needs to match the length of the `resolutions` array.
        /// </summary>
        public double[][] tileSizes { get; set; }
        public TileGrid() : base("ol.tilegrid.TileGrid")
        { }
        public TileGrid(string javaScriptName) : base(javaScriptName)
        { }
    }
}