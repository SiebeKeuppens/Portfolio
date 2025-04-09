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
            // Seed some initial project data
            modelBuilder.Entity<Project>().HasData(
                new Project 
                { 
                    Id = 1, 
                    Title = "Portfolio Website", 
                    Description = "A personal portfolio website showcasing my development projects and skills",
                    TechnologiesUsed = "Angular, .NET Core, Entity Framework Core, SQLite",
                    ImageUrl = "/assets/images/portfolio.jpg",
                    GitHubUrl = "unkown",
                    LiveDemoUrl = "unknown",
                    CompletedDate = DateTime.Now,
                    IsFeatured = true
                },
                
            new Project 
                { 
                    Id = 2, 
                    Title = "Portfolio Website", 
                    Description = "A personal portfolio website showcasing my development projects and skills",
                    TechnologiesUsed = "Angular, .NET Core, Entity Framework Core, SQLite",
                    ImageUrl = "/assets/images/portfolio.jpg",
                    GitHubUrl = "unkown",
                    LiveDemoUrl = "unknown",
                    CompletedDate = DateTime.Now,
                    IsFeatured = true
                },
                
            new Project 
                { 
                    Id = 3, 
                    Title = "Portfolio Website", 
                    Description = "A personal portfolio website showcasing my development projects and skills",
                    TechnologiesUsed = "Angular, .NET Core, Entity Framework Core, SQLite",
                    ImageUrl = "/assets/images/portfolio.jpg",
                    GitHubUrl = "unkown",
                    LiveDemoUrl = "unknown",
                    CompletedDate = DateTime.Now,
                    IsFeatured = true
                },
                
            new Project 
                { 
                    Id = 4, 
                    Title = "Portfolio Website", 
                    Description = "A personal portfolio website showcasing my development projects and skills",
                    TechnologiesUsed = "Angular, .NET Core, Entity Framework Core, SQLite",
                    ImageUrl = "/assets/images/portfolio.jpg",
                    GitHubUrl = "unkown",
                    LiveDemoUrl = "unknown",
                    CompletedDate = DateTime.Now,
                    IsFeatured = true
                },
                
            new Project 
                { 
                    Id = 5, 
                    Title = "Portfolio Website", 
                    Description = "A personal portfolio website showcasing my development projects and skills",
                    TechnologiesUsed = "Angular, .NET Core, Entity Framework Core, SQLite",
                    ImageUrl = "/assets/images/portfolio.jpg",
                    GitHubUrl = "unkown",
                    LiveDemoUrl = "unknown",
                    CompletedDate = DateTime.Now,
                    IsFeatured = true
                }
            );
        }
    }
}