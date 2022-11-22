using BibliotecaEntidades.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.DAO
{
    public static class EstadoAlumnoDAO
    {
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;

        static EstadoAlumnoDAO()
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

        public static Dictionary<int, EstadoAlumno> GetAll()
        {
            Dictionary<int, EstadoAlumno> datos = new Dictionary<int, EstadoAlumno>();

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM materias";
                _sqlConnection.Open();

                using (SqlDataReader dataReader = _sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {

                        datos.Add(Convert.ToInt32("id_alumno"), (EstadoAlumno)dataReader);

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
    }
}
