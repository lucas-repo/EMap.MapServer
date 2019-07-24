using EMap.MapServer.Ogc.Ows1_1;
using System.Xml.Serialization;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace EMap.MapServer.Ogc.Wmts1
{




    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wmts/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wmts/1.0", IsNullable = false)]
    public partial class Capabilities : CapabilitiesBaseType
    {

        private ContentsType contentsField;

        private Themes[] themesField;

        private OnlineResourceType[] wSDLField;

        private OnlineResourceType[] serviceMetadataURLField;


        public ContentsType Contents
        {
            get
            {
                return this.contentsField;
            }
            set
            {
                this.contentsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("Themes", typeof(Themes))]
        public Themes[] Themes
        {
            get
            {
                return this.themesField;
            }
            set
            {
                this.themesField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("WSDL")]
        public OnlineResourceType[] WSDL
        {
            get
            {
                return this.wSDLField;
            }
            set
            {
                this.wSDLField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("ServiceMetadataURL")]
        public OnlineResourceType[] ServiceMetadataURL
        {
            get
            {
                return this.serviceMetadataURLField;
            }
            set
            {
                this.serviceMetadataURLField = value;
            }
        }
        [XmlAttribute(Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string schemaLocation { get; set; } = "http://www.opengis.net/wmts/1.0 http://schemas.opengis.net/wmts/1.0/wmtsGetCapabilities_response.xsd";

        #region Functions
        public LayerType GetLayerType(string layerName)
        {
            LayerType layerType = GetLayerTypes(layerName).FirstOrDefault();
            return layerType;
        }
        public IEnumerable<LayerType> GetLayerTypes(string layerName)
        {
            IEnumerable<LayerType> layerTypes = Contents?.DatasetDescriptionSummary?.Where(x => x is LayerType layerType && layerType.Identifier.Value == layerName).Select(x => x as LayerType);
            return layerTypes;
        }
        public TileMatrixSet GetTileMatrixSet(string tileMatrixSetName)
        {
            TileMatrixSet tileMatrixSet = GetTileMatrixSets(tileMatrixSetName).FirstOrDefault();
            return tileMatrixSet;
        }
        public IEnumerable<TileMatrixSet> GetTileMatrixSets(string tileMatrixSetName)
        {
            IEnumerable<TileMatrixSet> tileMatrixSets = Contents.TileMatrixSet?.Where(x => x.Identifier.Value == tileMatrixSetName);
            return tileMatrixSets;
        }
        #endregion
    }
}
