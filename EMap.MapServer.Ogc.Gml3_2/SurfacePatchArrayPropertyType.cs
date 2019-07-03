namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("patches", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class SurfacePatchArrayPropertyType {
        
        private AbstractSurfacePatchType[] abstractSurfacePatchField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("AbstractSurfacePatch")]
        public AbstractSurfacePatchType[] AbstractSurfacePatch {
            get {
                return this.abstractSurfacePatchField;
            }
            set {
                this.abstractSurfacePatchField = value;
            }
        }
    }
}
