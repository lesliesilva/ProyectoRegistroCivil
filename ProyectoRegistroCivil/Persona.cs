using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoRegistroCivil
{
    public class Persona
    {
        public string Cedula;
        public string Nombres;
        public string Apellidos;
        public string Provincia;
        public string Genero;
        public string FechaNacimiento;
        public Persona() { }
        public Persona(string cedula, string nombres, string apellidos, string provincia,
            string genero, string fechaNacimiento)

        {
            Cedula = cedula;
            Nombres = nombres;
            Apellidos = apellidos;
            Provincia = provincia;
            Genero = genero;
            FechaNacimiento = fechaNacimiento;
        }
        public string NombreCompleto()
        {
            return Nombres + " " + Apellidos;
        }
        public string MostrarDatos()
        {
            return "Cédula: " + Cedula + "\nNombres: " + Nombres + "\nApellidos: " + Apellidos + "\nProvincia: " + Provincia +
             "\nGénero: " + Genero + "\nFecha de nacimiento: " + FechaNacimiento;
        }
    }
}
