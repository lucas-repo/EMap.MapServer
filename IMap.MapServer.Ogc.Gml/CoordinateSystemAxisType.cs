namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("CoordinateSystemAxis", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class CoordinateSystemAxisType : CoordinateSystemAxisBaseType {
        
        private IdentifierType[] axisIDField;
        
        private StringOrRefType remarksField;
        
        private CodeType1 axisAbbrevField;
        
        private CodeType1 axisDirectionField;
        
        private string uomField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("axisID")]
        public IdentifierType[] axisID {
            get {
                return this.axisIDField;
            }
            set {
                this.axisIDField = value;
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
        public CodeType1 axisAbbrev {
            get {
                return this.axisAbbrevField;
            }
            set {
                this.axisAbbrevField = value;
            }
        }
        
        /// <remarks/>
        public CodeType1 axisDirection {
            get {
                return this.axisDirectionField;
            }
            set {
                this.axisDirectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="anyURI")]
        public string uom {
            get {
                return this.uomField;
            }
            set {
                this.uomField = value;
            }
        }
    }
}
