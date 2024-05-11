using SelfSampleProRAD_DB;
namespace SelfSampleProRAD
{
    public partial class CompleteForm : Form
    {
        Employee singleEmployee;
        Account singleAccount;
        Tasks singleTask;
        List<Employee> employeeList = new List<Employee>();
        List<Account> accountList = new List<Account>();
        List<Tasks> taskList = new List<Tasks>();
        public CompleteForm()
        {
            InitializeComponent();
            InitPanels();
        }

        //Methods
        private void InitPanels()
        {
            this.adminPanel.Visible = false;
            this.managerPanel.Visible = false;
            this.devPanel.Visible = false;
            this.loginPanel.Visible = true;
            this.loginInfoLbl.Text = string.Empty;
        }
        private void OnPanelLoad(Employee emp)
        {
            empIDProfTxtBx.Text = emp.EmployeeID;
            fNameProfTxtBx.Text = emp.FirstName;
            lNameProfTxtBx.Text = emp.LastName;
            ageProfTxtBx.Text = emp.Age.ToString();
            genderProfTxtBx.Text = emp.Gender.ToString();
            positionProfTxtBx.Text = emp.Position.ToString();
            catagProfTxtBx.Text = emp.Catagory.ToString();
            salaryProfTxtBx.Text = emp.Salary.ToString();
            taxProfTxtBx.Text = emp.Tax.ToString();
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
            adminPanel.Visible = false;
            managerPanel.Visible = false;
            devPanel.Visible = false;
            loginPanel.Visible = true;
        }
        //List All accounts for Admin
        private void PopulateAccountTable()
        {
            accountList.Clear();
            employeeDataGrid.Rows.Clear();
            singleAccount = new Account();
            SqlDataReader rec = singleAccount.ListAllAccounts();
            if (rec.HasRows)
            {
                while (rec.Read())
                {
                    accountList.Add(new Account(Convert.ToInt32(rec["UserID"]), rec["Username"].ToString(), rec["Password"].ToString(), Convert.ToChar(rec["Status"])));
                }
            }
            rec.Close();
            try
            {
                
                foreach (var account in accountList)
                {
                    employeeDataGrid.Rows.Add(account.UserID, account.UserName, account.Status == 'A' ? "Active" : "Inactive");
                    var rowIndex = employeeDataGrid.Rows.Count - 1; // Get the index of the newly added row
                    var button = new DataGridViewButtonCell(); // Create a new button cell
                    button.FlatStyle = FlatStyle.Flat;
                    if(account.Status == 'A')
                    {
                        button.Value = "Deactivate";
                        button.Style.BackColor = Color.IndianRed;
                        employeeDataGrid.Rows[rowIndex].Cells["accStatusClm"].Style.BackColor = Color.LimeGreen;
                    }
                    else 
                    {
                        button.Value = "Activate";
                        button.Style.BackColor = Color.LimeGreen;
                        employeeDataGrid.Rows[rowIndex].Cells["accStatusClm"].Style.BackColor = Color.IndianRed;
                    }
                    button.Value = account.Status == 'A' ? "Deactivate" : "Activate"; // Set button text based on status
                    employeeDataGrid.Rows[rowIndex].Cells["cngStBtn"] = button; // Set the button cell to the specific column "ChangeStatus"
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //List Tasks Assigned by Manager
        private void PopulateTasksTable_man()
        {
            // List All Accounts to display on combo box
            List<Account> locAcc = new List<Account>();
            singleAccount = new Account();
            SqlDataReader Arec = singleAccount.ListAllDevs();
            if (Arec.HasRows)
            {
                while (Arec.Read())
                {
                    locAcc.Add(new Account(Convert.ToInt32(Arec["UserID"]), Arec["Username"].ToString(), Arec["Password"].ToString()
                    , Convert.ToChar(Arec["Status"])));
                }
            }
            Arec.Close();
            foreach (Account account in locAcc)
            {
                asgToCmbBx.Items.Add(account.UserName);
            }
            //
            taskAsgTbl.Rows.Clear();
            taskList.Clear();
            singleTask = new Tasks();
            SqlDataReader Tskrec = singleTask.ViewTasksTo(userNameTxt.Text);
            if (Tskrec.HasRows)
            {
                while (Tskrec.Read())
                {
                    taskList.Add(new Tasks(Convert.ToInt32(Tskrec["TaskID"]), Tskrec["TaskName"].ToString(), Tskrec["AssignedTo"].ToString(),
                    Tskrec["AssignedBy"].ToString(), Convert.ToChar(Tskrec["Status"])));

                }
            }
            Tskrec.Close();
            try
            {
                string st = null;
                for (int i = 0; i < taskList.Count; i++)
                {
                    if (taskList[i].Status == 'U') st = "Undone";
                    else if (taskList[i].Status == 'D') st = "Done";
                    else if (taskList[i].Status == 'P') st = "Pending";
                    this.taskAsgTbl.Rows.Insert(i, taskList[i].TaskId, taskList[i].TaskName, taskList[i].AssignedTo, st);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void PopulateTasksTable_dev()
        {
            // List All Accounts to display on combo box
            emptaskListBox.Items.Clear();
            taskList.Clear();
            singleTask = new Tasks();
            SqlDataReader Tskrec = singleTask.ViewTasksFor(userNameTxt.Text);
            if (Tskrec.HasRows)
            {
                while (Tskrec.Read())
                {
                    taskList.Add(new Tasks(Convert.ToInt32(Tskrec["TaskID"]), Tskrec["TaskName"].ToString(), Tskrec["AssignedTo"].ToString(),
                    Tskrec["AssignedBy"].ToString(), Convert.ToChar(Tskrec["Status"])));

                }
            }
            Tskrec.Close();
            try
            {
                string st = null;
                for (int i = 0; i < taskList.Count; i++)
                {
                    emptaskListBox.Items.Add(taskList[i].TaskId+"_"+taskList[i].TaskName + "(" + taskList[i].AssignedBy + ")");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private string CatagorySelector()
        {
            if (fullTimeRadBtn.Checked) return fullTimeRadBtn.Text;
            if (partimeRdBtn.Checked) return partimeRdBtn.Text;
            if (contrRdBtn.Checked) return contrRdBtn.Text;
            else return string.Empty;
        }
        //Event handlers
        private void loginBtb_Click(object sender, EventArgs e)
        {
            singleEmployee = new Employee();
            singleEmployee.SelectEmployee(userNameTxt.Text, passwordTxt.Text);
            if (singleEmployee.Position == "Admin" && singleEmployee.Status == 'A')
            {
                this.Text = "Admin Page";
                this.adminPanel.Visible = true;
                this.managerPanel.Visible = false;
                this.devPanel.Visible = false;
                this.loginPanel.Visible = false;
                //Populate table
                PopulateAccountTable();
                LogAccess(1);
            }
            else if (singleEmployee.Position == "Developer" && singleEmployee.Status == 'A')
            {
                this.Text = "Developer Page";
                this.adminPanel.Visible = false;
                this.managerPanel.Visible = false;
                this.devPanel.Visible = true;
                this.loginPanel.Visible = false;
                OnPanelLoad(singleEmployee);
                PopulateTasksTable_dev();
                LogAccess(1);
            }
            else if (singleEmployee.Position == "Manager" && singleEmployee.Status == 'A')
            {
                this.Text = "Manager Page";
                adminPanel.Visible = false;
                this.managerPanel.Visible = true;
                this.devPanel.Visible = false;
                this.loginPanel.Visible = false;
                PopulateTasksTable_man();
                LogAccess(1);
            }
            else if (singleEmployee.Status == 'D') { loginInfoLbl.Text = "Account Deactivated"; LogAccess(0); }
            else { loginInfoLbl.Text = "Wrong Username or Password"; LogAccess(0); }

        }
        private void devLogoutLbl1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Logout();
        }

        private void devLogoutLbl2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Logout();
        }


        private void manLogoutLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Logout();
        }

        private void adminLogoutLbl2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Logout();
        }

        private void adminLogoutLbl1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Logout();
        }

        private void newEmpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.adminTabCrtl.SelectedTab = this.AddNewTabPage;
        }

        private void addTaskLkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.addTaskPanel.Visible = true;
        }

        private void manClsLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.addTaskPanel.Visible = false;
            asgToCmbBx.SelectedItem = null;
            tskIdTxtBx.Text = null;
            tskNmTxtBx.Text = null;
               
        }

        private void userNameTxt_TextChanged(object sender, EventArgs e)
        {
            this.loginInfoLbl.Text = string.Empty;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Employee empl = new Employee();
            char gend;
            if (genderSelect.Text == "Male") gend = 'M';
            else if (genderSelect.Text == "Female") gend = 'F';
            else gend = 'O';
            empl.calaculateTax();
            salaryTxtBx.Text = empl.Salary.ToString();
            taxTxtBx.Text = empl.Tax.ToString();
            empl.AddEmployee(empIdTxtBx.Text, fNameTxtBx.Text, lastNameTxtBx.Text,
                gend, Convert.ToByte(ageTxtBx.Text), positionSelect.Text, CatagorySelector());
            employeeList.Add(empl);
            if (MessageBox.Show("Save Successful", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                empIdTxtBx.Text = string.Empty;
                fNameTxtBx.Text = string.Empty;
                lastNameTxtBx.Text = string.Empty;
                ageTxtBx.Text = string.Empty; positionSelect.SelectedItem = null;
                salaryTxtBx.Text = string.Empty;
                taxTxtBx.Text = string.Empty;
                this.adminTabCrtl.SelectedTab = this.viewTabPage;
                employeeDataGrid.Rows.Clear();
                PopulateAccountTable();
            }
        }

        private void dobSelector_ValueChanged(object sender, EventArgs e)
        {
            ageTxtBx.Text = (DateTime.Now.Year - dobSelector.Value.Year).ToString();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            employeeDataGrid.Rows.Clear();
            PopulateAccountTable();
        }

        private void cngPwdLkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pwdChangePanel.Visible = true;
        }

        private void clsPwdCngLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pwdChangePanel.Visible = false;
        }

