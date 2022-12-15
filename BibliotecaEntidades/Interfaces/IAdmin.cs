using BibliotecaEntidades.Clases;
using BibliotecaEntidades.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Interfaces
{
    public interface IAdmin
    {
        public int CrearUsuario(Usuario usuario);
        public int CrearUsuario(Usuario usuario, string contrasenia);
        public int CrearMateria(Materia materia);
        public int AgregarProfesorAMateria(int codigoMateria, int dniProfesor);
        public int CambiarEstadoAlumno(int codigoMateria, int dniAlumno, EEstadoAlumno estado);
    }
}
