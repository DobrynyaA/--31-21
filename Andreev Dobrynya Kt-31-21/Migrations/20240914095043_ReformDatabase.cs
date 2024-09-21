using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Andreev_Dobrynya_Kt_31_21.Migrations
{
    /// <inheritdoc />
    public partial class ReformDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cd_student_Groups_GroupId",
                table: "cd_student");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Subjects_SubjectId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_cd_student_StudentId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Subjects_SubjectId",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_cd_student_StudentId",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cd_student",
                table: "cd_student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tests",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exams",
                table: "Exams");

            migrationBuilder.RenameTable(
                name: "Tests",
                newName: "cd_tests");

            migrationBuilder.RenameTable(
                name: "Subjects",
                newName: "cd_subject");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "cd_groups");

            migrationBuilder.RenameTable(
                name: "Exams",
                newName: "cd_exams");

            migrationBuilder.RenameColumn(
                name: "middle_name",
                table: "cd_student",
                newName: "c_middle_name");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "cd_student",
                newName: "c_last_name");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "cd_student",
                newName: "c_first_name");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "cd_student",
                newName: "group_id");

            migrationBuilder.RenameColumn(
                name: "isPassed",
                table: "cd_tests",
                newName: "b_is_passed");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "cd_tests",
                newName: "subject_id");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "cd_tests",
                newName: "student_id");

            migrationBuilder.RenameColumn(
                name: "TestId",
                table: "cd_tests",
                newName: "test_id");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_SubjectId",
                table: "cd_tests",
                newName: "IX_cd_tests_subject_id");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_StudentId",
                table: "cd_tests",
                newName: "IX_cd_tests_student_id");

            migrationBuilder.RenameColumn(
                name: "Speciality",
                table: "cd_groups",
                newName: "c_speciality");

            migrationBuilder.RenameColumn(
                name: "GroupName",
                table: "cd_groups",
                newName: "c_group_name");

            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "cd_groups",
                newName: "d_creation_date");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "cd_groups",
                newName: "group_id");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "cd_exams",
                newName: "subject_id");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "cd_exams",
                newName: "student_id");

            migrationBuilder.RenameColumn(
                name: "Mark",
                table: "cd_exams",
                newName: "n_mark_id");

            migrationBuilder.RenameColumn(
                name: "ExamDate",
                table: "cd_exams",
                newName: "d_exam_date");

            migrationBuilder.RenameColumn(
                name: "ExamId",
                table: "cd_exams",
                newName: "exam_id");

            migrationBuilder.RenameIndex(
                name: "IX_Exams_SubjectId",
                table: "cd_exams",
                newName: "IX_cd_exams_subject_id");

            migrationBuilder.RenameIndex(
                name: "IX_Exams_StudentId",
                table: "cd_exams",
                newName: "IX_cd_exams_student_id");

            migrationBuilder.AlterColumn<string>(
                name: "c_middle_name",
                table: "cd_student",
                type: "varchar",
                maxLength: 50,
                nullable: false,
                comment: "Фамилия Студента",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "c_last_name",
                table: "cd_student",
                type: "varchar",
                maxLength: 50,
                nullable: false,
                comment: "Отчество студента",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "c_first_name",
                table: "cd_student",
                type: "varchar",
                maxLength: 50,
                nullable: false,
                comment: "Имя студента",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "group_id",
                table: "cd_student",
                type: "int4",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<bool>(
                name: "b_is_passed",
                table: "cd_tests",
                type: "bool",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "SubjectName",
                table: "cd_subject",
                type: "varchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "c_speciality",
                table: "cd_groups",
                type: "varchar",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "c_group_name",
                table: "cd_groups",
                type: "varchar",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "d_creation_date",
                table: "cd_groups",
                type: "timestamp",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "group_id",
                table: "cd_groups",
                type: "int4",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "subject_id",
                table: "cd_exams",
                type: "int4",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "student_id",
                table: "cd_exams",
                type: "int4",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "n_mark_id",
                table: "cd_exams",
                type: "int4",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "d_exam_date",
                table: "cd_exams",
                type: "timestamp",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "exam_id",
                table: "cd_exams",
                type: "int4",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "pk_cd_student_student_id",
                table: "cd_student",
                column: "student_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_cd_tests_test_id",
                table: "cd_tests",
                column: "test_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_cd_subject_subject_id",
                table: "cd_subject",
                column: "SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "pk_cd_groups_group_id",
                table: "cd_groups",
                column: "group_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_cd_exams_exam_id",
                table: "cd_exams",
                column: "exam_id");

            migrationBuilder.CreateIndex(
                name: "idx_cd_tests_fk_b_is_passed",
                table: "cd_tests",
                column: "b_is_passed");

            migrationBuilder.CreateIndex(
                name: "idx_cd_subject_fk_c_subject_id",
                table: "cd_subject",
                column: "SubjectName");

            migrationBuilder.CreateIndex(
                name: "idx_cd_groups_fk_c_speciality",
                table: "cd_groups",
                column: "c_speciality");

            migrationBuilder.CreateIndex(
                name: "idx_cd_groups_fk_d_creation_date",
                table: "cd_groups",
                column: "d_creation_date");

            migrationBuilder.CreateIndex(
                name: "idx_cd_exams_fk_f_group_id",
                table: "cd_exams",
                column: "n_mark_id");

            migrationBuilder.AddForeignKey(
                name: "FK_cd_exams_cd_student_student_id",
                table: "cd_exams",
                column: "student_id",
                principalTable: "cd_student",
                principalColumn: "student_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cd_exams_cd_subject_subject_id",
                table: "cd_exams",
                column: "subject_id",
                principalTable: "cd_subject",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_cd_student_cd_groups_group_id",
                table: "cd_student",
                column: "group_id",
                principalTable: "cd_groups",
                principalColumn: "group_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cd_tests_cd_student_student_id",
                table: "cd_tests",
                column: "student_id",
                principalTable: "cd_student",
                principalColumn: "student_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cd_tests_cd_subject_subject_id",
                table: "cd_tests",
                column: "subject_id",
                principalTable: "cd_subject",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cd_exams_cd_student_student_id",
                table: "cd_exams");

            migrationBuilder.DropForeignKey(
                name: "FK_cd_exams_cd_subject_subject_id",
                table: "cd_exams");

            migrationBuilder.DropForeignKey(
                name: "FK_cd_student_cd_groups_group_id",
                table: "cd_student");

            migrationBuilder.DropForeignKey(
                name: "FK_cd_tests_cd_student_student_id",
                table: "cd_tests");

            migrationBuilder.DropForeignKey(
                name: "FK_cd_tests_cd_subject_subject_id",
                table: "cd_tests");

            migrationBuilder.DropPrimaryKey(
                name: "pk_cd_student_student_id",
                table: "cd_student");

            migrationBuilder.DropPrimaryKey(
                name: "pk_cd_tests_test_id",
                table: "cd_tests");

            migrationBuilder.DropIndex(
                name: "idx_cd_tests_fk_b_is_passed",
                table: "cd_tests");

            migrationBuilder.DropPrimaryKey(
                name: "pk_cd_subject_subject_id",
                table: "cd_subject");

            migrationBuilder.DropIndex(
                name: "idx_cd_subject_fk_c_subject_id",
                table: "cd_subject");

            migrationBuilder.DropPrimaryKey(
                name: "pk_cd_groups_group_id",
                table: "cd_groups");

            migrationBuilder.DropIndex(
                name: "idx_cd_groups_fk_c_speciality",
                table: "cd_groups");

            migrationBuilder.DropIndex(
                name: "idx_cd_groups_fk_d_creation_date",
                table: "cd_groups");

            migrationBuilder.DropPrimaryKey(
                name: "pk_cd_exams_exam_id",
                table: "cd_exams");

            migrationBuilder.DropIndex(
                name: "idx_cd_exams_fk_f_group_id",
                table: "cd_exams");

            migrationBuilder.RenameTable(
                name: "cd_tests",
                newName: "Tests");

            migrationBuilder.RenameTable(
                name: "cd_subject",
                newName: "Subjects");

            migrationBuilder.RenameTable(
                name: "cd_groups",
                newName: "Groups");

            migrationBuilder.RenameTable(
                name: "cd_exams",
                newName: "Exams");

            migrationBuilder.RenameColumn(
                name: "group_id",
                table: "cd_student",
                newName: "GroupId");

            migrationBuilder.RenameColumn(
                name: "c_middle_name",
                table: "cd_student",
                newName: "middle_name");

            migrationBuilder.RenameColumn(
                name: "c_last_name",
                table: "cd_student",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "c_first_name",
                table: "cd_student",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "subject_id",
                table: "Tests",
                newName: "SubjectId");

            migrationBuilder.RenameColumn(
                name: "student_id",
                table: "Tests",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "b_is_passed",
                table: "Tests",
                newName: "isPassed");

            migrationBuilder.RenameColumn(
                name: "test_id",
                table: "Tests",
                newName: "TestId");

            migrationBuilder.RenameIndex(
                name: "IX_cd_tests_subject_id",
                table: "Tests",
                newName: "IX_Tests_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_cd_tests_student_id",
                table: "Tests",
                newName: "IX_Tests_StudentId");

            migrationBuilder.RenameColumn(
                name: "d_creation_date",
                table: "Groups",
                newName: "CreationDate");

            migrationBuilder.RenameColumn(
                name: "c_speciality",
                table: "Groups",
                newName: "Speciality");

            migrationBuilder.RenameColumn(
                name: "c_group_name",
                table: "Groups",
                newName: "GroupName");

            migrationBuilder.RenameColumn(
                name: "group_id",
                table: "Groups",
                newName: "GroupId");

            migrationBuilder.RenameColumn(
                name: "subject_id",
                table: "Exams",
                newName: "SubjectId");

            migrationBuilder.RenameColumn(
                name: "student_id",
                table: "Exams",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "n_mark_id",
                table: "Exams",
                newName: "Mark");

            migrationBuilder.RenameColumn(
                name: "d_exam_date",
                table: "Exams",
                newName: "ExamDate");

            migrationBuilder.RenameColumn(
                name: "exam_id",
                table: "Exams",
                newName: "ExamId");

            migrationBuilder.RenameIndex(
                name: "IX_cd_exams_subject_id",
                table: "Exams",
                newName: "IX_Exams_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_cd_exams_student_id",
                table: "Exams",
                newName: "IX_Exams_StudentId");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "cd_student",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int4");

            migrationBuilder.AlterColumn<string>(
                name: "middle_name",
                table: "cd_student",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 50,
                oldComment: "Фамилия Студента");

            migrationBuilder.AlterColumn<string>(
                name: "last_name",
                table: "cd_student",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 50,
                oldComment: "Отчество студента");

            migrationBuilder.AlterColumn<string>(
                name: "first_name",
                table: "cd_student",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 50,
                oldComment: "Имя студента");

            migrationBuilder.AlterColumn<bool>(
                name: "isPassed",
                table: "Tests",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bool");

            migrationBuilder.AlterColumn<string>(
                name: "SubjectName",
                table: "Subjects",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CreationDate",
                table: "Groups",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp");

            migrationBuilder.AlterColumn<string>(
                name: "Speciality",
                table: "Groups",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "GroupName",
                table: "Groups",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "Groups",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int4")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Exams",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int4");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Exams",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int4");

            migrationBuilder.AlterColumn<int>(
                name: "Mark",
                table: "Exams",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExamDate",
                table: "Exams",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp");

            migrationBuilder.AlterColumn<int>(
                name: "ExamId",
                table: "Exams",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int4")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_cd_student",
                table: "cd_student",
                column: "student_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tests",
                table: "Tests",
                column: "TestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects",
                column: "SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exams",
                table: "Exams",
                column: "ExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_cd_student_Groups_GroupId",
                table: "cd_student",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Subjects_SubjectId",
                table: "Exams",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_cd_student_StudentId",
                table: "Exams",
                column: "StudentId",
                principalTable: "cd_student",
                principalColumn: "student_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Subjects_SubjectId",
                table: "Tests",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_cd_student_StudentId",
                table: "Tests",
                column: "StudentId",
                principalTable: "cd_student",
                principalColumn: "student_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
