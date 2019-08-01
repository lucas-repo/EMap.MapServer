using EMap.MapServer.Ogc.Ows1_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

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
        public void RemoveContent(string identifier, Type type)
        {
            if (string.IsNullOrEmpty(identifier) || type == null)
            {
                return;
            }
            DatasetDescriptionSummaryBaseType[] srcContents = Contents?.DatasetDescriptionSummary;
            if (srcContents == null)
            {
                return;
            }
            DatasetDescriptionSummaryBaseType baseType = srcContents.FirstOrDefault(x => x.Identifier.Value == identifier && x.GetType() == type);
            if (baseType == null)
            {
                return;
            }
            if (baseType is LayerType content)
            {
                if (content.TileMatrixSetLink == null || content.TileMatrixSetLink.Length == 0)
                {
                    return;
                }
                //remove tileMatrixSet
                TileMatrixSetLink tileMatrixSetLink = content.TileMatrixSetLink[0];
                string tileMatrixSetName = tileMatrixSetLink.TileMatrixSet;
                TileMatrixSet tileMatrixSet = Contents.TileMatrixSet?.FirstOrDefault(x=>x.Identifier.Value == tileMatrixSetName);
                if (tileMatrixSet!= null)
                {
                    var layerTypes= srcContents.Where(x => x is LayerType layerType && x != baseType).Select(x=> x as LayerType) ;
                    bool isReferenced = false;
                    foreach (var item in layerTypes)
                    {
                        if (item.TileMatrixSetLink == null || item.TileMatrixSetLink.Length == 0)
                        {
                            continue;
                        }
                        if (item.TileMatrixSetLink[0].TileMatrixSet == tileMatrixSetName)
                        {
                            isReferenced = true;
                            break;
                        }
                    }
                    if (!isReferenced)
                    {
                        Contents.TileMatrixSet = Contents.TileMatrixSet.Remove(tileMatrixSet);
                    }
                }
            }
            DatasetDescriptionSummaryBaseType[] destContents = srcContents.Remove(baseType);
            Contents.DatasetDescriptionSummary = destContents;
        }
        #endregion
    }
}
