using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.DAO
{
    public class BaseDAO
    {
        protected SqlConnection _sqlConnection;
        protected SqlCommand _sqlCommand;

        public BaseDAO()
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
    }
}
