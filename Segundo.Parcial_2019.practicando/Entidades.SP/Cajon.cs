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
    [Serializable]
    public  class Cajon<T> : ISerializar, IDeserializar
    {
        #region Atributos
        protected int _capacidad;
        protected List<T> _elementos;
        protected double _precioUnitario;
        #endregion

        #region Atributos
        public List<T> Elementos { get { return this._elementos; } }
        public double PrecioTotal { get { return this._elementos.Count * this._precioUnitario; } }
        #endregion

        #region Constructores
        public Cajon()
        {
            this._elementos = new List<T>();
        }

        public Cajon(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public Cajon(double precioUnitario, int capacidad) : this(capacidad)
        {
            this._precioUnitario = precioUnitario;
        }
        #endregion

        #region MEtodos
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("Capacidad: {0} Cantidad Total: {1} Precio Total: {2}", this._capacidad, this._elementos.Count, this.PrecioTotal);

            foreach (T item in this._elementos)
            {
                retorno.AppendLine(item.ToString());
            }
            return retorno.ToString();
        }

        public bool Xml(string archivo)
        {
            bool retorno = false;

            try
            {
                using (StreamWriter writer = new StreamWriter(archivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Cajon<T>));
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

        bool IDeserializar.Xml(string archivo, out Fruta fruta)
        {
            bool retorno = false;

            try
            {
                using (StreamReader reader = new StreamReader(archivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Cajon<T>));
                    fruta = (Fruta) serializer.Deserialize(reader);
                    retorno = true;
                }


            }
            catch (Exception e)
            {
                throw e;
            }


            return retorno;
        }

        /*public static int EliminarFruta(this int id)
        {
            return 0;
        }*/
        #endregion

        #region Operadores
        public static Cajon<T> operator +(Cajon<T> cajon, T fruta)
        {
            if (cajon.Elementos.Count < cajon._capacidad)
            {
                cajon.Elementos.Add(fruta);
            }
            else
            {
                throw new CajonLlenoException("El Cajon esta lleno");
            }
            return cajon;
        }
        #endregion

    }
}
