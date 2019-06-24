namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public abstract partial class AbstractTimePrimitiveType : AbstractTimeObjectType {
        
        private RelatedTimeType[] relatedTimeField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("relatedTime")]
        public RelatedTimeType[] relatedTime {
            get {
                return this.relatedTimeField;
            }
            set {
                this.relatedTimeField = value;
            }
        }
    }
}
