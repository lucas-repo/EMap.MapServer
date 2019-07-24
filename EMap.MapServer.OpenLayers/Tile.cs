using EMap.MapServer.OpenLayers.events;

namespace EMap.MapServer.OpenLayers
{
    public class Tile:EventTarget 
    {
        public Tile() : base("ol.Tile")
        { }
        public Tile(string javaScriptName) : base(javaScriptName)
        { }
    }
}