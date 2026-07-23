namespace ProyectoRegistroCivil
{
    partial class Form4
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
            groupBox1 = new GroupBox();
            txtDescripcion = new TextBox();
            cmbTipo = new ComboBox();
            cmbEstado = new ComboBox();
            txtFecha = new TextBox();
            txtNumero = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnRegistrar = new Button();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            dgvTramites = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTramites).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(cmbTipo);
            groupBox1.Controls.Add(cmbEstado);
            groupBox1.Controls.Add(txtFecha);
            groupBox1.Controls.Add(txtNumero);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(74, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(578, 340);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del trámite";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(228, 248);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(186, 74);
            txtDescripcion.TabIndex = 9;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Cédula", "Pasaporte", "Partida de nacimiento", "Cambio de domicilio" });
            cmbTipo.Location = new Point(228, 97);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(150, 33);
            cmbTipo.TabIndex = 8;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Pendiente", "", "En proceso", "", "Finalizado" });
            cmbEstado.Location = new Point(228, 194);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(150, 33);
            cmbEstado.TabIndex = 7;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(228, 141);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(150, 31);
            txtFecha.TabIndex = 6;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(228, 46);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(150, 31);
            txtNumero.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 248);
            label6.Name = "label6";
            label6.Size = new Size(108, 25);
            label6.TabIndex = 4;
            label6.Text = "Descripción:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 194);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 3;
            label5.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 144);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 2;
            label4.Text = "Fecha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 97);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 1;
            label3.Text = "Tipo de trámite:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 52);
            label2.Name = "label2";
            label2.Size = new Size(167, 25);
            label2.TabIndex = 0;
            label2.Text = "Número de trámite:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 21);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 1;
            label1.Text = "GESTIÓN DE TRÁMITES  ";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(91, 438);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(238, 438);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(392, 438);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(540, 438);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(112, 34);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // dgvTramites
            // 
            dgvTramites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTramites.Location = new Point(197, 492);
            dgvTramites.Name = "dgvTramites";
            dgvTramites.RowHeadersWidth = 62;
            dgvTramites.Size = new Size(360, 152);
            dgvTramites.TabIndex = 6;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 666);
            Controls.Add(dgvTramites);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(btnRegistrar);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form4";
            Text = "Form4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTramites).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbTipo;
        private ComboBox cmbEstado;
        private TextBox txtFecha;
        private TextBox txtNumero;
        private TextBox txtDescripcion;
        private Button btnRegistrar;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private DataGridView dgvTramites;
    }
}