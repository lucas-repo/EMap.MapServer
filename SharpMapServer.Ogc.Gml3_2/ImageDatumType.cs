namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("ImageDatum", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class ImageDatumType : AbstractDatumType {
        
        private CodeWithAuthorityType pixelInCellField;
        
        
        public CodeWithAuthorityType pixelInCell {
            get {
                return this.pixelInCellField;
            }
            set {
                this.pixelInCellField = value;
            }
        }
    }
}
