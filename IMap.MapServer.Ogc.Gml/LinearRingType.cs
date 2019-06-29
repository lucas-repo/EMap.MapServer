namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("LinearRing", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class LinearRingType : AbstractRingType {
        
        private object[] itemsField;
        
        private ItemsChoiceType4[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coord", typeof(CoordType))]
        [System.Xml.Serialization.XmlElementAttribute("coordinates", typeof(CoordinatesType))]
        [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pointRep", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pos", typeof(DirectPositionType))]
        [System.Xml.Serialization.XmlElementAttribute("posList", typeof(DirectPositionListType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType4[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
}
