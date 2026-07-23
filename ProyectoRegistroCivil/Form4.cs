using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoRegistroCivil
{
    public partial class Form4 : Form
    {
        List<Tramite> listaTramites = new List<Tramite>();

        public Form4()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Tramite tramite = new Tramite();

            tramite.NumeroTramite = Convert.ToInt16(txtNumero.Text);
            tramite.TipoTramite = cmbTipo.Text;
            tramite.Fecha = txtFecha.Text;
            tramite.Estado = cmbEstado.Text;
            tramite.Descripcion = txtDescripcion.Text;

            listaTramites.Add(tramite);

            dgvTramites.DataSource = null;
            dgvTramites.DataSource = listaTramites;

            MessageBox.Show("Trámite registrado correctamente");

            Limpiar();
        }


        private void Limpiar()
        {
            txtNumero.Clear();
            cmbTipo.SelectedIndex = -1;
            txtFecha.Clear();
            cmbEstado.SelectedIndex = -1;
            txtDescripcion.Clear();
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string tipo = cmbTipo.Text;
            string estado = cmbEstado.Text;

            List<Tramite> resultado = new List<Tramite>();

            bool encontrado = false;

            foreach (Tramite tramite in listaTramites)
            {
                MessageBox.Show(tramite.TipoTramite + " - " + tramite.Estado);

                if (tramite.TipoTramite == tipo && tramite.Estado == estado)
                {
                    resultado.Add(tramite);
                    encontrado = true;
                }
            }

            dgvTramites.DataSource = null;
            dgvTramites.DataSource = resultado;

            if (encontrado)
            {
                MessageBox.Show("Trámite encontrado");
            }
            else
            {
                MessageBox.Show("No se encontró ningún trámite");
            }
        }
    }
}