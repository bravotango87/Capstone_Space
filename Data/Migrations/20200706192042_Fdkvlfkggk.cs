using Microsoft.EntityFrameworkCore.Migrations;

namespace Space.Data.Migrations
{
    public partial class Fdkvlfkggk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3f1c7b0-7f78-490f-9163-3846090922eb");

            migrationBuilder.DropColumn(
                name: "DayOne",
                table: "Itineraries");

            migrationBuilder.AddColumn<string>(
                name: "Arrival",
                table: "Itineraries",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6bb49b48-5a77-4747-a0ad-299bf103438b", "1cd176c7-8980-4986-b0c9-a3065b731ace", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bb49b48-5a77-4747-a0ad-299bf103438b");

            migrationBuilder.DropColumn(
                name: "Arrival",
                table: "Itineraries");

            migrationBuilder.AddColumn<string>(
                name: "DayOne",
                table: "Itineraries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3f1c7b0-7f78-490f-9163-3846090922eb", "07cafd29-cd00-4e30-bc33-19ebeaefbda6", "Customer", "CUSTOMER" });
        }
    }
}
