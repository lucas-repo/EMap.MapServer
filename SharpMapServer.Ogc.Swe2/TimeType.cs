namespace SharpMapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Time", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class TimeType : AbstractSimpleComponentType {
        
        private UnitReference uomField;
        
        private AllowedTimesPropertyType constraintField;
        
        private string valueField;
        
        private System.DateTime referenceTimeField;
        
        private bool referenceTimeFieldSpecified;
        
        private string localFrameField;
        
        
        public UnitReference uom {
            get {
                return this.uomField;
            }
            set {
                this.uomField = value;
            }
        }
        
        
        public AllowedTimesPropertyType constraint {
            get {
                return this.constraintField;
            }
            set {
                this.constraintField = value;
            }
        }
        
        
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime referenceTime {
            get {
                return this.referenceTimeField;
            }
            set {
                this.referenceTimeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool referenceTimeSpecified {
            get {
                return this.referenceTimeFieldSpecified;
            }
            set {
                this.referenceTimeFieldSpecified = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string localFrame {
            get {
                return this.localFrameField;
            }
            set {
                this.localFrameField = value;
            }
        }
    }
}
