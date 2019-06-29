namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("CoordinateSystemAxis", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class CoordinateSystemAxisType : IdentifiedObjectType {
        
        private CodeType axisAbbrevField;
        
        private CodeWithAuthorityType axisDirectionField;
        
        private double minimumValueField;
        
        private bool minimumValueFieldSpecified;
        
        private double maximumValueField;
        
        private bool maximumValueFieldSpecified;
        
        private CodeWithAuthorityType rangeMeaningField;
        
        private string uomField;
        
        
        public CodeType axisAbbrev {
            get {
                return this.axisAbbrevField;
            }
            set {
                this.axisAbbrevField = value;
            }
        }
        
        
        public CodeWithAuthorityType axisDirection {
            get {
                return this.axisDirectionField;
            }
            set {
                this.axisDirectionField = value;
            }
        }
        
        
        public double minimumValue {
            get {
                return this.minimumValueField;
            }
            set {
                this.minimumValueField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minimumValueSpecified {
            get {
                return this.minimumValueFieldSpecified;
            }
            set {
                this.minimumValueFieldSpecified = value;
            }
        }
        
        
        public double maximumValue {
            get {
                return this.maximumValueField;
            }
            set {
                this.maximumValueField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumValueSpecified {
            get {
                return this.maximumValueFieldSpecified;
            }
            set {
                this.maximumValueFieldSpecified = value;
            }
        }
        
        
        public CodeWithAuthorityType rangeMeaning {
            get {
                return this.rangeMeaningField;
            }
            set {
                this.rangeMeaningField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uom {
            get {
                return this.uomField;
            }
            set {
                this.uomField = value;
            }
        }
    }
}
