namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TinType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("Surface", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class SurfaceType : AbstractSurfaceType {
        
        private SurfacePatchArrayPropertyType patchesField;
        
        
        public SurfacePatchArrayPropertyType patches {
            get {
                return this.patchesField;
            }
            set {
                this.patchesField = value;
            }
        }
    }
}
