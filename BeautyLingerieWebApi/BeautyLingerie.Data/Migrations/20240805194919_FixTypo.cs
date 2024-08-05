using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyLingerie.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixTypo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Color_ColorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Size_SizeId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Size",
                table: "Size");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Color",
                table: "Color");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1016cdc5-e0e0-4c94-b07a-509bbd270806"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("727a4ce0-a41a-484a-b50a-fe6085bcbe2b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("78e401f0-6377-4dec-833a-a13d7c4006c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("acf5fd46-415a-4699-921b-2fad7c4b924f"));

            migrationBuilder.RenameTable(
                name: "Size",
                newName: "Sizes");

            migrationBuilder.RenameTable(
                name: "Color",
                newName: "Colors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes",
                column: "SizeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colors",
                table: "Colors",
                column: "ColorId");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ColorId", "CreatedOn", "Description", "ImageKey", "Name", "Price", "Quantity", "SizeId" },
                values: new object[,]
                {
                    { new Guid("8941c16b-adbb-4883-89c4-6eca223b37f3"), new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), new Guid("48f0be7d-e69d-4933-b81c-0ff4b7106d5d"), new DateTime(2024, 8, 5, 19, 49, 18, 348, DateTimeKind.Utc).AddTicks(9109), "Experience elegance and comfort with our Beautiful Pink Lace Underwear. This stunning piece features delicate lace detailing and a lovely pink hue, making it a perfect choice for those who appreciate beauty and style. Ideal for everyday wear or special occasions.", "underwearSeed.jpg", "Beautiful Pink Lace Underwear", 3.50m, 5, new Guid("be1e8a73-6b95-4e2e-9673-d4c5a4e8b0da") },
                    { new Guid("96a9c366-a244-4c4f-9107-0b9f8a0cc2ca"), new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), new Guid("37bc840f-355e-4bb2-8b79-ccca593ee1c6"), new DateTime(2024, 8, 5, 19, 49, 18, 348, DateTimeKind.Utc).AddTicks(9118), "Embrace sophistication and comfort with our Elegant White Lace Bra. This exquisite piece features intricate lace detailing and a pristine white color, making it an ideal choice for those who appreciate elegance and quality. Perfect for both everyday wear and special occasions.", "braSeed.jpg", "Elegant White Lace Bra", 12.99m, 7, new Guid("c38c1b69-b3b4-4a1b-9e2e-8d5c2d5f0a7e") },
                    { new Guid("a9d6314f-fb39-4fb6-ab40-032010d3358b"), new Guid("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"), new Guid("3f3b5865-bd1e-4a21-9473-7a77d601b0f5"), new DateTime(2024, 8, 5, 19, 49, 18, 348, DateTimeKind.Utc).AddTicks(9091), "Dive into paradise with our Tropical Breeze Bikini, featuring a vibrant blend of blue and pink with a chic palm tree pattern. The set includes a flattering bikini and a matching pink pareo, perfect for effortless beach style and comfort. Ideal for sun-soaked getaways and poolside lounging.", "bikiniSeed.jpg", "Tropical Breeze Bikini", 26.00m, 3, new Guid("e2a05d49-c2c4-4ad2-9ae3-f3d1c6a07cb2") },
                    { new Guid("c4994d44-3f46-44c5-ba09-30d32dfbf113"), new Guid("9e8b7c6d-5a4b-3c2d-1e0f-a9b8c7d6e5f4"), new Guid("81e5c1be-6c10-44e7-89ed-8c7dd6b3d1a6"), new DateTime(2024, 8, 5, 19, 49, 18, 348, DateTimeKind.Utc).AddTicks(9126), "Elevate your wardrobe with our Chic Black Lace Tank Top. This versatile piece features elegant lace detailing and a sleek black design, perfect for adding a touch of sophistication to any outfit. Ideal for casual outings or dressed-up events.", "othersSeed.jpg", "Chic Black Lace Tank Top", 29.99m, 7, new Guid("d1b82e13-25c1-4d5e-98c3-769b9b48adf7") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Colors_ColorId",
                table: "Products",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "ColorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sizes_SizeId",
                table: "Products",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "SizeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Colors_ColorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sizes_SizeId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colors",
                table: "Colors");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8941c16b-adbb-4883-89c4-6eca223b37f3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("96a9c366-a244-4c4f-9107-0b9f8a0cc2ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a9d6314f-fb39-4fb6-ab40-032010d3358b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c4994d44-3f46-44c5-ba09-30d32dfbf113"));

            migrationBuilder.RenameTable(
                name: "Sizes",
                newName: "Size");

            migrationBuilder.RenameTable(
                name: "Colors",
                newName: "Color");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Size",
                table: "Size",
                column: "SizeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Color",
                table: "Color",
                column: "ColorId");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ColorId", "CreatedOn", "Description", "ImageKey", "Name", "Price", "Quantity", "SizeId" },
                values: new object[,]
                {
                    { new Guid("1016cdc5-e0e0-4c94-b07a-509bbd270806"), new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), new Guid("37bc840f-355e-4bb2-8b79-ccca593ee1c6"), new DateTime(2024, 8, 4, 7, 58, 2, 158, DateTimeKind.Utc).AddTicks(7158), "Embrace sophistication and comfort with our Elegant White Lace Bra. This exquisite piece features intricate lace detailing and a pristine white color, making it an ideal choice for those who appreciate elegance and quality. Perfect for both everyday wear and special occasions.", "braSeed.jpg", "Elegant White Lace Bra", 12.99m, 7, new Guid("c38c1b69-b3b4-4a1b-9e2e-8d5c2d5f0a7e") },
                    { new Guid("727a4ce0-a41a-484a-b50a-fe6085bcbe2b"), new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), new Guid("48f0be7d-e69d-4933-b81c-0ff4b7106d5d"), new DateTime(2024, 8, 4, 7, 58, 2, 158, DateTimeKind.Utc).AddTicks(7152), "Experience elegance and comfort with our Beautiful Pink Lace Underwear. This stunning piece features delicate lace detailing and a lovely pink hue, making it a perfect choice for those who appreciate beauty and style. Ideal for everyday wear or special occasions.", "underwearSeed.jpg", "Beautiful Pink Lace Underwear", 3.50m, 5, new Guid("be1e8a73-6b95-4e2e-9673-d4c5a4e8b0da") },
                    { new Guid("78e401f0-6377-4dec-833a-a13d7c4006c6"), new Guid("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"), new Guid("3f3b5865-bd1e-4a21-9473-7a77d601b0f5"), new DateTime(2024, 8, 4, 7, 58, 2, 158, DateTimeKind.Utc).AddTicks(7137), "Dive into paradise with our Tropical Breeze Bikini, featuring a vibrant blend of blue and pink with a chic palm tree pattern. The set includes a flattering bikini and a matching pink pareo, perfect for effortless beach style and comfort. Ideal for sun-soaked getaways and poolside lounging.", "bikiniSeed.jpg", "Tropical Breeze Bikini", 26.00m, 3, new Guid("e2a05d49-c2c4-4ad2-9ae3-f3d1c6a07cb2") },
                    { new Guid("acf5fd46-415a-4699-921b-2fad7c4b924f"), new Guid("9e8b7c6d-5a4b-3c2d-1e0f-a9b8c7d6e5f4"), new Guid("81e5c1be-6c10-44e7-89ed-8c7dd6b3d1a6"), new DateTime(2024, 8, 4, 7, 58, 2, 158, DateTimeKind.Utc).AddTicks(7163), "Elevate your wardrobe with our Chic Black Lace Tank Top. This versatile piece features elegant lace detailing and a sleek black design, perfect for adding a touch of sophistication to any outfit. Ideal for casual outings or dressed-up events.", "othersSeed.jpg", "Chic Black Lace Tank Top", 29.99m, 7, new Guid("d1b82e13-25c1-4d5e-98c3-769b9b48adf7") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Color_ColorId",
                table: "Products",
                column: "ColorId",
                principalTable: "Color",
                principalColumn: "ColorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Size_SizeId",
                table: "Products",
                column: "SizeId",
                principalTable: "Size",
                principalColumn: "SizeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
