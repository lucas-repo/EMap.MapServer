namespace EMap.MapServer.OpenLayers.events
{
    public class EventTarget:JavaScriptConverter
    {
        public EventTarget() : base("ol.events.Target")
        { }
        protected EventTarget(string javaScriptName) : base(javaScriptName)
        { }
    }
}