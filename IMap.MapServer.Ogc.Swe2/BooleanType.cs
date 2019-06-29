namespace IMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Boolean", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class BooleanType : AbstractSimpleComponentType {
        
        private bool valueField;
        
        private bool valueFieldSpecified;
        
        
        public bool value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valueSpecified {
            get {
                return this.valueFieldSpecified;
            }
            set {
                this.valueFieldSpecified = value;
            }
        }
    }
}
