using System.Xml.Linq;

namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("absoluteExternalPositionalAccuracy", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class AbsoluteExternalPositionalAccuracyType : AbstractPositionalAccuracyType {
        
        private MeasureType resultField;
        
        /// <remarks/>
        public MeasureType result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
    }
}
