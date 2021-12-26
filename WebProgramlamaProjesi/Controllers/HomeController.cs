using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebProgramlamaProjesi.Data;
using WebProgramlamaProjesi.Models;

namespace WebProgramlamaProjesi.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        BlogYorum by = new BlogYorum();

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Blog.ToListAsync());
        }

        public async Task<PartialViewResult> _HomePartial1()
        {
            return PartialView(await _context.Blog.OrderByDescending(item=>item.ID).Take(2).ToListAsync());
        }

        public async Task<PartialViewResult> _HomePartial2()
        {
            return PartialView(await _context.Blog.Take(1).ToListAsync());
        }

        public async Task<PartialViewResult> _HomePartial3()
        {
            return PartialView(await _context.Blog.ToListAsync());
        }

        public async Task<PartialViewResult> _HomePartial4()
        {
            return PartialView(await _context.Blog.Take(3).ToListAsync());
        }

        public async Task<IActionResult> About()
        {
            return View(await _context.Hakkimizda.ToListAsync());
        }
        

        public async Task<IActionResult> Blog()
        {
            by.Deger1 = await _context.Blog.ToListAsync();
            by.Deger3 = await _context.Blog.Take(3).ToListAsync();
            return View(by);
        }

        public async Task<IActionResult> BlogDetayAsync(int id)
        {
            by.Deger1 = await _context.Blog.Where(x => x.ID == id).ToListAsync();
            by.Deger2 = await _context.Yorumlar.Where(x => x.BlogId == id).ToListAsync();
            return View(by);
        }

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            _context.Yorumlar.Add(y);
            _context.SaveChanges();
            return PartialView();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


