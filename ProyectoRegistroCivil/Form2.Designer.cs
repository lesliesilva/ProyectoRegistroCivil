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
            lblNombres.Location = new Point(81, 49);
            lblNombres.Margin = new Padding(2, 0, 2, 0);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(59, 15);
            lblNombres.TabIndex = 0;
            lblNombres.Text = "Nombres:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(91, 82);
            lblUsuario.Margin = new Padding(2, 0, 2, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(81, 116);
            lblContrasena.Margin = new Padding(2, 0, 2, 0);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(70, 15);
            lblContrasena.TabIndex = 2;
            lblContrasena.Text = "Contrasena:";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(184, 49);
            txtNombres.Margin = new Padding(2, 2, 2, 2);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(106, 23);
            txtNombres.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(184, 80);
            txtUsuario.Margin = new Padding(2, 2, 2, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(106, 23);
            txtUsuario.TabIndex = 4;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Usuario", "Administrador" });
            cmbTipo.Location = new Point(184, 154);
            cmbTipo.Margin = new Padding(2, 2, 2, 2);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(129, 23);
            cmbTipo.TabIndex = 5;
            // 
            // lblTipoUsua
            // 
            lblTipoUsua.AutoSize = true;
            lblTipoUsua.Location = new Point(72, 154);
            lblTipoUsua.Margin = new Padding(2, 0, 2, 0);
            lblTipoUsua.Name = "lblTipoUsua";
            lblTipoUsua.Size = new Size(93, 15);
            lblTipoUsua.TabIndex = 6;
            lblTipoUsua.Text = "Tipo De Usuario:";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(184, 112);
            txtContrasena.Margin = new Padding(2, 2, 2, 2);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(106, 23);
            txtContrasena.TabIndex = 7;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(260, 209);
            btnGuardar.Margin = new Padding(2, 2, 2, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(78, 20);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(153, 209);
            btnCancelar.Margin = new Padding(2, 2, 2, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 20);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Location = new Point(184, 16);
            lblRegistro.Margin = new Padding(2, 0, 2, 0);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(134, 15);
            lblRegistro.TabIndex = 10;
            lblRegistro.Text = "REGISTRO DE USUARIOS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Fondo_R_C;
            pictureBox1.Location = new Point(-1213, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Fondo_R_C;
            pictureBox2.Location = new Point(2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(558, 270);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
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
            Margin = new Padding(2, 2, 2, 2);
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