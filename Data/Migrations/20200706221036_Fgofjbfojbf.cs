using Microsoft.EntityFrameworkCore.Migrations;

namespace Space.Data.Migrations
{
    public partial class Fgofjbfojbf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bb49b48-5a77-4747-a0ad-299bf103438b");

            migrationBuilder.AlterColumn<string>(
                name: "Depature",
                table: "Itineraries",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bdf3c66c-77d4-45e5-bd35-793de1400aa1", "b466ba08-0203-4aae-a5f4-8d3f5cee8a8c", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bdf3c66c-77d4-45e5-bd35-793de1400aa1");

            migrationBuilder.AlterColumn<int>(
                name: "Depature",
                table: "Itineraries",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6bb49b48-5a77-4747-a0ad-299bf103438b", "1cd176c7-8980-4986-b0c9-a3065b731ace", "Customer", "CUSTOMER" });
        }
    }
}
