﻿namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TopoSolid", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TopoSolidType : AbstractTopoPrimitiveType {
        
        private DirectedFacePropertyType[] directedFaceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("directedFace")]
        public DirectedFacePropertyType[] directedFace {
            get {
                return this.directedFaceField;
            }
            set {
                this.directedFaceField = value;
            }
        }
    }
}