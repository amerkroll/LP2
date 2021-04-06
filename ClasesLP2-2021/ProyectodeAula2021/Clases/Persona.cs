using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectodeAula2021
{
    public class Persona
    {
        int ci = 0;
        int edad = 18;
        string estadoCivil = "soltero";


        // Constructor that takes no arguments:
        public Persona()
        {
            Nombre = "SIN NOMBRE";
            Apellido = "NO DEFINIDO";
        }

        // Auto-implemented readonly property:
        public string Nombre { get; set; }

        // Auto-implemented readonly property:
        public string Apellido { get; set; }

    }
}
