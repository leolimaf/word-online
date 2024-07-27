using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnlineTextEditor.Models;

namespace OnlineTextEditor.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}