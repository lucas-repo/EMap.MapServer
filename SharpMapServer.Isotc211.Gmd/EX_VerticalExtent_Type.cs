using SharpMapServer.Isotc211.Gco;
using SharpMapServer.Isotc211.Gsr;

namespace SharpMapServer.Isotc211.Gmd
{


    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("EX_VerticalExtent", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class EX_VerticalExtent_Type : AbstractObject_Type {
        
        private Real_PropertyType minimumValueField;
        
        private Real_PropertyType maximumValueField;
        
        private SC_CRS_PropertyType verticalCRSField;
        
        
        public Real_PropertyType minimumValue {
            get {
                return this.minimumValueField;
            }
            set {
                this.minimumValueField = value;
            }
        }
        
        
        public Real_PropertyType maximumValue {
            get {
                return this.maximumValueField;
            }
            set {
                this.maximumValueField = value;
            }
        }
        
        
        public SC_CRS_PropertyType verticalCRS {
            get {
                return this.verticalCRSField;
            }
            set {
                this.verticalCRSField = value;
            }
        }
    }
}
