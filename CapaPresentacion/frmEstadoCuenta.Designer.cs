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
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // cbxCliente
            // 
            cbxCliente.FormattingEnabled = true;
            cbxCliente.Location = new Point(108, 15);
            cbxCliente.Name = "cbxCliente";
            cbxCliente.Size = new Size(135, 28);
            cbxCliente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 18);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 1;
            label1.Text = "IDCliente";
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(17, 147);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.Size = new Size(759, 270);
            dgvReporte.TabIndex = 2;
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(108, 49);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(278, 27);
            dtFecha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 49);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 4;
            label2.Text = "Fecha Inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 87);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 6;
            label3.Text = "Fecha Fin";
            // 
            // dtFechaFin
            // 
            dtFechaFin.Location = new Point(108, 82);
            dtFechaFin.Name = "dtFechaFin";
            dtFechaFin.Size = new Size(278, 27);
            dtFechaFin.TabIndex = 5;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(340, 23);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(47, 20);
            lblSaldo.TabIndex = 7;
            lblSaldo.Text = "Saldo";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(463, 15);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(250, 94);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 23);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 9;
            label4.Text = "Saldo Final:";
            // 
            // frmEstadoCuenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}