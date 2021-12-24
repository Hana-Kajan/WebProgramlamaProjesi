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
    public class YorumlarController : Controller
    {
        private readonly ApplicationDbContext _context;

        public YorumlarController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Yorumlar
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Yorumlar.Include(y => y.Blog);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Yorumlar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yorumlar = await _context.Yorumlar
                .Include(y => y.Blog)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (yorumlar == null)
            {
                return NotFound();
            }

            return View(yorumlar);
        }

        // GET: Yorumlar/Create
        public IActionResult Create()
        {
            ViewData["BlogId"] = new SelectList(_context.Blog, "ID", "ID");
            return View();
        }

        // POST: Yorumlar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,KullaniciAdi,Mail,Yorum,BlogId")] Yorumlar yorumlar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(yorumlar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BlogId"] = new SelectList(_context.Blog, "ID", "ID", yorumlar.BlogId);
            return View(yorumlar);
        }

        // GET: Yorumlar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yorumlar = await _context.Yorumlar.FindAsync(id);
            if (yorumlar == null)
            {
                return NotFound();
            }
            ViewData["BlogId"] = new SelectList(_context.Blog, "ID", "ID", yorumlar.BlogId);
            return View(yorumlar);
        }

        // POST: Yorumlar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,KullaniciAdi,Mail,Yorum,BlogId")] Yorumlar yorumlar)
        {
            if (id != yorumlar.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(yorumlar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!YorumlarExists(yorumlar.ID))
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
            ViewData["BlogId"] = new SelectList(_context.Blog, "ID", "ID", yorumlar.BlogId);
            return View(yorumlar);
        }

        // GET: Yorumlar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yorumlar = await _context.Yorumlar
                .Include(y => y.Blog)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (yorumlar == null)
            {
                return NotFound();
            }

            return View(yorumlar);
        }

        // POST: Yorumlar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var yorumlar = await _context.Yorumlar.FindAsync(id);
            _context.Yorumlar.Remove(yorumlar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool YorumlarExists(int id)
        {
            return _context.Yorumlar.Any(e => e.ID == id);
        }
    }
}
