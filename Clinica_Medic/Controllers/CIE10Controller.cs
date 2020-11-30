using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Clinica_Medic.Data;
using Clinica_Medic.Models;

namespace Clinica_Medic.Controllers
{
    public class CIE10Controller : Controller
    {
        public readonly ApplicationDbContext _context;

        public CIE10Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        public CIE10Controller()
        {
        }

        // GET: CIE10
        public async Task<IActionResult> Index()
        {
            return View(await _context.CIE10.ToListAsync());
        }

        // GET: CIE10/Details/5
        public async Task<IActionResult> Details(int? id)
        {
           // var product = new CIE10(id,"A001","Diarrea");
           // return View("Details", product);

            if (id == null)
            {
                return NotFound();
            }

            var cIE10 = await _context.CIE10
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cIE10 == null)
            {
                return NotFound();
            }

            return View(cIE10);
        }

        // GET: CIE10/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CIE10/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Codigo,Nombre,Categoria,Descripcion")] CIE10 cIE10)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cIE10);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cIE10);
        }

        // GET: CIE10/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cIE10 = await _context.CIE10.FindAsync(id);
            if (cIE10 == null)
            {
                return NotFound();
            }
            return View(cIE10);
        }

        // POST: CIE10/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Codigo,Nombre,Categoria,Descripcion")] CIE10 cIE10)
        {
            if (id != cIE10.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cIE10);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CIE10Exists(cIE10.Id))
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
            return View(cIE10);
        }

        // GET: CIE10/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cIE10 = await _context.CIE10
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cIE10 == null)
            {
                return NotFound();
            }

            return View(cIE10);
        }

        // POST: CIE10/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cIE10 = await _context.CIE10.FindAsync(id);
            _context.CIE10.Remove(cIE10);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CIE10Exists(int id)
        {
            return _context.CIE10.Any(e => e.Id == id);
        }
    }
}
