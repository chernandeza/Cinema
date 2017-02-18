using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosBase
{
    public class Tanda
    {
        private HorariosTanda _horario;

        public HorariosTanda Horario
        {
            get { return _horario; }
            set { _horario = value; }
        }

        private Pelicula _peliculaTanda;

        public Pelicula PeliculaTanda
        {
            get { return _peliculaTanda; }
            set { _peliculaTanda = value; }
        }

        private List<Butaca> _butacas;

        public List<Butaca> ButacasTanda
        {
            get { return _butacas; }
            set { _butacas = value; }
        }

        private Tarifa _tarifaTanda;

        public Tarifa TarifaTanda
        {
            get { return _tarifaTanda; }
            set { _tarifaTanda = value; }
        }

        public Tanda()
        {
            this._horario = HorariosTanda.Ninguno;
            this._peliculaTanda = new Pelicula();
            this._tarifaTanda = new Tarifa();
            this._butacas = new List<Butaca>();
        }

        /// <summary>
        /// Constructor con parametros para el objeto Tanda
        /// </summary>
        /// <param name="ht">Horario de la tanda</param>
        /// <param name="pel">Pelicula a presentar en la tanda</param>
        /// <param name="tt">Tarifa a utilizar en la tanda</param>
        /// <param name="butacas">Cantidad de butacas disponibles en la tanda</param>
        public Tanda(HorariosTanda ht, Pelicula pel, Tarifa tt, int butacas)
        {
            this._horario = ht;
            this._peliculaTanda = pel;
            this._tarifaTanda = tt;
            for (int i = 0; i < butacas; i++)
            {
                this._butacas.Add(new Butaca());
            }
        }
    }

    public enum HorariosTanda
    {
        Ninguno,
        _10am,
        _2pm,
        _6pm,
        _10pm,
        Especial
    }
}
