using BibliotecaEntidades.DAO;
using BibliotecaEntidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Clases
{
    public class Alumno : Usuario, IAlumno
    {
        private int _cantidadMaterias;



        public Alumno(int id, string nombre, string apellido, int dni) : base(id, nombre, apellido, dni)
        {
            this._cantidadMaterias = 0;
            this._nivelUsuario = ENivelUsuario.Alumno;
        }
        public Alumno( string nombre, string apellido, int dni) : this(0, nombre, apellido, dni)
        {
        }

        public int CantidadMaterias {get => _cantidadMaterias; }



        public override string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Información alumno");
            sb.Append($"{base.MostrarInformacion()}");

            return sb.ToString();
        }

        public static int InscribirseAMateria(int codigoMateria, Alumno a)
        {
            return ClaseDAO.MateriaDao.Add(codigoMateria, a.Dni, new EstadoAlumno());
        }

        public int DarAsistenciaAMateria(int codigoMateria, int dniAlumno)
        {
            int filas = 0;
            try
            {

                EstadoAlumno? estadoAlumno = ClaseDAO.MateriaDao.Get(codigoMateria, dniAlumno);

                if (estadoAlumno is not null)
                {
                    estadoAlumno.Asistencia = true;
                    
                    filas = ClaseDAO.MateriaDao.Update(codigoMateria, dniAlumno, estadoAlumno);
                }
                else
                {
                    throw new Exception($"No existe alumno con el dni {dniAlumno}");
                }
            }
            catch (Exception)
            {

                throw;
            }

            return filas;
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

    }
}
