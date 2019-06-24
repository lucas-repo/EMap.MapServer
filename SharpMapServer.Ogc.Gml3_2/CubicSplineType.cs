namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("CubicSpline", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class CubicSplineType : AbstractCurveSegmentType {
        
        private object[] itemsField;
        
        private ItemsChoiceType8[] itemsElementNameField;
        
        private VectorType vectorAtStartField;
        
        private VectorType vectorAtEndField;
        
        private CurveInterpolationType interpolationField;
        
        private bool interpolationFieldSpecified;
        
        private string degreeField;
        
        public CubicSplineType() {
            this.interpolationField = CurveInterpolationType.cubicSpline;
            this.degreeField = "3";
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("coordinates", typeof(CoordinatesType))]
        [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pointRep", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pos", typeof(DirectPositionType))]
        [System.Xml.Serialization.XmlElementAttribute("posList", typeof(DirectPositionListType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType8[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        
        public VectorType vectorAtStart {
            get {
                return this.vectorAtStartField;
            }
            set {
                this.vectorAtStartField = value;
            }
        }
        
        
        public VectorType vectorAtEnd {
            get {
                return this.vectorAtEndField;
            }
            set {
                this.vectorAtEndField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CurveInterpolationType interpolation {
            get {
                return this.interpolationField;
            }
            set {
                this.interpolationField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool interpolationSpecified {
            get {
                return this.interpolationFieldSpecified;
            }
            set {
                this.interpolationFieldSpecified = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string degree {
            get {
                return this.degreeField;
            }
            set {
                this.degreeField = value;
            }
        }
    }
}
