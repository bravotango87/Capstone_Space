using Microsoft.EntityFrameworkCore.Migrations;

namespace Space.Data.Migrations
{
    public partial class Ititn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aea51871-a4de-4e43-91c7-a1a8bc4e8e6d");

            migrationBuilder.CreateTable(
                name: "Itineraries",
                columns: table => new
                {
                    ItineraryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(nullable: true),
                    ThreeWeeksPrior = table.Column<string>(nullable: true),
                    DayOfLaunch = table.Column<string>(nullable: true),
                    Depature = table.Column<int>(nullable: false),
                    RequiredForms = table.Column<string>(nullable: true),
                    DayOne = table.Column<string>(nullable: true),
                    WhatToDo = table.Column<string>(nullable: true),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itineraries", x => x.ItineraryId);
                    table.ForeignKey(
                        name: "FK_Itineraries_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "02f79b68-195c-4019-bf96-c56f9bc7f011", "f9b6bda4-f34d-4d1b-9f46-8f49da2917dc", "Customer", "CUSTOMER" });

            migrationBuilder.CreateIndex(
                name: "IX_Itineraries_IdentityUserId",
                table: "Itineraries",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Itineraries");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02f79b68-195c-4019-bf96-c56f9bc7f011");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aea51871-a4de-4e43-91c7-a1a8bc4e8e6d", "d50c75fc-0ef0-4f94-9150-aee52d773f22", "Customer", "CUSTOMER" });
        }
    }
}
