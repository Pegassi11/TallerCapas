using CapasEntidad;
using CapasNegocio; // Se necesita para poder usar CNCliente

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        // --- CORRECCI�N 1: Crear una instancia (un objeto) de la capa de negocio ---
        // Este objeto "cNCliente" ser� el intermediario para todas las operaciones.
        private CNCliente cNCliente = new CNCliente();

        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // codigo para cargar la foto al control de picturebox
            ofdFoto.FileName = string.Empty;
            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                // se guarda la imagen y la ubicacion en el control
                pctFoto.Load(ofdFoto.FileName);
            }
            ofdFoto.FileName = string.Empty;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nudId.Value = 0;
            txtNombre.Text = string.Empty; // o ""
            txtCedula.Text = string.Empty;
            cmbCateg.SelectedIndex = -1; // Deselecciona cualquier �tem
            pctFoto.Image = null; // Limpia la imagen
            nudMonto.Value = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CEClientes cEClientes = new CEClientes();
            cEClientes.IdClientes = (int)nudId.Value;
            cEClientes.nombreComp = txtNombre.Text;
            cEClientes.cedCliente = txtCedula.Text;
            cEClientes.ctgCliente = cmbCateg.Text;
            cEClientes.fotoCliente = pctFoto.ImageLocation;
            cEClientes.montoTotal = (double)nudMonto.Value;

            // --- NOTA: Asignar valores a las nuevas propiedades ---
            // Se deben llenar los campos que se a�adieron a la entidad para evitar errores.
            cEClientes.fechaCrea = DateTime.Now; // Asigna la fecha y hora actual como ejemplo
            cEClientes.numLote = ""; // Se debe asignar un valor, aunque sea vac�o por ahora

            // ---- Taller 3 ----
            bool validado;

            // --- CORRECCI�N 2: Usar el objeto "cNCliente" (en min�scula) ---
            // Ya no se llama al plano (CNCliente), sino al motor real que se construy� (cNCliente).
            validado = cNCliente.validarDatos(cEClientes);

            if (validado == false)
            {
                return;
            }

            // --- CORRECCI�N 3: Usar el objeto "cNCliente" aqu� tambi�n ---
            cNCliente.CrearCliente(cEClientes);
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            // Primero, se comprueba si hay una fila seleccionada para evitar errores
            if (dgvDatos.CurrentRow != null)
            {
                // --- CORRECCI�N: Se usan los nombres de columna exactos de la base de datos ---
                nudId.Value = Convert.ToInt32(dgvDatos.CurrentRow.Cells["IdClientes"].Value);
                txtNombre.Text = dgvDatos.CurrentRow.Cells["NombreComp"].Value.ToString();
                txtCedula.Text = dgvDatos.CurrentRow.Cells["CedCliente"].Value.ToString();
                cmbCateg.Text = dgvDatos.CurrentRow.Cells["CtgCliente"].Value.ToString();
                nudMonto.Value = Convert.ToDecimal(dgvDatos.CurrentRow.Cells["MontoTotal"].Value);
                pctFoto.ImageLocation = dgvDatos.CurrentRow.Cells["FotoCliente"].Value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ahora simplemente se ejecuta el procedimiento est�ndar de carga.
            CargarGrid();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Recolectar los datos del formulario en un objeto CEClientes.
                CEClientes cEClientes = new CEClientes();
                cEClientes.IdClientes = (int)nudId.Value;
                cEClientes.nombreComp = txtNombre.Text;
                cEClientes.cedCliente = txtCedula.Text;
                cEClientes.ctgCliente = cmbCateg.Text;
                cEClientes.fotoCliente = pctFoto.ImageLocation;
                cEClientes.montoTotal = (double)nudMonto.Value;

                // 2. Llamar al m�todo de la capa de negocio para actualizar.
                cNCliente.ActualizarCliente(cEClientes);

                // 3. Notificar al usuario y refrescar la tabla.
                MessageBox.Show("Cliente actualizado exitosamente.");
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }
        private void CargarGrid()
        {
            // Esta es la misma l�nea de c�digo que est� en el evento Form_Load.
            // Pide los datos a la capa de negocio y los asigna a la tabla.
            dgvDatos.DataSource = cNCliente.obtenerDatos().Tables["clientes"];
        }
    }
}