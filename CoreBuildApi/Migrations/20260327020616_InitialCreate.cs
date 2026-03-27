using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CoreBuildApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cpus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Marca = table.Column<string>(type: "text", nullable: false),
                    Socket = table.Column<string>(type: "text", nullable: false),
                    Generacion = table.Column<string>(type: "text", nullable: false),
                    Nucleos = table.Column<int>(type: "integer", nullable: false),
                    Hilos = table.Column<int>(type: "integer", nullable: false),
                    FrecuenciaBase = table.Column<string>(type: "text", nullable: false),
                    FrecuenciaTurbo = table.Column<string>(type: "text", nullable: false),
                    CacheL3 = table.Column<string>(type: "text", nullable: false),
                    TdpWatts = table.Column<int>(type: "integer", nullable: false),
                    GraficosIntegrados = table.Column<string>(type: "text", nullable: true),
                    SoporteRam = table.Column<string>(type: "text", nullable: false),
                    PrecioUsd = table.Column<decimal>(type: "numeric", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cpus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gpus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Marca = table.Column<string>(type: "text", nullable: false),
                    Chipset = table.Column<string>(type: "text", nullable: false),
                    Vram = table.Column<string>(type: "text", nullable: false),
                    TipoVram = table.Column<string>(type: "text", nullable: false),
                    BusMemoria = table.Column<string>(type: "text", nullable: false),
                    FrecuenciaBase = table.Column<string>(type: "text", nullable: false),
                    FrecuenciaBoost = table.Column<string>(type: "text", nullable: false),
                    ConsumoWatts = table.Column<int>(type: "integer", nullable: false),
                    FuenteRecomendada = table.Column<string>(type: "text", nullable: false),
                    ConectoresEnergia = table.Column<string>(type: "text", nullable: false),
                    VersionPcie = table.Column<string>(type: "text", nullable: false),
                    PrecioUsd = table.Column<decimal>(type: "numeric", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gpus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motherboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Marca = table.Column<string>(type: "text", nullable: false),
                    Socket = table.Column<string>(type: "text", nullable: false),
                    Chipset = table.Column<string>(type: "text", nullable: false),
                    Formato = table.Column<string>(type: "text", nullable: false),
                    CompatibilidadCpu = table.Column<string>(type: "text", nullable: false),
                    TipoRam = table.Column<string>(type: "text", nullable: false),
                    VelocidadRamMax = table.Column<string>(type: "text", nullable: false),
                    SlotsRam = table.Column<string>(type: "text", nullable: false),
                    Almacenamiento = table.Column<string>(type: "text", nullable: false),
                    Puertos = table.Column<string>(type: "text", nullable: false),
                    Conectividad = table.Column<string>(type: "text", nullable: true),
                    PrecioUsd = table.Column<decimal>(type: "numeric", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Psus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Marca = table.Column<string>(type: "text", nullable: false),
                    PotenciaWatts = table.Column<int>(type: "integer", nullable: false),
                    Certificacion = table.Column<string>(type: "text", nullable: false),
                    TipoModular = table.Column<string>(type: "text", nullable: false),
                    Eficiencia = table.Column<string>(type: "text", nullable: false),
                    Ventilador = table.Column<string>(type: "text", nullable: false),
                    Protecciones = table.Column<string>(type: "text", nullable: false),
                    Conectores = table.Column<string>(type: "text", nullable: false),
                    PrecioUsd = table.Column<decimal>(type: "numeric", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Psus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Marca = table.Column<string>(type: "text", nullable: false),
                    Tipo = table.Column<string>(type: "text", nullable: false),
                    CapacidadTotal = table.Column<string>(type: "text", nullable: false),
                    Configuracion = table.Column<string>(type: "text", nullable: false),
                    Velocidad = table.Column<string>(type: "text", nullable: false),
                    Latencia = table.Column<string>(type: "text", nullable: false),
                    Voltaje = table.Column<string>(type: "text", nullable: false),
                    Perfil = table.Column<string>(type: "text", nullable: false),
                    PrecioUsd = table.Column<decimal>(type: "numeric", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rams", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cpus");

            migrationBuilder.DropTable(
                name: "Gpus");

            migrationBuilder.DropTable(
                name: "Motherboards");

            migrationBuilder.DropTable(
                name: "Psus");

            migrationBuilder.DropTable(
                name: "Rams");
        }
    }
}
