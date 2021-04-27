using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectodeAula2021.Clases
{
    public class Lista
    {
        String nombre;
        String apellido;
        int matricula;
        String carrera;

     
       // recorre_interativo();
       //  crea_inicio();

        public void setAtributos(string nombre, string apellido, int matricula, string carrera)
        {
            this.nombre = nombre;
            //this utilizamos para hacer referencia a el atributo nombre de esta clase Lista.
            this.apellido = apellido;
            this.matricula = matricula;
            this.carrera = carrera;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public String getApellido()
        {
            return this.apellido;
        }

        //string perro { get; set; }


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

                Console.WriteLine("Cantidad de elementos en la lista = " + listaAlumnos.Count().ToString());

                contador++;
            }
        }
    }
}
