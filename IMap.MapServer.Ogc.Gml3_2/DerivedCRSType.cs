namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("DerivedCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class DerivedCRSType : AbstractGeneralDerivedCRSType {
        
        private SingleCRSPropertyType baseCRSField;
        
        private CodeWithAuthorityType derivedCRSTypeField;
        
        private CoordinateSystemPropertyType coordinateSystemField;
        
        
        public SingleCRSPropertyType baseCRS {
            get {
                return this.baseCRSField;
            }
            set {
                this.baseCRSField = value;
            }
        }
        
        
        public CodeWithAuthorityType derivedCRSType {
            get {
                return this.derivedCRSTypeField;
            }
            set {
                this.derivedCRSTypeField = value;
            }
        }
        
        
        public CoordinateSystemPropertyType coordinateSystem {
            get {
                return this.coordinateSystemField;
            }
            set {
                this.coordinateSystemField = value;
            }
        }
    }
}
