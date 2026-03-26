namespace CoreBuildApi.models
{
    public class Ram
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public string CapacidadTotal { get; set; } = string.Empty;
        public string Configuracion { get; set; } = string.Empty;
        public string Velocidad { get; set; } = string.Empty;
        public string Latencia { get; set; } = string.Empty;
        public string Voltaje { get; set; } = string.Empty;
        public string Perfil { get; set; } = string.Empty;
        public decimal PrecioUsd { get; set; }
        public string Descripcion { get; set; } = string.Empty;
    }
}
