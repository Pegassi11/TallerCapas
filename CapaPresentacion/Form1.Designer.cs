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
            dgvDatos = new DataGridView();
            btnActualizar = new Button();
            labelCorreo = new Label();
            txtCorreo = new TextBox();
            groupBox1 = new GroupBox();
            rbSr = new RadioButton();
            rbSra = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 63);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(138, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(149, 102);
            txtCedula.Margin = new Padding(3, 4, 3, 4);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(139, 27);
            txtCedula.TabIndex = 2;
            // 
            // nudMonto
            // 
            nudMonto.Location = new Point(150, 140);
            nudMonto.Margin = new Padding(3, 4, 3, 4);
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(138, 27);
            nudMonto.TabIndex = 3;
            // 
            // cmbCateg
            // 
            cmbCateg.FormattingEnabled = true;
            cmbCateg.Location = new Point(150, 179);
            cmbCateg.Margin = new Padding(3, 4, 3, 4);
            cmbCateg.Name = "cmbCateg";
            cmbCateg.Size = new Size(138, 28);
            cmbCateg.TabIndex = 4;
            // 
            // pctFoto
            // 
            pctFoto.Location = new Point(294, 24);
            pctFoto.Margin = new Padding(3, 4, 3, 4);
            pctFoto.Name = "pctFoto";
            pctFoto.Size = new Size(257, 194);
            pctFoto.TabIndex = 5;
            pctFoto.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(368, 222);
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
            btnNuevo.Location = new Point(569, 79);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 31);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(569, 118);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 31);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // nudId
            // 
            nudId.Location = new Point(149, 24);
            nudId.Margin = new Padding(3, 4, 3, 4);
            nudId.Name = "nudId";
            nudId.Size = new Size(139, 27);
            nudId.TabIndex = 9;
            nudId.Validating += nudId_Validating;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(119, 27);
            labelID.Name = "labelID";
            labelID.Size = new Size(24, 20);
            labelID.TabIndex = 10;
            labelID.Text = "ID";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(79, 65);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(64, 20);
            labelNombre.TabIndex = 11;
            labelNombre.Text = "Nombre";
            // 
            // labelCedula
            // 
            labelCedula.AutoSize = true;
            labelCedula.Location = new Point(88, 105);
            labelCedula.Name = "labelCedula";
            labelCedula.Size = new Size(55, 20);
            labelCedula.TabIndex = 12;
            labelCedula.Text = "Cedula";
            // 
            // labelMonto
            // 
            labelMonto.AutoSize = true;
            labelMonto.Location = new Point(91, 142);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(53, 20);
            labelMonto.TabIndex = 13;
            labelMonto.Text = "Monto";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(70, 182);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(74, 20);
            labelCategoria.TabIndex = 14;
            labelCategoria.Text = "Categoria";
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(333, 253);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(593, 188);
            dgvDatos.TabIndex = 15;
            dgvDatos.SelectionChanged += dgvDatos_SelectionChanged;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(569, 156);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 16;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(89, 218);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(54, 20);
            labelCorreo.TabIndex = 17;
            labelCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(150, 215);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(138, 27);
            txtCorreo.TabIndex = 18;
            txtCorreo.Validating += txtCorreo_Validating;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbSra);
            groupBox1.Controls.Add(rbSr);
            groupBox1.Location = new Point(149, 253);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(139, 85);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Género";
            // 
            // rbSr
            // 
            rbSr.AutoSize = true;
            rbSr.Location = new Point(65, 21);
            rbSr.Name = "rbSr";
            rbSr.Size = new Size(46, 24);
            rbSr.TabIndex = 0;
            rbSr.TabStop = true;
            rbSr.Text = "Sr.";
            rbSr.UseVisualStyleBackColor = true;
            // 
            // rbSra
            // 
            rbSra.AutoSize = true;
            rbSra.Location = new Point(65, 51);
            rbSra.Name = "rbSra";
            rbSra.Size = new Size(54, 24);
            rbSra.TabIndex = 1;
            rbSra.TabStop = true;
            rbSra.Text = "Sra.";
            rbSra.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 544);
            Controls.Add(groupBox1);
            Controls.Add(txtCorreo);
            Controls.Add(labelCorreo);
            Controls.Add(btnActualizar);
            Controls.Add(dgvDatos);
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
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudId).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private DataGridView dgvDatos;
        private Button btnActualizar;
        private Label labelCorreo;
        private TextBox txtCorreo;
        private GroupBox groupBox1;
        private RadioButton rbSra;
        private RadioButton rbSr;
    }
}
