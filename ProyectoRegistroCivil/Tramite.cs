using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoRegistroCivil
{
    public class Tramite
    {
        public int NumeroTramite { get; set; }
        public string TipoTramite { get; set; }
        public string Fecha { get; set; }
        public string Estado { get; set; }
        public string Descripcion { get; set; }
        public Tramite() { }
        public Tramite(int numeroTramite, string tipoTramite, string fecha, string estado, string descripcion)
        {
            NumeroTramite = numeroTramite;
            TipoTramite = tipoTramite;
            Fecha = fecha;
            Estado = estado;
            Descripcion = descripcion;
        }
        public string MostrarTramite()
        {
            string aux = "";
            aux = "Número de trámite: " + NumeroTramite + "\nTipo de trámite: " + TipoTramite + "\nFecha: " + Fecha +
                  "\nEstado: " + Estado + "\nDescripción: " + Descripcion;
            return aux;
        }
        public string CambiarEstado(string nuevoEstado)
        {
            string aux = "";

            Estado = nuevoEstado;

            aux = "Estado actualizado correctamente.";

            return aux;
        }
        public string RegistrarTramite()
        {
            string aux = "";

            if (TipoTramite == "" || Fecha == "")
            {
                aux = "Complete los datos del trámite.";
            }
            else
            {
                aux = "Trámite registrado correctamente.";
            }
            return aux;
        }
    }
}
