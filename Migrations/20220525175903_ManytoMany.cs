using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommandeProduct.Migrations
{
    public partial class ManytoMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Client",
                table: "Client");

            migrationBuilder.RenameTable(
                name: "Client",
                newName: "Clients");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "Cin");

            migrationBuilder.CreateTable(
                name: "Produits",
                columns: table => new
                {
                    id_P = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_P = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    quantite = table.Column<int>(type: "int", nullable: false),
                    marque = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produits", x => x.id_P);
                });

            migrationBuilder.CreateTable(
                name: "Commandes",
                columns: table => new
                {
                    Id_Command = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_P = table.Column<int>(type: "int", nullable: false),
                    Cin = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commandes", x => x.Id_Command);
                    table.ForeignKey(
                        name: "FK_Commandes_Clients_Cin",
                        column: x => x.Cin,
                        principalTable: "Clients",
                        principalColumn: "Cin",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Commandes_Produits_id_P",
                        column: x => x.id_P,
                        principalTable: "Produits",
                        principalColumn: "id_P",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_Cin",
                table: "Commandes",
                column: "Cin");

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_id_P",
                table: "Commandes",
                column: "id_P");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commandes");

            migrationBuilder.DropTable(
                name: "Produits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "Client");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Client",
                table: "Client",
                column: "Cin");
        }
    }
}
