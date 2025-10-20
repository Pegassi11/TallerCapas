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
        public string Correo { get; set; } = string.Empty; // Inicilializado

        // --- NUEVAS PROPIEDADES (Taller 6) ---
        public string Genero { get; set; } = string.Empty;
        public bool Interes1 { get; set; } // Para CheckBox (montaña)
        public bool Interes2 { get; set; } // Para CheckBox (playa)
        public bool Interes3 { get; set; } // Para CheckBox (compras)
    }

}
