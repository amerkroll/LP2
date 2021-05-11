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

            //Console.WriteLine("Hola Mundo");

            // Call the constructor that has one parameter.
            //var person2 = new Persona();

            //Console.WriteLine(person2.Nombre);   
            //Console.WriteLine(person2.Apellido);
            //Console.WriteLine(person2);


            Lista objetoLista = new Lista();

            objetoLista.setAtributos("Mauro", "Gimenez");

            Console.WriteLine("El primer alumno de la clase es: " + objetoLista.getNombre());
            Console.WriteLine("Los demas atributos del objeto Mauro son: " + objetoLista.getApellido());

            objetoLista.Carrera = "Informatica"; //uso del set
            Console.WriteLine("La carrera de Mauro es: " + objetoLista.Carrera); //uso del get

            objetoLista.matricula = 4324; //uso del set
            Console.WriteLine("La matricula de Mauro es: " + objetoLista.matricula); //uso del get

            //ImprimirLista();
            ImprimirABB();
        }

        static void ImprimirLista()
        {
            string profe = "Andrea";
            List<string> listaAlumnos = new List<string>();

            listaAlumnos.Add("Augusto");
            listaAlumnos.Add("Meli");
            listaAlumnos.Add("Edgar");
            listaAlumnos.Add(profe);

            //Console.WriteLine(listaAlumnos[1]);

            int contador = 0;
            foreach (string alumno in listaAlumnos)   // para cada elemento
            //for (indiceInicio; incremento; condicionStop (cantidad de elementos))
            //for (int i = 0; i < cantidad; i++ )
            {
                //Console.WriteLine(alumno);
                Console.WriteLine("Elemento #{" + contador.ToString() + "}--> " + alumno);
                contador++;
            }

            Console.WriteLine("Cantidad de elementos en la lista =" + listaAlumnos.Count().ToString());

        }

        static void ImprimirABB()
        {
            ArbolBinarioOrdenado abo = new ArbolBinarioOrdenado ();
            abo.Insertar (100);
            abo.Insertar (50);
            abo.Insertar (25);
            abo.Insertar (75);
            abo.Insertar (150);
            Console.WriteLine ("Impresion preorden: ");
            abo.ImprimirPre ();
            Console.WriteLine ("Impresion entreorden: ");
            abo.ImprimirEntre ();
            Console.WriteLine ("Impresion postorden: ");
            abo.ImprimirPost ();
        }
    }
}
