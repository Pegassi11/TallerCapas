using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapasNegocio;

namespace CapaPresentacion
{
    public partial class frmEstadoCuenta : Form
    {
        public frmEstadoCuenta()
        {
            InitializeComponent();
        }

        private CNCliente cNCliente = new CNCliente();

        private void frmEstadoCuenta_Load(object sender, EventArgs e)
        {
            // Carga el ComboBox de Clientes
            cbxCliente.DataSource = cNCliente.obtenerDatos().Tables["clientes"];
            cbxCliente.DisplayMember = "NombreComp"; // Muestra el nombre del cliente
            cbxCliente.ValueMember = "IdClientes";   // Guarda el ID del cliente
            cbxCliente.SelectedIndex = -1; // Para que no aparezca nada seleccionado
        }

        // Debes añadir esta instancia en tu formulario
        private CNEstadoCuenta cNEstadoCuenta = new CNEstadoCuenta();
        // También necesitas los controles: dtpFecha (inicio), dtpFechaFin (fin), dgvReporte (para mostrar), lblSaldo (para el saldo)

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = Convert.ToInt32(cbxCliente.SelectedValue);
                DateTime fechaDesde = dtFecha.Value;
                DateTime fechaHasta = dtFechaFin.Value;

                DataTable dt = cNEstadoCuenta.obtenerDatos(idCliente, fechaDesde, fechaHasta);

                dgvReporte.DataSource = dt;

                // ... (código para mostrar el saldo final en el label) ...

                // --- TALLER 7 - PARTE 3: Bucle 'for' ---
                // Se recorre la tabla usando un contador (i) desde la fila 0 hasta la última
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    // Se obtiene la fila actual usando el índice (i)
                    DataRow fila = dt.Rows[i];

                    // Se muestra el valor de la columna "Debe" de esa fila
                    // (Puedes mostrar cualquier columna, como "Fecha" o "Saldo")
                    MessageBox.Show(fila["Debe"].ToString(), "Debe");
                }
                // --- FIN DE LA PARTE 3 ---
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
