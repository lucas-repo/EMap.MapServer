using EMap.MapServer.Ogc.Ows1_1;

namespace EMap.MapServer.Ogc.Wmts1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wmts/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wmts/1.0", IsNullable=false)]
    public partial class Dimension : DescriptionType {
        
        private CodeType identifierField;
        
        private DomainMetadataType uOMField;
        
        private string unitSymbolField;
        
        private string defaultField;
        
        private bool currentField;
        
        private bool currentFieldSpecified;
        
        private string[] valueField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/ows/1.1")]
        public CodeType Identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/ows/1.1")]
        public DomainMetadataType UOM {
            get {
                return this.uOMField;
            }
            set {
                this.uOMField = value;
            }
        }
        
        
        public string UnitSymbol {
            get {
                return this.unitSymbolField;
            }
            set {
                this.unitSymbolField = value;
            }
        }
        
        
        public string Default {
            get {
                return this.defaultField;
            }
            set {
                this.defaultField = value;
            }
        }
        
        
        public bool Current {
            get {
                return this.currentField;
            }
            set {
                this.currentField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CurrentSpecified {
            get {
                return this.currentFieldSpecified;
            }
            set {
                this.currentFieldSpecified = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public string[] Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
