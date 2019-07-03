using EMap.MapServer.Ogc.Ows1_1;

namespace EMap.MapServer.Ogc.Wmts1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wmts/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wmts/1.0", IsNullable=false)]
    public partial class Theme : DescriptionType {
        
        private CodeType identifierField;
        
        private Theme[] theme1Field;
        
        private string[] layerRefField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/ows/1.1")]
        public CodeType Identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Theme")]
        public Theme[] Theme1 {
            get {
                return this.theme1Field;
            }
            set {
                this.theme1Field = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("LayerRef", DataType="anyURI")]
        public string[] LayerRef {
            get {
                return this.layerRefField;
            }
            set {
                this.layerRefField = value;
            }
        }
    }
}
