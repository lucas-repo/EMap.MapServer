using EMap.MapServer.Ogc.Ows1_1;
using System.Collections.Generic;
using System.Linq;

namespace EMap.MapServer.Ogc.Wmts1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wmts/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wmts/1.0", IsNullable=false)]
    public partial class TileMatrixSet : DescriptionType {
        
        private CodeType identifierField;
        
        private BoundingBoxType boundingBoxField;
        
        private string supportedCRSField;
        
        private string wellKnownScaleSetField;
        
        private TileMatrix[] tileMatrixField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/ows/1.1")]
        public CodeType Identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/ows/1.1")]
        public BoundingBoxType BoundingBox {
            get {
                return this.boundingBoxField;
            }
            set {
                this.boundingBoxField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/ows/1.1", DataType="anyURI")]
        public string SupportedCRS {
            get {
                return this.supportedCRSField;
            }
            set {
                this.supportedCRSField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string WellKnownScaleSet {
            get {
                return this.wellKnownScaleSetField;
            }
            set {
                this.wellKnownScaleSetField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("TileMatrix")]
        public TileMatrix[] TileMatrix {
            get {
                return this.tileMatrixField;
            }
            set {
                this.tileMatrixField = value;
            }
        }
        #region Functions
        public IEnumerable<TileMatrix> GetTileMatrices(string identifer)
        {
            IEnumerable<TileMatrix> tileMatrices = TileMatrix?.Where(x => x.Identifier.Value == identifer);
            return tileMatrices;
        }
        public TileMatrix GetTileMatrix(string identifer)
        {
            TileMatrix tileMatrix = GetTileMatrices(identifer).FirstOrDefault();
            return tileMatrix;
        }
        #endregion
    }
}
