using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELibrary.Migrations
{
    public partial class Librarian : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Librarians",
                columns: table => new
                {
                    LibrarianId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LibrarianName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LibrarianSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Librarians", x => x.LibrarianId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Librarians");
        }
    }
}
