using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Educatcion_API.Migrations
{
    public partial class newname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Categorys_CategoryId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.RenameTable(
                name: "Vehicles",
                newName: "Classes");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_CategoryId",
                table: "Classes",
                newName: "IX_Classes_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Classes",
                table: "Classes",
                column: "Id");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Classes",
                table: "Classes");

            migrationBuilder.RenameTable(
                name: "Classes",
                newName: "Vehicles");

            migrationBuilder.RenameIndex(
                name: "IX_Classes_CategoryId",
                table: "Vehicles",
                newName: "IX_Vehicles_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Categorys_CategoryId",
                table: "Vehicles",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
