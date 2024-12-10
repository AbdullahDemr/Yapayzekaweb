using Microsoft.AspNetCore.Mvc;

namespace YapayZeka.Controllers
{
    public class FAQsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
