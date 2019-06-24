﻿namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("exterior", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class AbstractRingPropertyType {
        
        private AbstractRingType abstractRingField;
        
        
        public AbstractRingType AbstractRing {
            get {
                return this.abstractRingField;
            }
            set {
                this.abstractRingField = value;
            }
        }
    }
}