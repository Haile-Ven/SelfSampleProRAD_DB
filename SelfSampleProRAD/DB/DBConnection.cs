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
        }
        public SqlConnection _connection
        {
            get
            {
                connection = new SqlConnection(_connectionString);
                connection.Open();
                return connection;
            }
        }
    }
}
