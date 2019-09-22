using EMap.OgcStandards.Services.Gdals;
using EMap.MapServer.Services.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using OSGeo.GDAL;
using OSGeo.OGR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;
using EMap.MapServer.OpenLayers;
using EMap.OgcStandards.Wmts1;
using EMap.MapServer.Services.ViewModels;
using EMap.MapServer.OpenLayers.proj;

namespace EMap.MapServer.Services.Controllers
{
    //[Route("[controller]")]
    public class LayersController : BaseController
    {
        public LayersController(IHostingEnvironment environment, ConfigContext configContext) : base(environment, configContext)
        {
        }

        // GET: Layers
        public async Task<IActionResult> Index()
        {
            return View(await Index(null));
        }
        [Route("{serviceId}")]
        public async Task<IActionResult> Index(int? serviceId)
        {
            var layerRecords = (from layerItem in ConfigContext.Layers
                                join serviceItem in ConfigContext.Services on layerItem.ServiceId equals serviceItem.Id
                                select layerItem).Include(x => x.Service);
            List<LayerRecord> layers;
            if (serviceId != null)
            {
                layers = await layerRecords.Where(x => x.ServiceId == serviceId).ToListAsync();
            }
            else
            {
                layers = await layerRecords.ToListAsync();
            }
            return View(layers);
        }
        // GET: Layers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var layerRecord = await ConfigContext.Layers
                .Include(l => l.Service)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (layerRecord == null)
            {
                return NotFound();
            }

            return View(layerRecord);
        }
        // GET: Layers/Preview/5
        [Route("[controller]/Preview/{id}")]
        public async Task<IActionResult> Preview(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var layerRecord = await ConfigContext.Layers
                .Include(l => l.Service)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (layerRecord == null)
            {
                return NotFound();
            }
            PreviewModel previewModel = new PreviewModel()
            {
                 LayerId= id.Value
            };
            return View(previewModel);
        }
        [Route("[controller]/Preview/{id}/{width}/{height}")]
        public async Task<IActionResult> Preview(int? id, int width, int height)
        {
            if (id == null)
            {
                return NotFound();
            }

            var layerRecord = await ConfigContext.Layers
                .Include(l => l.Service)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (layerRecord == null)
            {
                return NotFound();
            }
            ServiceRecord serviceRecord = layerRecord.Service;
            View view = new View();
            OpenLayers.layer.BaseLayer baseLayer = null;
            switch (serviceRecord.Type)
            {
                case OgcServiceType.Wmts:
                    GdalWmtsService gdalWmtsService = new GdalWmtsService();

                    string capabilitiesPath = ServicePathManager.GetCapabilitiesPath(serviceRecord.Type, serviceRecord.Version, serviceRecord.Name);
                    Capabilities capabilities = null;
                    using (StreamReader sr = new StreamReader(capabilitiesPath))
                    {
                        capabilities = gdalWmtsService.XmlDeSerialize(sr);
                    }
                    LayerType layerType = capabilities.GetLayerType(layerRecord.Name);
                    string format= layerType.Format.FirstOrDefault();
                    string destTileMatrixSetName = layerType.TileMatrixSetLink.FirstOrDefault()?.TileMatrixSet;
                    TileMatrixSet tileMatrixSet = capabilities.GetTileMatrixSet(destTileMatrixSetName);
                    double[] origin = tileMatrixSet.TileMatrix.FirstOrDefault()?.TopLeftCorner?.ToDoubleValues();
                    string[] matrixIds = tileMatrixSet.TileMatrix.Select(x => x.Identifier.Value).ToArray();
                    double[] resolutions = tileMatrixSet.GetResolutions(matrixIds).ToArray();

                    var bound = layerType.BoundingBox.FirstOrDefault();
                    double[] lowerCorner = bound.LowerCorner.ToDoubleValues();
                    double[] upperCorner = bound.UpperCorner.ToDoubleValues();
                    double xmin = lowerCorner[0];
                    double ymin = lowerCorner[1];
                    double xmax = upperCorner[0];
                    double ymax = upperCorner[1];
                    double[] extent = new double[] { xmin, ymin, xmax, ymax };
                    double centerX = (xmin + xmax) / 2;
                    double centerY = (ymin + ymax) / 2;
                    view.center = new double[] { centerX, centerY };
                    view.extent = extent;
                    view.resolution = TileMatrixSet.GetSuitableResolution(resolutions.ToList(), xmin, ymin, xmax, ymax, width, height);
                    view.minResolution = resolutions[resolutions.Length - 1];
                    view.maxResolution = resolutions[0];
                    if (!string.IsNullOrEmpty(tileMatrixSet.SupportedCRS))
                    {
                        string[] array = tileMatrixSet.SupportedCRS.Split("EPSG");
                        if (array.Length > 0)
                        {
                            string epsg = array[array.Length - 1].Replace(":", "");
                            view.projection = $"EPSG:{epsg}";
                        }
                    }
                    WmtsTileGrid tileGrid = new WmtsTileGrid()
                    {
                        origin = origin,
                        matrixIds = matrixIds,
                        resolutions = resolutions, 
                        extent = extent
                    };
                    OpenLayers.source.Wmts source = new OpenLayers.source.Wmts()
                    {
                        url = capabilities.GetHref(),
                        layer = layerRecord.Name,
                        tileGrid = tileGrid,
                        matrixSet = destTileMatrixSetName,
                        format= format
                    };
                    baseLayer = new OpenLayers.layer.TileLayer()
                    {
                        source = source
                    };
                    break;
                default:
                    return NotFound();
            }
            Map map = new Map()
            {
                layers = new OpenLayers.layer.BaseLayer[] { baseLayer },
                view =view
            };
            return new JsonResult(map);
            //PreviewModel previewModel = new PreviewModel()
            //{
            //    Layers = new OpenLayers.layer.BaseLayer[] { baseLayer },
            //    View = view
            //};
            //return View(previewModel);
        }
        // GET: Layers/Create
        public IActionResult Create()
        {
            ViewData["ServiceId"] = new SelectList(ConfigContext.Services, "Id", "Name");
            return View();
        }

