namespace EMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AllowedTimes", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class AllowedTimesType : AbstractSWEType {
        
        private string[] valueField;
        
        private string[] intervalField;
        
        private string significantFiguresField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public string[] value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("interval")]
        public string[] interval {
            get {
                return this.intervalField;
            }
            set {
                this.intervalField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string significantFigures {
            get {
                return this.significantFiguresField;
            }
            set {
                this.significantFiguresField = value;
            }
        }
    }
}
