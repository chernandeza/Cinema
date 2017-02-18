using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosBase
{
    public class Cartelera
    {
        private List<Sala> _salas;

        public List<Sala> Salas
        {
            get { return _salas; }
            set { _salas = value; }
        }

        public Cartelera()
        {
            for (int i = 0; i < 7; i++)
            {
                this.Salas.Add(new Sala());
            }
        }
    }
}
