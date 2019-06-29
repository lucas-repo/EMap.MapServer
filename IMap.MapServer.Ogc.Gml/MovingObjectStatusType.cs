namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("MovingObjectStatus", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class MovingObjectStatusType : AbstractTimeSliceType {
        
        private LocationPropertyType locationField;
        
        private MeasureType speedField;
        
        private DirectionPropertyType bearingField;
        
        private MeasureType accelerationField;
        
        private MeasureType elevationField;
        
        private StringOrRefType statusField;
        
        /// <remarks/>
        public LocationPropertyType location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
        
        /// <remarks/>
        public MeasureType speed {
            get {
                return this.speedField;
            }
            set {
                this.speedField = value;
            }
        }
        
        /// <remarks/>
        public DirectionPropertyType bearing {
            get {
                return this.bearingField;
            }
            set {
                this.bearingField = value;
            }
        }
        
        /// <remarks/>
        public MeasureType acceleration {
            get {
                return this.accelerationField;
            }
            set {
                this.accelerationField = value;
            }
        }
        
        /// <remarks/>
        public MeasureType elevation {
            get {
                return this.elevationField;
            }
            set {
                this.elevationField = value;
            }
        }
        
        /// <remarks/>
        public StringOrRefType status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
    }
}
