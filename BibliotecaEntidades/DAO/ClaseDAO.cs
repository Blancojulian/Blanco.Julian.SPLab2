using BibliotecaEntidades.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.DAO
{
    public class ClaseDAO<T> where T : Usuario
    {
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;

        static ClaseDAO()
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

        public static List<T> GetAll()
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
