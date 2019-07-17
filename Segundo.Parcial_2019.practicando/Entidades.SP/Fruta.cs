using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
    [Serializable]
    public abstract class Fruta
    {
        #region Atributos
        protected string _color;
        protected double _peso;
        #endregion

        #region Propiedades
        public abstract bool TieneCarozo { get; }
        #endregion

        #region Constructores
        public Fruta()
        {

        }
        protected Fruta(string color, double peso)
        {
            this._color = color;
            this._peso = peso;
        }
        #endregion

        #region Metodos
        protected virtual string FrutaToString()
        {
            return string.Format("Color: {0} Peso: {1}", this._color, this._peso);
        }

       

        #endregion

    }
}
