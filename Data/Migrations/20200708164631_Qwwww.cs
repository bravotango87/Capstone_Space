using Microsoft.EntityFrameworkCore.Migrations;

namespace Space.Data.Migrations
{
    public partial class Qwwww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "701548b8-4a05-4475-870b-e409e8c4f795");

            migrationBuilder.DropColumn(
                name: "PickTrip",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Trip",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e2501c8-61e3-4823-92af-b42d8a401f97", "efc056d1-adad-408e-89dd-f499631315f8", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e2501c8-61e3-4823-92af-b42d8a401f97");

            migrationBuilder.DropColumn(
                name: "Trip",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "PickTrip",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "701548b8-4a05-4475-870b-e409e8c4f795", "29e643fc-8938-426d-997a-d40805a94b47", "Customer", "CUSTOMER" });
        }
    }
}
