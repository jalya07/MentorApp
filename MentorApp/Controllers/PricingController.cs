using Microsoft.AspNetCore.Mvc;

namespace MentorApp.Controllers;

public class PricingController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}