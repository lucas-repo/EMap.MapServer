using IMap.MapServer.Ogc.Ows1_1;

namespace IMap.MapServer.Ogc.Wmts1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wmts/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("Layer", Namespace="http://www.opengis.net/wmts/1.0", IsNullable=false)]
    public partial class LayerType : DatasetDescriptionSummaryBaseType {
        
        private Style[] styleField;
        
        private string[] formatField;
        
        private string[] infoFormatField;
        
        private Dimension[] dimensionField;
        
        private TileMatrixSetLink[] tileMatrixSetLinkField;
        
        private URLTemplateType[] resourceURLField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("Style")]
        public Style[] Style {
            get {
                return this.styleField;
            }
            set {
                this.styleField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Format")]
        public string[] Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("InfoFormat")]
        public string[] InfoFormat {
            get {
                return this.infoFormatField;
            }
            set {
                this.infoFormatField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Dimension")]
        public Dimension[] Dimension {
            get {
                return this.dimensionField;
            }
            set {
                this.dimensionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("TileMatrixSetLink")]
        public TileMatrixSetLink[] TileMatrixSetLink {
            get {
                return this.tileMatrixSetLinkField;
            }
            set {
                this.tileMatrixSetLinkField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("ResourceURL")]
        public URLTemplateType[] ResourceURL {
            get {
                return this.resourceURLField;
            }
            set {
                this.resourceURLField = value;
            }
        }
    }
}
