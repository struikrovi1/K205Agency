using K205Agency.Areas.admin.ViewModel;
using K205Agency.Data;
using K205Agency.Models;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult Index()
        {
            AdminVM vm = new()
            {
                Portfolios = _context.Portfolios.ToList(),
            };
            
            return View(vm);
        }
    }
}
