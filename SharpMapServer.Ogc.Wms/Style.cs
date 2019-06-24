namespace SharpMapServer.Ogc.Wms {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wms", IsNullable=false)]
    public partial class Style {
        
        private string nameField;
        
        private string titleField;
        
        private string abstractField;
        
        private LegendURL[] legendURLField;
        
        private StyleSheetURL styleSheetURLField;
        
        private StyleURL styleURLField;
        
        
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        
        public string Abstract {
            get {
                return this.abstractField;
            }
            set {
                this.abstractField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("LegendURL")]
        public LegendURL[] LegendURL {
            get {
                return this.legendURLField;
            }
            set {
                this.legendURLField = value;
            }
        }
        
        
        public StyleSheetURL StyleSheetURL {
            get {
                return this.styleSheetURLField;
            }
            set {
                this.styleSheetURLField = value;
            }
        }
        
        
        public StyleURL StyleURL {
            get {
                return this.styleURLField;
            }
            set {
                this.styleURLField = value;
            }
        }
    }
}
