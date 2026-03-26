namespace CoreBuildApi.models
{
    public class Cpu
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Socket { get; set; } = string.Empty;
        public string Generacion { get; set; } = string.Empty;
        public int Nucleos { get; set; }
        public int Hilos { get; set; }
        public string FrecuenciaBase { get; set; } = string.Empty;
        public string FrecuenciaTurbo { get; set; } = string.Empty;
        public string CacheL3 { get; set; } = string.Empty;
        public int TdpWatts { get; set; }
        public string? GraficosIntegrados { get; set; }
        public string SoporteRam { get; set; } = string.Empty;
        public decimal PrecioUsd { get; set; }
        public string Descripcion { get; set; } = string.Empty;
    }
}
