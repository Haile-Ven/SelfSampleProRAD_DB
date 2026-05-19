using System.Data;

namespace SelfSampleProRAD_DB_SQL.DB
{
    internal class DBConnection
    {
        public string _connectionString { get; set; }
        SqlConnection connection;
        public DBConnection(string? connectionString)
        {
            _connectionString = connectionString == null ?
                "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Haile-Work\\source\\repos\\SelfSampleProRAD_DB_SQL\\SelfSampleProRAD\\DB\\EmployeeTaskDB.mdf;Integrated Security=True" :
                connectionString;
            connection = new SqlConnection(_connectionString);
        }
        public SqlConnection _connection
        {
            get
            {
                if (connection.State != ConnectionState.Open) connection.Open();
                return connection;
            }
        }
    }
}
