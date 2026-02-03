using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorWebApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedDataToSuedaAkca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedTo", "Date" },
                values: new object[] { "Sueda Akça", new DateTime(2026, 1, 29, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 1, 24, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2026, 1, 3, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 12, 3, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2026, 1, 19, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2026, 1, 14, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AssignedTo", "Date" },
                values: new object[] { "Sueda Akça", new DateTime(2026, 1, 31, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2026, 1, 27, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2026, 1, 3, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2026, 1, 22, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 11, 3, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2026, 1, 30, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.InsertData(
                table: "SampleDatas",
                columns: new[] { "Id", "AssignedTo", "Branch", "Category", "Customer", "Date", "Description", "Name", "PaymentStatus", "Priority", "Project", "Region", "Status", "Value", "Year" },
                values: new object[,]
                {
                    { 13, "Sueda Akça", "Ankara", "Ticari", "Müşteri 3", new DateTime(2026, 1, 21, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6480), "Açıklama metni 13", "Örnek Proje 13", "Pending", "Medium", "Beta", "Bölge 3", "Active", 1300000m, 2023 },
                    { 14, "Sueda Akça", "İzmir", "İnşaat", "Müşteri 4", new DateTime(2026, 1, 20, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6500), "Açıklama metni 14", "Örnek Proje 14", "Overdue", "Low", "Gamma", "Bölge 4", "Active", 1400000m, 2024 },
                    { 15, "Sueda Akça", "İstanbul", "Ticari", "Müşteri 5", new DateTime(2026, 1, 19, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6530), "Açıklama metni 15", "Örnek Proje 15", "Paid", "High", "Delta", "Bölge 0", "Active", 1500000m, 2020 },
                    { 16, "Sueda Akça", "Ankara", "İnşaat", "Müşteri 6", new DateTime(2026, 1, 18, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6540), "Açıklama metni 16", "Örnek Proje 16", "Pending", "Medium", "Alpha", "Bölge 1", "Active", 1600000m, 2021 },
                    { 17, "Sueda Akça", "İzmir", "Ticari", "Müşteri 7", new DateTime(2026, 1, 17, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6550), "Açıklama metni 17", "Örnek Proje 17", "Overdue", "Low", "Beta", "Bölge 2", "Active", 1700000m, 2022 },
                    { 18, "Sueda Akça", "İstanbul", "İnşaat", "Müşteri 8", new DateTime(2026, 1, 16, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6560), "Açıklama metni 18", "Örnek Proje 18", "Paid", "High", "Gamma", "Bölge 3", "Active", 1800000m, 2023 },
                    { 19, "Sueda Akça", "Ankara", "Ticari", "Müşteri 9", new DateTime(2026, 1, 15, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6620), "Açıklama metni 19", "Örnek Proje 19", "Pending", "Medium", "Delta", "Bölge 4", "Active", 1900000m, 2024 },
                    { 20, "Sueda Akça", "İzmir", "İnşaat", "Müşteri 0", new DateTime(2026, 1, 14, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6630), "Açıklama metni 20", "Örnek Proje 20", "Overdue", "Low", "Alpha", "Bölge 0", "Active", 2000000m, 2020 },
                    { 21, "Sueda Akça", "İstanbul", "Ticari", "Müşteri 1", new DateTime(2026, 1, 13, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6640), "Açıklama metni 21", "Örnek Proje 21", "Paid", "High", "Beta", "Bölge 1", "Active", 2100000m, 2021 },
                    { 22, "Sueda Akça", "Ankara", "İnşaat", "Müşteri 2", new DateTime(2026, 1, 12, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6650), "Açıklama metni 22", "Örnek Proje 22", "Pending", "Medium", "Gamma", "Bölge 2", "Active", 2200000m, 2022 },
                    { 23, "Sueda Akça", "İzmir", "Ticari", "Müşteri 3", new DateTime(2026, 1, 11, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6660), "Açıklama metni 23", "Örnek Proje 23", "Overdue", "Low", "Delta", "Bölge 3", "Active", 2300000m, 2023 },
                    { 24, "Sueda Akça", "İstanbul", "İnşaat", "Müşteri 4", new DateTime(2026, 1, 10, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6670), "Açıklama metni 24", "Örnek Proje 24", "Paid", "High", "Alpha", "Bölge 4", "Active", 2400000m, 2024 },
                    { 25, "Sueda Akça", "Ankara", "Ticari", "Müşteri 5", new DateTime(2026, 1, 9, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6680), "Açıklama metni 25", "Örnek Proje 25", "Pending", "Medium", "Beta", "Bölge 0", "Active", 2500000m, 2020 },
                    { 26, "Sueda Akça", "İzmir", "İnşaat", "Müşteri 6", new DateTime(2026, 1, 8, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6690), "Açıklama metni 26", "Örnek Proje 26", "Overdue", "Low", "Gamma", "Bölge 1", "Active", 2600000m, 2021 },
                    { 27, "Sueda Akça", "İstanbul", "Ticari", "Müşteri 7", new DateTime(2026, 1, 7, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6700), "Açıklama metni 27", "Örnek Proje 27", "Paid", "High", "Delta", "Bölge 2", "Active", 2700000m, 2022 },
                    { 28, "Sueda Akça", "Ankara", "İnşaat", "Müşteri 8", new DateTime(2026, 1, 6, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6710), "Açıklama metni 28", "Örnek Proje 28", "Pending", "Medium", "Alpha", "Bölge 3", "Active", 2800000m, 2023 },
                    { 29, "Sueda Akça", "İzmir", "Ticari", "Müşteri 9", new DateTime(2026, 1, 5, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6730), "Açıklama metni 29", "Örnek Proje 29", "Overdue", "Low", "Beta", "Bölge 4", "Active", 2900000m, 2024 },
                    { 30, "Sueda Akça", "İstanbul", "İnşaat", "Müşteri 0", new DateTime(2026, 1, 4, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6740), "Açıklama metni 30", "Örnek Proje 30", "Paid", "High", "Gamma", "Bölge 0", "Active", 3000000m, 2020 },
                    { 31, "Sueda Akça", "Ankara", "Ticari", "Müşteri 1", new DateTime(2026, 1, 3, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6750), "Açıklama metni 31", "Örnek Proje 31", "Pending", "Medium", "Delta", "Bölge 1", "Active", 3100000m, 2021 },
                    { 32, "Sueda Akça", "İzmir", "İnşaat", "Müşteri 2", new DateTime(2026, 1, 2, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6760), "Açıklama metni 32", "Örnek Proje 32", "Overdue", "Low", "Alpha", "Bölge 2", "Active", 3200000m, 2022 },
                    { 33, "Sueda Akça", "İstanbul", "Ticari", "Müşteri 3", new DateTime(2026, 1, 1, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6770), "Açıklama metni 33", "Örnek Proje 33", "Paid", "High", "Beta", "Bölge 3", "Active", 3300000m, 2023 },
                    { 34, "Sueda Akça", "Ankara", "İnşaat", "Müşteri 4", new DateTime(2025, 12, 31, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6780), "Açıklama metni 34", "Örnek Proje 34", "Pending", "Medium", "Gamma", "Bölge 4", "Active", 3400000m, 2024 },
                    { 35, "Sueda Akça", "İzmir", "Ticari", "Müşteri 5", new DateTime(2025, 12, 30, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6790), "Açıklama metni 35", "Örnek Proje 35", "Overdue", "Low", "Delta", "Bölge 0", "Active", 3500000m, 2020 },
                    { 36, "Sueda Akça", "İstanbul", "İnşaat", "Müşteri 6", new DateTime(2025, 12, 29, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6800), "Açıklama metni 36", "Örnek Proje 36", "Paid", "High", "Alpha", "Bölge 1", "Active", 3600000m, 2021 },
                    { 37, "Sueda Akça", "Ankara", "Ticari", "Müşteri 7", new DateTime(2025, 12, 28, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6810), "Açıklama metni 37", "Örnek Proje 37", "Pending", "Medium", "Beta", "Bölge 2", "Active", 3700000m, 2022 },
                    { 38, "Sueda Akça", "İzmir", "İnşaat", "Müşteri 8", new DateTime(2025, 12, 27, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6820), "Açıklama metni 38", "Örnek Proje 38", "Overdue", "Low", "Gamma", "Bölge 3", "Active", 3800000m, 2023 },
                    { 39, "Sueda Akça", "İstanbul", "Ticari", "Müşteri 9", new DateTime(2025, 12, 26, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6830), "Açıklama metni 39", "Örnek Proje 39", "Paid", "High", "Delta", "Bölge 4", "Active", 3900000m, 2024 },
                    { 40, "Sueda Akça", "Ankara", "İnşaat", "Müşteri 0", new DateTime(2025, 12, 25, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6840), "Açıklama metni 40", "Örnek Proje 40", "Pending", "Medium", "Alpha", "Bölge 0", "Active", 4000000m, 2020 },
                    { 41, "Sueda Akça", "İzmir", "Ticari", "Müşteri 1", new DateTime(2025, 12, 24, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6850), "Açıklama metni 41", "Örnek Proje 41", "Overdue", "Low", "Beta", "Bölge 1", "Active", 4100000m, 2021 },
                    { 42, "Sueda Akça", "İstanbul", "İnşaat", "Müşteri 2", new DateTime(2025, 12, 23, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6860), "Açıklama metni 42", "Örnek Proje 42", "Paid", "High", "Gamma", "Bölge 2", "Active", 4200000m, 2022 },
                    { 43, "Sueda Akça", "Ankara", "Ticari", "Müşteri 3", new DateTime(2025, 12, 22, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6880), "Açıklama metni 43", "Örnek Proje 43", "Pending", "Medium", "Delta", "Bölge 3", "Active", 4300000m, 2023 },
                    { 44, "Sueda Akça", "İzmir", "İnşaat", "Müşteri 4", new DateTime(2025, 12, 21, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6890), "Açıklama metni 44", "Örnek Proje 44", "Overdue", "Low", "Alpha", "Bölge 4", "Active", 4400000m, 2024 },
                    { 45, "Sueda Akça", "İstanbul", "Ticari", "Müşteri 5", new DateTime(2025, 12, 20, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6900), "Açıklama metni 45", "Örnek Proje 45", "Paid", "High", "Beta", "Bölge 0", "Active", 4500000m, 2020 },
                    { 46, "Sueda Akça", "Ankara", "İnşaat", "Müşteri 6", new DateTime(2025, 12, 19, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6910), "Açıklama metni 46", "Örnek Proje 46", "Pending", "Medium", "Gamma", "Bölge 1", "Active", 4600000m, 2021 },
                    { 47, "Sueda Akça", "İzmir", "Ticari", "Müşteri 7", new DateTime(2025, 12, 18, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6920), "Açıklama metni 47", "Örnek Proje 47", "Overdue", "Low", "Delta", "Bölge 2", "Active", 4700000m, 2022 },
                    { 48, "Sueda Akça", "İstanbul", "İnşaat", "Müşteri 8", new DateTime(2025, 12, 17, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6930), "Açıklama metni 48", "Örnek Proje 48", "Paid", "High", "Alpha", "Bölge 3", "Active", 4800000m, 2023 },
                    { 49, "Sueda Akça", "Ankara", "Ticari", "Müşteri 9", new DateTime(2025, 12, 16, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6940), "Açıklama metni 49", "Örnek Proje 49", "Pending", "Medium", "Beta", "Bölge 4", "Active", 4900000m, 2024 },
                    { 50, "Sueda Akça", "İzmir", "İnşaat", "Müşteri 0", new DateTime(2025, 12, 15, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6950), "Açıklama metni 50", "Örnek Proje 50", "Overdue", "Low", "Gamma", "Bölge 0", "Active", 5000000m, 2020 },
                    { 51, "Sueda Akça", "İstanbul", "Ticari", "Müşteri 1", new DateTime(2025, 12, 14, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6960), "Açıklama metni 51", "Örnek Proje 51", "Paid", "High", "Delta", "Bölge 1", "Active", 5100000m, 2021 },
                    { 52, "Sueda Akça", "Ankara", "İnşaat", "Müşteri 2", new DateTime(2025, 12, 13, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6980), "Açıklama metni 52", "Örnek Proje 52", "Pending", "Medium", "Alpha", "Bölge 2", "Active", 5200000m, 2022 },
                    { 53, "Sueda Akça", "İzmir", "Ticari", "Müşteri 3", new DateTime(2025, 12, 12, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6990), "Açıklama metni 53", "Örnek Proje 53", "Overdue", "Low", "Beta", "Bölge 3", "Active", 5300000m, 2023 },
                    { 54, "Sueda Akça", "İstanbul", "İnşaat", "Müşteri 4", new DateTime(2025, 12, 11, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7000), "Açıklama metni 54", "Örnek Proje 54", "Paid", "High", "Gamma", "Bölge 4", "Active", 5400000m, 2024 },
                    { 55, "Sueda Akça", "Ankara", "Ticari", "Müşteri 5", new DateTime(2025, 12, 10, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7010), "Açıklama metni 55", "Örnek Proje 55", "Pending", "Medium", "Delta", "Bölge 0", "Active", 5500000m, 2020 },
                    { 56, "Sueda Akça", "İzmir", "İnşaat", "Müşteri 6", new DateTime(2025, 12, 9, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7020), "Açıklama metni 56", "Örnek Proje 56", "Overdue", "Low", "Alpha", "Bölge 1", "Active", 5600000m, 2021 },
                    { 57, "Sueda Akça", "İstanbul", "Ticari", "Müşteri 7", new DateTime(2025, 12, 8, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7030), "Açıklama metni 57", "Örnek Proje 57", "Paid", "High", "Beta", "Bölge 2", "Active", 5700000m, 2022 },
                    { 58, "Sueda Akça", "Ankara", "İnşaat", "Müşteri 8", new DateTime(2025, 12, 7, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7040), "Açıklama metni 58", "Örnek Proje 58", "Pending", "Medium", "Gamma", "Bölge 3", "Active", 5800000m, 2023 },
                    { 59, "Sueda Akça", "İzmir", "Ticari", "Müşteri 9", new DateTime(2025, 12, 6, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7050), "Açıklama metni 59", "Örnek Proje 59", "Overdue", "Low", "Delta", "Bölge 4", "Active", 5900000m, 2024 },
                    { 60, "Sueda Akça", "İstanbul", "İnşaat", "Müşteri 0", new DateTime(2025, 12, 5, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7060), "Açıklama metni 60", "Örnek Proje 60", "Paid", "High", "Alpha", "Bölge 0", "Active", 6000000m, 2020 },
                    { 61, "Sueda Akça", "Ankara", "Ticari", "Müşteri 1", new DateTime(2025, 12, 4, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7070), "Açıklama metni 61", "Örnek Proje 61", "Pending", "Medium", "Beta", "Bölge 1", "Active", 6100000m, 2021 },
                    { 62, "Sueda Akça", "İzmir", "İnşaat", "Müşteri 2", new DateTime(2025, 12, 3, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7080), "Açıklama metni 62", "Örnek Proje 62", "Overdue", "Low", "Gamma", "Bölge 2", "Active", 6200000m, 2022 },
                    { 63, "Sueda Akça", "İstanbul", "Ticari", "Müşteri 3", new DateTime(2025, 12, 2, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7090), "Açıklama metni 63", "Örnek Proje 63", "Paid", "High", "Delta", "Bölge 3", "Active", 6300000m, 2023 },
                    { 64, "Sueda Akça", "Ankara", "İnşaat", "Müşteri 4", new DateTime(2025, 12, 1, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7100), "Açıklama metni 64", "Örnek Proje 64", "Pending", "Medium", "Alpha", "Bölge 4", "Active", 6400000m, 2024 },
                    { 65, "Sueda Akça", "İzmir", "Ticari", "Müşteri 5", new DateTime(2025, 11, 30, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7110), "Açıklama metni 65", "Örnek Proje 65", "Overdue", "Low", "Beta", "Bölge 0", "Active", 6500000m, 2020 },
                    { 66, "Sueda Akça", "İstanbul", "İnşaat", "Müşteri 6", new DateTime(2025, 11, 29, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7120), "Açıklama metni 66", "Örnek Proje 66", "Paid", "High", "Gamma", "Bölge 1", "Active", 6600000m, 2021 },
                    { 67, "Sueda Akça", "Ankara", "Ticari", "Müşteri 7", new DateTime(2025, 11, 28, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7130), "Açıklama metni 67", "Örnek Proje 67", "Pending", "Medium", "Delta", "Bölge 2", "Active", 6700000m, 2022 },
                    { 68, "Sueda Akça", "İzmir", "İnşaat", "Müşteri 8", new DateTime(2025, 11, 27, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7140), "Açıklama metni 68", "Örnek Proje 68", "Overdue", "Low", "Alpha", "Bölge 3", "Active", 6800000m, 2023 },
                    { 69, "Sueda Akça", "İstanbul", "Ticari", "Müşteri 9", new DateTime(2025, 11, 26, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7150), "Açıklama metni 69", "Örnek Proje 69", "Paid", "High", "Beta", "Bölge 4", "Active", 6900000m, 2024 },
                    { 70, "Sueda Akça", "Ankara", "İnşaat", "Müşteri 0", new DateTime(2025, 11, 25, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7160), "Açıklama metni 70", "Örnek Proje 70", "Pending", "Medium", "Gamma", "Bölge 0", "Active", 7000000m, 2020 },
                    { 71, "Sueda Akça", "İzmir", "Ticari", "Müşteri 1", new DateTime(2025, 11, 24, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7220), "Açıklama metni 71", "Örnek Proje 71", "Overdue", "Low", "Delta", "Bölge 1", "Active", 7100000m, 2021 },
                    { 72, "Sueda Akça", "İstanbul", "İnşaat", "Müşteri 2", new DateTime(2025, 11, 23, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7230), "Açıklama metni 72", "Örnek Proje 72", "Paid", "High", "Alpha", "Bölge 2", "Active", 7200000m, 2022 },
                    { 73, "Sueda Akça", "Ankara", "Ticari", "Müşteri 3", new DateTime(2025, 11, 22, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7240), "Açıklama metni 73", "Örnek Proje 73", "Pending", "Medium", "Beta", "Bölge 3", "Active", 7300000m, 2023 },
                    { 74, "Sueda Akça", "İzmir", "İnşaat", "Müşteri 4", new DateTime(2025, 11, 21, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7250), "Açıklama metni 74", "Örnek Proje 74", "Overdue", "Low", "Gamma", "Bölge 4", "Active", 7400000m, 2024 },
                    { 75, "Sueda Akça", "İstanbul", "Ticari", "Müşteri 5", new DateTime(2025, 11, 20, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7260), "Açıklama metni 75", "Örnek Proje 75", "Paid", "High", "Delta", "Bölge 0", "Active", 7500000m, 2020 },
                    { 76, "Sueda Akça", "Ankara", "İnşaat", "Müşteri 6", new DateTime(2025, 11, 19, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7270), "Açıklama metni 76", "Örnek Proje 76", "Pending", "Medium", "Alpha", "Bölge 1", "Active", 7600000m, 2021 },
                    { 77, "Sueda Akça", "İzmir", "Ticari", "Müşteri 7", new DateTime(2025, 11, 18, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7280), "Açıklama metni 77", "Örnek Proje 77", "Overdue", "Low", "Beta", "Bölge 2", "Active", 7700000m, 2022 },
                    { 78, "Sueda Akça", "İstanbul", "İnşaat", "Müşteri 8", new DateTime(2025, 11, 17, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7290), "Açıklama metni 78", "Örnek Proje 78", "Paid", "High", "Gamma", "Bölge 3", "Active", 7800000m, 2023 },
                    { 79, "Sueda Akça", "Ankara", "Ticari", "Müşteri 9", new DateTime(2025, 11, 16, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7300), "Açıklama metni 79", "Örnek Proje 79", "Pending", "Medium", "Delta", "Bölge 4", "Active", 7900000m, 2024 },
                    { 80, "Sueda Akça", "İzmir", "İnşaat", "Müşteri 0", new DateTime(2025, 11, 15, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7310), "Açıklama metni 80", "Örnek Proje 80", "Overdue", "Low", "Alpha", "Bölge 0", "Active", 8000000m, 2020 },
                    { 81, "Sueda Akça", "İstanbul", "Ticari", "Müşteri 1", new DateTime(2025, 11, 14, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7320), "Açıklama metni 81", "Örnek Proje 81", "Paid", "High", "Beta", "Bölge 1", "Active", 8100000m, 2021 },
                    { 82, "Sueda Akça", "Ankara", "İnşaat", "Müşteri 2", new DateTime(2025, 11, 13, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7330), "Açıklama metni 82", "Örnek Proje 82", "Pending", "Medium", "Gamma", "Bölge 2", "Active", 8200000m, 2022 },
                    { 83, "Sueda Akça", "İzmir", "Ticari", "Müşteri 3", new DateTime(2025, 11, 12, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7340), "Açıklama metni 83", "Örnek Proje 83", "Overdue", "Low", "Delta", "Bölge 3", "Active", 8300000m, 2023 },
                    { 84, "Sueda Akça", "İstanbul", "İnşaat", "Müşteri 4", new DateTime(2025, 11, 11, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7350), "Açıklama metni 84", "Örnek Proje 84", "Paid", "High", "Alpha", "Bölge 4", "Active", 8400000m, 2024 },
                    { 85, "Sueda Akça", "Ankara", "Ticari", "Müşteri 5", new DateTime(2025, 11, 10, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7360), "Açıklama metni 85", "Örnek Proje 85", "Pending", "Medium", "Beta", "Bölge 0", "Active", 8500000m, 2020 },
                    { 86, "Sueda Akça", "İzmir", "İnşaat", "Müşteri 6", new DateTime(2025, 11, 9, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7370), "Açıklama metni 86", "Örnek Proje 86", "Overdue", "Low", "Gamma", "Bölge 1", "Active", 8600000m, 2021 },
                    { 87, "Sueda Akça", "İstanbul", "Ticari", "Müşteri 7", new DateTime(2025, 11, 8, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7380), "Açıklama metni 87", "Örnek Proje 87", "Paid", "High", "Delta", "Bölge 2", "Active", 8700000m, 2022 },
                    { 88, "Sueda Akça", "Ankara", "İnşaat", "Müşteri 8", new DateTime(2025, 11, 7, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7390), "Açıklama metni 88", "Örnek Proje 88", "Pending", "Medium", "Alpha", "Bölge 3", "Active", 8800000m, 2023 },
                    { 89, "Sueda Akça", "İzmir", "Ticari", "Müşteri 9", new DateTime(2025, 11, 6, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7400), "Açıklama metni 89", "Örnek Proje 89", "Overdue", "Low", "Beta", "Bölge 4", "Active", 8900000m, 2024 },
                    { 90, "Sueda Akça", "İstanbul", "İnşaat", "Müşteri 0", new DateTime(2025, 11, 5, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7410), "Açıklama metni 90", "Örnek Proje 90", "Paid", "High", "Gamma", "Bölge 0", "Active", 9000000m, 2020 },
                    { 91, "Sueda Akça", "Ankara", "Ticari", "Müşteri 1", new DateTime(2025, 11, 4, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7420), "Açıklama metni 91", "Örnek Proje 91", "Pending", "Medium", "Delta", "Bölge 1", "Active", 9100000m, 2021 },
                    { 92, "Sueda Akça", "İzmir", "İnşaat", "Müşteri 2", new DateTime(2025, 11, 3, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7430), "Açıklama metni 92", "Örnek Proje 92", "Overdue", "Low", "Alpha", "Bölge 2", "Active", 9200000m, 2022 },
                    { 93, "Sueda Akça", "İstanbul", "Ticari", "Müşteri 3", new DateTime(2025, 11, 2, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7440), "Açıklama metni 93", "Örnek Proje 93", "Paid", "High", "Beta", "Bölge 3", "Active", 9300000m, 2023 },
                    { 94, "Sueda Akça", "Ankara", "İnşaat", "Müşteri 4", new DateTime(2025, 11, 1, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7450), "Açıklama metni 94", "Örnek Proje 94", "Pending", "Medium", "Gamma", "Bölge 4", "Active", 9400000m, 2024 },
                    { 95, "Sueda Akça", "İzmir", "Ticari", "Müşteri 5", new DateTime(2025, 10, 31, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7460), "Açıklama metni 95", "Örnek Proje 95", "Overdue", "Low", "Delta", "Bölge 0", "Active", 9500000m, 2020 },
                    { 96, "Sueda Akça", "İstanbul", "İnşaat", "Müşteri 6", new DateTime(2025, 10, 30, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7470), "Açıklama metni 96", "Örnek Proje 96", "Paid", "High", "Alpha", "Bölge 1", "Active", 9600000m, 2021 },
                    { 97, "Sueda Akça", "Ankara", "Ticari", "Müşteri 7", new DateTime(2025, 10, 29, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7480), "Açıklama metni 97", "Örnek Proje 97", "Pending", "Medium", "Beta", "Bölge 2", "Active", 9700000m, 2022 },
                    { 98, "Sueda Akça", "İzmir", "İnşaat", "Müşteri 8", new DateTime(2025, 10, 28, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7490), "Açıklama metni 98", "Örnek Proje 98", "Overdue", "Low", "Gamma", "Bölge 3", "Active", 9800000m, 2023 },
                    { 99, "Sueda Akça", "İstanbul", "Ticari", "Müşteri 9", new DateTime(2025, 10, 27, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7500), "Açıklama metni 99", "Örnek Proje 99", "Paid", "High", "Delta", "Bölge 4", "Active", 9900000m, 2024 },
                    { 100, "Sueda Akça", "Ankara", "İnşaat", "Müşteri 0", new DateTime(2025, 10, 26, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7520), "Açıklama metni 100", "Örnek Proje 100", "Pending", "Medium", "Alpha", "Bölge 0", "Active", 10000000m, 2020 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedTo", "Date" },
                values: new object[] { "Ali Yılmaz", new DateTime(2026, 1, 25, 11, 11, 7, 958, DateTimeKind.Local).AddTicks(3020) });

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

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AssignedTo", "Date" },
                values: new object[] { "Selin Ak", new DateTime(2026, 1, 27, 11, 11, 7, 958, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2026, 1, 23, 11, 11, 7, 958, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2025, 12, 30, 11, 11, 7, 958, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2026, 1, 18, 11, 11, 7, 958, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 10, 30, 11, 11, 7, 958, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2026, 1, 26, 11, 11, 7, 958, DateTimeKind.Local).AddTicks(3110));
        }
    }
}
