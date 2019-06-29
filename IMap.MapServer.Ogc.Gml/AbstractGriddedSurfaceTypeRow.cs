namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/gml")]
    public partial class AbstractGriddedSurfaceTypeRow {
        
        private DirectPositionListType posListField;
        
        private DirectPositionType[] posField;
        
        private PointPropertyType[] pointPropertyField;
        
        /// <remarks/>
        public DirectPositionListType posList {
            get {
                return this.posListField;
            }
            set {
                this.posListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pos")]
        public DirectPositionType[] pos {
            get {
                return this.posField;
            }
            set {
                this.posField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pointProperty")]
        public PointPropertyType[] pointProperty {
            get {
                return this.pointPropertyField;
            }
            set {
                this.pointPropertyField = value;
            }
        }
    }
}
