namespace SelfSampleProRAD_DB_SQL.DB
{
    internal class DBConnection
    {
        string connectionString;
        SqlConnection connection;
        public DBConnection() 
        {
        }
        public SqlConnection openConnection() 
        {
            try { 
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Haile-Work\\source\\repos\\SelfSampleProRAD_DB_SQL\\SelfSampleProRAD\\DB\\EmployeeTaskDB.mdf;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();
            }
            catch (Exception dbEx) { if (MessageBox.Show(dbEx.Message, "Database Error in DBConnection", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) { Environment.Exit(0); } }
            return connection;
        }
        public void closeConnection() { connection.Close(); }
    }
}
