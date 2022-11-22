using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Clases
{
    public abstract class Usuario
    {
        protected int _id;
        protected string _nombre;
        protected string _apellido;
        protected int _dni;
        protected ENivelUsuario _nivelUsuario;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Dni { get => _dni; set => _dni = value; }
        public ENivelUsuario NivelUsuario { get => _nivelUsuario; }

        public Usuario(int id, string nombre, string apellido, int dni)
        {
            _id = id;
            _nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            _apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
            _dni = dni;
        }

        public Usuario(string nombre, string apellido, int dni) : this(0, nombre, apellido, dni)
        {

        }


        public virtual string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {this._id}");
            sb.AppendLine($"DNI: {this._dni}");
            sb.AppendLine($"Apellido: {this._apellido}");
            sb.AppendLine($"Nombre: {this._nombre}");

            return sb.ToString();
        }


        public static bool operator ==(Usuario a1, Usuario a2)
        {
            bool retorno = false;

            if (a1.Dni == a2.Dni)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Usuario a1, Usuario a2)
        {
            return !(a1 == a2);
        }

        public static bool operator ==(Usuario a, int id)
        {
            bool retorno = false;

            if (a.Id == id)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Usuario a, int id)
        {
            return !(a == id);
        }

        public static explicit operator Usuario(SqlDataReader r)
        {
            ENivelUsuario n = (ENivelUsuario)Convert.ToInt32(r["id_nivel_usuario"]);
            Usuario? usuario = null;
            switch (n)
            {
                case ENivelUsuario.Admin:
                    usuario = (Admin)r;
                    break;
                case ENivelUsuario.Profesor:
                    usuario = (Profesor)r;
                    break;
                case ENivelUsuario.Alumno:
                    usuario = (Alumno)r;
                    break;

            }


            return usuario;
        }
    }
}
