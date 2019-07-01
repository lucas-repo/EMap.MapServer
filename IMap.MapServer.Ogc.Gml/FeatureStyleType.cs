namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("FeatureStyle", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class FeatureStyleType : AbstractGMLType {
        
        private string featureConstraintField;
        
        private GeometryStylePropertyType[] geometryStyleField;
        
        private TopologyStylePropertyType[] topologyStyleField;
        
        private LabelStylePropertyType labelStyleField;
        
        private string featureTypeField;
        
        private string baseTypeField;
        
        private QueryGrammarEnumeration queryGrammarField;
        
        private bool queryGrammarFieldSpecified;
        
        /// <remarks/>
        public string featureConstraint {
            get {
                return this.featureConstraintField;
            }
            set {
                this.featureConstraintField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("geometryStyle")]
        public GeometryStylePropertyType[] geometryStyle {
            get {
                return this.geometryStyleField;
            }
            set {
                this.geometryStyleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("topologyStyle")]
        public TopologyStylePropertyType[] topologyStyle {
            get {
                return this.topologyStyleField;
            }
            set {
                this.topologyStyleField = value;
            }
        }
        
        /// <remarks/>
        public LabelStylePropertyType labelStyle {
            get {
                return this.labelStyleField;
            }
            set {
                this.labelStyleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string featureType {
            get {
                return this.featureTypeField;
            }
            set {
                this.featureTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string baseType {
            get {
                return this.baseTypeField;
            }
            set {
                this.baseTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public QueryGrammarEnumeration queryGrammar {
            get {
                return this.queryGrammarField;
            }
            set {
                this.queryGrammarField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool queryGrammarSpecified {
            get {
                return this.queryGrammarFieldSpecified;
            }
            set {
                this.queryGrammarFieldSpecified = value;
            }
        }
    }
}
