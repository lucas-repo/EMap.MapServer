namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AffinePlacement", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class AffinePlacementType {
        
        private DirectPositionType locationField;
        
        private VectorType[] refDirectionField;
        
        private string inDimensionField;
        
        private string outDimensionField;
        
        
        public DirectPositionType location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("refDirection")]
        public VectorType[] refDirection {
            get {
                return this.refDirectionField;
            }
            set {
                this.refDirectionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string inDimension {
            get {
                return this.inDimensionField;
            }
            set {
                this.inDimensionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string outDimension {
            get {
                return this.outDimensionField;
            }
            set {
                this.outDimensionField = value;
            }
        }
    }
}
