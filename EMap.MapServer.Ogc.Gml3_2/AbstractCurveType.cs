namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrientableCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractRingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearRingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineStringType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public abstract partial class AbstractCurveType : AbstractGeometricPrimitiveType {
    }
}
