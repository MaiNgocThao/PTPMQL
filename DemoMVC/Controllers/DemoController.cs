using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    { 
        public IActionResult Index()
        {
            //su dung viewbag de gui du lieu tu controller ve view
            ViewBag.FullName = "Mai NGoc Thao";
            return View();
        }
        public IActionResult Demo()
        {
            return View();
        }
    }
}