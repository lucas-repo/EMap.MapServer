using DotSpatial.Data;
using DotSpatial.Projections;
using DotSpatial.Symbology;
using SharpMapServer.Ogc.Ows1_1;
using SharpMapServer.Ogc.Wmts1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpMapServer.DotSpatial
{
    public static class CapabilitiesHelper
    {
        public static ServiceIdentification GetServiceIdentification(string[] titles, string[] abstracts, string[] keyWords, string service, string[] serviceTypeVersions, string fees, string[] accessConstraints, string[] profiles)
        {
            LanguageStringType[] titleTypes = null;
            if (titles != null)
            {
                titleTypes = new LanguageStringType[titles.Length];
                for (int i = 0; i < titles.Length; i++)
                {
                    titleTypes[i] = new LanguageStringType()
                    {
                        Value = titles[i]
                    };
                }
            }
            LanguageStringType[] abstractTypes = null;
            if (abstracts != null)
            {
                abstractTypes = new LanguageStringType[abstracts.Length];
                for (int i = 0; i < abstracts.Length; i++)
                {
                    titleTypes[i] = new LanguageStringType()
                    {
                        Value = abstracts[i]
                    };
                }
            }
            KeywordsType[] keywordsTypes = null;
            if (keyWords != null)
            {
                keywordsTypes = new KeywordsType[keyWords.Length];
                for (int i = 0; i < keyWords.Length; i++)
                {
                    LanguageStringType[] keyword = new LanguageStringType[]
                    {
                        new LanguageStringType()
                        {
                            Value=keyWords[i]
                        }
                    };
                    keywordsTypes[i] = new KeywordsType()
                    {
                        Keyword = keyword
                    };
                }
            }
            CodeType serviceType = null;
            if (!string.IsNullOrWhiteSpace(service))
            {
                serviceType = new CodeType()
                {
                    Value = service
                };
            }
            ServiceIdentification serviceIdentification = new ServiceIdentification()
            {
                Title = titleTypes,
                Abstract = abstractTypes,
                Keywords = keywordsTypes,
                ServiceType = serviceType,
                ServiceTypeVersion = serviceTypeVersions,
                Fees = fees,
                AccessConstraints = accessConstraints,
                Profile = profiles
            };
            return serviceIdentification;
        }
        public static ServiceProvider GetServiceProvider(string poroviderName, string providerSite, ResponsiblePartySubsetType serviceContact)
        {
            OnlineResourceType providerSiteType = new OnlineResourceType()
            {
                href = providerSite
            };
            ServiceProvider serviceProvider = new ServiceProvider()
            {
                ProviderName = poroviderName,
                ProviderSite = providerSiteType,
                ServiceContact = serviceContact
            };
            return serviceProvider;
        }
        private static RequestMethodType GetGetRequestMethodType(string href, string value)
        {
            object[] allowedValues = new Ogc.Ows1_1.ValueType[]
            {
                new Ogc.Ows1_1.ValueType()
                {
                     Value=value
                }
            };
            DomainType constraint = new DomainType()
            {
                name = "GetEncoding",
                AllowedValues = allowedValues
            };
            DomainType[] constraints = new DomainType[]
            {
                constraint
            };
            RequestMethodType restRequest = new RequestMethodType()
            {
                href = href,
                Constraint = constraints
            };
            return restRequest;
        }
        public static RequestMethodType GetRestRequestMethodType(string href)
        {
            RequestMethodType restRequest = GetGetRequestMethodType(href, "REST");
            return restRequest;
        }

        public static RequestMethodType GetKvpRequestMethodType(string href)
        {
            RequestMethodType restRequest = GetGetRequestMethodType(href, "KVP");
            return restRequest;
        }
        public static Operation GetOperation(string href, string operationName)
        {
            RequestMethodType restRequest = GetRestRequestMethodType(href);
            RequestMethodType kvpRequest = GetKvpRequestMethodType($"{href}?");
            RequestMethodType[] requestMethodTypes = new RequestMethodType[]
            {
                restRequest,kvpRequest
            };
            ItemsChoiceType1[] itemsChoiceType1s = new ItemsChoiceType1[]
            {
                 ItemsChoiceType1.Get, ItemsChoiceType1.Get
            };
            HTTP http = new HTTP()
            {
                Items = requestMethodTypes,
                ItemsElementName = itemsChoiceType1s
            };
            DCP DCP = new DCP()
            {
                Item = http
            };
            DCP[] DCPs = new DCP[]
            {
                DCP
            };
            Operation operation = new Operation()
            {
                name = operationName,
                DCP = DCPs
            };
            return operation;
        }
        public static LayerType GetLayerType(IDataSet dataSet)
        {
            LayerType layerType = null;
            if (dataSet == null)
            {
                return layerType;
            }
            LanguageStringType[] titles = new LanguageStringType[]
            {
                new LanguageStringType()
                {
                    Value = dataSet.Name
                }
            };
            LanguageStringType[] abstracts = new LanguageStringType[]
            {
                new LanguageStringType()
                {
                    Value = dataSet.Name
                }
            };
            var extent = dataSet.Extent;
            BoundingBoxType[] boundingBoxs = null;
            WGS84BoundingBoxType[] WGS84BoundingBoxes = null;
            ProjectionInfo wgs84PrjInfo = KnownCoordinateSystems.Geographic.World.WGS1984;
            if (dataSet.Projection.Equals(wgs84PrjInfo))//wgs84
            {
                WGS84BoundingBoxes = new WGS84BoundingBoxType[]
                {
                    new WGS84BoundingBoxType()
                    {
                         LowerCorner=$"{extent.MinX} {extent.MinY}",
                         UpperCorner=$"{extent.MaxX} {extent.MaxY}"
                    }
                };
            }
            else
            {
                boundingBoxs = new BoundingBoxType[]
                {
                    new BoundingBoxType()
                    {
                         LowerCorner=$"{extent.MinX} {extent.MinY}",
                         UpperCorner=$"{extent.MaxX} {extent.MaxY}"
                    }
                };
                using (IDataSet tmpDs = DataManager.DefaultDataManager.OpenFile(dataSet.Filename))
                {
                    tmpDs.Reproject(wgs84PrjInfo);
                    WGS84BoundingBoxes = new WGS84BoundingBoxType[]
                    {
                        new WGS84BoundingBoxType()
                        {
                             LowerCorner=$"{tmpDs.Extent.MinX} {tmpDs.Extent.MinY}",
                             UpperCorner=$"{tmpDs.Extent.MaxX} {tmpDs.Extent.MaxY}"
                        }
                    };
                }
            }
            CodeType identifier = new CodeType()
            {
                Value = dataSet.Name
            };
            Style style = new Style()
            {
                isDefault = true,
                Identifier = new CodeType()
                {
                    Value = "default"
                }
            };
            Style[] styles = new Style[]
            {
                style
            };
            string[] formats = new string[]
            {
                "image/png","image/jpg"
            };
            TileMatrixSetLink[] tileMatrixSetLinks = new TileMatrixSetLink[]
            {
                new TileMatrixSetLink()
                {
                     TileMatrixSet=dataSet.Projection.Name
                }
            };
            layerType = new LayerType()
            {
                Title = titles,
                Abstract = abstracts,
                BoundingBox = boundingBoxs,
                WGS84BoundingBox = WGS84BoundingBoxes,
                Identifier= identifier,
                Style = styles,
                Format = formats,
                TileMatrixSetLink = tileMatrixSetLinks
            };
            return layerType;
        }
        public static TileMatrix[] GetTileMatrices(IDataSet dataSet, int minLevel, int maxLevel)
        {
            if (dataSet == null)
            {
                return null;
            }
            if (minLevel < 0)
            {
                return null;
            }
            double semimajor = dataSet.Projection.GeographicInfo.Datum.Spheroid.EquatorialRadius;
            double top = dataSet.Extent.MaxY;
            double left = dataSet.Extent.MinX;
            int tileWidth = 256, tileHeight = 256;
            double scaleDenominator = 0;
            int matrixWidth = 0, matrixHeight = 0;
            double tileDWidth = 0, tileDHeight = 0;
            List<TileMatrix> tileMatrices = new List<TileMatrix>();
            {
                for (int i = minLevel; i <= maxLevel; i++)
                {
                    scaleDenominator = Math.PI * semimajor / (128 * Math.Pow(2, i));
                    tileDWidth = Math.PI * semimajor / Math.Pow(2, i - 1);
                    tileDHeight = tileDWidth;
                    matrixWidth = (int)Math.Ceiling(dataSet.Extent.Width / tileDWidth);
                    matrixHeight = (int)Math.Ceiling(dataSet.Extent.Height / tileDHeight);
                    TileMatrix tileMatrix = new TileMatrix()
                    {
                        Identifier = new CodeType()
                        {
                            Value = i.ToString()
                        },
                        ScaleDenominator = scaleDenominator,
                        TopLeftCorner = $"{left} {top}",
                        TileWidth = tileWidth.ToString(),
                        TileHeight = tileHeight.ToString(),
                        MatrixWidth = matrixWidth.ToString(),
                        MatrixHeight = matrixHeight.ToString()
                    };
                    tileMatrices.Add(tileMatrix);
                }
            }
            return tileMatrices.ToArray();
        }
        public static Capabilities  CreateCapabilities(string href)
        {
            #region ServiceIdentification
            LanguageStringType[] titles = new LanguageStringType[]
           {
                new LanguageStringType()
                {
                    Value="Web Map Tile Service"
                }
           };
            LanguageStringType[] abstracts = new LanguageStringType[]
            {
                new LanguageStringType()
                {
                    Value="Service that contrains the map access interface to some TileMatrixSets"
                }
            };
            LanguageStringType[] keyword1 = new LanguageStringType[]
            {
                new LanguageStringType()
                {
                    Value="tile"
                }
            };
            KeywordsType keywordsType1 = new KeywordsType()
            {
                Keyword = keyword1
            };
            LanguageStringType[] keyword2 = new LanguageStringType[]
            {
                new LanguageStringType()
                {
                    Value="map"
                }
            };
            KeywordsType keywordsType2 = new KeywordsType()
            {
                Keyword = keyword2
            };
            KeywordsType[] keywords = new KeywordsType[]
            {
                keywordsType1,keywordsType2
            };
            CodeType serviceType = new CodeType()
            {
                Value = "OGC WMTS"
            };
            string[] serviceTypeVersion = new string[]
            {
                "1.0.0"
            };
            string fees = "none";
            string[] accessConstraints = new string[]
            {
                "none"
            };
            ServiceIdentification serviceIdentification = new ServiceIdentification()
            {
                Title = titles,
                Abstract = abstracts,
                Keywords = keywords,
                ServiceType = serviceType,
                ServiceTypeVersion = serviceTypeVersion,
                Fees = fees,
                AccessConstraints = accessConstraints
            };
            #endregion

            #region ServiceProvider
            string poroviderName = "SharpMapServer";
            OnlineResourceType providerSiteType = new OnlineResourceType()
            {
                href = href
            };
            string[] voices = new string[] { "0000-00000000" };
            string[] facsimiles = new string[] { "0001-00000001" };
            TelephoneType phone = new TelephoneType()
            {
                Voice = voices,
                Facsimile = facsimiles
            };
            string[] deliveryPoints = new string[] { "jinjiang" };
            string city = "chengdu";
            string administrativeArea = "sichuan";
            string country = "china";
            string[] electronicMailAddress = new string[] { "123456@test.com" };
            string postalCode = "123456";
            AddressType address = new AddressType()
            {
                DeliveryPoint = deliveryPoints,
                City = city,
                AdministrativeArea = administrativeArea,
                Country = country,
                ElectronicMailAddress = electronicMailAddress,
                PostalCode = postalCode
            };
            ContactType contactInfo = new ContactType()
            {
                Phone = phone,
                Address = address
            };
            string individualName = "lc";
            string positionName = "Senior Software Engineer";
            ResponsiblePartySubsetType serviceContact = new ResponsiblePartySubsetType()
            {
                IndividualName = individualName,
                PositionName = positionName,
                ContactInfo = contactInfo
            };
            ServiceProvider serviceProvider = new ServiceProvider()
            {
                ProviderName = poroviderName,
                ProviderSite = providerSiteType,
                ServiceContact = serviceContact
            };
            #endregion

            #region OperationsMetadata
            Operation getCapabilitiesOperation = CapabilitiesHelper.GetOperation(href, "GetCapabilities");
            Operation getTileOperation = CapabilitiesHelper.GetOperation(href, "GetTile");
            Operation getFeatureinfoOperation = CapabilitiesHelper.GetOperation(href, "GetFeatureinfo");
            Operation[] operations = new Operation[]
            {
                getCapabilitiesOperation,
                getTileOperation,
                getFeatureinfoOperation
            };
            OperationsMetadata operationsMetadata = new OperationsMetadata()
            {
                Operation = operations
            };
            #endregion
            
            Capabilities capabilities = new Capabilities()
            {
                ServiceIdentification = serviceIdentification,
                ServiceProvider = serviceProvider,
                OperationsMetadata = operationsMetadata
            };
            return capabilities;
        }
        public static LayerType AddContent(Capabilities capabilities,IDataSet dataSet)
        {
            LayerType layerType = null;
            if (capabilities == null || dataSet == null)
            {
                return layerType;
            }
            if (capabilities.Contents == null)
            {
                capabilities.Contents = new ContentsType();
            }
            DatasetDescriptionSummaryBaseType[] datasets = capabilities.Contents.DatasetDescriptionSummary;
            if (datasets?.Any(x=>x.Identifier.Value==dataSet.Name)==true)
            {
                return layerType; 
            }
            int layerCount = datasets == null ? 1 : datasets.Length + 1;
            capabilities.Contents.DatasetDescriptionSummary = new DatasetDescriptionSummaryBaseType[layerCount];
            datasets?.CopyTo(capabilities.Contents.DatasetDescriptionSummary, 0);
            datasets = capabilities.Contents.DatasetDescriptionSummary;
             layerType = GetLayerType(dataSet);
            datasets[datasets.Length - 1] = layerType;

            TileMatrixSet[] tileMatrixSets = capabilities.Contents.TileMatrixSet;
            if (tileMatrixSets?.Any(x => x.Identifier.Value == dataSet.Projection.Name) != true)
            {
                int tileMatrixSetCount = tileMatrixSets == null ? 1 : tileMatrixSets.Length + 1;
                capabilities.Contents.TileMatrixSet = new TileMatrixSet[tileMatrixSetCount];
                tileMatrixSets?.CopyTo(capabilities.Contents.TileMatrixSet, 0);
                tileMatrixSets = capabilities.Contents.TileMatrixSet;
                int minLevel = 0;
                int maxLevel = 20;

                TileMatrix[] tileMatrices = GetTileMatrices(dataSet, minLevel, maxLevel);
                TileMatrixSet tileMatrixSet = new TileMatrixSet()
                {
                    Identifier = new CodeType()
                    {
                        Value = dataSet.Projection.Name
                    },
                    SupportedCRS = "urn:ogc:def:crs:OGC:1.3:CRS84",//TODO 待修改
                    TileMatrix = tileMatrices
                };
                tileMatrixSets[tileMatrixSets.Length - 1] = tileMatrixSet;
            }
            return layerType;
        }
    }
}
