namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("coord", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class CoordType {
        
        private decimal xField;
        
        private decimal yField;
        
        private bool yFieldSpecified;
        
        private decimal zField;
        
        private bool zFieldSpecified;
        
        /// <remarks/>
        public decimal X {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
            }
        }
        
        /// <remarks/>
        public decimal Y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool YSpecified {
            get {
                return this.yFieldSpecified;
            }
            set {
                this.yFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal Z {
            get {
                return this.zField;
            }
            set {
                this.zField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ZSpecified {
            get {
                return this.zFieldSpecified;
            }
            set {
                this.zFieldSpecified = value;
            }
        }
    }
}
