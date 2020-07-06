using Microsoft.EntityFrameworkCore.Migrations;

namespace Space.Data.Migrations
{
    public partial class Tghjk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02f79b68-195c-4019-bf96-c56f9bc7f011");

            migrationBuilder.AddColumn<string>(
                name: "FlyingBack",
                table: "Itineraries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhatToBring",
                table: "Itineraries",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3f1c7b0-7f78-490f-9163-3846090922eb", "07cafd29-cd00-4e30-bc33-19ebeaefbda6", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3f1c7b0-7f78-490f-9163-3846090922eb");

            migrationBuilder.DropColumn(
                name: "FlyingBack",
                table: "Itineraries");

            migrationBuilder.DropColumn(
                name: "WhatToBring",
                table: "Itineraries");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "02f79b68-195c-4019-bf96-c56f9bc7f011", "f9b6bda4-f34d-4d1b-9f46-8f49da2917dc", "Customer", "CUSTOMER" });
        }
    }
}
