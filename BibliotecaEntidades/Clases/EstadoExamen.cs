using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Clases
{
    public class EstadoExamen
    {
        private int _nota;
        private bool _rendido;

        public EstadoExamen(int nota, bool rendido)
        {
            _nota = nota;
            _rendido = rendido;
        }
        public EstadoExamen() : this(0, false)
        {
        }


        public int Nota
        {
            get { return this._nota; }
            set
            {
                if (value < 1 || value > 10)
                {
                    value = 0;
                }
                this._nota = value;
            }
        }

        public bool Rendido
        {
            get { return this._rendido; }
            set
            {
                if (this._rendido == true && value == false)
                {
                    value = true;
                }
                this._rendido = value;
            }
        }

    }
}
