using Microsoft.AspNetCore.Mvc;

namespace Project_S.L.A.Y.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}