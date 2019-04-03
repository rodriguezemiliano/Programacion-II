using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
  class Boligrafo
  {
    static short cantidadTintaMaxima = 100;
    private ConsoleColor color;
    private short tinta;
        
    public Boligrafo(short tinta, ConsoleColor color)
    {
      this.color = color;
      this.tinta = tinta;
    }
    public ConsoleColor GetColor()
    {
      return this.color;
    }
    
    public short GetTinta()
    {
      return this.tinta;
    }

    private void SetTinta(short tinta)
    {
      if (this.tinta < cantidadTintaMaxima)
      {
        if(tinta >= cantidadTintaMaxima)
        {
          this.tinta = cantidadTintaMaxima;
        }
        else
        {
          if(this.tinta + tinta > cantidadTintaMaxima)
          {
            this.tinta = cantidadTintaMaxima;
          }
          else
          {
            this.tinta += tinta;
          }
              
        }
        
      }

      if (tinta <= -100)
      {
        this.tinta = 0;
      }
      else
      {
        if (this.tinta + tinta < 0)
        {
          this.tinta = 0;
        }
        else
        {
          this.tinta += tinta;
        }
      }
    }

    public void Recargar()
    {
      SetTinta(cantidadTintaMaxima);
    }

    public bool 
  }
}
