using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosBase
{
    public class Sala
    {
        private byte _numSala;

        public byte NumeroDeSala
        {
            get { return _numSala; }
            set { _numSala = value; }
        }

        private List<Tanda> _tandas;

        public List<Tanda> TandasEnSala
        {
            get { return _tandas; }
            set { _tandas = value; }
        }

        private bool _vip;

        public bool EsSalaVIP
        {
            get { return _vip; }
            set { _vip = value; }
        }

        private TipoSala _tipo;

        public TipoSala Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public Sala()
        {
            this._numSala = 0;
            this._tipo = TipoSala.Ninguno;
            this._vip = false;
            this._tandas = new List<Tanda>();
        }
    }

    public enum TipoSala
    {
        Ninguno,
        dosD,
        tresD,
        cuatroD,        
    }
}
