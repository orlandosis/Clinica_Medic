using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Clinica_Medic.Data;
using Clinica_Medic.Models;

namespace clinica.Controllers
{
    public class SignosVitalesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SignosVitalesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SignosVitales
        public async Task<IActionResult> Index()
        {
            return View(await _context.SignosVitales.ToListAsync());
        }

        // GET: SignosVitales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var signosVitales = await _context.SignosVitales
                .FirstOrDefaultAsync(m => m.Id == id);
            if (signosVitales == null)
            {
                return NotFound();
            }

            return View(signosVitales);
        }

        // GET: SignosVitales/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SignosVitales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Dpi,Temperatura,Presion,Peso,Fecha")] SignosVitales signosVitales)
        {
            if (ModelState.IsValid)
            {
                _context.Add(signosVitales);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(signosVitales);
        }

        // GET: SignosVitales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var signosVitales = await _context.SignosVitales.FindAsync(id);
            if (signosVitales == null)
            {
                return NotFound();
            }
            return View(signosVitales);
        }

        // POST: SignosVitales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Dpi,Temperatura,Presion,Peso,Fecha")] SignosVitales signosVitales)
        {
            if (id != signosVitales.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(signosVitales);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SignosVitalesExists(signosVitales.Id))
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
            return View(signosVitales);
        }

        // GET: SignosVitales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var signosVitales = await _context.SignosVitales
                .FirstOrDefaultAsync(m => m.Id == id);
            if (signosVitales == null)
            {
                return NotFound();
            }

            return View(signosVitales);
        }

        // POST: SignosVitales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var signosVitales = await _context.SignosVitales.FindAsync(id);
            _context.SignosVitales.Remove(signosVitales);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SignosVitalesExists(int id)
        {
            return _context.SignosVitales.Any(e => e.Id == id);
        }
    }
}
