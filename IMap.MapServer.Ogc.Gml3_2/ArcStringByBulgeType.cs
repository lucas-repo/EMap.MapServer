using System.Xml.Linq;

namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcByBulgeType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("ArcStringByBulge", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class ArcStringByBulgeType : AbstractCurveSegmentType {
        
        private object[] itemsField;
        
        private ItemsChoiceType7[] itemsElementNameField;
        
        private double[] bulgeField;
        
        private VectorType[] normalField;
        
        private CurveInterpolationType interpolationField;
        
        private bool interpolationFieldSpecified;
        
        private string numArcField;
        
        public ArcStringByBulgeType() {
            this.interpolationField = CurveInterpolationType.circularArc2PointWithBulge;
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
        public ItemsChoiceType7[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("bulge")]
        public double[] bulge {
            get {
                return this.bulgeField;
            }
            set {
                this.bulgeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("normal")]
        public VectorType[] normal {
            get {
                return this.normalField;
            }
            set {
                this.normalField = value;
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
