namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Envelope", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class EnvelopeType {
        
        private object[] itemsField;
        
        private ItemsChoiceType1[] itemsElementNameField;
        
        private string srsNameField;
        
        private string srsDimensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coord", typeof(CoordType))]
        [System.Xml.Serialization.XmlElementAttribute("coordinates", typeof(CoordinatesType))]
        [System.Xml.Serialization.XmlElementAttribute("lowerCorner", typeof(DirectPositionType))]
        [System.Xml.Serialization.XmlElementAttribute("pos", typeof(DirectPositionType))]
        [System.Xml.Serialization.XmlElementAttribute("upperCorner", typeof(DirectPositionType))]
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
        public ItemsChoiceType1[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string srsName {
            get {
                return this.srsNameField;
            }
            set {
                this.srsNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string srsDimension {
            get {
                return this.srsDimensionField;
            }
            set {
                this.srsDimensionField = value;
            }
        }
    }
}
