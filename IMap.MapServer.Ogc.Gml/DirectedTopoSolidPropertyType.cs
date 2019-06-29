namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("directedTopoSolid", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class DirectedTopoSolidPropertyType {
        
        private TopoSolidType topoSolidField;
        
        private SignType orientationField;
        
        private string remoteSchemaField;
        
        public DirectedTopoSolidPropertyType() {
            this.orientationField = SignType.Item1;
        }
        
        /// <remarks/>
        public TopoSolidType TopoSolid {
            get {
                return this.topoSolidField;
            }
            set {
                this.topoSolidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(SignType.Item1)]
        public SignType orientation {
            get {
                return this.orientationField;
            }
            set {
                this.orientationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
}
