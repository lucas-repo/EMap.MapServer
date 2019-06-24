namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("tupleList", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class CoordinatesType {
        
        private string decimalField;
        
        private string csField;
        
        private string tsField;
        
        private string valueField;
        
        public CoordinatesType() {
            this.decimalField = ".";
            this.csField = ",";
            this.tsField = " ";
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(".")]
        public string @decimal {
            get {
                return this.decimalField;
            }
            set {
                this.decimalField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(",")]
        public string cs {
            get {
                return this.csField;
            }
            set {
                this.csField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(" ")]
        public string ts {
            get {
                return this.tsField;
            }
            set {
                this.tsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
