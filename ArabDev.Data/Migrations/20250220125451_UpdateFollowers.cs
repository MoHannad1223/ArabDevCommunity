using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArabDev.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFollowers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Followers_Users_FollowedUserId",
                table: "Followers");

            migrationBuilder.DropForeignKey(
                name: "FK_Followers_Users_UserId",
                table: "Followers");

            migrationBuilder.DropIndex(
                name: "IX_Followers_UserId",
                table: "Followers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Followers");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Followers_Users_FollowedUserId",
                table: "Followers");

            migrationBuilder.DropForeignKey(
                name: "FK_Followers_Users_FollowerUserId",
                table: "Followers");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Posts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Followers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Followers_UserId",
                table: "Followers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Followers_Users_FollowedUserId",
                table: "Followers",
                column: "FollowedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Followers_Users_UserId",
                table: "Followers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
