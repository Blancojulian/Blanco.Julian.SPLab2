using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Clases
{
    public class Alumno : Usuario
    {
        private int _cantidadMaterias;
        private List<Materia> _materias;

        private List<int> _idMaterias;


        public Alumno(int id, string nombre, string apellido, int dni) : base(id, nombre, apellido, dni)
        {
            this._cantidadMaterias = 0;
            this._nivelUsuario = ENivelUsuario.Alumno;
            this._idMaterias = new List<int>();
        }

        public List<int> IdMaterias { get => _idMaterias; }
        public int CantidadMaterias {get => _cantidadMaterias; }



        public override string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Información alumno");
            sb.Append($"{base.MostrarInformacion()}");

            return sb.ToString();
        }

        public bool InscribirseAMateria(Materia materia)
        {
            bool retorno = materia + this;

            if (retorno)
            {
                this._materias.Add(materia);
            }

            return retorno;
        }

        public bool DarAsistenciaAMateria(Materia materia)
        {
            return Materia.DarAsistencia(materia, this);
        }



        public static bool operator ==(Alumno a, int codigoMateria)
        {
            bool retorno = false;

            foreach (Materia materia in a._materias)
            {
                if (materia.CodigoMateria == codigoMateria)
                {

                    if (EEstadoMateria.Aprobada == Materia.GetEstadoMateriaAlumno(materia, a))
                    {
                        retorno = true;
                        break;
                    }

                }
            }

            return retorno;
        }

        public static bool operator !=(Alumno a, int codigoMateria)
        {
            return !(a == codigoMateria);
        }

        public static explicit operator Alumno(SqlDataReader r)
        {
            Alumno a = new Alumno(
                Convert.ToInt32(r["id"]),
                r["nombre"].ToString() ?? "",
                r["apellido"].ToString() ?? "",
                Convert.ToInt32(r["dni"])
                );

            return a;
        }

        public List<Materia> Materias { get { return new List<Materia>(this._materias); } }
    }
}
