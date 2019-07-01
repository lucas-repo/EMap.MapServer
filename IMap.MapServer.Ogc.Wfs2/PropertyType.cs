namespace EMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Property", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class PropertyType {
        
        private PropertyTypeValueReference valueReferenceField;
        
        private object valueField;
        
        
        public PropertyTypeValueReference ValueReference {
            get {
                return this.valueReferenceField;
            }
            set {
                this.valueReferenceField = value;
            }
        }
        
        
        public object Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
