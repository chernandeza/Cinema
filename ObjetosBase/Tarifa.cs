using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosBase
{
    public class Tarifa
    {
        private int _precioNormal;

        public int Normal
        {
            get { return _precioNormal; }
            set { _precioNormal = value; }
        }

        private int _precioNino;

        public int Nino
        {
            get { return _precioNino; }
            set { _precioNino = value; }
        }

        private int _precioAdultoMayor;

        public int AdultoMayor
        {
            get { return _precioAdultoMayor; }
            set { _precioAdultoMayor = value; }
        }

        private bool _estreno;

        public bool EsEstreno
        {
            get { return _estreno; }
            set { _estreno = value; }
        }

        public Tarifa()
        {
            this._estreno = true;
            this._precioAdultoMayor = 0;
            this._precioNino = 0;
            this._precioNormal = 0;
        }

        /// <summary>
        /// Constructor con parametros para la clase
        /// </summary>
        /// <param name="est">Indica si la pelicula es estreno o no</param>
        /// <param name="precioNorm">Precio normal en la tanda</param>
        /// <param name="precioNin">Precio para ninos en la tanda</param>
        /// <param name="precioAdMay">Precio para Adulto Mayor en la tanda</param>
        public Tarifa(bool est, int precioNorm, int precioNin, int precioAdMay)
        {
            this._estreno = est;
            this._precioAdultoMayor = precioAdMay;
            this._precioNino = precioNin;
            this._precioNormal = precioNorm;
        }
    }
}
