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
    public class UsuarioDao : BaseDAO, IClaseDAO<Usuario>, IUsuarioDAO<Usuario>, IComprobarLogin
    {
        
        public UsuarioDao() : base()
        {
            
        }

        public List<Usuario> GetAll()
        {
            List<Usuario> datos = new List<Usuario>();

            

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM usuarios";
                _sqlConnection.Open();

                using (SqlDataReader dataReader = _sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {

                        datos.Add((Usuario)dataReader);

                    }
                }

            }
            catch (Exception)
            {
                throw;
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

        
        public List<T> GetAll<T>() where T : Usuario
        {
            List<T> datos = new List<T>();

            string command = TipoDeUsuarioConsulta(typeof(T));

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
            catch (Exception)
            {
                throw;
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
        
        public Usuario? Get(int dni)
        {
            Usuario? usuario = null;

            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlCommand.CommandText = "SELECT * FROM usuarios WHERE dni = @dni";

                _sqlCommand.Parameters.AddWithValue("@dni", dni);
                _sqlConnection.Open();

                using (SqlDataReader dataReader = _sqlCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {

                        usuario = (Usuario)dataReader;

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return usuario;
        }
        public T? Get<T>(int dni) where T : Usuario
        {
            T? datos = default;

            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlCommand.CommandText = "SELECT * FROM usuarios WHERE dni = @dni";

                _sqlCommand.Parameters.AddWithValue("@dni", dni);
                _sqlConnection.Open();

                using (SqlDataReader dataReader = _sqlCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {

                        datos = (T)dataReader;

                    }
                }

            }
            catch (Exception)
            {
                throw;
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


        public int Add(Usuario datos)
        {
            int filas = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();
                //(nombre, apellido, dni, id_nivel_usuario)
                _sqlCommand.CommandText = "INSERT INTO usuarios VALUES(@nombre, @apellido, @dni, @tipoUsuario, @contrasenia)";

                _sqlCommand.Parameters.AddWithValue("@nombre", datos.Nombre);
                _sqlCommand.Parameters.AddWithValue("@apellido", datos.Apellido);
                _sqlCommand.Parameters.AddWithValue("@dni", datos.Dni);
                _sqlCommand.Parameters.AddWithValue("@tipoUsuario", (int)datos.NivelUsuario);
                _sqlCommand.Parameters.AddWithValue("@contrasenia", "123");


                filas = _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
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

        public int Add<T>(T datos, string contrasenia) where T : Usuario
        {
            int filas = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO usuarios VALUES(@nombre, @apellido, @dni, @tipoUsuario, @contrasenia)";

                _sqlCommand.Parameters.AddWithValue("@nombre", datos.Nombre);
                _sqlCommand.Parameters.AddWithValue("@apellido", datos.Apellido);
                _sqlCommand.Parameters.AddWithValue("@dni", datos.Dni);
                _sqlCommand.Parameters.AddWithValue("@tipoUsuario", (int)datos.NivelUsuario);
                _sqlCommand.Parameters.AddWithValue("@contrasenia", contrasenia);


                filas = _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
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

        public int Update(int id, Usuario datos)
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
            catch (Exception)
            {
                throw;
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

        public int Delete(int id)
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
            catch (Exception)
            {
                throw;
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

        public T? ComprobarLogin<T>(string nombre, string contrasenia, int dni) where T : Usuario
        {
            T? usuario = default;

            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlCommand.CommandText = "SELECT * FROM usuarios WHERE nombre = @nombre AND contrasenia = @contrasenia AND dni = @dni";

                _sqlCommand.Parameters.AddWithValue("@nombre", nombre);
                _sqlCommand.Parameters.AddWithValue("@contrasenia", contrasenia);
                _sqlCommand.Parameters.AddWithValue("@dni", dni);

                _sqlConnection.Open();

                using (SqlDataReader dataReader = _sqlCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {

                        usuario = (T)dataReader;

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return usuario;
        }
    }
}
