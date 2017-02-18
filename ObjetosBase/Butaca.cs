using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosBase
{
    public class Butaca
    {
        private bool _ocupado;

        public bool EstaOcupado
        {
            get { return _ocupado; }
            set { _ocupado = value; }
        }

        public Butaca()
        {
            _ocupado = false;
        }

        public void ReservarLaButaca()
        {
            EstaOcupado = true;
        }

        public void DesocuparLaButaca()
        {
            EstaOcupado = false;
        }
    }
}
