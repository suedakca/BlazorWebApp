using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddPoolTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CommercialRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommercialRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PoolDefinitions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoolDefinitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Progress = table.Column<int>(type: "int", nullable: false),
                    Budget = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PoolColumns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PoolDefinitionId = table.Column<int>(type: "int", nullable: false),
                    HeaderText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Width = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CssClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeaderCssClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderIndex = table.Column<int>(type: "int", nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoolColumns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PoolColumns_PoolDefinitions_PoolDefinitionId",
                        column: x => x.PoolDefinitionId,
                        principalTable: "PoolDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CommercialRecords",
                columns: new[] { "Id", "Amount", "Category", "CustomerName", "Date", "RefNo", "Region", "Status" },
                values: new object[,]
                {
                    { 1, 1137.5m, "Bireysel", "Müşteri 2 A.Ş.", new DateTime(2026, 2, 4, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8240), "REF-100001", "Ege", "Aktif" },
                    { 2, 1275m, "Kamu", "Müşteri 3 A.Ş.", new DateTime(2026, 2, 3, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8300), "REF-100002", "İç Anadolu", "Aktif" },
                    { 3, 1412.5m, "Kurumsal", "Müşteri 4 A.Ş.", new DateTime(2026, 2, 2, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8310), "REF-100003", "Akdeniz", "Bekliyor" },
                    { 4, 1550m, "Bireysel", "Müşteri 5 A.Ş.", new DateTime(2026, 2, 1, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8330), "REF-100004", "Marmara", "Aktif" },
                    { 5, 1687.5m, "Kamu", "Müşteri 6 A.Ş.", new DateTime(2026, 1, 31, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8340), "REF-100005", "Ege", "Pasif" },
                    { 6, 1825m, "Kurumsal", "Müşteri 7 A.Ş.", new DateTime(2026, 1, 30, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8350), "REF-100006", "İç Anadolu", "Bekliyor" },
                    { 7, 1962.5m, "Bireysel", "Müşteri 8 A.Ş.", new DateTime(2026, 1, 29, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8360), "REF-100007", "Akdeniz", "Aktif" },
                    { 8, 2100m, "Kamu", "Müşteri 9 A.Ş.", new DateTime(2026, 1, 28, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8370), "REF-100008", "Marmara", "Aktif" },
                    { 9, 2237.5m, "Kurumsal", "Müşteri 10 A.Ş.", new DateTime(2026, 1, 27, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8380), "REF-100009", "Ege", "Bekliyor" },
                    { 10, 2375m, "Bireysel", "Müşteri 11 A.Ş.", new DateTime(2026, 1, 26, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8390), "REF-100010", "İç Anadolu", "Pasif" },
                    { 11, 2512.5m, "Kamu", "Müşteri 12 A.Ş.", new DateTime(2026, 1, 25, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8410), "REF-100011", "Akdeniz", "Aktif" },
                    { 12, 2650m, "Kurumsal", "Müşteri 13 A.Ş.", new DateTime(2026, 1, 24, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8420), "REF-100012", "Marmara", "Bekliyor" },
                    { 13, 2787.5m, "Bireysel", "Müşteri 14 A.Ş.", new DateTime(2026, 1, 23, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8430), "REF-100013", "Ege", "Aktif" },
                    { 14, 2925m, "Kamu", "Müşteri 15 A.Ş.", new DateTime(2026, 1, 22, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8440), "REF-100014", "İç Anadolu", "Aktif" },
                    { 15, 3062.5m, "Kurumsal", "Müşteri 16 A.Ş.", new DateTime(2026, 1, 21, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8460), "REF-100015", "Akdeniz", "Pasif" },
                    { 16, 3200m, "Bireysel", "Müşteri 17 A.Ş.", new DateTime(2026, 1, 20, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8470), "REF-100016", "Marmara", "Aktif" },
                    { 17, 3337.5m, "Kamu", "Müşteri 18 A.Ş.", new DateTime(2026, 1, 19, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8480), "REF-100017", "Ege", "Aktif" },
                    { 18, 3475m, "Kurumsal", "Müşteri 19 A.Ş.", new DateTime(2026, 1, 18, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8490), "REF-100018", "İç Anadolu", "Bekliyor" },
                    { 19, 3612.5m, "Bireysel", "Müşteri 20 A.Ş.", new DateTime(2026, 1, 17, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8500), "REF-100019", "Akdeniz", "Aktif" },
                    { 20, 3750m, "Kamu", "Müşteri 21 A.Ş.", new DateTime(2026, 1, 16, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8510), "REF-100020", "Marmara", "Pasif" },
                    { 21, 3887.5m, "Kurumsal", "Müşteri 22 A.Ş.", new DateTime(2026, 1, 15, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8520), "REF-100021", "Ege", "Bekliyor" },
                    { 22, 4025m, "Bireysel", "Müşteri 23 A.Ş.", new DateTime(2026, 1, 14, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8530), "REF-100022", "İç Anadolu", "Aktif" },
                    { 23, 4162.5m, "Kamu", "Müşteri 24 A.Ş.", new DateTime(2026, 1, 13, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8540), "REF-100023", "Akdeniz", "Aktif" },
                    { 24, 4300m, "Kurumsal", "Müşteri 25 A.Ş.", new DateTime(2026, 1, 12, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8550), "REF-100024", "Marmara", "Bekliyor" },
                    { 25, 4437.5m, "Bireysel", "Müşteri 26 A.Ş.", new DateTime(2026, 1, 11, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8560), "REF-100025", "Ege", "Pasif" },
                    { 26, 4575m, "Kamu", "Müşteri 27 A.Ş.", new DateTime(2026, 1, 10, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8570), "REF-100026", "İç Anadolu", "Aktif" },
                    { 27, 4712.5m, "Kurumsal", "Müşteri 28 A.Ş.", new DateTime(2026, 1, 9, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8580), "REF-100027", "Akdeniz", "Bekliyor" },
                    { 28, 4850m, "Bireysel", "Müşteri 29 A.Ş.", new DateTime(2026, 1, 8, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8590), "REF-100028", "Marmara", "Aktif" },
                    { 29, 4987.5m, "Kamu", "Müşteri 30 A.Ş.", new DateTime(2026, 1, 7, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8600), "REF-100029", "Ege", "Aktif" },
                    { 30, 5125m, "Kurumsal", "Müşteri 31 A.Ş.", new DateTime(2026, 1, 6, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8610), "REF-100030", "İç Anadolu", "Pasif" },
                    { 31, 5262.5m, "Bireysel", "Müşteri 32 A.Ş.", new DateTime(2026, 1, 5, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8620), "REF-100031", "Akdeniz", "Aktif" },
                    { 32, 5400m, "Kamu", "Müşteri 33 A.Ş.", new DateTime(2026, 1, 4, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8630), "REF-100032", "Marmara", "Aktif" },
                    { 33, 5537.5m, "Kurumsal", "Müşteri 34 A.Ş.", new DateTime(2026, 1, 3, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8640), "REF-100033", "Ege", "Bekliyor" },
                    { 34, 5675m, "Bireysel", "Müşteri 35 A.Ş.", new DateTime(2026, 1, 2, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8650), "REF-100034", "İç Anadolu", "Aktif" },
                    { 35, 5812.5m, "Kamu", "Müşteri 36 A.Ş.", new DateTime(2026, 1, 1, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8670), "REF-100035", "Akdeniz", "Pasif" },
                    { 36, 5950m, "Kurumsal", "Müşteri 37 A.Ş.", new DateTime(2025, 12, 31, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8680), "REF-100036", "Marmara", "Bekliyor" },
                    { 37, 6087.5m, "Bireysel", "Müşteri 38 A.Ş.", new DateTime(2025, 12, 30, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8690), "REF-100037", "Ege", "Aktif" },
                    { 38, 6225m, "Kamu", "Müşteri 39 A.Ş.", new DateTime(2025, 12, 29, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8700), "REF-100038", "İç Anadolu", "Aktif" },
                    { 39, 6362.5m, "Kurumsal", "Müşteri 40 A.Ş.", new DateTime(2025, 12, 28, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8710), "REF-100039", "Akdeniz", "Bekliyor" },
                    { 40, 6500m, "Bireysel", "Müşteri 41 A.Ş.", new DateTime(2025, 12, 27, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8720), "REF-100040", "Marmara", "Pasif" },
                    { 41, 6637.5m, "Kamu", "Müşteri 42 A.Ş.", new DateTime(2025, 12, 26, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8730), "REF-100041", "Ege", "Aktif" },
                    { 42, 6775m, "Kurumsal", "Müşteri 43 A.Ş.", new DateTime(2025, 12, 25, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8740), "REF-100042", "İç Anadolu", "Bekliyor" },
                    { 43, 6912.5m, "Bireysel", "Müşteri 44 A.Ş.", new DateTime(2025, 12, 24, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8750), "REF-100043", "Akdeniz", "Aktif" },
                    { 44, 7050m, "Kamu", "Müşteri 45 A.Ş.", new DateTime(2025, 12, 23, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8760), "REF-100044", "Marmara", "Aktif" },
                    { 45, 7187.5m, "Kurumsal", "Müşteri 46 A.Ş.", new DateTime(2025, 12, 22, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8770), "REF-100045", "Ege", "Pasif" },
                    { 46, 7325m, "Bireysel", "Müşteri 47 A.Ş.", new DateTime(2025, 12, 21, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8780), "REF-100046", "İç Anadolu", "Aktif" },
                    { 47, 7462.5m, "Kamu", "Müşteri 48 A.Ş.", new DateTime(2025, 12, 20, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8790), "REF-100047", "Akdeniz", "Aktif" },
                    { 48, 7600m, "Kurumsal", "Müşteri 49 A.Ş.", new DateTime(2025, 12, 19, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8800), "REF-100048", "Marmara", "Bekliyor" },
                    { 49, 7737.5m, "Bireysel", "Müşteri 50 A.Ş.", new DateTime(2025, 12, 18, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8820), "REF-100049", "Ege", "Aktif" },
                    { 50, 7875m, "Kamu", "Müşteri 51 A.Ş.", new DateTime(2025, 12, 17, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8830), "REF-100050", "İç Anadolu", "Pasif" },
                    { 51, 8012.5m, "Kurumsal", "Müşteri 52 A.Ş.", new DateTime(2025, 12, 16, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8840), "REF-100051", "Akdeniz", "Bekliyor" },
                    { 52, 8150m, "Bireysel", "Müşteri 53 A.Ş.", new DateTime(2025, 12, 15, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8850), "REF-100052", "Marmara", "Aktif" },
                    { 53, 8287.5m, "Kamu", "Müşteri 54 A.Ş.", new DateTime(2025, 12, 14, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8860), "REF-100053", "Ege", "Aktif" },
                    { 54, 8425m, "Kurumsal", "Müşteri 55 A.Ş.", new DateTime(2025, 12, 13, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8870), "REF-100054", "İç Anadolu", "Bekliyor" },
                    { 55, 8562.5m, "Bireysel", "Müşteri 56 A.Ş.", new DateTime(2025, 12, 12, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8880), "REF-100055", "Akdeniz", "Pasif" },
                    { 56, 8700m, "Kamu", "Müşteri 57 A.Ş.", new DateTime(2025, 12, 11, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8890), "REF-100056", "Marmara", "Aktif" },
                    { 57, 8837.5m, "Kurumsal", "Müşteri 58 A.Ş.", new DateTime(2025, 12, 10, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8900), "REF-100057", "Ege", "Bekliyor" },
                    { 58, 8975m, "Bireysel", "Müşteri 59 A.Ş.", new DateTime(2025, 12, 9, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8910), "REF-100058", "İç Anadolu", "Aktif" },
                    { 59, 9112.5m, "Kamu", "Müşteri 60 A.Ş.", new DateTime(2025, 12, 8, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8920), "REF-100059", "Akdeniz", "Aktif" },
                    { 60, 9250m, "Kurumsal", "Müşteri 61 A.Ş.", new DateTime(2025, 12, 7, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8930), "REF-100060", "Marmara", "Pasif" },
                    { 61, 9387.5m, "Bireysel", "Müşteri 62 A.Ş.", new DateTime(2025, 12, 6, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8940), "REF-100061", "Ege", "Aktif" },
                    { 62, 9525m, "Kamu", "Müşteri 63 A.Ş.", new DateTime(2025, 12, 5, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8950), "REF-100062", "İç Anadolu", "Aktif" },
                    { 63, 9662.5m, "Kurumsal", "Müşteri 64 A.Ş.", new DateTime(2025, 12, 4, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8960), "REF-100063", "Akdeniz", "Bekliyor" },
                    { 64, 9800m, "Bireysel", "Müşteri 65 A.Ş.", new DateTime(2025, 12, 3, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8970), "REF-100064", "Marmara", "Aktif" },
                    { 65, 9937.5m, "Kamu", "Müşteri 66 A.Ş.", new DateTime(2025, 12, 2, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(8990), "REF-100065", "Ege", "Pasif" },
                    { 66, 10075m, "Kurumsal", "Müşteri 67 A.Ş.", new DateTime(2025, 12, 1, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9000), "REF-100066", "İç Anadolu", "Bekliyor" },
                    { 67, 10212.5m, "Bireysel", "Müşteri 68 A.Ş.", new DateTime(2025, 11, 30, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9010), "REF-100067", "Akdeniz", "Aktif" },
                    { 68, 10350m, "Kamu", "Müşteri 69 A.Ş.", new DateTime(2025, 11, 29, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9020), "REF-100068", "Marmara", "Aktif" },
                    { 69, 10487.5m, "Kurumsal", "Müşteri 70 A.Ş.", new DateTime(2025, 11, 28, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9030), "REF-100069", "Ege", "Bekliyor" },
                    { 70, 10625m, "Bireysel", "Müşteri 71 A.Ş.", new DateTime(2025, 11, 27, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9040), "REF-100070", "İç Anadolu", "Pasif" },
                    { 71, 10762.5m, "Kamu", "Müşteri 72 A.Ş.", new DateTime(2025, 11, 26, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9050), "REF-100071", "Akdeniz", "Aktif" },
                    { 72, 10900m, "Kurumsal", "Müşteri 73 A.Ş.", new DateTime(2025, 11, 25, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9060), "REF-100072", "Marmara", "Bekliyor" },
                    { 73, 11037.5m, "Bireysel", "Müşteri 74 A.Ş.", new DateTime(2025, 11, 24, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9070), "REF-100073", "Ege", "Aktif" },
                    { 74, 11175m, "Kamu", "Müşteri 75 A.Ş.", new DateTime(2025, 11, 23, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9080), "REF-100074", "İç Anadolu", "Aktif" },
                    { 75, 11312.5m, "Kurumsal", "Müşteri 76 A.Ş.", new DateTime(2025, 11, 22, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9100), "REF-100075", "Akdeniz", "Pasif" },
                    { 76, 11450m, "Bireysel", "Müşteri 77 A.Ş.", new DateTime(2025, 11, 21, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9110), "REF-100076", "Marmara", "Aktif" },
                    { 77, 11587.5m, "Kamu", "Müşteri 78 A.Ş.", new DateTime(2025, 11, 20, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9120), "REF-100077", "Ege", "Aktif" },
                    { 78, 11725m, "Kurumsal", "Müşteri 79 A.Ş.", new DateTime(2025, 11, 19, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9130), "REF-100078", "İç Anadolu", "Bekliyor" },
                    { 79, 11862.5m, "Bireysel", "Müşteri 80 A.Ş.", new DateTime(2025, 11, 18, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9140), "REF-100079", "Akdeniz", "Aktif" },
                    { 80, 12000m, "Kamu", "Müşteri 81 A.Ş.", new DateTime(2025, 11, 17, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9150), "REF-100080", "Marmara", "Pasif" },
                    { 81, 12137.5m, "Kurumsal", "Müşteri 82 A.Ş.", new DateTime(2025, 11, 16, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9160), "REF-100081", "Ege", "Bekliyor" },
                    { 82, 12275m, "Bireysel", "Müşteri 83 A.Ş.", new DateTime(2025, 11, 15, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9170), "REF-100082", "İç Anadolu", "Aktif" },
                    { 83, 12412.5m, "Kamu", "Müşteri 84 A.Ş.", new DateTime(2025, 11, 14, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9180), "REF-100083", "Akdeniz", "Aktif" },
                    { 84, 12550m, "Kurumsal", "Müşteri 85 A.Ş.", new DateTime(2025, 11, 13, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9190), "REF-100084", "Marmara", "Bekliyor" },
                    { 85, 12687.5m, "Bireysel", "Müşteri 86 A.Ş.", new DateTime(2025, 11, 12, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9200), "REF-100085", "Ege", "Pasif" },
                    { 86, 12825m, "Kamu", "Müşteri 87 A.Ş.", new DateTime(2025, 11, 11, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9220), "REF-100086", "İç Anadolu", "Aktif" },
                    { 87, 12962.5m, "Kurumsal", "Müşteri 88 A.Ş.", new DateTime(2025, 11, 10, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9230), "REF-100087", "Akdeniz", "Bekliyor" },
                    { 88, 13100m, "Bireysel", "Müşteri 89 A.Ş.", new DateTime(2025, 11, 9, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9240), "REF-100088", "Marmara", "Aktif" },
                    { 89, 13237.5m, "Kamu", "Müşteri 90 A.Ş.", new DateTime(2025, 11, 8, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9250), "REF-100089", "Ege", "Aktif" },
                    { 90, 13375m, "Kurumsal", "Müşteri 91 A.Ş.", new DateTime(2025, 11, 7, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9260), "REF-100090", "İç Anadolu", "Pasif" },
                    { 91, 13512.5m, "Bireysel", "Müşteri 92 A.Ş.", new DateTime(2025, 11, 6, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9270), "REF-100091", "Akdeniz", "Aktif" },
                    { 92, 13650m, "Kamu", "Müşteri 93 A.Ş.", new DateTime(2025, 11, 5, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9280), "REF-100092", "Marmara", "Aktif" },
                    { 93, 13787.5m, "Kurumsal", "Müşteri 94 A.Ş.", new DateTime(2025, 11, 4, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9290), "REF-100093", "Ege", "Bekliyor" },
                    { 94, 13925m, "Bireysel", "Müşteri 95 A.Ş.", new DateTime(2025, 11, 3, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9300), "REF-100094", "İç Anadolu", "Aktif" },
                    { 95, 14062.5m, "Kamu", "Müşteri 96 A.Ş.", new DateTime(2025, 11, 2, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9320), "REF-100095", "Akdeniz", "Pasif" },
                    { 96, 14200m, "Kurumsal", "Müşteri 97 A.Ş.", new DateTime(2025, 11, 1, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9330), "REF-100096", "Marmara", "Bekliyor" },
                    { 97, 14337.5m, "Bireysel", "Müşteri 98 A.Ş.", new DateTime(2025, 10, 31, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9330), "REF-100097", "Ege", "Aktif" },
                    { 98, 14475m, "Kamu", "Müşteri 99 A.Ş.", new DateTime(2025, 10, 30, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9350), "REF-100098", "İç Anadolu", "Aktif" },
                    { 99, 14612.5m, "Kurumsal", "Müşteri 100 A.Ş.", new DateTime(2025, 10, 29, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9360), "REF-100099", "Akdeniz", "Bekliyor" },
                    { 100, 14750m, "Bireysel", "Müşteri 101 A.Ş.", new DateTime(2025, 10, 28, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9370), "REF-100100", "Marmara", "Pasif" },
                    { 101, 14887.5m, "Kamu", "Müşteri 102 A.Ş.", new DateTime(2025, 10, 27, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9380), "REF-100101", "Ege", "Aktif" },
                    { 102, 15025m, "Kurumsal", "Müşteri 103 A.Ş.", new DateTime(2025, 10, 26, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9390), "REF-100102", "İç Anadolu", "Bekliyor" },
                    { 103, 15162.5m, "Bireysel", "Müşteri 104 A.Ş.", new DateTime(2025, 10, 25, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9400), "REF-100103", "Akdeniz", "Aktif" },
                    { 104, 15300m, "Kamu", "Müşteri 105 A.Ş.", new DateTime(2025, 10, 24, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9410), "REF-100104", "Marmara", "Aktif" },
                    { 105, 15437.5m, "Kurumsal", "Müşteri 106 A.Ş.", new DateTime(2025, 10, 23, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9420), "REF-100105", "Ege", "Pasif" },
                    { 106, 15575m, "Bireysel", "Müşteri 107 A.Ş.", new DateTime(2025, 10, 22, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9430), "REF-100106", "İç Anadolu", "Aktif" },
                    { 107, 15712.5m, "Kamu", "Müşteri 108 A.Ş.", new DateTime(2025, 10, 21, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9440), "REF-100107", "Akdeniz", "Aktif" },
                    { 108, 15850m, "Kurumsal", "Müşteri 109 A.Ş.", new DateTime(2025, 10, 20, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9450), "REF-100108", "Marmara", "Bekliyor" },
                    { 109, 15987.5m, "Bireysel", "Müşteri 110 A.Ş.", new DateTime(2025, 10, 19, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9460), "REF-100109", "Ege", "Aktif" },
                    { 110, 16125m, "Kamu", "Müşteri 111 A.Ş.", new DateTime(2025, 10, 18, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9470), "REF-100110", "İç Anadolu", "Pasif" },
                    { 111, 16262.5m, "Kurumsal", "Müşteri 112 A.Ş.", new DateTime(2025, 10, 17, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9480), "REF-100111", "Akdeniz", "Bekliyor" },
                    { 112, 16400m, "Bireysel", "Müşteri 113 A.Ş.", new DateTime(2025, 10, 16, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9490), "REF-100112", "Marmara", "Aktif" },
                    { 113, 16537.5m, "Kamu", "Müşteri 114 A.Ş.", new DateTime(2025, 10, 15, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9500), "REF-100113", "Ege", "Aktif" },
                    { 114, 16675m, "Kurumsal", "Müşteri 115 A.Ş.", new DateTime(2025, 10, 14, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9510), "REF-100114", "İç Anadolu", "Bekliyor" },
                    { 115, 16812.5m, "Bireysel", "Müşteri 116 A.Ş.", new DateTime(2025, 10, 13, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9520), "REF-100115", "Akdeniz", "Pasif" },
                    { 116, 16950m, "Kamu", "Müşteri 117 A.Ş.", new DateTime(2025, 10, 12, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9530), "REF-100116", "Marmara", "Aktif" },
                    { 117, 17087.5m, "Kurumsal", "Müşteri 118 A.Ş.", new DateTime(2025, 10, 11, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9540), "REF-100117", "Ege", "Bekliyor" },
                    { 118, 17225m, "Bireysel", "Müşteri 119 A.Ş.", new DateTime(2025, 10, 10, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9550), "REF-100118", "İç Anadolu", "Aktif" },
                    { 119, 17362.5m, "Kamu", "Müşteri 120 A.Ş.", new DateTime(2025, 10, 9, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9560), "REF-100119", "Akdeniz", "Aktif" },
                    { 120, 17500m, "Kurumsal", "Müşteri 121 A.Ş.", new DateTime(2025, 10, 8, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9570), "REF-100120", "Marmara", "Pasif" },
                    { 121, 17637.5m, "Bireysel", "Müşteri 122 A.Ş.", new DateTime(2025, 10, 7, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9580), "REF-100121", "Ege", "Aktif" },
                    { 122, 17775m, "Kamu", "Müşteri 123 A.Ş.", new DateTime(2025, 10, 6, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9590), "REF-100122", "İç Anadolu", "Aktif" },
                    { 123, 17912.5m, "Kurumsal", "Müşteri 124 A.Ş.", new DateTime(2025, 10, 5, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9600), "REF-100123", "Akdeniz", "Bekliyor" },
                    { 124, 18050m, "Bireysel", "Müşteri 125 A.Ş.", new DateTime(2025, 10, 4, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9610), "REF-100124", "Marmara", "Aktif" },
                    { 125, 18187.5m, "Kamu", "Müşteri 126 A.Ş.", new DateTime(2025, 10, 3, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9640), "REF-100125", "Ege", "Pasif" },
                    { 126, 18325m, "Kurumsal", "Müşteri 127 A.Ş.", new DateTime(2025, 10, 2, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9650), "REF-100126", "İç Anadolu", "Bekliyor" },
                    { 127, 18462.5m, "Bireysel", "Müşteri 128 A.Ş.", new DateTime(2025, 10, 1, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9660), "REF-100127", "Akdeniz", "Aktif" },
                    { 128, 18600m, "Kamu", "Müşteri 129 A.Ş.", new DateTime(2025, 9, 30, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9670), "REF-100128", "Marmara", "Aktif" },
                    { 129, 18737.5m, "Kurumsal", "Müşteri 130 A.Ş.", new DateTime(2025, 9, 29, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9680), "REF-100129", "Ege", "Bekliyor" },
                    { 130, 18875m, "Bireysel", "Müşteri 131 A.Ş.", new DateTime(2025, 9, 28, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9690), "REF-100130", "İç Anadolu", "Pasif" },
                    { 131, 19012.5m, "Kamu", "Müşteri 132 A.Ş.", new DateTime(2025, 9, 27, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9700), "REF-100131", "Akdeniz", "Aktif" },
                    { 132, 19150m, "Kurumsal", "Müşteri 133 A.Ş.", new DateTime(2025, 9, 26, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9710), "REF-100132", "Marmara", "Bekliyor" },
                    { 133, 19287.5m, "Bireysel", "Müşteri 134 A.Ş.", new DateTime(2025, 9, 25, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9720), "REF-100133", "Ege", "Aktif" },
                    { 134, 19425m, "Kamu", "Müşteri 135 A.Ş.", new DateTime(2025, 9, 24, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9730), "REF-100134", "İç Anadolu", "Aktif" },
                    { 135, 19562.5m, "Kurumsal", "Müşteri 136 A.Ş.", new DateTime(2025, 9, 23, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9740), "REF-100135", "Akdeniz", "Pasif" },
                    { 136, 19700m, "Bireysel", "Müşteri 137 A.Ş.", new DateTime(2025, 9, 22, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9750), "REF-100136", "Marmara", "Aktif" },
                    { 137, 19837.5m, "Kamu", "Müşteri 138 A.Ş.", new DateTime(2025, 9, 21, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9760), "REF-100137", "Ege", "Aktif" },
                    { 138, 19975m, "Kurumsal", "Müşteri 139 A.Ş.", new DateTime(2025, 9, 20, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9770), "REF-100138", "İç Anadolu", "Bekliyor" },
                    { 139, 20112.5m, "Bireysel", "Müşteri 140 A.Ş.", new DateTime(2025, 9, 19, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9780), "REF-100139", "Akdeniz", "Aktif" },
                    { 140, 20250m, "Kamu", "Müşteri 141 A.Ş.", new DateTime(2025, 9, 18, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9790), "REF-100140", "Marmara", "Pasif" },
                    { 141, 20387.5m, "Kurumsal", "Müşteri 142 A.Ş.", new DateTime(2025, 9, 17, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9800), "REF-100141", "Ege", "Bekliyor" },
                    { 142, 20525m, "Bireysel", "Müşteri 143 A.Ş.", new DateTime(2025, 9, 16, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9810), "REF-100142", "İç Anadolu", "Aktif" },
                    { 143, 20662.5m, "Kamu", "Müşteri 144 A.Ş.", new DateTime(2025, 9, 15, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9820), "REF-100143", "Akdeniz", "Aktif" },
                    { 144, 20800m, "Kurumsal", "Müşteri 145 A.Ş.", new DateTime(2025, 9, 14, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9830), "REF-100144", "Marmara", "Bekliyor" },
                    { 145, 20937.5m, "Bireysel", "Müşteri 146 A.Ş.", new DateTime(2025, 9, 13, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9840), "REF-100145", "Ege", "Pasif" },
                    { 146, 21075m, "Kamu", "Müşteri 147 A.Ş.", new DateTime(2025, 9, 12, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9850), "REF-100146", "İç Anadolu", "Aktif" },
                    { 147, 21212.5m, "Kurumsal", "Müşteri 148 A.Ş.", new DateTime(2025, 9, 11, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9860), "REF-100147", "Akdeniz", "Bekliyor" },
                    { 148, 21350m, "Bireysel", "Müşteri 149 A.Ş.", new DateTime(2025, 9, 10, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9880), "REF-100148", "Marmara", "Aktif" },
                    { 149, 21487.5m, "Kamu", "Müşteri 150 A.Ş.", new DateTime(2025, 9, 9, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9890), "REF-100149", "Ege", "Aktif" },
                    { 150, 21625m, "Kurumsal", "Müşteri 151 A.Ş.", new DateTime(2025, 9, 8, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9900), "REF-100150", "İç Anadolu", "Pasif" },
                    { 151, 21762.5m, "Bireysel", "Müşteri 152 A.Ş.", new DateTime(2025, 9, 7, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9910), "REF-100151", "Akdeniz", "Aktif" },
                    { 152, 21900m, "Kamu", "Müşteri 153 A.Ş.", new DateTime(2025, 9, 6, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9920), "REF-100152", "Marmara", "Aktif" },
                    { 153, 22037.5m, "Kurumsal", "Müşteri 154 A.Ş.", new DateTime(2025, 9, 5, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9930), "REF-100153", "Ege", "Bekliyor" },
                    { 154, 22175m, "Bireysel", "Müşteri 155 A.Ş.", new DateTime(2025, 9, 4, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9940), "REF-100154", "İç Anadolu", "Aktif" },
                    { 155, 22312.5m, "Kamu", "Müşteri 156 A.Ş.", new DateTime(2025, 9, 3, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9950), "REF-100155", "Akdeniz", "Pasif" },
                    { 156, 22450m, "Kurumsal", "Müşteri 157 A.Ş.", new DateTime(2025, 9, 2, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9960), "REF-100156", "Marmara", "Bekliyor" },
                    { 157, 22587.5m, "Bireysel", "Müşteri 158 A.Ş.", new DateTime(2025, 9, 1, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9970), "REF-100157", "Ege", "Aktif" },
                    { 158, 22725m, "Kamu", "Müşteri 159 A.Ş.", new DateTime(2025, 8, 31, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9980), "REF-100158", "İç Anadolu", "Aktif" },
                    { 159, 22862.5m, "Kurumsal", "Müşteri 160 A.Ş.", new DateTime(2025, 8, 30, 15, 38, 6, 338, DateTimeKind.Local).AddTicks(9990), "REF-100159", "Akdeniz", "Bekliyor" },
                    { 160, 23000m, "Bireysel", "Müşteri 161 A.Ş.", new DateTime(2025, 8, 29, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(20), "REF-100160", "Marmara", "Pasif" },
                    { 161, 23137.5m, "Kamu", "Müşteri 162 A.Ş.", new DateTime(2025, 8, 28, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(30), "REF-100161", "Ege", "Aktif" },
                    { 162, 23275m, "Kurumsal", "Müşteri 163 A.Ş.", new DateTime(2025, 8, 27, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(40), "REF-100162", "İç Anadolu", "Bekliyor" },
                    { 163, 23412.5m, "Bireysel", "Müşteri 164 A.Ş.", new DateTime(2025, 8, 26, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(50), "REF-100163", "Akdeniz", "Aktif" },
                    { 164, 23550m, "Kamu", "Müşteri 165 A.Ş.", new DateTime(2025, 8, 25, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(60), "REF-100164", "Marmara", "Aktif" },
                    { 165, 23687.5m, "Kurumsal", "Müşteri 166 A.Ş.", new DateTime(2025, 8, 24, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(70), "REF-100165", "Ege", "Pasif" },
                    { 166, 23825m, "Bireysel", "Müşteri 167 A.Ş.", new DateTime(2025, 8, 23, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(80), "REF-100166", "İç Anadolu", "Aktif" },
                    { 167, 23962.5m, "Kamu", "Müşteri 168 A.Ş.", new DateTime(2025, 8, 22, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(90), "REF-100167", "Akdeniz", "Aktif" },
                    { 168, 24100m, "Kurumsal", "Müşteri 169 A.Ş.", new DateTime(2025, 8, 21, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(100), "REF-100168", "Marmara", "Bekliyor" },
                    { 169, 24237.5m, "Bireysel", "Müşteri 170 A.Ş.", new DateTime(2025, 8, 20, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(110), "REF-100169", "Ege", "Aktif" },
                    { 170, 24375m, "Kamu", "Müşteri 171 A.Ş.", new DateTime(2025, 8, 19, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(120), "REF-100170", "İç Anadolu", "Pasif" },
                    { 171, 24512.5m, "Kurumsal", "Müşteri 172 A.Ş.", new DateTime(2025, 8, 18, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(130), "REF-100171", "Akdeniz", "Bekliyor" },
                    { 172, 24650m, "Bireysel", "Müşteri 173 A.Ş.", new DateTime(2025, 8, 17, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(140), "REF-100172", "Marmara", "Aktif" },
                    { 173, 24787.5m, "Kamu", "Müşteri 174 A.Ş.", new DateTime(2025, 8, 16, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(150), "REF-100173", "Ege", "Aktif" },
                    { 174, 24925m, "Kurumsal", "Müşteri 175 A.Ş.", new DateTime(2025, 8, 15, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(160), "REF-100174", "İç Anadolu", "Bekliyor" },
                    { 175, 25062.5m, "Bireysel", "Müşteri 176 A.Ş.", new DateTime(2025, 8, 14, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(170), "REF-100175", "Akdeniz", "Pasif" },
                    { 176, 25200m, "Kamu", "Müşteri 177 A.Ş.", new DateTime(2025, 8, 13, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(180), "REF-100176", "Marmara", "Aktif" },
                    { 177, 25337.5m, "Kurumsal", "Müşteri 178 A.Ş.", new DateTime(2025, 8, 12, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(190), "REF-100177", "Ege", "Bekliyor" },
                    { 178, 25475m, "Bireysel", "Müşteri 179 A.Ş.", new DateTime(2025, 8, 11, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(200), "REF-100178", "İç Anadolu", "Aktif" },
                    { 179, 25612.5m, "Kamu", "Müşteri 180 A.Ş.", new DateTime(2025, 8, 10, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(220), "REF-100179", "Akdeniz", "Aktif" },
                    { 180, 25750m, "Kurumsal", "Müşteri 181 A.Ş.", new DateTime(2025, 8, 9, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(230), "REF-100180", "Marmara", "Pasif" },
                    { 181, 25887.5m, "Bireysel", "Müşteri 182 A.Ş.", new DateTime(2025, 8, 8, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(240), "REF-100181", "Ege", "Aktif" },
                    { 182, 26025m, "Kamu", "Müşteri 183 A.Ş.", new DateTime(2025, 8, 7, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(250), "REF-100182", "İç Anadolu", "Aktif" },
                    { 183, 26162.5m, "Kurumsal", "Müşteri 184 A.Ş.", new DateTime(2025, 8, 6, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(260), "REF-100183", "Akdeniz", "Bekliyor" },
                    { 184, 26300m, "Bireysel", "Müşteri 185 A.Ş.", new DateTime(2025, 8, 5, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(270), "REF-100184", "Marmara", "Aktif" },
                    { 185, 26437.5m, "Kamu", "Müşteri 186 A.Ş.", new DateTime(2025, 8, 4, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(280), "REF-100185", "Ege", "Pasif" },
                    { 186, 26575m, "Kurumsal", "Müşteri 187 A.Ş.", new DateTime(2025, 8, 3, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(290), "REF-100186", "İç Anadolu", "Bekliyor" },
                    { 187, 26712.5m, "Bireysel", "Müşteri 188 A.Ş.", new DateTime(2025, 8, 2, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(300), "REF-100187", "Akdeniz", "Aktif" },
                    { 188, 26850m, "Kamu", "Müşteri 189 A.Ş.", new DateTime(2025, 8, 1, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(310), "REF-100188", "Marmara", "Aktif" },
                    { 189, 26987.5m, "Kurumsal", "Müşteri 190 A.Ş.", new DateTime(2025, 7, 31, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(320), "REF-100189", "Ege", "Bekliyor" },
                    { 190, 27125m, "Bireysel", "Müşteri 191 A.Ş.", new DateTime(2025, 7, 30, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(330), "REF-100190", "İç Anadolu", "Pasif" },
                    { 191, 27262.5m, "Kamu", "Müşteri 192 A.Ş.", new DateTime(2025, 7, 29, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(340), "REF-100191", "Akdeniz", "Aktif" },
                    { 192, 27400m, "Kurumsal", "Müşteri 193 A.Ş.", new DateTime(2025, 7, 28, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(350), "REF-100192", "Marmara", "Bekliyor" },
                    { 193, 27537.5m, "Bireysel", "Müşteri 194 A.Ş.", new DateTime(2025, 7, 27, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(400), "REF-100193", "Ege", "Aktif" },
                    { 194, 27675m, "Kamu", "Müşteri 195 A.Ş.", new DateTime(2025, 7, 26, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(410), "REF-100194", "İç Anadolu", "Aktif" },
                    { 195, 27812.5m, "Kurumsal", "Müşteri 196 A.Ş.", new DateTime(2025, 7, 25, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(420), "REF-100195", "Akdeniz", "Pasif" },
                    { 196, 27950m, "Bireysel", "Müşteri 197 A.Ş.", new DateTime(2025, 7, 24, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(430), "REF-100196", "Marmara", "Aktif" },
                    { 197, 28087.5m, "Kamu", "Müşteri 198 A.Ş.", new DateTime(2025, 7, 23, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(440), "REF-100197", "Ege", "Aktif" },
                    { 198, 28225m, "Kurumsal", "Müşteri 199 A.Ş.", new DateTime(2025, 7, 22, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(450), "REF-100198", "İç Anadolu", "Bekliyor" },
                    { 199, 28362.5m, "Bireysel", "Müşteri 200 A.Ş.", new DateTime(2025, 7, 21, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(480), "REF-100199", "Akdeniz", "Aktif" },
                    { 200, 28500m, "Kamu", "Müşteri 201 A.Ş.", new DateTime(2025, 7, 20, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(490), "REF-100200", "Marmara", "Pasif" }
                });

            migrationBuilder.InsertData(
                table: "PoolDefinitions",
                columns: new[] { "Id", "Description", "DisplayName", "Name" },
                values: new object[,]
                {
                    { 1, "Yüksek performanslı ticari işlem veri havuzu", "Ticari Kayıtlar", "DataPool2" },
                    { 2, "Aktif proje takip ve bütçe yönetim havuzu", "Proje Yönetimi", "DataPool3" }
                });

            migrationBuilder.InsertData(
                table: "ProjectRecords",
                columns: new[] { "Id", "Budget", "CustomerName", "DueDate", "Progress", "ProjectName", "Status" },
                values: new object[,]
                {
                    { 1, 161900m, "Global Müşteri 2", new DateTime(2026, 3, 10, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(540), 32, "Proje Görselleştirme #1001", "Pending" },
                    { 2, 396992m, "Global Müşteri 3", new DateTime(2026, 5, 9, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(570), 79, "Proje Görselleştirme #1002", "On Hold" },
                    { 3, 182083m, "Global Müşteri 4", new DateTime(2026, 3, 15, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(600), 36, "Proje Görselleştirme #1003", "Completed" },
                    { 4, 417175m, "Global Müşteri 5", new DateTime(2026, 5, 14, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(620), 83, "Proje Görselleştirme #1004", "Active" },
                    { 5, 202266m, "Global Müşteri 6", new DateTime(2026, 3, 20, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(650), 40, "Proje Görselleştirme #1005", "Pending" },
                    { 6, 437357m, "Global Müşteri 7", new DateTime(2026, 5, 19, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(680), 87, "Proje Görselleştirme #1006", "On Hold" },
                    { 7, 222449m, "Global Müşteri 8", new DateTime(2026, 3, 26, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(710), 44, "Proje Görselleştirme #1007", "Completed" },
                    { 8, 457540m, "Global Müşteri 9", new DateTime(2026, 5, 25, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(740), 91, "Proje Görselleştirme #1008", "Active" },
                    { 9, 242631m, "Global Müşteri 10", new DateTime(2026, 3, 31, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(770), 48, "Proje Görselleştirme #1009", "Pending" },
                    { 10, 477723m, "Global Müşteri 11", new DateTime(2026, 5, 30, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(800), 95, "Proje Görselleştirme #1010", "On Hold" },
                    { 11, 262814m, "Global Müşteri 12", new DateTime(2026, 4, 5, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(820), 52, "Proje Görselleştirme #1011", "Completed" },
                    { 12, 497906m, "Global Müşteri 13", new DateTime(2026, 6, 4, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(870), 99, "Proje Görselleştirme #1012", "Active" },
                    { 13, 282997m, "Global Müşteri 14", new DateTime(2026, 4, 10, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(900), 56, "Proje Görselleştirme #1013", "Pending" },
                    { 14, 68088m, "Global Müşteri 15", new DateTime(2026, 2, 14, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(930), 13, "Proje Görselleştirme #1014", "On Hold" },
                    { 15, 303180m, "Global Müşteri 16", new DateTime(2026, 4, 15, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(950), 60, "Proje Görselleştirme #1015", "Completed" },
                    { 16, 88271m, "Global Müşteri 17", new DateTime(2026, 2, 19, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(980), 17, "Proje Görselleştirme #1016", "Active" },
                    { 17, 323363m, "Global Müşteri 18", new DateTime(2026, 4, 20, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1010), 64, "Proje Görselleştirme #1017", "Pending" },
                    { 18, 108454m, "Global Müşteri 19", new DateTime(2026, 2, 24, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1040), 21, "Proje Görselleştirme #1018", "On Hold" },
                    { 19, 343545m, "Global Müşteri 20", new DateTime(2026, 4, 26, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1070), 68, "Proje Görselleştirme #1019", "Completed" },
                    { 20, 128637m, "Global Müşteri 21", new DateTime(2026, 3, 2, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1100), 25, "Proje Görselleştirme #1020", "Active" },
                    { 21, 363728m, "Global Müşteri 22", new DateTime(2026, 5, 1, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1120), 72, "Proje Görselleştirme #1021", "Pending" },
                    { 22, 148820m, "Global Müşteri 23", new DateTime(2026, 3, 7, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1150), 29, "Proje Görselleştirme #1022", "On Hold" },
                    { 23, 383911m, "Global Müşteri 24", new DateTime(2026, 5, 6, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1180), 76, "Proje Görselleştirme #1023", "Completed" },
                    { 24, 169002m, "Global Müşteri 25", new DateTime(2026, 3, 12, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1220), 33, "Proje Görselleştirme #1024", "Active" },
                    { 25, 404094m, "Global Müşteri 26", new DateTime(2026, 5, 11, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1250), 80, "Proje Görselleştirme #1025", "Pending" },
                    { 26, 189185m, "Global Müşteri 27", new DateTime(2026, 3, 17, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1270), 37, "Proje Görselleştirme #1026", "On Hold" },
                    { 27, 424277m, "Global Müşteri 28", new DateTime(2026, 5, 16, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1300), 84, "Proje Görselleştirme #1027", "Completed" },
                    { 28, 209368m, "Global Müşteri 29", new DateTime(2026, 3, 22, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1330), 41, "Proje Görselleştirme #1028", "Active" },
                    { 29, 444459m, "Global Müşteri 30", new DateTime(2026, 5, 21, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1360), 88, "Proje Görselleştirme #1029", "Pending" },
                    { 30, 229551m, "Global Müşteri 31", new DateTime(2026, 3, 27, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1390), 45, "Proje Görselleştirme #1030", "On Hold" },
                    { 31, 464642m, "Global Müşteri 32", new DateTime(2026, 5, 26, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1420), 92, "Proje Görselleştirme #1031", "Completed" },
                    { 32, 249733m, "Global Müşteri 33", new DateTime(2026, 4, 2, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1450), 49, "Proje Görselleştirme #1032", "Active" },
                    { 33, 484825m, "Global Müşteri 34", new DateTime(2026, 6, 1, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1470), 96, "Proje Görselleştirme #1033", "Pending" },
                    { 34, 269916m, "Global Müşteri 35", new DateTime(2026, 4, 7, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1500), 53, "Proje Görselleştirme #1034", "On Hold" },
                    { 35, 55008m, "Global Müşteri 36", new DateTime(2026, 2, 11, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1530), 11, "Proje Görselleştirme #1035", "Completed" },
                    { 36, 290099m, "Global Müşteri 37", new DateTime(2026, 4, 12, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1560), 58, "Proje Görselleştirme #1036", "Active" },
                    { 37, 75190m, "Global Müşteri 38", new DateTime(2026, 2, 16, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1590), 15, "Proje Görselleştirme #1037", "Pending" },
                    { 38, 310282m, "Global Müşteri 39", new DateTime(2026, 4, 17, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1620), 62, "Proje Görselleştirme #1038", "On Hold" },
                    { 39, 95373m, "Global Müşteri 40", new DateTime(2026, 2, 21, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1640), 19, "Proje Görselleştirme #1039", "Completed" },
                    { 40, 330465m, "Global Müşteri 41", new DateTime(2026, 4, 22, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1670), 66, "Proje Görselleştirme #1040", "Active" },
                    { 41, 115556m, "Global Müşteri 42", new DateTime(2026, 2, 26, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1750), 23, "Proje Görselleştirme #1041", "Pending" },
                    { 42, 350647m, "Global Müşteri 43", new DateTime(2026, 4, 27, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1780), 70, "Proje Görselleştirme #1042", "On Hold" },
                    { 43, 135739m, "Global Müşteri 44", new DateTime(2026, 3, 3, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1800), 27, "Proje Görselleştirme #1043", "Completed" },
                    { 44, 370830m, "Global Müşteri 45", new DateTime(2026, 5, 2, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1830), 74, "Proje Görselleştirme #1044", "Active" },
                    { 45, 155922m, "Global Müşteri 46", new DateTime(2026, 3, 9, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1860), 31, "Proje Görselleştirme #1045", "Pending" },
                    { 46, 391013m, "Global Müşteri 47", new DateTime(2026, 5, 8, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1890), 78, "Proje Görselleştirme #1046", "On Hold" },
                    { 47, 176104m, "Global Müşteri 48", new DateTime(2026, 3, 14, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1930), 35, "Proje Görselleştirme #1047", "Completed" },
                    { 48, 411196m, "Global Müşteri 49", new DateTime(2026, 5, 13, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1960), 82, "Proje Görselleştirme #1048", "Active" },
                    { 49, 196287m, "Global Müşteri 50", new DateTime(2026, 3, 19, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(1980), 39, "Proje Görselleştirme #1049", "Pending" },
                    { 50, 431379m, "Global Müşteri 1", new DateTime(2026, 5, 18, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2010), 86, "Proje Görselleştirme #1050", "On Hold" },
                    { 51, 216470m, "Global Müşteri 2", new DateTime(2026, 3, 24, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2040), 43, "Proje Görselleştirme #1051", "Completed" },
                    { 52, 451561m, "Global Müşteri 3", new DateTime(2026, 5, 23, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2070), 90, "Proje Görselleştirme #1052", "Active" },
                    { 53, 236653m, "Global Müşteri 4", new DateTime(2026, 3, 29, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2090), 47, "Proje Görselleştirme #1053", "Pending" },
                    { 54, 471744m, "Global Müşteri 5", new DateTime(2026, 5, 28, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2120), 94, "Proje Görselleştirme #1054", "On Hold" },
                    { 55, 256835m, "Global Müşteri 6", new DateTime(2026, 4, 3, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2150), 51, "Proje Görselleştirme #1055", "Completed" },
                    { 56, 491927m, "Global Müşteri 7", new DateTime(2026, 6, 2, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2180), 98, "Proje Görselleştirme #1056", "Active" },
                    { 57, 277018m, "Global Müşteri 8", new DateTime(2026, 4, 9, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2210), 55, "Proje Görselleştirme #1057", "Pending" },
                    { 58, 62110m, "Global Müşteri 9", new DateTime(2026, 2, 13, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2240), 12, "Proje Görselleştirme #1058", "On Hold" },
                    { 59, 297201m, "Global Müşteri 10", new DateTime(2026, 4, 14, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2270), 59, "Proje Görselleştirme #1059", "Completed" },
                    { 60, 82292m, "Global Müşteri 11", new DateTime(2026, 2, 18, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2300), 16, "Proje Görselleştirme #1060", "Active" },
                    { 61, 317384m, "Global Müşteri 12", new DateTime(2026, 4, 19, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2330), 63, "Proje Görselleştirme #1061", "Pending" },
                    { 62, 102475m, "Global Müşteri 13", new DateTime(2026, 2, 23, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2360), 20, "Proje Görselleştirme #1062", "On Hold" },
                    { 63, 337567m, "Global Müşteri 14", new DateTime(2026, 4, 24, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2390), 67, "Proje Görselleştirme #1063", "Completed" },
                    { 64, 122658m, "Global Müşteri 15", new DateTime(2026, 2, 28, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2420), 24, "Proje Görselleştirme #1064", "Active" },
                    { 65, 357749m, "Global Müşteri 16", new DateTime(2026, 4, 29, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2450), 71, "Proje Görselleştirme #1065", "Pending" },
                    { 66, 142841m, "Global Müşteri 17", new DateTime(2026, 3, 5, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2480), 28, "Proje Görselleştirme #1066", "On Hold" },
                    { 67, 377932m, "Global Müşteri 18", new DateTime(2026, 5, 4, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2510), 75, "Proje Görselleştirme #1067", "Completed" },
                    { 68, 163024m, "Global Müşteri 19", new DateTime(2026, 3, 10, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2530), 32, "Proje Görselleştirme #1068", "Active" },
                    { 69, 398115m, "Global Müşteri 20", new DateTime(2026, 5, 9, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2560), 79, "Proje Görselleştirme #1069", "Pending" },
                    { 70, 183206m, "Global Müşteri 21", new DateTime(2026, 3, 16, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2590), 36, "Proje Görselleştirme #1070", "On Hold" },
                    { 71, 418298m, "Global Müşteri 22", new DateTime(2026, 5, 15, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2630), 83, "Proje Görselleştirme #1071", "Completed" },
                    { 72, 203389m, "Global Müşteri 23", new DateTime(2026, 3, 21, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2660), 40, "Proje Görselleştirme #1072", "Active" },
                    { 73, 438481m, "Global Müşteri 24", new DateTime(2026, 5, 20, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2690), 87, "Proje Görselleştirme #1073", "Pending" },
                    { 74, 223572m, "Global Müşteri 25", new DateTime(2026, 3, 26, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2710), 44, "Proje Görselleştirme #1074", "On Hold" },
                    { 75, 458663m, "Global Müşteri 26", new DateTime(2026, 5, 25, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2740), 91, "Proje Görselleştirme #1075", "Completed" },
                    { 76, 243755m, "Global Müşteri 27", new DateTime(2026, 3, 31, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2770), 48, "Proje Görselleştirme #1076", "Active" },
                    { 77, 478846m, "Global Müşteri 28", new DateTime(2026, 5, 30, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2800), 95, "Proje Görselleştirme #1077", "Pending" },
                    { 78, 263937m, "Global Müşteri 29", new DateTime(2026, 4, 5, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2820), 52, "Proje Görselleştirme #1078", "On Hold" },
                    { 79, 499029m, "Global Müşteri 30", new DateTime(2026, 6, 4, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2850), 99, "Proje Görselleştirme #1079", "Completed" },
                    { 80, 284120m, "Global Müşteri 31", new DateTime(2026, 4, 10, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2880), 56, "Proje Görselleştirme #1080", "Active" },
                    { 81, 69212m, "Global Müşteri 32", new DateTime(2026, 2, 14, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2910), 13, "Proje Görselleştirme #1081", "Pending" },
                    { 82, 304303m, "Global Müşteri 33", new DateTime(2026, 4, 15, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2940), 60, "Proje Görselleştirme #1082", "On Hold" },
                    { 83, 89394m, "Global Müşteri 34", new DateTime(2026, 2, 20, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(2980), 17, "Proje Görselleştirme #1083", "Completed" },
                    { 84, 324486m, "Global Müşteri 35", new DateTime(2026, 4, 21, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3000), 64, "Proje Görselleştirme #1084", "Active" },
                    { 85, 109577m, "Global Müşteri 36", new DateTime(2026, 2, 25, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3030), 21, "Proje Görselleştirme #1085", "Pending" },
                    { 86, 344669m, "Global Müşteri 37", new DateTime(2026, 4, 26, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3060), 68, "Proje Görselleştirme #1086", "On Hold" },
                    { 87, 129760m, "Global Müşteri 38", new DateTime(2026, 3, 2, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3090), 25, "Proje Görselleştirme #1087", "Completed" },
                    { 88, 364851m, "Global Müşteri 39", new DateTime(2026, 5, 1, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3120), 72, "Proje Görselleştirme #1088", "Active" },
                    { 89, 149943m, "Global Müşteri 40", new DateTime(2026, 3, 7, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3150), 29, "Proje Görselleştirme #1089", "Pending" },
                    { 90, 385034m, "Global Müşteri 41", new DateTime(2026, 5, 6, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3180), 77, "Proje Görselleştirme #1090", "On Hold" },
                    { 91, 170126m, "Global Müşteri 42", new DateTime(2026, 3, 12, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3210), 34, "Proje Görselleştirme #1091", "Completed" },
                    { 92, 405217m, "Global Müşteri 43", new DateTime(2026, 5, 11, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3230), 81, "Proje Görselleştirme #1092", "Active" },
                    { 93, 190308m, "Global Müşteri 44", new DateTime(2026, 3, 17, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3260), 38, "Proje Görselleştirme #1093", "Pending" },
                    { 94, 425400m, "Global Müşteri 45", new DateTime(2026, 5, 16, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3290), 85, "Proje Görselleştirme #1094", "On Hold" },
                    { 95, 210491m, "Global Müşteri 46", new DateTime(2026, 3, 23, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3360), 42, "Proje Görselleştirme #1095", "Completed" },
                    { 96, 445583m, "Global Müşteri 47", new DateTime(2026, 5, 22, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3390), 89, "Proje Görselleştirme #1096", "Active" },
                    { 97, 230674m, "Global Müşteri 48", new DateTime(2026, 3, 28, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3420), 46, "Proje Görselleştirme #1097", "Pending" },
                    { 98, 465765m, "Global Müşteri 49", new DateTime(2026, 5, 27, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3450), 93, "Proje Görselleştirme #1098", "On Hold" },
                    { 99, 250857m, "Global Müşteri 50", new DateTime(2026, 4, 2, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3470), 50, "Proje Görselleştirme #1099", "Completed" },
                    { 100, 485948m, "Global Müşteri 1", new DateTime(2026, 6, 1, 15, 38, 6, 339, DateTimeKind.Local).AddTicks(3500), 97, "Proje Görselleştirme #1100", "Active" }
                });

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

            migrationBuilder.InsertData(
                table: "PoolColumns",
                columns: new[] { "Id", "CssClass", "DataType", "HeaderCssClass", "HeaderText", "IsVisible", "OrderIndex", "PoolDefinitionId", "PropertyName", "Width" },
                values: new object[,]
                {
                    { 1, "ps-4 text-muted font-monospace", "Text", "ps-4", "ID", true, 1, 1, "Id", "80px" },
                    { 2, "", "BadgeSecondary", "", "REF NO", true, 2, 1, "RefNo", "120px" },
                    { 3, "text-muted small", "Date", "", "TARİH", true, 3, 1, "Date", "120px" },
                    { 4, "fw-medium text-dark", "Text", "", "MÜŞTERİ", true, 4, 1, "CustomerName", "" },
                    { 5, "text-muted small", "Text", "", "BÖLGE", true, 5, 1, "Region", "" },
                    { 6, "", "BadgePrimary", "", "KATEGORİ", true, 6, 1, "Category", "" },
                    { 7, "text-end font-monospace fw-bold text-dark", "Currency", "text-end", "TUTAR", true, 7, 1, "Amount", "" },
                    { 8, "text-center", "StatusIndicator", "text-center", "DURUM", true, 8, 1, "Status", "" },
                    { 9, "text-end pe-4", "Actions", "text-end pe-4", "İŞLEM", true, 9, 1, "Actions", "100px" },
                    { 10, "text-center fw-bold text-muted", "Text", "text-center", "#", true, 1, 2, "Id", "60px" },
                    { 11, "", "ProjectDetails", "", "PROJE DETAYLARI", true, 2, 2, "ProjectName", "250px" },
                    { 12, "text-center", "StatusBadge", "text-center", "DURUM", true, 3, 2, "Status", "120px" },
                    { 13, "text-end font-monospace fw-bold text-dark", "Currency", "text-end", "BÜTÇE", true, 4, 2, "Budget", "150px" },
                    { 14, "", "ProgressBar", "", "İLERLEME", true, 5, 2, "Progress", "200px" },
                    { 15, "", "AvatarGroup", "", "EKİP", true, 6, 2, "Team", "150px" },
                    { 16, "text-muted small", "Date", "", "TESLİM", true, 7, 2, "DueDate", "120px" },
                    { 17, "text-center", "ActionsVertical", "text-center", "İŞLEM", true, 8, 2, "Actions", "100px" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PoolColumns_PoolDefinitionId",
                table: "PoolColumns",
                column: "PoolDefinitionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommercialRecords");

            migrationBuilder.DropTable(
                name: "PoolColumns");

            migrationBuilder.DropTable(
                name: "ProjectRecords");

            migrationBuilder.DropTable(
                name: "PoolDefinitions");

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 29, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6360));

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
                column: "Date",
                value: new DateTime(2026, 1, 31, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6410));

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

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2026, 1, 21, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2026, 1, 20, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2026, 1, 19, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2026, 1, 18, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2026, 1, 17, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2026, 1, 16, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2026, 1, 15, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2026, 1, 14, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2026, 1, 13, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2026, 1, 12, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2026, 1, 11, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2026, 1, 10, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2026, 1, 9, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2026, 1, 8, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2026, 1, 7, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2026, 1, 6, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2026, 1, 5, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2026, 1, 4, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2026, 1, 3, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2026, 1, 2, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 33,
                column: "Date",
                value: new DateTime(2026, 1, 1, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 34,
                column: "Date",
                value: new DateTime(2025, 12, 31, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 35,
                column: "Date",
                value: new DateTime(2025, 12, 30, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2025, 12, 29, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 37,
                column: "Date",
                value: new DateTime(2025, 12, 28, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 38,
                column: "Date",
                value: new DateTime(2025, 12, 27, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 39,
                column: "Date",
                value: new DateTime(2025, 12, 26, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 40,
                column: "Date",
                value: new DateTime(2025, 12, 25, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 41,
                column: "Date",
                value: new DateTime(2025, 12, 24, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 42,
                column: "Date",
                value: new DateTime(2025, 12, 23, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 43,
                column: "Date",
                value: new DateTime(2025, 12, 22, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 44,
                column: "Date",
                value: new DateTime(2025, 12, 21, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 45,
                column: "Date",
                value: new DateTime(2025, 12, 20, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 46,
                column: "Date",
                value: new DateTime(2025, 12, 19, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 47,
                column: "Date",
                value: new DateTime(2025, 12, 18, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 48,
                column: "Date",
                value: new DateTime(2025, 12, 17, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 49,
                column: "Date",
                value: new DateTime(2025, 12, 16, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 50,
                column: "Date",
                value: new DateTime(2025, 12, 15, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 51,
                column: "Date",
                value: new DateTime(2025, 12, 14, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 52,
                column: "Date",
                value: new DateTime(2025, 12, 13, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 53,
                column: "Date",
                value: new DateTime(2025, 12, 12, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 54,
                column: "Date",
                value: new DateTime(2025, 12, 11, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 55,
                column: "Date",
                value: new DateTime(2025, 12, 10, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 56,
                column: "Date",
                value: new DateTime(2025, 12, 9, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 57,
                column: "Date",
                value: new DateTime(2025, 12, 8, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 58,
                column: "Date",
                value: new DateTime(2025, 12, 7, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 59,
                column: "Date",
                value: new DateTime(2025, 12, 6, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 60,
                column: "Date",
                value: new DateTime(2025, 12, 5, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 61,
                column: "Date",
                value: new DateTime(2025, 12, 4, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 62,
                column: "Date",
                value: new DateTime(2025, 12, 3, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 63,
                column: "Date",
                value: new DateTime(2025, 12, 2, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 64,
                column: "Date",
                value: new DateTime(2025, 12, 1, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 65,
                column: "Date",
                value: new DateTime(2025, 11, 30, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 66,
                column: "Date",
                value: new DateTime(2025, 11, 29, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 67,
                column: "Date",
                value: new DateTime(2025, 11, 28, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 68,
                column: "Date",
                value: new DateTime(2025, 11, 27, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 69,
                column: "Date",
                value: new DateTime(2025, 11, 26, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 70,
                column: "Date",
                value: new DateTime(2025, 11, 25, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 71,
                column: "Date",
                value: new DateTime(2025, 11, 24, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 72,
                column: "Date",
                value: new DateTime(2025, 11, 23, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 73,
                column: "Date",
                value: new DateTime(2025, 11, 22, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 74,
                column: "Date",
                value: new DateTime(2025, 11, 21, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 75,
                column: "Date",
                value: new DateTime(2025, 11, 20, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 76,
                column: "Date",
                value: new DateTime(2025, 11, 19, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 77,
                column: "Date",
                value: new DateTime(2025, 11, 18, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 78,
                column: "Date",
                value: new DateTime(2025, 11, 17, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 79,
                column: "Date",
                value: new DateTime(2025, 11, 16, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 80,
                column: "Date",
                value: new DateTime(2025, 11, 15, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 81,
                column: "Date",
                value: new DateTime(2025, 11, 14, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 82,
                column: "Date",
                value: new DateTime(2025, 11, 13, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 83,
                column: "Date",
                value: new DateTime(2025, 11, 12, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 84,
                column: "Date",
                value: new DateTime(2025, 11, 11, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 85,
                column: "Date",
                value: new DateTime(2025, 11, 10, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 86,
                column: "Date",
                value: new DateTime(2025, 11, 9, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 87,
                column: "Date",
                value: new DateTime(2025, 11, 8, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 88,
                column: "Date",
                value: new DateTime(2025, 11, 7, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 89,
                column: "Date",
                value: new DateTime(2025, 11, 6, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 90,
                column: "Date",
                value: new DateTime(2025, 11, 5, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 91,
                column: "Date",
                value: new DateTime(2025, 11, 4, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 92,
                column: "Date",
                value: new DateTime(2025, 11, 3, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 93,
                column: "Date",
                value: new DateTime(2025, 11, 2, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 94,
                column: "Date",
                value: new DateTime(2025, 11, 1, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 95,
                column: "Date",
                value: new DateTime(2025, 10, 31, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 96,
                column: "Date",
                value: new DateTime(2025, 10, 30, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 97,
                column: "Date",
                value: new DateTime(2025, 10, 29, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 98,
                column: "Date",
                value: new DateTime(2025, 10, 28, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 99,
                column: "Date",
                value: new DateTime(2025, 10, 27, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "SampleDatas",
                keyColumn: "Id",
                keyValue: 100,
                column: "Date",
                value: new DateTime(2025, 10, 26, 13, 48, 16, 768, DateTimeKind.Local).AddTicks(7520));
        }
    }
}
