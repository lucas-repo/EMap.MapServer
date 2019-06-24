using SharpMapServer.Ogc.Ows1_1;

namespace SharpMapServer.Ogc.Wmts1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wmts/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wmts/1.0", IsNullable=false)]
    public partial class LegendURL : OnlineResourceType {
        
        private string formatField;
        
        private double minScaleDenominatorField;
        
        private bool minScaleDenominatorFieldSpecified;
        
        private double maxScaleDenominatorField;
        
        private bool maxScaleDenominatorFieldSpecified;
        
        private string widthField;
        
        private string heightField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double minScaleDenominator {
            get {
                return this.minScaleDenominatorField;
            }
            set {
                this.minScaleDenominatorField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minScaleDenominatorSpecified {
            get {
                return this.minScaleDenominatorFieldSpecified;
            }
            set {
                this.minScaleDenominatorFieldSpecified = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maxScaleDenominator {
            get {
                return this.maxScaleDenominatorField;
            }
            set {
                this.maxScaleDenominatorField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxScaleDenominatorSpecified {
            get {
                return this.maxScaleDenominatorFieldSpecified;
            }
            set {
                this.maxScaleDenominatorFieldSpecified = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string width {
            get {
                return this.widthField;
            }
            set {
                this.widthField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string height {
            get {
                return this.heightField;
            }
            set {
                this.heightField = value;
            }
        }
    }
}
