using System.Diagnostics;
using MentorApp.Data;
using Microsoft.AspNetCore.Mvc;
using MentorApp.Models;
using MentorApp.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace MentorApp.Controllers;

public class HomeController(MentorAppDbContext context) : Controller
{
    public async Task<IActionResult> Index()
    {
        var slider = await context.Sliders.FirstOrDefaultAsync();
        HomeVm homeVm = new HomeVm
        {
            Slider = slider
        };
        return View(homeVm);
    }

    
}