using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyLingerie.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCratedOnForProductAndChangeSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1bfdb702-65cb-42d5-bed7-a51b4aca8443"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2b0b0abf-2cf3-415a-bf1d-2121f4309e9b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("745e3246-7b3c-4b22-8b3d-464e2601730f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c3b0404a-3c30-4ba0-bab6-02da2f033152"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ColorId", "CreatedOn", "Description", "ImageKey", "Name", "Price", "Quantity", "SizeId" },
                values: new object[,]
                {
                    { new Guid("0624386e-da98-407d-9876-04a1156e0528"), new Guid("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"), new Guid("3f3b5865-bd1e-4a21-9473-7a77d601b0f5"), new DateTime(2024, 8, 3, 9, 8, 14, 486, DateTimeKind.Utc).AddTicks(7316), "Dive into paradise with our Tropical Breeze Bikini, featuring a vibrant blend of blue and pink with a chic palm tree pattern. The set includes a flattering bikini and a matching pink pareo, perfect for effortless beach style and comfort. Ideal for sun-soaked getaways and poolside lounging.", "bikiniSeed.jpg", "Tropical Breeze Bikini", 26.00m, 3, new Guid("e2a05d49-c2c4-4ad2-9ae3-f3d1c6a07cb2") },
                    { new Guid("78d40d17-d60b-4759-82fd-33c19db982b5"), new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), new Guid("48f0be7d-e69d-4933-b81c-0ff4b7106d5d"), new DateTime(2024, 8, 3, 9, 8, 14, 486, DateTimeKind.Utc).AddTicks(7414), "Experience elegance and comfort with our Beautiful Pink Lace Underwear. This stunning piece features delicate lace detailing and a lovely pink hue, making it a perfect choice for those who appreciate beauty and style. Ideal for everyday wear or special occasions.", "underwearSeed.jpg", "Beautiful Pink Lace Underwear", 3.50m, 5, new Guid("be1e8a73-6b95-4e2e-9673-d4c5a4e8b0da") },
                    { new Guid("7e0ce8e8-575e-4197-a678-f477dd5e5895"), new Guid("9e8b7c6d-5a4b-3c2d-1e0f-a9b8c7d6e5f4"), new Guid("81e5c1be-6c10-44e7-89ed-8c7dd6b3d1a6"), new DateTime(2024, 8, 3, 9, 8, 14, 486, DateTimeKind.Utc).AddTicks(7435), "Elevate your wardrobe with our Chic Black Lace Tank Top. This versatile piece features elegant lace detailing and a sleek black design, perfect for adding a touch of sophistication to any outfit. Ideal for casual outings or dressed-up events.", "othersSeed.jpg", "Chic Black Lace Tank Top", 29.99m, 7, new Guid("d1b82e13-25c1-4d5e-98c3-769b9b48adf7") },
                    { new Guid("a8194ec2-3eca-4d56-996b-ecf2b70057cc"), new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), new Guid("37bc840f-355e-4bb2-8b79-ccca593ee1c6"), new DateTime(2024, 8, 3, 9, 8, 14, 486, DateTimeKind.Utc).AddTicks(7426), "Embrace sophistication and comfort with our Elegant White Lace Bra. This exquisite piece features intricate lace detailing and a pristine white color, making it an ideal choice for those who appreciate elegance and quality. Perfect for both everyday wear and special occasions.", "braSeed.jpg", "Elegant White Lace Bra", 12.99m, 7, new Guid("c38c1b69-b3b4-4a1b-9e2e-8d5c2d5f0a7e") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0624386e-da98-407d-9876-04a1156e0528"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("78d40d17-d60b-4759-82fd-33c19db982b5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7e0ce8e8-575e-4197-a678-f477dd5e5895"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a8194ec2-3eca-4d56-996b-ecf2b70057cc"));

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ColorId", "Description", "ImageKey", "Name", "Price", "Quantity", "SizeId" },
                values: new object[,]
                {
                    { new Guid("1bfdb702-65cb-42d5-bed7-a51b4aca8443"), new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), new Guid("48f0be7d-e69d-4933-b81c-0ff4b7106d5d"), "Experience elegance and comfort with our Beautiful Pink Lace Underwear. This stunning piece features delicate lace detailing and a lovely pink hue, making it a perfect choice for those who appreciate beauty and style. Ideal for everyday wear or special occasions.", "underwearSeed.jpg", "Beautiful Pink Lace Underwear", 3.50m, 5, new Guid("be1e8a73-6b95-4e2e-9673-d4c5a4e8b0da") },
                    { new Guid("2b0b0abf-2cf3-415a-bf1d-2121f4309e9b"), new Guid("9e8b7c6d-5a4b-3c2d-1e0f-a9b8c7d6e5f4"), new Guid("81e5c1be-6c10-44e7-89ed-8c7dd6b3d1a6"), "Elevate your wardrobe with our Chic Black Lace Tank Top. This versatile piece features elegant lace detailing and a sleek black design, perfect for adding a touch of sophistication to any outfit. Ideal for casual outings or dressed-up events.", "othersSeed.jpg", "Chic Black Lace Tank Top", 29.99m, 7, new Guid("d1b82e13-25c1-4d5e-98c3-769b9b48adf7") },
                    { new Guid("745e3246-7b3c-4b22-8b3d-464e2601730f"), new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), new Guid("37bc840f-355e-4bb2-8b79-ccca593ee1c6"), "Embrace sophistication and comfort with our Elegant White Lace Bra. This exquisite piece features intricate lace detailing and a pristine white color, making it an ideal choice for those who appreciate elegance and quality. Perfect for both everyday wear and special occasions.", "braSeed.jpg", "Elegant White Lace Bra", 12.99m, 7, new Guid("c38c1b69-b3b4-4a1b-9e2e-8d5c2d5f0a7e") },
                    { new Guid("c3b0404a-3c30-4ba0-bab6-02da2f033152"), new Guid("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"), new Guid("3f3b5865-bd1e-4a21-9473-7a77d601b0f5"), "Dive into paradise with our Tropical Breeze Bikini, featuring a vibrant blend of blue and pink with a chic palm tree pattern. The set includes a flattering bikini and a matching pink pareo, perfect for effortless beach style and comfort. Ideal for sun-soaked getaways and poolside lounging.", "bikiniSeed.jpg", "Tropical Breeze Bikini", 26.00m, 3, new Guid("e2a05d49-c2c4-4ad2-9ae3-f3d1c6a07cb2") }
                });
        }
    }
}
