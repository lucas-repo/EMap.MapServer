namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("pos", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class DirectPositionType {
        
        private string srsNameField;
        
        private string srsDimensionField;
        
        private double[] textField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string srsName {
            get {
                return this.srsNameField;
            }
            set {
                this.srsNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string srsDimension {
            get {
                return this.srsDimensionField;
            }
            set {
                this.srsDimensionField = value;
            }
        }
        
        /// <remarks/>
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
