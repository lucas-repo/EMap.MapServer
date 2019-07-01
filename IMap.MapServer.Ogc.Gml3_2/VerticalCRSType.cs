namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("VerticalCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class VerticalCRSType : AbstractCRSType {
        
        private VerticalCSPropertyType verticalCSField;
        
        private VerticalDatumPropertyType verticalDatumField;
        
        
        public VerticalCSPropertyType verticalCS {
            get {
                return this.verticalCSField;
            }
            set {
                this.verticalCSField = value;
            }
        }
        
        
        public VerticalDatumPropertyType verticalDatum {
            get {
                return this.verticalDatumField;
            }
            set {
                this.verticalDatumField = value;
            }
        }
    }
}
