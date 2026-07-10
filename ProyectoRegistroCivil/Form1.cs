using System.Collections.Generic;
namespace ProyectoRegistroCivil
{
    public partial class Form1 : Form
    {
        public static List<Usuario> listaUsuarios = new List<Usuario>();
        public Form1()
        {
            InitializeComponent();
            if (listaUsuarios.Count == 0)
            {
                listaUsuarios.Add(new Usuario("admin", "1234", "Administrador"));
            }
        }

        private void lblContrasena_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.NombreUsuario == txtUsuario.Text &&
                    usuario.Contrasena == txtContrasena.Text)
                {
                    MessageBox.Show("  Bienvenido " + usuario.Nombres);
                    if (usuario.TipoUsuario == "Administrador")
                    {
                        MessageBox.Show("Ingresó como Administrador");
                        Form3 frm = new Form3();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ingresó como Usuario");
                        Form4 frm = new Form4();
                        frm.Show();
                    }
                    return;
                }
            }
            MessageBox.Show("Usuario o contraseña incorrectos.");
        }

        private void lklRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 registro = new Form2();
            registro.Show();
        }
    }
}
