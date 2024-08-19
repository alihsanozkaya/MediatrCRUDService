using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MediatrCRUDService.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 19, 14, 46, 49, 663, DateTimeKind.Local).AddTicks(4154), "Samsung" },
                    { 2, new DateTime(2024, 8, 19, 14, 46, 49, 663, DateTimeKind.Local).AddTicks(4177), "Mavi" },
                    { 3, new DateTime(2024, 8, 19, 14, 46, 49, 663, DateTimeKind.Local).AddTicks(4178), "Eti" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 19, 14, 46, 49, 663, DateTimeKind.Local).AddTicks(6084), "Elektronik" },
                    { 2, new DateTime(2024, 8, 19, 14, 46, 49, 663, DateTimeKind.Local).AddTicks(6091), "Giyim" },
                    { 3, new DateTime(2024, 8, 19, 14, 46, 49, 663, DateTimeKind.Local).AddTicks(6092), "Yiyecek" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CreatedAt", "Description", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 8, 19, 14, 46, 49, 663, DateTimeKind.Local).AddTicks(7467), "Kullanıcı dostu kullanım özelliğiyle dikkatleri üzerine çeken Samsung Galaxy S24 Ultra 256 GB 12 GB Ram Kumtaşı tasarımıyla da adından sıklıkla söz ettiriyor.", 58999.989999999998, "Galaxy S24 Ultra" },
                    { 2, 2, new DateTime(2024, 8, 19, 14, 46, 49, 663, DateTimeKind.Local).AddTicks(7477), "Mavi Nin Erkek Koleksiyonundan Baskılı Siyah Tişört. Loose Fit / Bol Rahat Kesim Kısa Kol", 369.99000000000001, "Baskılı Siyah Tişört" },
                    { 3, 3, new DateTime(2024, 8, 19, 14, 46, 49, 663, DateTimeKind.Local).AddTicks(7478), "Şeker ilavesiz. Doğal lif kaynağı.", 17.5, "Lifalif Kuru Meyveli Yulaf Bar" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
