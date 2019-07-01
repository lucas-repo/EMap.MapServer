namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TemporalCRS", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TemporalCRSType : AbstractReferenceSystemType {
        
        private TemporalCSRefType usesTemporalCSField;
        
        private TemporalDatumRefType usesTemporalDatumField;
        
        /// <remarks/>
        public TemporalCSRefType usesTemporalCS {
            get {
                return this.usesTemporalCSField;
            }
            set {
                this.usesTemporalCSField = value;
            }
        }
        
        /// <remarks/>
        public TemporalDatumRefType usesTemporalDatum {
            get {
                return this.usesTemporalDatumField;
            }
            set {
                this.usesTemporalDatumField = value;
            }
        }
    }
}
