using Microsoft.AspNetCore.Mvc;

namespace YapayZeka.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
