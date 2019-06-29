namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimeOrdinalEra", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TimeOrdinalEraType : DefinitionType {
        
        private RelatedTimeType[] relatedTimeField;
        
        private TimeNodePropertyType startField;
        
        private TimeNodePropertyType endField;
        
        private TimePeriodPropertyType extentField;
        
        private TimeOrdinalEraPropertyType[] memberField;
        
        private ReferenceType groupField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("relatedTime")]
        public RelatedTimeType[] relatedTime {
            get {
                return this.relatedTimeField;
            }
            set {
                this.relatedTimeField = value;
            }
        }
        
        /// <remarks/>
        public TimeNodePropertyType start {
            get {
                return this.startField;
            }
            set {
                this.startField = value;
            }
        }
        
        /// <remarks/>
        public TimeNodePropertyType end {
            get {
                return this.endField;
            }
            set {
                this.endField = value;
            }
        }
        
        /// <remarks/>
        public TimePeriodPropertyType extent {
            get {
                return this.extentField;
            }
            set {
                this.extentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("member")]
        public TimeOrdinalEraPropertyType[] member {
            get {
                return this.memberField;
            }
            set {
                this.memberField = value;
            }
        }
        
        /// <remarks/>
        public ReferenceType group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
    }
}
