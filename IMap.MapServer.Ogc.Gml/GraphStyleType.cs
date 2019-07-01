namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("GraphStyle", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class GraphStyleType : BaseStyleDescriptorType {
        
        private bool planarField;
        
        private bool planarFieldSpecified;
        
        private bool directedField;
        
        private bool directedFieldSpecified;
        
        private bool gridField;
        
        private bool gridFieldSpecified;
        
        private double minDistanceField;
        
        private bool minDistanceFieldSpecified;
        
        private double minAngleField;
        
        private bool minAngleFieldSpecified;
        
        private GraphTypeType graphTypeField;
        
        private bool graphTypeFieldSpecified;
        
        private DrawingTypeType drawingTypeField;
        
        private bool drawingTypeFieldSpecified;
        
        private LineTypeType lineTypeField;
        
        private bool lineTypeFieldSpecified;
        
        private AesheticCriteriaType[] aestheticCriteriaField;
        
        /// <remarks/>
        public bool planar {
            get {
                return this.planarField;
            }
            set {
                this.planarField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool planarSpecified {
            get {
                return this.planarFieldSpecified;
            }
            set {
                this.planarFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool directed {
            get {
                return this.directedField;
            }
            set {
                this.directedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool directedSpecified {
            get {
                return this.directedFieldSpecified;
            }
            set {
                this.directedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool grid {
            get {
                return this.gridField;
            }
            set {
                this.gridField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool gridSpecified {
            get {
                return this.gridFieldSpecified;
            }
            set {
                this.gridFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public double minDistance {
            get {
                return this.minDistanceField;
            }
            set {
                this.minDistanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minDistanceSpecified {
            get {
                return this.minDistanceFieldSpecified;
            }
            set {
                this.minDistanceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public double minAngle {
            get {
                return this.minAngleField;
            }
            set {
                this.minAngleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minAngleSpecified {
            get {
                return this.minAngleFieldSpecified;
            }
            set {
                this.minAngleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public GraphTypeType graphType {
            get {
                return this.graphTypeField;
            }
            set {
                this.graphTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool graphTypeSpecified {
            get {
                return this.graphTypeFieldSpecified;
            }
            set {
                this.graphTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public DrawingTypeType drawingType {
            get {
                return this.drawingTypeField;
            }
            set {
                this.drawingTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool drawingTypeSpecified {
            get {
                return this.drawingTypeFieldSpecified;
            }
            set {
                this.drawingTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public LineTypeType lineType {
            get {
                return this.lineTypeField;
            }
            set {
                this.lineTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lineTypeSpecified {
            get {
                return this.lineTypeFieldSpecified;
            }
            set {
                this.lineTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("aestheticCriteria")]
        public AesheticCriteriaType[] aestheticCriteria {
            get {
                return this.aestheticCriteriaField;
            }
            set {
                this.aestheticCriteriaField = value;
            }
        }
    }
}
