using SharpMapServer.Ogc.Gml3_2;
using SharpMapServer.Ogc.Swe2;

namespace SharpMapServer.Ogc.Gmlcov
{




    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="AbstractCoverageType", Namespace="http://www.opengis.net/gmlcov/1.0")]
    public partial class AbstractCoverageType1 : AbstractCoverageType {
        
        private CoverageFunctionType coverageFunctionField;
        
        private DataRecordPropertyType rangeTypeField;
        
        private metadata[] metadataField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/gml/3.2")]
        public CoverageFunctionType coverageFunction {
            get {
                return this.coverageFunctionField;
            }
            set {
                this.coverageFunctionField = value;
            }
        }
        
        
        public DataRecordPropertyType rangeType {
            get {
                return this.rangeTypeField;
            }
            set {
                this.rangeTypeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("metadata")]
        public metadata[] metadata {
            get {
                return this.metadataField;
            }
            set {
                this.metadataField = value;
            }
        }
    }
}
