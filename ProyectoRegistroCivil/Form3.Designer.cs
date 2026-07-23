namespace ProyectoRegistroCivil
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            dgvUsuarios = new DataGridView();
            groupBox1 = new GroupBox();
            btnCerrarSesion = new Button();
            btnGuardarCambios = new Button();
            cmbTipo = new ComboBox();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            txtNombres = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(134, 74);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 36);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 23);
            label2.Name = "label2";
            label2.Size = new Size(292, 25);
            label2.TabIndex = 1;
            label2.Text = "ADMINISTRACIÓN REGISTRO CIVIL";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(75, 78);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(112, 34);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(242, 78);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(420, 78);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(589, 78);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 34);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 147);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 6;
            label3.Text = "Buscar Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 56);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 7;
            label4.Text = "Nombres:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 212);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 8;
            label5.Text = "Contraseña:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 137);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 9;
            label6.Text = "Usuario:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 280);
            label7.Name = "label7";
            label7.Size = new Size(141, 25);
            label7.TabIndex = 10;
            label7.Text = "Tipo de Usuario:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(204, 147);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(150, 31);
            txtBuscar.TabIndex = 11;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(420, 147);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(219, 210);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.Size = new Size(360, 127);
            dgvUsuarios.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCerrarSesion);
            groupBox1.Controls.Add(btnGuardarCambios);
            groupBox1.Controls.Add(cmbTipo);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(txtContrasena);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(91, 358);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 415);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del Usuario";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(317, 359);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(153, 34);
            btnCerrarSesion.TabIndex = 16;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(111, 359);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(162, 34);
            btnGuardarCambios.TabIndex = 15;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Administrador" });
            cmbTipo.Location = new Point(153, 280);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(182, 33);
            cmbTipo.TabIndex = 14;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(141, 137);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 13;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(141, 206);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(150, 31);
            txtContrasena.TabIndex = 12;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(141, 56);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(150, 31);
            txtNombres.TabIndex = 11;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 798);
            Controls.Add(groupBox1);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label3);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private DataGridView dgvUsuarios;
        private GroupBox groupBox1;
        private TextBox txtContrasena;
        private TextBox txtNombres;
        private ComboBox cmbTipo;
        private TextBox txtUsuario;
        private Button btnCerrarSesion;
        private Button btnGuardarCambios;
    }
}