using Microsoft.AspNetCore.Mvc;

namespace YapayZeka.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
