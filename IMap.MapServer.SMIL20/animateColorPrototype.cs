namespace IMap.MapServer.SMIL20 {
    
    
    
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(animateColorType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2001/SMIL20/")]
    public partial class animateColorPrototype {
        
        private string attributeNameField;
        
        private animatePrototypeAttributeType attributeTypeField;
        
        private animatePrototypeAdditive additiveField;
        
        private animatePrototypeAccumulate accumulateField;
        
        private string fromField;
        
        private string byField;
        
        private string valuesField;
        
        public animateColorPrototype() {
            this.attributeTypeField = animatePrototypeAttributeType.auto;
            this.additiveField = animatePrototypeAdditive.replace;
            this.accumulateField = animatePrototypeAccumulate.none;
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string attributeName {
            get {
                return this.attributeNameField;
            }
            set {
                this.attributeNameField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(animatePrototypeAttributeType.auto)]
        public animatePrototypeAttributeType attributeType {
            get {
                return this.attributeTypeField;
            }
            set {
                this.attributeTypeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(animatePrototypeAdditive.replace)]
        public animatePrototypeAdditive additive {
            get {
                return this.additiveField;
            }
            set {
                this.additiveField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(animatePrototypeAccumulate.none)]
        public animatePrototypeAccumulate accumulate {
            get {
                return this.accumulateField;
            }
            set {
                this.accumulateField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string from {
            get {
                return this.fromField;
            }
            set {
                this.fromField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string by {
            get {
                return this.byField;
            }
            set {
                this.byField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string values {
            get {
                return this.valuesField;
            }
            set {
                this.valuesField = value;
            }
        }
    }
}
