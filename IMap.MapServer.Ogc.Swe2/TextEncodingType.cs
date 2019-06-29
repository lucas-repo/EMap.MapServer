using System.Xml.Linq;

namespace IMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("TextEncoding", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class TextEncodingType : AbstractEncodingType {
        
        private bool collapseWhiteSpacesField;
        
        private string decimalSeparatorField;
        
        private string tokenSeparatorField;
        
        private string blockSeparatorField;
        
        public TextEncodingType() {
            this.collapseWhiteSpacesField = true;
            this.decimalSeparatorField = ".";
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool collapseWhiteSpaces {
            get {
                return this.collapseWhiteSpacesField;
            }
            set {
                this.collapseWhiteSpacesField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(".")]
        public string decimalSeparator {
            get {
                return this.decimalSeparatorField;
            }
            set {
                this.decimalSeparatorField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tokenSeparator {
            get {
                return this.tokenSeparatorField;
            }
            set {
                this.tokenSeparatorField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string blockSeparator {
            get {
                return this.blockSeparatorField;
            }
            set {
                this.blockSeparatorField = value;
            }
        }
    }
}
