using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("DS_DataSet", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class DS_DataSet_Type : AbstractObject_Type {
        
        private MD_Metadata_PropertyType[] hasField;
        
        private DS_Aggregate_PropertyType[] partOfField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("has")]
        public MD_Metadata_PropertyType[] has {
            get {
                return this.hasField;
            }
            set {
                this.hasField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("partOf")]
        public DS_Aggregate_PropertyType[] partOf {
            get {
                return this.partOfField;
            }
            set {
                this.partOfField = value;
            }
        }
    }
}
