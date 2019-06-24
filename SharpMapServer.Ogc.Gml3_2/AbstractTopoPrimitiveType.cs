namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoSolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NodeType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public abstract partial class AbstractTopoPrimitiveType : AbstractTopologyType {
    }
}
