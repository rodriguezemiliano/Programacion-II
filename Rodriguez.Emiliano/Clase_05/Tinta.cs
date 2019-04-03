using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05
{
  public class Tinta
  {
    private ConsoleColor _color;
    private ETipoTinta _eTipoTinta;

    public Tinta(ConsoleColor color, ETipoTinta eTipoTinta)
    {
      this._eTipoTinta = eTipoTinta;
      this._color = color;
    }

    public Tinta(ConsoleColor color):this(color, ETipoTinta.Comun)
    {
      
    }

    public Tinta():this(ConsoleColor.Black)
    {
      
    }

    private string Mostrar()
    {
      return _color.ToString() + _eTipoTinta.ToString();
    }

    public static string Mostrar(Tinta tinta)
    {
      return tinta.Mostrar();
    }

    public static bool operator == (Tinta tinta1 , Tinta tinta2)
    {
      bool retorno = false;

      retorno = (tinta1._color == tinta2._color && tinta1._eTipoTinta == tinta2._eTipoTinta);
      
      return retorno;
    }

    public static bool operator !=(Tinta tinta1, Tinta tinta2)
    {
      return !(tinta1 == tinta2);
    }
  }
}
