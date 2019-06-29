namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("rangeSet", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class RangeSetType {
        
        private object[] itemsField;
        
        private ItemsChoiceType11[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BooleanList", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CategoryList", typeof(CodeOrNullListType))]
        [System.Xml.Serialization.XmlElementAttribute("CountList", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("DataBlock", typeof(DataBlockType))]
        [System.Xml.Serialization.XmlElementAttribute("File", typeof(FileType))]
        [System.Xml.Serialization.XmlElementAttribute("QuantityList", typeof(MeasureOrNullListType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueArray", typeof(ValueArrayType))]
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
        public ItemsChoiceType11[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
}
