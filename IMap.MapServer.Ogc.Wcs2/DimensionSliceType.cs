namespace EMap.MapServer.Ogc.Wcs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wcs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DimensionSlice", Namespace="http://www.opengis.net/wcs/2.0", IsNullable=false)]
    public partial class DimensionSliceType : DimensionSubsetType {
        
        private string slicePointField;
        
        
        public string SlicePoint {
            get {
                return this.slicePointField;
            }
            set {
                this.slicePointField = value;
            }
        }
    }
}
