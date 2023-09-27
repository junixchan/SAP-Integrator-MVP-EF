using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SAP_Integrator_MVP_EF.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BillingTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SAP_ObjectCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesInvoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocNum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CardCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CardName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SalesOrderNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SalesmanId = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    DocDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DocDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BUnitId = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    PurchaseOrderNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BillingTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInvoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesInvoices_BillingTypes_BillingTypeId",
                        column: x => x.BillingTypeId,
                        principalTable: "BillingTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BillingTypes",
                columns: new[] { "Id", "Description", "Name", "SAP_ObjectCode" },
                values: new object[,]
                {
                    { 1, "Cancel Cash Sale", "SV", 13 },
                    { 2, "Invoice", "ZID1", 13 },
                    { 3, "Credit for Returns", "ZID4", 14 },
                    { 4, "Credit Ret W / O Ref", "ZRE1", 14 },
                    { 5, "RSS Invoice", "ZRSS", 13 },
                    { 6, "Van Sales Cash Inv.", "ZVAN", 13 },
                    { 7, "ZID7", "ZID7", 13 },
                    { 8, "ZID8", "ZID8", 13 },
                    { 9, "ZID9", "ZID9", 13 },
                    { 10, "ZRS1", "ZRS1", 13 }
                });

            migrationBuilder.InsertData(
                table: "SalesInvoices",
                columns: new[] { "Id", "BUnitId", "BillingTypeId", "CardCode", "CardName", "DocDate", "DocDueDate", "DocNum", "PurchaseOrderNo", "SalesOrderNo", "SalesmanId" },
                values: new object[,]
                {
                    { 1, 1, 3, "UIC12345", "NCCC", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "SI12345", "PO12345", "SO12345", 1 },
                    { 2, 12, 4, "UIC12346", "NCCC", new DateTime(2023, 9, 19, 16, 20, 58, 110, DateTimeKind.Local).AddTicks(1531), new DateTime(2023, 9, 19, 16, 20, 58, 110, DateTimeKind.Local).AddTicks(1531), "SI12346", "PO12346", "SO12346", 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoices_BillingTypeId",
                table: "SalesInvoices",
                column: "BillingTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesInvoices");

            migrationBuilder.DropTable(
                name: "BillingTypes");
        }
    }
}
