using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flower.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrlToFlowerProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FlowerProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1519681393784-d120267933ba?q=80&w=1200");

            migrationBuilder.UpdateData(
                table: "FlowerProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1519681393784-d120267933ba?q=80&w=1200");

            migrationBuilder.UpdateData(
                table: "FlowerProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1519681393784-d120267933ba?q=80&w=1200");

            migrationBuilder.UpdateData(
                table: "FlowerProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1519681393784-d120267933ba?q=80&w=1200");

            migrationBuilder.UpdateData(
                table: "FlowerProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1519681393784-d120267933ba?q=80&w=1200");

            migrationBuilder.UpdateData(
                table: "FlowerProducts",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1519681393784-d120267933ba?q=80&w=1200");

            migrationBuilder.UpdateData(
                table: "FlowerProducts",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1519681393784-d120267933ba?q=80&w=1200");

            migrationBuilder.UpdateData(
                table: "FlowerProducts",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1519681393784-d120267933ba?q=80&w=1200");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FlowerProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "FlowerProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "FlowerProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "FlowerProducts",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "FlowerProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "FlowerProducts",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "FlowerProducts",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "FlowerProducts",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: null);
        }
    }
}
