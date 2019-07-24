namespace EMap.MapServer.OpenLayers.source
{
    public class TileImage: UrlTile
    {
        /// <summary>
        /// The `crossOrigin` attribute for loaded images.  Note that you must provide a `crossOrigin` value if you want to access pixel data with the Canvas renderer.See https://developer.mozilla.org/en-US/docs/Web/HTML/CORS_enabled_image for more detail.
        /// </summary>
        public string crossOrigin { get; set; }
        /// <summary>
        /// Maximum allowed reprojection error (in pixels).
        /// </summary>
        public double reprojectionErrorThreshold { get; set; } = 0.5;
        /// <summary>
        /// Class used to instantiate image tiles. Default is {@link module:ol/ImageTile~ImageTile}.
        /// </summary>
        public ImageTile tileClass { get; set; }
        public TileImage() : base("ol.source.TileImage")
        { }
        public TileImage(string javaScriptName) : base(javaScriptName)
        { }
    }
}