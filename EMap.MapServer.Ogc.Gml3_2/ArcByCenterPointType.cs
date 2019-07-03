namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleByCenterPointType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("ArcByCenterPoint", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class ArcByCenterPointType : AbstractCurveSegmentType {
        
        private object itemField;
        
        private ItemChoiceType2 itemElementNameField;
        
        private LengthType radiusField;
        
        private AngleType startAngleField;
        
        private AngleType endAngleField;
        
        private CurveInterpolationType interpolationField;
        
        private bool interpolationFieldSpecified;
        
        private string numArcField;
        
        public ArcByCenterPointType() {
            this.interpolationField = CurveInterpolationType.circularArcCenterPointWithRadius;
            this.numArcField = "1";
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("coordinates", typeof(CoordinatesType))]
        [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pointRep", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pos", typeof(DirectPositionType))]
        [System.Xml.Serialization.XmlElementAttribute("posList", typeof(DirectPositionListType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
        
        
        public LengthType radius {
            get {
                return this.radiusField;
            }
            set {
                this.radiusField = value;
            }
        }
        
        
        public AngleType startAngle {
            get {
                return this.startAngleField;
            }
            set {
                this.startAngleField = value;
            }
        }
        
        
        public AngleType endAngle {
            get {
                return this.endAngleField;
            }
            set {
                this.endAngleField = value;
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
        public string numArc {
            get {
                return this.numArcField;
            }
            set {
                this.numArcField = value;
            }
        }
    }
}
