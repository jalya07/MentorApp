using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MentorApp.Models;

namespace MentorApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    
}