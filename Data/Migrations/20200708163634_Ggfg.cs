using Microsoft.EntityFrameworkCore.Migrations;

namespace Space.Data.Migrations
{
    public partial class Ggfg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c39ebb1d-c7e7-4fc3-81dd-93591ab3f660");

            migrationBuilder.DropColumn(
                name: "Trip",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "PickTrip",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "73d1ff73-d12c-4aa1-a05e-1b5713e8e487", "31ac6099-71f9-4358-bd0e-9a8e19492f6b", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73d1ff73-d12c-4aa1-a05e-1b5713e8e487");

            migrationBuilder.DropColumn(
                name: "PickTrip",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Trip",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c39ebb1d-c7e7-4fc3-81dd-93591ab3f660", "23db54cc-082e-404a-9855-4a9efb5629f0", "Customer", "CUSTOMER" });
        }
    }
}
