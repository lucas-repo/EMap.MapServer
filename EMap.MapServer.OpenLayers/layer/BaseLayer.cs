namespace EMap.MapServer.OpenLayers.layer
{
    public class BaseLayer: BaseObject
    {
        /// <summary>
        /// A CSS class name to set to the layer element.
        /// </summary>
        public string className { get; set; } = "ol-layer";

        /// <summary>
        /// Opacity (0, 1).
        /// </summary>
        public double opacity { get; set; } = 1;
        /// <summary>
        ///  Visibility.
        /// </summary>
        public bool visible { get; set; } = true;
        /// <summary>
        /// The bounding extent for layer rendering.  The layer will not be rendered outside of this extent.
        /// </summary>
        public double[] extent { get; set; }
        /// <summary>
        /// The z-index for layer rendering.  At rendering time, the layers will be ordered, first by Z-index and then by position.When `undefined`, a `zIndex` of 0 is assumed for layers that are added to the map's `layers` collection, or `Infinity` when the layer's `setMap()` method was used.
        /// </summary>
        public int? zIndex { get; set; }
        /// <summary>
        /// The minimum resolution (inclusive) at which this layer will be visible.
        /// </summary>
        public double? maxResolution { get; set; }
        /// <summary>
        /// The maximum resolution (exclusive) below which this layer will be visible.
        /// </summary>
        public double? minResolution { get; set; }
        public BaseLayer() : base("ol.layer.Base")
        { }
        public BaseLayer(string javaScriptName) : base(javaScriptName)
        { }
    }
}