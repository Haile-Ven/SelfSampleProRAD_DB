//using System.Data.SqlClient;
using Microsoft.SqlServer;
namespace SelfSampleProRAD_DB
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
            connectionString = "Data Source=HAILE-VEN;Initial Catalog=RADSampleProDB;Integrated Security=True;Encrypt=False;";
            connection = new SqlConnection(connectionString);
            connection.Open();
            }
            catch (Exception dbEx) { if (MessageBox.Show(dbEx.Message, "Database Error in DBConnection", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) { Environment.Exit(0); } }
            return connection;
        }
        public void closeConnection() { connection.Close(); }
    }
}
