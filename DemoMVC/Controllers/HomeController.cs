using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string FullName, string MSV)
    {
        ViewBag.Xinchao = "Xin chào: " + FullName + " - MSV: " + MSV;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}