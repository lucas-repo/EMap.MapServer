namespace EMap.MapServer.Ogc.Wms {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wms", IsNullable=false)]
    public partial class Dimension {
        
        private string nameField;
        
        private string unitsField;
        
        private string unitSymbolField;
        
        private string defaultField;
        
        private bool multipleValuesField;
        
        private bool multipleValuesFieldSpecified;
        
        private bool nearestValueField;
        
        private bool nearestValueFieldSpecified;
        
        private bool currentField;
        
        private bool currentFieldSpecified;
        
        private string valueField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unitSymbol {
            get {
                return this.unitSymbolField;
            }
            set {
                this.unitSymbolField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @default {
            get {
                return this.defaultField;
            }
            set {
                this.defaultField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool multipleValues {
            get {
                return this.multipleValuesField;
            }
            set {
                this.multipleValuesField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool multipleValuesSpecified {
            get {
                return this.multipleValuesFieldSpecified;
            }
            set {
                this.multipleValuesFieldSpecified = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool nearestValue {
            get {
                return this.nearestValueField;
            }
            set {
                this.nearestValueField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nearestValueSpecified {
            get {
                return this.nearestValueFieldSpecified;
            }
            set {
                this.nearestValueFieldSpecified = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool current {
            get {
                return this.currentField;
            }
            set {
                this.currentField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool currentSpecified {
            get {
                return this.currentFieldSpecified;
            }
            set {
                this.currentFieldSpecified = value;
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
