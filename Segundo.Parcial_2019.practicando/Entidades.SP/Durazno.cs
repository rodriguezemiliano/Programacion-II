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
    public class Durazno : Fruta
    {
        #region Atributos
        protected int _cantiPelusa;
        #endregion

        #region PRopiedades
        public override bool TieneCarozo { get { return true; } }
        public string Nombre { get { return "Durazno"; } }
        #endregion

        #region Constructores
        public Durazno()
        {

        }
        public Durazno(string color, double peso, int cantPelusa) : base(color, peso)
        {
            this._cantiPelusa = cantPelusa;
        }
        #endregion
        #region MEtodos
        protected override string FrutaToString()
        {
            return base.FrutaToString() + string.Format("Nombre: {0} Cant. Pelusa: {1} tiene carozo", this.Nombre, this._cantiPelusa);
        }
        public override string ToString()
        {
            return this.FrutaToString();
        }
        #endregion
    }
}
