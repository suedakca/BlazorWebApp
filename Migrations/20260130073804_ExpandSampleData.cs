using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorWebApp.Migrations
{
    /// <inheritdoc />
    public partial class ExpandSampleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssignedTo",
                table: "SampleDatas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Customer",
                table: "SampleDatas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaymentStatus",
                table: "SampleDatas",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Priority",
                table: "SampleDatas",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "SampleDatas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedTo", "Customer", "Date", "PaymentStatus", "Priority", "Region" },
                values: new object[] { "Ali Yılmaz", "Emlak Konut", new DateTime(2026, 1, 25, 10, 38, 3, 818, DateTimeKind.Local).AddTicks(2640), "Paid", "High", "Marmara" });

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignedTo", "Customer", "Date", "PaymentStatus", "Priority", "Region" },
                values: new object[] { "Fatma Demir", "Vestel A.Ş.", new DateTime(2026, 1, 20, 10, 38, 3, 818, DateTimeKind.Local).AddTicks(2670), "Pending", "Medium", "İç Anadolu" });

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignedTo", "Customer", "Date", "PaymentStatus", "Priority", "Region" },
                values: new object[] { "Mehmet Can", "Rönesans Holding", new DateTime(2025, 12, 30, 10, 38, 3, 818, DateTimeKind.Local).AddTicks(2680), "Overdue", "Low", "Ege" });

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignedTo", "Customer", "Date", "PaymentStatus", "Priority", "Region" },
                values: new object[] { "Ayşe Kaya", "Bireysel Yatırımcı", new DateTime(2025, 11, 30, 10, 38, 3, 818, DateTimeKind.Local).AddTicks(2680), "Paid", "High", "Akdeniz" });

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignedTo", "Customer", "Date", "PaymentStatus", "Priority", "Region" },
                values: new object[] { "Caner Öz", "DHL Express", new DateTime(2026, 1, 15, 10, 38, 3, 818, DateTimeKind.Local).AddTicks(2690), "Paid", "Medium", "Marmara" });

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AssignedTo", "Customer", "Date", "PaymentStatus", "Priority", "Region" },
                values: new object[] { "Deniz Akça", "Sağlık Bakanlığı", new DateTime(2026, 1, 10, 10, 38, 3, 818, DateTimeKind.Local).AddTicks(2690), "Paid", "High", "Marmara" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignedTo",
                table: "SampleDatas");

            migrationBuilder.DropColumn(
                name: "Customer",
                table: "SampleDatas");

            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "SampleDatas");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "SampleDatas");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "SampleDatas");

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 25, 9, 38, 30, 624, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 1, 20, 9, 38, 30, 624, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 12, 30, 9, 38, 30, 624, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 11, 30, 9, 38, 30, 624, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2026, 1, 15, 9, 38, 30, 624, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2026, 1, 10, 9, 38, 30, 624, DateTimeKind.Local).AddTicks(2780));
        }
    }
}
