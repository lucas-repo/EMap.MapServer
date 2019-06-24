namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MovingObjectStatusType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractTimeSliceType : AbstractGMLType {
        
        private TimePrimitivePropertyType validTimeField;
        
        private StringOrRefType dataSourceField;
        
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
