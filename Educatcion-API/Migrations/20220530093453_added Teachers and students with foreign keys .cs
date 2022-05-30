using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Educatcion_API.Migrations
{
    public partial class addedTeachersandstudentswithforeignkeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassesStudent_Students_StudentId1",
                table: "ClassesStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassesTeacher_Teachers_TeacherId1",
                table: "ClassesTeacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassesTeacher",
                table: "ClassesTeacher");

            migrationBuilder.DropIndex(
                name: "IX_ClassesTeacher_TeacherId1",
                table: "ClassesTeacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassesStudent",
                table: "ClassesStudent");

            migrationBuilder.DropIndex(
                name: "IX_ClassesStudent_StudentId1",
                table: "ClassesStudent");

            migrationBuilder.RenameColumn(
                name: "TeacherId1",
                table: "ClassesTeacher",
                newName: "ClassesId");

            migrationBuilder.RenameColumn(
                name: "StudentId1",
                table: "ClassesStudent",
                newName: "ClassesId");

            migrationBuilder.AddColumn<int>(
                name: "ClassesId",
                table: "Teachers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClassesId",
                table: "Students",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassesTeacher",
                table: "ClassesTeacher",
                columns: new[] { "ClassesId", "TeacherId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassesStudent",
                table: "ClassesStudent",
                columns: new[] { "ClassesId", "StudentId" });

            migrationBuilder.CreateIndex(
                name: "IX_ClassesTeacher_TeacherId",
                table: "ClassesTeacher",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassesStudent_StudentId",
                table: "ClassesStudent",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassesStudent_Students_ClassesId",
                table: "ClassesStudent",
                column: "ClassesId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassesTeacher_Teachers_ClassesId",
                table: "ClassesTeacher",
                column: "ClassesId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassesStudent_Students_ClassesId",
                table: "ClassesStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassesTeacher_Teachers_ClassesId",
                table: "ClassesTeacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassesTeacher",
                table: "ClassesTeacher");

            migrationBuilder.DropIndex(
                name: "IX_ClassesTeacher_TeacherId",
                table: "ClassesTeacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassesStudent",
                table: "ClassesStudent");

            migrationBuilder.DropIndex(
                name: "IX_ClassesStudent_StudentId",
                table: "ClassesStudent");

            migrationBuilder.DropColumn(
                name: "ClassesId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "ClassesId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "ClassesId",
                table: "ClassesTeacher",
                newName: "TeacherId1");

            migrationBuilder.RenameColumn(
                name: "ClassesId",
                table: "ClassesStudent",
                newName: "StudentId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassesTeacher",
                table: "ClassesTeacher",
                columns: new[] { "TeacherId", "TeacherId1" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassesStudent",
                table: "ClassesStudent",
                columns: new[] { "StudentId", "StudentId1" });

            migrationBuilder.CreateIndex(
                name: "IX_ClassesTeacher_TeacherId1",
                table: "ClassesTeacher",
                column: "TeacherId1");

            migrationBuilder.CreateIndex(
                name: "IX_ClassesStudent_StudentId1",
                table: "ClassesStudent",
                column: "StudentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassesStudent_Students_StudentId1",
                table: "ClassesStudent",
                column: "StudentId1",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassesTeacher_Teachers_TeacherId1",
                table: "ClassesTeacher",
                column: "TeacherId1",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
