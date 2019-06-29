using IMap.MapServer.Ogc.Fes2;

namespace IMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("LockFeature", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class LockFeatureType : BaseRequestType {
        
        private AbstractQueryExpressionType[] abstractQueryExpressionField;
        
        private string lockIdField;
        
        private string expiryField;
        
        private AllSomeType lockActionField;
        
        public LockFeatureType() {
            this.expiryField = "300";
            this.lockActionField = AllSomeType.ALL;
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("AbstractQueryExpression", Namespace="http://www.opengis.net/fes/2.0")]
        public AbstractQueryExpressionType[] AbstractQueryExpression {
            get {
                return this.abstractQueryExpressionField;
            }
            set {
                this.abstractQueryExpressionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lockId {
            get {
                return this.lockIdField;
            }
            set {
                this.lockIdField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("300")]
        public string expiry {
            get {
                return this.expiryField;
            }
            set {
                this.expiryField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(AllSomeType.ALL)]
        public AllSomeType lockAction {
            get {
                return this.lockActionField;
            }
            set {
                this.lockActionField = value;
            }
        }
    }
}
