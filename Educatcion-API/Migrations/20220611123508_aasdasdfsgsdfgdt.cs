using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Educatcion_API.Migrations
{
    public partial class aasdasdfsgsdfgdt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryNameId",
                table: "Classes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryNameId",
                table: "Classes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
