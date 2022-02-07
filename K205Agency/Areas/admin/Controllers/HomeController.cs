using Microsoft.AspNetCore.Mvc;

namespace K205Agency.Areas.admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
