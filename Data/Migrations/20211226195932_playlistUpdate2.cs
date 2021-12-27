using Microsoft.EntityFrameworkCore.Migrations;

namespace Playlist.Data.Migrations
{
    public partial class playlistUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_playlists_AspNetUsers_userId",
                table: "playlists");

            migrationBuilder.DropIndex(
                name: "IX_playlists_userId",
                table: "playlists");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "playlists");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "playlists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "playlists",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_playlists_userId",
                table: "playlists",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_playlists_AspNetUsers_userId",
                table: "playlists",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
