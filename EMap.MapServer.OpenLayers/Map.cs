using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.MapServer.OpenLayers
{
    public class Map:PluggableMap
    {
        public Map() : base("ol.Map")
        { }
        protected Map(string javaScriptName) : base(javaScriptName)
        { }
    }
}
