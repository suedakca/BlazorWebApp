using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddBranchInspections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BranchInspections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HasInspectionReport = table.Column<bool>(type: "bit", nullable: false),
                    AuditPeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuditPeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IndividualIdDeficiencies = table.Column<int>(type: "int", nullable: false),
                    PhotoDeficiencies = table.Column<int>(type: "int", nullable: false),
                    PhotoUpToDate = table.Column<int>(type: "int", nullable: false),
                    SignatureDeficiencies = table.Column<int>(type: "int", nullable: false),
                    SignatureUpToDate = table.Column<int>(type: "int", nullable: false),
                    SystemDeficiencies = table.Column<int>(type: "int", nullable: false),
                    SystemUpToDate = table.Column<int>(type: "int", nullable: false),
                    ReceiptDeficiencies = table.Column<int>(type: "int", nullable: false),
                    ReceiptUpToDate = table.Column<int>(type: "int", nullable: false),
                    ReconciliationDeficiencies = table.Column<int>(type: "int", nullable: false),
                    ReconciliationUpToDate = table.Column<int>(type: "int", nullable: false),
                    TotalScore = table.Column<double>(type: "float", nullable: false),
                    RiskScore = table.Column<double>(type: "float", nullable: false),
                    OverallOpinion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCount = table.Column<int>(type: "int", nullable: false),
                    MissingIdCount = table.Column<int>(type: "int", nullable: false),
                    MissingIdExcludingDivit = table.Column<int>(type: "int", nullable: false),
                    CashTransactionCount = table.Column<int>(type: "int", nullable: false),
                    MissingReceiptCount = table.Column<int>(type: "int", nullable: false),
                    ValidReceiptCount = table.Column<int>(type: "int", nullable: false),
                    IsBranchInterviewed = table.Column<bool>(type: "bit", nullable: false),
                    BranchInterviewDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchInspections", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BranchInspections",
                columns: new[] { "Id", "AuditPeriodEnd", "AuditPeriodStart", "BranchCode", "BranchInterviewDate", "BranchName", "BranchType", "CashTransactionCount", "City", "CustomerCount", "HasInspectionReport", "IndividualIdDeficiencies", "IsBranchInterviewed", "MissingIdCount", "MissingIdExcludingDivit", "MissingReceiptCount", "OpeningDate", "OverallOpinion", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "RiskScore", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate", "TaskId", "TotalScore", "ValidReceiptCount" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 2, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2470), new DateTime(2026, 1, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2470), "1001", null, "Ankara Şube 1", "Bireysel", 1020, "Ankara", 510, false, 1, false, 1, 1, 1, new DateTime(2021, 2, 20, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2510), "Gelişime Açık", 1, 99, 1, 199, 1, 9, new DateTime(2026, 2, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2470), 14.0, 1, 99, 1, 49, "TASK-2024-001", 86.5, 999 },
                    { 2, new DateTime(2026, 2, 4, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2530), new DateTime(2026, 1, 4, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2530), "1002", new DateTime(2026, 2, 3, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2530), "İzmir Şube 2", "Bireysel", 1040, "İzmir", 520, true, 2, true, 2, 2, 2, new DateTime(2021, 3, 2, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2540), "Riskli", 2, 98, 2, 198, 0, 10, new DateTime(2026, 2, 4, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2530), 13.0, 2, 98, 0, 50, "TASK-2024-002", 87.5, 998 },
                    { 3, new DateTime(2026, 2, 1, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2540), new DateTime(2026, 1, 1, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2540), "1003", null, "Bursa Şube 3", "Kurumsal", 1060, "Bursa", 530, false, 3, false, 3, 3, 3, new DateTime(2021, 3, 12, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2560), "Kritik", 3, 97, 3, 197, 1, 9, new DateTime(2026, 2, 1, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2540), 12.0, 0, 100, 1, 49, "TASK-2024-003", 88.5, 997 },
                    { 4, new DateTime(2026, 1, 29, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2560), new DateTime(2025, 12, 29, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2560), "1004", new DateTime(2026, 1, 28, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2560), "Antalya Şube 4", "Bireysel", 1080, "Antalya", 540, true, 4, true, 4, 4, 4, new DateTime(2021, 3, 22, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2570), "İyi", 0, 100, 4, 196, 0, 10, new DateTime(2026, 1, 29, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2560), 11.0, 1, 99, 0, 50, "TASK-2024-004", 89.5, 996 },
                    { 5, new DateTime(2026, 1, 26, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2570), new DateTime(2025, 12, 26, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2570), "1005", null, "Adana Şube 5", "Bireysel", 1100, "Adana", 550, false, 0, false, 5, 0, 5, new DateTime(2021, 4, 1, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2580), "Orta", 1, 99, 5, 195, 1, 9, new DateTime(2026, 1, 26, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2570), 10.0, 2, 98, 1, 49, "TASK-2024-005", 90.5, 995 },
                    { 6, new DateTime(2026, 1, 23, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2590), new DateTime(2025, 12, 23, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2590), "1006", new DateTime(2026, 1, 22, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2590), "Konya Şube 6", "Kurumsal", 1120, "Konya", 560, true, 1, true, 6, 1, 6, new DateTime(2021, 4, 11, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2600), "Olumlu", 2, 98, 0, 200, 0, 10, new DateTime(2026, 1, 23, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2590), 9.0, 0, 100, 0, 50, "TASK-2024-006", 91.5, 994 },
                    { 7, new DateTime(2026, 1, 20, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2600), new DateTime(2025, 12, 20, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2600), "1007", null, "Gaziantep Şube 7", "Bireysel", 1140, "Gaziantep", 570, false, 2, false, 7, 2, 7, new DateTime(2021, 4, 21, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2610), "Gelişime Açık", 3, 97, 1, 199, 1, 9, new DateTime(2026, 1, 20, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2600), 8.0, 1, 99, 1, 49, "TASK-2024-007", 92.5, 993 },
                    { 8, new DateTime(2026, 1, 17, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2610), new DateTime(2025, 12, 17, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2610), "1008", new DateTime(2026, 1, 16, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2610), "İstanbul Şube 8", "Bireysel", 1160, "İstanbul", 580, true, 3, true, 8, 3, 0, new DateTime(2021, 5, 1, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2620), "Riskli", 0, 100, 2, 198, 0, 10, new DateTime(2026, 1, 17, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2610), 7.0, 2, 98, 0, 50, "TASK-2024-008", 93.5, 1000 },
                    { 9, new DateTime(2026, 1, 14, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2630), new DateTime(2025, 12, 14, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2630), "1009", null, "Ankara Şube 9", "Kurumsal", 1180, "Ankara", 590, false, 4, false, 9, 4, 1, new DateTime(2021, 5, 11, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2640), "Kritik", 1, 99, 3, 197, 1, 9, new DateTime(2026, 1, 14, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2630), 6.0, 0, 100, 1, 49, "TASK-2024-009", 94.5, 999 },
                    { 10, new DateTime(2026, 1, 11, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2640), new DateTime(2025, 12, 11, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2640), "1010", new DateTime(2026, 1, 10, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2640), "İzmir Şube 10", "Bireysel", 1200, "İzmir", 600, true, 0, true, 0, 0, 2, new DateTime(2021, 5, 21, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2650), "İyi", 2, 98, 4, 196, 0, 10, new DateTime(2026, 1, 11, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2640), 15.0, 1, 99, 0, 50, "TASK-2024-010", 95.5, 998 },
                    { 11, new DateTime(2026, 1, 8, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2660), new DateTime(2025, 12, 8, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2660), "1011", null, "Bursa Şube 11", "Bireysel", 1220, "Bursa", 610, false, 1, false, 1, 1, 3, new DateTime(2021, 5, 31, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2670), "Orta", 3, 97, 5, 195, 1, 9, new DateTime(2026, 1, 8, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2660), 14.0, 2, 98, 1, 49, "TASK-2024-011", 96.5, 997 },
                    { 12, new DateTime(2026, 1, 5, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2670), new DateTime(2025, 12, 5, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2670), "1012", new DateTime(2026, 1, 4, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2670), "Antalya Şube 12", "Kurumsal", 1240, "Antalya", 620, true, 2, true, 2, 2, 4, new DateTime(2021, 6, 10, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2680), "Olumlu", 0, 100, 0, 200, 0, 10, new DateTime(2026, 1, 5, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2670), 13.0, 0, 100, 0, 50, "TASK-2024-012", 97.5, 996 },
                    { 13, new DateTime(2026, 1, 2, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2680), new DateTime(2025, 12, 2, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2680), "1013", null, "Adana Şube 13", "Bireysel", 1260, "Adana", 630, false, 3, false, 3, 3, 5, new DateTime(2021, 6, 20, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2700), "Gelişime Açık", 1, 99, 1, 199, 1, 9, new DateTime(2026, 1, 2, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2680), 12.0, 1, 99, 1, 49, "TASK-2024-013", 98.5, 995 },
                    { 14, new DateTime(2025, 12, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2700), new DateTime(2025, 11, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2700), "1014", new DateTime(2025, 12, 29, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2700), "Konya Şube 14", "Bireysel", 1280, "Konya", 640, true, 4, true, 4, 4, 6, new DateTime(2021, 6, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2710), "Riskli", 2, 98, 2, 198, 0, 10, new DateTime(2025, 12, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2700), 11.0, 2, 98, 0, 50, "TASK-2024-014", 99.5, 994 },
                    { 15, new DateTime(2025, 12, 27, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2710), new DateTime(2025, 11, 27, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2710), "1015", null, "Gaziantep Şube 15", "Kurumsal", 1300, "Gaziantep", 650, false, 0, false, 5, 0, 7, new DateTime(2021, 7, 10, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2720), "Kritik", 3, 97, 3, 197, 1, 9, new DateTime(2025, 12, 27, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2710), 10.0, 0, 100, 1, 49, "TASK-2024-015", 85.5, 993 },
                    { 16, new DateTime(2025, 12, 24, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2730), new DateTime(2025, 11, 24, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2730), "1016", new DateTime(2025, 12, 23, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2730), "İstanbul Şube 16", "Bireysel", 1320, "İstanbul", 660, true, 1, true, 6, 1, 0, new DateTime(2021, 7, 20, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2740), "İyi", 0, 100, 4, 196, 0, 10, new DateTime(2025, 12, 24, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2730), 9.0, 1, 99, 0, 50, "TASK-2024-016", 86.5, 1000 },
                    { 17, new DateTime(2025, 12, 21, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2740), new DateTime(2025, 11, 21, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2740), "1017", null, "Ankara Şube 17", "Bireysel", 1340, "Ankara", 670, false, 2, false, 7, 2, 1, new DateTime(2021, 7, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2750), "Orta", 1, 99, 5, 195, 1, 9, new DateTime(2025, 12, 21, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2740), 8.0, 2, 98, 1, 49, "TASK-2024-017", 87.5, 999 },
                    { 18, new DateTime(2025, 12, 18, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2750), new DateTime(2025, 11, 18, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2750), "1018", new DateTime(2025, 12, 17, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2750), "İzmir Şube 18", "Kurumsal", 1360, "İzmir", 680, true, 3, true, 8, 3, 2, new DateTime(2021, 8, 9, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2760), "Olumlu", 2, 98, 0, 200, 0, 10, new DateTime(2025, 12, 18, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2750), 7.0, 0, 100, 0, 50, "TASK-2024-018", 88.5, 998 },
                    { 19, new DateTime(2025, 12, 15, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2770), new DateTime(2025, 11, 15, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2770), "1019", null, "Bursa Şube 19", "Bireysel", 1380, "Bursa", 690, false, 4, false, 9, 4, 3, new DateTime(2021, 8, 19, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2780), "Gelişime Açık", 3, 97, 1, 199, 1, 9, new DateTime(2025, 12, 15, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2770), 6.0, 1, 99, 1, 49, "TASK-2024-019", 89.5, 997 },
                    { 20, new DateTime(2025, 12, 12, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2780), new DateTime(2025, 11, 12, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2780), "1020", new DateTime(2025, 12, 11, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2780), "Antalya Şube 20", "Bireysel", 1400, "Antalya", 700, true, 0, true, 0, 0, 4, new DateTime(2021, 8, 29, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2790), "Riskli", 0, 100, 2, 198, 0, 10, new DateTime(2025, 12, 12, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2780), 15.0, 2, 98, 0, 50, "TASK-2024-020", 90.5, 996 },
                    { 21, new DateTime(2025, 12, 9, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2790), new DateTime(2025, 11, 9, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2790), "1021", null, "Adana Şube 21", "Kurumsal", 1420, "Adana", 710, false, 1, false, 1, 1, 5, new DateTime(2021, 9, 8, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2800), "Kritik", 1, 99, 3, 197, 1, 9, new DateTime(2025, 12, 9, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2790), 14.0, 0, 100, 1, 49, "TASK-2024-021", 91.5, 995 },
                    { 22, new DateTime(2025, 12, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2810), new DateTime(2025, 11, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2810), "1022", new DateTime(2025, 12, 5, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2810), "Konya Şube 22", "Bireysel", 1440, "Konya", 720, true, 2, true, 2, 2, 6, new DateTime(2021, 9, 18, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2820), "İyi", 2, 98, 4, 196, 0, 10, new DateTime(2025, 12, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2810), 13.0, 1, 99, 0, 50, "TASK-2024-022", 92.5, 994 },
                    { 23, new DateTime(2025, 12, 3, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2890), new DateTime(2025, 11, 3, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2890), "1023", null, "Gaziantep Şube 23", "Bireysel", 1460, "Gaziantep", 730, false, 3, false, 3, 3, 7, new DateTime(2021, 9, 28, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2920), "Orta", 3, 97, 5, 195, 1, 9, new DateTime(2025, 12, 3, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2890), 12.0, 2, 98, 1, 49, "TASK-2024-023", 93.5, 993 },
                    { 24, new DateTime(2025, 11, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2920), new DateTime(2025, 10, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2920), "1024", new DateTime(2025, 11, 29, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2920), "İstanbul Şube 24", "Kurumsal", 1480, "İstanbul", 740, true, 4, true, 4, 4, 0, new DateTime(2021, 10, 8, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2940), "Olumlu", 0, 100, 0, 200, 0, 10, new DateTime(2025, 11, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2920), 11.0, 0, 100, 0, 50, "TASK-2024-024", 94.5, 1000 },
                    { 25, new DateTime(2025, 11, 27, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2940), new DateTime(2025, 10, 27, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2940), "1025", null, "Ankara Şube 25", "Bireysel", 1500, "Ankara", 750, false, 0, false, 5, 0, 1, new DateTime(2021, 10, 18, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2960), "Gelişime Açık", 1, 99, 1, 199, 1, 9, new DateTime(2025, 11, 27, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2940), 10.0, 1, 99, 1, 49, "TASK-2024-025", 95.5, 999 },
                    { 26, new DateTime(2025, 11, 24, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2960), new DateTime(2025, 10, 24, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2960), "1026", new DateTime(2025, 11, 23, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2960), "İzmir Şube 26", "Bireysel", 1520, "İzmir", 760, true, 1, true, 6, 1, 2, new DateTime(2021, 10, 28, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2970), "Riskli", 2, 98, 2, 198, 0, 10, new DateTime(2025, 11, 24, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2960), 9.0, 2, 98, 0, 50, "TASK-2024-026", 96.5, 998 },
                    { 27, new DateTime(2025, 11, 21, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2980), new DateTime(2025, 10, 21, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2980), "1027", null, "Bursa Şube 27", "Kurumsal", 1540, "Bursa", 770, false, 2, false, 7, 2, 3, new DateTime(2021, 11, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2990), "Kritik", 3, 97, 3, 197, 1, 9, new DateTime(2025, 11, 21, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2980), 8.0, 0, 100, 1, 49, "TASK-2024-027", 97.5, 997 },
                    { 28, new DateTime(2025, 11, 18, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2990), new DateTime(2025, 10, 18, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2990), "1028", new DateTime(2025, 11, 17, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2990), "Antalya Şube 28", "Bireysel", 1560, "Antalya", 780, true, 3, true, 8, 3, 4, new DateTime(2021, 11, 17, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3010), "İyi", 0, 100, 4, 196, 0, 10, new DateTime(2025, 11, 18, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2990), 7.0, 1, 99, 0, 50, "TASK-2024-028", 98.5, 996 },
                    { 29, new DateTime(2025, 11, 15, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3010), new DateTime(2025, 10, 15, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3010), "1029", null, "Adana Şube 29", "Bireysel", 1580, "Adana", 790, false, 4, false, 9, 4, 5, new DateTime(2021, 11, 27, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3020), "Orta", 1, 99, 5, 195, 1, 9, new DateTime(2025, 11, 15, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3010), 6.0, 2, 98, 1, 49, "TASK-2024-029", 99.5, 995 },
                    { 30, new DateTime(2025, 11, 12, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3030), new DateTime(2025, 10, 12, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3030), "1030", new DateTime(2025, 11, 11, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3030), "Konya Şube 30", "Kurumsal", 1600, "Konya", 800, true, 0, true, 0, 0, 6, new DateTime(2021, 12, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3040), "Olumlu", 2, 98, 0, 200, 0, 10, new DateTime(2025, 11, 12, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3030), 15.0, 0, 100, 0, 50, "TASK-2024-030", 85.5, 994 },
                    { 31, new DateTime(2025, 11, 9, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3050), new DateTime(2025, 10, 9, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3050), "1031", null, "Gaziantep Şube 31", "Bireysel", 1620, "Gaziantep", 810, false, 1, false, 1, 1, 7, new DateTime(2021, 12, 17, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3060), "Gelişime Açık", 3, 97, 1, 199, 1, 9, new DateTime(2025, 11, 9, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3050), 14.0, 1, 99, 1, 49, "TASK-2024-031", 86.5, 993 },
                    { 32, new DateTime(2025, 11, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3060), new DateTime(2025, 10, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3060), "1032", new DateTime(2025, 11, 5, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3060), "İstanbul Şube 32", "Bireysel", 1640, "İstanbul", 820, true, 2, true, 2, 2, 0, new DateTime(2021, 12, 27, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3080), "Riskli", 0, 100, 2, 198, 0, 10, new DateTime(2025, 11, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3060), 13.0, 2, 98, 0, 50, "TASK-2024-032", 87.5, 1000 },
                    { 33, new DateTime(2025, 11, 3, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3080), new DateTime(2025, 10, 3, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3080), "1033", null, "Ankara Şube 33", "Kurumsal", 1660, "Ankara", 830, false, 3, false, 3, 3, 1, new DateTime(2022, 1, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3100), "Kritik", 1, 99, 3, 197, 1, 9, new DateTime(2025, 11, 3, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3080), 12.0, 0, 100, 1, 49, "TASK-2024-033", 88.5, 999 },
                    { 34, new DateTime(2025, 10, 31, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3100), new DateTime(2025, 9, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3100), "1034", new DateTime(2025, 10, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3100), "İzmir Şube 34", "Bireysel", 1680, "İzmir", 840, true, 4, true, 4, 4, 2, new DateTime(2022, 1, 16, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3110), "İyi", 2, 98, 4, 196, 0, 10, new DateTime(2025, 10, 31, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3100), 11.0, 1, 99, 0, 50, "TASK-2024-034", 89.5, 998 },
                    { 35, new DateTime(2025, 10, 28, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3120), new DateTime(2025, 9, 28, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3120), "1035", null, "Bursa Şube 35", "Bireysel", 1700, "Bursa", 850, false, 0, false, 5, 0, 3, new DateTime(2022, 1, 26, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3130), "Orta", 3, 97, 5, 195, 1, 9, new DateTime(2025, 10, 28, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3120), 10.0, 2, 98, 1, 49, "TASK-2024-035", 90.5, 997 },
                    { 36, new DateTime(2025, 10, 25, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3130), new DateTime(2025, 9, 25, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3130), "1036", new DateTime(2025, 10, 24, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3130), "Antalya Şube 36", "Kurumsal", 1720, "Antalya", 860, true, 1, true, 6, 1, 4, new DateTime(2022, 2, 5, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3150), "Olumlu", 0, 100, 0, 200, 0, 10, new DateTime(2025, 10, 25, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3130), 9.0, 0, 100, 0, 50, "TASK-2024-036", 91.5, 996 },
                    { 37, new DateTime(2025, 10, 22, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3160), new DateTime(2025, 9, 22, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3160), "1037", null, "Adana Şube 37", "Bireysel", 1740, "Adana", 870, false, 2, false, 7, 2, 5, new DateTime(2022, 2, 15, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3170), "Gelişime Açık", 1, 99, 1, 199, 1, 9, new DateTime(2025, 10, 22, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3160), 8.0, 1, 99, 1, 49, "TASK-2024-037", 92.5, 995 },
                    { 38, new DateTime(2025, 10, 19, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3170), new DateTime(2025, 9, 19, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3170), "1038", new DateTime(2025, 10, 18, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3170), "Konya Şube 38", "Bireysel", 1760, "Konya", 880, true, 3, true, 8, 3, 6, new DateTime(2022, 2, 25, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3190), "Riskli", 2, 98, 2, 198, 0, 10, new DateTime(2025, 10, 19, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3170), 7.0, 2, 98, 0, 50, "TASK-2024-038", 93.5, 994 },
                    { 39, new DateTime(2025, 10, 16, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3190), new DateTime(2025, 9, 16, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3190), "1039", null, "Gaziantep Şube 39", "Kurumsal", 1780, "Gaziantep", 890, false, 4, false, 9, 4, 7, new DateTime(2022, 3, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3200), "Kritik", 3, 97, 3, 197, 1, 9, new DateTime(2025, 10, 16, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3190), 6.0, 0, 100, 1, 49, "TASK-2024-039", 94.5, 993 },
                    { 40, new DateTime(2025, 10, 13, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3210), new DateTime(2025, 9, 13, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3210), "1040", new DateTime(2025, 10, 12, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3210), "İstanbul Şube 40", "Bireysel", 1800, "İstanbul", 900, true, 0, true, 0, 0, 0, new DateTime(2022, 3, 17, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3220), "İyi", 0, 100, 4, 196, 0, 10, new DateTime(2025, 10, 13, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3210), 15.0, 1, 99, 0, 50, "TASK-2024-040", 95.5, 1000 },
                    { 41, new DateTime(2025, 10, 10, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3220), new DateTime(2025, 9, 10, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3220), "1041", null, "Ankara Şube 41", "Bireysel", 1820, "Ankara", 910, false, 1, false, 1, 1, 1, new DateTime(2022, 3, 27, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3230), "Orta", 1, 99, 5, 195, 1, 9, new DateTime(2025, 10, 10, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3220), 14.0, 2, 98, 1, 49, "TASK-2024-041", 96.5, 999 },
                    { 42, new DateTime(2025, 10, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3240), new DateTime(2025, 9, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3240), "1042", new DateTime(2025, 10, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3240), "İzmir Şube 42", "Kurumsal", 1840, "İzmir", 920, true, 2, true, 2, 2, 2, new DateTime(2022, 4, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3250), "Olumlu", 2, 98, 0, 200, 0, 10, new DateTime(2025, 10, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3240), 13.0, 0, 100, 0, 50, "TASK-2024-042", 97.5, 998 },
                    { 43, new DateTime(2025, 10, 4, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3250), new DateTime(2025, 9, 4, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3250), "1043", null, "Bursa Şube 43", "Bireysel", 1860, "Bursa", 930, false, 3, false, 3, 3, 3, new DateTime(2022, 4, 16, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3260), "Gelişime Açık", 3, 97, 1, 199, 1, 9, new DateTime(2025, 10, 4, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3250), 12.0, 1, 99, 1, 49, "TASK-2024-043", 98.5, 997 },
                    { 44, new DateTime(2025, 10, 1, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3260), new DateTime(2025, 9, 1, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3260), "1044", new DateTime(2025, 9, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3260), "Antalya Şube 44", "Bireysel", 1880, "Antalya", 940, true, 4, true, 4, 4, 4, new DateTime(2022, 4, 26, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3270), "Riskli", 0, 100, 2, 198, 0, 10, new DateTime(2025, 10, 1, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3260), 11.0, 2, 98, 0, 50, "TASK-2024-044", 99.5, 996 },
                    { 45, new DateTime(2025, 9, 28, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3280), new DateTime(2025, 8, 28, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3280), "1045", null, "Adana Şube 45", "Kurumsal", 1900, "Adana", 950, false, 0, false, 5, 0, 5, new DateTime(2022, 5, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3290), "Kritik", 1, 99, 3, 197, 1, 9, new DateTime(2025, 9, 28, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3280), 10.0, 0, 100, 1, 49, "TASK-2024-045", 85.5, 995 },
                    { 46, new DateTime(2025, 9, 25, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3290), new DateTime(2025, 8, 25, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3290), "1046", new DateTime(2025, 9, 24, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3290), "Konya Şube 46", "Bireysel", 1920, "Konya", 960, true, 1, true, 6, 1, 6, new DateTime(2022, 5, 16, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3300), "İyi", 2, 98, 4, 196, 0, 10, new DateTime(2025, 9, 25, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3290), 9.0, 1, 99, 0, 50, "TASK-2024-046", 86.5, 994 },
                    { 47, new DateTime(2025, 9, 22, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3300), new DateTime(2025, 8, 22, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3300), "1047", null, "Gaziantep Şube 47", "Bireysel", 1940, "Gaziantep", 970, false, 2, false, 7, 2, 7, new DateTime(2022, 5, 26, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3310), "Orta", 3, 97, 5, 195, 1, 9, new DateTime(2025, 9, 22, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3300), 8.0, 2, 98, 1, 49, "TASK-2024-047", 87.5, 993 },
                    { 48, new DateTime(2025, 9, 19, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3320), new DateTime(2025, 8, 19, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3320), "1048", new DateTime(2025, 9, 18, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3320), "İstanbul Şube 48", "Kurumsal", 1960, "İstanbul", 980, true, 3, true, 8, 3, 0, new DateTime(2022, 6, 5, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3330), "Olumlu", 0, 100, 0, 200, 0, 10, new DateTime(2025, 9, 19, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3320), 7.0, 0, 100, 0, 50, "TASK-2024-048", 88.5, 1000 },
                    { 49, new DateTime(2025, 9, 16, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3330), new DateTime(2025, 8, 16, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3330), "1049", null, "Ankara Şube 49", "Bireysel", 1980, "Ankara", 990, false, 4, false, 9, 4, 1, new DateTime(2022, 6, 15, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3340), "Gelişime Açık", 1, 99, 1, 199, 1, 9, new DateTime(2025, 9, 16, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3330), 6.0, 1, 99, 1, 49, "TASK-2024-049", 89.5, 999 },
                    { 50, new DateTime(2025, 9, 13, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3340), new DateTime(2025, 8, 13, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3340), "1050", new DateTime(2025, 9, 12, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3340), "İzmir Şube 50", "Bireysel", 2000, "İzmir", 1000, true, 0, true, 0, 0, 2, new DateTime(2022, 6, 25, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3360), "Riskli", 2, 98, 2, 198, 0, 10, new DateTime(2025, 9, 13, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3340), 15.0, 2, 98, 0, 50, "TASK-2024-050", 90.5, 998 }
                });

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 2, 9, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 2, 8, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2026, 2, 7, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2026, 2, 6, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2026, 2, 5, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2026, 2, 4, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2026, 2, 3, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2026, 2, 2, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2026, 2, 1, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2026, 1, 31, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2026, 1, 30, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2026, 1, 29, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2026, 1, 28, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2026, 1, 27, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2026, 1, 26, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2026, 1, 25, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2026, 1, 24, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2026, 1, 23, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2026, 1, 22, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2026, 1, 21, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2026, 1, 20, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2026, 1, 19, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2026, 1, 18, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2026, 1, 17, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2026, 1, 16, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2026, 1, 15, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2026, 1, 14, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2026, 1, 13, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2026, 1, 12, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2026, 1, 11, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2026, 1, 10, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2026, 1, 9, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 33,
                column: "Date",
                value: new DateTime(2026, 1, 8, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 34,
                column: "Date",
                value: new DateTime(2026, 1, 7, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 35,
                column: "Date",
                value: new DateTime(2026, 1, 6, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2026, 1, 5, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 37,
                column: "Date",
                value: new DateTime(2026, 1, 4, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 38,
                column: "Date",
                value: new DateTime(2026, 1, 3, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 39,
                column: "Date",
                value: new DateTime(2026, 1, 2, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 40,
                column: "Date",
                value: new DateTime(2026, 1, 1, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 41,
                column: "Date",
                value: new DateTime(2025, 12, 31, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 42,
                column: "Date",
                value: new DateTime(2025, 12, 30, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 43,
                column: "Date",
                value: new DateTime(2025, 12, 29, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 44,
                column: "Date",
                value: new DateTime(2025, 12, 28, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 45,
                column: "Date",
                value: new DateTime(2025, 12, 27, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 46,
                column: "Date",
                value: new DateTime(2025, 12, 26, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 47,
                column: "Date",
                value: new DateTime(2025, 12, 25, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 48,
                column: "Date",
                value: new DateTime(2025, 12, 24, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 49,
                column: "Date",
                value: new DateTime(2025, 12, 23, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 50,
                column: "Date",
                value: new DateTime(2025, 12, 22, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 51,
                column: "Date",
                value: new DateTime(2025, 12, 21, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 52,
                column: "Date",
                value: new DateTime(2025, 12, 20, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 53,
                column: "Date",
                value: new DateTime(2025, 12, 19, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 54,
                column: "Date",
                value: new DateTime(2025, 12, 18, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 55,
                column: "Date",
                value: new DateTime(2025, 12, 17, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 56,
                column: "Date",
                value: new DateTime(2025, 12, 16, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 57,
                column: "Date",
                value: new DateTime(2025, 12, 15, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 58,
                column: "Date",
                value: new DateTime(2025, 12, 14, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 59,
                column: "Date",
                value: new DateTime(2025, 12, 13, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 60,
                column: "Date",
                value: new DateTime(2025, 12, 12, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 61,
                column: "Date",
                value: new DateTime(2025, 12, 11, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 62,
                column: "Date",
                value: new DateTime(2025, 12, 10, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 63,
                column: "Date",
                value: new DateTime(2025, 12, 9, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 64,
                column: "Date",
                value: new DateTime(2025, 12, 8, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 65,
                column: "Date",
                value: new DateTime(2025, 12, 7, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 66,
                column: "Date",
                value: new DateTime(2025, 12, 6, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 67,
                column: "Date",
                value: new DateTime(2025, 12, 5, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 68,
                column: "Date",
                value: new DateTime(2025, 12, 4, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 69,
                column: "Date",
                value: new DateTime(2025, 12, 3, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 70,
                column: "Date",
                value: new DateTime(2025, 12, 2, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 71,
                column: "Date",
                value: new DateTime(2025, 12, 1, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 72,
                column: "Date",
                value: new DateTime(2025, 11, 30, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 73,
                column: "Date",
                value: new DateTime(2025, 11, 29, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 74,
                column: "Date",
                value: new DateTime(2025, 11, 28, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 75,
                column: "Date",
                value: new DateTime(2025, 11, 27, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 76,
                column: "Date",
                value: new DateTime(2025, 11, 26, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 77,
                column: "Date",
                value: new DateTime(2025, 11, 25, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 78,
                column: "Date",
                value: new DateTime(2025, 11, 24, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 79,
                column: "Date",
                value: new DateTime(2025, 11, 23, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 80,
                column: "Date",
                value: new DateTime(2025, 11, 22, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 81,
                column: "Date",
                value: new DateTime(2025, 11, 21, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 82,
                column: "Date",
                value: new DateTime(2025, 11, 20, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 83,
                column: "Date",
                value: new DateTime(2025, 11, 19, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 84,
                column: "Date",
                value: new DateTime(2025, 11, 18, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 85,
                column: "Date",
                value: new DateTime(2025, 11, 17, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 86,
                column: "Date",
                value: new DateTime(2025, 11, 16, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 87,
                column: "Date",
                value: new DateTime(2025, 11, 15, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 88,
                column: "Date",
                value: new DateTime(2025, 11, 14, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 89,
                column: "Date",
                value: new DateTime(2025, 11, 13, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 90,
                column: "Date",
                value: new DateTime(2025, 11, 12, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 91,
                column: "Date",
                value: new DateTime(2025, 11, 11, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 92,
                column: "Date",
                value: new DateTime(2025, 11, 10, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 93,
                column: "Date",
                value: new DateTime(2025, 11, 9, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 94,
                column: "Date",
                value: new DateTime(2025, 11, 8, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 95,
                column: "Date",
                value: new DateTime(2025, 11, 7, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 96,
                column: "Date",
                value: new DateTime(2025, 11, 6, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 97,
                column: "Date",
                value: new DateTime(2025, 11, 5, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 98,
                column: "Date",
                value: new DateTime(2025, 11, 4, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 99,
                column: "Date",
                value: new DateTime(2025, 11, 3, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 100,
                column: "Date",
                value: new DateTime(2025, 11, 2, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 101,
                column: "Date",
                value: new DateTime(2025, 11, 1, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 102,
                column: "Date",
                value: new DateTime(2025, 10, 31, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 103,
                column: "Date",
                value: new DateTime(2025, 10, 30, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 104,
                column: "Date",
                value: new DateTime(2025, 10, 29, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 105,
                column: "Date",
                value: new DateTime(2025, 10, 28, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 106,
                column: "Date",
                value: new DateTime(2025, 10, 27, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 107,
                column: "Date",
                value: new DateTime(2025, 10, 26, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 108,
                column: "Date",
                value: new DateTime(2025, 10, 25, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 109,
                column: "Date",
                value: new DateTime(2025, 10, 24, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 110,
                column: "Date",
                value: new DateTime(2025, 10, 23, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 111,
                column: "Date",
                value: new DateTime(2025, 10, 22, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 112,
                column: "Date",
                value: new DateTime(2025, 10, 21, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 113,
                column: "Date",
                value: new DateTime(2025, 10, 20, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 114,
                column: "Date",
                value: new DateTime(2025, 10, 19, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 115,
                column: "Date",
                value: new DateTime(2025, 10, 18, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 116,
                column: "Date",
                value: new DateTime(2025, 10, 17, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 117,
                column: "Date",
                value: new DateTime(2025, 10, 16, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 118,
                column: "Date",
                value: new DateTime(2025, 10, 15, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 119,
                column: "Date",
                value: new DateTime(2025, 10, 14, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 120,
                column: "Date",
                value: new DateTime(2025, 10, 13, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 121,
                column: "Date",
                value: new DateTime(2025, 10, 12, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 122,
                column: "Date",
                value: new DateTime(2025, 10, 11, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 123,
                column: "Date",
                value: new DateTime(2025, 10, 10, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 124,
                column: "Date",
                value: new DateTime(2025, 10, 9, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 125,
                column: "Date",
                value: new DateTime(2025, 10, 8, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 126,
                column: "Date",
                value: new DateTime(2025, 10, 7, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 127,
                column: "Date",
                value: new DateTime(2025, 10, 6, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 128,
                column: "Date",
                value: new DateTime(2025, 10, 5, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 129,
                column: "Date",
                value: new DateTime(2025, 10, 4, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 130,
                column: "Date",
                value: new DateTime(2025, 10, 3, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 131,
                column: "Date",
                value: new DateTime(2025, 10, 2, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 132,
                column: "Date",
                value: new DateTime(2025, 10, 1, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 133,
                column: "Date",
                value: new DateTime(2025, 9, 30, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 134,
                column: "Date",
                value: new DateTime(2025, 9, 29, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 135,
                column: "Date",
                value: new DateTime(2025, 9, 28, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 136,
                column: "Date",
                value: new DateTime(2025, 9, 27, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 137,
                column: "Date",
                value: new DateTime(2025, 9, 26, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 138,
                column: "Date",
                value: new DateTime(2025, 9, 25, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 139,
                column: "Date",
                value: new DateTime(2025, 9, 24, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 140,
                column: "Date",
                value: new DateTime(2025, 9, 23, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 141,
                column: "Date",
                value: new DateTime(2025, 9, 22, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 142,
                column: "Date",
                value: new DateTime(2025, 9, 21, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 143,
                column: "Date",
                value: new DateTime(2025, 9, 20, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 144,
                column: "Date",
                value: new DateTime(2025, 9, 19, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 145,
                column: "Date",
                value: new DateTime(2025, 9, 18, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 146,
                column: "Date",
                value: new DateTime(2025, 9, 17, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 147,
                column: "Date",
                value: new DateTime(2025, 9, 16, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 148,
                column: "Date",
                value: new DateTime(2025, 9, 15, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 149,
                column: "Date",
                value: new DateTime(2025, 9, 14, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 150,
                column: "Date",
                value: new DateTime(2025, 9, 13, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 151,
                column: "Date",
                value: new DateTime(2025, 9, 12, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 152,
                column: "Date",
                value: new DateTime(2025, 9, 11, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 153,
                column: "Date",
                value: new DateTime(2025, 9, 10, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 154,
                column: "Date",
                value: new DateTime(2025, 9, 9, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 155,
                column: "Date",
                value: new DateTime(2025, 9, 8, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 156,
                column: "Date",
                value: new DateTime(2025, 9, 7, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 157,
                column: "Date",
                value: new DateTime(2025, 9, 6, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 158,
                column: "Date",
                value: new DateTime(2025, 9, 5, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 159,
                column: "Date",
                value: new DateTime(2025, 9, 4, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 160,
                column: "Date",
                value: new DateTime(2025, 9, 3, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 161,
                column: "Date",
                value: new DateTime(2025, 9, 2, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 162,
                column: "Date",
                value: new DateTime(2025, 9, 1, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 163,
                column: "Date",
                value: new DateTime(2025, 8, 31, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 164,
                column: "Date",
                value: new DateTime(2025, 8, 30, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 165,
                column: "Date",
                value: new DateTime(2025, 8, 29, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 166,
                column: "Date",
                value: new DateTime(2025, 8, 28, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 167,
                column: "Date",
                value: new DateTime(2025, 8, 27, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 168,
                column: "Date",
                value: new DateTime(2025, 8, 26, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 169,
                column: "Date",
                value: new DateTime(2025, 8, 25, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 170,
                column: "Date",
                value: new DateTime(2025, 8, 24, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 171,
                column: "Date",
                value: new DateTime(2025, 8, 23, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 172,
                column: "Date",
                value: new DateTime(2025, 8, 22, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 173,
                column: "Date",
                value: new DateTime(2025, 8, 21, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 174,
                column: "Date",
                value: new DateTime(2025, 8, 20, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 175,
                column: "Date",
                value: new DateTime(2025, 8, 19, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 176,
                column: "Date",
                value: new DateTime(2025, 8, 18, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 177,
                column: "Date",
                value: new DateTime(2025, 8, 17, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 178,
                column: "Date",
                value: new DateTime(2025, 8, 16, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 179,
                column: "Date",
                value: new DateTime(2025, 8, 15, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 180,
                column: "Date",
                value: new DateTime(2025, 8, 14, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 181,
                column: "Date",
                value: new DateTime(2025, 8, 13, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 182,
                column: "Date",
                value: new DateTime(2025, 8, 12, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 183,
                column: "Date",
                value: new DateTime(2025, 8, 11, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 184,
                column: "Date",
                value: new DateTime(2025, 8, 10, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 185,
                column: "Date",
                value: new DateTime(2025, 8, 9, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 186,
                column: "Date",
                value: new DateTime(2025, 8, 8, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 187,
                column: "Date",
                value: new DateTime(2025, 8, 7, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 188,
                column: "Date",
                value: new DateTime(2025, 8, 6, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 189,
                column: "Date",
                value: new DateTime(2025, 8, 5, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 190,
                column: "Date",
                value: new DateTime(2025, 8, 4, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 191,
                column: "Date",
                value: new DateTime(2025, 8, 3, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 192,
                column: "Date",
                value: new DateTime(2025, 8, 2, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 193,
                column: "Date",
                value: new DateTime(2025, 8, 1, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 194,
                column: "Date",
                value: new DateTime(2025, 7, 31, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 195,
                column: "Date",
                value: new DateTime(2025, 7, 30, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 196,
                column: "Date",
                value: new DateTime(2025, 7, 29, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 197,
                column: "Date",
                value: new DateTime(2025, 7, 28, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 198,
                column: "Date",
                value: new DateTime(2025, 7, 27, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 199,
                column: "Date",
                value: new DateTime(2025, 7, 26, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 200,
                column: "Date",
                value: new DateTime(2025, 7, 25, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2026, 3, 15, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2026, 5, 14, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2026, 3, 20, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 4,
                column: "DueDate",
                value: new DateTime(2026, 5, 19, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 5,
                column: "DueDate",
                value: new DateTime(2026, 3, 25, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 6,
                column: "DueDate",
                value: new DateTime(2026, 5, 24, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 7,
                column: "DueDate",
                value: new DateTime(2026, 3, 31, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 8,
                column: "DueDate",
                value: new DateTime(2026, 5, 30, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 9,
                column: "DueDate",
                value: new DateTime(2026, 4, 5, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 10,
                column: "DueDate",
                value: new DateTime(2026, 6, 4, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 11,
                column: "DueDate",
                value: new DateTime(2026, 4, 10, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 12,
                column: "DueDate",
                value: new DateTime(2026, 6, 9, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 13,
                column: "DueDate",
                value: new DateTime(2026, 4, 15, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 14,
                column: "DueDate",
                value: new DateTime(2026, 2, 19, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 15,
                column: "DueDate",
                value: new DateTime(2026, 4, 20, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 16,
                column: "DueDate",
                value: new DateTime(2026, 2, 24, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 17,
                column: "DueDate",
                value: new DateTime(2026, 4, 25, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 18,
                column: "DueDate",
                value: new DateTime(2026, 3, 1, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 19,
                column: "DueDate",
                value: new DateTime(2026, 5, 1, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 20,
                column: "DueDate",
                value: new DateTime(2026, 3, 7, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 21,
                column: "DueDate",
                value: new DateTime(2026, 5, 6, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 22,
                column: "DueDate",
                value: new DateTime(2026, 3, 12, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 23,
                column: "DueDate",
                value: new DateTime(2026, 5, 11, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 24,
                column: "DueDate",
                value: new DateTime(2026, 3, 17, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 25,
                column: "DueDate",
                value: new DateTime(2026, 5, 16, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 26,
                column: "DueDate",
                value: new DateTime(2026, 3, 22, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 27,
                column: "DueDate",
                value: new DateTime(2026, 5, 21, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 28,
                column: "DueDate",
                value: new DateTime(2026, 3, 27, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 29,
                column: "DueDate",
                value: new DateTime(2026, 5, 26, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 30,
                column: "DueDate",
                value: new DateTime(2026, 4, 1, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 31,
                column: "DueDate",
                value: new DateTime(2026, 5, 31, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 32,
                column: "DueDate",
                value: new DateTime(2026, 4, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 33,
                column: "DueDate",
                value: new DateTime(2026, 6, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 34,
                column: "DueDate",
                value: new DateTime(2026, 4, 12, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 35,
                column: "DueDate",
                value: new DateTime(2026, 2, 16, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 36,
                column: "DueDate",
                value: new DateTime(2026, 4, 17, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 37,
                column: "DueDate",
                value: new DateTime(2026, 2, 21, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 38,
                column: "DueDate",
                value: new DateTime(2026, 4, 22, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 39,
                column: "DueDate",
                value: new DateTime(2026, 2, 26, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 40,
                column: "DueDate",
                value: new DateTime(2026, 4, 27, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 41,
                column: "DueDate",
                value: new DateTime(2026, 3, 3, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 42,
                column: "DueDate",
                value: new DateTime(2026, 5, 2, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 43,
                column: "DueDate",
                value: new DateTime(2026, 3, 8, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 44,
                column: "DueDate",
                value: new DateTime(2026, 5, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 45,
                column: "DueDate",
                value: new DateTime(2026, 3, 14, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 46,
                column: "DueDate",
                value: new DateTime(2026, 5, 13, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 47,
                column: "DueDate",
                value: new DateTime(2026, 3, 19, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 48,
                column: "DueDate",
                value: new DateTime(2026, 5, 18, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 49,
                column: "DueDate",
                value: new DateTime(2026, 3, 24, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 50,
                column: "DueDate",
                value: new DateTime(2026, 5, 23, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 51,
                column: "DueDate",
                value: new DateTime(2026, 3, 29, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 52,
                column: "DueDate",
                value: new DateTime(2026, 5, 28, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 53,
                column: "DueDate",
                value: new DateTime(2026, 4, 3, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 54,
                column: "DueDate",
                value: new DateTime(2026, 6, 2, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 55,
                column: "DueDate",
                value: new DateTime(2026, 4, 8, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 56,
                column: "DueDate",
                value: new DateTime(2026, 6, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 57,
                column: "DueDate",
                value: new DateTime(2026, 4, 14, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 58,
                column: "DueDate",
                value: new DateTime(2026, 2, 18, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 59,
                column: "DueDate",
                value: new DateTime(2026, 4, 19, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 60,
                column: "DueDate",
                value: new DateTime(2026, 2, 23, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 61,
                column: "DueDate",
                value: new DateTime(2026, 4, 24, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 62,
                column: "DueDate",
                value: new DateTime(2026, 2, 28, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 63,
                column: "DueDate",
                value: new DateTime(2026, 4, 29, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 64,
                column: "DueDate",
                value: new DateTime(2026, 3, 5, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 65,
                column: "DueDate",
                value: new DateTime(2026, 5, 4, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 66,
                column: "DueDate",
                value: new DateTime(2026, 3, 10, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 67,
                column: "DueDate",
                value: new DateTime(2026, 5, 9, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 68,
                column: "DueDate",
                value: new DateTime(2026, 3, 15, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 69,
                column: "DueDate",
                value: new DateTime(2026, 5, 14, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 70,
                column: "DueDate",
                value: new DateTime(2026, 3, 21, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 71,
                column: "DueDate",
                value: new DateTime(2026, 5, 20, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 72,
                column: "DueDate",
                value: new DateTime(2026, 3, 26, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 73,
                column: "DueDate",
                value: new DateTime(2026, 5, 25, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 74,
                column: "DueDate",
                value: new DateTime(2026, 3, 31, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 75,
                column: "DueDate",
                value: new DateTime(2026, 5, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 76,
                column: "DueDate",
                value: new DateTime(2026, 4, 5, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 77,
                column: "DueDate",
                value: new DateTime(2026, 6, 4, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 78,
                column: "DueDate",
                value: new DateTime(2026, 4, 10, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 79,
                column: "DueDate",
                value: new DateTime(2026, 6, 9, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 80,
                column: "DueDate",
                value: new DateTime(2026, 4, 15, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 81,
                column: "DueDate",
                value: new DateTime(2026, 2, 19, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 82,
                column: "DueDate",
                value: new DateTime(2026, 4, 20, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 83,
                column: "DueDate",
                value: new DateTime(2026, 2, 25, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 84,
                column: "DueDate",
                value: new DateTime(2026, 4, 26, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 85,
                column: "DueDate",
                value: new DateTime(2026, 3, 2, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 86,
                column: "DueDate",
                value: new DateTime(2026, 5, 1, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 87,
                column: "DueDate",
                value: new DateTime(2026, 3, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 88,
                column: "DueDate",
                value: new DateTime(2026, 5, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 89,
                column: "DueDate",
                value: new DateTime(2026, 3, 12, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 90,
                column: "DueDate",
                value: new DateTime(2026, 5, 11, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 91,
                column: "DueDate",
                value: new DateTime(2026, 3, 17, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 92,
                column: "DueDate",
                value: new DateTime(2026, 5, 16, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 93,
                column: "DueDate",
                value: new DateTime(2026, 3, 22, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 94,
                column: "DueDate",
                value: new DateTime(2026, 5, 21, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 95,
                column: "DueDate",
                value: new DateTime(2026, 3, 28, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 96,
                column: "DueDate",
                value: new DateTime(2026, 5, 27, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 97,
                column: "DueDate",
                value: new DateTime(2026, 4, 2, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 98,
                column: "DueDate",
                value: new DateTime(2026, 6, 1, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 99,
                column: "DueDate",
                value: new DateTime(2026, 4, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 100,
                column: "DueDate",
                value: new DateTime(2026, 6, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 2, 5, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 1, 31, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2026, 1, 10, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 12, 10, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2026, 1, 26, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2026, 1, 21, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2026, 2, 7, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2026, 2, 3, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2026, 1, 10, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2026, 1, 29, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 11, 10, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2026, 2, 6, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2026, 1, 28, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2026, 1, 27, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2026, 1, 26, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2026, 1, 25, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2026, 1, 24, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2026, 1, 23, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2026, 1, 22, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2026, 1, 21, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2026, 1, 20, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2026, 1, 19, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2026, 1, 18, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2026, 1, 17, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2026, 1, 16, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2026, 1, 15, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2026, 1, 14, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2026, 1, 13, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2026, 1, 12, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2026, 1, 11, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2026, 1, 10, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2026, 1, 9, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 33,
                column: "Date",
                value: new DateTime(2026, 1, 8, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 34,
                column: "Date",
                value: new DateTime(2026, 1, 7, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 35,
                column: "Date",
                value: new DateTime(2026, 1, 6, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2026, 1, 5, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 37,
                column: "Date",
                value: new DateTime(2026, 1, 4, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 38,
                column: "Date",
                value: new DateTime(2026, 1, 3, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 39,
                column: "Date",
                value: new DateTime(2026, 1, 2, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 40,
                column: "Date",
                value: new DateTime(2026, 1, 1, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 41,
                column: "Date",
                value: new DateTime(2025, 12, 31, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 42,
                column: "Date",
                value: new DateTime(2025, 12, 30, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 43,
                column: "Date",
                value: new DateTime(2025, 12, 29, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 44,
                column: "Date",
                value: new DateTime(2025, 12, 28, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 45,
                column: "Date",
                value: new DateTime(2025, 12, 27, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 46,
                column: "Date",
                value: new DateTime(2025, 12, 26, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 47,
                column: "Date",
                value: new DateTime(2025, 12, 25, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 48,
                column: "Date",
                value: new DateTime(2025, 12, 24, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 49,
                column: "Date",
                value: new DateTime(2025, 12, 23, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 50,
                column: "Date",
                value: new DateTime(2025, 12, 22, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 51,
                column: "Date",
                value: new DateTime(2025, 12, 21, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 52,
                column: "Date",
                value: new DateTime(2025, 12, 20, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 53,
                column: "Date",
                value: new DateTime(2025, 12, 19, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 54,
                column: "Date",
                value: new DateTime(2025, 12, 18, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 55,
                column: "Date",
                value: new DateTime(2025, 12, 17, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 56,
                column: "Date",
                value: new DateTime(2025, 12, 16, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 57,
                column: "Date",
                value: new DateTime(2025, 12, 15, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 58,
                column: "Date",
                value: new DateTime(2025, 12, 14, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 59,
                column: "Date",
                value: new DateTime(2025, 12, 13, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 60,
                column: "Date",
                value: new DateTime(2025, 12, 12, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 61,
                column: "Date",
                value: new DateTime(2025, 12, 11, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 62,
                column: "Date",
                value: new DateTime(2025, 12, 10, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 63,
                column: "Date",
                value: new DateTime(2025, 12, 9, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 64,
                column: "Date",
                value: new DateTime(2025, 12, 8, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 65,
                column: "Date",
                value: new DateTime(2025, 12, 7, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 66,
                column: "Date",
                value: new DateTime(2025, 12, 6, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 67,
                column: "Date",
                value: new DateTime(2025, 12, 5, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 68,
                column: "Date",
                value: new DateTime(2025, 12, 4, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 69,
                column: "Date",
                value: new DateTime(2025, 12, 3, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 70,
                column: "Date",
                value: new DateTime(2025, 12, 2, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 71,
                column: "Date",
                value: new DateTime(2025, 12, 1, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 72,
                column: "Date",
                value: new DateTime(2025, 11, 30, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 73,
                column: "Date",
                value: new DateTime(2025, 11, 29, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 74,
                column: "Date",
                value: new DateTime(2025, 11, 28, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 75,
                column: "Date",
                value: new DateTime(2025, 11, 27, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 76,
                column: "Date",
                value: new DateTime(2025, 11, 26, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 77,
                column: "Date",
                value: new DateTime(2025, 11, 25, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 78,
                column: "Date",
                value: new DateTime(2025, 11, 24, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 79,
                column: "Date",
                value: new DateTime(2025, 11, 23, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 80,
                column: "Date",
                value: new DateTime(2025, 11, 22, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 81,
                column: "Date",
                value: new DateTime(2025, 11, 21, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 82,
                column: "Date",
                value: new DateTime(2025, 11, 20, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 83,
                column: "Date",
                value: new DateTime(2025, 11, 19, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 84,
                column: "Date",
                value: new DateTime(2025, 11, 18, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 85,
                column: "Date",
                value: new DateTime(2025, 11, 17, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 86,
                column: "Date",
                value: new DateTime(2025, 11, 16, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 87,
                column: "Date",
                value: new DateTime(2025, 11, 15, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 88,
                column: "Date",
                value: new DateTime(2025, 11, 14, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 89,
                column: "Date",
                value: new DateTime(2025, 11, 13, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 90,
                column: "Date",
                value: new DateTime(2025, 11, 12, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 91,
                column: "Date",
                value: new DateTime(2025, 11, 11, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 92,
                column: "Date",
                value: new DateTime(2025, 11, 10, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 93,
                column: "Date",
                value: new DateTime(2025, 11, 9, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 94,
                column: "Date",
                value: new DateTime(2025, 11, 8, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 95,
                column: "Date",
                value: new DateTime(2025, 11, 7, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 96,
                column: "Date",
                value: new DateTime(2025, 11, 6, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 97,
                column: "Date",
                value: new DateTime(2025, 11, 5, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 98,
                column: "Date",
                value: new DateTime(2025, 11, 4, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 99,
                column: "Date",
                value: new DateTime(2025, 11, 3, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 100,
                column: "Date",
                value: new DateTime(2025, 11, 2, 10, 15, 30, 536, DateTimeKind.Local).AddTicks(6410));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BranchInspections");

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 2, 4, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 2, 3, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2026, 2, 2, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2026, 2, 1, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2026, 1, 31, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2026, 1, 30, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2026, 1, 29, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2026, 1, 28, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2026, 1, 27, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2026, 1, 26, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2026, 1, 25, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2026, 1, 24, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2026, 1, 23, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2026, 1, 22, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2026, 1, 21, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2026, 1, 20, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2026, 1, 19, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2026, 1, 18, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2026, 1, 17, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2026, 1, 16, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2026, 1, 15, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2026, 1, 14, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2026, 1, 13, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2026, 1, 12, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2026, 1, 11, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2026, 1, 10, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2026, 1, 9, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2026, 1, 8, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2026, 1, 7, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2026, 1, 6, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2026, 1, 5, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2026, 1, 4, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 33,
                column: "Date",
                value: new DateTime(2026, 1, 3, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 34,
                column: "Date",
                value: new DateTime(2026, 1, 2, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 35,
                column: "Date",
                value: new DateTime(2026, 1, 1, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2025, 12, 31, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 37,
                column: "Date",
                value: new DateTime(2025, 12, 30, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 38,
                column: "Date",
                value: new DateTime(2025, 12, 29, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 39,
                column: "Date",
                value: new DateTime(2025, 12, 28, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 40,
                column: "Date",
                value: new DateTime(2025, 12, 27, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 41,
                column: "Date",
                value: new DateTime(2025, 12, 26, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 42,
                column: "Date",
                value: new DateTime(2025, 12, 25, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 43,
                column: "Date",
                value: new DateTime(2025, 12, 24, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 44,
                column: "Date",
                value: new DateTime(2025, 12, 23, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 45,
                column: "Date",
                value: new DateTime(2025, 12, 22, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 46,
                column: "Date",
                value: new DateTime(2025, 12, 21, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 47,
                column: "Date",
                value: new DateTime(2025, 12, 20, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 48,
                column: "Date",
                value: new DateTime(2025, 12, 19, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 49,
                column: "Date",
                value: new DateTime(2025, 12, 18, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 50,
                column: "Date",
                value: new DateTime(2025, 12, 17, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 51,
                column: "Date",
                value: new DateTime(2025, 12, 16, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 52,
                column: "Date",
                value: new DateTime(2025, 12, 15, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 53,
                column: "Date",
                value: new DateTime(2025, 12, 14, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 54,
                column: "Date",
                value: new DateTime(2025, 12, 13, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 55,
                column: "Date",
                value: new DateTime(2025, 12, 12, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 56,
                column: "Date",
                value: new DateTime(2025, 12, 11, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 57,
                column: "Date",
                value: new DateTime(2025, 12, 10, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 58,
                column: "Date",
                value: new DateTime(2025, 12, 9, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 59,
                column: "Date",
                value: new DateTime(2025, 12, 8, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 60,
                column: "Date",
                value: new DateTime(2025, 12, 7, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 61,
                column: "Date",
                value: new DateTime(2025, 12, 6, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 62,
                column: "Date",
                value: new DateTime(2025, 12, 5, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 63,
                column: "Date",
                value: new DateTime(2025, 12, 4, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 64,
                column: "Date",
                value: new DateTime(2025, 12, 3, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 65,
                column: "Date",
                value: new DateTime(2025, 12, 2, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 66,
                column: "Date",
                value: new DateTime(2025, 12, 1, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 67,
                column: "Date",
                value: new DateTime(2025, 11, 30, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 68,
                column: "Date",
                value: new DateTime(2025, 11, 29, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 69,
                column: "Date",
                value: new DateTime(2025, 11, 28, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 70,
                column: "Date",
                value: new DateTime(2025, 11, 27, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 71,
                column: "Date",
                value: new DateTime(2025, 11, 26, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 72,
                column: "Date",
                value: new DateTime(2025, 11, 25, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 73,
                column: "Date",
                value: new DateTime(2025, 11, 24, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 74,
                column: "Date",
                value: new DateTime(2025, 11, 23, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 75,
                column: "Date",
                value: new DateTime(2025, 11, 22, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 76,
                column: "Date",
                value: new DateTime(2025, 11, 21, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 77,
                column: "Date",
                value: new DateTime(2025, 11, 20, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 78,
                column: "Date",
                value: new DateTime(2025, 11, 19, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 79,
                column: "Date",
                value: new DateTime(2025, 11, 18, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 80,
                column: "Date",
                value: new DateTime(2025, 11, 17, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 81,
                column: "Date",
                value: new DateTime(2025, 11, 16, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 82,
                column: "Date",
                value: new DateTime(2025, 11, 15, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 83,
                column: "Date",
                value: new DateTime(2025, 11, 14, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 84,
                column: "Date",
                value: new DateTime(2025, 11, 13, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 85,
                column: "Date",
                value: new DateTime(2025, 11, 12, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 86,
                column: "Date",
                value: new DateTime(2025, 11, 11, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 87,
                column: "Date",
                value: new DateTime(2025, 11, 10, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 88,
                column: "Date",
                value: new DateTime(2025, 11, 9, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 89,
                column: "Date",
                value: new DateTime(2025, 11, 8, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 90,
                column: "Date",
                value: new DateTime(2025, 11, 7, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 91,
                column: "Date",
                value: new DateTime(2025, 11, 6, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 92,
                column: "Date",
                value: new DateTime(2025, 11, 5, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 93,
                column: "Date",
                value: new DateTime(2025, 11, 4, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 94,
                column: "Date",
                value: new DateTime(2025, 11, 3, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 95,
                column: "Date",
                value: new DateTime(2025, 11, 2, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 96,
                column: "Date",
                value: new DateTime(2025, 11, 1, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 97,
                column: "Date",
                value: new DateTime(2025, 10, 31, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 98,
                column: "Date",
                value: new DateTime(2025, 10, 30, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 99,
                column: "Date",
                value: new DateTime(2025, 10, 29, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 100,
                column: "Date",
                value: new DateTime(2025, 10, 28, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 101,
                column: "Date",
                value: new DateTime(2025, 10, 27, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 102,
                column: "Date",
                value: new DateTime(2025, 10, 26, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 103,
                column: "Date",
                value: new DateTime(2025, 10, 25, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 104,
                column: "Date",
                value: new DateTime(2025, 10, 24, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 105,
                column: "Date",
                value: new DateTime(2025, 10, 23, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 106,
                column: "Date",
                value: new DateTime(2025, 10, 22, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 107,
                column: "Date",
                value: new DateTime(2025, 10, 21, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 108,
                column: "Date",
                value: new DateTime(2025, 10, 20, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 109,
                column: "Date",
                value: new DateTime(2025, 10, 19, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 110,
                column: "Date",
                value: new DateTime(2025, 10, 18, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 111,
                column: "Date",
                value: new DateTime(2025, 10, 17, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 112,
                column: "Date",
                value: new DateTime(2025, 10, 16, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 113,
                column: "Date",
                value: new DateTime(2025, 10, 15, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 114,
                column: "Date",
                value: new DateTime(2025, 10, 14, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 115,
                column: "Date",
                value: new DateTime(2025, 10, 13, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 116,
                column: "Date",
                value: new DateTime(2025, 10, 12, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 117,
                column: "Date",
                value: new DateTime(2025, 10, 11, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 118,
                column: "Date",
                value: new DateTime(2025, 10, 10, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 119,
                column: "Date",
                value: new DateTime(2025, 10, 9, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 120,
                column: "Date",
                value: new DateTime(2025, 10, 8, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 121,
                column: "Date",
                value: new DateTime(2025, 10, 7, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 122,
                column: "Date",
                value: new DateTime(2025, 10, 6, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 123,
                column: "Date",
                value: new DateTime(2025, 10, 5, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 124,
                column: "Date",
                value: new DateTime(2025, 10, 4, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 125,
                column: "Date",
                value: new DateTime(2025, 10, 3, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 126,
                column: "Date",
                value: new DateTime(2025, 10, 2, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 127,
                column: "Date",
                value: new DateTime(2025, 10, 1, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 128,
                column: "Date",
                value: new DateTime(2025, 9, 30, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 129,
                column: "Date",
                value: new DateTime(2025, 9, 29, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 130,
                column: "Date",
                value: new DateTime(2025, 9, 28, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 131,
                column: "Date",
                value: new DateTime(2025, 9, 27, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 132,
                column: "Date",
                value: new DateTime(2025, 9, 26, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 133,
                column: "Date",
                value: new DateTime(2025, 9, 25, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 134,
                column: "Date",
                value: new DateTime(2025, 9, 24, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 135,
                column: "Date",
                value: new DateTime(2025, 9, 23, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 136,
                column: "Date",
                value: new DateTime(2025, 9, 22, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 137,
                column: "Date",
                value: new DateTime(2025, 9, 21, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 138,
                column: "Date",
                value: new DateTime(2025, 9, 20, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 139,
                column: "Date",
                value: new DateTime(2025, 9, 19, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 140,
                column: "Date",
                value: new DateTime(2025, 9, 18, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 141,
                column: "Date",
                value: new DateTime(2025, 9, 17, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 142,
                column: "Date",
                value: new DateTime(2025, 9, 16, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 143,
                column: "Date",
                value: new DateTime(2025, 9, 15, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 144,
                column: "Date",
                value: new DateTime(2025, 9, 14, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 145,
                column: "Date",
                value: new DateTime(2025, 9, 13, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 146,
                column: "Date",
                value: new DateTime(2025, 9, 12, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 147,
                column: "Date",
                value: new DateTime(2025, 9, 11, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 148,
                column: "Date",
                value: new DateTime(2025, 9, 10, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 149,
                column: "Date",
                value: new DateTime(2025, 9, 9, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 150,
                column: "Date",
                value: new DateTime(2025, 9, 8, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 151,
                column: "Date",
                value: new DateTime(2025, 9, 7, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 152,
                column: "Date",
                value: new DateTime(2025, 9, 6, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 153,
                column: "Date",
                value: new DateTime(2025, 9, 5, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 154,
                column: "Date",
                value: new DateTime(2025, 9, 4, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 155,
                column: "Date",
                value: new DateTime(2025, 9, 3, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 156,
                column: "Date",
                value: new DateTime(2025, 9, 2, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 157,
                column: "Date",
                value: new DateTime(2025, 9, 1, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 158,
                column: "Date",
                value: new DateTime(2025, 8, 31, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 159,
                column: "Date",
                value: new DateTime(2025, 8, 30, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 160,
                column: "Date",
                value: new DateTime(2025, 8, 29, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 161,
                column: "Date",
                value: new DateTime(2025, 8, 28, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 162,
                column: "Date",
                value: new DateTime(2025, 8, 27, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 163,
                column: "Date",
                value: new DateTime(2025, 8, 26, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 164,
                column: "Date",
                value: new DateTime(2025, 8, 25, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 165,
                column: "Date",
                value: new DateTime(2025, 8, 24, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 166,
                column: "Date",
                value: new DateTime(2025, 8, 23, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 167,
                column: "Date",
                value: new DateTime(2025, 8, 22, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 168,
                column: "Date",
                value: new DateTime(2025, 8, 21, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 169,
                column: "Date",
                value: new DateTime(2025, 8, 20, 15, 41, 23, 301, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 170,
                column: "Date",
                value: new DateTime(2025, 8, 19, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 171,
                column: "Date",
                value: new DateTime(2025, 8, 18, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 172,
                column: "Date",
                value: new DateTime(2025, 8, 17, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 173,
                column: "Date",
                value: new DateTime(2025, 8, 16, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 174,
                column: "Date",
                value: new DateTime(2025, 8, 15, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 175,
                column: "Date",
                value: new DateTime(2025, 8, 14, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 176,
                column: "Date",
                value: new DateTime(2025, 8, 13, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 177,
                column: "Date",
                value: new DateTime(2025, 8, 12, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 178,
                column: "Date",
                value: new DateTime(2025, 8, 11, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 179,
                column: "Date",
                value: new DateTime(2025, 8, 10, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 180,
                column: "Date",
                value: new DateTime(2025, 8, 9, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 181,
                column: "Date",
                value: new DateTime(2025, 8, 8, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 182,
                column: "Date",
                value: new DateTime(2025, 8, 7, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 183,
                column: "Date",
                value: new DateTime(2025, 8, 6, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 184,
                column: "Date",
                value: new DateTime(2025, 8, 5, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 185,
                column: "Date",
                value: new DateTime(2025, 8, 4, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 186,
                column: "Date",
                value: new DateTime(2025, 8, 3, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 187,
                column: "Date",
                value: new DateTime(2025, 8, 2, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 188,
                column: "Date",
                value: new DateTime(2025, 8, 1, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 189,
                column: "Date",
                value: new DateTime(2025, 7, 31, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 190,
                column: "Date",
                value: new DateTime(2025, 7, 30, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 191,
                column: "Date",
                value: new DateTime(2025, 7, 29, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 192,
                column: "Date",
                value: new DateTime(2025, 7, 28, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 193,
                column: "Date",
                value: new DateTime(2025, 7, 27, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 194,
                column: "Date",
                value: new DateTime(2025, 7, 26, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 195,
                column: "Date",
                value: new DateTime(2025, 7, 25, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 196,
                column: "Date",
                value: new DateTime(2025, 7, 24, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 197,
                column: "Date",
                value: new DateTime(2025, 7, 23, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 198,
                column: "Date",
                value: new DateTime(2025, 7, 22, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 199,
                column: "Date",
                value: new DateTime(2025, 7, 21, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 200,
                column: "Date",
                value: new DateTime(2025, 7, 20, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2026, 3, 10, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2026, 5, 9, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2026, 3, 15, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 4,
                column: "DueDate",
                value: new DateTime(2026, 5, 14, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 5,
                column: "DueDate",
                value: new DateTime(2026, 3, 20, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 6,
                column: "DueDate",
                value: new DateTime(2026, 5, 19, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 7,
                column: "DueDate",
                value: new DateTime(2026, 3, 26, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 8,
                column: "DueDate",
                value: new DateTime(2026, 5, 25, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 9,
                column: "DueDate",
                value: new DateTime(2026, 3, 31, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 10,
                column: "DueDate",
                value: new DateTime(2026, 5, 30, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 11,
                column: "DueDate",
                value: new DateTime(2026, 4, 5, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 12,
                column: "DueDate",
                value: new DateTime(2026, 6, 4, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 13,
                column: "DueDate",
                value: new DateTime(2026, 4, 10, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 14,
                column: "DueDate",
                value: new DateTime(2026, 2, 14, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 15,
                column: "DueDate",
                value: new DateTime(2026, 4, 15, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 16,
                column: "DueDate",
                value: new DateTime(2026, 2, 19, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 17,
                column: "DueDate",
                value: new DateTime(2026, 4, 20, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 18,
                column: "DueDate",
                value: new DateTime(2026, 2, 24, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 19,
                column: "DueDate",
                value: new DateTime(2026, 4, 26, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 20,
                column: "DueDate",
                value: new DateTime(2026, 3, 2, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 21,
                column: "DueDate",
                value: new DateTime(2026, 5, 1, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 22,
                column: "DueDate",
                value: new DateTime(2026, 3, 7, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 23,
                column: "DueDate",
                value: new DateTime(2026, 5, 6, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 24,
                column: "DueDate",
                value: new DateTime(2026, 3, 12, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 25,
                column: "DueDate",
                value: new DateTime(2026, 5, 11, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 26,
                column: "DueDate",
                value: new DateTime(2026, 3, 17, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 27,
                column: "DueDate",
                value: new DateTime(2026, 5, 16, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 28,
                column: "DueDate",
                value: new DateTime(2026, 3, 22, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 29,
                column: "DueDate",
                value: new DateTime(2026, 5, 21, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 30,
                column: "DueDate",
                value: new DateTime(2026, 3, 27, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 31,
                column: "DueDate",
                value: new DateTime(2026, 5, 26, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 32,
                column: "DueDate",
                value: new DateTime(2026, 4, 2, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 33,
                column: "DueDate",
                value: new DateTime(2026, 6, 1, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 34,
                column: "DueDate",
                value: new DateTime(2026, 4, 7, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 35,
                column: "DueDate",
                value: new DateTime(2026, 2, 11, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 36,
                column: "DueDate",
                value: new DateTime(2026, 4, 12, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 37,
                column: "DueDate",
                value: new DateTime(2026, 2, 16, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 38,
                column: "DueDate",
                value: new DateTime(2026, 4, 17, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 39,
                column: "DueDate",
                value: new DateTime(2026, 2, 21, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 40,
                column: "DueDate",
                value: new DateTime(2026, 4, 22, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 41,
                column: "DueDate",
                value: new DateTime(2026, 2, 26, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 42,
                column: "DueDate",
                value: new DateTime(2026, 4, 27, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 43,
                column: "DueDate",
                value: new DateTime(2026, 3, 3, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 44,
                column: "DueDate",
                value: new DateTime(2026, 5, 2, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 45,
                column: "DueDate",
                value: new DateTime(2026, 3, 9, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 46,
                column: "DueDate",
                value: new DateTime(2026, 5, 8, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 47,
                column: "DueDate",
                value: new DateTime(2026, 3, 14, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 48,
                column: "DueDate",
                value: new DateTime(2026, 5, 13, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 49,
                column: "DueDate",
                value: new DateTime(2026, 3, 19, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 50,
                column: "DueDate",
                value: new DateTime(2026, 5, 18, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 51,
                column: "DueDate",
                value: new DateTime(2026, 3, 24, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 52,
                column: "DueDate",
                value: new DateTime(2026, 5, 23, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 53,
                column: "DueDate",
                value: new DateTime(2026, 3, 29, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 54,
                column: "DueDate",
                value: new DateTime(2026, 5, 28, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 55,
                column: "DueDate",
                value: new DateTime(2026, 4, 3, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 56,
                column: "DueDate",
                value: new DateTime(2026, 6, 2, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 57,
                column: "DueDate",
                value: new DateTime(2026, 4, 9, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 58,
                column: "DueDate",
                value: new DateTime(2026, 2, 13, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 59,
                column: "DueDate",
                value: new DateTime(2026, 4, 14, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 60,
                column: "DueDate",
                value: new DateTime(2026, 2, 18, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 61,
                column: "DueDate",
                value: new DateTime(2026, 4, 19, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 62,
                column: "DueDate",
                value: new DateTime(2026, 2, 23, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 63,
                column: "DueDate",
                value: new DateTime(2026, 4, 24, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 64,
                column: "DueDate",
                value: new DateTime(2026, 2, 28, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 65,
                column: "DueDate",
                value: new DateTime(2026, 4, 29, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 66,
                column: "DueDate",
                value: new DateTime(2026, 3, 5, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 67,
                column: "DueDate",
                value: new DateTime(2026, 5, 4, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 68,
                column: "DueDate",
                value: new DateTime(2026, 3, 10, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 69,
                column: "DueDate",
                value: new DateTime(2026, 5, 9, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 70,
                column: "DueDate",
                value: new DateTime(2026, 3, 16, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 71,
                column: "DueDate",
                value: new DateTime(2026, 5, 15, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 72,
                column: "DueDate",
                value: new DateTime(2026, 3, 21, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 73,
                column: "DueDate",
                value: new DateTime(2026, 5, 20, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 74,
                column: "DueDate",
                value: new DateTime(2026, 3, 26, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 75,
                column: "DueDate",
                value: new DateTime(2026, 5, 25, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 76,
                column: "DueDate",
                value: new DateTime(2026, 3, 31, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 77,
                column: "DueDate",
                value: new DateTime(2026, 5, 30, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 78,
                column: "DueDate",
                value: new DateTime(2026, 4, 5, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 79,
                column: "DueDate",
                value: new DateTime(2026, 6, 4, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 80,
                column: "DueDate",
                value: new DateTime(2026, 4, 10, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 81,
                column: "DueDate",
                value: new DateTime(2026, 2, 14, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 82,
                column: "DueDate",
                value: new DateTime(2026, 4, 15, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 83,
                column: "DueDate",
                value: new DateTime(2026, 2, 20, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 84,
                column: "DueDate",
                value: new DateTime(2026, 4, 21, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 85,
                column: "DueDate",
                value: new DateTime(2026, 2, 25, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 86,
                column: "DueDate",
                value: new DateTime(2026, 4, 26, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 87,
                column: "DueDate",
                value: new DateTime(2026, 3, 2, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 88,
                column: "DueDate",
                value: new DateTime(2026, 5, 1, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 89,
                column: "DueDate",
                value: new DateTime(2026, 3, 7, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 90,
                column: "DueDate",
                value: new DateTime(2026, 5, 6, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 91,
                column: "DueDate",
                value: new DateTime(2026, 3, 12, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 92,
                column: "DueDate",
                value: new DateTime(2026, 5, 11, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 93,
                column: "DueDate",
                value: new DateTime(2026, 3, 17, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 94,
                column: "DueDate",
                value: new DateTime(2026, 5, 16, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 95,
                column: "DueDate",
                value: new DateTime(2026, 3, 23, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 96,
                column: "DueDate",
                value: new DateTime(2026, 5, 22, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 97,
                column: "DueDate",
                value: new DateTime(2026, 3, 28, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 98,
                column: "DueDate",
                value: new DateTime(2026, 5, 27, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 99,
                column: "DueDate",
                value: new DateTime(2026, 4, 2, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 100,
                column: "DueDate",
                value: new DateTime(2026, 6, 1, 15, 41, 23, 301, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 31, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 1, 26, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2026, 1, 5, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 12, 5, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2026, 1, 21, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2026, 1, 16, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2026, 2, 2, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2026, 1, 29, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2026, 1, 5, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2026, 1, 24, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 11, 5, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2026, 2, 1, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2026, 1, 23, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2026, 1, 22, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2026, 1, 21, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2026, 1, 20, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2026, 1, 19, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2026, 1, 18, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2026, 1, 17, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2026, 1, 16, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2026, 1, 15, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2026, 1, 14, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2026, 1, 13, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2026, 1, 12, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2026, 1, 11, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2026, 1, 10, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2026, 1, 9, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2026, 1, 8, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2026, 1, 7, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2026, 1, 6, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2026, 1, 5, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2026, 1, 4, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 33,
                column: "Date",
                value: new DateTime(2026, 1, 3, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 34,
                column: "Date",
                value: new DateTime(2026, 1, 2, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 35,
                column: "Date",
                value: new DateTime(2026, 1, 1, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2025, 12, 31, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 37,
                column: "Date",
                value: new DateTime(2025, 12, 30, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 38,
                column: "Date",
                value: new DateTime(2025, 12, 29, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 39,
                column: "Date",
                value: new DateTime(2025, 12, 28, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 40,
                column: "Date",
                value: new DateTime(2025, 12, 27, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 41,
                column: "Date",
                value: new DateTime(2025, 12, 26, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 42,
                column: "Date",
                value: new DateTime(2025, 12, 25, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 43,
                column: "Date",
                value: new DateTime(2025, 12, 24, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 44,
                column: "Date",
                value: new DateTime(2025, 12, 23, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 45,
                column: "Date",
                value: new DateTime(2025, 12, 22, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 46,
                column: "Date",
                value: new DateTime(2025, 12, 21, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 47,
                column: "Date",
                value: new DateTime(2025, 12, 20, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 48,
                column: "Date",
                value: new DateTime(2025, 12, 19, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 49,
                column: "Date",
                value: new DateTime(2025, 12, 18, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 50,
                column: "Date",
                value: new DateTime(2025, 12, 17, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 51,
                column: "Date",
                value: new DateTime(2025, 12, 16, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 52,
                column: "Date",
                value: new DateTime(2025, 12, 15, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 53,
                column: "Date",
                value: new DateTime(2025, 12, 14, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 54,
                column: "Date",
                value: new DateTime(2025, 12, 13, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 55,
                column: "Date",
                value: new DateTime(2025, 12, 12, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 56,
                column: "Date",
                value: new DateTime(2025, 12, 11, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 57,
                column: "Date",
                value: new DateTime(2025, 12, 10, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 58,
                column: "Date",
                value: new DateTime(2025, 12, 9, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 59,
                column: "Date",
                value: new DateTime(2025, 12, 8, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 60,
                column: "Date",
                value: new DateTime(2025, 12, 7, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 61,
                column: "Date",
                value: new DateTime(2025, 12, 6, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 62,
                column: "Date",
                value: new DateTime(2025, 12, 5, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 63,
                column: "Date",
                value: new DateTime(2025, 12, 4, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 64,
                column: "Date",
                value: new DateTime(2025, 12, 3, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 65,
                column: "Date",
                value: new DateTime(2025, 12, 2, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 66,
                column: "Date",
                value: new DateTime(2025, 12, 1, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 67,
                column: "Date",
                value: new DateTime(2025, 11, 30, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 68,
                column: "Date",
                value: new DateTime(2025, 11, 29, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 69,
                column: "Date",
                value: new DateTime(2025, 11, 28, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 70,
                column: "Date",
                value: new DateTime(2025, 11, 27, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 71,
                column: "Date",
                value: new DateTime(2025, 11, 26, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 72,
                column: "Date",
                value: new DateTime(2025, 11, 25, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 73,
                column: "Date",
                value: new DateTime(2025, 11, 24, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 74,
                column: "Date",
                value: new DateTime(2025, 11, 23, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 75,
                column: "Date",
                value: new DateTime(2025, 11, 22, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 76,
                column: "Date",
                value: new DateTime(2025, 11, 21, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 77,
                column: "Date",
                value: new DateTime(2025, 11, 20, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 78,
                column: "Date",
                value: new DateTime(2025, 11, 19, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 79,
                column: "Date",
                value: new DateTime(2025, 11, 18, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 80,
                column: "Date",
                value: new DateTime(2025, 11, 17, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 81,
                column: "Date",
                value: new DateTime(2025, 11, 16, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 82,
                column: "Date",
                value: new DateTime(2025, 11, 15, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 83,
                column: "Date",
                value: new DateTime(2025, 11, 14, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 84,
                column: "Date",
                value: new DateTime(2025, 11, 13, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 85,
                column: "Date",
                value: new DateTime(2025, 11, 12, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 86,
                column: "Date",
                value: new DateTime(2025, 11, 11, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 87,
                column: "Date",
                value: new DateTime(2025, 11, 10, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 88,
                column: "Date",
                value: new DateTime(2025, 11, 9, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 89,
                column: "Date",
                value: new DateTime(2025, 11, 8, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 90,
                column: "Date",
                value: new DateTime(2025, 11, 7, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 91,
                column: "Date",
                value: new DateTime(2025, 11, 6, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 92,
                column: "Date",
                value: new DateTime(2025, 11, 5, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 93,
                column: "Date",
                value: new DateTime(2025, 11, 4, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 94,
                column: "Date",
                value: new DateTime(2025, 11, 3, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 95,
                column: "Date",
                value: new DateTime(2025, 11, 2, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 96,
                column: "Date",
                value: new DateTime(2025, 11, 1, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 97,
                column: "Date",
                value: new DateTime(2025, 10, 31, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 98,
                column: "Date",
                value: new DateTime(2025, 10, 30, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 99,
                column: "Date",
                value: new DateTime(2025, 10, 29, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 100,
                column: "Date",
                value: new DateTime(2025, 10, 28, 15, 41, 23, 300, DateTimeKind.Local).AddTicks(7400));
        }
    }
}
