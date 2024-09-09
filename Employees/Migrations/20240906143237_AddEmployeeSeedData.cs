using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Employees.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Employee",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Employee",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Employee",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Avatar", "City", "Department", "Email", "FirstName", "LastName", "PostalCode", "Street" },
                values: new object[,]
                {
                    { 1, "https://example.com/avatars/1.png", "Musterstadt", "Sales", "max.muster@example.com", "Max", "Muster", "12345", "Musterstraße 1" },
                    { 2, "https://example.com/avatars/2.png", "Beispielstadt", "Marketing", "erika.mustermann@example.com", "Erika", "Mustermann", "67890", "Beispielweg 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "City",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Employee");
        }
    }
}
