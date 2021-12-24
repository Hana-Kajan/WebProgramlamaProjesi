using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebProgramlamaProjesi.Data;
using WebProgramlamaProjesi.Models;

namespace WebProgramlamaProjesi.Controllers
{
    public class HakkimizdaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HakkimizdaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Hakkimizda
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hakkimizda.ToListAsync());
        }

        // GET: Hakkimizda/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hakkimizda = await _context.Hakkimizda
                .FirstOrDefaultAsync(m => m.ID == id);
            if (hakkimizda == null)
            {
                return NotFound();
            }

            return View(hakkimizda);
        }

        // GET: Hakkimizda/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hakkimizda/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FotoUrl,Aciklama")] Hakkimizda hakkimizda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hakkimizda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hakkimizda);
        }

        // GET: Hakkimizda/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hakkimizda = await _context.Hakkimizda.FindAsync(id);
            if (hakkimizda == null)
            {
                return NotFound();
            }
            return View(hakkimizda);
        }

        // POST: Hakkimizda/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FotoUrl,Aciklama")] Hakkimizda hakkimizda)
        {
            if (id != hakkimizda.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hakkimizda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HakkimizdaExists(hakkimizda.ID))
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
            return View(hakkimizda);
        }

        // GET: Hakkimizda/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hakkimizda = await _context.Hakkimizda
                .FirstOrDefaultAsync(m => m.ID == id);
            if (hakkimizda == null)
            {
                return NotFound();
            }

            return View(hakkimizda);
        }

        // POST: Hakkimizda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hakkimizda = await _context.Hakkimizda.FindAsync(id);
            _context.Hakkimizda.Remove(hakkimizda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HakkimizdaExists(int id)
        {
            return _context.Hakkimizda.Any(e => e.ID == id);
        }
    }
}
