namespace SharpMapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class PropertyName {
        
        private ResolveValueType resolveField;
        
        private string resolveDepthField;
        
        private string resolveTimeoutField;
        
        private string resolvePathField;
        
        private System.Xml.XmlQualifiedName valueField;
        
        public PropertyName() {
            this.resolveField = ResolveValueType.none;
            this.resolveDepthField = "*";
            this.resolveTimeoutField = "300";
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ResolveValueType.none)]
        public ResolveValueType resolve {
            get {
                return this.resolveField;
            }
            set {
                this.resolveField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("*")]
        public string resolveDepth {
            get {
                return this.resolveDepthField;
            }
            set {
                this.resolveDepthField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("300")]
        public string resolveTimeout {
            get {
                return this.resolveTimeoutField;
            }
            set {
                this.resolveTimeoutField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string resolvePath {
            get {
                return this.resolvePathField;
            }
            set {
                this.resolvePathField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public System.Xml.XmlQualifiedName Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
