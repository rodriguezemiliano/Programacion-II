using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
  public class Cajon <T>
  {
    protected int _capacidad;
    protected List<T> _elementos;
    protected double _precioUnitario;

    public List<T> Elementos
    {
      get { return this._elementos; }
    }

    public double PrecioTotal
    {
      get { return this._elementos.Count * this._precioUnitario; }
    }

    public Cajon()
    {
      this._elementos = new List<T>();
    }
    public Cajon (int capacidad)
    {
      this._capacidad = capacidad;
    }
    public Cajon (double precioUnidad, int capacidad):this(capacidad)
    {
      this._precioUnitario = precioUnidad;
    }

    public override string ToString()
    {
      StringBuilder retorno = new StringBuilder();

      retorno.AppendLine(this._capacidad.ToString() + this._elementos.Count.ToString() + this.PrecioTotal.ToString());

      foreach (T item in this._elementos)
      {
        retorno.AppendLine(item.ToString());
      }

      return base.ToString();
    }

    public static Cajon<T> operator +(Cajon<T> cajon, T t)
    {
      if (cajon._capacidad > cajon._elementos.Count)
      {
        cajon._elementos.Add(t);
      }

      return cajon;
    }
  }
}
