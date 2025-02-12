using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArabDev.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditSomeFaultDataType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LearningName",
                table: "User_Learnings");

            migrationBuilder.RenameColumn(
                name: "Img",
                table: "Posts",
                newName: "Image");

            migrationBuilder.AddColumn<string>(
                name: "LearningNames",
                table: "User_Learnings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AlterColumn<string>(
                name: "SkillName",
                table: "Skills",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 25);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LearningNames",
                table: "User_Learnings");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Posts",
                newName: "Img");

            migrationBuilder.AddColumn<int>(
                name: "LearningName",
                table: "User_Learnings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "SkillName",
                table: "Skills",
                type: "int",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);
        }
    }
}
