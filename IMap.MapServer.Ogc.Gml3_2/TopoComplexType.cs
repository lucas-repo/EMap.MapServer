namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("TopoComplex", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TopoComplexType : AbstractTopologyType {
        
        private TopoComplexPropertyType maximalComplexField;
        
        private TopoComplexPropertyType[] superComplexField;
        
        private TopoComplexPropertyType[] subComplexField;
        
        private TopoPrimitiveMemberType[] topoPrimitiveMemberField;
        
        private TopoPrimitiveArrayAssociationType topoPrimitiveMembersField;
        
        private bool isMaximalField;
        
        private AggregationType aggregationTypeField;
        
        private bool aggregationTypeFieldSpecified;
        
        public TopoComplexType() {
            this.isMaximalField = false;
        }
        
        
        public TopoComplexPropertyType maximalComplex {
            get {
                return this.maximalComplexField;
            }
            set {
                this.maximalComplexField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("superComplex")]
        public TopoComplexPropertyType[] superComplex {
            get {
                return this.superComplexField;
            }
            set {
                this.superComplexField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("subComplex")]
        public TopoComplexPropertyType[] subComplex {
            get {
                return this.subComplexField;
            }
            set {
                this.subComplexField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("topoPrimitiveMember")]
        public TopoPrimitiveMemberType[] topoPrimitiveMember {
            get {
                return this.topoPrimitiveMemberField;
            }
            set {
                this.topoPrimitiveMemberField = value;
            }
        }
        
        
        public TopoPrimitiveArrayAssociationType topoPrimitiveMembers {
            get {
                return this.topoPrimitiveMembersField;
            }
            set {
                this.topoPrimitiveMembersField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool isMaximal {
            get {
                return this.isMaximalField;
            }
            set {
                this.isMaximalField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AggregationType aggregationType {
            get {
                return this.aggregationTypeField;
            }
            set {
                this.aggregationTypeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool aggregationTypeSpecified {
            get {
                return this.aggregationTypeFieldSpecified;
            }
            set {
                this.aggregationTypeFieldSpecified = value;
            }
        }
    }
}
