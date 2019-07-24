using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.MapServer.OpenLayers.layer
{
    public class TileLayer: BaseTileLayer
    {
        public TileLayer() : base("ol.layer.Tile")
        { }
        public TileLayer(string javaScriptName) : base(javaScriptName)
        { }
    }
}
