using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorWebApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SampleDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleDatas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SampleDatas",
                columns: new[] { "Id", "Category", "Date", "Description", "Name", "Status", "Value" },
                values: new object[,]
                {
                    { 1, "A", new DateTime(2026, 1, 30, 8, 41, 47, 377, DateTimeKind.Local).AddTicks(1470), "Test item 1", "Item 1", "Active", 100m },
                    { 2, "B", new DateTime(2026, 1, 29, 8, 41, 47, 377, DateTimeKind.Local).AddTicks(1510), "Test item 2", "Item 2", "Inactive", 200m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SampleDatas");
        }
    }
}
