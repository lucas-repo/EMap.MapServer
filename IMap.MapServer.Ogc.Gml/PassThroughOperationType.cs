namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("PassThroughOperation", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class PassThroughOperationType : AbstractCoordinateOperationType {
        
        private string[] modifiedCoordinateField;
        
        private OperationRefType usesOperationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("modifiedCoordinate", DataType="positiveInteger")]
        public string[] modifiedCoordinate {
            get {
                return this.modifiedCoordinateField;
            }
            set {
                this.modifiedCoordinateField = value;
            }
        }
        
        /// <remarks/>
        public OperationRefType usesOperation {
            get {
                return this.usesOperationField;
            }
            set {
                this.usesOperationField = value;
            }
        }
    }
}
