using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoWebsite.Data.Migrations
{
    public partial class UpdateCMSEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CMSs",
                table: "CMSs");

            migrationBuilder.DropColumn(
                name: "CMSId",
                table: "CMSs");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "CMSs",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "CMSs",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(1000)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CMSs",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CMSs",
                table: "CMSs",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CMSs",
                table: "CMSs");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CMSs");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "CMSs",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "CMSs",
                type: "varchar(1000)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CMSId",
                table: "CMSs",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CMSs",
                table: "CMSs",
                column: "CMSId");
        }
    }
}
