using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; //librería para dibujar figuras geométricas
using System.Linq;
using System.Text;
using System.Threading; //librería para manejo de hilos
using System.Windows.Forms;

namespace ProyectodeAula2021.Clases
{
    class Nodo_Arbol
    {
        public int info; //dato a almacenar en el nodo
        public Nodo_Arbol Izquierdo; //nodo izquierdo del árbol
        public Nodo_Arbol Derecho; //nodo derecho del árbol
        public Nodo_Arbol Padre; //nodo raíz del árbol
        public int altura;
        public int nivel;
        public Rectangle nodo; //para dibujar el nodo del árbol
        //Variable que definen el tamaño de los círculos que representan los nodos del árbol
        private const int Radio = 30;
        //Variable para el manejo de distancia horizontal
        private const int DistanciaH = 80;
        //variable para el manejo de distancia vertical
        private const int DistanciaV = 10;
        //variable para manejar posición eje X
        private int CoordenadaX;
        //variable para manejar posición eje Y
        private int CoordenadaY;
        Graphics col;
        private Nodo_Arbol arbol; //declarando un objeto de tipo árbol

        public Nodo_Arbol() //constructor por defecto
        {
        }

        //constructor por defecto para el objeto de tipo árbol
        public Nodo_Arbol Arbol
        {
            get
            { return arbol; }
            set
            { arbol = value; }
        }

        //constructor con parámetros
        public Nodo_Arbol(int nueva_info, Nodo_Arbol izquierdo, Nodo_Arbol derecho, Nodo_Arbol padre)
        {
            info = nueva_info;
            Izquierdo = izquierdo;
            Derecho = derecho;
            Padre = padre;
            altura = 0;
        }

        //función para insertar un nodo en el árbol
        public Nodo_Arbol Insertar(int x, Nodo_Arbol t, int Level)
        {
            if (t == null)
            {
                t = new Nodo_Arbol(x, null, null, null);
                t.nivel = Level;
            }
            else if (x < t.info) //si el valor a insertar es menor que la raíz
            {
                Level++;
                t.Izquierdo = Insertar(x, t.Izquierdo, Level);
            }
            else if (x > t.info) //si el valor a insertar es mayor que la raíz
            {
                Level++;
                t.Derecho = Insertar(x, t.Derecho, Level);
            }
            else
            {
                MessageBox.Show("Dato existente en el Arbol", "Error de Ingreso");
            }
            return t;
        }

        //Función buscar un nodo
        public void buscar(int x, Nodo_Arbol t)
        {
            if (t != null)
            {
                if (x == t.info)
                {
                    MessageBox.Show("Nodo encontrado en la posición X: " + t.CoordenadaX + " Y:" + t.CoordenadaY);
                    //encontrado(t);
                }
                else
                {
                    if (x < t.info) //búsqueda en el subárbol izquierdo
                    {
                        buscar(x, t.Izquierdo);
                    }
                    else
                    {
                        if (x > t.info) //búsqueda en el subárbol derecho
                        {
                            buscar(x, t.Derecho);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nodo NO encontrado", "Error de búsqueda");
            }
        }
    }
}
            
