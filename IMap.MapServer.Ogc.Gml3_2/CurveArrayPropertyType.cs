namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("curveMembers", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class CurveArrayPropertyType {
        
        private AbstractCurveType[] abstractCurveField;
        
        private bool ownsField;
        
        public CurveArrayPropertyType() {
            this.ownsField = false;
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("AbstractCurve")]
        public AbstractCurveType[] AbstractCurve {
            get {
                return this.abstractCurveField;
            }
            set {
                this.abstractCurveField = value;
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
