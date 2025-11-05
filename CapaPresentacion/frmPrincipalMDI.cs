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
    public partial class frmPrincipalMDI : Form
    {
        public frmPrincipalMDI()
        {
            InitializeComponent();
        }

        private void abrirClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verefica si no hay otro cliente abierto
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm is Form1)
                {
                    childForm.Activate(); // Activa esa ventana
                    return;               // No abre una nueva
                }
            }

            // Si no hay otro cliente, crea uno nuevo y lo muestra
            Form1 clientesForm = new Form1();
            clientesForm.MdiParent = this; // Establece esta ventana como el papá
            clientesForm.Show();           // Muestra la hija
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Cierra la aplicación
        }

        private void estadoDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verefica si no hay otro cliente abierto
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm is frmEstadoCuenta)
                {
                    childForm.Activate(); // Activa esa ventana
                    return;               // No abre una nueva
                }
            }
            frmEstadoCuenta reporteForm = new frmEstadoCuenta();
            reporteForm.MdiParent = this; // Asigna este formulario como el contenedor
            reporteForm.Show();
        }
    }
}
