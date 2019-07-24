using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EMap.MapServer.Services.Models;
using EMap.MapServer.Ogc.Services;
using Microsoft.AspNetCore.Hosting;
using EMap.MapServer.Ogc.Wmts1;
using System.IO;
using System.Text.Encodings.Web;

namespace EMap.MapServer.Services.Controllers
{
    public class ServicesController : BaseController
    {
        public ServicesController(IHostingEnvironment environment, ConfigContext configContext) : base(environment, configContext)
        {
        }

        // GET: Services
        public async Task<IActionResult> Index()
        {
            return View(await ConfigContext.Services.ToListAsync());
        }
        public async Task<IActionResult> Layers(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ServiceRecord serviceRecord = await ConfigContext.Services.FindAsync(id);
            if (serviceRecord == null)
            {
                return NotFound();
            }
            else
            {
                return RedirectToAction("Index", "Layers", new { serviceId = id });
            }
        }
        // GET: Services/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ServiceRecord serviceRecord = await ConfigContext.Services.FindAsync(id);
            if (serviceRecord == null)
            {
                return NotFound();
            }
            else
            {
                string href = GetHref();
                string routTemplate = OgcServiceHelper.GetRoutTemplate<WmtsController>("GetCapabilities");
                routTemplate = routTemplate.Replace("{serviceName}", serviceRecord.Name);
                routTemplate = routTemplate.Replace("{version}", serviceRecord.Version);
                routTemplate = string.Join("/", routTemplate.Split("/").Select(s => System.Net.WebUtility.UrlEncode(s)));
                string url = $"{href}/{routTemplate}";
                return Redirect(url);
            }
        }

        // GET: Services/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: Services/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Type,Version,Path,Name,Id")] ServiceRecord serviceRecord)
        {
            if (ModelState.IsValid)
            {
                bool ret = await OgcServiceHelper.CreateCapabilities(serviceRecord.Type, serviceRecord.Version, serviceRecord.Name);
                if (ret)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(serviceRecord);
        }

        // GET: Services/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceRecord = await ConfigContext.Services.FindAsync(id);
            if (serviceRecord == null)
            {
                return NotFound();
            }
            return View(serviceRecord);
        }

        // POST: Services/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Type,Version,Path,Name,Id")] ServiceRecord serviceRecord)
        {
            if (id != serviceRecord.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    ConfigContext.Update(serviceRecord);
                    await ConfigContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceRecordExists(serviceRecord.Id))
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
            return View(serviceRecord);
        }

        // GET: Services/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceRecord = await ConfigContext.Services
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serviceRecord == null)
            {
                return NotFound();
            }

            return View(serviceRecord);
        }

        // POST: Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var serviceRecord = await ConfigContext.Services.FindAsync(id);
            if (serviceRecord == null)
            {
                return BadRequest("未找到要删除的服务");
            }
            string capabilitiesDirectory = ServicePathManager.GetServiceDirectory(serviceRecord.Type, serviceRecord.Version, serviceRecord.Name);
            if (Directory.Exists(capabilitiesDirectory))
            {
                Directory.Delete(capabilitiesDirectory, true);
            }
            var layerRecords = ConfigContext.Layers.Where(x => x.ServiceId == id);
            ConfigContext.Layers.RemoveRange(layerRecords);
            ConfigContext.Services.Remove(serviceRecord);
            await ConfigContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceRecordExists(int id)
        {
            return ConfigContext.Services.Any(e => e.Id == id);
        }
    }
}
