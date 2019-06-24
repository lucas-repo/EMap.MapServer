namespace SharpMapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swe/2.0")]
    public partial class BinaryEncodingTypeMember {
        
        private ComponentType componentField;
        
        private BlockType blockField;
        
        
        public ComponentType Component {
            get {
                return this.componentField;
            }
            set {
                this.componentField = value;
            }
        }
        
        
        public BlockType Block {
            get {
                return this.blockField;
            }
            set {
                this.blockField = value;
            }
        }
    }
}
