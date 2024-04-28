using Microsoft.AspNetCore.Mvc;

namespace MyFirstApp.Controllers
{
    public class Map : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
