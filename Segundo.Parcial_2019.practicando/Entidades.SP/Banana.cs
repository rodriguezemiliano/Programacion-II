using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
namespace Entidades.SP
{
    [XmlInclude(typeof(Fruta))]
    [XmlInclude(typeof(Durazno))]
    public class Banana : Fruta
    {
        #region Atributos
        protected string _paisOrigen;
        #endregion
        #region Propiedades
        public string Nombre { get { return "Banana"; } }
        public override bool TieneCarozo { get { return false; } }
        #endregion

        #region Constructores
        public Banana()
        {

        }
        public Banana(string color, double peso, string paisOrigen) : base(color, peso)
        {
            this._paisOrigen = paisOrigen;
        }
        #endregion

        #region Metodos
        protected override string FrutaToString()
        {
            return base.FrutaToString() + string.Format("Nombre: {0} Pais: {1} no tiene carozo", this.Nombre, this._paisOrigen);
        }
        public override string ToString()
        {
            return this.FrutaToString();
        }
        #endregion
    }
}
