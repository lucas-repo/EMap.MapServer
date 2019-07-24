using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.MapServer.OpenLayers
{
    public class PluggableMap: BaseObject
    {
        /// <summary>
        /// Maximum number tiles to load simultaneously.
        /// </summary>
        public int maxTilesLoading { get; set; } = 16;
        /// <summary>
        /// The minimum distance in pixels the cursor must move to be detected as a map move event instead of a click. Increasing this value can make it easier to click on the map.
        /// </summary>
        public int moveTolerance { get; set; } = 1;
        public layer.BaseLayer[] layers { get; set; }
        /// <summary>
        /// The map's view.  No layer sources will be fetched unless this is specified at construction time or through {@link module:ol/Map ~Map#setView}.
        /// </summary>
        public View view { get; set; }
        public string target { get; set; }
        public PluggableMap() : base("ol.PluggableMap")
        { }
        protected PluggableMap(string javaScriptName) : base(javaScriptName)
        { }
    }
}
