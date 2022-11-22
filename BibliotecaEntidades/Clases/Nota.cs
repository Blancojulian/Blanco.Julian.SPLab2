using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Clases
{
    public class Nota
    {
        private int _nota;
        private bool _rendido;

        public Nota()
        {
            this._nota = 0;
            this._rendido = false;
        }

        public int NotaParcial { 
            get { return this._nota; }
            set
            {
                if (value < 1 || value >10)
                {
                    value = 1;
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
