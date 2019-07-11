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

namespace EMap.MapServer.Services.Controllers
{
    public class LayersController : BaseController
    {
        public LayersController(IHostingEnvironment environment, ConfigContext configContext) : base(environment, configContext)
        {
        }

        // GET: Layers
        public async Task<IActionResult> Index()
        {
            var configContext = ConfigContext.Layers.Include(l => l.Service);
            return View(await configContext.ToListAsync());
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

            return View(layerRecord);
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
            var layerRecord = await ConfigContext.Layers.FindAsync(id);
            ConfigContext.Layers.Remove(layerRecord);
            await ConfigContext.SaveChangesAsync();
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

                    //Encoding encoding = Encoding.UTF8;
                    //ZipArchive zipAchever = ZipFile.Open(tempZipPath, ZipArchiveMode.Read, encoding);
                    //if (zipAchever.Entries.Count > 0)
                    //{
                    //    bool hasChinese = ContainChinese(zipAchever.Entries[0].FullName);
                    //    if (hasChinese)
                    //    {
                    //        encoding = Encoding.GetEncoding("GBK");
                    //    }
                    //}

                    //ZipFile.ExtractToDirectory(tempZipPath, tempZipDirectory, encoding, true);//todo根据压缩包编码确定解压编码
                    List<string> supportFileNames = GetSupportFileNames(tempZipDirectory);
                    string destDirectory = ServicePathManager.GetServiceDirectory(serviceRecord.Type, serviceRecord.Version, serviceRecord.Name);
                    if (!Directory.Exists(destDirectory))
                    {
                        Directory.CreateDirectory(destDirectory);
                    }
                    foreach (var supportFileName in supportFileNames)
                    {
                        ret = OgcServiceHelper.AddLayerToCapabilities(serviceRecord.Type, serviceRecord.Version, capabilitiesPath, supportFileName);
                        if (ret)
                        {
                            string destName = Path.GetFileNameWithoutExtension(supportFileName);
                            string destNameWithExtension = Path.GetFileName(supportFileName);
                            string destLayerPath = Path.Combine(destDirectory, destNameWithExtension);
                            OgcServiceHelper.MoveFile(supportFileName, destLayerPath);
                            LayerRecord layerRecord = new LayerRecord()
                            {
                                Name = destName,
                                Path = destLayerPath,
                                Service = serviceRecord
                            };
                            ConfigContext.Layers.Add(layerRecord);
                        }
                    }
                    Directory.Delete(tempZipDirectory, true);
                    System.IO.File.Delete(tempZipPath);
                }
            }
            int result = await ConfigContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
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
