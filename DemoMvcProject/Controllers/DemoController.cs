using Microsoft.AspNetCore.Mvc;

namespace DemoMvcProject.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
             return View();
        }
        public IActionResult Demo()
        {
            return View();
        }
    }
}