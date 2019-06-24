namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("validArea", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class ExtentType {
        
        private StringOrRefType descriptionField;
        
        private object[] itemsField;
        
        private EnvelopeType[] verticalExtentField;
        
        private TimePeriodType[] temporalExtentField;
        
        /// <remarks/>
        public StringOrRefType description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("boundingBox", typeof(EnvelopeType))]
        [System.Xml.Serialization.XmlElementAttribute("boundingPolygon", typeof(PolygonType))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("verticalExtent")]
        public EnvelopeType[] verticalExtent {
            get {
                return this.verticalExtentField;
            }
            set {
                this.verticalExtentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("temporalExtent")]
        public TimePeriodType[] temporalExtent {
            get {
                return this.temporalExtentField;
            }
            set {
                this.temporalExtentField = value;
            }
        }
    }
}
