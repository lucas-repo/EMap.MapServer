using EMap.MapServer.SMIL20.Language;

namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GraphStyleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopologyStyleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LabelStyleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeometryStyleType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public partial class BaseStyleDescriptorType : AbstractGMLType {
        
        private ScaleType spatialResolutionField;
        
        private StyleVariationType[] styleVariationField;
        
        private animateType[] animateField;
        
        private animateMotionType[] animateMotionField;
        
        private animateColorType[] animateColorField;
        
        private setType[] setField;
        
        /// <remarks/>
        public ScaleType spatialResolution {
            get {
                return this.spatialResolutionField;
            }
            set {
                this.spatialResolutionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("styleVariation")]
        public StyleVariationType[] styleVariation {
            get {
                return this.styleVariationField;
            }
            set {
                this.styleVariationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("animate", Namespace="http://www.w3.org/2001/SMIL20/")]
        public animateType[] animate {
            get {
                return this.animateField;
            }
            set {
                this.animateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("animateMotion", Namespace="http://www.w3.org/2001/SMIL20/")]
        public animateMotionType[] animateMotion {
            get {
                return this.animateMotionField;
            }
            set {
                this.animateMotionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("animateColor", Namespace="http://www.w3.org/2001/SMIL20/")]
        public animateColorType[] animateColor {
            get {
                return this.animateColorField;
            }
            set {
                this.animateColorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("set", Namespace="http://www.w3.org/2001/SMIL20/")]
        public setType[] set {
            get {
                return this.setField;
            }
            set {
                this.setField = value;
            }
        }
    }
}
