using K205Agency.Data;
using K205Agency.Models;
using K205Agency.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace K205Agency.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AgencyDbContext _context;

        public HomeController(ILogger<HomeController> logger, AgencyDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        // get post put delete


        [HttpGet]
        public IActionResult Index()
        {
            HomeVM homeVM = new()
            {
                Masthead = _context.Mastheads.FirstOrDefault(),
                Services = _context.Services.ToList(),
                Portfolios = _context.Portfolios.Include(x=>x.Category).ToList(),
                Abouts = _context.Abouts.ToList()
            };
            
            return View(homeVM);
        }

        [HttpPost]
        public IActionResult Index(ContactUs contactUs)
        {
            _context.ContactUs.Add(contactUs);
            _context.SaveChanges();


            return RedirectToAction(nameof(Index));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}