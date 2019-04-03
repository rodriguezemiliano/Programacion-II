using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05
{
  public class Pluma
  {

    private string _marca;
    private Tinta _tinta;
    private int _cantidad;

    public Pluma() : this("sin marca", new Tinta(), 0)
    {
    }

    public Pluma(string marca, Tinta tinta, int cantidad):this(marca, cantidad)
    {
      this._tinta = tinta;
    }

    public Pluma(string marca, int cantidad):this(marca)
    {
      this._cantidad = cantidad;
    }

    public Pluma(string marca)
    {
      this._marca = marca;
    }

    private string Mostrar()
    {
      return this._marca.ToString() + ", " + Tinta.Mostrar(this._tinta) + ", " + this._cantidad.ToString();
    }

    public static bool operator == (Pluma pluma, Tinta tinta)
    {
      bool retorno = true;

      retorno = (pluma._tinta == tinta);

      return retorno;
    }
    public static bool operator !=(Pluma pluma, Tinta tinta)
    {
      return !(pluma == tinta);
    }

    public static implicit operator string (Pluma pluma)
    {
      return pluma.Mostrar();
    }

    public static Pluma operator + (Pluma pluma, Tinta tinta)
    {

      if(pluma == tinta)
      {
        if (pluma._cantidad < 100)
        {
          pluma._cantidad += 10;
        }
      }

      return pluma;
    }
  }
}
