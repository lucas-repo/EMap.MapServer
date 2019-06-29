namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ShellType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrientableSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TinType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolygonType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public abstract partial class AbstractSurfaceType : AbstractGeometricPrimitiveType {
    }
}
