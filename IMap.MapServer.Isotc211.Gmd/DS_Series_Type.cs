namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DS_ProductionSeries_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DS_Sensor_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DS_Platform_Type))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("DS_Series", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class DS_Series_Type : AbstractDS_Aggregate_Type {
    }
}
