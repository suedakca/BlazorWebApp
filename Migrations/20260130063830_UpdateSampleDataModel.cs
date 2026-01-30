using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorWebApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSampleDataModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Branch",
                table: "SampleDatas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Project",
                table: "SampleDatas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "SampleDatas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Branch", "Category", "Date", "Description", "Name", "Project", "Value", "Year" },
                values: new object[] { "İstanbul", "İnşaat", new DateTime(2026, 1, 25, 9, 38, 30, 624, DateTimeKind.Local).AddTicks(2720), "Merkez şube konut satışı", "Konut Projesi A", "Alpha", 1250000m, 2024 });

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Branch", "Category", "Date", "Description", "Name", "Project", "Status", "Value", "Year" },
                values: new object[] { "Ankara", "Ticari", new DateTime(2026, 1, 20, 9, 38, 30, 624, DateTimeKind.Local).AddTicks(2770), "Ankara şube ofis kiralama", "Ofis Bloğu B", "Alpha", "Active", 850000m, 2024 });

            migrationBuilder.InsertData(
                table: "SampleDatas",
                columns: new[] { "Id", "Branch", "Category", "Date", "Description", "Name", "Project", "Status", "Value", "Year" },
                values: new object[,]
                {
                    { 3, "İzmir", "Ticari", new DateTime(2025, 12, 30, 9, 38, 30, 624, DateTimeKind.Local).AddTicks(2770), "İzmir AVM projesi tamamlandı", "AVM Projesi C", "Beta", "Inactive", 5000000m, 2023 },
                    { 4, "Antalya", "Lüks Konut", new DateTime(2025, 11, 30, 9, 38, 30, 624, DateTimeKind.Local).AddTicks(2780), "Antalya lüks villa projesi", "Villa Etap 1", "Gamma", "Active", 3200000m, 2024 },
                    { 5, "Kocaeli", "Sanayi", new DateTime(2026, 1, 15, 9, 38, 30, 624, DateTimeKind.Local).AddTicks(2780), "Kocaeli lojistik depo depo inşaatı", "Lojistik Merkezi", "Beta", "Active", 4500000m, 2024 },
                    { 6, "Bursa", "Kamu", new DateTime(2026, 1, 10, 9, 38, 30, 624, DateTimeKind.Local).AddTicks(2780), "Bursa şehir hastanesi ek bina", "Hastane Projesi", "Delta", "Active", 12000000m, 2022 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Branch",
                table: "SampleDatas");

            migrationBuilder.DropColumn(
                name: "Project",
                table: "SampleDatas");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "SampleDatas");

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Date", "Description", "Name", "Value" },
                values: new object[] { "A", new DateTime(2026, 1, 30, 8, 41, 47, 377, DateTimeKind.Local).AddTicks(1470), "Test item 1", "Item 1", 100m });

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Date", "Description", "Name", "Status", "Value" },
                values: new object[] { "B", new DateTime(2026, 1, 29, 8, 41, 47, 377, DateTimeKind.Local).AddTicks(1510), "Test item 2", "Item 2", "Inactive", 200m });
        }
    }
}
