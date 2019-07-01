namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("DataBlock", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class DataBlockType {
        
        private AssociationRoleType rangeParametersField;
        
        private object itemField;
        
        
        public AssociationRoleType rangeParameters {
            get {
                return this.rangeParametersField;
            }
            set {
                this.rangeParametersField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("doubleOrNilReasonTupleList", typeof(string))]
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
