using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosBase
{
    public class Pelicula
    {
        private String _nombre;

        public String NombrePelicula
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private GeneroPelicula _genero;

        public GeneroPelicula Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

        private FormatoPelicula _formato;

        public FormatoPelicula Formato
        {
            get { return _formato; }
            set { _formato = value; }
        }

        private short _duracion;

        public short DuracionPelicula
        {
            get { return _duracion; }
            set { _duracion = value; }
        }

        private byte _edad;

        public byte EdadMinima
        {
            get { return _edad; }
            set { _edad = value; }
        }

        private IdiomaPelicula _idioma;

        public IdiomaPelicula Idioma
        {
            get { return _idioma; }
            set { _idioma = value; }
        }

        private bool _subtitulos;

        public bool EsSubtitulada
        {
            get { return _subtitulos; }
            set { _subtitulos = value; }
        }

        private DateTime _fechaEstreno;

        public DateTime FechaEstreno
        {
            get { return _fechaEstreno; }
            set { _fechaEstreno = value; }
        }

        public Pelicula()
        {
            this._nombre = "";
            this._formato = FormatoPelicula.Ninguno;
            this._edad = 0;
            this._duracion = 0;
            this._genero = GeneroPelicula.Ninguno;
            this._subtitulos = false;
            this._idioma = IdiomaPelicula.Ninguno;
            this._fechaEstreno = DateTime.Now;
        }
    }

    public enum GeneroPelicula
    {
        Ninguno,
        Accion,
        Comedia,
        Drama,
        Terror,
        Suspenso,
        Erotica,
        Romantica,
        Documental,
        Extranjera,
        Infantil
    }

    public enum FormatoPelicula
    {
        Ninguno,
        dosD,
        tresD,
        cuatroD,
        ochoMM
    }

    public enum IdiomaPelicula
    {
        Ninguno,
        Espanol,
        Ingles,
        Italiano,
        Frances,
        Japones,
        Otro
    }
}
