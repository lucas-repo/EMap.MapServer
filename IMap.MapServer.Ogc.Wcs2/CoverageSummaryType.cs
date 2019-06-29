using IMap.MapServer.Ogc.Ows2;
using System.Xml.Linq;

namespace IMap.MapServer.Ogc.Wcs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wcs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("CoverageSummary", Namespace="http://www.opengis.net/wcs/2.0", IsNullable=false)]
    public partial class CoverageSummaryType : DescriptionType {
        
        private WGS84BoundingBoxType[] wGS84BoundingBoxField;
        
        private string coverageIdField;
        
        private System.Xml.XmlQualifiedName coverageSubtypeField;
        
        private CoverageSubtypeParentType coverageSubtypeParentField;
        
        private BoundingBoxType[] boundingBoxField;
        
        private MetadataType[] metadataField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("WGS84BoundingBox", Namespace="http://www.opengis.net/ows/2.0")]
        public WGS84BoundingBoxType[] WGS84BoundingBox {
            get {
                return this.wGS84BoundingBoxField;
            }
            set {
                this.wGS84BoundingBoxField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="NCName")]
        public string CoverageId {
            get {
                return this.coverageIdField;
            }
            set {
                this.coverageIdField = value;
            }
        }
        
        
        public System.Xml.XmlQualifiedName CoverageSubtype {
            get {
                return this.coverageSubtypeField;
            }
            set {
                this.coverageSubtypeField = value;
            }
        }
        
        
        public CoverageSubtypeParentType CoverageSubtypeParent {
            get {
                return this.coverageSubtypeParentField;
            }
            set {
                this.coverageSubtypeParentField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("BoundingBox", Namespace="http://www.opengis.net/ows/2.0")]
        public BoundingBoxType[] BoundingBox {
            get {
                return this.boundingBoxField;
            }
            set {
                this.boundingBoxField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Metadata", Namespace="http://www.opengis.net/ows/2.0")]
        public MetadataType[] Metadata {
            get {
                return this.metadataField;
            }
            set {
                this.metadataField = value;
            }
        }
    }
}
