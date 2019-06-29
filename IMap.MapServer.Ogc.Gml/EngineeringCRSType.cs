namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("EngineeringCRS", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class EngineeringCRSType : AbstractReferenceSystemType {
        
        private CoordinateSystemRefType usesCSField;
        
        private EngineeringDatumRefType usesEngineeringDatumField;
        
        /// <remarks/>
        public CoordinateSystemRefType usesCS {
            get {
                return this.usesCSField;
            }
            set {
                this.usesCSField = value;
            }
        }
        
        /// <remarks/>
        public EngineeringDatumRefType usesEngineeringDatum {
            get {
                return this.usesEngineeringDatumField;
            }
            set {
                this.usesEngineeringDatumField = value;
            }
        }
    }
}
