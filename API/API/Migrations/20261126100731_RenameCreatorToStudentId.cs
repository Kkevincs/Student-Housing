using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class RenameCreatorToStudentId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chores_Students_CreatorId",
                table: "Chores");

            migrationBuilder.RenameColumn(
                name: "CreatorId",
                table: "Chores",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Chores_CreatorId",
                table: "Chores",
                newName: "IX_Chores_StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chores_Students_StudentId",
                table: "Chores",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chores_Students_StudentId",
                table: "Chores");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Chores",
                newName: "CreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Chores_StudentId",
                table: "Chores",
                newName: "IX_Chores_CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chores_Students_CreatorId",
                table: "Chores",
                column: "CreatorId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
