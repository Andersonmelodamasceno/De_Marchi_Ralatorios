using System.Data.SqlClient;

namespace De_Marchi_Relatorios.Data
{
    class DbContext
    {
        private string connectionString;

        public DbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}