        private void cngPwdBtn_Click(object sender, EventArgs e)
        {
            if (nwPwdTxtBx.Text == reNwPwdTxtBx.Text)
            {
                if (singleEmployee.changePassword(oldPwdTxtBx.Text, nwPwdTxtBx.Text) == 1)
                {
                    if (MessageBox.Show("Password Changed Successfully", "Password Change", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        pwdChangePanel.Visible = false;
                    }
                }
                else
                {
                    _ = MessageBox.Show("Unable To Change Password", "Password Change", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else _ = MessageBox.Show("Password doen't Match", "Password Change", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void employeeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == employeeDataGrid.Columns["cngStBtn"].Index)
            {
                string username = employeeDataGrid.Rows[e.RowIndex].Cells["usrNameClm"].Value.ToString();

                if (employeeDataGrid.Rows[e.RowIndex].Cells["accStatusClm"].Value.ToString() == "Active")
                {
                    if (MessageBox.Show("Are You Sure You Want To Deactivate This Account?", "Change Account Status",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (singleEmployee.deactivateAccount(username) == 1)
                        {
                            MessageBox.Show("Account Deactivated", "Account Access Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Account Deactivation Failed", "Account Access Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (employeeDataGrid.Rows[e.RowIndex].Cells["accStatusClm"].Value.ToString() == "Inactive")
                {
                    if (MessageBox.Show("Are You Sure You Want To Activate This Account?", "Change Account Status",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (singleEmployee.activateAccount(username) == 1)
                        {
                            MessageBox.Show("Account Activated", "Account Access Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Account Activation Failed", "Account Access Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                PopulateAccountTable();
            }
        }

        private void submitTaskBtn_Click(object sender, EventArgs e)
        {
            Tasks tsk = new Tasks();
            if (tsk.submitWork(Convert.ToInt32(emptaskListBox.Text.Split("_")[0])) == 1) 
            { 
                MessageBox.Show("Tasked Submitted Successfully", "Task Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                emptaskListBox.ClearSelected();
                doTaskRcTxtBx.Clear();
                PopulateTasksTable_dev();
            } 
        }

        private void asgnTaskBtn_Click(object sender, EventArgs e)
        {
            Tasks tsk = new Tasks();
            int rws = tsk.AssignTask(Convert.ToInt32(tskIdTxtBx.Text), tskNmTxtBx.Text, asgToCmbBx.Text, userNameTxt.Text);
            if (rws > 0)
            {
                MessageBox.Show("Tasked Assigned Successfully", "Task Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateTasksTable_man();
            }
        }

        private void doTaskRcTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (emptaskListBox.SelectedItem != null)
            {
                Tasks tsk = new Tasks();
                tsk.startWorking(Convert.ToInt32(emptaskListBox.Text.Split("_")[0]));
            }
        }
    }

}