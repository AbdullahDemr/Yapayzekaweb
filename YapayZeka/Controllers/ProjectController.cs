using Microsoft.AspNetCore.Mvc;

namespace YapayZeka.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
