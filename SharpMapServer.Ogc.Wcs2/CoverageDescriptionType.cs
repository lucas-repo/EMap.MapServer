using SharpMapServer.Ogc.Gml3_2;
using SharpMapServer.Ogc.Gmlcov;
using SharpMapServer.Ogc.Swe2;

namespace SharpMapServer.Ogc.Wcs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wcs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("CoverageDescription", Namespace="http://www.opengis.net/wcs/2.0", IsNullable=false)]
    public partial class CoverageDescriptionType : AbstractFeatureType {
        
        private string coverageIdField;
        
        private CoverageFunctionType coverageFunctionField;
        
        private metadata[] metadataField;
        
        private DomainSetType domainSetField;
        
        private DataRecordPropertyType rangeTypeField;
        
        private ServiceParametersType serviceParametersField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="NCName")]
        public string CoverageId {
            get {
                return this.coverageIdField;
            }
            set {
                this.coverageIdField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/gml/3.2")]
        public CoverageFunctionType coverageFunction {
            get {
                return this.coverageFunctionField;
            }
            set {
                this.coverageFunctionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("metadata", Namespace="http://www.opengis.net/gmlcov/1.0")]
        public metadata[] metadata {
            get {
                return this.metadataField;
            }
            set {
                this.metadataField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/gml/3.2")]
        public DomainSetType domainSet {
            get {
                return this.domainSetField;
            }
            set {
                this.domainSetField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/gmlcov/1.0")]
        public DataRecordPropertyType rangeType {
            get {
                return this.rangeTypeField;
            }
            set {
                this.rangeTypeField = value;
            }
        }
        
        
        public ServiceParametersType ServiceParameters {
            get {
                return this.serviceParametersField;
            }
            set {
                this.serviceParametersField = value;
            }
        }
    }
}
