namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractFeatureCollectionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractFeatureType : AbstractGMLType {
        
        private BoundingShapeType boundedByField;
        
        private LocationPropertyType locationField;
        
        /// <remarks/>
        public BoundingShapeType boundedBy {
            get {
                return this.boundedByField;
            }
            set {
                this.boundedByField = value;
            }
        }
        
        /// <remarks/>
        public LocationPropertyType location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
    }
}
