using SharpMapServer.Isotc211.Gco;

namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("DQ_QuantitativeResult", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class DQ_QuantitativeResult_Type : AbstractDQ_Result_Type {
        
        private RecordType_PropertyType valueTypeField;
        
        private UnitOfMeasure_PropertyType valueUnitField;
        
        private CharacterString_PropertyType errorStatisticField;
        
        private Record_PropertyType[] valueField;
        
        
        public RecordType_PropertyType valueType {
            get {
                return this.valueTypeField;
            }
            set {
                this.valueTypeField = value;
            }
        }
        
        
        public UnitOfMeasure_PropertyType valueUnit {
            get {
                return this.valueUnitField;
            }
            set {
                this.valueUnitField = value;
            }
        }
        
        
        public CharacterString_PropertyType errorStatistic {
            get {
                return this.errorStatisticField;
            }
            set {
                this.errorStatisticField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public Record_PropertyType[] value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
