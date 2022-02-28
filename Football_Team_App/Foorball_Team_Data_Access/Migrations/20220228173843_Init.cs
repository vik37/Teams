using Microsoft.EntityFrameworkCore.Migrations;

namespace Foorball_Team_Data_Access.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stadium = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoundedYear = table.Column<int>(type: "int", nullable: false),
                    History = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "DateOfBirth", "Firstname", "Lastname", "Value" },
                values: new object[] { 1, "03-10-1981", "Zlatan", "Ibrahimovic", 2500000.0 });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "DateOfBirth", "Firstname", "Lastname", "Value" },
                values: new object[] { 2, "08-05-2000", "Sandro", "Tonali", 65000000.0 });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "City", "FoundedYear", "History", "Name", "Stadium" },
                values: new object[] { 1, "Milano", 1899, "AC Milan was founded as Milan Foot-Ball and Cricket Club in 1899 by English expatriates Alfred Edwards and Herbert Kilpin. The club claims 16 December of that year as their foundation date, but historical evidence seems to suggest that the club was actually founded a few days earlier, most likely on 13 December.", "AC Milan", "San Siro" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
