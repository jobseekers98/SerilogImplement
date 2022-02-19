using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstCrud.Migrations
{
    public partial class r1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(270)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Collegename = table.Column<string>(type: "nvarchar(270)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(270)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Student", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Student");
        }
    }
}
