using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Andreev_Dobrynya_Kt_31_21.Migrations
{
    /// <inheritdoc />
    public partial class AddHasKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Students_StudentId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Students_StudentId",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "cd_student");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GroupId",
                table: "cd_student",
                newName: "idx_cd_student_fk_f_group_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cd_student",
                table: "cd_student",
                column: "student_id");

            migrationBuilder.AddForeignKey(
                name: "FK_cd_student_Groups_GroupId",
                table: "cd_student",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_cd_student_StudentId",
                table: "Exams",
                column: "StudentId",
                principalTable: "cd_student",
                principalColumn: "student_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_cd_student_StudentId",
                table: "Tests",
                column: "StudentId",
                principalTable: "cd_student",
                principalColumn: "student_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cd_student_Groups_GroupId",
                table: "cd_student");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_cd_student_StudentId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_cd_student_StudentId",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cd_student",
                table: "cd_student");

            migrationBuilder.RenameTable(
                name: "cd_student",
                newName: "Students");

            migrationBuilder.RenameIndex(
                name: "idx_cd_student_fk_f_group_id",
                table: "Students",
                newName: "IX_Students_GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "student_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Students_StudentId",
                table: "Exams",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "student_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Students_StudentId",
                table: "Tests",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "student_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
