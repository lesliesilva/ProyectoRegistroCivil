namespace ProyectoRegistroCivil
{
    partial class Form2
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
            lblNombres = new Label();
            lblUsuario = new Label();
            lblContrasena = new Label();
            txtNombres = new TextBox();
            txtUsuario = new TextBox();
            cmbTipo = new ComboBox();
            lblTipoUsua = new Label();
            txtContrasena = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            lblRegistro = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombres.Location = new Point(28, 67);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(94, 25);
            lblNombres.TabIndex = 0;
            lblNombres.Text = "Nombres:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(28, 116);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(82, 25);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContrasena.Location = new Point(26, 165);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(113, 25);
            lblContrasena.TabIndex = 2;
            lblContrasena.Text = "Contraseña:";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(187, 67);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(150, 31);
            txtNombres.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(187, 110);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 4;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Usuario", "Administrador" });
            cmbTipo.Location = new Point(185, 215);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(183, 33);
            cmbTipo.TabIndex = 5;
            // 
            // lblTipoUsua
            // 
            lblTipoUsua.AutoSize = true;
            lblTipoUsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoUsua.Location = new Point(26, 223);
            lblTipoUsua.Name = "lblTipoUsua";
            lblTipoUsua.Size = new Size(153, 25);
            lblTipoUsua.TabIndex = 6;
            lblTipoUsua.Text = "Tipo De Usuario:";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(187, 165);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(150, 31);
            txtContrasena.TabIndex = 7;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(168, 266);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(111, 33);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(28, 266);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 33);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRegistro.ForeColor = SystemColors.HotTrack;
            lblRegistro.Location = new Point(70, 22);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(343, 26);
            lblRegistro.TabIndex = 10;
            lblRegistro.Text = "REGISTRO DE USUARIOS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Fondo_R_C;
            pictureBox1.Location = new Point(-1733, 187);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Fondo_R_C;
            pictureBox2.Location = new Point(-10, 0);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(799, 450);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lblRegistro);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtContrasena);
            Controls.Add(lblTipoUsua);
            Controls.Add(cmbTipo);
            Controls.Add(txtUsuario);
            Controls.Add(txtNombres);
            Controls.Add(lblContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(lblNombres);
            Controls.Add(pictureBox2);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombres;
        private Label lblUsuario;
        private Label lblContrasena;
        private TextBox txtNombres;
        private TextBox txtUsuario;
        private ComboBox cmbTipo;
        private Label lblTipoUsua;
        private TextBox txtContrasena;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label lblRegistro;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}