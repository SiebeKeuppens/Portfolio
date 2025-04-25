using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioBackend.Data;
using PortfolioBackend.Models;

namespace PortfolioBackend.Controllers;

public class HomeController : Controller
{
    private readonly PortfolioDbContext _context;

    public HomeController(PortfolioDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }
    
    [HttpGet("/AdminPage")]
    public IActionResult AdminPage()
    {
        return View();
    }

    [HttpGet("/AllProjects")]
    public async Task<IActionResult> AllProjects(string sortBy = "title", string sortOrder = "asc")
    {
        ViewData["TitleSortParam"] = sortBy == "title" && sortOrder == "asc" ? "title_desc" : "title";
        ViewData["DateSortParam"] = sortBy == "date" && sortOrder == "asc" ? "date_desc" : "date";
        ViewData["CurrentSort"] = sortBy;
        ViewData["CurrentOrder"] = sortOrder;

        IQueryable<Project> projects = _context.Projects;
        
        // Apply sorting
        switch (sortBy)
        {
            case "title_desc":
                projects = projects.OrderByDescending(p => p.Title);
                break;
            case "date":
                projects = projects.OrderBy(p => p.CompletedDate);
                break;
            case "date_desc":
                projects = projects.OrderByDescending(p => p.CompletedDate);
                break;
            default:
                projects = projects.OrderBy(p => p.Title);
                break;
        }

        return View(await projects.ToListAsync());
    }

    [HttpGet("/Contact")]
    public IActionResult Contact()
    {
        return View();
    }
}