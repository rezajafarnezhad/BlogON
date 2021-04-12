using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogON.Infra.EFcore.Migrations
{
    public partial class UpdateMappingArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(170)",
                maxLength: 170,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Articles",
                type: "nvarchar(600)",
                maxLength: 600,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(190)",
                oldMaxLength: 190);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(170)",
                oldMaxLength: 170);

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Articles",
                type: "nvarchar(190)",
                maxLength: 190,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(600)",
                oldMaxLength: 600);
        }
    }
}
