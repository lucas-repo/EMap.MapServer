namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("valueComponents", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class ValueArrayPropertyType {
        
        private object[] abstractValueField;
        
        private AbstractGeometryType[] abstractGeometryField;
        
        private AbstractTimeObjectType[] abstractTimeObjectField;
        
        private string[] nullField;
        
        private bool ownsField;
        
        public ValueArrayPropertyType() {
            this.ownsField = false;
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("AbstractValue")]
        public object[] AbstractValue {
            get {
                return this.abstractValueField;
            }
            set {
                this.abstractValueField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("AbstractGeometry")]
        public AbstractGeometryType[] AbstractGeometry {
            get {
                return this.abstractGeometryField;
            }
            set {
                this.abstractGeometryField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("AbstractTimeObject")]
        public AbstractTimeObjectType[] AbstractTimeObject {
            get {
                return this.abstractTimeObjectField;
            }
            set {
                this.abstractTimeObjectField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Null")]
        public string[] Null {
            get {
                return this.nullField;
            }
            set {
                this.nullField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool owns {
            get {
                return this.ownsField;
            }
            set {
                this.ownsField = value;
            }
        }
    }
}
