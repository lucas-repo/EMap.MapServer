namespace IMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("rangeType", Namespace="http://www.opengis.net/gmlcov/1.0", IsNullable=false)]
    public partial class DataRecordPropertyType {
        
        private DataRecordType dataRecordField;
        
        
        public DataRecordType DataRecord {
            get {
                return this.dataRecordField;
            }
            set {
                this.dataRecordField = value;
            }
        }
    }
}
