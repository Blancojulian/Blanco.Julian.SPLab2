using BibliotecaEntidades.Clases;
using BibliotecaEntidades.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Interfaces
{
    public interface IAlumno
    {
        public static int InscribirseAMateria(int codigoMateria, Alumno a)
        {
            return ClaseDAO.MateriaDao.Add(codigoMateria, a.Dni, new EstadoAlumno());
        }
        public int DarAsistenciaAMateria(int codigoMateria, int dniAlumno);
    }
}
