using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra toda la aplicación
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // --- Validación Simple (Reemplazar con lógica real después) ---
            string usuarioValido = "admin";
            string contrasenaValida = "1234";

            if (txtUsuario.Text == usuarioValido && txtContrasena.Text == contrasenaValida)
            {
                // Login exitoso
                MessageBox.Show("¡Bienvenido!");

                // Oculta el formulario de login
                this.Hide();

                // Crea y muestra el formulario principal
                frmPrincipalMDI formPrincipal = new frmPrincipalMDI();
                formPrincipal.Show();
                // Opcional: Si quieres que la aplicación se cierre al cerrar Form1
                formPrincipal.FormClosed += (s, args) => this.Close();

            }
            else
            {
                // Login fallido
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContrasena.Clear(); // Limpia el campo de contraseña
                txtUsuario.Focus();    // Pone el foco de nuevo en el usuario
            }
        }
    }
}
