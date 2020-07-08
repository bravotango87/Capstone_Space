using Microsoft.EntityFrameworkCore.Migrations;

namespace Space.Data.Migrations
{
    public partial class Awewewe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73d1ff73-d12c-4aa1-a05e-1b5713e8e487");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "701548b8-4a05-4475-870b-e409e8c4f795", "29e643fc-8938-426d-997a-d40805a94b47", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "701548b8-4a05-4475-870b-e409e8c4f795");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "73d1ff73-d12c-4aa1-a05e-1b5713e8e487", "31ac6099-71f9-4358-bd0e-9a8e19492f6b", "Customer", "CUSTOMER" });
        }
    }
}
