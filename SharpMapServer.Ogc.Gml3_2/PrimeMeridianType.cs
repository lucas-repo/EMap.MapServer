namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("PrimeMeridian", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class PrimeMeridianType : IdentifiedObjectType {
        
        private AngleType greenwichLongitudeField;
        
        
        public AngleType greenwichLongitude {
            get {
                return this.greenwichLongitudeField;
            }
            set {
                this.greenwichLongitudeField = value;
            }
        }
    }
}