        // POST: Layers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Path,ServiceId,Name,Id")] LayerRecord layerRecord)
        {
            if (ModelState.IsValid)
            {
                ConfigContext.Add(layerRecord);
                await ConfigContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ServiceId"] = new SelectList(ConfigContext.Services, "Id", "Id", layerRecord.ServiceId);
            return View(layerRecord);
        }

        // GET: Layers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var layerRecord = await ConfigContext.Layers.FindAsync(id);
            if (layerRecord == null)
            {
                return NotFound();
            }
            ViewData["ServiceId"] = new SelectList(ConfigContext.Services, "Id", "Id", layerRecord.ServiceId);
            return View(layerRecord);
        }

        // POST: Layers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Path,ServiceId,Name,Id")] LayerRecord layerRecord)
        {
            if (id != layerRecord.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    ConfigContext.Update(layerRecord);
                    await ConfigContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LayerRecordExists(layerRecord.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ServiceId"] = new SelectList(ConfigContext.Services, "Id", "Id", layerRecord.ServiceId);
            return View(layerRecord);
        }

        // GET: Layers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var layerRecord = await ConfigContext.Layers
                .Include(l => l.Service)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (layerRecord == null)
            {
                return NotFound();
            }

            return View(layerRecord);
        }

        // POST: Layers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            LayerRecord layerRecord = await ConfigContext.Layers.FindAsync(id);
            if (layerRecord == null)
            {
                return NotFound("未找到图层");
            }
            ServiceRecord serviceRecord = await ConfigContext.Services.FindAsync(layerRecord.ServiceId);
            if (serviceRecord == null)
            {
                return StatusCode(500);
            }

            string capabilitiesPath = ServicePathManager.GetCapabilitiesPath(serviceRecord.Type, serviceRecord.Version, serviceRecord.Name);
            await OgcServiceHelper.RemoveLayerFromCapabilities(serviceRecord, capabilitiesPath, layerRecord);
            return RedirectToAction(nameof(Index));
        }
        public string ValidateLayerName(int serviceId, string layerName)
        {
            string error = null;
            string extention = Path.GetExtension(layerName);
            switch (extention)
            {
                //case ".shp":
                //case ".img":
                //case ".tif":
                //case ".jpg":
                //    ServiceRecord serviceRecord = await ConfigContext.Services.FindAsync(serviceId);
                //    if (serviceRecord == null)
                //    {
                //        error = "未找到服务";
                //    }
                //    else
                //    {
                //        string destName = Path.GetFileNameWithoutExtension(layerName);
                //        bool isExist = await ConfigContext.Layers.AnyAsync(x => x.ServiceId == serviceId && x.Name == destName);
                //        if (isExist)
                //        {
                //            error = "已存在同名的图层";
                //        }
                //    }
                //    break;
                case ".zip"://只接受.zip压缩文件
                    break;
                default:
                    error = "不支持的数据格式";
                    break;
            }
            return error;
        }
        static bool ContainChinese(string input)
        {
            string pattern = "[\u4e00-\u9fbb]";
            return Regex.IsMatch(input, pattern);
        }
        [HttpPost]
        public async Task<IActionResult> Upload([FromForm]IFormCollection formData)
        {
            string error = null;
            var files = formData.Files;
            long size = files.Sum(f => f.Length);
            if (!Request.Form.ContainsKey("ServiceId"))
            {
                error = "参数未包含ServiceId";
                return BadRequest(error);
            }
            StringValues values = Request.Form["ServiceId"];
            if (values.Count == 0)
            {
                error = "参数未包含ServiceId";
                return BadRequest(error);
            }
            bool ret = int.TryParse(values[0], out int serviceId);
            if (!ret)
            {
                error = "ServiceId错误";
                return BadRequest(error);
            }
            ServiceRecord serviceRecord = await ConfigContext.Services.FindAsync(serviceId);
            if (serviceRecord == null)
            {
                error = "未找到指定的服务";
                return BadRequest(error);
            }
            string capabilitiesPath = ServicePathManager.GetCapabilitiesPath(serviceRecord.Type, serviceRecord.Version, serviceRecord.Name);
            if (!System.IO.File.Exists(capabilitiesPath))
            {
                error = "服务器内部错误：未找到元数据";
                return BadRequest(error);
            }
            string tempDirectory = Path.GetTempPath();
            if (!Directory.Exists(tempDirectory))
            {
                Directory.CreateDirectory(tempDirectory);
            }
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    string zipNameWithExtension = Path.GetFileName(formFile.FileName);
                    string zipName = Path.GetFileNameWithoutExtension(formFile.FileName);
                    string tempZipPath = Path.Combine(tempDirectory, zipNameWithExtension);//zip临时路径
                    using (var stream = System.IO.File.Create(tempZipPath))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                    string tempZipDirectory = Path.Combine(tempDirectory, zipName);//zip临时解压目录
                    ZipUtil.UnZip(tempZipPath, tempZipDirectory);
                    List<string> srcFileNames = GetSupportFileNames(tempZipDirectory);
                    string destDirectory = ServicePathManager.GetServiceDirectory(serviceRecord.Type, serviceRecord.Version, serviceRecord.Name);
                    if (!Directory.Exists(destDirectory))
                    {
                        Directory.CreateDirectory(destDirectory);
                    }
                    foreach (var srcFileName in srcFileNames)
                    {
                        string destNameWithExtension = Path.GetFileName(srcFileName);
                        string destFileName = Path.Combine(destDirectory, destNameWithExtension);
                        OgcServiceHelper.MoveDataSet(srcFileName, destFileName);

                        ret = OgcServiceHelper.AddLayerToCapabilities(serviceRecord, capabilitiesPath, destFileName);
                        if (!ret)
                        {
                            OgcServiceHelper.DeleteDataSet(destFileName);
                        }
                    }
                    Directory.Delete(tempZipDirectory, true);
                    System.IO.File.Delete(tempZipPath);
                }
            }
            int result = await ConfigContext.SaveChangesAsync();
            return Ok();
        }
        public static List<string> GetSupportRasterExtensions()
        {
            int driverCount = Gdal.GetDriverCount();
            List<string> extensions = new List<string>();
            for (int i = 0; i < driverCount; i++)
            {
                using (OSGeo.GDAL.Driver driver = Gdal.GetDriver(i))
                {
                    string[] metadata = driver.GetMetadata("");
                    var str = metadata.FirstOrDefault(x => x.Contains("DMD_EXTENSION="));
                    if (str != null)
                    {
                        var extension = str.Split('=')[1];
                        bool isRaster = metadata.Any(x => x == "DCAP_RASTER=YES");
                        extension = $".{extension}";
                        if (!extensions.Contains(extension))
                        {
                            extensions.Add(extension);
                        }
                    }
                }
            }
            return extensions;
        }
        private static List<string> GetSupportVectorExtensions()
        {
            int driverCount = Ogr.GetDriverCount();
            List<string> extensions = new List<string>();
            for (int i = 0; i < driverCount; i++)
            {
                using (OSGeo.OGR.Driver driver = Ogr.GetDriver(i))
                {
                }
            }
            return extensions;
        }
        public static List<string> GetSupportFileNames(string directory)
        {
            List<string> supportFileNames = new List<string>();
            string[] files = Directory.GetFiles(directory);
            List<string> rasterExtensions = GetSupportRasterExtensions();
            List<string> vectorExtensions = new List<string>() { ".shp" };
            foreach (var file in files)
            {
                string extension = Path.GetExtension(file);
                try
                {
                    if (rasterExtensions.Contains(extension))
                    {
                        using (Dataset dataset = Gdal.Open(file, Access.GA_ReadOnly))
                        {
                            if (dataset == null)
                            {
                                continue;
                            }
                        }
                    }
                    else if (vectorExtensions.Contains(extension))
                    {
                        using (DataSource dataSource = Ogr.Open(file, 0))
                        {
                            if (dataSource == null)
                            {
                                continue;
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                    supportFileNames.Add(file);
                }
                catch (Exception e)
                { }
            }
            return supportFileNames;
        }
        private bool LayerRecordExists(int id)
        {
            return ConfigContext.Layers.Any(e => e.Id == id);
        }
    }
}
