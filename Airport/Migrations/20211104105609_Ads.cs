using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Airport.Migrations
{
    public partial class Ads : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Login = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblFlights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    DepartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ArrivDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DepartCity = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ArrivCity = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblFlights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblAirplanes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Model = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Type = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    NumberPass = table.Column<int>(type: "integer", nullable: false),
                    Country = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    FlightsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAirplanes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblAirplanes_tblFlights_FlightsId",
                        column: x => x.FlightsId,
                        principalTable: "tblFlights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblClients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Gender = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    AccountsId = table.Column<int>(type: "integer", nullable: false),
                    FlightsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblClients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblClients_tblAccounts_AccountsId",
                        column: x => x.AccountsId,
                        principalTable: "tblAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblClients_tblFlights_FlightsId",
                        column: x => x.FlightsId,
                        principalTable: "tblFlights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblAirplanes_FlightsId",
                table: "tblAirplanes",
                column: "FlightsId");

            migrationBuilder.CreateIndex(
                name: "IX_tblClients_AccountsId",
                table: "tblClients",
                column: "AccountsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblClients_FlightsId",
                table: "tblClients",
                column: "FlightsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblAirplanes");

            migrationBuilder.DropTable(
                name: "tblClients");

            migrationBuilder.DropTable(
                name: "tblAccounts");

            migrationBuilder.DropTable(
                name: "tblFlights");
        }
    }
}
