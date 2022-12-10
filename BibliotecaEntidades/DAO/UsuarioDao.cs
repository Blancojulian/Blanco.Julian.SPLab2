using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEntidades.Clases;
using BibliotecaEntidades.Interfaces;

namespace BibliotecaEntidades.DAO
{
    public class UsuarioDao : BaseDAO, IClaseDAO<UsuarioDao>
    {
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;

        public UsuarioDao()
        {
            
        }

        public List<Usuario> GetAll()
        {
            List<Usuario> datos = new List<Usuario>();

            string command = TipoDeUsuarioConsulta(typeof(Usuario));

            try
            {
                _sqlCommand.CommandText = command;
                _sqlConnection.Open();

                using (SqlDataReader dataReader = _sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {

                        datos.Add((T)dataReader);

                    }
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return datos;
        }

        public static T? Get(int id)
        {
            T? datos = default;

            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlCommand.CommandText = "SELECT * FROM usuarios WHERE id = @id";

                _sqlCommand.Parameters.AddWithValue("@id", id);
                _sqlConnection.Open();

                using (SqlDataReader dataReader = _sqlCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {

                        datos = (T)dataReader;

                    }
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return datos;
        }


        public static int Add(T datos)
        {
            int filas = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();
                //(nombre, apellido, dni, id_nivel_usuario)
                _sqlCommand.CommandText = "INSERT INTO usuarios VALUES(@nombre, @apellido, @dni, @tipoUsuario)";

                _sqlCommand.Parameters.AddWithValue("@nombre", datos.Nombre);
                _sqlCommand.Parameters.AddWithValue("@apellido", datos.Apellido);
                _sqlCommand.Parameters.AddWithValue("@dni", datos.Dni);
                _sqlCommand.Parameters.AddWithValue("@tipoUsuario", (int)datos.NivelUsuario);

                filas = _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return filas;
        }

        public static int Update(int id, T datos)
        {
            int filas = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();
                //(nombre, apellido, dni, id_nivel_usuario)
                _sqlCommand.CommandText = "UPDATE usuarios SET nombre = @nombre, apellido = @apellido, dni = @dni, id_nivel_usuario = @tipoUsuario WHERE id = @id";

                _sqlCommand.Parameters.AddWithValue("@nombre", datos.Nombre);
                _sqlCommand.Parameters.AddWithValue("@apellido", datos.Apellido);
                _sqlCommand.Parameters.AddWithValue("@dni", datos.Dni);
                _sqlCommand.Parameters.AddWithValue("@tipoUsuario", (int)datos.NivelUsuario);
                _sqlCommand.Parameters.AddWithValue("@id", id);

                filas = _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return filas;
        }

        public static int Delete(int id)
        {
            int filas = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();
                //(nombre, apellido, dni, id_nivel_usuario)
                _sqlCommand.CommandText = "DELETE FROM usuarios WHERE id = @id";

                _sqlCommand.Parameters.AddWithValue("@id", id);

                filas = _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return filas;
        }

        private static string TipoDeUsuarioConsulta(Type tipo)
        {
            //Type tipo = t.GetType();
            string command = "SELECT * FROM usuarios";

            if (typeof(Admin) == tipo)
            {
                command += $" WHERE id_nivel_usuario = {(int)ENivelUsuario.Admin}";
            }
            else if (typeof(Profesor) == tipo)
            {
                command += $" WHERE id_nivel_usuario = {(int)ENivelUsuario.Profesor}";

            }
            else if (typeof(Alumno) == tipo)
            {
                command += $" WHERE id_nivel_usuario = {(int)ENivelUsuario.Alumno}";

            }

            return command;
        }
    }
}
