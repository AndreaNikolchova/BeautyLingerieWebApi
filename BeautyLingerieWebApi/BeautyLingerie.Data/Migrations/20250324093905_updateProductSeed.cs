﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyLingerie.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateProductSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("106e1a9e-69f3-4a8e-8246-7af2e3f8d7de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1238b8db-1d43-4400-9080-ff5cec39dde5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6566eff9-a894-4afc-899d-12e394d6c4cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8ca3687c-c089-40c2-a843-1d5bbc646bb1"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ColorId", "CreatedOn", "Description", "ImageUrl", "Name", "OrderId", "Price", "Quantity", "SizeId" },
                values: new object[,]
                {
                    { new Guid("3e1aa9a0-5850-4f73-bf0b-57c3d4b00f37"), new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), new Guid("48f0be7d-e69d-4933-b81c-0ff4b7106d5d"), new DateTime(2025, 3, 24, 9, 39, 5, 158, DateTimeKind.Utc).AddTicks(3900), "Experience elegance and comfort with our Beautiful Pink Lace Underwear. This stunning piece features delicate lace detailing and a lovely pink hue, making it a perfect choice for those who appreciate beauty and style. Ideal for everyday wear or special occasions.", "https://res.cloudinary.com/dqko9lpej/image/upload/v1742805902/jvvbilveebrqwey5vnn9.jpg", "Beautiful Pink Lace Underwear", null, 3.50m, 5, new Guid("be1e8a73-6b95-4e2e-9673-d4c5a4e8b0da") },
                    { new Guid("5a30789c-b3af-4fdf-bb2f-e9661902526b"), new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), new Guid("37bc840f-355e-4bb2-8b79-ccca593ee1c6"), new DateTime(2025, 3, 24, 9, 39, 5, 158, DateTimeKind.Utc).AddTicks(3907), "Embrace sophistication and comfort with our Elegant White Lace Bra. This exquisite piece features intricate lace detailing and a pristine white color, making it an ideal choice for those who appreciate elegance and quality. Perfect for both everyday wear and special occasions.", "https://res.cloudinary.com/dqko9lpej/image/upload/v1742805902/w0hvcjfrp7tcbucmszu1.jpg", "Elegant White Lace Bra", null, 12.99m, 7, new Guid("c38c1b69-b3b4-4a1b-9e2e-8d5c2d5f0a7e") },
                    { new Guid("992a8b7a-0bdc-43cd-bc2e-f8c74174855e"), new Guid("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"), new Guid("3f3b5865-bd1e-4a21-9473-7a77d601b0f5"), new DateTime(2025, 3, 24, 9, 39, 5, 158, DateTimeKind.Utc).AddTicks(3809), "Dive into paradise with our Tropical Breeze Bikini, featuring a vibrant blend of blue and pink with a chic palm tree pattern. The set includes a flattering bikini and a matching pink pareo, perfect for effortless beach style and comfort. Ideal for sun-soaked getaways and poolside lounging.", "https://res.cloudinary.com/dqko9lpej/image/upload/v1742805902/zaplviqvawybdtxwgoto.jpg", "Tropical Breeze Bikini", null, 26.00m, 3, new Guid("e2a05d49-c2c4-4ad2-9ae3-f3d1c6a07cb2") },
                    { new Guid("99da9a32-f709-430a-973e-42c4ee421a10"), new Guid("9e8b7c6d-5a4b-3c2d-1e0f-a9b8c7d6e5f4"), new Guid("81e5c1be-6c10-44e7-89ed-8c7dd6b3d1a6"), new DateTime(2025, 3, 24, 9, 39, 5, 158, DateTimeKind.Utc).AddTicks(3929), "Elevate your wardrobe with our Chic Black Lace Tank Top. This versatile piece features elegant lace detailing and a sleek black design, perfect for adding a touch of sophistication to any outfit. Ideal for casual outings or dressed-up events.", "https://res.cloudinary.com/dqko9lpej/image/upload/v1742805902/rbku1kdduiuluc8jq6qy.jpg", "Chic Black Lace Tank Top", null, 29.99m, 7, new Guid("d1b82e13-25c1-4d5e-98c3-769b9b48adf7") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3e1aa9a0-5850-4f73-bf0b-57c3d4b00f37"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5a30789c-b3af-4fdf-bb2f-e9661902526b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("992a8b7a-0bdc-43cd-bc2e-f8c74174855e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("99da9a32-f709-430a-973e-42c4ee421a10"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ColorId", "CreatedOn", "Description", "ImageUrl", "Name", "OrderId", "Price", "Quantity", "SizeId" },
                values: new object[,]
                {
                    { new Guid("106e1a9e-69f3-4a8e-8246-7af2e3f8d7de"), new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), new Guid("37bc840f-355e-4bb2-8b79-ccca593ee1c6"), new DateTime(2025, 3, 24, 9, 28, 36, 496, DateTimeKind.Utc).AddTicks(7660), "Embrace sophistication and comfort with our Elegant White Lace Bra. This exquisite piece features intricate lace detailing and a pristine white color, making it an ideal choice for those who appreciate elegance and quality. Perfect for both everyday wear and special occasions.", "https://console.cloudinary.com/pm/c-2a076cc0b769b72f259e84193cdb7b/media-explorer?assetId=946f30a2977208640c668e4ac0e8fdc8", "Elegant White Lace Bra", null, 12.99m, 7, new Guid("c38c1b69-b3b4-4a1b-9e2e-8d5c2d5f0a7e") },
                    { new Guid("1238b8db-1d43-4400-9080-ff5cec39dde5"), new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), new Guid("48f0be7d-e69d-4933-b81c-0ff4b7106d5d"), new DateTime(2025, 3, 24, 9, 28, 36, 496, DateTimeKind.Utc).AddTicks(7653), "Experience elegance and comfort with our Beautiful Pink Lace Underwear. This stunning piece features delicate lace detailing and a lovely pink hue, making it a perfect choice for those who appreciate beauty and style. Ideal for everyday wear or special occasions.", "https://console.cloudinary.com/pm/c-2a076cc0b769b72f259e84193cdb7b/media-explorer?assetId=32bb34227e2e90652e75aaac0fe12952", "Beautiful Pink Lace Underwear", null, 3.50m, 5, new Guid("be1e8a73-6b95-4e2e-9673-d4c5a4e8b0da") },
                    { new Guid("6566eff9-a894-4afc-899d-12e394d6c4cd"), new Guid("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"), new Guid("3f3b5865-bd1e-4a21-9473-7a77d601b0f5"), new DateTime(2025, 3, 24, 9, 28, 36, 496, DateTimeKind.Utc).AddTicks(7639), "Dive into paradise with our Tropical Breeze Bikini, featuring a vibrant blend of blue and pink with a chic palm tree pattern. The set includes a flattering bikini and a matching pink pareo, perfect for effortless beach style and comfort. Ideal for sun-soaked getaways and poolside lounging.", "https://console.cloudinary.com/pm/c-2a076cc0b769b72f259e84193cdb7b/media-explorer?assetId=8a90fe72a0ed62564a764443e3f1da13", "Tropical Breeze Bikini", null, 26.00m, 3, new Guid("e2a05d49-c2c4-4ad2-9ae3-f3d1c6a07cb2") },
                    { new Guid("8ca3687c-c089-40c2-a843-1d5bbc646bb1"), new Guid("9e8b7c6d-5a4b-3c2d-1e0f-a9b8c7d6e5f4"), new Guid("81e5c1be-6c10-44e7-89ed-8c7dd6b3d1a6"), new DateTime(2025, 3, 24, 9, 28, 36, 496, DateTimeKind.Utc).AddTicks(7667), "Elevate your wardrobe with our Chic Black Lace Tank Top. This versatile piece features elegant lace detailing and a sleek black design, perfect for adding a touch of sophistication to any outfit. Ideal for casual outings or dressed-up events.", "https://console.cloudinary.com/pm/c-2a076cc0b769b72f259e84193cdb7b/media-explorer?assetId=0e4a4786e53ed295a04a1dd4956e3151", "Chic Black Lace Tank Top", null, 29.99m, 7, new Guid("d1b82e13-25c1-4d5e-98c3-769b9b48adf7") }
                });
        }
    }
}
