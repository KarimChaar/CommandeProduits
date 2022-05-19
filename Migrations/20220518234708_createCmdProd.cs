using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommandeProduct.Migrations
{
    public partial class createCmdProd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Cin = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClientNom = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LocationRue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationVille = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationPays = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type_C = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Cin);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
