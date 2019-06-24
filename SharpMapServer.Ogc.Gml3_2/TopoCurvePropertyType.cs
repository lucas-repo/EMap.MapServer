namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("topoCurveProperty", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TopoCurvePropertyType {
        
        private TopoCurveType topoCurveField;
        
        private bool ownsField;
        
        public TopoCurvePropertyType() {
            this.ownsField = false;
        }
        
        
        public TopoCurveType TopoCurve {
            get {
                return this.topoCurveField;
            }
            set {
                this.topoCurveField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool owns {
            get {
                return this.ownsField;
            }
            set {
                this.ownsField = value;
            }
        }
    }
}
