namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("PrimeMeridian", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class PrimeMeridianType : PrimeMeridianBaseType {
        
        private IdentifierType[] meridianIDField;
        
        private StringOrRefType remarksField;
        
        private AngleChoiceType greenwichLongitudeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("meridianID")]
        public IdentifierType[] meridianID {
            get {
                return this.meridianIDField;
            }
            set {
                this.meridianIDField = value;
            }
        }
        
        /// <remarks/>
        public StringOrRefType remarks {
            get {
                return this.remarksField;
            }
            set {
                this.remarksField = value;
            }
        }
        
        /// <remarks/>
        public AngleChoiceType greenwichLongitude {
            get {
                return this.greenwichLongitudeField;
            }
            set {
                this.greenwichLongitudeField = value;
            }
        }
    }
}
