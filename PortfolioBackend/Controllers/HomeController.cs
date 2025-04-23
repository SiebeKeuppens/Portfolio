using Microsoft.AspNetCore.Mvc;

namespace PortfolioBackend.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpGet("/AdminPage")]
    public IActionResult AdminPage()
    {
        return View();
    }
}