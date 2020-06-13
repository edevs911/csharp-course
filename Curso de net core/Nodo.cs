using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_de_net_core
{
    public class Nodo
    {
        public int dato;
        public Nodo siguiente;
        public Nodo(int dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }
    }
}
