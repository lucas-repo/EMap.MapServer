using IMap.MapServer.Isotc211.Gco;

namespace IMap.MapServer.Isotc211.Gmd {
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_Completeness_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_CompletenessCommission_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_CompletenessOmission_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_LogicalConsistency_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_ConceptualConsistency_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_DomainConsistency_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_FormatConsistency_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_TopologicalConsistency_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_PositionalAccuracy_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_AbsoluteExternalPositionalAccuracy_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_GriddedDataPositionalAccuracy_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_RelativeInternalPositionalAccuracy_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_ThematicAccuracy_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_ThematicClassificationCorrectness_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_NonQuantitativeAttributeAccuracy_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_QuantitativeAttributeAccuracy_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_TemporalAccuracy_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_AccuracyOfATimeMeasurement_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_TemporalConsistency_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_TemporalValidity_Type))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public abstract partial class AbstractDQ_Element_Type : AbstractObject_Type {
        
        private CharacterString_PropertyType[] nameOfMeasureField;
        
        private MD_Identifier_PropertyType measureIdentificationField;
        
        private CharacterString_PropertyType measureDescriptionField;
        
        private DQ_EvaluationMethodTypeCode_PropertyType evaluationMethodTypeField;
        
        private CharacterString_PropertyType evaluationMethodDescriptionField;
        
        private CI_Citation_PropertyType evaluationProcedureField;
        
        private DateTime_PropertyType[] dateTimeField;
        
        private DQ_Result_PropertyType[] resultField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("nameOfMeasure")]
        public CharacterString_PropertyType[] nameOfMeasure {
            get {
                return this.nameOfMeasureField;
            }
            set {
                this.nameOfMeasureField = value;
            }
        }
        
        
        public MD_Identifier_PropertyType measureIdentification {
            get {
                return this.measureIdentificationField;
            }
            set {
                this.measureIdentificationField = value;
            }
        }
        
        
        public CharacterString_PropertyType measureDescription {
            get {
                return this.measureDescriptionField;
            }
            set {
                this.measureDescriptionField = value;
            }
        }
        
        
        public DQ_EvaluationMethodTypeCode_PropertyType evaluationMethodType {
            get {
                return this.evaluationMethodTypeField;
            }
            set {
                this.evaluationMethodTypeField = value;
            }
        }
        
        
        public CharacterString_PropertyType evaluationMethodDescription {
            get {
                return this.evaluationMethodDescriptionField;
            }
            set {
                this.evaluationMethodDescriptionField = value;
            }
        }
        
        
        public CI_Citation_PropertyType evaluationProcedure {
            get {
                return this.evaluationProcedureField;
            }
            set {
                this.evaluationProcedureField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("dateTime")]
        public DateTime_PropertyType[] dateTime {
            get {
                return this.dateTimeField;
            }
            set {
                this.dateTimeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("result")]
        public DQ_Result_PropertyType[] result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
    }
}
