using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEntidades.DAO;
using BibliotecaEntidades.Interfaces;

namespace BibliotecaEntidades.Clases
{
    public class Profesor : Usuario, IProfesor
    {
        

        public Profesor(int id, string nombre, string apellido, int dni) : base(id, nombre, apellido, dni)
        {
            this._nivelUsuario = ENivelUsuario.Profesor;
        }
        public Profesor(string nombre, string apellido, int dni) : base(0, nombre, apellido, dni)
        {
            this._nivelUsuario = ENivelUsuario.Profesor;
        }

        public int AgregarExamen(int codigoMateria, EExamen examen)
        {
            return ClaseDAO.MateriaDao.AgregarExamen(codigoMateria, examen);
        }

        public int AgregarNota(int codigoMateria, int dniAlumno, EExamen examen, int nota)
        {
            int filas = 0;
            try
            {
                
                EstadoAlumno? estadoAlumno = ClaseDAO.MateriaDao.Get(codigoMateria, dniAlumno);

                if (estadoAlumno is not null)
                {
                    if (examen == EExamen.Primer)
                    {
                        estadoAlumno.PrimerExamen.Nota = nota;
                        estadoAlumno.PrimerExamen.Rendido = true;
                    }
                    else if (examen == EExamen.Segundo)
                    {
                        estadoAlumno.SegundoExamen.Nota = nota;
                        estadoAlumno.SegundoExamen.Rendido = true;
                    }
                    
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

        

    }
}
