namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("history", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class HistoryPropertyType {
        
        private AbstractTimeSliceType[] abstractTimeSliceField;
        
        private bool ownsField;
        
        public HistoryPropertyType() {
            this.ownsField = false;
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("AbstractTimeSlice")]
        public AbstractTimeSliceType[] AbstractTimeSlice {
            get {
                return this.abstractTimeSliceField;
            }
            set {
                this.abstractTimeSliceField = value;
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
