using SharpMapServer.Ogc.Gml;

namespace SharpMapServer.Ogc.Wmts1
{
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wmts/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wmts/1.0", IsNullable=false)]
    public partial class FeatureInfoResponse {
        
        private object itemField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("_FeatureCollection", typeof(AbstractFeatureCollectionType), Namespace="http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("AnyContent", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("BinaryPayload", typeof(BinaryPayload))]
        [System.Xml.Serialization.XmlElementAttribute("TextPayload", typeof(TextPayload))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}
