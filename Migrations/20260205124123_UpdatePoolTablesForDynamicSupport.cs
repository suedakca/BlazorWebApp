using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorWebApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePoolTablesForDynamicSupport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConnectionString",
                table: "PoolDefinitions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TableName",
                table: "PoolDefinitions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                table: "PoolDefinitions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConnectionString", "TableName" },
                values: new object[] { null, "CommercialRecords" });

            migrationBuilder.UpdateData(
                table: "PoolDefinitions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConnectionString", "TableName" },
                values: new object[] { null, "ProjectRecords" });

            migrationBuilder.InsertData(
                table: "PoolDefinitions",
                columns: new[] { "Id", "ConnectionString", "Description", "DisplayName", "Name", "TableName" },
                values: new object[] { 3, null, "Genel veri havuzu", "Veri Havuzu (Excel)", "UnifiedData", "SampleDatas" });

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

            migrationBuilder.InsertData(
                table: "PoolColumns",
                columns: new[] { "Id", "CssClass", "DataType", "HeaderCssClass", "HeaderText", "IsVisible", "OrderIndex", "PoolDefinitionId", "PropertyName", "Width" },
                values: new object[,]
                {
                    { 18, "col-index", "Text", "col-index", "#", true, 1, 3, "Id", "50px" },
                    { 19, "d-none d-lg-table-cell", "Text", "d-none d-lg-table-cell", "ID", true, 2, 3, "Id", "" },
                    { 20, "d-none d-md-table-cell", "BadgeLight", "d-none d-md-table-cell", "Proje", true, 3, 3, "Project", "" },
                    { 21, "d-none d-xl-table-cell", "Text", "d-none d-xl-table-cell", "Yıl", true, 4, 3, "Year", "" },
                    { 22, "d-none d-lg-table-cell text-muted", "Text", "d-none d-lg-table-cell", "Bölge", true, 5, 3, "Region", "" },
                    { 23, "d-none d-lg-table-cell", "Text", "d-none d-lg-table-cell", "Şube", true, 6, 3, "Branch", "" },
                    { 24, "fw-medium", "Text", "", "Müşteri", true, 7, 3, "Customer", "" },
                    { 25, "fw-bold", "Text", "", "Adı", true, 8, 3, "Name", "" },
                    { 26, "d-none d-sm-table-cell", "Text", "d-none d-sm-table-cell", "Kategori", true, 9, 3, "Category", "" },
                    { 27, "text-center", "PriorityBadge", "text-center", "Öncelik", true, 10, 3, "Priority", "" },
                    { 28, "d-none d-xxl-table-cell", "UserAvatar", "d-none d-xxl-table-cell", "Atanan", true, 11, 3, "AssignedTo", "" },
                    { 29, "text-end font-monospace fw-bold", "Currency", "text-end", "Değer (TL)", true, 12, 3, "Value", "" },
                    { 30, "text-center", "PaymentStatus", "text-center", "Ödeme", true, 13, 3, "PaymentStatus", "" },
                    { 31, "text-center", "StatusPill", "text-center", "Durum", true, 14, 3, "Status", "" },
                    { 32, "d-none d-xxl-table-cell", "TextTruncate", "d-none d-xxl-table-cell", "Açıklama", true, 15, 3, "Description", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PoolColumns",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PoolColumns",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PoolColumns",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PoolColumns",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PoolColumns",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PoolColumns",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PoolColumns",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PoolColumns",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PoolColumns",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PoolColumns",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PoolColumns",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PoolColumns",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PoolColumns",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PoolColumns",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PoolColumns",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PoolDefinitions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ConnectionString",
                table: "PoolDefinitions");

            migrationBuilder.DropColumn(
                name: "TableName",
                table: "PoolDefinitions");

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 2, 4, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 2, 3, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2026, 2, 2, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2026, 2, 1, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2026, 1, 31, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2026, 1, 30, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2026, 1, 29, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2026, 1, 28, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2026, 1, 27, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2026, 1, 26, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2026, 1, 25, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2026, 1, 24, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2026, 1, 23, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2026, 1, 22, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2026, 1, 21, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2026, 1, 20, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2026, 1, 19, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2026, 1, 18, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2026, 1, 17, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2026, 1, 16, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2026, 1, 15, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2026, 1, 14, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2026, 1, 13, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2026, 1, 12, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2026, 1, 11, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2026, 1, 10, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2026, 1, 9, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2026, 1, 8, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2026, 1, 7, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2026, 1, 6, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2026, 1, 5, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2026, 1, 4, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 33,
                column: "Date",
                value: new DateTime(2026, 1, 3, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 34,
                column: "Date",
                value: new DateTime(2026, 1, 2, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 35,
                column: "Date",
                value: new DateTime(2026, 1, 1, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2025, 12, 31, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 37,
                column: "Date",
                value: new DateTime(2025, 12, 30, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 38,
                column: "Date",
                value: new DateTime(2025, 12, 29, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 39,
                column: "Date",
                value: new DateTime(2025, 12, 28, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 40,
                column: "Date",
                value: new DateTime(2025, 12, 27, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 41,
                column: "Date",
                value: new DateTime(2025, 12, 26, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 42,
                column: "Date",
                value: new DateTime(2025, 12, 25, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 43,
                column: "Date",
                value: new DateTime(2025, 12, 24, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 44,
                column: "Date",
                value: new DateTime(2025, 12, 23, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 45,
                column: "Date",
                value: new DateTime(2025, 12, 22, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 46,
                column: "Date",
                value: new DateTime(2025, 12, 21, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 47,
                column: "Date",
                value: new DateTime(2025, 12, 20, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 48,
                column: "Date",
                value: new DateTime(2025, 12, 19, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 49,
                column: "Date",
                value: new DateTime(2025, 12, 18, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 50,
                column: "Date",
                value: new DateTime(2025, 12, 17, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 51,
                column: "Date",
                value: new DateTime(2025, 12, 16, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 52,
                column: "Date",
                value: new DateTime(2025, 12, 15, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 53,
                column: "Date",
                value: new DateTime(2025, 12, 14, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 54,
                column: "Date",
                value: new DateTime(2025, 12, 13, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 55,
                column: "Date",
                value: new DateTime(2025, 12, 12, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 56,
                column: "Date",
                value: new DateTime(2025, 12, 11, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 57,
                column: "Date",
                value: new DateTime(2025, 12, 10, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 58,
                column: "Date",
                value: new DateTime(2025, 12, 9, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 59,
                column: "Date",
                value: new DateTime(2025, 12, 8, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 60,
                column: "Date",
                value: new DateTime(2025, 12, 7, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 61,
                column: "Date",
                value: new DateTime(2025, 12, 6, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 62,
                column: "Date",
                value: new DateTime(2025, 12, 5, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 63,
                column: "Date",
                value: new DateTime(2025, 12, 4, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 64,
                column: "Date",
                value: new DateTime(2025, 12, 3, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 65,
                column: "Date",
                value: new DateTime(2025, 12, 2, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 66,
                column: "Date",
                value: new DateTime(2025, 12, 1, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 67,
                column: "Date",
                value: new DateTime(2025, 11, 30, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 68,
                column: "Date",
                value: new DateTime(2025, 11, 29, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 69,
                column: "Date",
                value: new DateTime(2025, 11, 28, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 70,
                column: "Date",
                value: new DateTime(2025, 11, 27, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 71,
                column: "Date",
                value: new DateTime(2025, 11, 26, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 72,
                column: "Date",
                value: new DateTime(2025, 11, 25, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 73,
                column: "Date",
                value: new DateTime(2025, 11, 24, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 74,
                column: "Date",
                value: new DateTime(2025, 11, 23, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 75,
                column: "Date",
                value: new DateTime(2025, 11, 22, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 76,
                column: "Date",
                value: new DateTime(2025, 11, 21, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 77,
                column: "Date",
                value: new DateTime(2025, 11, 20, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 78,
                column: "Date",
                value: new DateTime(2025, 11, 19, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 79,
                column: "Date",
                value: new DateTime(2025, 11, 18, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 80,
                column: "Date",
                value: new DateTime(2025, 11, 17, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 81,
                column: "Date",
                value: new DateTime(2025, 11, 16, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 82,
                column: "Date",
                value: new DateTime(2025, 11, 15, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 83,
                column: "Date",
                value: new DateTime(2025, 11, 14, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 84,
                column: "Date",
                value: new DateTime(2025, 11, 13, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 85,
                column: "Date",
                value: new DateTime(2025, 11, 12, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 86,
                column: "Date",
                value: new DateTime(2025, 11, 11, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 87,
                column: "Date",
                value: new DateTime(2025, 11, 10, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 88,
                column: "Date",
                value: new DateTime(2025, 11, 9, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 89,
                column: "Date",
                value: new DateTime(2025, 11, 8, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 90,
                column: "Date",
                value: new DateTime(2025, 11, 7, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 91,
                column: "Date",
                value: new DateTime(2025, 11, 6, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 92,
                column: "Date",
                value: new DateTime(2025, 11, 5, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 93,
                column: "Date",
                value: new DateTime(2025, 11, 4, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 94,
                column: "Date",
                value: new DateTime(2025, 11, 3, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 95,
                column: "Date",
                value: new DateTime(2025, 11, 2, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 96,
                column: "Date",
                value: new DateTime(2025, 11, 1, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 97,
                column: "Date",
                value: new DateTime(2025, 10, 31, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 98,
                column: "Date",
                value: new DateTime(2025, 10, 30, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 99,
                column: "Date",
                value: new DateTime(2025, 10, 29, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 100,
                column: "Date",
                value: new DateTime(2025, 10, 28, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 101,
                column: "Date",
                value: new DateTime(2025, 10, 27, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 102,
                column: "Date",
                value: new DateTime(2025, 10, 26, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 103,
                column: "Date",
                value: new DateTime(2025, 10, 25, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 104,
                column: "Date",
                value: new DateTime(2025, 10, 24, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 105,
                column: "Date",
                value: new DateTime(2025, 10, 23, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 106,
                column: "Date",
                value: new DateTime(2025, 10, 22, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 107,
                column: "Date",
                value: new DateTime(2025, 10, 21, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 108,
                column: "Date",
                value: new DateTime(2025, 10, 20, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 109,
                column: "Date",
                value: new DateTime(2025, 10, 19, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 110,
                column: "Date",
                value: new DateTime(2025, 10, 18, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 111,
                column: "Date",
                value: new DateTime(2025, 10, 17, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 112,
                column: "Date",
                value: new DateTime(2025, 10, 16, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 113,
                column: "Date",
                value: new DateTime(2025, 10, 15, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 114,
                column: "Date",
                value: new DateTime(2025, 10, 14, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 115,
                column: "Date",
                value: new DateTime(2025, 10, 13, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 116,
                column: "Date",
                value: new DateTime(2025, 10, 12, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 117,
                column: "Date",
                value: new DateTime(2025, 10, 11, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 118,
                column: "Date",
                value: new DateTime(2025, 10, 10, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 119,
                column: "Date",
                value: new DateTime(2025, 10, 9, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 120,
                column: "Date",
                value: new DateTime(2025, 10, 8, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 121,
                column: "Date",
                value: new DateTime(2025, 10, 7, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 122,
                column: "Date",
                value: new DateTime(2025, 10, 6, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 123,
                column: "Date",
                value: new DateTime(2025, 10, 5, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 124,
                column: "Date",
                value: new DateTime(2025, 10, 4, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 125,
                column: "Date",
                value: new DateTime(2025, 10, 3, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 126,
                column: "Date",
                value: new DateTime(2025, 10, 2, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 127,
                column: "Date",
                value: new DateTime(2025, 10, 1, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 128,
                column: "Date",
                value: new DateTime(2025, 9, 30, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 129,
                column: "Date",
                value: new DateTime(2025, 9, 29, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 130,
                column: "Date",
                value: new DateTime(2025, 9, 28, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 131,
                column: "Date",
                value: new DateTime(2025, 9, 27, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 132,
                column: "Date",
                value: new DateTime(2025, 9, 26, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 133,
                column: "Date",
                value: new DateTime(2025, 9, 25, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 134,
                column: "Date",
                value: new DateTime(2025, 9, 24, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 135,
                column: "Date",
                value: new DateTime(2025, 9, 23, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 136,
                column: "Date",
                value: new DateTime(2025, 9, 22, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 137,
                column: "Date",
                value: new DateTime(2025, 9, 21, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 138,
                column: "Date",
                value: new DateTime(2025, 9, 20, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 139,
                column: "Date",
                value: new DateTime(2025, 9, 19, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 140,
                column: "Date",
                value: new DateTime(2025, 9, 18, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 141,
                column: "Date",
                value: new DateTime(2025, 9, 17, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 142,
                column: "Date",
                value: new DateTime(2025, 9, 16, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 143,
                column: "Date",
                value: new DateTime(2025, 9, 15, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 144,
                column: "Date",
                value: new DateTime(2025, 9, 14, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 145,
                column: "Date",
                value: new DateTime(2025, 9, 13, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 146,
                column: "Date",
                value: new DateTime(2025, 9, 12, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 147,
                column: "Date",
                value: new DateTime(2025, 9, 11, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 148,
                column: "Date",
                value: new DateTime(2025, 9, 10, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 149,
                column: "Date",
                value: new DateTime(2025, 9, 9, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 150,
                column: "Date",
                value: new DateTime(2025, 9, 8, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 151,
                column: "Date",
                value: new DateTime(2025, 9, 7, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 152,
                column: "Date",
                value: new DateTime(2025, 9, 6, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 153,
                column: "Date",
                value: new DateTime(2025, 9, 5, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 154,
                column: "Date",
                value: new DateTime(2025, 9, 4, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 155,
                column: "Date",
                value: new DateTime(2025, 9, 3, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 156,
                column: "Date",
                value: new DateTime(2025, 9, 2, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 157,
                column: "Date",
                value: new DateTime(2025, 9, 1, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 158,
                column: "Date",
                value: new DateTime(2025, 8, 31, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 159,
                column: "Date",
                value: new DateTime(2025, 8, 30, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 160,
                column: "Date",
                value: new DateTime(2025, 8, 29, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 161,
                column: "Date",
                value: new DateTime(2025, 8, 28, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 162,
                column: "Date",
                value: new DateTime(2025, 8, 27, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 163,
                column: "Date",
                value: new DateTime(2025, 8, 26, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 164,
                column: "Date",
                value: new DateTime(2025, 8, 25, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 165,
                column: "Date",
                value: new DateTime(2025, 8, 24, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 166,
                column: "Date",
                value: new DateTime(2025, 8, 23, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 167,
                column: "Date",
                value: new DateTime(2025, 8, 22, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 168,
                column: "Date",
                value: new DateTime(2025, 8, 21, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 169,
                column: "Date",
                value: new DateTime(2025, 8, 20, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 170,
                column: "Date",
                value: new DateTime(2025, 8, 19, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 171,
                column: "Date",
                value: new DateTime(2025, 8, 18, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 172,
                column: "Date",
                value: new DateTime(2025, 8, 17, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 173,
                column: "Date",
                value: new DateTime(2025, 8, 16, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 174,
                column: "Date",
                value: new DateTime(2025, 8, 15, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 175,
                column: "Date",
                value: new DateTime(2025, 8, 14, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 176,
                column: "Date",
                value: new DateTime(2025, 8, 13, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 177,
                column: "Date",
                value: new DateTime(2025, 8, 12, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 178,
                column: "Date",
                value: new DateTime(2025, 8, 11, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 179,
                column: "Date",
                value: new DateTime(2025, 8, 10, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 180,
                column: "Date",
                value: new DateTime(2025, 8, 9, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 181,
                column: "Date",
                value: new DateTime(2025, 8, 8, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 182,
                column: "Date",
                value: new DateTime(2025, 8, 7, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 183,
                column: "Date",
                value: new DateTime(2025, 8, 6, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 184,
                column: "Date",
                value: new DateTime(2025, 8, 5, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 185,
                column: "Date",
                value: new DateTime(2025, 8, 4, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 186,
                column: "Date",
                value: new DateTime(2025, 8, 3, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 187,
                column: "Date",
                value: new DateTime(2025, 8, 2, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 188,
                column: "Date",
                value: new DateTime(2025, 8, 1, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 189,
                column: "Date",
                value: new DateTime(2025, 7, 31, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 190,
                column: "Date",
                value: new DateTime(2025, 7, 30, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 191,
                column: "Date",
                value: new DateTime(2025, 7, 29, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 192,
                column: "Date",
                value: new DateTime(2025, 7, 28, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 193,
                column: "Date",
                value: new DateTime(2025, 7, 27, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 194,
                column: "Date",
                value: new DateTime(2025, 7, 26, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 195,
                column: "Date",
                value: new DateTime(2025, 7, 25, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 196,
                column: "Date",
                value: new DateTime(2025, 7, 24, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 197,
                column: "Date",
                value: new DateTime(2025, 7, 23, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 198,
                column: "Date",
                value: new DateTime(2025, 7, 22, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 199,
                column: "Date",
                value: new DateTime(2025, 7, 21, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "CommercialRecords",
                keyColumn: "Id",
                keyValue: 200,
                column: "Date",
                value: new DateTime(2025, 7, 20, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2026, 3, 10, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2026, 5, 9, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2026, 3, 15, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 4,
                column: "DueDate",
                value: new DateTime(2026, 5, 14, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 5,
                column: "DueDate",
                value: new DateTime(2026, 3, 20, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 6,
                column: "DueDate",
                value: new DateTime(2026, 5, 19, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 7,
                column: "DueDate",
                value: new DateTime(2026, 3, 26, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 8,
                column: "DueDate",
                value: new DateTime(2026, 5, 25, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 9,
                column: "DueDate",
                value: new DateTime(2026, 3, 31, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 10,
                column: "DueDate",
                value: new DateTime(2026, 5, 30, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 11,
                column: "DueDate",
                value: new DateTime(2026, 4, 5, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 12,
                column: "DueDate",
                value: new DateTime(2026, 6, 4, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 13,
                column: "DueDate",
                value: new DateTime(2026, 4, 10, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 14,
                column: "DueDate",
                value: new DateTime(2026, 2, 14, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 15,
                column: "DueDate",
                value: new DateTime(2026, 4, 15, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 16,
                column: "DueDate",
                value: new DateTime(2026, 2, 19, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 17,
                column: "DueDate",
                value: new DateTime(2026, 4, 20, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 18,
                column: "DueDate",
                value: new DateTime(2026, 2, 24, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 19,
                column: "DueDate",
                value: new DateTime(2026, 4, 26, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 20,
                column: "DueDate",
                value: new DateTime(2026, 3, 2, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 21,
                column: "DueDate",
                value: new DateTime(2026, 5, 1, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 22,
                column: "DueDate",
                value: new DateTime(2026, 3, 7, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 23,
                column: "DueDate",
                value: new DateTime(2026, 5, 6, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 24,
                column: "DueDate",
                value: new DateTime(2026, 3, 12, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 25,
                column: "DueDate",
                value: new DateTime(2026, 5, 11, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 26,
                column: "DueDate",
                value: new DateTime(2026, 3, 17, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 27,
                column: "DueDate",
                value: new DateTime(2026, 5, 16, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 28,
                column: "DueDate",
                value: new DateTime(2026, 3, 22, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 29,
                column: "DueDate",
                value: new DateTime(2026, 5, 21, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 30,
                column: "DueDate",
                value: new DateTime(2026, 3, 27, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 31,
                column: "DueDate",
                value: new DateTime(2026, 5, 26, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 32,
                column: "DueDate",
                value: new DateTime(2026, 4, 2, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 33,
                column: "DueDate",
                value: new DateTime(2026, 6, 1, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 34,
                column: "DueDate",
                value: new DateTime(2026, 4, 7, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 35,
                column: "DueDate",
                value: new DateTime(2026, 2, 11, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 36,
                column: "DueDate",
                value: new DateTime(2026, 4, 12, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 37,
                column: "DueDate",
                value: new DateTime(2026, 2, 16, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 38,
                column: "DueDate",
                value: new DateTime(2026, 4, 17, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 39,
                column: "DueDate",
                value: new DateTime(2026, 2, 21, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 40,
                column: "DueDate",
                value: new DateTime(2026, 4, 22, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 41,
                column: "DueDate",
                value: new DateTime(2026, 2, 26, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 42,
                column: "DueDate",
                value: new DateTime(2026, 4, 27, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 43,
                column: "DueDate",
                value: new DateTime(2026, 3, 3, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 44,
                column: "DueDate",
                value: new DateTime(2026, 5, 2, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 45,
                column: "DueDate",
                value: new DateTime(2026, 3, 9, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 46,
                column: "DueDate",
                value: new DateTime(2026, 5, 8, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 47,
                column: "DueDate",
                value: new DateTime(2026, 3, 14, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 48,
                column: "DueDate",
                value: new DateTime(2026, 5, 13, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 49,
                column: "DueDate",
                value: new DateTime(2026, 3, 19, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 50,
                column: "DueDate",
                value: new DateTime(2026, 5, 18, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 51,
                column: "DueDate",
                value: new DateTime(2026, 3, 24, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 52,
                column: "DueDate",
                value: new DateTime(2026, 5, 23, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 53,
                column: "DueDate",
                value: new DateTime(2026, 3, 29, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 54,
                column: "DueDate",
                value: new DateTime(2026, 5, 28, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 55,
                column: "DueDate",
                value: new DateTime(2026, 4, 3, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 56,
                column: "DueDate",
                value: new DateTime(2026, 6, 2, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 57,
                column: "DueDate",
                value: new DateTime(2026, 4, 9, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 58,
                column: "DueDate",
                value: new DateTime(2026, 2, 13, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 59,
                column: "DueDate",
                value: new DateTime(2026, 4, 14, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 60,
                column: "DueDate",
                value: new DateTime(2026, 2, 18, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 61,
                column: "DueDate",
                value: new DateTime(2026, 4, 19, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 62,
                column: "DueDate",
                value: new DateTime(2026, 2, 23, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 63,
                column: "DueDate",
                value: new DateTime(2026, 4, 24, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 64,
                column: "DueDate",
                value: new DateTime(2026, 2, 28, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 65,
                column: "DueDate",
                value: new DateTime(2026, 4, 29, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 66,
                column: "DueDate",
                value: new DateTime(2026, 3, 5, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 67,
                column: "DueDate",
                value: new DateTime(2026, 5, 4, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 68,
                column: "DueDate",
                value: new DateTime(2026, 3, 10, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 69,
                column: "DueDate",
                value: new DateTime(2026, 5, 9, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 70,
                column: "DueDate",
                value: new DateTime(2026, 3, 16, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 71,
                column: "DueDate",
                value: new DateTime(2026, 5, 15, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 72,
                column: "DueDate",
                value: new DateTime(2026, 3, 21, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 73,
                column: "DueDate",
                value: new DateTime(2026, 5, 20, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 74,
                column: "DueDate",
                value: new DateTime(2026, 3, 26, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 75,
                column: "DueDate",
                value: new DateTime(2026, 5, 25, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 76,
                column: "DueDate",
                value: new DateTime(2026, 3, 31, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 77,
                column: "DueDate",
                value: new DateTime(2026, 5, 30, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 78,
                column: "DueDate",
                value: new DateTime(2026, 4, 5, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 79,
                column: "DueDate",
                value: new DateTime(2026, 6, 4, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 80,
                column: "DueDate",
                value: new DateTime(2026, 4, 10, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 81,
                column: "DueDate",
                value: new DateTime(2026, 2, 14, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 82,
                column: "DueDate",
                value: new DateTime(2026, 4, 15, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 83,
                column: "DueDate",
                value: new DateTime(2026, 2, 20, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 84,
                column: "DueDate",
                value: new DateTime(2026, 4, 21, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 85,
                column: "DueDate",
                value: new DateTime(2026, 2, 25, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 86,
                column: "DueDate",
                value: new DateTime(2026, 4, 26, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 87,
                column: "DueDate",
                value: new DateTime(2026, 3, 2, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 88,
                column: "DueDate",
                value: new DateTime(2026, 5, 1, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 89,
                column: "DueDate",
                value: new DateTime(2026, 3, 7, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 90,
                column: "DueDate",
                value: new DateTime(2026, 5, 6, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 91,
                column: "DueDate",
                value: new DateTime(2026, 3, 12, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 92,
                column: "DueDate",
                value: new DateTime(2026, 5, 11, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 93,
                column: "DueDate",
                value: new DateTime(2026, 3, 17, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 94,
                column: "DueDate",
                value: new DateTime(2026, 5, 16, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 95,
                column: "DueDate",
                value: new DateTime(2026, 3, 23, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 96,
                column: "DueDate",
                value: new DateTime(2026, 5, 22, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 97,
                column: "DueDate",
                value: new DateTime(2026, 3, 28, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 98,
                column: "DueDate",
                value: new DateTime(2026, 5, 27, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 99,
                column: "DueDate",
                value: new DateTime(2026, 4, 2, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "ProjectRecords",
                keyColumn: "Id",
                keyValue: 100,
                column: "DueDate",
                value: new DateTime(2026, 6, 1, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 31, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 1, 26, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2026, 1, 5, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 12, 5, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2026, 1, 21, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2026, 1, 16, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2026, 2, 2, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2026, 1, 29, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2026, 1, 5, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2026, 1, 24, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 11, 5, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2026, 2, 1, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2026, 1, 23, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2026, 1, 22, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2026, 1, 21, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2026, 1, 20, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2026, 1, 19, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2026, 1, 18, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2026, 1, 17, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2026, 1, 16, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2026, 1, 15, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2026, 1, 14, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2026, 1, 13, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2026, 1, 12, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2026, 1, 11, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2026, 1, 10, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2026, 1, 9, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2026, 1, 8, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2026, 1, 7, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2026, 1, 6, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2026, 1, 5, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2026, 1, 4, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 33,
                column: "Date",
                value: new DateTime(2026, 1, 3, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 34,
                column: "Date",
                value: new DateTime(2026, 1, 2, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 35,
                column: "Date",
                value: new DateTime(2026, 1, 1, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2025, 12, 31, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 37,
                column: "Date",
                value: new DateTime(2025, 12, 30, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 38,
                column: "Date",
                value: new DateTime(2025, 12, 29, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 39,
                column: "Date",
                value: new DateTime(2025, 12, 28, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 40,
                column: "Date",
                value: new DateTime(2025, 12, 27, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 41,
                column: "Date",
                value: new DateTime(2025, 12, 26, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 42,
                column: "Date",
                value: new DateTime(2025, 12, 25, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 43,
                column: "Date",
                value: new DateTime(2025, 12, 24, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 44,
                column: "Date",
                value: new DateTime(2025, 12, 23, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 45,
                column: "Date",
                value: new DateTime(2025, 12, 22, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 46,
                column: "Date",
                value: new DateTime(2025, 12, 21, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 47,
                column: "Date",
                value: new DateTime(2025, 12, 20, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 48,
                column: "Date",
                value: new DateTime(2025, 12, 19, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 49,
                column: "Date",
                value: new DateTime(2025, 12, 18, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 50,
                column: "Date",
                value: new DateTime(2025, 12, 17, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 51,
                column: "Date",
                value: new DateTime(2025, 12, 16, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 52,
                column: "Date",
                value: new DateTime(2025, 12, 15, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 53,
                column: "Date",
                value: new DateTime(2025, 12, 14, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 54,
                column: "Date",
                value: new DateTime(2025, 12, 13, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 55,
                column: "Date",
                value: new DateTime(2025, 12, 12, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 56,
                column: "Date",
                value: new DateTime(2025, 12, 11, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 57,
                column: "Date",
                value: new DateTime(2025, 12, 10, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 58,
                column: "Date",
                value: new DateTime(2025, 12, 9, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 59,
                column: "Date",
                value: new DateTime(2025, 12, 8, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 60,
                column: "Date",
                value: new DateTime(2025, 12, 7, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 61,
                column: "Date",
                value: new DateTime(2025, 12, 6, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 62,
                column: "Date",
                value: new DateTime(2025, 12, 5, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 63,
                column: "Date",
                value: new DateTime(2025, 12, 4, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 64,
                column: "Date",
                value: new DateTime(2025, 12, 3, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 65,
                column: "Date",
                value: new DateTime(2025, 12, 2, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 66,
                column: "Date",
                value: new DateTime(2025, 12, 1, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 67,
                column: "Date",
                value: new DateTime(2025, 11, 30, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 68,
                column: "Date",
                value: new DateTime(2025, 11, 29, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 69,
                column: "Date",
                value: new DateTime(2025, 11, 28, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 70,
                column: "Date",
                value: new DateTime(2025, 11, 27, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 71,
                column: "Date",
                value: new DateTime(2025, 11, 26, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 72,
                column: "Date",
                value: new DateTime(2025, 11, 25, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 73,
                column: "Date",
                value: new DateTime(2025, 11, 24, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 74,
                column: "Date",
                value: new DateTime(2025, 11, 23, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 75,
                column: "Date",
                value: new DateTime(2025, 11, 22, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 76,
                column: "Date",
                value: new DateTime(2025, 11, 21, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 77,
                column: "Date",
                value: new DateTime(2025, 11, 20, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 78,
                column: "Date",
                value: new DateTime(2025, 11, 19, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 79,
                column: "Date",
                value: new DateTime(2025, 11, 18, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 80,
                column: "Date",
                value: new DateTime(2025, 11, 17, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 81,
                column: "Date",
                value: new DateTime(2025, 11, 16, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 82,
                column: "Date",
                value: new DateTime(2025, 11, 15, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 83,
                column: "Date",
                value: new DateTime(2025, 11, 14, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 84,
                column: "Date",
                value: new DateTime(2025, 11, 13, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 85,
                column: "Date",
                value: new DateTime(2025, 11, 12, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 86,
                column: "Date",
                value: new DateTime(2025, 11, 11, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 87,
                column: "Date",
                value: new DateTime(2025, 11, 10, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 88,
                column: "Date",
                value: new DateTime(2025, 11, 9, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 89,
                column: "Date",
                value: new DateTime(2025, 11, 8, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 90,
                column: "Date",
                value: new DateTime(2025, 11, 7, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 91,
                column: "Date",
                value: new DateTime(2025, 11, 6, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 92,
                column: "Date",
                value: new DateTime(2025, 11, 5, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 93,
                column: "Date",
                value: new DateTime(2025, 11, 4, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 94,
                column: "Date",
                value: new DateTime(2025, 11, 3, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 95,
                column: "Date",
                value: new DateTime(2025, 11, 2, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 96,
                column: "Date",
                value: new DateTime(2025, 11, 1, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 97,
                column: "Date",
                value: new DateTime(2025, 10, 31, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 98,
                column: "Date",
                value: new DateTime(2025, 10, 30, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 99,
                column: "Date",
                value: new DateTime(2025, 10, 29, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 100,
                column: "Date",
                value: new DateTime(2025, 10, 28, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8150));
        }
    }
}
