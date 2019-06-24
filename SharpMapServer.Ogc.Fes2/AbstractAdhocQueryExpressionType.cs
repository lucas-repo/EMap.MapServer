namespace SharpMapServer.Ogc.Fes2 {
    
    
    
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(QueryType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    public abstract partial class AbstractAdhocQueryExpressionType : AbstractQueryExpressionType {
        
        private object[] abstractProjectionClauseField;
        
        private object abstractSelectionClauseField;
        
        private object abstractSortingClauseField;
        
        private string[] typeNamesField;
        
        private string[] aliasesField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("AbstractProjectionClause")]
        public object[] AbstractProjectionClause {
            get {
                return this.abstractProjectionClauseField;
            }
            set {
                this.abstractProjectionClauseField = value;
            }
        }
        
        
        public object AbstractSelectionClause {
            get {
                return this.abstractSelectionClauseField;
            }
            set {
                this.abstractSelectionClauseField = value;
            }
        }
        
        
        public object AbstractSortingClause {
            get {
                return this.abstractSortingClauseField;
            }
            set {
                this.abstractSortingClauseField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] typeNames {
            get {
                return this.typeNamesField;
            }
            set {
                this.typeNamesField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string[] aliases {
            get {
                return this.aliasesField;
            }
            set {
                this.aliasesField = value;
            }
        }
    }
}
