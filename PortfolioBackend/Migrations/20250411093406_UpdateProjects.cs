using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioBackend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompletedDate", "GitHubUrl", "ImageUrl", "IsFeatured", "LiveDemoUrl", "TechnologiesUsed" },
                values: new object[] { "Not finished yet", "https://github.com/SiebeKeuppens/Portfolio", "/assets/images/portfolio.png", false, "#", "Angular, TypeScript, JaveScript, C#, .NET Core, Entity Framework Core, SQLite" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompletedDate", "Description", "GitHubUrl", "ImageUrl", "LiveDemoUrl", "TechnologiesUsed", "Title" },
                values: new object[] { "07-00-YYYY", "A Virtual Reality game about Portals", "https://github.com/NicolaiDG/ImmersiveProjectV3", "/assets/images/hubpreview.png", "https://sidequestvr.com/app/40113/enter-the-world-of-geology", "Unity, C#, Entity Framework Core, SQLite", "Immersive Storytelling" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CompletedDate",
                value: "11-34-YYYY");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CompletedDate",
                value: "11-34-YYYY");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CompletedDate", "IsFeatured" },
                values: new object[] { "11-34-YYYY", false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompletedDate", "GitHubUrl", "ImageUrl", "IsFeatured", "LiveDemoUrl", "TechnologiesUsed" },
                values: new object[] { new DateTime(2025, 4, 9, 16, 21, 22, 556, DateTimeKind.Local).AddTicks(4490), "unkown", "/assets/images/portfolio.jpg", true, "unknown", "Angular, .NET Core, Entity Framework Core, SQLite" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompletedDate", "Description", "GitHubUrl", "ImageUrl", "LiveDemoUrl", "TechnologiesUsed", "Title" },
                values: new object[] { new DateTime(2025, 4, 9, 16, 21, 22, 556, DateTimeKind.Local).AddTicks(4540), "A personal portfolio website showcasing my development projects and skills", "unkown", "/assets/images/portfolio.jpg", "unknown", "Angular, .NET Core, Entity Framework Core, SQLite", "Portfolio Website" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CompletedDate",
                value: new DateTime(2025, 4, 9, 16, 21, 22, 556, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CompletedDate",
                value: new DateTime(2025, 4, 9, 16, 21, 22, 556, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CompletedDate", "IsFeatured" },
                values: new object[] { new DateTime(2025, 4, 9, 16, 21, 22, 556, DateTimeKind.Local).AddTicks(4550), true });
        }
    }
}
