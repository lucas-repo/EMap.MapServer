﻿using SharpMapServer.Ogc.Fes2;

namespace SharpMapServer.Ogc.Wfs2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GetFeatureWithLockType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetFeature", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class GetFeatureType : BaseRequestType {
        
        private AbstractQueryExpressionType[] abstractQueryExpressionField;
        
        private string startIndexField;
        
        private string countField;
        
        private ResultTypeType resultTypeField;
        
        private string outputFormatField;
        
        private ResolveValueType resolveField;
        
        private string resolveDepthField;
        
        private string resolveTimeoutField;
        
        public GetFeatureType() {
            this.startIndexField = "0";
            this.resultTypeField = ResultTypeType.results;
            this.outputFormatField = "application/gml+xml; version=3.2";
            this.resolveField = ResolveValueType.none;
            this.resolveDepthField = "*";
            this.resolveTimeoutField = "300";
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
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string startIndex {
            get {
                return this.startIndexField;
            }
            set {
                this.startIndexField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ResultTypeType.results)]
        public ResultTypeType resultType {
            get {
                return this.resultTypeField;
            }
            set {
                this.resultTypeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("application/gml+xml; version=3.2")]
        public string outputFormat {
            get {
                return this.outputFormatField;
            }
            set {
                this.outputFormatField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ResolveValueType.none)]
        public ResolveValueType resolve {
            get {
                return this.resolveField;
            }
            set {
                this.resolveField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("*")]
        public string resolveDepth {
            get {
                return this.resolveDepthField;
            }
            set {
                this.resolveDepthField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("300")]
        public string resolveTimeout {
            get {
                return this.resolveTimeoutField;
            }
            set {
                this.resolveTimeoutField = value;
            }
        }
    }
}