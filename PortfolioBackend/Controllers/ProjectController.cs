using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioBackend.Data;
using PortfolioBackend.Models;

namespace PortfolioBackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectController : ControllerBase
{
    private readonly PortfolioDbContext _context;

    public ProjectController(PortfolioDbContext context)
    {
        _context = context;
    }

    // GET: api/project
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Project>>> GetProjects(string? sortBy = null, string? sortOrder = "asc")
    {
        IQueryable<Project> query = _context.Projects;

        // Apply sorting
        if (!string.IsNullOrEmpty(sortBy))
        {
            switch (sortBy.ToLower())
            {
                case "title":
                    query = sortOrder?.ToLower() == "desc"
                        ? query.OrderByDescending(p => p.Title)
                        : query.OrderBy(p => p.Title);
                    break;
                case "date":
                    query = sortOrder?.ToLower() == "desc"
                        ? query.OrderByDescending(p => p.CompletedDate)
                        : query.OrderBy(p => p.CompletedDate);
                    break;
                default:
                    // Default sort by ID if sort field is not recognized
                    query = sortOrder?.ToLower() == "desc"
                        ? query.OrderByDescending(p => p.Id)
                        : query.OrderBy(p => p.Id);
                    break;
            }
        }

        return await query.ToListAsync();
    }

    // GET: api/project/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Project>> GetProject(int id)
    {
        var project = await _context.Projects.FindAsync(id);

        if (project == null) return NotFound();

        return project;
    }

    // POST: api/project/AddProject
    [HttpPost("AddProject")]
    public async Task<ActionResult<Project>> AddProject([FromForm] Project project, [FromForm] string adminPassword)
    {
        var realAdminPassword = Environment.GetEnvironmentVariable("ADMIN_PASSWORD");
        if (adminPassword != realAdminPassword)
        {
            Console.WriteLine("Checked password " + adminPassword + " against " + realAdminPassword + " , FAILED!");
            ;
            return Unauthorized();
        }

        _context.Projects.Add(project);
        await _context.SaveChangesAsync();
        return Redirect("/AllProjects");
        return CreatedAtAction("GetProject", new { id = project.Id }, project);
    }
}