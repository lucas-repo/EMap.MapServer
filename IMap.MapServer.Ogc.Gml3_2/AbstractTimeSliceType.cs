namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MovingObjectStatusType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public abstract partial class AbstractTimeSliceType : AbstractGMLType {
        
        private TimePrimitivePropertyType validTimeField;
        
        private StringOrRefType dataSourceField;
        
        
        public TimePrimitivePropertyType validTime {
            get {
                return this.validTimeField;
            }
            set {
                this.validTimeField = value;
            }
        }
        
        
        public StringOrRefType dataSource {
            get {
                return this.dataSourceField;
            }
            set {
                this.dataSourceField = value;
            }
        }
    }
}
