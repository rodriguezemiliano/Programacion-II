using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace Entidades.SP
{
    [XmlInclude(typeof(Fruta))]
    [XmlInclude(typeof(Manzana))]
    public class Manzana : Fruta , ISerializar
    {
        #region Atributos
        protected string _provinciaOrigen;
        #endregion

        #region PRopiedades
        public  string Nombre { get { return "Manzana"; } }
        public override bool TieneCarozo { get { return true; } }
        #endregion

        #region Construcrores
        public Manzana()
        {

        }
        public Manzana(string color, double peso, string provinciaOrigen ):base(color, peso)
        {
            this._provinciaOrigen = provinciaOrigen;
        }
        #endregion

        #region Metodos
        protected override string FrutaToString()
        {
            return base.FrutaToString() + string.Format("Nombre: {0} Provincia: {1} tiene carozo", this.Nombre, this._provinciaOrigen);
        }
        public override string ToString()
        {
            return this.FrutaToString();
        }

        public bool Xml(string archivo)
        {
            bool retorno = false;

            try
            {
                using (StreamWriter writer = new StreamWriter(archivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Manzana));
                    serializer.Serialize(writer, this);
                    retorno = true;
                }

            }
            catch (Exception e)
            {
                throw e;
            }

            return retorno;
        }


        #endregion
    }
}
