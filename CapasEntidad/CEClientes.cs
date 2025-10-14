namespace CapasEntidad
{
    public class CEClientes
    {
        public int IdClientes { get; set; }
        public string nombreComp { get; set; } = string.Empty; // Inicializado
        public string cedCliente { get; set; } = string.Empty; // Inicializado
        public string ctgCliente { get; set; } = string.Empty; // Inicializado
        public string fotoCliente { get; set; } = string.Empty; // Inicializado
        public double montoTotal { get; set; }
        public DateTime fechaCrea { get; set; }
        public string numLote { get; set; } = string.Empty; // Inicializado
    }

}
