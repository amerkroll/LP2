using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectodeAula2021.Clases
{
    public class Cola
    {   //Atributos
        int frente = 0;
        int final = 0;
        int MAX = 5;
        int[] cola;

        public Cola()  //Constructor
        {
            cola = new int[MAX];
        }
        //Metodos
        public void imprimir_cola()
        {
            foreach (int i in cola)
            {
                Console.WriteLine($"{i}");
            }
        }
        public void inserta_cola (int dato)
        {
            if (final < MAX)
            {
                final++;
                cola[final] = dato;
                if (final == 1)
                    frente = 1;
            }
            else
                Console.WriteLine("Desbordamiento cola llena");
        }
        public void eliminar_cola()
        {
            if (frente != 0)
            {
                if (frente == final)
                    frente = final = 0;
                else
                    frente++;
            }
            else
                Console.WriteLine("Cola vacia No se puede eliminar");
        }
    }
}
