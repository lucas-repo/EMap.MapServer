namespace EMap.MapServer.Ogc.Wcs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wcs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DimensionTrim", Namespace="http://www.opengis.net/wcs/2.0", IsNullable=false)]
    public partial class DimensionTrimType : DimensionSubsetType {
        
        private string trimLowField;
        
        private string trimHighField;
        
        
        public string TrimLow {
            get {
                return this.trimLowField;
            }
            set {
                this.trimLowField = value;
            }
        }
        
        
        public string TrimHigh {
            get {
                return this.trimHighField;
            }
            set {
                this.trimHighField = value;
            }
        }
    }
}
