namespace SharpMapServer.Ogc.Wms {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wms", IsNullable=false)]
    public partial class LegendURL {
        
        private string formatField;
        
        private OnlineResource onlineResourceField;
        
        private string widthField;
        
        private string heightField;
        
        
        public string Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        
        public OnlineResource OnlineResource {
            get {
                return this.onlineResourceField;
            }
            set {
                this.onlineResourceField = value;
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
