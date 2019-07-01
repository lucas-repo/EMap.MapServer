namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TopoComplex", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TopoComplexType : AbstractTopologyType {
        
        private TopoComplexMemberType maximalComplexField;
        
        private TopoComplexMemberType[] superComplexField;
        
        private TopoComplexMemberType[] subComplexField;
        
        private TopoPrimitiveMemberType[] topoPrimitiveMemberField;
        
        private TopoPrimitiveArrayAssociationType topoPrimitiveMembersField;
        
        private bool isMaximalField;
        
        public TopoComplexType() {
            this.isMaximalField = false;
        }
        
        /// <remarks/>
        public TopoComplexMemberType maximalComplex {
            get {
                return this.maximalComplexField;
            }
            set {
                this.maximalComplexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("superComplex")]
        public TopoComplexMemberType[] superComplex {
            get {
                return this.superComplexField;
            }
            set {
                this.superComplexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subComplex")]
        public TopoComplexMemberType[] subComplex {
            get {
                return this.subComplexField;
            }
            set {
                this.subComplexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("topoPrimitiveMember")]
        public TopoPrimitiveMemberType[] topoPrimitiveMember {
            get {
                return this.topoPrimitiveMemberField;
            }
            set {
                this.topoPrimitiveMemberField = value;
            }
        }
        
        /// <remarks/>
        public TopoPrimitiveArrayAssociationType topoPrimitiveMembers {
            get {
                return this.topoPrimitiveMembersField;
            }
            set {
                this.topoPrimitiveMembersField = value;
            }
        }
        
        /// <remarks/>
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
    }
}
