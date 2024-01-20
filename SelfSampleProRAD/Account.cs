using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Linq;
using System.Diagnostics.Eventing.Reader;
using System.Reflection;

namespace SelfSampleProRAD_DB
{
    public class Account
    {
        //Auto-Properties
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public char Status { get; set; }
        //Constructors
        public Account() { }
        public Account(int uID, string userN, string passW, char st)
        {
            UserID = uID;
            UserName = userN;
            Password = passW;
            Status = st;
        }
        protected Account(int id, string fName, string lName, string pass, string pos)
        {
            UserID = id;
            UserName = fName + "_" + lName + "@" + UserID + "_" + pos;
            Password = pass;
        }
        //Methods
        public void createAccount(int id, string fName, string lName, string pass, string pos)
        {
            UserID = id;
            UserName = (fName + "_" + lName + "@" + UserID + "_" + pos).ToLower();
            Password = pass;
            Status = 'A';
            //Add to database
            try
            {
                SqlConnection con = new DBConnection().openConnection();
                string sql = string.Format("INSERT INTO Account (UserID,Username, Password, Status)" +
            $" VALUES ('{UserID}','{UserName}','{Password}','A')");
                SqlCommand cmd = new SqlCommand(sql, con);
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception dbEx) { MessageBox.Show(dbEx.Message, "Database Error in Account", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public byte changePassword(string oldPass, string newPass)
        {
            if (oldPass == Password)
            {
                Password = newPass;
                try
                {
                    SqlConnection con = new DBConnection().openConnection();
                    string sql = string.Format($"UPDATE Account SET Password = '{Password}' WHERE UserID = '{UserID}'");
                    SqlCommand cmd = new SqlCommand(sql, con);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    return 1;
                }
                catch (Exception dbEx) { MessageBox.Show(dbEx.Message, "Database Error in Account", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            return 0;
        }
        public SqlDataReader ListAllAccounts()
        {
            SqlConnection con = new DBConnection().openConnection();
            SqlDataReader accRec = null;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Account", con);
                accRec = cmd.ExecuteReader();
            }
            catch (Exception dbEx) { MessageBox.Show(dbEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return accRec;
        }
        public SqlDataReader ListAllDevs()
        {
            SqlConnection con = new DBConnection().openConnection();
            SqlDataReader accRec = null;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Account WHERE Username LIKE '%Developer%'", con);
                accRec = cmd.ExecuteReader();
            }
            catch (Exception dbEx) { MessageBox.Show(dbEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return accRec;
        }
        public byte activateAccount(string userNm)
        {
            try
            {
                SqlConnection con = new DBConnection().openConnection();
                string sql = string.Format($"UPDATE Account SET Status = 'A' WHERE Username = '{userNm}'");
                SqlCommand cmd = new SqlCommand(sql, con);
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch (Exception dbEx) { MessageBox.Show(dbEx.Message, "Database Error in Account", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            return 0;
        }
        public byte deactivateAccount(string userNm)
        {
            try
            {
                SqlConnection con = new DBConnection().openConnection();
                string sql = string.Format($"UPDATE Account SET Status = 'D' WHERE Username = '{userNm}'");
                SqlCommand cmd = new SqlCommand(sql, con);
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch (Exception dbEx) { MessageBox.Show(dbEx.Message, "Database Error in Account", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            return 0;
        }
    }
}
