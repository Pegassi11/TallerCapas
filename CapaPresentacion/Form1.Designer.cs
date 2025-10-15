namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtCedula = new TextBox();
            nudMonto = new NumericUpDown();
            cmbCateg = new ComboBox();
            pctFoto = new PictureBox();
            linkLabel1 = new LinkLabel();
            ofdFoto = new OpenFileDialog();
            btnNuevo = new Button();
            btnGuardar = new Button();
            nudId = new NumericUpDown();
            labelID = new Label();
            labelNombre = new Label();
            labelCedula = new Label();
            labelMonto = new Label();
            labelCategoria = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudId).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(154, 76);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(153, 115);
            txtCedula.Margin = new Padding(3, 4, 3, 4);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(114, 27);
            txtCedula.TabIndex = 2;
            // 
            // nudMonto
            // 
            nudMonto.Location = new Point(154, 153);
            nudMonto.Margin = new Padding(3, 4, 3, 4);
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(137, 27);
            nudMonto.TabIndex = 3;
            // 
            // cmbCateg
            // 
            cmbCateg.FormattingEnabled = true;
            cmbCateg.Items.AddRange(new object[] { "Activo", "Potencial", "Inactivo" });
            cmbCateg.Location = new Point(154, 192);
            cmbCateg.Margin = new Padding(3, 4, 3, 4);
            cmbCateg.Name = "cmbCateg";
            cmbCateg.Size = new Size(138, 28);
            cmbCateg.TabIndex = 4;
            // 
            // pctFoto
            // 
            pctFoto.Location = new Point(298, 37);
            pctFoto.Margin = new Padding(3, 4, 3, 4);
            pctFoto.Name = "pctFoto";
            pctFoto.Size = new Size(114, 67);
            pctFoto.TabIndex = 5;
            pctFoto.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(318, 108);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(87, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cargar Foto";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // ofdFoto
            // 
            ofdFoto.FileName = "openFileDialog1";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(419, 35);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(86, 31);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(419, 73);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // nudId
            // 
            nudId.Location = new Point(153, 37);
            nudId.Margin = new Padding(3, 4, 3, 4);
            nudId.Name = "nudId";
            nudId.Size = new Size(137, 27);
            nudId.TabIndex = 9;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(123, 40);
            labelID.Name = "labelID";
            labelID.Size = new Size(24, 20);
            labelID.TabIndex = 10;
            labelID.Text = "ID";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(83, 78);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(64, 20);
            labelNombre.TabIndex = 11;
            labelNombre.Text = "Nombre";
            // 
            // labelCedula
            // 
            labelCedula.AutoSize = true;
            labelCedula.Location = new Point(92, 118);
            labelCedula.Name = "labelCedula";
            labelCedula.Size = new Size(55, 20);
            labelCedula.TabIndex = 12;
            labelCedula.Text = "Cedula";
            // 
            // labelMonto
            // 
            labelMonto.AutoSize = true;
            labelMonto.Location = new Point(95, 155);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(53, 20);
            labelMonto.TabIndex = 13;
            labelMonto.Text = "Monto";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(74, 195);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(74, 20);
            labelCategoria.TabIndex = 14;
            labelCategoria.Text = "Categoria";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(labelCategoria);
            Controls.Add(labelMonto);
            Controls.Add(labelCedula);
            Controls.Add(labelNombre);
            Controls.Add(labelID);
            Controls.Add(nudId);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(linkLabel1);
            Controls.Add(pctFoto);
            Controls.Add(cmbCateg);
            Controls.Add(nudMonto);
            Controls.Add(txtCedula);
            Controls.Add(txtNombre);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private TextBox txtCedula;
        private NumericUpDown nudMonto;
        private ComboBox cmbCateg;
        private PictureBox pctFoto;
        private LinkLabel linkLabel1;
        private OpenFileDialog ofdFoto;
        private Button btnNuevo;
        private Button btnGuardar;
        private NumericUpDown nudId;
        private Label labelID;
        private Label labelNombre;
        private Label labelCedula;
        private Label labelMonto;
        private Label labelCategoria;
    }
}
