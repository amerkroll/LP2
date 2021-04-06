using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectodeAula2021
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            Console.WriteLine("Hola Mundo");

            // Call the constructor that has one parameter.
            var person2 = new Persona();

            Console.WriteLine(person2.Nombre);   
            Console.WriteLine(person2.Apellido);
            Console.WriteLine(person2);
        }
    }
}
