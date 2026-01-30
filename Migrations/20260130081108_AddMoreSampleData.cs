using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreSampleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 25, 11, 11, 7, 958, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 1, 20, 11, 11, 7, 958, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 12, 30, 11, 11, 7, 958, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 11, 30, 11, 11, 7, 958, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2026, 1, 15, 11, 11, 7, 958, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2026, 1, 10, 11, 11, 7, 958, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.InsertData(
                table: "SampleDatas",
                columns: new[] { "Id", "AssignedTo", "Branch", "Category", "Customer", "Date", "Description", "Name", "PaymentStatus", "Priority", "Project", "Region", "Status", "Value", "Year" },
                values: new object[,]
                {
                    { 7, "Selin Ak", "İstanbul", "İnşaat", "Ağaoğlu", new DateTime(2026, 1, 27, 11, 11, 7, 958, DateTimeKind.Local).AddTicks(3080), "Lüks rezidans satışı", "Rezidans X", "Paid", "Medium", "Alpha", "Marmara", "Active", 2500000m, 2024 },
                    { 8, "Emre Aydın", "Ankara", "Ticari", "Kuzu Grup", new DateTime(2026, 1, 23, 11, 11, 7, 958, DateTimeKind.Local).AddTicks(3080), "Modern iş merkezi kiralama", "İş Merkezi Y", "Pending", "High", "Beta", "İç Anadolu", "Active", 1800000m, 2024 },
                    { 9, "Zeynep Koç", "Kocaeli", "Sanayi", "Trendyol", new DateTime(2025, 12, 30, 11, 11, 7, 958, DateTimeKind.Local).AddTicks(3080), "Lojistik depo genişletme", "Depo Z", "Overdue", "Low", "Gamma", "Marmara", "Active", 3200000m, 2023 },
                    { 10, "Hakan Yıldız", "Bursa", "İnşaat", "Sur Yapı", new DateTime(2026, 1, 18, 11, 11, 7, 958, DateTimeKind.Local).AddTicks(3090), "Yeni etap konut projesi", "Konut Sitesi D", "Paid", "Medium", "Delta", "Marmara", "Active", 4100000m, 2024 },
                    { 11, "Merve Şahin", "Antalya", "Turizm", "Hilton", new DateTime(2025, 10, 30, 11, 11, 7, 958, DateTimeKind.Local).AddTicks(3110), "5 yıldızlı otel inşaatı", "Otel Projesi E", "Paid", "High", "Gamma", "Akdeniz", "Active", 15000000m, 2024 },
                    { 12, "Murat Demir", "İstanbul", "Kamu", "İBB", new DateTime(2026, 1, 26, 11, 11, 7, 958, DateTimeKind.Local).AddTicks(3110), "Şehir parkı yenileme çalışması", "Park Revizyonu", "Paid", "Low", "Alpha", "Marmara", "Active", 500000m, 2022 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 25, 10, 38, 3, 818, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 1, 20, 10, 38, 3, 818, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 12, 30, 10, 38, 3, 818, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 11, 30, 10, 38, 3, 818, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2026, 1, 15, 10, 38, 3, 818, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2026, 1, 10, 10, 38, 3, 818, DateTimeKind.Local).AddTicks(2690));
        }
    }
}
