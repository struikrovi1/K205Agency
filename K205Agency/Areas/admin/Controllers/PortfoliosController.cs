using K205Agency.Areas.admin.ViewModel;
using K205Agency.Data;
using K205Agency.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace K205Agency.Areas.admin.Controllers
{
    [Area("admin")]
    public class PortfoliosController : Controller
    {
        private readonly AgencyDbContext _context;

        public PortfoliosController(AgencyDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Portfolios.ToListAsync());
        }
    }
}
