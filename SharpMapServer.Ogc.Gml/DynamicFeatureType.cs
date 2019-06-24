namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DynamicFeatureCollectionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("DynamicFeature", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class DynamicFeatureType : AbstractFeatureType {
        
        private TimePrimitivePropertyType validTimeField;
        
        private HistoryPropertyType historyField;
        
        private StringOrRefType dataSourceField;
        
        private ReferenceType dataSourceReferenceField;
        
        /// <remarks/>
        public TimePrimitivePropertyType validTime {
            get {
                return this.validTimeField;
            }
            set {
                this.validTimeField = value;
            }
        }
        
        /// <remarks/>
        public HistoryPropertyType history {
            get {
                return this.historyField;
            }
            set {
                this.historyField = value;
            }
        }
        
        /// <remarks/>
        public StringOrRefType dataSource {
            get {
                return this.dataSourceField;
            }
            set {
                this.dataSourceField = value;
            }
        }
        
        /// <remarks/>
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
