namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("ImageCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class ImageCRSType : AbstractCRSType {
        
        private object itemField;
        
        private ImageDatumPropertyType imageDatumField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("affineCS", typeof(AffineCSPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("cartesianCS", typeof(CartesianCSPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("usesObliqueCartesianCS", typeof(ObliqueCartesianCSPropertyType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        
        public ImageDatumPropertyType imageDatum {
            get {
                return this.imageDatumField;
            }
            set {
                this.imageDatumField = value;
            }
        }
    }
}
