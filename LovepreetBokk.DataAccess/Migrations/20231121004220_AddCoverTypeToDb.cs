using Microsoft.EntityFrameworkCore.Migrations;

namespace LovepreetBook.DataAccess.Migrations
{
    public partial class AddCoverTypeToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Covertypes",
                table: "Covertypes");

            migrationBuilder.RenameTable(
                name: "Covertypes",
                newName: "CoverTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoverTypes",
                table: "CoverTypes",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CoverTypes",
                table: "CoverTypes");

            migrationBuilder.RenameTable(
                name: "CoverTypes",
                newName: "Covertypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Covertypes",
                table: "Covertypes",
                column: "Id");
        }
    }
}
