using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MediatrCRUDService.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7177), "Apple" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7178), "Asus" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 4, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7179), "Mavi" },
                    { 5, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7180), "Koton" },
                    { 6, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7180), "Zara" },
                    { 7, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7181), "Karaca" },
                    { 8, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7181), "Yataş" },
                    { 9, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7182), "English Home" },
                    { 10, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7183), "Bürotime" },
                    { 11, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7183), "Bürosit" },
                    { 12, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7184), "Adidas" },
                    { 13, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7185), "Nike" },
                    { 14, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7185), "Decathlon" },
                    { 15, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7186), "LEGO" },
                    { 16, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7186), "Hot Wheels" },
                    { 17, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7187), "Faber Castell" },
                    { 18, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7188), "Gıpta" },
                    { 19, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7188), "Scrikss" },
                    { 20, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7189), "Avon" },
                    { 21, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7190), "Yves Rocher" },
                    { 22, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7190), "Nivea" },
                    { 23, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7191), "Eti" },
                    { 24, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7191), "Sütaş" },
                    { 25, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(7192), "Çaykur" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(8591), "Moda" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(8591), "Ev" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 4, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(8592), "Ofis" },
                    { 5, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(8593), "Spor" },
                    { 6, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(8593), "Oyuncak" },
                    { 7, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(8594), "Kırtasiye" },
                    { 8, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(8594), "Kozmetik" },
                    { 9, new DateTime(2024, 8, 20, 16, 24, 52, 0, DateTimeKind.Local).AddTicks(8595), "Gıda" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 20, 16, 24, 52, 1, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandId", "CreatedAt", "Description", "Price", "Title" },
                values: new object[] { 4, new DateTime(2024, 8, 20, 16, 24, 52, 1, DateTimeKind.Local).AddTicks(4509), "Mavi Nin Denim Koleksiyonundan Barcelona Kolej Buz Mavi Jean Pantolon", 699.99000000000001, "Barcelona Kolej Buz Mavi Jean Pantolon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BrandId", "CreatedAt", "Description", "Price", "Title" },
                values: new object[] { 9, new DateTime(2024, 8, 20, 16, 24, 52, 1, DateTimeKind.Local).AddTicks(4510), "Floral Slice Pike Takımı 150x220 cm Yeşil", 849.99000000000001, "Floral Slice Tek Kişilik Pike Takımı Yeşil" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CreatedAt", "Description", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 10, new DateTime(2024, 8, 20, 16, 24, 52, 1, DateTimeKind.Local).AddTicks(4511), "Çalışma koltuğu", 6776.0, "Comfy Başlıklı Çalışma Koltuğu" },
                    { 5, 12, new DateTime(2024, 8, 20, 16, 24, 52, 1, DateTimeKind.Local).AddTicks(4512), "BENZERSİZ BİR GEÇMİŞE SAHİP, EL DİKİŞLİ FUTBOL TOPU", 819.0, "Tango Rosario El Dikişli Fifa Onaylı Deri Futbol Topu" },
                    { 6, 16, new DateTime(2024, 8, 20, 16, 24, 52, 1, DateTimeKind.Local).AddTicks(4513), "Hot Wheels Fast & Furious Volkswagen Jetta MK3 HRW44", 259.5, "Fast & Furious Volkswagen Jetta" },
                    { 7, 17, new DateTime(2024, 8, 20, 16, 24, 52, 1, DateTimeKind.Local).AddTicks(4514), "2022 Grip 1347 Versatil Kalem 0.7 mm Petrol Yeşili", 260.0, "2022 Grip 1347 Versatil Kalem" },
                    { 8, 21, new DateTime(2024, 8, 20, 16, 24, 52, 1, DateTimeKind.Local).AddTicks(4515), "Gözenekleri derinlemesine arındıran yüz yıkama jeli, ferahlık veren organik nane ve jel dokusu sayesinde cildi kurutmadan temizler ve gözenekleri kirden arındırır.", 450.0, "Karma Ve Yağlı Ciltler Için Pure Menthe Prebiyotik Yüz Yıkama Jeli-390 ml" },
                    { 9, 23, new DateTime(2024, 8, 20, 16, 24, 52, 1, DateTimeKind.Local).AddTicks(4516), "Şeker ilavesiz. Doğal lif kaynağı.", 17.5, "Lifalif Kuru Meyveli Yulaf Bar" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 19, 18, 43, 40, 597, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 8, 19, 18, 43, 40, 597, DateTimeKind.Local).AddTicks(3440), "Mavi" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 8, 19, 18, 43, 40, 597, DateTimeKind.Local).AddTicks(3440), "Eti" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 19, 18, 43, 40, 597, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 8, 19, 18, 43, 40, 597, DateTimeKind.Local).AddTicks(4513), "Giyim" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 8, 19, 18, 43, 40, 597, DateTimeKind.Local).AddTicks(4514), "Yiyecek" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 19, 18, 43, 40, 598, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandId", "CreatedAt", "Description", "Price", "Title" },
                values: new object[] { 2, new DateTime(2024, 8, 19, 18, 43, 40, 598, DateTimeKind.Local).AddTicks(163), "Mavi Nin Erkek Koleksiyonundan Baskılı Siyah Tişört. Loose Fit / Bol Rahat Kesim Kısa Kol", 369.99000000000001, "Baskılı Siyah Tişört" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BrandId", "CreatedAt", "Description", "Price", "Title" },
                values: new object[] { 3, new DateTime(2024, 8, 19, 18, 43, 40, 598, DateTimeKind.Local).AddTicks(164), "Şeker ilavesiz. Doğal lif kaynağı.", 17.5, "Lifalif Kuru Meyveli Yulaf Bar" });
        }
    }
}
