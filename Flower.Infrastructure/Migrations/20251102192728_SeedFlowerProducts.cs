using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Flower.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedFlowerProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlowerProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowerProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FlowerProducts",
                columns: new[] { "Id", "Category", "Code", "Description", "ImageUrl", "IsAvailable", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "bouquet", "FLR-001", null, null, true, "Pembe Gül Buketi", 850m },
                    { 2, "orchid", "FLR-002", null, null, true, "Beyaz Orkide", 1200m },
                    { 3, "bouquet", "FLR-003", null, null, true, "Kırmızı Güller 11’li", 690m },
                    { 4, "mixed", "FLR-004", null, null, true, "Mevsim Çiçekleri Vazoda", 540m },
                    { 5, "orchid", "FLR-005", null, null, true, "Saksı Orkide Çift Dal", 1450m },
                    { 6, "terrarium", "FLR-006", null, null, true, "Teraryum Küçük Dünya", 820m },
                    { 7, "ceremony", "FLR-007", null, null, true, "Söz – Nişan Masası Çiçeği", 1950m },
                    { 8, "birthday", "FLR-008", null, null, true, "Doğum Günü Pembe Aranjman", 780m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlowerProducts");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
