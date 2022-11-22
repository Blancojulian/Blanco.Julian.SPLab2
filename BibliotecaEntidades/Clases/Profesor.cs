using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Clases
{
    public class Profesor : Usuario
    {
        private List<Materia> _materias;
        private List<int> _idMaterias;

        public Profesor(int id, string nombre, string apellido, int dni) : base(id, nombre, apellido, dni)
        {
            this._nivelUsuario = ENivelUsuario.Profesor;
            this._materias = new List<Materia>();
        }

        public bool AgregarExamen(Materia materia, string nombre, DateTime fecha)
        {
            bool retorno = false;

            if(materia == this)
            {
                retorno = materia + new Examen(nombre, fecha);
            }
            return retorno;
        }

        public bool AgregarNota(Materia materia, Alumno alumno, bool primerExamen, int nota)
        {
            return Materia.DarNota(materia, this, alumno, primerExamen, nota);
        }

        public static bool operator +(Profesor p, Materia m)
        {
            bool retorno = true;

            foreach (Materia materia in p._materias)
            {
                if (materia == m)
                {
                    retorno = false;
                    break;
                }
            }

            if (retorno)
            {
                p._materias.Add(m);
            }

            return retorno;
        }

        public static explicit operator Profesor(SqlDataReader r)
        {
            Profesor p = new Profesor(
                Convert.ToInt32(r["id"]),
                r["nombre"].ToString() ?? "",
                r["apellido"].ToString() ?? "",
                Convert.ToInt32(r["dni"])
                );

            return p;
        }

        public List<Materia> Materias { get { return new List<Materia>(this._materias); } }
        public List<int> IdMaterias { get => new List<int>(this._idMaterias); }

        public string PrintMaterias { get => "matematica, historia y programacion"; }
    }
}
