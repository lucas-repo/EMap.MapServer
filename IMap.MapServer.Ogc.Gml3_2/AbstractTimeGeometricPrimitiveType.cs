namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimePeriodType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeInstantType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public abstract partial class AbstractTimeGeometricPrimitiveType : AbstractTimePrimitiveType {
        
        private string frameField;
        
        public AbstractTimeGeometricPrimitiveType() {
            this.frameField = "#ISO-8601";
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        [System.ComponentModel.DefaultValueAttribute("#ISO-8601")]
        public string frame {
            get {
                return this.frameField;
            }
            set {
                this.frameField = value;
            }
        }
    }
}
