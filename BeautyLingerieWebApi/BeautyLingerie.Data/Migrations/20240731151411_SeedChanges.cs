using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyLingerie.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("278d814c-d3f5-44a0-b7ab-df6ce0311a52"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3b2c2dc5-660c-495e-86b4-b6c6faca5f65"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8e9e6403-449e-476c-a584-37c2412da5a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("95a32523-9225-4a80-b1ed-f766f955d6d7"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ColorId", "Description", "ImageKey", "Name", "Price", "Quantity", "SizeId" },
                values: new object[,]
                {
                    { new Guid("8dba6b23-28c6-4a33-a196-11baff25e8be"), new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), new Guid("48f0be7d-e69d-4933-b81c-0ff4b7106d5d"), "Experience elegance and comfort with our Beautiful Pink Lace Underwear. This stunning piece features delicate lace detailing and a lovely pink hue, making it a perfect choice for those who appreciate beauty and style. Ideal for everyday wear or special occasions.", "underwearSeed.jpg", "Beautiful Pink Lace Underwear", 3.50m, 5, new Guid("be1e8a73-6b95-4e2e-9673-d4c5a4e8b0da") },
                    { new Guid("96db6ea0-7619-4a1e-a464-b18118e42b0d"), new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), new Guid("37bc840f-355e-4bb2-8b79-ccca593ee1c6"), "Embrace sophistication and comfort with our Elegant White Lace Bra. This exquisite piece features intricate lace detailing and a pristine white color, making it an ideal choice for those who appreciate elegance and quality. Perfect for both everyday wear and special occasions.", "braSeed.jpg", "Elegant White Lace Bra", 12.99m, 7, new Guid("c38c1b69-b3b4-4a1b-9e2e-8d5c2d5f0a7e") },
                    { new Guid("a3574b3b-ea81-43c2-9cbe-c6e1418e4272"), new Guid("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"), new Guid("3f3b5865-bd1e-4a21-9473-7a77d601b0f5"), "Dive into paradise with our Tropical Breeze Bikini, featuring a vibrant blend of blue and pink with a chic palm tree pattern. The set includes a flattering bikini and a matching pink pareo, perfect for effortless beach style and comfort. Ideal for sun-soaked getaways and poolside lounging.", "bikiniSeed.jpg", "Tropical Breeze Bikini", 26.00m, 3, new Guid("e2a05d49-c2c4-4ad2-9ae3-f3d1c6a07cb2") },
                    { new Guid("e7ecaeb8-4bd7-4f66-ba72-84d5c53ccbe0"), new Guid("9e8b7c6d-5a4b-3c2d-1e0f-a9b8c7d6e5f4"), new Guid("81e5c1be-6c10-44e7-89ed-8c7dd6b3d1a6"), "Elevate your wardrobe with our Chic Black Lace Tank Top. This versatile piece features elegant lace detailing and a sleek black design, perfect for adding a touch of sophistication to any outfit. Ideal for casual outings or dressed-up events.", "othersSeed.jpg", "Chic Black Lace Tank Top", 29.99m, 7, new Guid("d1b82e13-25c1-4d5e-98c3-769b9b48adf7") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8dba6b23-28c6-4a33-a196-11baff25e8be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("96db6ea0-7619-4a1e-a464-b18118e42b0d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a3574b3b-ea81-43c2-9cbe-c6e1418e4272"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e7ecaeb8-4bd7-4f66-ba72-84d5c53ccbe0"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ColorId", "Description", "ImageKey", "Name", "Price", "Quantity", "SizeId" },
                values: new object[,]
                {
                    { new Guid("278d814c-d3f5-44a0-b7ab-df6ce0311a52"), new Guid("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"), new Guid("3f3b5865-bd1e-4a21-9473-7a77d601b0f5"), "Dive into paradise with our Tropical Breeze Bikini, featuring a vibrant blend of blue and pink with a chic palm tree pattern. The set includes a flattering bikini and a matching pink pareo, perfect for effortless beach style and comfort. Ideal for sun-soaked getaways and poolside lounging.", "bikiniSeed", "Tropical Breeze Bikini", 26.00m, 3, new Guid("e2a05d49-c2c4-4ad2-9ae3-f3d1c6a07cb2") },
                    { new Guid("3b2c2dc5-660c-495e-86b4-b6c6faca5f65"), new Guid("9e8b7c6d-5a4b-3c2d-1e0f-a9b8c7d6e5f4"), new Guid("81e5c1be-6c10-44e7-89ed-8c7dd6b3d1a6"), "Elevate your wardrobe with our Chic Black Lace Tank Top. This versatile piece features elegant lace detailing and a sleek black design, perfect for adding a touch of sophistication to any outfit. Ideal for casual outings or dressed-up events.", "othersSeed", "Chic Black Lace Tank Top", 29.99m, 7, new Guid("d1b82e13-25c1-4d5e-98c3-769b9b48adf7") },
                    { new Guid("8e9e6403-449e-476c-a584-37c2412da5a7"), new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), new Guid("37bc840f-355e-4bb2-8b79-ccca593ee1c6"), "Embrace sophistication and comfort with our Elegant White Lace Bra. This exquisite piece features intricate lace detailing and a pristine white color, making it an ideal choice for those who appreciate elegance and quality. Perfect for both everyday wear and special occasions.", "braSeed", "Elegant White Lace Bra", 12.99m, 7, new Guid("c38c1b69-b3b4-4a1b-9e2e-8d5c2d5f0a7e") },
                    { new Guid("95a32523-9225-4a80-b1ed-f766f955d6d7"), new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), new Guid("48f0be7d-e69d-4933-b81c-0ff4b7106d5d"), "Experience elegance and comfort with our Beautiful Pink Lace Underwear. This stunning piece features delicate lace detailing and a lovely pink hue, making it a perfect choice for those who appreciate beauty and style. Ideal for everyday wear or special occasions.", "underwearSeed", "Beautiful Pink Lace Underwear", 3.50m, 5, new Guid("be1e8a73-6b95-4e2e-9673-d4c5a4e8b0da") }
                });
        }
    }
}
