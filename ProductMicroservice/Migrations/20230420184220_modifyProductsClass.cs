using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductMicroservice.Migrations
{
    /// <inheritdoc />
    public partial class modifyProductsClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<AlterColumnOperation>(
               name: "Description",table: "Products", nullable: true);

            migrationBuilder.AlterColumn<AlterColumnOperation>(
               name: "CreatedBy", table: "Products", nullable: true);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryID", "CreatedBy", "Description", "ImageBase64", "ProductName", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, "", "", "nft1", "nft1.webp", 20.0 },
                    { 2, 2, "", "", "nft2", "nft2.webp", 50.0 },
                    { 3, 3, "", "", "nft3", "nft3.webp", 55.0 },
                    { 4, 4, "", "", "nft4", "nft4.webp", 30.0 },
                    { 5, 1, "", "", "nft5", "nft5.webp", 20.0 },
                    { 6, 2, "", "", "nft6", "nft6.webp", 10.0 },
                    { 7, 3, "", "", "nft7", "nft7.webp", 20.0 },
                    { 8, 4, "", "", "nft8", "nft8.jpg", 20.0 },
                    { 9, 1, "", "", "nft9", "nft9.webp", 25.0 },
                    { 10, 2, "", "", "nft10", "nft10.webp", 30.0 },
                    { 11, 3, "", "", "nft11", "nft11.webp", 40.0 },
                    { 12, 4, "", "", "nft12", "nft12.webp", 20.0 },
                    { 13, 1, "", "", "nft13", "nft13.webp", 30.0 },
                    { 14, 2, "", "", "nft14", "nft14.webp", 50.0 },
                    { 15, 3, "", "", "nft15", "nft15.webp", 20.0 },
                    { 16, 4, "", "", "nft16", "nft16.webp", 20.0 },
                    { 17, 1, "", "", "nft18", "nft18.webp", 20.0 },
                    { 18, 2, "", "", "nft19", "nft19.webp", 20.0 },
                    { 19, 3, "", "", "nft20", "nft20.webp", 20.0 },
                    { 20, 4, "", "", "nft21", "nft21.webp", 20.0 },
                    { 21, 1, "", "", "nft17", "nft17.webp", 28.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
               name: "Products");

            migrationBuilder.AlterTable(
              name: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);
        }
    }
}
