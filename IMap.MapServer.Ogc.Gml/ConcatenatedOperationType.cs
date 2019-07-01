namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("ConcatenatedOperation", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class ConcatenatedOperationType : AbstractCoordinateOperationType {
        
        private SingleOperationRefType[] usesSingleOperationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("usesSingleOperation")]
        public SingleOperationRefType[] usesSingleOperation {
            get {
                return this.usesSingleOperationField;
            }
            set {
                this.usesSingleOperationField = value;
            }
        }
    }
}
