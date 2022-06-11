using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Educatcion_API.Migrations
{
    public partial class anant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryTeacher");

            migrationBuilder.DropColumn(
                name: "ExperienceId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Categorys");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExperienceId",
                table: "Teachers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Categorys",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CategoryTeacher",
                columns: table => new
                {
                    ExperienceId = table.Column<int>(type: "INTEGER", nullable: false),
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTeacher", x => new { x.ExperienceId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_CategoryTeacher_Categorys_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Categorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryTeacher_Teachers_ExperienceId",
                        column: x => x.ExperienceId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTeacher_TeacherId",
                table: "CategoryTeacher",
                column: "TeacherId");
        }
    }
}
