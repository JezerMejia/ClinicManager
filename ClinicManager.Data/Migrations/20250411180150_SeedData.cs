using System;
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
                table: "Specialties",
                columns: new[] { "Name", "Description" },
                values: new object[,]
                {
                    { "derma", "Dermatología" },
                    { "general", "Médico General" },
                    { "odonto", "Odontología" },
                    { "oftalmo", "Oftalmología" },
                    { "pediatria", "Pediatría" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Discriminator", "Email", "FirstName", "Identifier", "LastName", "Password", "Phone", "Sex" },
                values: new object[,]
                {
                    { 1, "Medic", "juan.perez@gmail.com", "Juan", "0010101010001A", "Pérez", "Usuario123.", "12121212", 1 },
                    { 2, "Medic", "maria.hernandez@gmail.com", "María", "0010101010001B", "Hernández", "Usuario123.", "14141414", 0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthday", "Discriminator", "Email", "FirstName", "Identifier", "LastName", "Phone", "Sex" },
                values: new object[] { 3, new DateTime(2003, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patient", "jezer.mejia@gmail.com", "Jezer", "2010511031000Y", "Mejía", "81211855", 1 });

            migrationBuilder.InsertData(
                table: "MedicSpecialty",
                columns: new[] { "MedicsId", "SpecialtiesName" },
                values: new object[,]
                {
                    { 1, "general" },
                    { 1, "odonto" },
                    { 2, "derma" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MedicSpecialty",
                keyColumns: new[] { "MedicsId", "SpecialtiesName" },
                keyValues: new object[] { 1, "general" });

            migrationBuilder.DeleteData(
                table: "MedicSpecialty",
                keyColumns: new[] { "MedicsId", "SpecialtiesName" },
                keyValues: new object[] { 1, "odonto" });

            migrationBuilder.DeleteData(
                table: "MedicSpecialty",
                keyColumns: new[] { "MedicsId", "SpecialtiesName" },
                keyValues: new object[] { 2, "derma" });

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Name",
                keyValue: "oftalmo");

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Name",
                keyValue: "pediatria");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Name",
                keyValue: "derma");

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Name",
                keyValue: "general");

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Name",
                keyValue: "odonto");

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
