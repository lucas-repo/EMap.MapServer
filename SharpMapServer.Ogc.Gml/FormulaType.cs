namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public partial class FormulaType {
        
        private double aField;
        
        private bool aFieldSpecified;
        
        private double bField;
        
        private double cField;
        
        private double dField;
        
        private bool dFieldSpecified;
        
        /// <remarks/>
        public double a {
            get {
                return this.aField;
            }
            set {
                this.aField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool aSpecified {
            get {
                return this.aFieldSpecified;
            }
            set {
                this.aFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public double b {
            get {
                return this.bField;
            }
            set {
                this.bField = value;
            }
        }
        
        /// <remarks/>
        public double c {
            get {
                return this.cField;
            }
            set {
                this.cField = value;
            }
        }
        
        /// <remarks/>
        public double d {
            get {
                return this.dField;
            }
            set {
                this.dField = value;
            }
        }
        
        /// <remarks/>
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
