namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("pos", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class DirectPositionType {
        
        private string srsNameField;
        
        private string srsDimensionField;
        
        private double[] textField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string srsName {
            get {
                return this.srsNameField;
            }
            set {
                this.srsNameField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string srsDimension {
            get {
                return this.srsDimensionField;
            }
            set {
                this.srsDimensionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public double[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
}
