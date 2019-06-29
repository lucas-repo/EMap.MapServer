namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("VerticalDatum", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class VerticalDatumType : AbstractDatumType {
        
        private VerticalDatumTypeType verticalDatumTypeField;
        
        /// <remarks/>
        public VerticalDatumTypeType verticalDatumType {
            get {
                return this.verticalDatumTypeField;
            }
            set {
                this.verticalDatumTypeField = value;
            }
        }
    }
}
