using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_enClase
{
  
  class Program
  {
    static void Main(string[] args)
    {
      Sello.mensaje = "Hola este es un msj";
      Sello.color = ConsoleColor.Blue;
      Sello.ImprimirEnColor();

      Sello.mensaje = "este es otro msj en verde";
      Sello.color = ConsoleColor.Green;
      Sello.ImprimirEnColor();

      Sello.mensaje = "vuelvo a escribir en gris";
      Sello.color = ConsoleColor.Gray;
      Sello.ImprimirEnColor();

      Sello.Borrar();
      Console.WriteLine(Sello.Imprimir());
      Console.ReadKey();
    }
  }
}
