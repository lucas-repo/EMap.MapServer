namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("ImageCRS", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class ImageCRSType : AbstractReferenceSystemType {
        
        private object itemField;
        
        private ImageDatumRefType usesImageDatumField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("usesCartesianCS", typeof(CartesianCSRefType))]
        [System.Xml.Serialization.XmlElementAttribute("usesObliqueCartesianCS", typeof(ObliqueCartesianCSRefType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        public ImageDatumRefType usesImageDatum {
            get {
                return this.usesImageDatumField;
            }
            set {
                this.usesImageDatumField = value;
            }
        }
    }
}
