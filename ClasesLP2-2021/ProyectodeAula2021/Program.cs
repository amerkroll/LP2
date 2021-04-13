using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectodeAula2021.Clases;

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
            //Application.Run(new Login());

            Console.WriteLine("Hola Mundo");

            // Call the constructor that has one parameter.
            //var person2 = new Persona();

            //Console.WriteLine(person2.Nombre);   
            //Console.WriteLine(person2.Apellido);
            //Console.WriteLine(person2);
            ImprimirLista();
           
        }


        static void ImprimirLista()
        {
            string profe = "Andrea";
            List<string> listaAlumnos = new List<string>();

            listaAlumnos.Add("Augusto");
            listaAlumnos.Add("Meli");
            listaAlumnos.Add("Edgar");
            listaAlumnos.Add(profe);

            Console.WriteLine(listaAlumnos[1]);

            int contador = 0;
            foreach (string alumno in listaAlumnos)   // para cada elemento
            //for (indiceInicio; incremento; condicionStop (cantidad de elementos))
            //for (int i = 0; i < cantidad; i++ )
            {
                //Console.WriteLine(alumno);
                Console.WriteLine("Elemento #{" + contador.ToString() + "}--> " + alumno);
                contador++;
            }

        }
    }
}
