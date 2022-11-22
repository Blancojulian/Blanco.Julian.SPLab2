using BibliotecaEntidades.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.DAO
{
    public static class ExamenDao
    {
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;

        static ExamenDao()
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
        //metodos privados aparte para lista de profesores, estados de los alumnos y los examenes
        //mejor hacerr DAOs por lista de profesores, estados de los alumnos y los examenes
        public static List<Examen> GetAll()
        {
            List<Examen> datos = new List<Examen>();

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM examenes INNER JOIN " +
                    "notas_examenes ON examenes.id_nota = notas_examenes.id_nota";

                _sqlConnection.Open();

                using (SqlDataReader dataReader = _sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Examen? examen = (Examen)dataReader;
                        if (examen != null)
                        {
                            datos.Add((Examen)dataReader);

                        }

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

        public static List<Examen> GetAll(int idAlumno)
        {
            List<Examen> datos = new List<Examen>();

            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlCommand.CommandText = "SELECT * FROM examenes INNER JOIN " +
                    "notas_examenes ON examenes.id_nota = notas_examenes.id_nota" +
                    "WHERE notas_examenes.id_usuario = @id";

                _sqlCommand.Parameters.AddWithValue("@id", idAlumno);

                _sqlConnection.Open();

                using (SqlDataReader dataReader = _sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Examen? examen = (Examen)dataReader;
                        if (examen != null)
                        {
                            datos.Add((Examen)dataReader);

                        }

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
        public static Examen? Get(int id)
        {
            Examen? datos = null;

            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlCommand.CommandText = "SELECT * FROM examenes INNER JOIN " +
                    "notas_examenes ON examenes.id_nota = notas_examenes.id_nota" +
                    "WHERE notas_examenes.id_examen = @id";


                _sqlCommand.Parameters.AddWithValue("@id", id);

                _sqlConnection.Open();

                using (SqlDataReader dataReader = _sqlCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        datos = (Examen)dataReader;
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
        public static int Add(Examen datos, int idMateria)
        {
            int filas = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO examenes VALUES" +
                    "(@nombre, @fecha, @id_materia);";
                
                _sqlCommand.Parameters.AddWithValue("@nombre", datos.Nombre);
                _sqlCommand.Parameters.AddWithValue("@fecha", datos.Fecha.ToString("yyyy-MM-dd"));
                _sqlCommand.Parameters.AddWithValue("@id_materia", idMateria);
                
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

        public static int Update(int id, Examen datos, int idMateria)
        {
            int filas = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "UPDATE examenes SET nombre = @nombre, " +
                    "fecha = @fecha, id_materia = @id_materia WHERE id = @id";

                _sqlCommand.Parameters.AddWithValue("@nombre", datos.Nombre);
                _sqlCommand.Parameters.AddWithValue("@fecha", datos.Fecha.ToString("yyyy-MM-dd"));
                _sqlCommand.Parameters.AddWithValue("@id_materia", idMateria);
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

        public static int Update(int id, int idNota)
        {
            int filas = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "UPDATE examenes SET id_nota = @id_nota WHERE id = @id";

                _sqlCommand.Parameters.AddWithValue("@id_nota", idNota);
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

                _sqlCommand.CommandText = "DELETE FROM examenes WHERE id = @id";

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
