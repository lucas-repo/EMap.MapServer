namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("VerticalCRS", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class VerticalCRSType : AbstractReferenceSystemType {
        
        private VerticalCSRefType usesVerticalCSField;
        
        private VerticalDatumRefType usesVerticalDatumField;
        
        /// <remarks/>
        public VerticalCSRefType usesVerticalCS {
            get {
                return this.usesVerticalCSField;
            }
            set {
                this.usesVerticalCSField = value;
            }
        }
        
        /// <remarks/>
        public VerticalDatumRefType usesVerticalDatum {
            get {
                return this.usesVerticalDatumField;
            }
            set {
                this.usesVerticalDatumField = value;
            }
        }
    }
}
