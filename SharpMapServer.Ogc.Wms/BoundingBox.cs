namespace SharpMapServer.Ogc.Wms {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wms", IsNullable=false)]
    public partial class BoundingBox {
        
        private string cRSField;
        
        private double minxField;
        
        private double minyField;
        
        private double maxxField;
        
        private double maxyField;
        
        private double resxField;
        
        private bool resxFieldSpecified;
        
        private double resyField;
        
        private bool resyFieldSpecified;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CRS {
            get {
                return this.cRSField;
            }
            set {
                this.cRSField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double minx {
            get {
                return this.minxField;
            }
            set {
                this.minxField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double miny {
            get {
                return this.minyField;
            }
            set {
                this.minyField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maxx {
            get {
                return this.maxxField;
            }
            set {
                this.maxxField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maxy {
            get {
                return this.maxyField;
            }
            set {
                this.maxyField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double resx {
            get {
                return this.resxField;
            }
            set {
                this.resxField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool resxSpecified {
            get {
                return this.resxFieldSpecified;
            }
            set {
                this.resxFieldSpecified = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double resy {
            get {
                return this.resyField;
            }
            set {
                this.resyField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool resySpecified {
            get {
                return this.resyFieldSpecified;
            }
            set {
                this.resyFieldSpecified = value;
            }
        }
    }
}
