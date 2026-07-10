namespace ProyectoRegistroCivil
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
            lblTitulo = new Label();
            lblContrasena = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnIngresar = new Button();
            lklRegistro = new LinkLabel();
            lblCuenta = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(309, 83);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(214, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SISTEMA REGISTRO CIVIL";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(219, 239);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(105, 25);
            lblContrasena.TabIndex = 1;
            lblContrasena.Text = "Contrasena:";
            lblContrasena.Click += lblContrasena_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(229, 162);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(76, 25);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(320, 162);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 3;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(320, 233);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(150, 31);
            txtContrasena.TabIndex = 4;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(320, 297);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(112, 34);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lklRegistro
            // 
            lklRegistro.AutoSize = true;
            lklRegistro.Location = new Point(409, 361);
            lklRegistro.Name = "lklRegistro";
            lklRegistro.Size = new Size(98, 25);
            lklRegistro.TabIndex = 6;
            lklRegistro.TabStop = true;
            lklRegistro.Text = "Registrarse";
            lklRegistro.LinkClicked += lklRegistro_LinkClicked;
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Location = new Point(209, 361);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(194, 25);
            lblCuenta.TabIndex = 7;
            lblCuenta.Text = "¿No tienes una cuenta?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCuenta);
            Controls.Add(lklRegistro);
            Controls.Add(btnIngresar);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(lblContrasena);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblContrasena;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnIngresar;
        private LinkLabel lklRegistro;
        private Label lblCuenta;
    }
}
