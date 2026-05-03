using Microsoft.AspNetCore.Mvc;
//using Presentation.WebApp.Models;
using System.Diagnostics;


namespace Presentation.WebApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
