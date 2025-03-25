namespace SelfSampleProRAD
{
    public partial class CompleteForm : Form
    {
        public CompleteForm()
        {
            InitializeComponent();
            InitPanels();
        }

        //Methods
        private void InitPanels()
        {
            this.loginPanel.Visible = true;
        }
        
        private void LogAccess(int logStat)
        {
            string status = logStat == 1 ? "Success" : "Failed";
            string msg = String.Format($"{userNameTxt.Text} {" ",50:D} {status} at {DateTime.Now.ToString()}\n");
            File.AppendAllText("System Access log.txt", msg);
        }
        private void Logout()
        {
            userNameTxt.Text = String.Empty;
            passwordTxt.Text = String.Empty;
            loginPanel.Visible = true;
        }
        //List All accounts for Admin
        private void PopulateAccountTable()
        {
            //accountList.Clear();
            //employeeDataGrid.Rows.Clear();
            //singleAccount = new Account();
            //SqlDataReader rec = singleAccount.ListAllAccounts();
            //if (rec.HasRows)
            //{
            //    while (rec.Read())
            //    {
            //        accountList.Add(new Account(Convert.ToInt32(rec["UserID"]), rec["Username"].ToString(), rec["Password"].ToString(), Convert.ToChar(rec["Status"])));
            //    }
            //}
            //rec.Close();
            //try
            //{

            //    foreach (var account in accountList)
            //    {
            //        employeeDataGrid.Rows.Add(account.UserID, account.UserName, account.Status == 'A' ? "Active" : "Inactive");
            //        var rowIndex = employeeDataGrid.Rows.Count - 1; // Get the index of the newly added row
            //        var button = new DataGridViewButtonCell(); // Create a new button cell
            //        button.FlatStyle = FlatStyle.Flat;
            //        if (account.Status == 'A')
            //        {
            //            button.Value = "Deactivate";
            //            button.Style.BackColor = Color.IndianRed;
            //            employeeDataGrid.Rows[rowIndex].Cells["accStatusClm"].Style.BackColor = Color.LimeGreen;
            //        }
            //        else
            //        {
            //            button.Value = "Activate";
            //            button.Style.BackColor = Color.LimeGreen;
            //            employeeDataGrid.Rows[rowIndex].Cells["accStatusClm"].Style.BackColor = Color.IndianRed;
            //        }
            //        button.Value = account.Status == 'A' ? "Deactivate" : "Activate"; // Set button text based on status
            //        employeeDataGrid.Rows[rowIndex].Cells["cngStBtn"] = button; // Set the button cell to the specific column "ChangeStatus"
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void PopulateTasksTable_dev()
        {
           
        }
        //Event handlers
        private void loginBtb_Click(object sender, EventArgs e)
        {
            

        }
        
        private void saveBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void dobSelector_ValueChanged(object sender, EventArgs e)
        {
            ageTxtBx.Text = (DateTime.Now.Year - dobSelector.Value.Year).ToString();
        }

       

        private void employeeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && e.ColumnIndex == employeeDataGrid.Columns["cngStBtn"].Index)
            //{
            //    string username = employeeDataGrid.Rows[e.RowIndex].Cells["usrNameClm"].Value.ToString();

            //    if (employeeDataGrid.Rows[e.RowIndex].Cells["accStatusClm"].Value.ToString() == "Active")
            //    {
            //        if (MessageBox.Show("Are You Sure You Want To Deactivate This Account?", "Change Account Status",
            //        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //        {
            //            if (singleEmployee.deactivateAccount(username) == 1)
            //            {
            //                MessageBox.Show("Account Deactivated", "Account Access Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            }
            //            else
            //            {
            //                MessageBox.Show("Account Deactivation Failed", "Account Access Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //    }
            //    else if (employeeDataGrid.Rows[e.RowIndex].Cells["accStatusClm"].Value.ToString() == "Inactive")
            //    {
            //        if (MessageBox.Show("Are You Sure You Want To Activate This Account?", "Change Account Status",
            //            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //        {
            //            if (singleEmployee.activateAccount(username) == 1)
            //            {
            //                MessageBox.Show("Account Activated", "Account Access Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //            else
            //            {
            //                MessageBox.Show("Account Activation Failed", "Account Access Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //    }
            //    PopulateAccountTable();
            //}
        }
    }

}