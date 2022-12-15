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
    public class Admin : Usuario, IAdmin
    {
        public Admin(int id, string nombre, string apellido, int dni) : base(id, nombre, apellido, dni)
        {            
            this._nivelUsuario = ENivelUsuario.Admin;
        }
        public Admin(string nombre, string apellido, int dni) : this(0, nombre, apellido, dni)
        {
        }

        public int CrearUsuario(Usuario usuario)
        {
            return ClaseDAO.UsuarioDao.Add(usuario);
        }

        public int CrearUsuario(Usuario usuario, string contrasenia)
        {
            return ClaseDAO.UsuarioDao.Add(usuario, contrasenia);
        }

        public int CrearMateria(Materia materia)
        {
            return ClaseDAO.MateriaDao.Add(materia);
        }

        

        public int AgregarProfesorAMateria(int codigoMateria, int dniProfesor)
        {
            return ClaseDAO.MateriaDao.AgregarProfesor(codigoMateria, dniProfesor);
        }

        public int CambiarEstadoAlumno(int codigoMateria, int dniAlumno, EEstadoAlumno estado)
        {
            int filas = 0;
            try
            {

                EstadoAlumno? estadoAlumno = ClaseDAO.MateriaDao.Get(codigoMateria, dniAlumno);

                if (estadoAlumno is not null)
                {
                    estadoAlumno.Estado = estado;
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
        

        public static explicit operator Admin(SqlDataReader r)
        {
            Admin a = new Admin(
                Convert.ToInt32(r["id"]),
                r["nombre"].ToString() ?? "",
                r["apellido"].ToString() ?? "",
                Convert.ToInt32(r["dni"])
                );

            return a;
        }

    }
}
