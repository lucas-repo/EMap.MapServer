using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EMap.MapServer.Services.Models;
using Microsoft.AspNetCore.Hosting;

namespace EMap.MapServer.Services.Controllers
{
    public class LayersController : BaseController
    {
        protected OgcServiceHelper OgcServiceHelper { get; }
        public LayersController(IHostingEnvironment environment, ConfigContext configContext) : base(environment, configContext)
        {
            string href = Request.Host.Host;
            OgcServiceHelper = new OgcServiceHelper(ConfigContext, ServicePathManager, href);
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

        // GET: Layers/Create
        public IActionResult Create()
        {
            ViewData["ServiceId"] = new SelectList(ConfigContext.Services, "Id", "Id");
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

        private bool LayerRecordExists(int id)
        {
            return ConfigContext.Layers.Any(e => e.Id == id);
        }
    }
}
