using Microsoft.AspNetCore.Mvc;

namespace YapayZeka.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
