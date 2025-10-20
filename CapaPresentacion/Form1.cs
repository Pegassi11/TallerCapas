using CapasEntidad;
using CapasNegocio; // Se necesita para poder usar CNCliente

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        // --- CORRECCIÓN 1: Crear una instancia (un objeto) de la capa de negocio ---
        // Este objeto "cNCliente" será el intermediario para todas las operaciones.
        private CNCliente cNCliente = new CNCliente();
        private CNCategorias cNCategorias = new CNCategorias();

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
            cmbCateg.SelectedIndex = -1; // Deselecciona cualquier ítem
            pctFoto.Image = null; // Limpia la imagen
            nudMonto.Value = 0;
            txtCorreo.Text = string.Empty;
            // --- NUEVO CÓDIGO (Taller 6) ---
            // Deseleccionar los radiobuttons del genero
            rbSr.Checked = false;
            rbSra.Checked = false;

            chkInteres1.Checked = false;
            chkInteres2.Checked = false;
            chkInteres3.Checked = false;
            // --- FIN NUEVO CÓDIGO ---

            // Optional: Set focus back to the first field
            //nudId.Focus();
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
            cEClientes.Correo = txtCorreo.Text;
            // Se deben llenar los campos que se añadieron a la entidad para evitar errores.
            cEClientes.fechaCrea = DateTime.Now; // Asigna la fecha y hora actual como ejemplo
            cEClientes.numLote = ""; // Se debe asignar un valor, aunque sea vacío por ahora
            // Determinar qué RadioButton está seleccionado y asignar el valor
            if (rbSr.Checked)
            {
                cEClientes.Genero = "Sr."; // Guarda "Sr." si rbSr está marcado
            }
            else if (rbSra.Checked)
            {
                cEClientes.Genero = "Sra."; // Guarda "Sra." si rbSra está marcado
            }
            else
            {
                cEClientes.Genero = ""; // Guarda vacío si ninguno está marcado
            }
            // Ver cada interes seleccionado en los CheckBoxes
            cEClientes.Interes1 = chkInteres1.Checked; // verdadero si es seleccionado
            cEClientes.Interes2 = chkInteres2.Checked;
            cEClientes.Interes3 = chkInteres3.Checked;

            bool validado;
            validado = cNCliente.validarDatos(cEClientes);

            if (validado == false)
            {
                return;
            }

            cNCliente.CrearCliente(cEClientes);

            CargarGrid();
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            // Primero, se comprueba si hay una fila seleccionada para evitar errores
            if (dgvDatos.CurrentRow != null)
            {
                // --- CORRECCIÓN: Se usan los nombres de columna exactos de la base de datos ---
                if (dgvDatos.CurrentRow.Cells["IdClientes"].Value != DBNull.Value)
                    nudId.Value = Convert.ToInt32(dgvDatos.CurrentRow.Cells["IdClientes"].Value);
                else
                    nudId.Value = 0; //Se usa el valor por defecto

                txtNombre.Text = dgvDatos.CurrentRow.Cells["NombreComp"].Value?.ToString() ?? string.Empty;
                txtCedula.Text = dgvDatos.CurrentRow.Cells["CedCliente"].Value?.ToString() ?? string.Empty;
                cmbCateg.Text = dgvDatos.CurrentRow.Cells["CtgCliente"].Value?.ToString() ?? string.Empty;
                if (dgvDatos.CurrentRow.Cells["MontoTotal"].Value != DBNull.Value)
                    nudMonto.Value = Convert.ToDecimal(dgvDatos.CurrentRow.Cells["MontoTotal"].Value);
                else
                    nudMonto.Value = 0;
                pctFoto.ImageLocation = dgvDatos.CurrentRow.Cells["FotoCliente"].Value?.ToString() ?? string.Empty;
                txtCorreo.Text = dgvDatos.CurrentRow.Cells["Correo"].Value?.ToString() ?? string.Empty;
                // --- CÓDIGO NUEVO (Taller 6) ---
                // Cargar el Género en los RadioButtons
                string genero = dgvDatos.CurrentRow.Cells["Genero"].Value?.ToString() ?? string.Empty;
                if (genero == "Sr.")
                {
                    rbSr.Checked = true;
                }
                else if (genero == "Sra.")
                {
                    rbSra.Checked = true;
                }
                else
                {
                    // Si no hay género guardado, desmarcar ambos
                    rbSr.Checked = false;
                    rbSra.Checked = false;
                }

                // Cargar los Intereses en los CheckBoxes
                // Se usa Convert.ToBoolean para pasar de bit (0/1) a true/false
                chkInteres1.Checked = Convert.ToBoolean(dgvDatos.CurrentRow.Cells["Interes1"].Value);
                chkInteres2.Checked = Convert.ToBoolean(dgvDatos.CurrentRow.Cells["Interes2"].Value);
                chkInteres3.Checked = Convert.ToBoolean(dgvDatos.CurrentRow.Cells["Interes3"].Value);
                // --- FIN CÓDIGO NUEVO ---
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ahora simplemente se ejecuta el procedimiento estándar de carga.
            CargarGrid();
            // --- CÓDIGO DEL TALLER 5 ---
            // 1. Se conecta el ComboBox a la fuente de datos
            cmbCateg.DataSource = cNCategorias.obtenerDatos().Tables["categorias"];

            // 2. Se le dice qué columna mostrar al usuario
            cmbCateg.DisplayMember = "descCat";

            // 3. Se le dice qué columna usar como valor interno
            cmbCateg.ValueMember = "idCategoria";
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
                cEClientes.Correo = txtCorreo.Text;
                if (rbSr.Checked)
                {
                    cEClientes.Genero = "Sr."; // Guarda "Sr." si rbSr está marcado
                }
                else if (rbSra.Checked)
                {
                    cEClientes.Genero = "Sra."; // Guarda "Sra." si rbSra está marcado
                }
                else
                {
                    cEClientes.Genero = ""; // Opcional: Guarda vacío si ninguno está marcado
                }
                cEClientes.Interes1 = chkInteres1.Checked;
                cEClientes.Interes2 = chkInteres2.Checked;
                cEClientes.Interes3 = chkInteres3.Checked;

                // 2. Llamar al método de la capa de negocio para actualizar.
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
            // Esta es la misma línea de código que está en el evento Form_Load.
            // Pide los datos a la capa de negocio y los asigna a la tabla.
            dgvDatos.DataSource = cNCliente.obtenerDatos().Tables["clientes"];
        }

        private void nudId_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Se comprueba si el valor del control es igual a cero.
            if (nudId.Value == 0)
            {
                // Se muestra un mensaje de error al usuario.
                MessageBox.Show("El ID del cliente no puede ser cero.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // --- ¡Crucial! ---
                // Se cancela el evento. Esto evita que el usuario pueda
                // abandonar el control hasta que ingrese un valor válido.
                e.Cancel = true;
            }
        }

        private void txtCorreo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string correo = txtCorreo.Text;

            // Permite que el campo esté vacío (si no es obligatorio)
            if (string.IsNullOrWhiteSpace(correo))
            {
                return;
            }

            // Validación básica de formato de correo (simplificada)
            // Busca un patrón como "algo@algo.algo"
            bool esValido = System.Text.RegularExpressions.Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (!esValido)
            {
                MessageBox.Show("El formato del correo electrónico no es válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Impide salir del control
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Compruba la tecla Control está presionada junto con la tecla S
            if (e.Control && e.KeyCode == Keys.S)
            {
                // Si ambas condiciones se cumplen, se muestra el mensaje
                MessageBox.Show("Guardando...");

                // Opcional: llamar al método de guardado
                // btnGuardar_Click(sender, e);
            }
        }
    }
}