using CapasEntidad;
namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
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

        }
    }
}
