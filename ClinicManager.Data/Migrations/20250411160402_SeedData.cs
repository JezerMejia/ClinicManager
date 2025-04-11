using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Discriminator", "Email", "FirstName", "Identifier", "LastName", "Password", "Phone", "Sex" },
                values: new object[,]
                {
                    { 1, "Medic", "juan.perez@gmail.com", "Juan", "0010101010001A", "Pérez", "Usuario123.", "81211855", 1 },
                    { 2, "Medic", "maria.hernandez@gmail.com", "María", "0010101010001B", "Hernández", "Usuario123.", "12121212", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
