using IMap.MapServer.Isotc211.Gco;

namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_OnlineResource", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class CI_OnlineResource_Type : AbstractObject_Type {
        
        private URL_PropertyType linkageField;
        
        private CharacterString_PropertyType protocolField;
        
        private CharacterString_PropertyType applicationProfileField;
        
        private CharacterString_PropertyType nameField;
        
        private CharacterString_PropertyType descriptionField;
        
        private CI_OnLineFunctionCode_PropertyType functionField;
        
        
        public URL_PropertyType linkage {
            get {
                return this.linkageField;
            }
            set {
                this.linkageField = value;
            }
        }
        
        
        public CharacterString_PropertyType protocol {
            get {
                return this.protocolField;
            }
            set {
                this.protocolField = value;
            }
        }
        
        
        public CharacterString_PropertyType applicationProfile {
            get {
                return this.applicationProfileField;
            }
            set {
                this.applicationProfileField = value;
            }
        }
        
        
        public CharacterString_PropertyType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        
        public CharacterString_PropertyType description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        
        public CI_OnLineFunctionCode_PropertyType function {
            get {
                return this.functionField;
            }
            set {
                this.functionField = value;
            }
        }
    }
}
