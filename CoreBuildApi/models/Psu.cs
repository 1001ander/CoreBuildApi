namespace CoreBuildApi.models;

public class Psu
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Marca { get; set; } = string.Empty;
    public int PotenciaWatts { get; set; }
    public string Certificacion { get; set; } = string.Empty;
    public string TipoModular { get; set; } = string.Empty;
    public string Eficiencia { get; set; } = string.Empty;
    public string Ventilador { get; set; } = string.Empty;
    public string Protecciones { get; set; } = string.Empty;
    public string Conectores { get; set; } = string.Empty;
    public decimal PrecioUsd { get; set; }
    public string Descripcion { get; set; } = string.Empty;
}
