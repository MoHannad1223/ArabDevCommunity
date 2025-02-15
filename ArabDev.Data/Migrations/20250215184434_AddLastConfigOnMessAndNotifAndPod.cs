using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArabDev.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddLastConfigOnMessAndNotifAndPod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages");

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "User_Learnings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Notifications",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostId1",
                table: "Notifications",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Notifications",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Messages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PodCastId",
                table: "Likes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PodCastId1",
                table: "Likes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PodCastId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PodCastId1",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Learnings_UserId1",
                table: "User_Learnings",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_PostId",
                table: "Notifications",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_PostId1",
                table: "Notifications",
                column: "PostId1");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId1",
                table: "Notifications",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_PodCastId",
                table: "Likes",
                column: "PodCastId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_PodCastId1",
                table: "Likes",
                column: "PodCastId1");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PodCastId",
                table: "Comments",
                column: "PodCastId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PodCastId1",
                table: "Comments",
                column: "PodCastId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_PodCasts_PodCastId",
                table: "Comments",
                column: "PodCastId",
                principalTable: "PodCasts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_PodCasts_PodCastId1",
                table: "Comments",
                column: "PodCastId1",
                principalTable: "PodCasts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_PodCasts_PodCastId",
                table: "Likes",
                column: "PodCastId",
                principalTable: "PodCasts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_PodCasts_PodCastId1",
                table: "Likes",
                column: "PodCastId1",
                principalTable: "PodCasts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_ReceiverId",
                table: "Messages",
                column: "ReceiverId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Posts_PostId",
                table: "Notifications",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Posts_PostId1",
                table: "Notifications",
                column: "PostId1",
                principalTable: "Posts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Users_UserId1",
                table: "Notifications",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Learnings_Users_UserId1",
                table: "User_Learnings",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_PodCasts_PodCastId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_PodCasts_PodCastId1",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_PodCasts_PodCastId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_PodCasts_PodCastId1",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_ReceiverId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Posts_PostId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Posts_PostId1",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Users_UserId1",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Learnings_Users_UserId1",
                table: "User_Learnings");

            migrationBuilder.DropIndex(
                name: "IX_User_Learnings_UserId1",
                table: "User_Learnings");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_PostId",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_PostId1",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_UserId1",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Likes_PodCastId",
                table: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Likes_PodCastId1",
                table: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PodCastId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PodCastId1",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "User_Learnings");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "PostId1",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "PodCastId",
                table: "Likes");

            migrationBuilder.DropColumn(
                name: "PodCastId1",
                table: "Likes");

            migrationBuilder.DropColumn(
                name: "PodCastId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "PodCastId1",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Messages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
