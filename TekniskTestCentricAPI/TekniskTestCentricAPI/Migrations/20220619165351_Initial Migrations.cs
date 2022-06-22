using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TekniskTestCentricAPI.Migrations
{
    public partial class InitialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Continent_Country_CountryId",
                table: "Continent");

            migrationBuilder.DropIndex(
                name: "IX_Continent_CountryId",
                table: "Continent");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Continent");

            migrationBuilder.AddColumn<Guid>(
                name: "ContinentId",
                table: "Country",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Country_ContinentId",
                table: "Country",
                column: "ContinentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Country_Continent_ContinentId",
                table: "Country",
                column: "ContinentId",
                principalTable: "Continent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Country_Continent_ContinentId",
                table: "Country");

            migrationBuilder.DropIndex(
                name: "IX_Country_ContinentId",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "ContinentId",
                table: "Country");

            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "Continent",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Continent_CountryId",
                table: "Continent",
                column: "CountryId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Continent_Country_CountryId",
                table: "Continent",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
