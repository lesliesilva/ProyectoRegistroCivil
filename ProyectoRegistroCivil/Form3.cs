using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoRegistroCivil
{
    public partial class Form3 : Form
    {
        Usuario usuarioSeleccionado;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
            foreach (Usuario usuario in Form1.listaUsuarios)
            {
                if (usuario.NombreUsuario == txtBuscar.Text)
                {
                    usuarioSeleccionado = usuario;
                    txtNombres.Text = usuario.Nombres;
                    txtUsuario.Text = usuario.NombreUsuario;
                    txtContrasena.Text = usuario.Contrasena;
                    cmbTipo.Text = usuario.TipoUsuario;

                    MessageBox.Show("Usuario encontrado.");
                    return;
                }
            }
            MessageBox.Show("Usuario no encontrado.");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionado != null)
            {
                usuarioSeleccionado.Nombres = txtNombres.Text;
                usuarioSeleccionado.NombreUsuario = txtUsuario.Text;
                usuarioSeleccionado.Contrasena = txtContrasena.Text;
                usuarioSeleccionado.TipoUsuario = cmbTipo.Text;
                CargarUsuarios();
                MessageBox.Show("Datos modificados correctamente.");
            }
            else
            {
                MessageBox.Show("Primero busque un usuario.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.listaUsuarios.Count; i++)
            {
                if (Form1.listaUsuarios[i].NombreUsuario == txtBuscar.Text)
                {
                    Form1.listaUsuarios.RemoveAt(i);
                    CargarUsuarios();
                    MessageBox.Show("Usuario eliminado correctamente.");
                    return;
                }
            }
            MessageBox.Show("Usuario no encontrado.");
        }
        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = Form1.listaUsuarios;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
