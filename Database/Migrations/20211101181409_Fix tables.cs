using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class Fixtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblPlaylists_tblTracks_TrackId",
                table: "tblPlaylists");

            migrationBuilder.DropIndex(
                name: "IX_tblPlaylists_TrackId",
                table: "tblPlaylists");

            migrationBuilder.DropColumn(
                name: "TrackId",
                table: "tblPlaylists");

            migrationBuilder.AddColumn<int>(
                name: "PlaylistId",
                table: "tblTracks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tblTracks_PlaylistId",
                table: "tblTracks",
                column: "PlaylistId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblTracks_tblPlaylists_PlaylistId",
                table: "tblTracks",
                column: "PlaylistId",
                principalTable: "tblPlaylists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblTracks_tblPlaylists_PlaylistId",
                table: "tblTracks");

            migrationBuilder.DropIndex(
                name: "IX_tblTracks_PlaylistId",
                table: "tblTracks");

            migrationBuilder.DropColumn(
                name: "PlaylistId",
                table: "tblTracks");

            migrationBuilder.AddColumn<int>(
                name: "TrackId",
                table: "tblPlaylists",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tblPlaylists_TrackId",
                table: "tblPlaylists",
                column: "TrackId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblPlaylists_tblTracks_TrackId",
                table: "tblPlaylists",
                column: "TrackId",
                principalTable: "tblTracks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
