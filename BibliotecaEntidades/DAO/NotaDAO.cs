using BibliotecaEntidades.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.DAO
{
    public static class NotaDAO
    {
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;

        static NotaDAO()
        {
            _sqlConnection = new SqlConnection(@"
                Data Source = .;
                Database = prueba_sql_2;
                Trusted_Connection = True;
            ");
            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = System.Data.CommandType.Text;
        }
        /*
        public static List<Materia> GetAll()
        {
            List<Materia> datos = new List<Materia>();

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM materias";
                _sqlConnection.Open();

                using (SqlDataReader dataReader = _sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {

                        datos.Add((Materia)dataReader);

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
        public static Materia? Get(int id)
        {
            Materia? datos = null;

            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlCommand.CommandText = "SELECT * FROM materias WHERE id = @id";

                _sqlCommand.Parameters.AddWithValue("@id", id);

                _sqlConnection.Open();

                using (SqlDataReader dataReader = _sqlCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        datos = (Materia)dataReader;
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
        }*/

        public static int Add(int datos)
        {
            int filas = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO materias VALUES" +
                    "(@nombre, @cuatrimestre, @codigo_materia, @id_materia_correlativa)";

                _sqlCommand.Parameters.AddWithValue("@nombre", datos.Nombre);
                _sqlCommand.Parameters.AddWithValue("@cuatrimestre", datos.Cuatrimestre);
                _sqlCommand.Parameters.AddWithValue("@codigo_materia", datos.CodigoMateria);
                _sqlCommand.Parameters.AddWithValue("@id_materia_correlativa", datos.MateriaCorrelativa);

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

        public static int Update(int id, Materia datos)
        {
            int filas = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();
                //(nombre, apellido, dni, id_nivel_usuario)
                _sqlCommand.CommandText = "UPDATE materias SET nombre = @nombre, " +
                    "cuatrimestre = @cuatrimestre, codigo_materia = @codigo_materia, " +
                    "id_materia_correlativa = @id_materia_correlativa WHERE id = @id";

                _sqlCommand.Parameters.AddWithValue("@nombre", datos.Nombre);
                _sqlCommand.Parameters.AddWithValue("@cuatrimestre", datos.Cuatrimestre);
                _sqlCommand.Parameters.AddWithValue("@codigo_materia", datos.CodigoMateria);
                _sqlCommand.Parameters.AddWithValue("@id_materia_correlativa", datos.MateriaCorrelativa);
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

                _sqlCommand.CommandText = "DELETE FROM materias WHERE id = @id";

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
    }
}
