using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoWebsite.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CMSs",
                columns: table => new
                {
                    CMSId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Content = table.Column<string>(type: "varchar(1000)", nullable: true),
                    Slug = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMSs", x => x.CMSId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CMSs");
        }
    }
}
