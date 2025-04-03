using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyLingerie.Data.Migrations
{
    /// <inheritdoc />
    public partial class productQuantitiesToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0a3235bd-a81f-491f-b602-9b6a811ec42b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("10917c33-b47e-44e9-be0d-fd9c8f8f1d01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a5f498d8-90cf-45ec-be33-31be720c4f28"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e9e9268e-62b6-43d5-a802-6ad5ce495523"));

            migrationBuilder.AddColumn<string>(
                name: "ProductQuanties",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ColorId", "CreatedOn", "Description", "ImageUrl", "Name", "OrderId", "Price", "Quantity", "SizeId" },
                values: new object[,]
                {
                    { new Guid("18e3efd6-a8c8-4594-b8f2-ae2cbd905f8b"), new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), new Guid("37bc840f-355e-4bb2-8b79-ccca593ee1c6"), new DateTime(2025, 4, 3, 18, 10, 11, 411, DateTimeKind.Utc).AddTicks(2261), "Embrace sophistication and comfort with our Elegant White Lace Bra. This exquisite piece features intricate lace detailing and a pristine white color, making it an ideal choice for those who appreciate elegance and quality. Perfect for both everyday wear and special occasions.", "https://res.cloudinary.com/dqko9lpej/image/upload/v1742805902/w0hvcjfrp7tcbucmszu1.jpg", "Elegant White Lace Bra", null, 12.99m, 7, new Guid("c38c1b69-b3b4-4a1b-9e2e-8d5c2d5f0a7e") },
                    { new Guid("700707e7-8210-4453-aee6-da118c47b2e7"), new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), new Guid("48f0be7d-e69d-4933-b81c-0ff4b7106d5d"), new DateTime(2025, 4, 3, 18, 10, 11, 411, DateTimeKind.Utc).AddTicks(2255), "Experience elegance and comfort with our Beautiful Pink Lace Underwear. This stunning piece features delicate lace detailing and a lovely pink hue, making it a perfect choice for those who appreciate beauty and style. Ideal for everyday wear or special occasions.", "https://res.cloudinary.com/dqko9lpej/image/upload/v1742805902/jvvbilveebrqwey5vnn9.jpg", "Beautiful Pink Lace Underwear", null, 3.50m, 5, new Guid("be1e8a73-6b95-4e2e-9673-d4c5a4e8b0da") },
                    { new Guid("9eebb0be-d70f-4a39-91a2-9d337aee143d"), new Guid("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"), new Guid("3f3b5865-bd1e-4a21-9473-7a77d601b0f5"), new DateTime(2025, 4, 3, 18, 10, 11, 411, DateTimeKind.Utc).AddTicks(2242), "Dive into paradise with our Tropical Breeze Bikini, featuring a vibrant blend of blue and pink with a chic palm tree pattern. The set includes a flattering bikini and a matching pink pareo, perfect for effortless beach style and comfort. Ideal for sun-soaked getaways and poolside lounging.", "https://res.cloudinary.com/dqko9lpej/image/upload/v1742805902/zaplviqvawybdtxwgoto.jpg", "Tropical Breeze Bikini", null, 26.00m, 3, new Guid("e2a05d49-c2c4-4ad2-9ae3-f3d1c6a07cb2") },
                    { new Guid("b88b44f6-6f56-47b5-ad9e-fc5f9429ec04"), new Guid("9e8b7c6d-5a4b-3c2d-1e0f-a9b8c7d6e5f4"), new Guid("81e5c1be-6c10-44e7-89ed-8c7dd6b3d1a6"), new DateTime(2025, 4, 3, 18, 10, 11, 411, DateTimeKind.Utc).AddTicks(2283), "Elevate your wardrobe with our Chic Black Lace Tank Top. This versatile piece features elegant lace detailing and a sleek black design, perfect for adding a touch of sophistication to any outfit. Ideal for casual outings or dressed-up events.", "https://res.cloudinary.com/dqko9lpej/image/upload/v1742805902/rbku1kdduiuluc8jq6qy.jpg", "Chic Black Lace Tank Top", null, 29.99m, 7, new Guid("d1b82e13-25c1-4d5e-98c3-769b9b48adf7") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("18e3efd6-a8c8-4594-b8f2-ae2cbd905f8b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("700707e7-8210-4453-aee6-da118c47b2e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9eebb0be-d70f-4a39-91a2-9d337aee143d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b88b44f6-6f56-47b5-ad9e-fc5f9429ec04"));

            migrationBuilder.DropColumn(
                name: "ProductQuanties",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ColorId", "CreatedOn", "Description", "ImageUrl", "Name", "OrderId", "Price", "Quantity", "SizeId" },
                values: new object[,]
                {
                    { new Guid("0a3235bd-a81f-491f-b602-9b6a811ec42b"), new Guid("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"), new Guid("3f3b5865-bd1e-4a21-9473-7a77d601b0f5"), new DateTime(2025, 4, 1, 11, 14, 49, 688, DateTimeKind.Utc).AddTicks(9216), "Dive into paradise with our Tropical Breeze Bikini, featuring a vibrant blend of blue and pink with a chic palm tree pattern. The set includes a flattering bikini and a matching pink pareo, perfect for effortless beach style and comfort. Ideal for sun-soaked getaways and poolside lounging.", "https://res.cloudinary.com/dqko9lpej/image/upload/v1742805902/zaplviqvawybdtxwgoto.jpg", "Tropical Breeze Bikini", null, 26.00m, 3, new Guid("e2a05d49-c2c4-4ad2-9ae3-f3d1c6a07cb2") },
                    { new Guid("10917c33-b47e-44e9-be0d-fd9c8f8f1d01"), new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), new Guid("48f0be7d-e69d-4933-b81c-0ff4b7106d5d"), new DateTime(2025, 4, 1, 11, 14, 49, 688, DateTimeKind.Utc).AddTicks(9231), "Experience elegance and comfort with our Beautiful Pink Lace Underwear. This stunning piece features delicate lace detailing and a lovely pink hue, making it a perfect choice for those who appreciate beauty and style. Ideal for everyday wear or special occasions.", "https://res.cloudinary.com/dqko9lpej/image/upload/v1742805902/jvvbilveebrqwey5vnn9.jpg", "Beautiful Pink Lace Underwear", null, 3.50m, 5, new Guid("be1e8a73-6b95-4e2e-9673-d4c5a4e8b0da") },
                    { new Guid("a5f498d8-90cf-45ec-be33-31be720c4f28"), new Guid("9e8b7c6d-5a4b-3c2d-1e0f-a9b8c7d6e5f4"), new Guid("81e5c1be-6c10-44e7-89ed-8c7dd6b3d1a6"), new DateTime(2025, 4, 1, 11, 14, 49, 688, DateTimeKind.Utc).AddTicks(9288), "Elevate your wardrobe with our Chic Black Lace Tank Top. This versatile piece features elegant lace detailing and a sleek black design, perfect for adding a touch of sophistication to any outfit. Ideal for casual outings or dressed-up events.", "https://res.cloudinary.com/dqko9lpej/image/upload/v1742805902/rbku1kdduiuluc8jq6qy.jpg", "Chic Black Lace Tank Top", null, 29.99m, 7, new Guid("d1b82e13-25c1-4d5e-98c3-769b9b48adf7") },
                    { new Guid("e9e9268e-62b6-43d5-a802-6ad5ce495523"), new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), new Guid("37bc840f-355e-4bb2-8b79-ccca593ee1c6"), new DateTime(2025, 4, 1, 11, 14, 49, 688, DateTimeKind.Utc).AddTicks(9236), "Embrace sophistication and comfort with our Elegant White Lace Bra. This exquisite piece features intricate lace detailing and a pristine white color, making it an ideal choice for those who appreciate elegance and quality. Perfect for both everyday wear and special occasions.", "https://res.cloudinary.com/dqko9lpej/image/upload/v1742805902/w0hvcjfrp7tcbucmszu1.jpg", "Elegant White Lace Bra", null, 12.99m, 7, new Guid("c38c1b69-b3b4-4a1b-9e2e-8d5c2d5f0a7e") }
                });
        }
    }
}
