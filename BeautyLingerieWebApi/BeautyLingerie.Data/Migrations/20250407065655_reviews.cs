using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyLingerie.Data.Migrations
{
    /// <inheritdoc />
    public partial class reviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("09595ab6-c4af-4223-812c-6d74f2767997"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 7, 6, 56, 54, 200, DateTimeKind.Utc).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2352a676-800c-4e14-8ee7-1ca1fd32280c"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 7, 6, 56, 54, 200, DateTimeKind.Utc).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 7, 6, 56, 54, 200, DateTimeKind.Utc).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e9c8d216-5c64-4f78-8487-41dc0a29c77e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 7, 6, 56, 54, 200, DateTimeKind.Utc).AddTicks(8266));

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId_UserId",
                table: "Reviews",
                columns: new[] { "ProductId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("09595ab6-c4af-4223-812c-6d74f2767997"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 4, 8, 25, 33, 556, DateTimeKind.Utc).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2352a676-800c-4e14-8ee7-1ca1fd32280c"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 4, 8, 25, 33, 556, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 4, 8, 25, 33, 556, DateTimeKind.Utc).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e9c8d216-5c64-4f78-8487-41dc0a29c77e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 4, 8, 25, 33, 556, DateTimeKind.Utc).AddTicks(4591));
        }
    }
}
