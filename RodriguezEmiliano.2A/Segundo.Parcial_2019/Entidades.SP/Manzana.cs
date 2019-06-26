using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
  public class Manzana : Fruta
  {
    protected string _provinciaOrigen;

    public string Nombre
    {
      get { return "Mansana"; }
    }

    public override bool TieneCarozo { get { return true; } }

    public Manzana (string color, double peso, string provinciaOrigen):base(color,peso)
    {
      this._provinciaOrigen = provinciaOrigen;
    }

    public override string ToString()
    {
      return this.Nombre+ " " + base.FrutaToString() + " " + this._provinciaOrigen + " " + this.TieneCarozo.ToString();
    }
  }
}
