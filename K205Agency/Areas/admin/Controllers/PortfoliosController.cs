using Microsoft.AspNetCore.Mvc;

namespace K205Agency.Areas.admin.Controllers
{
    [Area("admin")]
    public class PortfoliosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
