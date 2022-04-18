using Microsoft.AspNetCore.Mvc;

namespace K205Agency.Areas.admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



    }
}
