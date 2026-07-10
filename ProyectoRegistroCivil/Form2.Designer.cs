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
            SuspendLayout();
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(116, 81);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(90, 25);
            lblNombres.TabIndex = 0;
            lblNombres.Text = "Nombres:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(130, 137);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(76, 25);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(116, 193);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(105, 25);
            lblContrasena.TabIndex = 2;
            lblContrasena.Text = "Contrasena:";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(263, 81);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(150, 31);
            txtNombres.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(263, 134);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 4;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Usuario", "Administrador" });
            cmbTipo.Location = new Point(263, 257);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(182, 33);
            cmbTipo.TabIndex = 5;
            // 
            // lblTipoUsua
            // 
            lblTipoUsua.AutoSize = true;
            lblTipoUsua.Location = new Point(103, 257);
            lblTipoUsua.Name = "lblTipoUsua";
            lblTipoUsua.Size = new Size(143, 25);
            lblTipoUsua.TabIndex = 6;
            lblTipoUsua.Text = "Tipo De Usuario:";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(263, 187);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(150, 31);
            txtContrasena.TabIndex = 7;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(371, 348);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(219, 348);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Location = new Point(263, 26);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(211, 25);
            lblRegistro.TabIndex = 10;
            lblRegistro.Text = "REGISTRO DE USUARIOS";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Form2";
            Text = "Form2";
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
    }
}