using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoRegistroCivil
{
    public class Personas
    {
        public List<Persona> Lista { get; set; }

        public Personas()
        {
            Lista = new List<Persona>();
        }

        public void Agregar(Persona persona)
        {
            Lista.Add(persona);
        }

        public Persona Buscar(string cedula)
        {
            Persona aux = new Persona();

            foreach (Persona persona in Lista)
            {
                if (persona.Cedula == cedula)
                {
                    aux = persona;
                }
            }

            return aux;
        }
        public Persona BuscarNombre(string nombre)
        {
            Persona personaEncontrada = new Persona();

            foreach (Persona persona in Lista)
            {
                if (persona.Nombres == nombre)
                {
                    personaEncontrada = persona;
                }
            }

            return personaEncontrada;
        }
        public void Eliminar(string cedula)
        {
            foreach (Persona persona in Lista)
            {
                if (persona.Cedula == cedula)
                {
                    Lista.Remove(persona);
                }
            }
        }
    }
}
