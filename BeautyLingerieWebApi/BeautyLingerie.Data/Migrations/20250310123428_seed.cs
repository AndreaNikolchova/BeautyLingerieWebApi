using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyLingerie.Data.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("9e8b7c6d-5a4b-3c2d-1e0f-a9b8c7d6e5f4"), "Others" },
                    { new Guid("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"), "Bikini" },
                    { new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), "Underwear" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorId", "Name" },
                values: new object[,]
                {
                    { new Guid("111a1245-7c45-4a12-baf4-cbdb5e85f7e6"), "Turquoise" },
                    { new Guid("21ec2020-3aea-4069-a2dd-08002b30309d"), "Blue" },
                    { new Guid("37bc840f-355e-4bb2-8b79-ccca593ee1c6"), "White" },
                    { new Guid("3f3b5865-bd1e-4a21-9473-7a77d601b0f5"), "Multicolor" },
                    { new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "Red" },
                    { new Guid("48f0be7d-e69d-4933-b81c-0ff4b7106d5d"), "Pink" },
                    { new Guid("5531e2b6-0f72-40f8-9d62-6e7fc621c3f4"), "Brown" },
                    { new Guid("68e3f5e2-6f52-4095-85c6-70bfb0d80b29"), "Green" },
                    { new Guid("81e5c1be-6c10-44e7-89ed-8c7dd6b3d1a6"), "Black" },
                    { new Guid("a2d6b5cb-2a3e-4d58-a7fc-e42a67c4ff7d"), "Orange" },
                    { new Guid("a3a0a98e-7e51-4c32-9c2b-b00d9057ed9a"), "Gray" },
                    { new Guid("b5b14f99-b75d-4017-bdd2-2fc08c30f35a"), "Cyan" },
                    { new Guid("b6eb6d37-6d69-4b82-a5ec-9cf9a2e547a1"), "Purple" },
                    { new Guid("c1c34f64-c8e3-4d43-b8f2-d9ad4c2fbc2a"), "Magenta" },
                    { new Guid("d7d6aeba-45b8-49c5-bf80-1d12c967ce5d"), "Lime" },
                    { new Guid("e6e7a663-32b3-4c8f-a1da-051ac8e5dca9"), "Teal" },
                    { new Guid("ed6958ab-267e-4148-97f2-e1d9d4fcd8b7"), "Yellow" },
                    { new Guid("f3f4a0a4-12cb-4f5f-b3a8-3c8c8ea5dc1c"), "Indigo" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeId", "Name" },
                values: new object[,]
                {
                    { new Guid("ae2b67e1-df68-4e2d-9c3a-8b6e1e8b9f3c"), "XXL" },
                    { new Guid("be1e8a73-6b95-4e2e-9673-d4c5a4e8b0da"), "M" },
                    { new Guid("c38c1b69-b3b4-4a1b-9e2e-8d5c2d5f0a7e"), "XL" },
                    { new Guid("d1b82e13-25c1-4d5e-98c3-769b9b48adf7"), "S" },
                    { new Guid("e2a05d49-c2c4-4ad2-9ae3-f3d1c6a07cb2"), "L" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ColorId", "CreatedOn", "Description", "ImageKey", "Name", "OrderId", "Price", "Quantity", "SizeId" },
                values: new object[,]
                {
                    { new Guid("2bddd03a-d568-47a3-8b4b-21641aec2acb"), new Guid("9e8b7c6d-5a4b-3c2d-1e0f-a9b8c7d6e5f4"), new Guid("81e5c1be-6c10-44e7-89ed-8c7dd6b3d1a6"), new DateTime(2025, 3, 10, 12, 34, 27, 639, DateTimeKind.Utc).AddTicks(4699), "Elevate your wardrobe with our Chic Black Lace Tank Top. This versatile piece features elegant lace detailing and a sleek black design, perfect for adding a touch of sophistication to any outfit. Ideal for casual outings or dressed-up events.", "othersSeed.jpg", "Chic Black Lace Tank Top", null, 29.99m, 7, new Guid("d1b82e13-25c1-4d5e-98c3-769b9b48adf7") },
                    { new Guid("48746951-61da-415d-802c-692de3a86c5b"), new Guid("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"), new Guid("3f3b5865-bd1e-4a21-9473-7a77d601b0f5"), new DateTime(2025, 3, 10, 12, 34, 27, 639, DateTimeKind.Utc).AddTicks(4636), "Dive into paradise with our Tropical Breeze Bikini, featuring a vibrant blend of blue and pink with a chic palm tree pattern. The set includes a flattering bikini and a matching pink pareo, perfect for effortless beach style and comfort. Ideal for sun-soaked getaways and poolside lounging.", "bikiniSeed.jpg", "Tropical Breeze Bikini", null, 26.00m, 3, new Guid("e2a05d49-c2c4-4ad2-9ae3-f3d1c6a07cb2") },
                    { new Guid("6b9dbbfb-b003-4922-bfa0-9bcbc9c96ed3"), new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), new Guid("48f0be7d-e69d-4933-b81c-0ff4b7106d5d"), new DateTime(2025, 3, 10, 12, 34, 27, 639, DateTimeKind.Utc).AddTicks(4680), "Experience elegance and comfort with our Beautiful Pink Lace Underwear. This stunning piece features delicate lace detailing and a lovely pink hue, making it a perfect choice for those who appreciate beauty and style. Ideal for everyday wear or special occasions.", "underwearSeed.jpg", "Beautiful Pink Lace Underwear", null, 3.50m, 5, new Guid("be1e8a73-6b95-4e2e-9673-d4c5a4e8b0da") },
                    { new Guid("db473dd2-5392-4422-b176-23d0cc786750"), new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), new Guid("37bc840f-355e-4bb2-8b79-ccca593ee1c6"), new DateTime(2025, 3, 10, 12, 34, 27, 639, DateTimeKind.Utc).AddTicks(4690), "Embrace sophistication and comfort with our Elegant White Lace Bra. This exquisite piece features intricate lace detailing and a pristine white color, making it an ideal choice for those who appreciate elegance and quality. Perfect for both everyday wear and special occasions.", "braSeed.jpg", "Elegant White Lace Bra", null, 12.99m, 7, new Guid("c38c1b69-b3b4-4a1b-9e2e-8d5c2d5f0a7e") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("111a1245-7c45-4a12-baf4-cbdb5e85f7e6"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("21ec2020-3aea-4069-a2dd-08002b30309d"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("5531e2b6-0f72-40f8-9d62-6e7fc621c3f4"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("68e3f5e2-6f52-4095-85c6-70bfb0d80b29"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("a2d6b5cb-2a3e-4d58-a7fc-e42a67c4ff7d"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("a3a0a98e-7e51-4c32-9c2b-b00d9057ed9a"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("b5b14f99-b75d-4017-bdd2-2fc08c30f35a"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("b6eb6d37-6d69-4b82-a5ec-9cf9a2e547a1"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("c1c34f64-c8e3-4d43-b8f2-d9ad4c2fbc2a"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("d7d6aeba-45b8-49c5-bf80-1d12c967ce5d"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("e6e7a663-32b3-4c8f-a1da-051ac8e5dca9"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("ed6958ab-267e-4148-97f2-e1d9d4fcd8b7"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("f3f4a0a4-12cb-4f5f-b3a8-3c8c8ea5dc1c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2bddd03a-d568-47a3-8b4b-21641aec2acb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("48746951-61da-415d-802c-692de3a86c5b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6b9dbbfb-b003-4922-bfa0-9bcbc9c96ed3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("db473dd2-5392-4422-b176-23d0cc786750"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: new Guid("ae2b67e1-df68-4e2d-9c3a-8b6e1e8b9f3c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("9e8b7c6d-5a4b-3c2d-1e0f-a9b8c7d6e5f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("37bc840f-355e-4bb2-8b79-ccca593ee1c6"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("3f3b5865-bd1e-4a21-9473-7a77d601b0f5"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("48f0be7d-e69d-4933-b81c-0ff4b7106d5d"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("81e5c1be-6c10-44e7-89ed-8c7dd6b3d1a6"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: new Guid("be1e8a73-6b95-4e2e-9673-d4c5a4e8b0da"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: new Guid("c38c1b69-b3b4-4a1b-9e2e-8d5c2d5f0a7e"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: new Guid("d1b82e13-25c1-4d5e-98c3-769b9b48adf7"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: new Guid("e2a05d49-c2c4-4ad2-9ae3-f3d1c6a07cb2"));
        }
    }
}
