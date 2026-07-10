using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoRegistroCivil
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nombres = txtNombres.Text;
            usuario.NombreUsuario = txtUsuario.Text;
            usuario.Contrasena = txtContrasena.Text;
            usuario.TipoUsuario = cmbTipo.Text;
            Form1.listaUsuarios.Add(usuario);
            MessageBox.Show("Usuario registrado correctamente.");
            this.Close();
        }
    }
}
