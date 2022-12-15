using BibliotecaEntidades.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Interfaces
{
    public interface IEstadoEnMateriaDAO
    {
        public List<EstadoAlumno> GetAll(int idCodigoMateria);
        public EstadoAlumno? Get(int codigoMateria, int dniAlumno);
        public int Add(int codigoMateria, int dniAlumno, EstadoAlumno datos);
        public int Update(int codigoMateria, int dniAlumno, EstadoAlumno datos);
        public int AgregarExamen(int codigoMateria, EExamen examen);
        public int AgregarProfesor(int codigoMateria, int dniProfesor);

        public List<Profesor> GetAllProfesores(int idCodigoMateria);

        //public int AgregarNota(int codigoMateria, int dniAlumno, EExamen examen, int nota);

        //public int EliminsrAlumnoDeMateria(int codigoMateria, int dniAlumno);
    }
}
