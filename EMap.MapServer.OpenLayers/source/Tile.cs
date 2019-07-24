using EMap.MapServer.OpenLayers.source;

namespace EMap.MapServer.OpenLayers.source
{
    public class TileSource: Source
    {
        /// <summary>
        /// Tile cache size. The default depends on the screen size. Will increase if too small.
        /// </summary>
        public int cacheSize { get; set; }
        /// <summary>
        /// Whether the layer is opaque.
        /// </summary>
        public bool opaque { get; set; } = true;
        /// <summary>
        /// The pixel ratio used by the tile service.  For example, if the tile service advertizes 256px by 256px tiles but actually sends 512px by 512px images(for retina/hidpi devices) then `tilePixelRatio` should be set to `2`.
        /// </summary>
        public int tilePixelRatio { get; set; } = 1;

        /// <summary>
        /// tileGrid
        /// </summary>
        public TileGrid tileGrid { get; set; }
        /// <summary>
        /// Duration of the opacity transition for rendering. To disable the opacity transition, pass `transition: 0`.
        /// </summary>
        public double transition { get; set; }
        /// <summary>
        /// Optional tile key for proper cache fetching
        /// </summary>
        public string key { get; set; }
        public TileSource() : base("ol.source.Tile")
        { }
        public TileSource(string javaScriptName) : base(javaScriptName)
        { }
    }
}