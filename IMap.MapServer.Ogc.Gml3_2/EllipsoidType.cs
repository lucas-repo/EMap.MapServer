namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("Ellipsoid", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class EllipsoidType : IdentifiedObjectType {
        
        private MeasureType semiMajorAxisField;
        
        private SecondDefiningParameter secondDefiningParameterField;
        
        
        public MeasureType semiMajorAxis {
            get {
                return this.semiMajorAxisField;
            }
            set {
                this.semiMajorAxisField = value;
            }
        }
        
        
        public SecondDefiningParameter secondDefiningParameter {
            get {
                return this.secondDefiningParameterField;
            }
            set {
                this.secondDefiningParameterField = value;
            }
        }
    }
}
