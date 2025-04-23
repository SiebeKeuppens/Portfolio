using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    
    // GET: api/projects
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Project>>> GetProjects()
    {
        return await _context.Projects.ToListAsync();
    }

    // GET: api/projects/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Project>> GetProject(int id)
    {
        var project = await _context.Projects.FindAsync(id);

        if (project == null)
        {
            return NotFound();
        }

        return project;
    }
    
    // POST: api/projects/addProject
    [HttpPost("addProject")]
    public async Task<ActionResult<Project>> AddProject([FromForm] Project project)
    {
        _context.Projects.Add(project);
        await _context.SaveChangesAsync();
    
        return CreatedAtAction(nameof(GetProject), new { id = project.Id }, project);
    }
    
    
}