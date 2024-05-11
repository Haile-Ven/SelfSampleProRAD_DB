using Microsoft.SqlServer.Server;
using System.Data.Common;

namespace SelfSampleProRAD_DB
{
    public class Employee : Account
    {
        //Auto-properties
        public string EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public byte Age { get; set; }
        public string Position { get; set; }
        public float Salary { get; set; }
        public float Tax { get; set; }
        public string Catagory { get; set; }
        public List<Tasks> Tasks { get; set; }
        //Constructors
        public Employee() { }
        public Employee(string id, string fName, string lName, char gen, byte age, string pos, string cat)
        : base(Convert.ToInt32(id), fName, lName, "12345", pos)

        {
            EmployeeID = id;
            FirstName = fName;
            LastName = lName;
            Gender = gen;
            Age = age;
            Position = pos;
            Catagory = cat;
        }
        //Methods
        public void AddEmployee(string id, string fName, string lName, char gen, byte age, string pos, string cat)
        {
            EmployeeID = id;
            FirstName = fName;
            LastName = lName;
            Gender = gen;
            Age = age;
            Position = pos;
            Catagory = cat;
            calaculateTax();
            //Add to database
            SqlConnection con = new DBConnection().openConnection();
            try
            {
                string sql = string.Format("INSERT INTO Employee (EmpID, FirstName, LastName, Age, Gender, Position, Salary, Tax, Category)" +
            $" VALUES ('{EmployeeID}','{FirstName}','{LastName}',{Age.ToString()},'{Gender}','{Position}',{Salary},{Tax},'{Catagory}')");
            SqlCommand cmd = new SqlCommand(sql,con);
                int rowsAffeted = cmd.ExecuteNonQuery();
                if(rowsAffeted > 0) { createAccount(Convert.ToInt32(EmployeeID), FirstName, LastName,"12345",Position); }
            }
            catch (Exception dbEx) { MessageBox.Show(dbEx.Message, "Database Error in Employee", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            con.Close();
        }
        public void editEmployee()
        {
            //Access database and edit
        }
        public void SelectEmployee(string usrName, string pwd)
        {
            //Select a singleEmployee Employee from database
            SqlDataReader AccRec = null;
            SqlDataReader EmpRec = null;
            SqlConnection con = new DBConnection().openConnection();
            try
            {
                string AccSql = "SELECT * FROM Account WHERE Username = @Username AND Password = @Password";
                SqlCommand AccCmd = new SqlCommand(AccSql, con);

                // Assuming 'usrName' and 'pwd' are the user inputs
                AccCmd.Parameters.AddWithValue("@Username", usrName);
                AccCmd.Parameters.AddWithValue("@Password", pwd);
                AccRec = AccCmd.ExecuteReader();
                if (AccRec.HasRows)
                {
                    while (AccRec.Read())
                    {
                        UserID = Convert.ToInt32(AccRec["UserID"]);
                        UserName = AccRec["Username"].ToString();
                        Password = AccRec["Password"].ToString();
                        Status = Convert.ToChar(AccRec["Status"]);
                        EmployeeID = AccRec["Username"].ToString().Split("@")[1].Split("_")[0];

                    }
                    con.Close();
                    con.Open();
                    string EmpSql = string.Format($"SELECT * FROM Employee WHERE EmpID = '{Convert.ToInt32(EmployeeID)}' ");
                    SqlCommand EmpCmd = new SqlCommand(EmpSql, con);
                    EmpRec = EmpCmd.ExecuteReader();
                    if (EmpRec.HasRows)
                    {
                        while (EmpRec.Read())
                        {
                            EmployeeID = EmpRec["EmpID"].ToString();
                            FirstName = EmpRec["FirstName"].ToString();
                            LastName = EmpRec["LastName"].ToString();
                            Gender = Convert.ToChar(EmpRec["Gender"].ToString()[0]);
                            Age = Convert.ToByte(EmpRec["Age"]);
                            Position = EmpRec["Position"].ToString();
                            Salary = Convert.ToSingle(EmpRec["Salary"]);
                            Tax = Convert.ToSingle(EmpRec["Tax"]);
                            Catagory = EmpRec["Category"].ToString();
                        }
                    }
                    con.Close ();
                }
            }
            catch (Exception dbEx) { MessageBox.Show(dbEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public SqlDataReader ListAllEmployees()
        {
            SqlConnection con = new DBConnection().openConnection();
            SqlDataReader rec = null;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", con);
                rec = cmd.ExecuteReader();
                
            } catch(Exception dbEx) { MessageBox.Show(dbEx.Message,"Database Error",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            con.Close();
            return rec;
        }
        public void calaculateTax()
        {
            if (Position == "Developer")
            {
                Salary = 20000;
                Tax = Salary * (25F / 100);
            }
            else if (Position == "Manager")
            {
                Salary = 30000;
                Tax = Salary * (35f / 100);
            }
        }
    }
}
