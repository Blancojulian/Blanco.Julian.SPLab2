using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Clases
{
    public static class ListaUsuarios
    {
        public static List<Usuario>_lista;
        private static int _id;

        static ListaUsuarios()
        {
            _id = 0;
            _lista = new List<Usuario>();
            /*
            AgregarUsuario(new Alumno("Juan", "Doe", "asd123", 1234));
            AgregarUsuario(new Alumno("Juan", "esteban", "AAA111", 2222));

            Admin admin1 = new Admin("Jose", "Admin", "1111", 1111);
            AgregarUsuario(admin1);


            //Materia
            Materia materia1 = new Materia(10, "Programacion", "primer");
            admin1.CrearMateria(materia1);
            */


        }

        public static int GetId()
        {
            _id++;
            return _id;
        }

        private static bool UsuarioExiste(Usuario u)
        {
            bool retorno = false;

            foreach (Usuario usuario in _lista)
            {
                if(usuario.Dni == u.Dni)
                {
                    retorno = true;
                    break;
                }
            }
            
            return retorno;
        }
        
        public static bool AgregarUsuario(Usuario u)
        {
            bool retorno = false;

            if (!UsuarioExiste(u))
            {
                _lista.Add(u);
                retorno = true;
            }

            return retorno;
        }

        public static bool EliminarUsuario(Usuario u)
        {
            bool retorno = false;

            if (UsuarioExiste(u))
            {
                _lista.Remove(u);
                retorno = true;
            }

            return retorno;
        }

        public static Usuario ComprobarLogin(string nombre, string contrasenia, int dni)
        {
            
            foreach(Usuario usuario in _lista)
            {
                if(usuario.Nombre == nombre && usuario.Dni == dni /*&& 
                    Usuario.ComprobarContrasenia(usuario, contrasenia)*/)
                {
                    return usuario;
                }
            }
            

            return null;
        }

        public static Usuario GetUsuario(int dni)
        {
            Usuario usuario = null;

            foreach (Usuario u in _lista)
            {
                if (u.Dni == dni)
                {
                    usuario = u;
                    break;
                }
            }

            return usuario;
        }

        public static List<Profesor> ListaProfesores
        {
            get 
            {
                List<Profesor> listaProfesores = new List<Profesor> ();

                foreach(Usuario usuario in _lista)
                {
                    if (usuario.NivelUsuario == ENivelUsuario.Profesor)
                    {
                        listaProfesores.Add((Profesor)usuario);

                    }
                }

                return listaProfesores;
            } 
        }

    }
}
