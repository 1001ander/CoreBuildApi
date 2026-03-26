namespace CoreBuildApi.models
{
    public class Gpu
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Chipset { get; set; } = string.Empty;
        public string Vram { get; set; } = string.Empty;
        public string TipoVram { get; set; } = string.Empty;
        public string BusMemoria { get; set; } = string.Empty;
        public string FrecuenciaBase { get; set; } = string.Empty;
        public string FrecuenciaBoost { get; set; } = string.Empty;
        public int ConsumoWatts { get; set; }
        public string FuenteRecomendada { get; set; } = string.Empty;
        public string ConectoresEnergia { get; set; } = string.Empty;
        public string VersionPcie { get; set; } = string.Empty;
        public decimal PrecioUsd { get; set; }
        public string Descripcion { get; set; } = string.Empty;
    }
}
