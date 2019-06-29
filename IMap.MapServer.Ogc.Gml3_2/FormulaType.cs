namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public partial class FormulaType {
        
        private double aField;
        
        private bool aFieldSpecified;
        
        private double bField;
        
        private double cField;
        
        private double dField;
        
        private bool dFieldSpecified;
        
        
        public double a {
            get {
                return this.aField;
            }
            set {
                this.aField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool aSpecified {
            get {
                return this.aFieldSpecified;
            }
            set {
                this.aFieldSpecified = value;
            }
        }
        
        
        public double b {
            get {
                return this.bField;
            }
            set {
                this.bField = value;
            }
        }
        
        
        public double c {
            get {
                return this.cField;
            }
            set {
                this.cField = value;
            }
        }
        
        
        public double d {
            get {
                return this.dField;
            }
            set {
                this.dField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dSpecified {
            get {
                return this.dFieldSpecified;
            }
            set {
                this.dFieldSpecified = value;
            }
        }
    }
}
