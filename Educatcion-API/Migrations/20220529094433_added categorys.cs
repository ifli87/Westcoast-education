using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Educatcion_API.Migrations
{
    public partial class addedcategorys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Categorys_CategoryId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Classes");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Classes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Categorys_CategoryId",
                table: "Classes",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Categorys_CategoryId",
                table: "Classes");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Classes",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Classes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Categorys_CategoryId",
                table: "Classes",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "Id");
        }
    }
}
