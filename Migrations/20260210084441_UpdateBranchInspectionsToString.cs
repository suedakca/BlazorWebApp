using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorWebApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBranchInspectionsToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SystemUpToDate",
                table: "BranchInspections",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "SystemDeficiencies",
                table: "BranchInspections",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "SignatureUpToDate",
                table: "BranchInspections",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "SignatureDeficiencies",
                table: "BranchInspections",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ReconciliationUpToDate",
                table: "BranchInspections",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ReconciliationDeficiencies",
                table: "BranchInspections",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ReceiptUpToDate",
                table: "BranchInspections",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ReceiptDeficiencies",
                table: "BranchInspections",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PhotoUpToDate",
                table: "BranchInspections",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PhotoDeficiencies",
                table: "BranchInspections",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "IndividualIdDeficiencies",
                table: "BranchInspections",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 2, 7, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2900), new DateTime(2026, 1, 7, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2900), "Bilgi", new DateTime(2021, 2, 20, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2960), "Düşük", "Orta", "Orta", "Yüksek", "Gelişim Fırsatı", "Bilgi", new DateTime(2026, 2, 7, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2900), "Yüksek", "Gelişim Fırsatı", "Bilgi", "Düşük" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 2, 4, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2980), new DateTime(2026, 1, 4, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2980), new DateTime(2026, 2, 3, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2980), "Düşük", new DateTime(2021, 3, 2, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2990), "Orta", "Yüksek", "Yüksek", "Gelişim Fırsatı", "Bilgi", "Düşük", new DateTime(2026, 2, 4, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2980), "Gelişim Fırsatı", "Bilgi", "Düşük", "Orta" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 2, 1, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2990), new DateTime(2026, 1, 1, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2990), "Orta", new DateTime(2021, 3, 12, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3000), "Yüksek", "Gelişim Fırsatı", "Gelişim Fırsatı", "Bilgi", "Düşük", "Orta", new DateTime(2026, 2, 1, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2990), "Bilgi", "Düşük", "Orta", "Yüksek" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 1, 29, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3010), new DateTime(2025, 12, 29, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3010), new DateTime(2026, 1, 28, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3010), "Yüksek", new DateTime(2021, 3, 22, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3020), "Gelişim Fırsatı", "Bilgi", "Bilgi", "Düşük", "Orta", "Yüksek", new DateTime(2026, 1, 29, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3010), "Düşük", "Orta", "Yüksek", "Gelişim Fırsatı" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 1, 26, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3020), new DateTime(2025, 12, 26, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3020), "Gelişim Fırsatı", new DateTime(2021, 4, 1, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3030), "Bilgi", "Düşük", "Düşük", "Orta", "Yüksek", "Gelişim Fırsatı", new DateTime(2026, 1, 26, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3020), "Orta", "Yüksek", "Gelişim Fırsatı", "Bilgi" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 1, 23, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3040), new DateTime(2025, 12, 23, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3040), new DateTime(2026, 1, 22, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3040), "Bilgi", new DateTime(2021, 4, 11, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3050), "Düşük", "Orta", "Orta", "Yüksek", "Gelişim Fırsatı", "Bilgi", new DateTime(2026, 1, 23, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3040), "Yüksek", "Gelişim Fırsatı", "Bilgi", "Düşük" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 1, 20, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3050), new DateTime(2025, 12, 20, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3050), "Düşük", new DateTime(2021, 4, 21, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3060), "Orta", "Yüksek", "Yüksek", "Gelişim Fırsatı", "Bilgi", "Düşük", new DateTime(2026, 1, 20, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3050), "Gelişim Fırsatı", "Bilgi", "Düşük", "Orta" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 1, 17, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3070), new DateTime(2025, 12, 17, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3070), new DateTime(2026, 1, 16, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3070), "Orta", new DateTime(2021, 5, 1, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3080), "Yüksek", "Gelişim Fırsatı", "Gelişim Fırsatı", "Bilgi", "Düşük", "Orta", new DateTime(2026, 1, 17, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3070), "Bilgi", "Düşük", "Orta", "Yüksek" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3080), new DateTime(2025, 12, 14, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3080), "Yüksek", new DateTime(2021, 5, 11, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3090), "Gelişim Fırsatı", "Bilgi", "Bilgi", "Düşük", "Orta", "Yüksek", new DateTime(2026, 1, 14, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3080), "Düşük", "Orta", "Yüksek", "Gelişim Fırsatı" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 1, 11, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3090), new DateTime(2025, 12, 11, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3090), new DateTime(2026, 1, 10, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3090), "Gelişim Fırsatı", new DateTime(2021, 5, 21, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3110), "Bilgi", "Düşük", "Düşük", "Orta", "Yüksek", "Gelişim Fırsatı", new DateTime(2026, 1, 11, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3090), "Orta", "Yüksek", "Gelişim Fırsatı", "Bilgi" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 1, 8, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3110), new DateTime(2025, 12, 8, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3110), "Bilgi", new DateTime(2021, 5, 31, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3120), "Düşük", "Orta", "Orta", "Yüksek", "Gelişim Fırsatı", "Bilgi", new DateTime(2026, 1, 8, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3110), "Yüksek", "Gelişim Fırsatı", "Bilgi", "Düşük" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 1, 5, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3120), new DateTime(2025, 12, 5, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3120), new DateTime(2026, 1, 4, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3120), "Düşük", new DateTime(2021, 6, 10, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3140), "Orta", "Yüksek", "Yüksek", "Gelişim Fırsatı", "Bilgi", "Düşük", new DateTime(2026, 1, 5, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3120), "Gelişim Fırsatı", "Bilgi", "Düşük", "Orta" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 1, 2, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3140), new DateTime(2025, 12, 2, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3140), "Orta", new DateTime(2021, 6, 20, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3150), "Yüksek", "Gelişim Fırsatı", "Gelişim Fırsatı", "Bilgi", "Düşük", "Orta", new DateTime(2026, 1, 2, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3140), "Bilgi", "Düşük", "Orta", "Yüksek" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 12, 30, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3160), new DateTime(2025, 11, 30, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3160), new DateTime(2025, 12, 29, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3160), "Yüksek", new DateTime(2021, 6, 30, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3180), "Gelişim Fırsatı", "Bilgi", "Bilgi", "Düşük", "Orta", "Yüksek", new DateTime(2025, 12, 30, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3160), "Düşük", "Orta", "Yüksek", "Gelişim Fırsatı" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 12, 27, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3180), new DateTime(2025, 11, 27, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3180), "Gelişim Fırsatı", new DateTime(2021, 7, 10, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3200), "Bilgi", "Düşük", "Düşük", "Orta", "Yüksek", "Gelişim Fırsatı", new DateTime(2025, 12, 27, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3180), "Orta", "Yüksek", "Gelişim Fırsatı", "Bilgi" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 12, 24, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3200), new DateTime(2025, 11, 24, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3200), new DateTime(2025, 12, 23, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3200), "Bilgi", new DateTime(2021, 7, 20, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3210), "Düşük", "Orta", "Orta", "Yüksek", "Gelişim Fırsatı", "Bilgi", new DateTime(2025, 12, 24, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3200), "Yüksek", "Gelişim Fırsatı", "Bilgi", "Düşük" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 12, 21, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3220), new DateTime(2025, 11, 21, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3220), "Düşük", new DateTime(2021, 7, 30, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3230), "Orta", "Yüksek", "Yüksek", "Gelişim Fırsatı", "Bilgi", "Düşük", new DateTime(2025, 12, 21, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3220), "Gelişim Fırsatı", "Bilgi", "Düşük", "Orta" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 12, 18, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3240), new DateTime(2025, 11, 18, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3240), new DateTime(2025, 12, 17, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3240), "Orta", new DateTime(2021, 8, 9, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3250), "Yüksek", "Gelişim Fırsatı", "Gelişim Fırsatı", "Bilgi", "Düşük", "Orta", new DateTime(2025, 12, 18, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3240), "Bilgi", "Düşük", "Orta", "Yüksek" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3250), new DateTime(2025, 11, 15, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3250), "Yüksek", new DateTime(2021, 8, 19, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3270), "Gelişim Fırsatı", "Bilgi", "Bilgi", "Düşük", "Orta", "Yüksek", new DateTime(2025, 12, 15, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3250), "Düşük", "Orta", "Yüksek", "Gelişim Fırsatı" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 12, 12, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3270), new DateTime(2025, 11, 12, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3270), new DateTime(2025, 12, 11, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3270), "Gelişim Fırsatı", new DateTime(2021, 8, 29, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3290), "Bilgi", "Düşük", "Düşük", "Orta", "Yüksek", "Gelişim Fırsatı", new DateTime(2025, 12, 12, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3270), "Orta", "Yüksek", "Gelişim Fırsatı", "Bilgi" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 12, 9, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3290), new DateTime(2025, 11, 9, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3290), "Bilgi", new DateTime(2021, 9, 8, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3300), "Düşük", "Orta", "Orta", "Yüksek", "Gelişim Fırsatı", "Bilgi", new DateTime(2025, 12, 9, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3290), "Yüksek", "Gelişim Fırsatı", "Bilgi", "Düşük" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 12, 6, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3310), new DateTime(2025, 11, 6, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3310), new DateTime(2025, 12, 5, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3310), "Düşük", new DateTime(2021, 9, 18, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3320), "Orta", "Yüksek", "Yüksek", "Gelişim Fırsatı", "Bilgi", "Düşük", new DateTime(2025, 12, 6, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3310), "Gelişim Fırsatı", "Bilgi", "Düşük", "Orta" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3320), new DateTime(2025, 11, 3, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3320), "Orta", new DateTime(2021, 9, 28, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3340), "Yüksek", "Gelişim Fırsatı", "Gelişim Fırsatı", "Bilgi", "Düşük", "Orta", new DateTime(2025, 12, 3, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3320), "Bilgi", "Düşük", "Orta", "Yüksek" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 11, 30, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3340), new DateTime(2025, 10, 30, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3340), new DateTime(2025, 11, 29, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3340), "Yüksek", new DateTime(2021, 10, 8, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3350), "Gelişim Fırsatı", "Bilgi", "Bilgi", "Düşük", "Orta", "Yüksek", new DateTime(2025, 11, 30, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3340), "Düşük", "Orta", "Yüksek", "Gelişim Fırsatı" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 11, 27, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3360), new DateTime(2025, 10, 27, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3360), "Gelişim Fırsatı", new DateTime(2021, 10, 18, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3370), "Bilgi", "Düşük", "Düşük", "Orta", "Yüksek", "Gelişim Fırsatı", new DateTime(2025, 11, 27, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3360), "Orta", "Yüksek", "Gelişim Fırsatı", "Bilgi" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3370), new DateTime(2025, 10, 24, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3370), new DateTime(2025, 11, 23, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3370), "Bilgi", new DateTime(2021, 10, 28, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3400), "Düşük", "Orta", "Orta", "Yüksek", "Gelişim Fırsatı", "Bilgi", new DateTime(2025, 11, 24, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3370), "Yüksek", "Gelişim Fırsatı", "Bilgi", "Düşük" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 11, 21, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3400), new DateTime(2025, 10, 21, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3400), "Düşük", new DateTime(2021, 11, 7, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3410), "Orta", "Yüksek", "Yüksek", "Gelişim Fırsatı", "Bilgi", "Düşük", new DateTime(2025, 11, 21, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3400), "Gelişim Fırsatı", "Bilgi", "Düşük", "Orta" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 11, 18, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3420), new DateTime(2025, 10, 18, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3420), new DateTime(2025, 11, 17, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3420), "Orta", new DateTime(2021, 11, 17, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3430), "Yüksek", "Gelişim Fırsatı", "Gelişim Fırsatı", "Bilgi", "Düşük", "Orta", new DateTime(2025, 11, 18, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3420), "Bilgi", "Düşük", "Orta", "Yüksek" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 11, 15, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3430), new DateTime(2025, 10, 15, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3430), "Yüksek", new DateTime(2021, 11, 27, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3440), "Gelişim Fırsatı", "Bilgi", "Bilgi", "Düşük", "Orta", "Yüksek", new DateTime(2025, 11, 15, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3430), "Düşük", "Orta", "Yüksek", "Gelişim Fırsatı" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 11, 12, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3440), new DateTime(2025, 10, 12, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3440), new DateTime(2025, 11, 11, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3440), "Gelişim Fırsatı", new DateTime(2021, 12, 7, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3460), "Bilgi", "Düşük", "Düşük", "Orta", "Yüksek", "Gelişim Fırsatı", new DateTime(2025, 11, 12, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3440), "Orta", "Yüksek", "Gelişim Fırsatı", "Bilgi" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 11, 9, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3460), new DateTime(2025, 10, 9, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3460), "Bilgi", new DateTime(2021, 12, 17, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3470), "Düşük", "Orta", "Orta", "Yüksek", "Gelişim Fırsatı", "Bilgi", new DateTime(2025, 11, 9, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3460), "Yüksek", "Gelişim Fırsatı", "Bilgi", "Düşük" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 11, 6, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3470), new DateTime(2025, 10, 6, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3470), new DateTime(2025, 11, 5, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3470), "Düşük", new DateTime(2021, 12, 27, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3480), "Orta", "Yüksek", "Yüksek", "Gelişim Fırsatı", "Bilgi", "Düşük", new DateTime(2025, 11, 6, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3470), "Gelişim Fırsatı", "Bilgi", "Düşük", "Orta" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 11, 3, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3490), new DateTime(2025, 10, 3, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3490), "Orta", new DateTime(2022, 1, 6, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3500), "Yüksek", "Gelişim Fırsatı", "Gelişim Fırsatı", "Bilgi", "Düşük", "Orta", new DateTime(2025, 11, 3, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3490), "Bilgi", "Düşük", "Orta", "Yüksek" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 10, 31, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3500), new DateTime(2025, 9, 30, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3500), new DateTime(2025, 10, 30, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3500), "Yüksek", new DateTime(2022, 1, 16, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3510), "Gelişim Fırsatı", "Bilgi", "Bilgi", "Düşük", "Orta", "Yüksek", new DateTime(2025, 10, 31, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3500), "Düşük", "Orta", "Yüksek", "Gelişim Fırsatı" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 10, 28, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3510), new DateTime(2025, 9, 28, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3510), "Gelişim Fırsatı", new DateTime(2022, 1, 26, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3530), "Bilgi", "Düşük", "Düşük", "Orta", "Yüksek", "Gelişim Fırsatı", new DateTime(2025, 10, 28, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3510), "Orta", "Yüksek", "Gelişim Fırsatı", "Bilgi" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 10, 25, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3530), new DateTime(2025, 9, 25, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3530), new DateTime(2025, 10, 24, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3530), "Bilgi", new DateTime(2022, 2, 5, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3540), "Düşük", "Orta", "Orta", "Yüksek", "Gelişim Fırsatı", "Bilgi", new DateTime(2025, 10, 25, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3530), "Yüksek", "Gelişim Fırsatı", "Bilgi", "Düşük" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 10, 22, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3540), new DateTime(2025, 9, 22, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3540), "Düşük", new DateTime(2022, 2, 15, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3550), "Orta", "Yüksek", "Yüksek", "Gelişim Fırsatı", "Bilgi", "Düşük", new DateTime(2025, 10, 22, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3540), "Gelişim Fırsatı", "Bilgi", "Düşük", "Orta" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 10, 19, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3560), new DateTime(2025, 9, 19, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3560), new DateTime(2025, 10, 18, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3560), "Orta", new DateTime(2022, 2, 25, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3570), "Yüksek", "Gelişim Fırsatı", "Gelişim Fırsatı", "Bilgi", "Düşük", "Orta", new DateTime(2025, 10, 19, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3560), "Bilgi", "Düşük", "Orta", "Yüksek" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 10, 16, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3570), new DateTime(2025, 9, 16, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3570), "Yüksek", new DateTime(2022, 3, 7, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3580), "Gelişim Fırsatı", "Bilgi", "Bilgi", "Düşük", "Orta", "Yüksek", new DateTime(2025, 10, 16, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3570), "Düşük", "Orta", "Yüksek", "Gelişim Fırsatı" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 10, 13, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3590), new DateTime(2025, 9, 13, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3590), new DateTime(2025, 10, 12, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3590), "Gelişim Fırsatı", new DateTime(2022, 3, 17, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3600), "Bilgi", "Düşük", "Düşük", "Orta", "Yüksek", "Gelişim Fırsatı", new DateTime(2025, 10, 13, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3590), "Orta", "Yüksek", "Gelişim Fırsatı", "Bilgi" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 10, 10, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3600), new DateTime(2025, 9, 10, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3600), "Bilgi", new DateTime(2022, 3, 27, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3610), "Düşük", "Orta", "Orta", "Yüksek", "Gelişim Fırsatı", "Bilgi", new DateTime(2025, 10, 10, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3600), "Yüksek", "Gelişim Fırsatı", "Bilgi", "Düşük" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 10, 7, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3620), new DateTime(2025, 9, 7, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3620), new DateTime(2025, 10, 6, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3620), "Düşük", new DateTime(2022, 4, 6, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3630), "Orta", "Yüksek", "Yüksek", "Gelişim Fırsatı", "Bilgi", "Düşük", new DateTime(2025, 10, 7, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3620), "Gelişim Fırsatı", "Bilgi", "Düşük", "Orta" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 10, 4, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3630), new DateTime(2025, 9, 4, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3630), "Orta", new DateTime(2022, 4, 16, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3640), "Yüksek", "Gelişim Fırsatı", "Gelişim Fırsatı", "Bilgi", "Düşük", "Orta", new DateTime(2025, 10, 4, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3630), "Bilgi", "Düşük", "Orta", "Yüksek" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 10, 1, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3650), new DateTime(2025, 9, 1, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3650), new DateTime(2025, 9, 30, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3650), "Yüksek", new DateTime(2022, 4, 26, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3660), "Gelişim Fırsatı", "Bilgi", "Bilgi", "Düşük", "Orta", "Yüksek", new DateTime(2025, 10, 1, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3650), "Düşük", "Orta", "Yüksek", "Gelişim Fırsatı" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 9, 28, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3660), new DateTime(2025, 8, 28, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3660), "Gelişim Fırsatı", new DateTime(2022, 5, 6, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3670), "Bilgi", "Düşük", "Düşük", "Orta", "Yüksek", "Gelişim Fırsatı", new DateTime(2025, 9, 28, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3660), "Orta", "Yüksek", "Gelişim Fırsatı", "Bilgi" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 9, 25, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3670), new DateTime(2025, 8, 25, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3670), new DateTime(2025, 9, 24, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3670), "Bilgi", new DateTime(2022, 5, 16, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3680), "Düşük", "Orta", "Orta", "Yüksek", "Gelişim Fırsatı", "Bilgi", new DateTime(2025, 9, 25, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3670), "Yüksek", "Gelişim Fırsatı", "Bilgi", "Düşük" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 9, 22, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3690), new DateTime(2025, 8, 22, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3690), "Düşük", new DateTime(2022, 5, 26, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3700), "Orta", "Yüksek", "Yüksek", "Gelişim Fırsatı", "Bilgi", "Düşük", new DateTime(2025, 9, 22, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3690), "Gelişim Fırsatı", "Bilgi", "Düşük", "Orta" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 9, 19, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3700), new DateTime(2025, 8, 19, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3700), new DateTime(2025, 9, 18, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3700), "Orta", new DateTime(2022, 6, 5, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3710), "Yüksek", "Gelişim Fırsatı", "Gelişim Fırsatı", "Bilgi", "Düşük", "Orta", new DateTime(2025, 9, 19, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3700), "Bilgi", "Düşük", "Orta", "Yüksek" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 9, 16, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3710), new DateTime(2025, 8, 16, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3710), "Yüksek", new DateTime(2022, 6, 15, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3720), "Gelişim Fırsatı", "Bilgi", "Bilgi", "Düşük", "Orta", "Yüksek", new DateTime(2025, 9, 16, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3710), "Düşük", "Orta", "Yüksek", "Gelişim Fırsatı" });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 9, 13, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3730), new DateTime(2025, 8, 13, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3730), new DateTime(2025, 9, 12, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3730), "Gelişim Fırsatı", new DateTime(2022, 6, 25, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3740), "Bilgi", "Düşük", "Düşük", "Orta", "Yüksek", "Gelişim Fırsatı", new DateTime(2025, 9, 13, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(3730), "Orta", "Yüksek", "Gelişim Fırsatı", "Bilgi" });

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 2, 9, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 2, 8, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2026, 2, 7, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2026, 2, 6, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2026, 2, 5, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2026, 2, 4, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2026, 2, 3, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2026, 2, 2, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2026, 2, 1, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2026, 1, 31, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2026, 1, 30, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2026, 1, 29, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2026, 1, 28, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2026, 1, 27, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2026, 1, 26, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2026, 1, 25, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2026, 1, 24, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2026, 1, 23, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2026, 1, 22, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2026, 1, 21, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2026, 1, 20, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2026, 1, 19, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2026, 1, 18, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2026, 1, 17, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2026, 1, 16, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2026, 1, 15, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2026, 1, 14, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2026, 1, 13, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2026, 1, 12, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2026, 1, 11, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2026, 1, 10, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2026, 1, 9, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 33,
                column: "Date",
                value: new DateTime(2026, 1, 8, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 34,
                column: "Date",
                value: new DateTime(2026, 1, 7, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 35,
                column: "Date",
                value: new DateTime(2026, 1, 6, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2026, 1, 5, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 37,
                column: "Date",
                value: new DateTime(2026, 1, 4, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 38,
                column: "Date",
                value: new DateTime(2026, 1, 3, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 39,
                column: "Date",
                value: new DateTime(2026, 1, 2, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 40,
                column: "Date",
                value: new DateTime(2026, 1, 1, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 41,
                column: "Date",
                value: new DateTime(2025, 12, 31, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 42,
                column: "Date",
                value: new DateTime(2025, 12, 30, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 43,
                column: "Date",
                value: new DateTime(2025, 12, 29, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 44,
                column: "Date",
                value: new DateTime(2025, 12, 28, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 45,
                column: "Date",
                value: new DateTime(2025, 12, 27, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 46,
                column: "Date",
                value: new DateTime(2025, 12, 26, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 47,
                column: "Date",
                value: new DateTime(2025, 12, 25, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 48,
                column: "Date",
                value: new DateTime(2025, 12, 24, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 49,
                column: "Date",
                value: new DateTime(2025, 12, 23, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 50,
                column: "Date",
                value: new DateTime(2025, 12, 22, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 51,
                column: "Date",
                value: new DateTime(2025, 12, 21, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 52,
                column: "Date",
                value: new DateTime(2025, 12, 20, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 53,
                column: "Date",
                value: new DateTime(2025, 12, 19, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 54,
                column: "Date",
                value: new DateTime(2025, 12, 18, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 55,
                column: "Date",
                value: new DateTime(2025, 12, 17, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 56,
                column: "Date",
                value: new DateTime(2025, 12, 16, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 57,
                column: "Date",
                value: new DateTime(2025, 12, 15, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 58,
                column: "Date",
                value: new DateTime(2025, 12, 14, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 59,
                column: "Date",
                value: new DateTime(2025, 12, 13, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 60,
                column: "Date",
                value: new DateTime(2025, 12, 12, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 61,
                column: "Date",
                value: new DateTime(2025, 12, 11, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 62,
                column: "Date",
                value: new DateTime(2025, 12, 10, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 63,
                column: "Date",
                value: new DateTime(2025, 12, 9, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 64,
                column: "Date",
                value: new DateTime(2025, 12, 8, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 65,
                column: "Date",
                value: new DateTime(2025, 12, 7, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 66,
                column: "Date",
                value: new DateTime(2025, 12, 6, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 67,
                column: "Date",
                value: new DateTime(2025, 12, 5, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 68,
                column: "Date",
                value: new DateTime(2025, 12, 4, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 69,
                column: "Date",
                value: new DateTime(2025, 12, 3, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 70,
                column: "Date",
                value: new DateTime(2025, 12, 2, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 71,
                column: "Date",
                value: new DateTime(2025, 12, 1, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 72,
                column: "Date",
                value: new DateTime(2025, 11, 30, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 73,
                column: "Date",
                value: new DateTime(2025, 11, 29, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 74,
                column: "Date",
                value: new DateTime(2025, 11, 28, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 75,
                column: "Date",
                value: new DateTime(2025, 11, 27, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 76,
                column: "Date",
                value: new DateTime(2025, 11, 26, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 77,
                column: "Date",
                value: new DateTime(2025, 11, 25, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 78,
                column: "Date",
                value: new DateTime(2025, 11, 24, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 79,
                column: "Date",
                value: new DateTime(2025, 11, 23, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 80,
                column: "Date",
                value: new DateTime(2025, 11, 22, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 81,
                column: "Date",
                value: new DateTime(2025, 11, 21, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 82,
                column: "Date",
                value: new DateTime(2025, 11, 20, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 83,
                column: "Date",
                value: new DateTime(2025, 11, 19, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 84,
                column: "Date",
                value: new DateTime(2025, 11, 18, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 85,
                column: "Date",
                value: new DateTime(2025, 11, 17, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 86,
                column: "Date",
                value: new DateTime(2025, 11, 16, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 87,
                column: "Date",
                value: new DateTime(2025, 11, 15, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 88,
                column: "Date",
                value: new DateTime(2025, 11, 14, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 89,
                column: "Date",
                value: new DateTime(2025, 11, 13, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 90,
                column: "Date",
                value: new DateTime(2025, 11, 12, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 91,
                column: "Date",
                value: new DateTime(2025, 11, 11, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 92,
                column: "Date",
                value: new DateTime(2025, 11, 10, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 93,
                column: "Date",
                value: new DateTime(2025, 11, 9, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 94,
                column: "Date",
                value: new DateTime(2025, 11, 8, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 95,
                column: "Date",
                value: new DateTime(2025, 11, 7, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 96,
                column: "Date",
                value: new DateTime(2025, 11, 6, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 97,
                column: "Date",
                value: new DateTime(2025, 11, 5, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 98,
                column: "Date",
                value: new DateTime(2025, 11, 4, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 99,
                column: "Date",
                value: new DateTime(2025, 11, 3, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 100,
                column: "Date",
                value: new DateTime(2025, 11, 2, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 101,
                column: "Date",
                value: new DateTime(2025, 11, 1, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 102,
                column: "Date",
                value: new DateTime(2025, 10, 31, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 103,
                column: "Date",
                value: new DateTime(2025, 10, 30, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 104,
                column: "Date",
                value: new DateTime(2025, 10, 29, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 105,
                column: "Date",
                value: new DateTime(2025, 10, 28, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 106,
                column: "Date",
                value: new DateTime(2025, 10, 27, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 107,
                column: "Date",
                value: new DateTime(2025, 10, 26, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 108,
                column: "Date",
                value: new DateTime(2025, 10, 25, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 109,
                column: "Date",
                value: new DateTime(2025, 10, 24, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 110,
                column: "Date",
                value: new DateTime(2025, 10, 23, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 111,
                column: "Date",
                value: new DateTime(2025, 10, 22, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 112,
                column: "Date",
                value: new DateTime(2025, 10, 21, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 113,
                column: "Date",
                value: new DateTime(2025, 10, 20, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 114,
                column: "Date",
                value: new DateTime(2025, 10, 19, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 115,
                column: "Date",
                value: new DateTime(2025, 10, 18, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 116,
                column: "Date",
                value: new DateTime(2025, 10, 17, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 117,
                column: "Date",
                value: new DateTime(2025, 10, 16, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 118,
                column: "Date",
                value: new DateTime(2025, 10, 15, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 119,
                column: "Date",
                value: new DateTime(2025, 10, 14, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 120,
                column: "Date",
                value: new DateTime(2025, 10, 13, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 121,
                column: "Date",
                value: new DateTime(2025, 10, 12, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 122,
                column: "Date",
                value: new DateTime(2025, 10, 11, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 123,
                column: "Date",
                value: new DateTime(2025, 10, 10, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 124,
                column: "Date",
                value: new DateTime(2025, 10, 9, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 125,
                column: "Date",
                value: new DateTime(2025, 10, 8, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 126,
                column: "Date",
                value: new DateTime(2025, 10, 7, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 127,
                column: "Date",
                value: new DateTime(2025, 10, 6, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 128,
                column: "Date",
                value: new DateTime(2025, 10, 5, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 129,
                column: "Date",
                value: new DateTime(2025, 10, 4, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 130,
                column: "Date",
                value: new DateTime(2025, 10, 3, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 131,
                column: "Date",
                value: new DateTime(2025, 10, 2, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 132,
                column: "Date",
                value: new DateTime(2025, 10, 1, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 133,
                column: "Date",
                value: new DateTime(2025, 9, 30, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 134,
                column: "Date",
                value: new DateTime(2025, 9, 29, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 135,
                column: "Date",
                value: new DateTime(2025, 9, 28, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 136,
                column: "Date",
                value: new DateTime(2025, 9, 27, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 137,
                column: "Date",
                value: new DateTime(2025, 9, 26, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 138,
                column: "Date",
                value: new DateTime(2025, 9, 25, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 139,
                column: "Date",
                value: new DateTime(2025, 9, 24, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 140,
                column: "Date",
                value: new DateTime(2025, 9, 23, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 141,
                column: "Date",
                value: new DateTime(2025, 9, 22, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 142,
                column: "Date",
                value: new DateTime(2025, 9, 21, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 143,
                column: "Date",
                value: new DateTime(2025, 9, 20, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 144,
                column: "Date",
                value: new DateTime(2025, 9, 19, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 145,
                column: "Date",
                value: new DateTime(2025, 9, 18, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 146,
                column: "Date",
                value: new DateTime(2025, 9, 17, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 147,
                column: "Date",
                value: new DateTime(2025, 9, 16, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 148,
                column: "Date",
                value: new DateTime(2025, 9, 15, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 149,
                column: "Date",
                value: new DateTime(2025, 9, 14, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 150,
                column: "Date",
                value: new DateTime(2025, 9, 13, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 151,
                column: "Date",
                value: new DateTime(2025, 9, 12, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 152,
                column: "Date",
                value: new DateTime(2025, 9, 11, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 153,
                column: "Date",
                value: new DateTime(2025, 9, 10, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 154,
                column: "Date",
                value: new DateTime(2025, 9, 9, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 155,
                column: "Date",
                value: new DateTime(2025, 9, 8, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 156,
                column: "Date",
                value: new DateTime(2025, 9, 7, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 157,
                column: "Date",
                value: new DateTime(2025, 9, 6, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 158,
                column: "Date",
                value: new DateTime(2025, 9, 5, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 159,
                column: "Date",
                value: new DateTime(2025, 9, 4, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 160,
                column: "Date",
                value: new DateTime(2025, 9, 3, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 161,
                column: "Date",
                value: new DateTime(2025, 9, 2, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 162,
                column: "Date",
                value: new DateTime(2025, 9, 1, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 163,
                column: "Date",
                value: new DateTime(2025, 8, 31, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 164,
                column: "Date",
                value: new DateTime(2025, 8, 30, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 165,
                column: "Date",
                value: new DateTime(2025, 8, 29, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 166,
                column: "Date",
                value: new DateTime(2025, 8, 28, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 167,
                column: "Date",
                value: new DateTime(2025, 8, 27, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 168,
                column: "Date",
                value: new DateTime(2025, 8, 26, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 169,
                column: "Date",
                value: new DateTime(2025, 8, 25, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 170,
                column: "Date",
                value: new DateTime(2025, 8, 24, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 171,
                column: "Date",
                value: new DateTime(2025, 8, 23, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 172,
                column: "Date",
                value: new DateTime(2025, 8, 22, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 173,
                column: "Date",
                value: new DateTime(2025, 8, 21, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 174,
                column: "Date",
                value: new DateTime(2025, 8, 20, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 175,
                column: "Date",
                value: new DateTime(2025, 8, 19, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 176,
                column: "Date",
                value: new DateTime(2025, 8, 18, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 177,
                column: "Date",
                value: new DateTime(2025, 8, 17, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 178,
                column: "Date",
                value: new DateTime(2025, 8, 16, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 179,
                column: "Date",
                value: new DateTime(2025, 8, 15, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 180,
                column: "Date",
                value: new DateTime(2025, 8, 14, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 181,
                column: "Date",
                value: new DateTime(2025, 8, 13, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 182,
                column: "Date",
                value: new DateTime(2025, 8, 12, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 183,
                column: "Date",
                value: new DateTime(2025, 8, 11, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 184,
                column: "Date",
                value: new DateTime(2025, 8, 10, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 185,
                column: "Date",
                value: new DateTime(2025, 8, 9, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 186,
                column: "Date",
                value: new DateTime(2025, 8, 8, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 187,
                column: "Date",
                value: new DateTime(2025, 8, 7, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 188,
                column: "Date",
                value: new DateTime(2025, 8, 6, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 189,
                column: "Date",
                value: new DateTime(2025, 8, 5, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 190,
                column: "Date",
                value: new DateTime(2025, 8, 4, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 191,
                column: "Date",
                value: new DateTime(2025, 8, 3, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 192,
                column: "Date",
                value: new DateTime(2025, 8, 2, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 193,
                column: "Date",
                value: new DateTime(2025, 8, 1, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 194,
                column: "Date",
                value: new DateTime(2025, 7, 31, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 195,
                column: "Date",
                value: new DateTime(2025, 7, 30, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 196,
                column: "Date",
                value: new DateTime(2025, 7, 29, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 197,
                column: "Date",
                value: new DateTime(2025, 7, 28, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 198,
                column: "Date",
                value: new DateTime(2025, 7, 27, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 199,
                column: "Date",
                value: new DateTime(2025, 7, 26, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 200,
                column: "Date",
                value: new DateTime(2025, 7, 25, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2026, 3, 15, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2026, 5, 14, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2026, 3, 20, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 4,
                column: "DueDate",
                value: new DateTime(2026, 5, 19, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 5,
                column: "DueDate",
                value: new DateTime(2026, 3, 25, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 6,
                column: "DueDate",
                value: new DateTime(2026, 5, 24, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 7,
                column: "DueDate",
                value: new DateTime(2026, 3, 31, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 8,
                column: "DueDate",
                value: new DateTime(2026, 5, 30, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 9,
                column: "DueDate",
                value: new DateTime(2026, 4, 5, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 10,
                column: "DueDate",
                value: new DateTime(2026, 6, 4, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 11,
                column: "DueDate",
                value: new DateTime(2026, 4, 10, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 12,
                column: "DueDate",
                value: new DateTime(2026, 6, 9, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 13,
                column: "DueDate",
                value: new DateTime(2026, 4, 15, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 14,
                column: "DueDate",
                value: new DateTime(2026, 2, 19, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 15,
                column: "DueDate",
                value: new DateTime(2026, 4, 20, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 16,
                column: "DueDate",
                value: new DateTime(2026, 2, 24, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 17,
                column: "DueDate",
                value: new DateTime(2026, 4, 25, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 18,
                column: "DueDate",
                value: new DateTime(2026, 3, 1, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 19,
                column: "DueDate",
                value: new DateTime(2026, 5, 1, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 20,
                column: "DueDate",
                value: new DateTime(2026, 3, 7, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 21,
                column: "DueDate",
                value: new DateTime(2026, 5, 6, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 22,
                column: "DueDate",
                value: new DateTime(2026, 3, 12, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 23,
                column: "DueDate",
                value: new DateTime(2026, 5, 11, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 24,
                column: "DueDate",
                value: new DateTime(2026, 3, 17, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 25,
                column: "DueDate",
                value: new DateTime(2026, 5, 16, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 26,
                column: "DueDate",
                value: new DateTime(2026, 3, 22, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 27,
                column: "DueDate",
                value: new DateTime(2026, 5, 21, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 28,
                column: "DueDate",
                value: new DateTime(2026, 3, 27, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 29,
                column: "DueDate",
                value: new DateTime(2026, 5, 26, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 30,
                column: "DueDate",
                value: new DateTime(2026, 4, 1, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 31,
                column: "DueDate",
                value: new DateTime(2026, 5, 31, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 32,
                column: "DueDate",
                value: new DateTime(2026, 4, 7, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 33,
                column: "DueDate",
                value: new DateTime(2026, 6, 6, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 34,
                column: "DueDate",
                value: new DateTime(2026, 4, 12, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 35,
                column: "DueDate",
                value: new DateTime(2026, 2, 16, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 36,
                column: "DueDate",
                value: new DateTime(2026, 4, 17, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 37,
                column: "DueDate",
                value: new DateTime(2026, 2, 21, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 38,
                column: "DueDate",
                value: new DateTime(2026, 4, 22, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 39,
                column: "DueDate",
                value: new DateTime(2026, 2, 26, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 40,
                column: "DueDate",
                value: new DateTime(2026, 4, 27, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 41,
                column: "DueDate",
                value: new DateTime(2026, 3, 3, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 42,
                column: "DueDate",
                value: new DateTime(2026, 5, 2, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 43,
                column: "DueDate",
                value: new DateTime(2026, 3, 8, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 44,
                column: "DueDate",
                value: new DateTime(2026, 5, 7, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 45,
                column: "DueDate",
                value: new DateTime(2026, 3, 14, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 46,
                column: "DueDate",
                value: new DateTime(2026, 5, 13, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 47,
                column: "DueDate",
                value: new DateTime(2026, 3, 19, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 48,
                column: "DueDate",
                value: new DateTime(2026, 5, 18, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 49,
                column: "DueDate",
                value: new DateTime(2026, 3, 24, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 50,
                column: "DueDate",
                value: new DateTime(2026, 5, 23, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 51,
                column: "DueDate",
                value: new DateTime(2026, 3, 29, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 52,
                column: "DueDate",
                value: new DateTime(2026, 5, 28, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 53,
                column: "DueDate",
                value: new DateTime(2026, 4, 3, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 54,
                column: "DueDate",
                value: new DateTime(2026, 6, 2, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 55,
                column: "DueDate",
                value: new DateTime(2026, 4, 8, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 56,
                column: "DueDate",
                value: new DateTime(2026, 6, 7, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 57,
                column: "DueDate",
                value: new DateTime(2026, 4, 14, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 58,
                column: "DueDate",
                value: new DateTime(2026, 2, 18, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 59,
                column: "DueDate",
                value: new DateTime(2026, 4, 19, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 60,
                column: "DueDate",
                value: new DateTime(2026, 2, 23, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 61,
                column: "DueDate",
                value: new DateTime(2026, 4, 24, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 62,
                column: "DueDate",
                value: new DateTime(2026, 2, 28, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 63,
                column: "DueDate",
                value: new DateTime(2026, 4, 29, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 64,
                column: "DueDate",
                value: new DateTime(2026, 3, 5, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 65,
                column: "DueDate",
                value: new DateTime(2026, 5, 4, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 66,
                column: "DueDate",
                value: new DateTime(2026, 3, 10, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 67,
                column: "DueDate",
                value: new DateTime(2026, 5, 9, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 68,
                column: "DueDate",
                value: new DateTime(2026, 3, 15, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 69,
                column: "DueDate",
                value: new DateTime(2026, 5, 14, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 70,
                column: "DueDate",
                value: new DateTime(2026, 3, 21, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 71,
                column: "DueDate",
                value: new DateTime(2026, 5, 20, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 72,
                column: "DueDate",
                value: new DateTime(2026, 3, 26, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 73,
                column: "DueDate",
                value: new DateTime(2026, 5, 25, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 74,
                column: "DueDate",
                value: new DateTime(2026, 3, 31, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 75,
                column: "DueDate",
                value: new DateTime(2026, 5, 30, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 76,
                column: "DueDate",
                value: new DateTime(2026, 4, 5, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 77,
                column: "DueDate",
                value: new DateTime(2026, 6, 4, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 78,
                column: "DueDate",
                value: new DateTime(2026, 4, 10, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 79,
                column: "DueDate",
                value: new DateTime(2026, 6, 9, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 80,
                column: "DueDate",
                value: new DateTime(2026, 4, 15, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 81,
                column: "DueDate",
                value: new DateTime(2026, 2, 19, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 82,
                column: "DueDate",
                value: new DateTime(2026, 4, 20, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 83,
                column: "DueDate",
                value: new DateTime(2026, 2, 25, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 84,
                column: "DueDate",
                value: new DateTime(2026, 4, 26, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 85,
                column: "DueDate",
                value: new DateTime(2026, 3, 2, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 86,
                column: "DueDate",
                value: new DateTime(2026, 5, 1, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 87,
                column: "DueDate",
                value: new DateTime(2026, 3, 7, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 88,
                column: "DueDate",
                value: new DateTime(2026, 5, 6, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 89,
                column: "DueDate",
                value: new DateTime(2026, 3, 12, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 90,
                column: "DueDate",
                value: new DateTime(2026, 5, 11, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 91,
                column: "DueDate",
                value: new DateTime(2026, 3, 17, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 92,
                column: "DueDate",
                value: new DateTime(2026, 5, 16, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 93,
                column: "DueDate",
                value: new DateTime(2026, 3, 22, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 94,
                column: "DueDate",
                value: new DateTime(2026, 5, 21, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 95,
                column: "DueDate",
                value: new DateTime(2026, 3, 28, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 96,
                column: "DueDate",
                value: new DateTime(2026, 5, 27, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 97,
                column: "DueDate",
                value: new DateTime(2026, 4, 2, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 98,
                column: "DueDate",
                value: new DateTime(2026, 6, 1, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 99,
                column: "DueDate",
                value: new DateTime(2026, 4, 7, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 100,
                column: "DueDate",
                value: new DateTime(2026, 6, 6, 11, 44, 41, 459, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 2, 5, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 1, 31, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2026, 1, 10, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 12, 10, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2026, 1, 26, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2026, 1, 21, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2026, 2, 7, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2026, 2, 3, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2026, 1, 10, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2026, 1, 29, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 11, 10, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2026, 2, 6, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2026, 1, 28, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2026, 1, 27, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2026, 1, 26, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2026, 1, 25, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2026, 1, 24, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2026, 1, 23, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2026, 1, 22, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2026, 1, 21, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2026, 1, 20, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2026, 1, 19, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2026, 1, 18, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2026, 1, 17, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2026, 1, 16, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2026, 1, 15, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2026, 1, 14, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2026, 1, 13, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2026, 1, 12, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2026, 1, 11, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2026, 1, 10, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2026, 1, 9, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 33,
                column: "Date",
                value: new DateTime(2026, 1, 8, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 34,
                column: "Date",
                value: new DateTime(2026, 1, 7, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 35,
                column: "Date",
                value: new DateTime(2026, 1, 6, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2026, 1, 5, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 37,
                column: "Date",
                value: new DateTime(2026, 1, 4, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 38,
                column: "Date",
                value: new DateTime(2026, 1, 3, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 39,
                column: "Date",
                value: new DateTime(2026, 1, 2, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 40,
                column: "Date",
                value: new DateTime(2026, 1, 1, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 41,
                column: "Date",
                value: new DateTime(2025, 12, 31, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 42,
                column: "Date",
                value: new DateTime(2025, 12, 30, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 43,
                column: "Date",
                value: new DateTime(2025, 12, 29, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 44,
                column: "Date",
                value: new DateTime(2025, 12, 28, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 45,
                column: "Date",
                value: new DateTime(2025, 12, 27, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 46,
                column: "Date",
                value: new DateTime(2025, 12, 26, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 47,
                column: "Date",
                value: new DateTime(2025, 12, 25, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 48,
                column: "Date",
                value: new DateTime(2025, 12, 24, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 49,
                column: "Date",
                value: new DateTime(2025, 12, 23, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 50,
                column: "Date",
                value: new DateTime(2025, 12, 22, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 51,
                column: "Date",
                value: new DateTime(2025, 12, 21, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 52,
                column: "Date",
                value: new DateTime(2025, 12, 20, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 53,
                column: "Date",
                value: new DateTime(2025, 12, 19, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 54,
                column: "Date",
                value: new DateTime(2025, 12, 18, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 55,
                column: "Date",
                value: new DateTime(2025, 12, 17, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 56,
                column: "Date",
                value: new DateTime(2025, 12, 16, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 57,
                column: "Date",
                value: new DateTime(2025, 12, 15, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 58,
                column: "Date",
                value: new DateTime(2025, 12, 14, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 59,
                column: "Date",
                value: new DateTime(2025, 12, 13, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 60,
                column: "Date",
                value: new DateTime(2025, 12, 12, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 61,
                column: "Date",
                value: new DateTime(2025, 12, 11, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 62,
                column: "Date",
                value: new DateTime(2025, 12, 10, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 63,
                column: "Date",
                value: new DateTime(2025, 12, 9, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 64,
                column: "Date",
                value: new DateTime(2025, 12, 8, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 65,
                column: "Date",
                value: new DateTime(2025, 12, 7, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 66,
                column: "Date",
                value: new DateTime(2025, 12, 6, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 67,
                column: "Date",
                value: new DateTime(2025, 12, 5, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 68,
                column: "Date",
                value: new DateTime(2025, 12, 4, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 69,
                column: "Date",
                value: new DateTime(2025, 12, 3, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 70,
                column: "Date",
                value: new DateTime(2025, 12, 2, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 71,
                column: "Date",
                value: new DateTime(2025, 12, 1, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 72,
                column: "Date",
                value: new DateTime(2025, 11, 30, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 73,
                column: "Date",
                value: new DateTime(2025, 11, 29, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 74,
                column: "Date",
                value: new DateTime(2025, 11, 28, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 75,
                column: "Date",
                value: new DateTime(2025, 11, 27, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 76,
                column: "Date",
                value: new DateTime(2025, 11, 26, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 77,
                column: "Date",
                value: new DateTime(2025, 11, 25, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 78,
                column: "Date",
                value: new DateTime(2025, 11, 24, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 79,
                column: "Date",
                value: new DateTime(2025, 11, 23, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 80,
                column: "Date",
                value: new DateTime(2025, 11, 22, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 81,
                column: "Date",
                value: new DateTime(2025, 11, 21, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 82,
                column: "Date",
                value: new DateTime(2025, 11, 20, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 83,
                column: "Date",
                value: new DateTime(2025, 11, 19, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 84,
                column: "Date",
                value: new DateTime(2025, 11, 18, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 85,
                column: "Date",
                value: new DateTime(2025, 11, 17, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 86,
                column: "Date",
                value: new DateTime(2025, 11, 16, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 87,
                column: "Date",
                value: new DateTime(2025, 11, 15, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 88,
                column: "Date",
                value: new DateTime(2025, 11, 14, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 89,
                column: "Date",
                value: new DateTime(2025, 11, 13, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 90,
                column: "Date",
                value: new DateTime(2025, 11, 12, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 91,
                column: "Date",
                value: new DateTime(2025, 11, 11, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 92,
                column: "Date",
                value: new DateTime(2025, 11, 10, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 93,
                column: "Date",
                value: new DateTime(2025, 11, 9, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 94,
                column: "Date",
                value: new DateTime(2025, 11, 8, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 95,
                column: "Date",
                value: new DateTime(2025, 11, 7, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 96,
                column: "Date",
                value: new DateTime(2025, 11, 6, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 97,
                column: "Date",
                value: new DateTime(2025, 11, 5, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 98,
                column: "Date",
                value: new DateTime(2025, 11, 4, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 99,
                column: "Date",
                value: new DateTime(2025, 11, 3, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 100,
                column: "Date",
                value: new DateTime(2025, 11, 2, 11, 44, 41, 458, DateTimeKind.Local).AddTicks(7290));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SystemUpToDate",
                table: "BranchInspections",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "SystemDeficiencies",
                table: "BranchInspections",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "SignatureUpToDate",
                table: "BranchInspections",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "SignatureDeficiencies",
                table: "BranchInspections",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ReconciliationUpToDate",
                table: "BranchInspections",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ReconciliationDeficiencies",
                table: "BranchInspections",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ReceiptUpToDate",
                table: "BranchInspections",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ReceiptDeficiencies",
                table: "BranchInspections",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "PhotoUpToDate",
                table: "BranchInspections",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "PhotoDeficiencies",
                table: "BranchInspections",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "IndividualIdDeficiencies",
                table: "BranchInspections",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 2, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2470), new DateTime(2026, 1, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2470), 1, new DateTime(2021, 2, 20, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2510), 1, 99, 1, 199, 1, 9, new DateTime(2026, 2, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2470), 1, 99, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 2, 4, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2530), new DateTime(2026, 1, 4, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2530), new DateTime(2026, 2, 3, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2530), 2, new DateTime(2021, 3, 2, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2540), 2, 98, 2, 198, 0, 10, new DateTime(2026, 2, 4, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2530), 2, 98, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 2, 1, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2540), new DateTime(2026, 1, 1, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2540), 3, new DateTime(2021, 3, 12, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2560), 3, 97, 3, 197, 1, 9, new DateTime(2026, 2, 1, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2540), 0, 100, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 1, 29, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2560), new DateTime(2025, 12, 29, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2560), new DateTime(2026, 1, 28, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2560), 4, new DateTime(2021, 3, 22, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2570), 0, 100, 4, 196, 0, 10, new DateTime(2026, 1, 29, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2560), 1, 99, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 1, 26, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2570), new DateTime(2025, 12, 26, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2570), 0, new DateTime(2021, 4, 1, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2580), 1, 99, 5, 195, 1, 9, new DateTime(2026, 1, 26, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2570), 2, 98, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 1, 23, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2590), new DateTime(2025, 12, 23, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2590), new DateTime(2026, 1, 22, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2590), 1, new DateTime(2021, 4, 11, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2600), 2, 98, 0, 200, 0, 10, new DateTime(2026, 1, 23, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2590), 0, 100, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 1, 20, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2600), new DateTime(2025, 12, 20, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2600), 2, new DateTime(2021, 4, 21, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2610), 3, 97, 1, 199, 1, 9, new DateTime(2026, 1, 20, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2600), 1, 99, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 1, 17, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2610), new DateTime(2025, 12, 17, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2610), new DateTime(2026, 1, 16, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2610), 3, new DateTime(2021, 5, 1, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2620), 0, 100, 2, 198, 0, 10, new DateTime(2026, 1, 17, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2610), 2, 98, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 1, 14, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2630), new DateTime(2025, 12, 14, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2630), 4, new DateTime(2021, 5, 11, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2640), 1, 99, 3, 197, 1, 9, new DateTime(2026, 1, 14, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2630), 0, 100, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 1, 11, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2640), new DateTime(2025, 12, 11, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2640), new DateTime(2026, 1, 10, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2640), 0, new DateTime(2021, 5, 21, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2650), 2, 98, 4, 196, 0, 10, new DateTime(2026, 1, 11, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2640), 1, 99, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 1, 8, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2660), new DateTime(2025, 12, 8, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2660), 1, new DateTime(2021, 5, 31, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2670), 3, 97, 5, 195, 1, 9, new DateTime(2026, 1, 8, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2660), 2, 98, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 1, 5, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2670), new DateTime(2025, 12, 5, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2670), new DateTime(2026, 1, 4, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2670), 2, new DateTime(2021, 6, 10, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2680), 0, 100, 0, 200, 0, 10, new DateTime(2026, 1, 5, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2670), 0, 100, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2026, 1, 2, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2680), new DateTime(2025, 12, 2, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2680), 3, new DateTime(2021, 6, 20, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2700), 1, 99, 1, 199, 1, 9, new DateTime(2026, 1, 2, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2680), 1, 99, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 12, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2700), new DateTime(2025, 11, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2700), new DateTime(2025, 12, 29, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2700), 4, new DateTime(2021, 6, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2710), 2, 98, 2, 198, 0, 10, new DateTime(2025, 12, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2700), 2, 98, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 12, 27, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2710), new DateTime(2025, 11, 27, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2710), 0, new DateTime(2021, 7, 10, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2720), 3, 97, 3, 197, 1, 9, new DateTime(2025, 12, 27, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2710), 0, 100, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 12, 24, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2730), new DateTime(2025, 11, 24, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2730), new DateTime(2025, 12, 23, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2730), 1, new DateTime(2021, 7, 20, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2740), 0, 100, 4, 196, 0, 10, new DateTime(2025, 12, 24, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2730), 1, 99, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 12, 21, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2740), new DateTime(2025, 11, 21, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2740), 2, new DateTime(2021, 7, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2750), 1, 99, 5, 195, 1, 9, new DateTime(2025, 12, 21, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2740), 2, 98, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 12, 18, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2750), new DateTime(2025, 11, 18, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2750), new DateTime(2025, 12, 17, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2750), 3, new DateTime(2021, 8, 9, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2760), 2, 98, 0, 200, 0, 10, new DateTime(2025, 12, 18, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2750), 0, 100, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2770), new DateTime(2025, 11, 15, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2770), 4, new DateTime(2021, 8, 19, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2780), 3, 97, 1, 199, 1, 9, new DateTime(2025, 12, 15, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2770), 1, 99, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 12, 12, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2780), new DateTime(2025, 11, 12, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2780), new DateTime(2025, 12, 11, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2780), 0, new DateTime(2021, 8, 29, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2790), 0, 100, 2, 198, 0, 10, new DateTime(2025, 12, 12, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2780), 2, 98, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 12, 9, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2790), new DateTime(2025, 11, 9, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2790), 1, new DateTime(2021, 9, 8, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2800), 1, 99, 3, 197, 1, 9, new DateTime(2025, 12, 9, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2790), 0, 100, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 12, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2810), new DateTime(2025, 11, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2810), new DateTime(2025, 12, 5, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2810), 2, new DateTime(2021, 9, 18, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2820), 2, 98, 4, 196, 0, 10, new DateTime(2025, 12, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2810), 1, 99, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 12, 3, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2890), new DateTime(2025, 11, 3, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2890), 3, new DateTime(2021, 9, 28, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2920), 3, 97, 5, 195, 1, 9, new DateTime(2025, 12, 3, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2890), 2, 98, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 11, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2920), new DateTime(2025, 10, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2920), new DateTime(2025, 11, 29, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2920), 4, new DateTime(2021, 10, 8, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2940), 0, 100, 0, 200, 0, 10, new DateTime(2025, 11, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2920), 0, 100, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2940), new DateTime(2025, 10, 27, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2940), 0, new DateTime(2021, 10, 18, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2960), 1, 99, 1, 199, 1, 9, new DateTime(2025, 11, 27, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2940), 1, 99, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 11, 24, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2960), new DateTime(2025, 10, 24, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2960), new DateTime(2025, 11, 23, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2960), 1, new DateTime(2021, 10, 28, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2970), 2, 98, 2, 198, 0, 10, new DateTime(2025, 11, 24, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2960), 2, 98, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 11, 21, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2980), new DateTime(2025, 10, 21, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2980), 2, new DateTime(2021, 11, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2990), 3, 97, 3, 197, 1, 9, new DateTime(2025, 11, 21, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2980), 0, 100, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 11, 18, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2990), new DateTime(2025, 10, 18, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2990), new DateTime(2025, 11, 17, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2990), 3, new DateTime(2021, 11, 17, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3010), 0, 100, 4, 196, 0, 10, new DateTime(2025, 11, 18, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(2990), 1, 99, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 11, 15, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3010), new DateTime(2025, 10, 15, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3010), 4, new DateTime(2021, 11, 27, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3020), 1, 99, 5, 195, 1, 9, new DateTime(2025, 11, 15, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3010), 2, 98, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 11, 12, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3030), new DateTime(2025, 10, 12, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3030), new DateTime(2025, 11, 11, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3030), 0, new DateTime(2021, 12, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3040), 2, 98, 0, 200, 0, 10, new DateTime(2025, 11, 12, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3030), 0, 100, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 11, 9, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3050), new DateTime(2025, 10, 9, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3050), 1, new DateTime(2021, 12, 17, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3060), 3, 97, 1, 199, 1, 9, new DateTime(2025, 11, 9, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3050), 1, 99, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 11, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3060), new DateTime(2025, 10, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3060), new DateTime(2025, 11, 5, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3060), 2, new DateTime(2021, 12, 27, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3080), 0, 100, 2, 198, 0, 10, new DateTime(2025, 11, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3060), 2, 98, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 11, 3, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3080), new DateTime(2025, 10, 3, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3080), 3, new DateTime(2022, 1, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3100), 1, 99, 3, 197, 1, 9, new DateTime(2025, 11, 3, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3080), 0, 100, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 10, 31, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3100), new DateTime(2025, 9, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3100), new DateTime(2025, 10, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3100), 4, new DateTime(2022, 1, 16, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3110), 2, 98, 4, 196, 0, 10, new DateTime(2025, 10, 31, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3100), 1, 99, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 10, 28, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3120), new DateTime(2025, 9, 28, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3120), 0, new DateTime(2022, 1, 26, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3130), 3, 97, 5, 195, 1, 9, new DateTime(2025, 10, 28, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3120), 2, 98, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 10, 25, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3130), new DateTime(2025, 9, 25, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3130), new DateTime(2025, 10, 24, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3130), 1, new DateTime(2022, 2, 5, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3150), 0, 100, 0, 200, 0, 10, new DateTime(2025, 10, 25, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3130), 0, 100, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 10, 22, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3160), new DateTime(2025, 9, 22, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3160), 2, new DateTime(2022, 2, 15, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3170), 1, 99, 1, 199, 1, 9, new DateTime(2025, 10, 22, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3160), 1, 99, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 10, 19, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3170), new DateTime(2025, 9, 19, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3170), new DateTime(2025, 10, 18, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3170), 3, new DateTime(2022, 2, 25, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3190), 2, 98, 2, 198, 0, 10, new DateTime(2025, 10, 19, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3170), 2, 98, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 10, 16, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3190), new DateTime(2025, 9, 16, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3190), 4, new DateTime(2022, 3, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3200), 3, 97, 3, 197, 1, 9, new DateTime(2025, 10, 16, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3190), 0, 100, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 10, 13, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3210), new DateTime(2025, 9, 13, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3210), new DateTime(2025, 10, 12, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3210), 0, new DateTime(2022, 3, 17, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3220), 0, 100, 4, 196, 0, 10, new DateTime(2025, 10, 13, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3210), 1, 99, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 10, 10, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3220), new DateTime(2025, 9, 10, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3220), 1, new DateTime(2022, 3, 27, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3230), 1, 99, 5, 195, 1, 9, new DateTime(2025, 10, 10, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3220), 2, 98, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 10, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3240), new DateTime(2025, 9, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3240), new DateTime(2025, 10, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3240), 2, new DateTime(2022, 4, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3250), 2, 98, 0, 200, 0, 10, new DateTime(2025, 10, 7, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3240), 0, 100, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 10, 4, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3250), new DateTime(2025, 9, 4, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3250), 3, new DateTime(2022, 4, 16, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3260), 3, 97, 1, 199, 1, 9, new DateTime(2025, 10, 4, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3250), 1, 99, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 10, 1, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3260), new DateTime(2025, 9, 1, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3260), new DateTime(2025, 9, 30, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3260), 4, new DateTime(2022, 4, 26, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3270), 0, 100, 2, 198, 0, 10, new DateTime(2025, 10, 1, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3260), 2, 98, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 9, 28, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3280), new DateTime(2025, 8, 28, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3280), 0, new DateTime(2022, 5, 6, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3290), 1, 99, 3, 197, 1, 9, new DateTime(2025, 9, 28, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3280), 0, 100, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 9, 25, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3290), new DateTime(2025, 8, 25, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3290), new DateTime(2025, 9, 24, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3290), 1, new DateTime(2022, 5, 16, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3300), 2, 98, 4, 196, 0, 10, new DateTime(2025, 9, 25, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3290), 1, 99, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 9, 22, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3300), new DateTime(2025, 8, 22, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3300), 2, new DateTime(2022, 5, 26, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3310), 3, 97, 5, 195, 1, 9, new DateTime(2025, 9, 22, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3300), 2, 98, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 9, 19, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3320), new DateTime(2025, 8, 19, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3320), new DateTime(2025, 9, 18, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3320), 3, new DateTime(2022, 6, 5, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3330), 0, 100, 0, 200, 0, 10, new DateTime(2025, 9, 19, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3320), 0, 100, 0, 50 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 9, 16, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3330), new DateTime(2025, 8, 16, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3330), 4, new DateTime(2022, 6, 15, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3340), 1, 99, 1, 199, 1, 9, new DateTime(2025, 9, 16, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3330), 1, 99, 1, 49 });

            migrationBuilder.UpdateData(
                table: "BranchInspections",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AuditPeriodEnd", "AuditPeriodStart", "BranchInterviewDate", "IndividualIdDeficiencies", "OpeningDate", "PhotoDeficiencies", "PhotoUpToDate", "ReceiptDeficiencies", "ReceiptUpToDate", "ReconciliationDeficiencies", "ReconciliationUpToDate", "ReportDate", "SignatureDeficiencies", "SignatureUpToDate", "SystemDeficiencies", "SystemUpToDate" },
                values: new object[] { new DateTime(2025, 9, 13, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3340), new DateTime(2025, 8, 13, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3340), new DateTime(2025, 9, 12, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3340), 0, new DateTime(2022, 6, 25, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3360), 2, 98, 2, 198, 0, 10, new DateTime(2025, 9, 13, 10, 15, 30, 537, DateTimeKind.Local).AddTicks(3340), 2, 98, 0, 50 });

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
    }
}
