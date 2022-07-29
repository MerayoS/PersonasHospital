using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonasHospital
{
    class Hospital
    {
        public static List<Persona> PersonasDelHospital = new List<Persona>();

        public static void RellenarLista()
        {
            var usedDni = new HashSet<int>();
            Random rName = new Random();
            List<string> Nombres = new List<string>();
            Nombres.AddRange(new string[] { "Pedro", "Pepito", "Jose", "Marta", "Monica", "Mercedes", "Carlos", "Juan", "juana" });

            Random rSurname = new Random();
            List<string> Apellidos = new List<string>();
            Apellidos.AddRange(new string[] { "Gomez", "Perez", "Garcia", "Rodriguez", "Gimenez", "Sanchez", "Gonzales", "Muños" });

            Random rDni = new Random();
             List<string> Dnis = new List<string>();
            Dnis.AddRange(new string[] { "123456789F", "456789126Q", "456159723P", "152356649W", "538426973K", "106359080G", "527810654M", "569142003V", "111111111J" });

            for (int n = 0; n < 6; n++)
            {
                int nombre = rName.Next(0, 9);
                int apellido = rSurname.Next(0, 8);
                int dni;
                do
                {
                    dni = rDni.Next(0, 9);
                }
                while (usedDni.Contains(dni));
                usedDni.Add(dni);
                Persona p = new Persona(Nombres[nombre], Apellidos[apellido], Dnis[dni]);
                PersonasDelHospital.Add(p);
            }

            //Se añaden los medicos fijos
            Medico m = new Medico("Carlos", "Oliva", "12547869L", 3328);
            Medico m2 = new Medico("Pablo", "Marmol", "56237595P", 2257);

            PersonasDelHospital.Add(m);
            PersonasDelHospital.Add(m2);

            //Se añaden los pacientes fijos
            Paciente pa = new Paciente("Cristian", "Morales", "45123265G", 102, 3328);
            Paciente pa2 = new Paciente("Cristina", "Jueves", "90507030M", 38, 3328);
            Paciente pa3 = new Paciente("Marta", "Galan", "66633396M", 99, 3328);
            Paciente pa4 = new Paciente("Sofia", "Esteban", "52525252K", 3, 2257);

            PersonasDelHospital.Add(pa);
            PersonasDelHospital.Add(pa2);
            PersonasDelHospital.Add(pa3);
            PersonasDelHospital.Add(pa4);


        }
        public static void MostrarListaDebug()
        {
            foreach(Persona p in PersonasDelHospital)
            {
                Debug.WriteLine(p.ToString());
            }
        }
        public static void MostrarLista(ListBox listBoxPersonas)
        {
            foreach(Persona p in PersonasDelHospital)
            {
                listBoxPersonas.Items.Add(p);
            }
        }
    }
}
