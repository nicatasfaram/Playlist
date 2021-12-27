using Microsoft.EntityFrameworkCore.Migrations;

namespace Playlist.Data.Migrations
{
    public partial class playlistUpdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlaylistId",
                table: "musics",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_musics_PlaylistId",
                table: "musics",
                column: "PlaylistId");

            migrationBuilder.AddForeignKey(
                name: "FK_musics_playlists_PlaylistId",
                table: "musics",
                column: "PlaylistId",
                principalTable: "playlists",
                principalColumn: "PlaylistId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_musics_playlists_PlaylistId",
                table: "musics");

            migrationBuilder.DropIndex(
                name: "IX_musics_PlaylistId",
                table: "musics");

            migrationBuilder.DropColumn(
                name: "PlaylistId",
                table: "musics");
        }
    }
}
