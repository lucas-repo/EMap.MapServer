using System;
using System.Collections.Generic;
using System.Text;

namespace IMap.MapServer.Ogc.Wmts1
{
    public class OverrideAttribute
    {
        public string BaseElementName { get; set; }
        public Type BaseType { get; set; }
        public Dictionary<string, Type> Inheritors { get; set; } = new Dictionary<string, Type>();
    }
}
