using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Clases
{
    public class Examen
    {
        private int _id;
        private string _nombre;
        private DateTime _fecha;
        private int _nota;
        private bool _rendido;

        public Examen(int id, string nombre, DateTime fecha)
        {
            _id = id;
            _nombre = nombre.ToLower();
            _fecha = fecha;
            _nota = 0;
            _rendido = false;

        }
        public Examen(string nombre, DateTime fecha) : this(0, nombre, fecha)
        {
            
        }

        private Examen(int id, string nombre, DateTime fecha, int nota, bool rendido) : this(id, nombre, fecha)
        {
            _nota = nota;
            _rendido = rendido;
        }

        public static explicit operator Examen?(SqlDataReader r)
        {
            Examen? examen = null;

            if (!string.IsNullOrEmpty(r["id_nota"].ToString() ?? ""))
            {
                examen = new Examen( Convert.ToInt32(r["id_examen"]),
                r["nombre"].ToString() ?? "",
                Convert.ToDateTime(r["fecha"]),
                Convert.ToInt32(r["nota"]),
                Convert.ToBoolean(r["rendido"]));
            }
            
            return examen;
        }
        public static bool operator ==(Examen e1, Examen e2)
        {
            bool retorno = false;

            if (e1._nombre == e2._nombre)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Examen e1, Examen e2)
        {
            return !(e1 == e2);
        }

        

        public int Nota
        {
            get { return this._nota; }
            set
            {
                if (value < 1 || value > 10)
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

        public string Nombre { get => _nombre; set => _nombre = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public int Id { get => _id; set => _id = value; }
    }
}
