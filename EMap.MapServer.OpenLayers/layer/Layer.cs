namespace EMap.MapServer.OpenLayers.layer
{
    public class Layer: BaseLayer
    {
        /// <summary>
        /// Source for this layer.
        /// </summary>
        public source.TileSource source { get; set; }
        /// <summary>
        /// Sets the layer as overlay on a map. The map will not manage this layer in its layers collection, and the layer will be rendered on top.This is useful for temporary layers. The standard way to add a layer to a map and have it managed by the map is to use { @link module:ol / Map#addLayer}.
        /// </summary>
        public PluggableMap map { get; set; }
        /// <summary>
        ///  Use interim tiles on error.
        /// </summary>
        public bool useInterimTilesOnError { get; set; } = true;
        public Layer() : base("ol.layer.Layer")
        { }
        public Layer(string javaScriptName) : base(javaScriptName)
        { }
    }
}