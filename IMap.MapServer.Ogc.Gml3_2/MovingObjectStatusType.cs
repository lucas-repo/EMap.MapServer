namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("MovingObjectStatus", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class MovingObjectStatusType : AbstractTimeSliceType {
        
        private object itemField;
        
        private MeasureType speedField;
        
        private DirectionPropertyType bearingField;
        
        private MeasureType accelerationField;
        
        private MeasureType elevationField;
        
        private StringOrRefType statusField;
        
        private ReferenceType statusReferenceField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("location", typeof(LocationPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("locationName", typeof(CodeType))]
        [System.Xml.Serialization.XmlElementAttribute("locationReference", typeof(ReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("pos", typeof(DirectPositionType))]
        [System.Xml.Serialization.XmlElementAttribute("position", typeof(GeometryPropertyType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        
        public MeasureType speed {
            get {
                return this.speedField;
            }
            set {
                this.speedField = value;
            }
        }
        
        
        public DirectionPropertyType bearing {
            get {
                return this.bearingField;
            }
            set {
                this.bearingField = value;
            }
        }
        
        
        public MeasureType acceleration {
            get {
                return this.accelerationField;
            }
            set {
                this.accelerationField = value;
            }
        }
        
        
        public MeasureType elevation {
            get {
                return this.elevationField;
            }
            set {
                this.elevationField = value;
            }
        }
        
        
        public StringOrRefType status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        
        public ReferenceType statusReference {
            get {
                return this.statusReferenceField;
            }
            set {
                this.statusReferenceField = value;
            }
        }
    }
}
