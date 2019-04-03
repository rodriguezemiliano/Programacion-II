using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_enClase
{
  class Sello
  {
    //Atributos
    public static string mensaje;
    public static ConsoleColor color;

    //Metodos
    public static string Imprimir()
    {
      return Sello.mensaje = ArmarFormatoMensaje();
    }
    public static void ImprimirEnColor()
    {
      Console.ForegroundColor = Sello.color;
      Console.WriteLine(Sello.Imprimir());
      Console.ForegroundColor = ConsoleColor.Gray;
    }
    public static void Borrar()
    {
      Sello.mensaje = "";
    }

    private static string ArmarFormatoMensaje()
    {
      string auxMensaje = "";

        for (int j = mensaje.Length + 1 ; j >=0 ; j--)
        {
          auxMensaje += "*";
          
        }

      auxMensaje += "\n*" + Sello.mensaje + "*\n" + auxMensaje;

      return auxMensaje;
    }
  }
}
