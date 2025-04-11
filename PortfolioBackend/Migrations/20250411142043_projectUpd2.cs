using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioBackend.Migrations
{
    /// <inheritdoc />
    public partial class projectUpd2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "TechnologiesUsed" },
                values: new object[] { "A personal portfolio website showcasing my development projects and skills. Made on my own because I wanted a way to show projects I am proud of. I built this site from scratch using my programming knowledge and while it is still an ongoing project, I am planning to host it on my own hardware. That being an old laptop or raspberry Pi i have laying around.", "Angular, TypeScript, JavaScript, C#, .NET Core, Entity Framework Core, SQLite" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "A Virtual Reality game about Portals. Made with an interdisciplinary team for school where we brainstormed and made this game. Every developer on the team made their own world with interactions, mine was the \"crystal world\"");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "GitHubUrl", "ImageUrl", "LiveDemoUrl" },
                values: new object[] { "#", "./assets/images/portfolio.png", "#" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "GitHubUrl", "ImageUrl", "LiveDemoUrl" },
                values: new object[] { "#", "./assets/images/portfolio.png", "#" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "GitHubUrl", "ImageUrl", "LiveDemoUrl" },
                values: new object[] { "#", "./assets/images/portfolio.png", "#" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "TechnologiesUsed" },
                values: new object[] { "A personal portfolio website showcasing my development projects and skills", "Angular, TypeScript, JaveScript, C#, .NET Core, Entity Framework Core, SQLite" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "A Virtual Reality game about Portals");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "GitHubUrl", "ImageUrl", "LiveDemoUrl" },
                values: new object[] { "unkown", "./assets/images/portfolio.jpg", "unknown" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "GitHubUrl", "ImageUrl", "LiveDemoUrl" },
                values: new object[] { "unkown", "./assets/images/portfolio.jpg", "unknown" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "GitHubUrl", "ImageUrl", "LiveDemoUrl" },
                values: new object[] { "unkown", "./assets/images/portfolio.jpg", "unknown" });
        }
    }
}
