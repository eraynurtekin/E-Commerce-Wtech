using Microsoft.AspNetCore.Mvc;

namespace Commerce.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
