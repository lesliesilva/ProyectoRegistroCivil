using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoRegistroCivil
{
    public class Usuario:Persona
    {
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string TipoUsuario { get; set; }
        public Usuario() { }
        public Usuario(string nombreUsuario, string contrasena, string tipoUsuario)
        {
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            TipoUsuario = tipoUsuario;
        }
        public string IniciarSesion(string usuario, string clave)
        {
            string aux = "";

            if (NombreUsuario == usuario && Contrasena == clave)
            {
                aux = "Ingreso correcto";
            }
            else
            {
                aux = "Usuario o contraseña incorrectos";
            }
            return aux;
        }
        public string MostrarUsuario()
        {
            string aux1 = "";
            aux1 = "Nombre: " + Nombres + "\nUsuario: " + NombreUsuario + "\nTipo: " + TipoUsuario;
            return aux1;
        }
    }
}
