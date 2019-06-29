namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("TopoVolume", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TopoVolumeType : AbstractTopologyType {
        
        private DirectedTopoSolidPropertyType[] directedTopoSolidField;
        
        private AggregationType aggregationTypeField;
        
        private bool aggregationTypeFieldSpecified;
        
        
        [System.Xml.Serialization.XmlElementAttribute("directedTopoSolid")]
        public DirectedTopoSolidPropertyType[] directedTopoSolid {
            get {
                return this.directedTopoSolidField;
            }
            set {
                this.directedTopoSolidField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AggregationType aggregationType {
            get {
                return this.aggregationTypeField;
            }
            set {
                this.aggregationTypeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool aggregationTypeSpecified {
            get {
                return this.aggregationTypeFieldSpecified;
            }
            set {
                this.aggregationTypeFieldSpecified = value;
            }
        }
    }
}
