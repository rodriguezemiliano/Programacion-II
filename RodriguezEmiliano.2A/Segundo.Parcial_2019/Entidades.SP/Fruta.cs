using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
  public abstract class Fruta
  {
    protected string _color;
    protected double _peso;

    public abstract bool TieneCarozo { get; }

    protected Fruta(string color, double peso)
    {
      _color = color;
      _peso = peso;
    }

    protected virtual string FrutaToString()
    {
      return this._color + " " + this._peso.ToString();
    }
  }
}
