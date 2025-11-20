using CapasEntidad;
using CapasNegocio; // Se necesita para poder usar CNCliente
using System.Data;

namespace CapaPresentacion
{
 public partial class Form1DataTable : Form
 {
 // Usaremos la capa de negocio como intermediario
 private CNCliente cNCliente = new CNCliente();
 private CNCategorias cNCategorias = new CNCategorias();

 public Form1DataTable()
 {
 InitializeComponent();
 }

 private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
 {
 ofdFoto.FileName = string.Empty;
 if (ofdFoto.ShowDialog() == DialogResult.OK)
 {
 pctFoto.Load(ofdFoto.FileName);
 }
 ofdFoto.FileName = string.Empty;
 }

 private void btnNuevo_Click(object sender, EventArgs e)
 {
 nudId.Value =0;
 txtNombre.Text = string.Empty;
 txtCedula.Text = string.Empty;
 cmbCateg.SelectedIndex = -1;
 pctFoto.Image = null;
 nudMonto.Value =0;
 txtCorreo.Text = string.Empty;
 rbSr.Checked = false;
 rbSra.Checked = false;
 chkInteres1.Checked = false;
 chkInteres2.Checked = false;
 chkInteres3.Checked = false;
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
 cEClientes.fechaCrea = DateTime.Now;
 cEClientes.numLote = "";
 if (rbSr.Checked)
 cEClientes.Genero = "Sr.";
 else if (rbSra.Checked)
 cEClientes.Genero = "Sra.";
 else
 cEClientes.Genero = string.Empty;

 cEClientes.Interes1 = chkInteres1.Checked;
 cEClientes.Interes2 = chkInteres2.Checked;
 cEClientes.Interes3 = chkInteres3.Checked;

 bool validado = cNCliente.validarDatos(cEClientes);
 if (!validado) return;

 cNCliente.CrearCliente(cEClientes);
 CargarGrid();
 }

 private void dgvDatos_SelectionChanged(object sender, EventArgs e)
 {
 if (dgvDatos.CurrentRow != null)
 {
 if (dgvDatos.CurrentRow.Cells["IdClientes"].Value != DBNull.Value)
 nudId.Value = Convert.ToInt32(dgvDatos.CurrentRow.Cells["IdClientes"].Value);
 else
 nudId.Value =0;

 txtNombre.Text = dgvDatos.CurrentRow.Cells["NombreComp"].Value?.ToString() ?? string.Empty;
 txtCedula.Text = dgvDatos.CurrentRow.Cells["CedCliente"].Value?.ToString() ?? string.Empty;
 cmbCateg.Text = dgvDatos.CurrentRow.Cells["CtgCliente"].Value?.ToString() ?? string.Empty;
 if (dgvDatos.CurrentRow.Cells["MontoTotal"].Value != DBNull.Value)
 nudMonto.Value = Convert.ToDecimal(dgvDatos.CurrentRow.Cells["MontoTotal"].Value);
 else
 nudMonto.Value =0;
 pctFoto.ImageLocation = dgvDatos.CurrentRow.Cells["FotoCliente"].Value?.ToString() ?? string.Empty;
 txtCorreo.Text = dgvDatos.CurrentRow.Cells["Correo"].Value?.ToString() ?? string.Empty;

 string genero = dgvDatos.CurrentRow.Cells["Genero"].Value?.ToString() ?? string.Empty;
 if (genero == "Sr.") rbSr.Checked = true;
 else if (genero == "Sra.") rbSra.Checked = true;
 else { rbSr.Checked = false; rbSra.Checked = false; }

 var val1 = dgvDatos.CurrentRow.Cells["Interes1"].Value;
 chkInteres1.Checked = val1 != DBNull.Value && Convert.ToBoolean(val1);
 var val2 = dgvDatos.CurrentRow.Cells["Interes2"].Value;
 chkInteres2.Checked = val2 != DBNull.Value && Convert.ToBoolean(val2);
 var val3 = dgvDatos.CurrentRow.Cells["Interes3"].Value;
 chkInteres3.Checked = val3 != DBNull.Value && Convert.ToBoolean(val3);
 }
 }

 private void Form1DataTable_Load(object sender, EventArgs e)
 {
 CargarGrid();
 cmbCateg.DataSource = cNCategorias.obtenerDatos().Tables["categorias"];
 cmbCateg.DisplayMember = "descCat";
 cmbCateg.ValueMember = "idCategoria";
 }

 private void btnActualizar_Click(object sender, EventArgs e)
 {
 try
 {
 CEClientes cEClientes = new CEClientes();
 cEClientes.IdClientes = (int)nudId.Value;
 cEClientes.nombreComp = txtNombre.Text;
 cEClientes.cedCliente = txtCedula.Text;
 cEClientes.ctgCliente = cmbCateg.Text;
 cEClientes.fotoCliente = pctFoto.ImageLocation;
 cEClientes.montoTotal = (double)nudMonto.Value;
 cEClientes.Correo = txtCorreo.Text;
 if (rbSr.Checked) cEClientes.Genero = "Sr.";
 else if (rbSra.Checked) cEClientes.Genero = "Sra.";
 else cEClientes.Genero = string.Empty;
 cEClientes.Interes1 = chkInteres1.Checked;
 cEClientes.Interes2 = chkInteres2.Checked;
 cEClientes.Interes3 = chkInteres3.Checked;

 cNCliente.ActualizarCliente(cEClientes);
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
 // Usar el nuevo método que devuelve DataTable
 dgvDatos.DataSource = cNCliente.obtenerDatosTabla();
 }

 private void nudId_Validating(object sender, System.ComponentModel.CancelEventArgs e)
 {
 if (nudId.Value ==0)
 {
 MessageBox.Show("El ID del cliente no puede ser cero.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
 e.Cancel = true;
 }
 }

 private void txtCorreo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
 {
 string correo = txtCorreo.Text;
 if (string.IsNullOrWhiteSpace(correo)) return;
 bool esValido = System.Text.RegularExpressions.Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
 if (!esValido)
 {
 MessageBox.Show("El formato del correo electrónico no es válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
 e.Cancel = true;
 }
 }

 private void Form1DataTable_KeyDown(object sender, KeyEventArgs e)
 {
 if (e.Control && e.KeyCode == Keys.S)
 {
 MessageBox.Show("Guardando");
 }
 }
 }
}
