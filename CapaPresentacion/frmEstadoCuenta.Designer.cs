namespace CapaPresentacion
{
    partial class frmEstadoCuenta
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
            cbxCliente = new ComboBox();
            label1 = new Label();
            dgvReporte = new DataGridView();
            dtFecha = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dtFechaFin = new DateTimePicker();
            lblSaldo = new Label();
            btnAceptar = new Button();
            label4 = new Label();
            btnImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // cbxCliente
            // 
            cbxCliente.FormattingEnabled = true;
            cbxCliente.Location = new Point(135, 19);
            cbxCliente.Margin = new Padding(4);
            cbxCliente.Name = "cbxCliente";
            cbxCliente.Size = new Size(168, 33);
            cbxCliente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 1;
            label1.Text = "IDCliente";
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(21, 178);
            dgvReporte.Margin = new Padding(4);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.Size = new Size(949, 344);
            dgvReporte.TabIndex = 2;
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(135, 61);
            dtFecha.Margin = new Padding(4);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(346, 31);
            dtFecha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 61);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 4;
            label2.Text = "Fecha Inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 109);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 6;
            label3.Text = "Fecha Fin";
            // 
            // dtFechaFin
            // 
            dtFechaFin.Location = new Point(135, 102);
            dtFechaFin.Margin = new Padding(4);
            dtFechaFin.Name = "dtFechaFin";
            dtFechaFin.Size = new Size(346, 31);
            dtFechaFin.TabIndex = 5;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(425, 29);
            lblSaldo.Margin = new Padding(4, 0, 4, 0);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(57, 25);
            lblSaldo.TabIndex = 7;
            lblSaldo.Text = "Saldo";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(519, 15);
            btnAceptar.Margin = new Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(138, 118);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(311, 29);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 9;
            label4.Text = "Saldo Final:";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(664, 15);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(155, 119);
            btnImprimir.TabIndex = 10;
            btnImprimir.Text = "Generar Reporte";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // frmEstadoCuenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnImprimir);
            Controls.Add(label4);
            Controls.Add(btnAceptar);
            Controls.Add(lblSaldo);
            Controls.Add(label3);
            Controls.Add(dtFechaFin);
            Controls.Add(label2);
            Controls.Add(dtFecha);
            Controls.Add(dgvReporte);
            Controls.Add(label1);
            Controls.Add(cbxCliente);
            Margin = new Padding(4);
            Name = "frmEstadoCuenta";
            Text = "frmEstadoCuenta";
            Load += frmEstadoCuenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxCliente;
        private Label label1;
        private DataGridView dgvReporte;
        private DateTimePicker dtFecha;
        private Label label2;
        private Label label3;
        private DateTimePicker dtFechaFin;
        private Label lblSaldo;
        private Button btnAceptar;
        private Label label4;
        private Button btnImprimir;
    }
}