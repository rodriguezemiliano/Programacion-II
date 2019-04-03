using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {

            int max = 0, min = 0 , aux = 0;
            float promedio = 0; 
            Boolean flag = true;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero");
                
                aux = int.Parse(Console.ReadLine());
                promedio += aux;
                
                if(flag)
                {
                    max = aux;
                    min = aux;
                    flag = false;
                }

                if (aux > max)
                {
                    max = aux;
                }
                if (aux < min)
                {
                    min = aux;
                }
            }

            Console.WriteLine("Maximo: {0}",max);
            Console.WriteLine("Minimo: {0}", min);
            Console.WriteLine("Promedio: {0:0.000}", promedio/5);
            Console.ReadKey();

        }
    }
}
