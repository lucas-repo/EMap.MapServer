using Microsoft.EntityFrameworkCore;
using IMap.MapServer.DotSpatial;
using IMap.MapServer.Ogc.Ows1_1;
using IMap.MapServer.Ogc.Services;
using IMap.MapServer.Ogc.Services.Gdals;
using IMap.MapServer.Ogc.Wmts1;
using IMap.MapServer.Services.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace IMap.MapServer.Creator
{
    class Program
    {
        static Program()
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
        }
        static void TestWmts()
        {
            XmlAttributeOverrides attrOverrides = new XmlAttributeOverrides();

            XmlAttributes ddsAttrs = new XmlAttributes();
            XmlElementAttribute layerAttr = new XmlElementAttribute
            {
                ElementName = "Layer",
                Type = typeof(LayerType)
            };
            ddsAttrs.XmlElements.Add(layerAttr);
            attrOverrides.Add(typeof(ContentsBaseType), "DatasetDescriptionSummary", ddsAttrs);

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
            string href = "http://123";
            #region ServiceProvider
            string poroviderName = "IMap.MapServer";
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
            Operation getCapabilitiesOperation =DotSpatial.CapabilitiesHelper.GetOperation(href, "GetCapabilities");
            Operation getTileOperation = DotSpatial.CapabilitiesHelper.GetOperation(href, "GetTile");
            Operation getFeatureinfoOperation = DotSpatial.CapabilitiesHelper.GetOperation(href, "GetFeatureinfo");
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
            IWmtsService wmts1Service = OgcServiceHelper.GetOgcService("WMTS", "1.0.0") as IWmtsService;
            wmts1Service.AddContent(capabilities, @"E:\LC\数据\双流\2014年遥感影像.img");

            List<object> objs = new List<object>();
            capabilities.Themes = new Themes[]
            {
                new Themes()
                {
                    Theme=new Theme[]
                    {
                        new Theme()
                        {
                            Identifier=new CodeType()
                            { Value="123" }
                        }
                    }
                }
            };
            objs.Add(capabilities);
            StringBuilder sb = new StringBuilder();
            using (TextWriter tw = new StringWriter(sb))
            {
                foreach (var item in objs)
                {
                    if (item == null)
                    {
                        continue;
                    }
                    var serializer = new XmlSerializer(item.GetType(), attrOverrides);
                    serializer.Serialize(tw, item);
                    var val = sb.ToString();
                    File.WriteAllText("123.xml", val);
                    sb.Clear();
                }
            }
        }
        static void Test()
        {
            double originX = 35383146.5;
            double originY = 3395525.5;
            double semimajor = 6378140.0;
            int level = 18;
            double x = 35405935.91222596; double y = 3366208.718846301;
            double falseEasting = 35500000.0;
            double falseNorthing = 0;
            var ret= WmtsHelper.GetTileIndexByProjection(originX, originY, semimajor, level, x, y, out int col, out int row, falseEasting,falseNorthing);
        }
        static void Main()
        {
            Test();
            string[] args = null;
            string str = Console.ReadLine();
            args = str.Split(" ");

            string service = null;
            string type = null;
            string version = null;
            List<string> datas = new List<string>();
            for (int i = 0; i < args.Length; i++)
            {
                string arg = args[i];
                switch (arg)
                {
                    case "-s":
                        if (!string.IsNullOrEmpty(args[++i]))
                        {
                            service = args[i];
                        }
                        break;
                    case "-t":
                        if (!string.IsNullOrEmpty(args[++i]))
                        {
                            type = args[i];
                        }
                        break;
                    case "-v":
                        if (!string.IsNullOrEmpty(args[++i]))
                        {
                            version = args[i];
                        }
                        break;
                    case "-d":
                        if (!string.IsNullOrEmpty(args[++i]))
                        {
                            datas.Add(args[i]);
                        }
                        break;
                }
            }
            //try
            //{

            ConfigContext configContext = GetConfigContext();
            ServiceHelper serviceHelper = new ServiceHelper(configContext);
            serviceHelper.CreateService(service, type, version, datas).Wait();
            Console.WriteLine("ok");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Error:{e.Message}");
            //}
            Console.Read();
        }
        private static Assembly GetAssembly(string fileName)
        {
            Assembly assembly = null;
            if (File.Exists(fileName))
            {
                assembly = Assembly.LoadFrom(fileName);
            }
            return assembly;
        }
        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            Assembly assembly = null;

            string privatePath = JsonSettings.DefaultSettings.GetValue<string>("privatePath");
            string[] directoryNames = privatePath.Split(';');
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string extension = Path.GetExtension(args.RequestingAssembly.CodeBase);
            string directory = null;
            string[] arry = args.Name.Split(',');
            string name = arry[0];
            string path = null;
            foreach (var directoryName in directoryNames)
            {
                directory = Path.Combine(baseDirectory, directoryName);
                path = Path.Combine(directory, $"{name}{extension}");
                assembly = GetAssembly(path);
                if (assembly != null)
                {
                    break;
                }
            }
            return assembly;
        }
        static ConfigContext GetConfigContext()
        {
            string connection = JsonSettings.DefaultSettings.GetConnectionString("ConfigContext");
            DbContextOptions<ConfigContext> dbContextOption = new DbContextOptions<ConfigContext>();
            DbContextOptionsBuilder<ConfigContext> dbContextOptionBuilder = new DbContextOptionsBuilder<ConfigContext>(dbContextOption);
            ConfigContext configContext = new ConfigContext(dbContextOptionBuilder.UseSqlite(connection).Options);
            return configContext;
        }
    }
}
