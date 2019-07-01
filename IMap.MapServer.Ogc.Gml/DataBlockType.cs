namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("DataBlock", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class DataBlockType {
        
        private RangeParametersType rangeParametersField;
        
        private object itemField;
        
        /// <remarks/>
        public RangeParametersType rangeParameters {
            get {
                return this.rangeParametersField;
            }
            set {
                this.rangeParametersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("doubleOrNullTupleList", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("tupleList", typeof(CoordinatesType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}
