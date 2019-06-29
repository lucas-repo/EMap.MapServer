namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/gml/3.2")]
    public partial class ClothoidTypeRefLocation {
        
        private AffinePlacementType affinePlacementField;
        
        
        public AffinePlacementType AffinePlacement {
            get {
                return this.affinePlacementField;
            }
            set {
                this.affinePlacementField = value;
            }
        }
    }
}
