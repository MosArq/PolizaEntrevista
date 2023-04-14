using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PolizaAPI.Migrations
{
    /// <inheritdoc />
    public partial class PolizaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
            name: "Polizas",
            columns: table => new
            {
                id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                NombreCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                IdentificacionCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                FechaNacimientoCliente = table.Column<DateTime>(type: "datetime2", nullable: false),
                FechaPoliza = table.Column<DateTime>(type: "datetime2", nullable: false),
                CoberturasCubiertas = table.Column<int>(type: "int", nullable: false),
                ValorMaxPoliza = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                NombrePlanPoliza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                CiudadResideCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                DireccionCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                PlacaAuto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Inspeccion = table.Column<bool>(type: "bit", nullable: false),
                FechaInicialPoliza = table.Column<DateTime>(type: "datetime2", nullable: false),
                FechaFinalPoliza = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Polizas", x => x.id);
            });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
            name: "Polizas");
        }
    }
}
