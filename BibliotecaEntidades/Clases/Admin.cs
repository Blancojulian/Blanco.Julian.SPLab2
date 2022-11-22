using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Clases
{
    public class Admin : Usuario
    {
        public Admin(int id, string nombre, string apellido, int dni) : base(id, nombre, apellido, dni)
        {            
            this._nivelUsuario = ENivelUsuario.Admin;
        }

        public bool CrearUsuario(Usuario usuario)
        {
            return ListaUsuarios.AgregarUsuario(usuario);
        }
        public bool CrearAlumno(int id, string nombre, string apellido, int dni)
        {
            return ListaUsuarios.AgregarUsuario( new Alumno(id, nombre, apellido, dni) );
        }

        public bool CrearProfesor(int id, string nombre, string apellido, string contrasenia, int dni)
        {
            return ListaUsuarios.AgregarUsuario( new Profesor(id, nombre, apellido, dni) );
        }

        public bool CrearAdmin(int id, string nombre, string apellido, string contrasenia, int dni)
        {
            return ListaUsuarios.AgregarUsuario( new Admin(id, nombre, apellido, dni) );
        }

        public bool CrearMateria(int id, int codigoMateria, string nombre, string cuatrimestre)
        {
            return ListaMaterias.AgregarMateria(new Materia(id, codigoMateria, nombre, cuatrimestre));
        }

        public bool CrearMateria(Materia materia)
        {
            return ListaMaterias.AgregarMateria(materia);
        }

        public bool CrearMateria(int id, int codigoMateria, string nombre, string cuatrimestre, int materiaCorrelativa)
        {
            return ListaMaterias.AgregarMateria( new Materia(id, codigoMateria, nombre, cuatrimestre, materiaCorrelativa) );
        }

        public bool AgregarProfesorAMateria(Materia materia, Profesor profesor)
        {
            return materia + profesor;
        }

        public bool CambiarEstadoAlumno(Materia materia, Alumno alumno, EEstadoAlumno estado)
        {
            return Materia.SetEstadoAlumno(materia, alumno, estado);
        }
        //ver si se puedo usar, este tema no lo dio
        public T CrearUsuario <T>(string nombre, string apellido, string contrasenia, int dni) where T : new()
        {
            T usuario = new T();
            return usuario;
            //return new T(nombre, apellido, contrasenia, dni);
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
