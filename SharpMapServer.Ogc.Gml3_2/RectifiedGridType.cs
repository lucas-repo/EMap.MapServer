namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("RectifiedGrid", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class RectifiedGridType : GridType {
        
        private PointPropertyType originField;
        
        private VectorType[] offsetVectorField;
        
        
        public PointPropertyType origin {
            get {
                return this.originField;
            }
            set {
                this.originField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("offsetVector")]
        public VectorType[] offsetVector {
            get {
                return this.offsetVectorField;
            }
            set {
                this.offsetVectorField = value;
            }
        }
    }
}
