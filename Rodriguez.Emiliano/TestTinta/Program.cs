using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_05;


namespace TestTinta
{
  class Program
  {
    static void Main(string[] args)
    {
      Tinta tinta1 = new Tinta();
      Console.WriteLine(Tinta.Mostrar(tinta1));

      Tinta tinta2 = new Tinta(ConsoleColor.DarkBlue);
      Console.WriteLine(Tinta.Mostrar(tinta2));

      Tinta tinta3 = new Tinta(ConsoleColor.DarkRed, ETipoTinta.China);
      Console.WriteLine(Tinta.Mostrar(tinta3));

      Pluma pluma1 = new Pluma("bic",tinta3, 20);

      Pluma pluma2 = pluma1 + tinta3;


      Console.ReadKey();
    }
  }
}
