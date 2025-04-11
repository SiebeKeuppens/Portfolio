using Microsoft.EntityFrameworkCore;
using PortfolioBackend.Models;

namespace PortfolioBackend.Data
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options)
            : base(options)
        { }
        
        public DbSet<Project> Projects { get; set; } = null!;
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed project data
            // TODO: Refactor to use an admin menu so I can add project via the site and seeding is uneccesary
            modelBuilder.Entity<Project>().HasData(
                new Project 
                { 
                    Id = 1, 
                    Title = "Portfolio Website", 
                    Description = $"A personal portfolio website showcasing my development projects and skills. " +
                                  $"Made on my own because I wanted a way to show projects I am proud of. " +
                                  $"I built this site from scratch using my programming knowledge and while it is still an ongoing project, I am planning to host it on my own hardware. " +
                                  $"That being an old laptop or raspberry Pi i have laying around.",
                    
                    TechnologiesUsed = "Angular, TypeScript, JavaScript, C#, .NET Core, Entity Framework Core, SQLite",
                    ImageUrl = "./assets/images/portfolio.png",
                    GitHubUrl = "https://github.com/SiebeKeuppens/Portfolio",
                    LiveDemoUrl = "#",
                    CompletedDate = "Not finished yet",
                    IsFeatured = false
                },
                
            new Project 
                { 
                    Id = 2, 
                    Title = "Immersive Storytelling", 
                    Description = $"A Virtual Reality game about Portals. Made with an interdisciplinary team for school where we brainstormed and made this game. " +
                                  $"Every developer on the team made their own world with interactions, mine was the \"crystal world\"",
                    TechnologiesUsed = "Unity, C#, Entity Framework Core, SQLite",
                    ImageUrl = "./assets/images/hubpreview.png",
                    GitHubUrl = "https://github.com/NicolaiDG/ImmersiveProjectV3",
                    LiveDemoUrl = "https://sidequestvr.com/app/40113/enter-the-world-of-geology",
                    CompletedDate = new DateTime(2025,01,07).ToString("dd MMMM yyyy"),
                    IsFeatured = true
                },
                
            new Project 
                { 
                    Id = 3, 
                    Title = "Portfolio Website", 
                    Description = "A personal portfolio website showcasing my development projects and skills",
                    TechnologiesUsed = "Angular, .NET Core, Entity Framework Core, SQLite",
                    ImageUrl = "./assets/images/portfolio.png",
                    GitHubUrl = "#",
                    LiveDemoUrl = "#",
                    CompletedDate = DateTime.Now.ToString("dd MMMM yyyy"),
                    IsFeatured = true
                },
                
            new Project 
                { 
                    Id = 4, 
                    Title = "Portfolio Website", 
                    Description = "A personal portfolio website showcasing my development projects and skills",
                    TechnologiesUsed = "Angular, .NET Core, Entity Framework Core, SQLite",
                    ImageUrl = "./assets/images/portfolio.png",
                    GitHubUrl = "#",
                    LiveDemoUrl = "#",
                    CompletedDate = DateTime.Now.ToString("dd MMMM yyyy"),
                    IsFeatured = true
                },
                
            new Project 
                { 
                    Id = 5, 
                    Title = "Portfolio Website", 
                    Description = "A personal portfolio website showcasing my development projects and skills",
                    TechnologiesUsed = "Angular, .NET Core, Entity Framework Core, SQLite",
                    ImageUrl = "./assets/images/portfolio.png",
                    GitHubUrl = "#",
                    LiveDemoUrl = "#",
                    CompletedDate = DateTime.Now.ToString("dd MMMM yyyy"),
                    IsFeatured = false
                }
            );
        }
    }
}