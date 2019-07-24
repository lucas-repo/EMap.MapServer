using EMap.MapServer.OpenLayers.events;

namespace EMap.MapServer.OpenLayers
{
    public class Observable: EventTarget
    {
        public Observable() : base("ol.Observable")
        { }
        protected Observable(string javaScriptName) : base(javaScriptName)
        { }
    }
}