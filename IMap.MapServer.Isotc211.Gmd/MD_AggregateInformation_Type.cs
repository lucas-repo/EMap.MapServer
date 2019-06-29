using IMap.MapServer.Isotc211.Gco;

namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_AggregateInformation", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_AggregateInformation_Type : AbstractObject_Type {
        
        private CI_Citation_PropertyType aggregateDataSetNameField;
        
        private MD_Identifier_PropertyType aggregateDataSetIdentifierField;
        
        private DS_AssociationTypeCode_PropertyType associationTypeField;
        
        private DS_InitiativeTypeCode_PropertyType initiativeTypeField;
        
        
        public CI_Citation_PropertyType aggregateDataSetName {
            get {
                return this.aggregateDataSetNameField;
            }
            set {
                this.aggregateDataSetNameField = value;
            }
        }
        
        
        public MD_Identifier_PropertyType aggregateDataSetIdentifier {
            get {
                return this.aggregateDataSetIdentifierField;
            }
            set {
                this.aggregateDataSetIdentifierField = value;
            }
        }
        
        
        public DS_AssociationTypeCode_PropertyType associationType {
            get {
                return this.associationTypeField;
            }
            set {
                this.associationTypeField = value;
            }
        }
        
        
        public DS_InitiativeTypeCode_PropertyType initiativeType {
            get {
                return this.initiativeTypeField;
            }
            set {
                this.initiativeTypeField = value;
            }
        }
    }
}
