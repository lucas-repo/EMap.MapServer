namespace EMap.MapServer.OpenLayers
{
    public class BaseObject:Observable
    {
        public BaseObject() : base("ol.Object")
        { }
        protected BaseObject(string javaScriptName) : base(javaScriptName)
        { }
    }
}