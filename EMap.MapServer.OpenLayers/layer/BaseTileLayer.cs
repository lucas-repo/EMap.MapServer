namespace EMap.MapServer.OpenLayers.layer
{
    public class BaseTileLayer: Layer
    {
        /// <summary>
        ///  Preload. Load low-resolution tiles up to `preload` levels. `0` means no preloading.
        /// </summary>
        public int preload { get; set; }
        public bool useInterimTilesOnError { get; set; } = true;
        public BaseTileLayer() : base("ol.layer.BaseTile")
        { }
        public BaseTileLayer(string javaScriptName) : base(javaScriptName)
        { }
    }
}