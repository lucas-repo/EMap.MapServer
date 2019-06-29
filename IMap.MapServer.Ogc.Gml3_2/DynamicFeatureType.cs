namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DynamicFeatureCollectionType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("DynamicFeature", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class DynamicFeatureType : AbstractFeatureType {
        
        private TimePrimitivePropertyType validTimeField;
        
        private HistoryPropertyType historyField;
        
        private StringOrRefType dataSourceField;
        
        private ReferenceType dataSourceReferenceField;
        
        
        public TimePrimitivePropertyType validTime {
            get {
                return this.validTimeField;
            }
            set {
                this.validTimeField = value;
            }
        }
        
        
        public HistoryPropertyType history {
            get {
                return this.historyField;
            }
            set {
                this.historyField = value;
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
        
        
        public ReferenceType dataSourceReference {
            get {
                return this.dataSourceReferenceField;
            }
            set {
                this.dataSourceReferenceField = value;
            }
        }
    }
}
