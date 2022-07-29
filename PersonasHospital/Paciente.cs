using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasHospital
{
    class Paciente : Persona
    {
        private int numeroPaciente;
        private int numeroMedicoAsignado;

        public int NumeroPaciente { get => numeroPaciente; set => numeroPaciente = value; }
        public int NumeroMedicoAsignado { get => numeroMedicoAsignado; set => numeroMedicoAsignado = value; }

        public Paciente(string Nombre, string Apellido, string Dni, int NumeroPaciente, int NumeroMedicoAsignado) : base(Nombre, Apellido, Dni)
        {
            numeroPaciente = NumeroPaciente;
            numeroMedicoAsignado = NumeroMedicoAsignado;
        }
        
        public override string ToString()
        {
            return "El paciente de Nombre: " + Nombre + " " + Apellido + " es atendido por el medico numero: " + numeroMedicoAsignado + ", su DNI: " + Dni + " y su numero de paciente: " + numeroPaciente + ".";
        }
    }
}
