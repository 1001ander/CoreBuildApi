using Microsoft.EntityFrameworkCore.Migrations;

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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Socket = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Generacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nucleos = table.Column<int>(type: "int", nullable: false),
                    Hilos = table.Column<int>(type: "int", nullable: false),
                    FrecuenciaBase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrecuenciaTurbo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CacheL3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TdpWatts = table.Column<int>(type: "int", nullable: false),
                    GraficosIntegrados = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoporteRam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioUsd = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cpus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gpus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Chipset = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoVram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusMemoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrecuenciaBase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrecuenciaBoost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConsumoWatts = table.Column<int>(type: "int", nullable: false),
                    FuenteRecomendada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConectoresEnergia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VersionPcie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioUsd = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gpus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motherboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Socket = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Chipset = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Formato = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompatibilidadCpu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoRam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VelocidadRamMax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SlotsRam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Almacenamiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Puertos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conectividad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrecioUsd = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Psus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PotenciaWatts = table.Column<int>(type: "int", nullable: false),
                    Certificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoModular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eficiencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ventilador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Protecciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conectores = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioUsd = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Psus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapacidadTotal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Configuracion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Velocidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Voltaje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perfil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioUsd = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
