namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public partial class RelatedTimeType : TimePrimitivePropertyType {
        
        private RelatedTimeTypeRelativePosition relativePositionField;
        
        private bool relativePositionFieldSpecified;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RelatedTimeTypeRelativePosition relativePosition {
            get {
                return this.relativePositionField;
            }
            set {
                this.relativePositionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativePositionSpecified {
            get {
                return this.relativePositionFieldSpecified;
            }
            set {
                this.relativePositionFieldSpecified = value;
            }
        }
    }
}
