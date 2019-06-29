namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("solidMembers", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class SolidArrayPropertyType {
        
        private AbstractSolidType[] abstractSolidField;
        
        private bool ownsField;
        
        public SolidArrayPropertyType() {
            this.ownsField = false;
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("AbstractSolid")]
        public AbstractSolidType[] AbstractSolid {
            get {
                return this.abstractSolidField;
            }
            set {
                this.abstractSolidField = value;
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
