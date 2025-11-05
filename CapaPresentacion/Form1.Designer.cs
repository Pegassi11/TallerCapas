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
            rbSra = new RadioButton();
            rbSr = new RadioButton();
            groupBox2 = new GroupBox();
            chkInteres3 = new CheckBox();
            chkInteres2 = new CheckBox();
            chkInteres1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(131, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(121, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(130, 76);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(122, 23);
            txtCedula.TabIndex = 2;
            // 
            // nudMonto
            // 
            nudMonto.Location = new Point(131, 105);
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(121, 23);
            nudMonto.TabIndex = 3;
            // 
            // cmbCateg
            // 
            cmbCateg.FormattingEnabled = true;
            cmbCateg.Location = new Point(131, 134);
            cmbCateg.Name = "cmbCateg";
            cmbCateg.Size = new Size(121, 23);
            cmbCateg.TabIndex = 4;
            // 
            // pctFoto
            // 
            pctFoto.Location = new Point(414, 18);
            pctFoto.Name = "pctFoto";
            pctFoto.Size = new Size(242, 137);
            pctFoto.TabIndex = 5;
            pctFoto.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(502, 166);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(69, 15);
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
            btnNuevo.Location = new Point(670, 50);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(82, 23);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(670, 79);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // nudId
            // 
            nudId.Location = new Point(130, 18);
            nudId.Name = "nudId";
            nudId.Size = new Size(122, 23);
            nudId.TabIndex = 9;
            nudId.Validating += nudId_Validating;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(104, 20);
            labelID.Name = "labelID";
            labelID.Size = new Size(18, 15);
            labelID.TabIndex = 10;
            labelID.Text = "ID";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(69, 49);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 11;
            labelNombre.Text = "Nombre";
            // 
            // labelCedula
            // 
            labelCedula.AutoSize = true;
            labelCedula.Location = new Point(77, 79);
            labelCedula.Name = "labelCedula";
            labelCedula.Size = new Size(44, 15);
            labelCedula.TabIndex = 12;
            labelCedula.Text = "Cedula";
            // 
            // labelMonto
            // 
            labelMonto.AutoSize = true;
            labelMonto.Location = new Point(80, 106);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(43, 15);
            labelMonto.TabIndex = 13;
            labelMonto.Text = "Monto";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(61, 136);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(58, 15);
            labelCategoria.TabIndex = 14;
            labelCategoria.Text = "Categoria";
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(61, 214);
            dgvDatos.Margin = new Padding(3, 2, 3, 2);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(691, 162);
            dgvDatos.TabIndex = 15;
            dgvDatos.SelectionChanged += dgvDatos_SelectionChanged;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(670, 107);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(82, 22);
            btnActualizar.TabIndex = 16;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(78, 164);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(43, 15);
            labelCorreo.TabIndex = 17;
            labelCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(131, 161);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(121, 23);
            txtCorreo.TabIndex = 18;
            txtCorreo.Validating += txtCorreo_Validating;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbSra);
            groupBox1.Controls.Add(rbSr);
            groupBox1.Location = new Point(259, 18);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(122, 64);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Género";
            // 
            // rbSra
            // 
            rbSra.AutoSize = true;
            rbSra.Location = new Point(57, 38);
            rbSra.Margin = new Padding(3, 2, 3, 2);
            rbSra.Name = "rbSra";
            rbSra.Size = new Size(44, 19);
            rbSra.TabIndex = 1;
            rbSra.TabStop = true;
            rbSra.Text = "Sra.";
            rbSra.UseVisualStyleBackColor = true;
            // 
            // rbSr
            // 
            rbSr.AutoSize = true;
            rbSr.Location = new Point(57, 16);
            rbSr.Margin = new Padding(3, 2, 3, 2);
            rbSr.Name = "rbSr";
            rbSr.Size = new Size(38, 19);
            rbSr.TabIndex = 0;
            rbSr.TabStop = true;
            rbSr.Text = "Sr.";
            rbSr.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkInteres3);
            groupBox2.Controls.Add(chkInteres2);
            groupBox2.Controls.Add(chkInteres1);
            groupBox2.Location = new Point(259, 92);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(150, 90);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Intereses";
            // 
            // chkInteres3
            // 
            chkInteres3.AutoSize = true;
            chkInteres3.Location = new Point(61, 62);
            chkInteres3.Margin = new Padding(3, 2, 3, 2);
            chkInteres3.Name = "chkInteres3";
            chkInteres3.Size = new Size(74, 19);
            chkInteres3.TabIndex = 2;
            chkInteres3.Text = "Compras";
            chkInteres3.UseVisualStyleBackColor = true;
            // 
            // chkInteres2
            // 
            chkInteres2.AutoSize = true;
            chkInteres2.Location = new Point(61, 40);
            chkInteres2.Margin = new Padding(3, 2, 3, 2);
            chkInteres2.Name = "chkInteres2";
            chkInteres2.Size = new Size(54, 19);
            chkInteres2.TabIndex = 1;
            chkInteres2.Text = "Playa";
            chkInteres2.UseVisualStyleBackColor = true;
            // 
            // chkInteres1
            // 
            chkInteres1.AutoSize = true;
            chkInteres1.Location = new Point(61, 17);
            chkInteres1.Margin = new Padding(3, 2, 3, 2);
            chkInteres1.Name = "chkInteres1";
            chkInteres1.Size = new Size(74, 19);
            chkInteres1.TabIndex = 0;
            chkInteres1.Text = "Montaña";
            chkInteres1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 403);
            Controls.Add(groupBox2);
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private GroupBox groupBox2;
        private CheckBox chkInteres2;
        private CheckBox chkInteres1;
        private CheckBox chkInteres3;
    }
}
