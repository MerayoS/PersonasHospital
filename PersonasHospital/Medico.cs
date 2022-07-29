using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasHospital
{
    internal class Medico : Persona
    {
        private int numeroMedico;
        public int NumeroMedico { get => numeroMedico; set => numeroMedico = value; }

        public Medico(string Nombre, string Apellido, string Dni, int NumeroMedico) : base(Nombre, Apellido, Dni)
        {
            numeroMedico = NumeroMedico;
        }
   

        public override string ToString()
        {
            return "El medico de Nombre: " + Nombre + " " + Apellido + " le corresponde el numero de medico: "+ numeroMedico + " y el DNI: " + Dni + ".";
        }
    }
}
