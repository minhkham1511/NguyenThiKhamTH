using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NguyenThiKhamBTH.Models;

namespace NguyenThiKhamBTH.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string FullName, string email)
    {
        ViewBag.name = "hello" + FullName + "_" + email ; 
         
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
