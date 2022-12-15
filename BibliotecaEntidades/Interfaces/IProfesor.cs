using BibliotecaEntidades.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Interfaces
{
    public interface IProfesor
    {
        public int AgregarExamen(int codigoMateria, EExamen examen);

        public int AgregarNota(int codigoMateria, int dniAlumno, EExamen examen, int nota);
    }
}
