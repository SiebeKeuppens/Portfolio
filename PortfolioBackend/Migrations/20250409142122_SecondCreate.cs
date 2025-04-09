using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioBackend.Migrations
{
    /// <inheritdoc />
    public partial class SecondCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedDate",
                value: new DateTime(2025, 4, 9, 16, 21, 22, 556, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CompletedDate", "Description", "GitHubUrl", "ImageUrl", "IsFeatured", "LiveDemoUrl", "TechnologiesUsed", "Title" },
                values: new object[,]
                {
                    { 2, new DateTime(2025, 4, 9, 16, 21, 22, 556, DateTimeKind.Local).AddTicks(4540), "A personal portfolio website showcasing my development projects and skills", "unkown", "/assets/images/portfolio.jpg", true, "unknown", "Angular, .NET Core, Entity Framework Core, SQLite", "Portfolio Website" },
                    { 3, new DateTime(2025, 4, 9, 16, 21, 22, 556, DateTimeKind.Local).AddTicks(4550), "A personal portfolio website showcasing my development projects and skills", "unkown", "/assets/images/portfolio.jpg", true, "unknown", "Angular, .NET Core, Entity Framework Core, SQLite", "Portfolio Website" },
                    { 4, new DateTime(2025, 4, 9, 16, 21, 22, 556, DateTimeKind.Local).AddTicks(4550), "A personal portfolio website showcasing my development projects and skills", "unkown", "/assets/images/portfolio.jpg", true, "unknown", "Angular, .NET Core, Entity Framework Core, SQLite", "Portfolio Website" },
                    { 5, new DateTime(2025, 4, 9, 16, 21, 22, 556, DateTimeKind.Local).AddTicks(4550), "A personal portfolio website showcasing my development projects and skills", "unkown", "/assets/images/portfolio.jpg", true, "unknown", "Angular, .NET Core, Entity Framework Core, SQLite", "Portfolio Website" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompletedDate",
                value: new DateTime(2025, 4, 9, 13, 45, 38, 1, DateTimeKind.Local).AddTicks(9460));
        }
    }
}
