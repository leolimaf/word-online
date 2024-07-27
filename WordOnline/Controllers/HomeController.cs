using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WordOnline.Models;

namespace WordOnline.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}