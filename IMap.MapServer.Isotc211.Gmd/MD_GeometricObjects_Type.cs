using IMap.MapServer.Isotc211.Gco;

namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_GeometricObjects", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_GeometricObjects_Type : AbstractObject_Type {
        
        private MD_GeometricObjectTypeCode_PropertyType geometricObjectTypeField;
        
        private Integer_PropertyType geometricObjectCountField;
        
        
        public MD_GeometricObjectTypeCode_PropertyType geometricObjectType {
            get {
                return this.geometricObjectTypeField;
            }
            set {
                this.geometricObjectTypeField = value;
            }
        }
        
        
        public Integer_PropertyType geometricObjectCount {
            get {
                return this.geometricObjectCountField;
            }
            set {
                this.geometricObjectCountField = value;
            }
        }
    }
}
