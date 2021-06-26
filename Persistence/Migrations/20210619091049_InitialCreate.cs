using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FundRaisers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TargetAmount = table.Column<decimal>(type: "TEXT", nullable: false),
                    CurrentAmount = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundRaisers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contributor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FundraiserID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Mobile = table.Column<string>(type: "TEXT", nullable: true),
                    Donation = table.Column<decimal>(type: "TEXT", nullable: false),
                    DateOfDonation = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contributor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contributor_FundRaisers_FundraiserID",
                        column: x => x.FundraiserID,
                        principalTable: "FundRaisers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contributor_FundraiserID",
                table: "Contributor",
                column: "FundraiserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contributor");

            migrationBuilder.DropTable(
                name: "FundRaisers");
        }
    }
}
