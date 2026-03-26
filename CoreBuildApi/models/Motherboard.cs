namespace CoreBuildApi.models
{
    public class Motherboard
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Socket { get; set; } = string.Empty;
        public string Chipset { get; set; } = string.Empty;
        public string Formato { get; set; } = string.Empty;
        public string CompatibilidadCpu { get; set; } = string.Empty;
        public string TipoRam { get; set; } = string.Empty;
        public string VelocidadRamMax { get; set; } = string.Empty;
        public string SlotsRam { get; set; } = string.Empty;
        public string Almacenamiento { get; set; } = string.Empty;
        public string Puertos { get; set; } = string.Empty;
        public string? Conectividad { get; set; }
        public decimal PrecioUsd { get; set; }
        public string Descripcion { get; set; } = string.Empty;
    }
}
