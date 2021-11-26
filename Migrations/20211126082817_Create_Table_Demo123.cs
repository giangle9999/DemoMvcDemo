using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Migrations
{
    public partial class Create_Table_Demo123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Demo123s",
                columns: table => new
                {
                    Demo123ID = table.Column<string>(type: "TEXT", nullable: false),
                    Demo123Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demo123s", x => x.Demo123ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Demo123s");
        }
    }
}
