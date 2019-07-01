namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BezierType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("BSpline", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class BSplineType : AbstractCurveSegmentType {
        
        private object[] itemsField;
        
        private ItemsChoiceType10[] itemsElementNameField;
        
        private string degreeField;
        
        private KnotPropertyType[] knotField;
        
        private CurveInterpolationType interpolationField;
        
        private bool isPolynomialField;
        
        private bool isPolynomialFieldSpecified;
        
        private KnotTypesType knotTypeField;
        
        private bool knotTypeFieldSpecified;
        
        public BSplineType() {
            this.interpolationField = CurveInterpolationType.polynomialSpline;
        }
        
        /// <remarks/>
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType10[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string degree {
            get {
                return this.degreeField;
            }
            set {
                this.degreeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("knot")]
        public KnotPropertyType[] knot {
            get {
                return this.knotField;
            }
            set {
                this.knotField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(CurveInterpolationType.polynomialSpline)]
        public CurveInterpolationType interpolation {
            get {
                return this.interpolationField;
            }
            set {
                this.interpolationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isPolynomial {
            get {
                return this.isPolynomialField;
            }
            set {
                this.isPolynomialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPolynomialSpecified {
            get {
                return this.isPolynomialFieldSpecified;
            }
            set {
                this.isPolynomialFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public KnotTypesType knotType {
            get {
                return this.knotTypeField;
            }
            set {
                this.knotTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool knotTypeSpecified {
            get {
                return this.knotTypeFieldSpecified;
            }
            set {
                this.knotTypeFieldSpecified = value;
            }
        }
    }
}
