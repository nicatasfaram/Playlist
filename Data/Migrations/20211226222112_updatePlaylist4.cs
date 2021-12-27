using Microsoft.EntityFrameworkCore.Migrations;

namespace Playlist.Data.Migrations
{
    public partial class updatePlaylist4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_musics_playlists_PlaylistId",
                table: "musics");

            migrationBuilder.DropTable(
                name: "playlists");

            migrationBuilder.DropIndex(
                name: "IX_musics_PlaylistId",
                table: "musics");

            migrationBuilder.DropColumn(
                name: "PlaylistId",
                table: "musics");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlaylistId",
                table: "musics",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "playlists",
                columns: table => new
                {
                    PlaylistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_playlists", x => x.PlaylistId);
                });

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
    }
}
