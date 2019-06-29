namespace IMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wfs/2.0")]
    public partial class PropertyTypeValueReference {
        
        private UpdateActionType actionField;
        
        private string valueField;
        
        public PropertyTypeValueReference() {
            this.actionField = UpdateActionType.replace;
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(UpdateActionType.replace)]
        public UpdateActionType action {
            get {
                return this.actionField;
            }
            set {
                this.actionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
