using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoDeLaboratorios.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computadores",
                columns: table => new
                {
                    ComputadorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Marca = table.Column<string>(type: "TEXT", nullable: false),
                    Processador = table.Column<string>(type: "TEXT", nullable: false),
                    PlacaMae = table.Column<string>(type: "TEXT", nullable: false),
                    Memoria = table.Column<int>(type: "INTEGER", nullable: false),
                    HD = table.Column<int>(type: "INTEGER", nullable: false),
                    NumeroPatrimonio = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCompra = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computadores", x => x.ComputadorId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computadores");
        }
    }
}
