using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectodeAula2021.Clases
{
    public class Lista
    {

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
                Console.WriteLine("Elemento #{"+contador+"}--> "+alumno);
                contador++;
            }

        }
    }
}
