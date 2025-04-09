namespace PortfolioBackend.Models;

public class Project
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string TechnologiesUsed { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string GitHubUrl { get; set; } = string.Empty;
    public string LiveDemoUrl { get; set; } = string.Empty;
    public DateTime CompletedDate { get; set; }
    public bool IsFeatured { get; set; }
}