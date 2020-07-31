using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main()
        {
            var list = new ListaNodo();
            list.ListaVacia();
            list.addNodo(1);
            list.addNodo(3);
            list.addNodo(2);
            list.addNodo(4);
            list.Listar();
            list.Sustituir(3,6);
            Console.WriteLine(list.Size());
            list.Listar();
            Console.ReadKey();

            //asdasds
        }
    }
}
