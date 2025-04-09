using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyLingerie.Data.Migrations
{
    /// <inheritdoc />
    public partial class changeUserIdOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("09595ab6-c4af-4223-812c-6d74f2767997"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 9, 9, 51, 13, 222, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2352a676-800c-4e14-8ee7-1ca1fd32280c"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 9, 9, 51, 13, 222, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 9, 9, 51, 13, 222, DateTimeKind.Utc).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e9c8d216-5c64-4f78-8487-41dc0a29c77e"),
                column: "CreatedOn",
                value: new DateTime(2025, 4, 9, 9, 51, 13, 222, DateTimeKind.Utc).AddTicks(5383));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
