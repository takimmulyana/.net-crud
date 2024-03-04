using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodStore.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedJeniss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Jeniss",
                columns: new[] { "Id", "Nama" },
                values: new object[,]
                {
                    { 1, "Sayuran" },
                    { 2, "Buah" },
                    { 3, "Meal" },
                    { 4, "Meat" },
                    { 5, "Fish" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jeniss",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jeniss",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jeniss",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Jeniss",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Jeniss",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
