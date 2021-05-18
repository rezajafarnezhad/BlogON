using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogON.Infra.EFcore.Migrations
{
    public partial class Add_FrameWork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "Articles",
                newName: "dateTime");

            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "ArticleCategories",
                newName: "dateTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "dateTime",
                table: "Articles",
                newName: "CreationDate");

            migrationBuilder.RenameColumn(
                name: "dateTime",
                table: "ArticleCategories",
                newName: "CreationDate");
        }
    }
}
