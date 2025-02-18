using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArabDev.Data.Migrations
{
    /// <inheritdoc />
    public partial class HandleUserOnFolloweer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Followers_Users_FollowedUserId",
                table: "Followers");

            migrationBuilder.DropForeignKey(
                name: "FK_Followers_Users_FollowerUserId",
                table: "Followers");

            migrationBuilder.AddForeignKey(
                name: "FK_Followers_Users_FollowedUserId",
                table: "Followers",
                column: "FollowedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Followers_Users_FollowedUserId",
                table: "Followers");

            migrationBuilder.AddForeignKey(
                name: "FK_Followers_Users_FollowedUserId",
                table: "Followers",
                column: "FollowedUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Followers_Users_FollowerUserId",
                table: "Followers",
                column: "FollowerUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
