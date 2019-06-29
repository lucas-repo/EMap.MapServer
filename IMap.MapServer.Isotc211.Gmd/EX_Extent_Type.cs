using IMap.MapServer.Isotc211.Gco;

namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("EX_Extent", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class EX_Extent_Type : AbstractObject_Type {
        
        private CharacterString_PropertyType descriptionField;
        
        private EX_GeographicExtent_PropertyType[] geographicElementField;
        
        private EX_TemporalExtent_PropertyType[] temporalElementField;
        
        private EX_VerticalExtent_PropertyType[] verticalElementField;
        
        
        public CharacterString_PropertyType description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("geographicElement")]
        public EX_GeographicExtent_PropertyType[] geographicElement {
            get {
                return this.geographicElementField;
            }
            set {
                this.geographicElementField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("temporalElement")]
        public EX_TemporalExtent_PropertyType[] temporalElement {
            get {
                return this.temporalElementField;
            }
            set {
                this.temporalElementField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("verticalElement")]
        public EX_VerticalExtent_PropertyType[] verticalElement {
            get {
                return this.verticalElementField;
            }
            set {
                this.verticalElementField = value;
            }
        }
    }
}
