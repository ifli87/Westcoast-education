using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Educatcion_API.Migrations
{
    public partial class aasdasdt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassesId",
                table: "Classes",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassesId",
                table: "Categorys",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_ClassesId",
                table: "Classes",
                column: "ClassesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Categorys_ClassesId",
                table: "Classes",
                column: "ClassesId",
                principalTable: "Categorys",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Categorys_ClassesId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_ClassesId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ClassesId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ClassesId",
                table: "Categorys");
        }
    }
}
