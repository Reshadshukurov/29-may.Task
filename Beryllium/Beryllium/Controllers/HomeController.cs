using Microsoft.AspNetCore.Mvc;


namespace Beryllium.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

      
    }
}
