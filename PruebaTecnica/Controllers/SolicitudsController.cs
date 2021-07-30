using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Data;
using PruebaTecnica.Models;

namespace PruebaTecnica.Controllers
{
    public class SolicitudsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SolicitudsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Solicituds
        public async Task<IActionResult> Index()
        {
            

            return View(await _context.Solicitud.ToListAsync());
        }

        // GET: Solicituds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitud = await _context.Solicitud
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitud == null)
            {
                return NotFound();
            }

            return View(solicitud);
        }

        // GET: Solicituds/Create
        public IActionResult Create()
        {
            IEnumerable<Personas> upersona = _context.Personas;
            List<SelectListItem> listapersona = upersona.ToList().ConvertAll(u =>
            {
                return new SelectListItem()
                {
                    Text = u.Id.ToString(),
                    Value = u.Id.ToString(),
                    Selected = false
                };
            });
            IEnumerable<Estados> uestados = _context.Estados;
            List<SelectListItem> listaestados = uestados.ToList().ConvertAll(u =>
            {
                return new SelectListItem()
                {
                    Text = u.Estado.ToString(),
                    Value = u.Estado.ToString(),
                    Selected = false
                };
            });
            ViewBag.listapersona = listapersona;
            ViewBag.listaestado = listaestados;

            return View();
        }

        // POST: Solicituds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PersonaId,Estado,FechaCreacion")] Solicitud solicitud)
        {
            if (ModelState.IsValid)
            {
                _context.Add(solicitud);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(solicitud);
        }

        // GET: Solicituds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            IEnumerable<Personas> upersona = _context.Personas;
            List<SelectListItem> listapersona = upersona.ToList().ConvertAll(u =>
            {
                return new SelectListItem()
                {
                    Text = u.Id.ToString(),
                    Value = u.Id.ToString(),
                    Selected = false
                };
            });
            IEnumerable<Estados> uestados = _context.Estados;
            List<SelectListItem> listaestados = uestados.ToList().ConvertAll(u =>
            {
                return new SelectListItem()
                {
                    Text = u.Estado.ToString(),
                    Value = u.Estado.ToString(),
                    Selected = false
                };
            });
            ViewBag.listapersona = listapersona;
            ViewBag.listaestado = listaestados;
            if (id == null)
            {
                return NotFound();
            }

            var solicitud = await _context.Solicitud.FindAsync(id);
            if (solicitud == null)
            {
                return NotFound();
            }
            return View(solicitud);
        }

        // POST: Solicituds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PersonaId,Estado,FechaCreacion")] Solicitud solicitud)
        {
            if (id != solicitud.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(solicitud);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SolicitudExists(solicitud.Id))
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
            return View(solicitud);
        }

        // GET: Solicituds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitud = await _context.Solicitud
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitud == null)
            {
                return NotFound();
            }

            return View(solicitud);
        }

        // POST: Solicituds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var solicitud = await _context.Solicitud.FindAsync(id);
            _context.Solicitud.Remove(solicitud);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SolicitudExists(int id)
        {
            return _context.Solicitud.Any(e => e.Id == id);
        }
    }
}
