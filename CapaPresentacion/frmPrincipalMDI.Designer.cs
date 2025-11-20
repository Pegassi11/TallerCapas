namespace CapaPresentacion
{
    partial class frmPrincipalMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            abrirClientesToolStripMenuItem = new ToolStripMenuItem();
            clientesDataTableToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            estadoDeCuentaToolStripMenuItem = new ToolStripMenuItem();
            estadoDeCuentaDataSetToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, clientesToolStripMenuItem, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1296, 35);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(88, 29);
            archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(147, 34);
            salirToolStripMenuItem.Text = "&Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirClientesToolStripMenuItem, clientesDataTableToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(89, 29);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // abrirClientesToolStripMenuItem
            // 
            abrirClientesToolStripMenuItem.Name = "abrirClientesToolStripMenuItem";
            abrirClientesToolStripMenuItem.Size = new Size(270, 34);
            abrirClientesToolStripMenuItem.Text = "Clientes (DataSet)";
            abrirClientesToolStripMenuItem.Click += abrirClientesToolStripMenuItem_Click;
            // 
            // clientesDataTableToolStripMenuItem
            // 
            clientesDataTableToolStripMenuItem.Name = "clientesDataTableToolStripMenuItem";
            clientesDataTableToolStripMenuItem.Size = new Size(270, 34);
            clientesDataTableToolStripMenuItem.Text = "Clientes (DataTable)";
            clientesDataTableToolStripMenuItem.Click += clientesDataTableToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { estadoDeCuentaToolStripMenuItem, estadoDeCuentaDataSetToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(98, 29);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // estadoDeCuentaToolStripMenuItem
            // 
            estadoDeCuentaToolStripMenuItem.Name = "estadoDeCuentaToolStripMenuItem";
            estadoDeCuentaToolStripMenuItem.Size = new Size(389, 34);
            estadoDeCuentaToolStripMenuItem.Text = "Estado de Cuenta (pAlmacendado)";
            estadoDeCuentaToolStripMenuItem.Click += estadoDeCuentaToolStripMenuItem_Click;
            // 
            // estadoDeCuentaDataSetToolStripMenuItem
            // 
            estadoDeCuentaDataSetToolStripMenuItem.Name = "estadoDeCuentaDataSetToolStripMenuItem";
            estadoDeCuentaDataSetToolStripMenuItem.Size = new Size(389, 34);
            estadoDeCuentaDataSetToolStripMenuItem.Text = "Estado de Cuenta (DataSet)";
            estadoDeCuentaDataSetToolStripMenuItem.Click += estadoDeCuentaDataSetToolStripMenuItem_Click;
            // 
            // frmPrincipalMDI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 780);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmPrincipalMDI";
            Text = "frmPrincipalMDI";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem abrirClientesToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem estadoDeCuentaToolStripMenuItem;
        private ToolStripMenuItem clientesDataTableToolStripMenuItem;
        private ToolStripMenuItem estadoDeCuentaDataSetToolStripMenuItem;
    }
}