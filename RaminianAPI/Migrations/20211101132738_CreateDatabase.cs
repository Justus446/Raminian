using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RaminianAPI.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ecommerce",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sku = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    offername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    offerprice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OfferStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OfferExpiry = table.Column<DateTime>(type: "datetime2", nullable: true),
                    qty = table.Column<int>(type: "int", nullable: true),
                    weight = table.Column<int>(type: "int", nullable: true),
                    is_in_stock = table.Column<int>(type: "int", nullable: false),
                    manage_stock = table.Column<int>(type: "int", nullable: false),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Breadcrumb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    L1Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    L2Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    L3Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    L4Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Warehouse = table.Column<int>(type: "int", nullable: true),
                    B64Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastMove = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VATCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VATPercent = table.Column<double>(type: "float", nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ecommerce", x => x.ProductID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ecommerce");
        }
    }
}
