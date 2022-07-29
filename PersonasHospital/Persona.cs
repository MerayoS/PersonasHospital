using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasHospital
{
    class Persona
    {
        private string nombre;
        private string apellido;
        private string dni;


        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }

        public Persona(string Nombre, string Apellido,string Dni)
        {
            nombre = Nombre;
            apellido = Apellido;
            dni = Dni;
        }

        public override string ToString()
        {
            return "A la persona de Nombre: " + nombre + " " + apellido + " le corresponde el DNI: " + dni + ".";
        }
    }
}
