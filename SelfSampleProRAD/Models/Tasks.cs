namespace SelfSampleProRAD_DB_SQL.Models
{
    public class Tasks
    {
        //Auto-Properties
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string AssignedTo { get; set; }
        public string AssignedBy { get; set; }
        public char Status { get; set; }
        //Constructors
        public Tasks() { }
        public Tasks(int tskId, string tskNm, string aTo, string aBy,char st)
        {
            TaskId = tskId;
            TaskName = tskNm;
            AssignedTo = aTo;
            AssignedBy = aBy;
            Status = st;
        }
        //Methods
        public int AssignTask(int tskId, string tskNm, string aTo, string aBy)
        {
            TaskId = tskId;
            TaskName = tskNm;
            AssignedTo = aTo;
            AssignedBy = aBy;
            Status = 'U';
            int rowsAffected=0;
            try
            {
                SqlConnection con = new DBConnection().openConnection();
                string sql = string.Format("INSERT INTO Tasks (TaskID, TaskName, AssignedTo, AssignedBy, Status)" +
            $" VALUES ('{TaskId}','{TaskName}','{AssignedTo}','{AssignedBy}','U')");
                SqlCommand cmd = new SqlCommand(sql, con);
                rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception dbEx) { MessageBox.Show(dbEx.Message, "Database Error in Account", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return rowsAffected;
        }

        public SqlDataReader ViewTasksFor(string taskTo)
        {
            AssignedTo = taskTo;
            SqlConnection con = new DBConnection().openConnection();
            SqlDataReader accRec = null;
            try
            {
                string sql = string.Format($"SELECT * FROM Tasks WHERE AssignedTo = '{AssignedTo}' " +
                    $"AND Status != 'D'");
                SqlCommand cmd = new SqlCommand(sql, con);
                accRec = cmd.ExecuteReader();
            }
            catch (Exception dbEx) { MessageBox.Show(dbEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return accRec;
        }

        public SqlDataReader ViewTasksTo(string taskBy)
        {
            SqlConnection con = new DBConnection().openConnection();
            SqlDataReader accRec = null;
            try
            {
                string sql = string.Format($"SELECT * FROM Tasks WHERE AssignedBy = '{taskBy}'");
                SqlCommand cmd = new SqlCommand(sql, con);
                accRec = cmd.ExecuteReader();
            }
            catch (Exception dbEx) { MessageBox.Show(dbEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return accRec;
        }

        public byte startWorking(int taskID)
        {
            try
            {
                SqlConnection con = new DBConnection().openConnection();
                string sql = string.Format($"UPDATE Tasks SET Status = 'P' WHERE TaskID = '{taskID}'");
                SqlCommand cmd = new SqlCommand(sql, con);
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch (Exception dbEx) { MessageBox.Show(dbEx.Message, "Database Error in Tasks", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            return 0;
        }
        public byte submitWork(int taskID)
        {
            try
            {
                SqlConnection con = new DBConnection().openConnection();
                string sql = string.Format($"UPDATE Tasks SET Status = 'D' WHERE TaskID = '{taskID}'");
                SqlCommand cmd = new SqlCommand(sql, con);
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch (Exception dbEx) { MessageBox.Show(dbEx.Message, "Database Error in Tasks", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            return 0;
        }
    }
}
