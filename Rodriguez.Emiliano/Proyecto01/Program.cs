using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.Title = "Ejercicio 01";

            System.Console.WriteLine("Hola Mundo!");
            System.Console.ReadKey();

            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("{0}",nombre);
            System.Console.ReadKey();

        }
    }
}
