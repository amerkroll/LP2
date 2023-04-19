using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectodeAula2021.Clases
{
    internal class Pila
    {  //Atributos
        int tope = 0;
        int MAX = 5;
        int[] pila = new int[5];
        //Métodos

        public Pila()
        {
            tope = 0;
            pila = new int[MAX];
        }

        public bool PilaVacia()
        {
            if (tope == 0)
                return true;
            else
                return false;
        }
        public bool PilaLlena()
        {
            if (tope == MAX)
                return true;
            else
                return false;
        }

        public void Push(int dato)
        {
            if (PilaLlena())
                Console.WriteLine("La pila ya esta llena");
            else
            {
                Console.WriteLine("EL elemento fue insertado correctamente");
                tope++;
                pila[tope] = dato;
            }
        }

        public void Delete()
        {
            if (PilaVacia())
                Console.WriteLine("La pila esta vacia, No se puede eliminar elementos");
            else
            {
                tope--;
                Console.WriteLine("Se elimina el elemento " + pila[tope].ToString());
            }
                
        }

    }
}
