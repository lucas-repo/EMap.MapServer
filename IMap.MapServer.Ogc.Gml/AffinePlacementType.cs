namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("AffinePlacement", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class AffinePlacementType {
        
        private DirectPositionType locationField;
        
        private VectorType[] refDirectionField;
        
        private string inDimensionField;
        
        private string outDimensionField;
        
        /// <remarks/>
        public DirectPositionType location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("refDirection")]
        public VectorType[] refDirection {
            get {
                return this.refDirectionField;
            }
            set {
                this.refDirectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string inDimension {
            get {
                return this.inDimensionField;
            }
            set {
                this.inDimensionField = value;
            }
        }
        
        /// <remarks/>
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
