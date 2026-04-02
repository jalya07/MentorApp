using System.Diagnostics;
using MentorApp.Data;
using Microsoft.AspNetCore.Mvc;
using MentorApp.Models;

namespace MentorApp.Controllers;

public class HomeController(MentorAppDbContext context) : Controller
{
    public IActionResult Index()
    {
        var sliders = context.Sliders.ToList();
        return View(sliders);
    }

    
}