namespace IMap.MapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Not", Namespace="http://www.opengis.net/fes/2.0", IsNullable=false)]
    public partial class UnaryLogicOpType : LogicOpsType {
        
        private object[] itemsField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("_Id", typeof(AbstractIdType))]
        [System.Xml.Serialization.XmlElementAttribute("comparisonOps", typeof(ComparisonOpsType))]
        [System.Xml.Serialization.XmlElementAttribute("extensionOps", typeof(ExtensionOpsType))]
        [System.Xml.Serialization.XmlElementAttribute("logicOps", typeof(LogicOpsType))]
        [System.Xml.Serialization.XmlElementAttribute("spatialOps", typeof(SpatialOpsType))]
        [System.Xml.Serialization.XmlElementAttribute("temporalOps", typeof(TemporalOpsType))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
}
