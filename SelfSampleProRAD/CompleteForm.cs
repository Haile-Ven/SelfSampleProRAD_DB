using Azure;
using SelfSampleProRAD_DB;
using SelfSampleProRAD_DB.Controller;
using SelfSampleProRAD_DB.DTOs;
using SelfSampleProRAD_DB.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
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
            mainTab.Visible = false;
            loginPanel.Visible = true;
            LogoutBtn.Visible = false;
            loginInfoLbl.Text = string.Empty;
        }

        private void LogAccess(int logStat)
        {
            string status = logStat == 1 ? "Success" : "Failed";
            string msg = $"{userNameTxt.Text,-50} {status} at {DateTime.Now}\n";
            File.AppendAllText("System Access log.txt", msg);
        }

        private void Logout()
        {
            userNameTxt.Text = String.Empty;
            passwordTxt.Text = String.Empty;
            mainTab.Visible = false;
            mainTab.TabPages.Clear();
            loginPanel.Visible = true;
            loginInfoLbl.Text = string.Empty;
            LogoutBtn.Visible = false;
            Text = "Employee Full Portal";
        }

        private string CatagorySelector()
        {
            if (fullTimeRadBtn.Checked) return fullTimeRadBtn.Text;
            if (partimeRdBtn.Checked) return partimeRdBtn.Text;
            if (contrRdBtn.Checked) return contrRdBtn.Text;
            else return string.Empty;
        }

        public void LoadProfile(EmployeeResponseDTO response)
        {
            empIDProfTxtBx.Text = response.EmployeeId.ToString();
            fNameProfTxtBx.Text = response.FirstName;
            lNameProfTxtBx.Text = response.LastName;
            genderProfTxtBx.Text = response.Gender.ToString();
            ageProfTxtBx.Text = response.Age.ToString();
            positionProfTxtBx.Text = response.Position;
            catagProfTxtBx.Text = response.Catagory;
            salaryProfTxtBx.Text = response.Salary.ToString();
            taxProfTxtBx.Text = response.Tax.ToString();
        }

        public void LoadEmployeeData()
        {
            employeeDataGrid.Rows.Clear();
            employeeDataGrid.CellContentClick -= EmployeeDataGrid_CellContentClick;
            employeeDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            employeeDataGrid.ColumnHeadersHeight = 40;
            employeeDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            var accounts = new AccountController().ListAllAccounts();
            foreach (var account in accounts)
            {
                int rowIndex = employeeDataGrid.Rows.Add(account.UserId, account.UserName, account.Status);
                // Style the action button
                var actionCell = employeeDataGrid.Rows[rowIndex].Cells["ActionBtnClm"];
                bool isActive = account.Status == 'A';
                actionCell.Value = isActive ? "Deactivate" : "Activate";
                Color buttonColor = isActive ? Color.IndianRed : Color.ForestGreen;
                actionCell.Style.ForeColor = Color.White;
                actionCell.Style.BackColor = buttonColor;
            }
            employeeDataGrid.CellContentClick += EmployeeDataGrid_CellContentClick;
        }

        public void LoadTasksBy(Guid taskBy)
        {
            taskAsgTbl.DataSource = new TasksController().ViewTasksBy(taskBy).Item1;
        }

        public void LoadTasksFor(Guid taskBy)
        {
            var tasks = new TasksController().ViewTasksFor(taskBy).Item1;
            var bindingSource = new BindingSource();
            bindingSource.DataSource = tasks.Select(t => new
            {
                DisplayName = $"{t.FirstName} {t.LastName} - {t.TaskName} ({t.Status})",
                TaskId = t.TaskId
            }).ToList();

            emptaskListBox.DataSource = bindingSource;
            emptaskListBox.DisplayMember = "DisplayName";
            emptaskListBox.ValueMember = "TaskId";
        }

        public void LoadUseComboBox(Guid empID)
        {
            taskAsgTbl.DataSource = new TasksController().ViewTasksFor(empID);
            var userIds = new AccountController()
                .ListAllDevs()
                .Select(d => d.UserId);

            var employees = userIds
                .Select(id => new EmployeeController().SelectEmployeeByUserId(id))
                .ToList();

            asgToCmbBx.DataSource = employees
                .Select(usr => new
                {
                    Display = $"{usr.FirstName} {usr.LastName} ({usr.Account.UserName})",
                    Value = usr.EmployeeId
                })
                .ToList();

            asgToCmbBx.DisplayMember = "Display";
            asgToCmbBx.ValueMember = "Value";
        }

        //Event handlers
        private void LoginBtb_Click(object sender, EventArgs e)
        {
            var response = new AccountController().Login(userNameTxt.Text, passwordTxt.Text);

            if (response.Item1 == null)
            {
                loginInfoLbl.Text = response.Item2;
                LogAccess(0);
                return;
            }
            LogoutBtn.Visible = true;
            loginPanel.Visible = false;
            mainTab.Visible = true;

            // Clear all tab pages first
            mainTab.TabPages.Clear();

            // Load tabs based on position
            switch (response.Item1.Position)
            {
                case "Developer":
                    Text = "Developer Dashboard";
                    mainTab.TabPages.Add(employeeProfileTab);
                    mainTab.TabPages.Add(employeeTaskTab);
                    break;

                case "Project Manager":
                    Text = "Manager Dashboard";
                    mainTab.TabPages.Add(employeeProfileTab);
                    mainTab.TabPages.Add(taskManTab);
                    break;

                case "Admin":
                    Text = "Admin Dashboard";
                    mainTab.TabPages.Add(employeeProfileTab);
                    mainTab.TabPages.Add(AddNewTabPage);
                    mainTab.TabPages.Add(viewTabPage);
                    LoadEmployeeData();
                    break;

                default:
                    loginInfoLbl.Text = "Invalid User Position.";
                    return;
            }
            mainTab.SelectedTab = employeeProfileTab;
            LoadProfile(response.Item1);
            LogAccess(1);
        }

        private void AddTaskLkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.addTaskPanel.Visible = true;
        }

        private void ManClsLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.addTaskPanel.Visible = false;
            asgToCmbBx.SelectedItem = null;
            tskNmTxtBx.Text = null;
        }

        private void UserNameTxt_TextChanged(object sender, EventArgs e)
        {
            this.loginInfoLbl.Text = string.Empty;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            char gender = 'O';
            gender = genderSelect.Text == "Male" ? 'M' : 'F';
            var response = new EmployeeController()
                .AddEmployee(firstNameTxtBx.Text,
                lastNameTxtBx.Text,
                gender,
                Convert.ToByte(ageTxtBx.Text),
                positionSelect.Text,
                CatagorySelector());
            MessageBox.Show(response, "Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DobSelector_ValueChanged(object sender, EventArgs e)
        {
            ageTxtBx.Text = (DateTime.Now.Year - dobSelector.Value.Year).ToString();
        }

        private void CngPwdLkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pwdChangePanel.Visible = true;
        }

        private void ClsPwdCngLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pwdChangePanel.Visible = false;
        }

        private void CngPwdBtn_Click(object sender, EventArgs e)
        {
            if (oldPwdTxtBx.Text == nwPwdTxtBx.Text)
            {
                MessageBox.Show("Old and New Passwords cannot be the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (reNwPwdTxtBx.Text != nwPwdTxtBx.Text)
            {
                MessageBox.Show("New Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var response = new AccountController().ChangePassword(Guid.Parse(empIDProfTxtBx.Text), oldPwdTxtBx.Text, nwPwdTxtBx.Text);
            MessageBox.Show(response, "Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pwdChangePanel.Visible = false;
        }

        private void SubmitTaskBtn_Click(object sender, EventArgs e)
        {
            if (emptaskListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a task to start working on.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(doTaskRcTxtBx.Text))
            {
                MessageBox.Show("Please fill in the task details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var response = new TasksController().submitWork(Guid.Parse(emptaskListBox.SelectedValue.ToString()));
            doTaskRcTxtBx.Text = string.Empty;
            LoadTasksFor(Guid.Parse(empIDProfTxtBx.Text));
            MessageBox.Show(response, "Task", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AsgnTaskBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tskNmTxtBx.Text) || asgToCmbBx.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            asgToCmbBx.SelectedValue.ToString();
            var response = new TasksController().AssignTask(tskNmTxtBx.Text, Guid.Parse(asgToCmbBx.SelectedValue.ToString()), Guid.Parse(empIDProfTxtBx.Text));
            MessageBox.Show(response.Item2);
            addTaskPanel.Visible = false;
            LoadTasksBy(Guid.Parse(empIDProfTxtBx.Text));
        }

        private void DoTaskRcTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (emptaskListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a task to start working on.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _ = new TasksController().startWorking(Guid.Parse(emptaskListBox.SelectedValue.ToString()));
            if (!emptaskListBox.Text.Contains("Started")) LoadTasksFor(Guid.Parse(empIDProfTxtBx.Text));
        }

        private void MainTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainTab.SelectedTab == viewTabPage)
            {
                LoadEmployeeData();
            }

            if (mainTab.SelectedTab == taskManTab)
            {
                LoadUseComboBox(Guid.Parse(empIDProfTxtBx.Text));
                LoadTasksBy(Guid.Parse(empIDProfTxtBx.Text));
            }

            if (mainTab.SelectedTab == employeeTaskTab)
            {
                LoadTasksFor(Guid.Parse(empIDProfTxtBx.Text));
            }


        }
        private void EmployeeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var msg = employeeDataGrid.Rows[e.RowIndex].Cells["StatusClm"].Value.ToString() == "A" ? "Deactivate" : "Activate";
            if (e.RowIndex >= 0 && employeeDataGrid.Columns[e.ColumnIndex].Name == "ActionBtnClm"
                && MessageBox.Show($"Are You Sure You Want To {msg}", "Account Change", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                == DialogResult.OK)
            {
                var userid = Guid.Parse(employeeDataGrid.Rows[e.RowIndex].Cells["UserIdClm"].Value.ToString());
                var response = new AccountController().ChangeAccountStatus(userid);
                LoadEmployeeData();
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void EditProfileLkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditControl editControl = new EditControl
                (
                new EmployeeEditDTO
                {
                    EmployeeId = Guid.Parse(empIDProfTxtBx.Text),
                    FirstName = fNameProfTxtBx.Text,
                    LastName = lNameProfTxtBx.Text,
                    Gender = genderProfTxtBx.Text[0],
                    Age = Convert.ToByte(ageProfTxtBx.Text)
                }
                );
            editControl.Location = new Point(50, 50);
            Controls.Add(editControl);
            editControl.BringToFront();
            editControl.UpdateBtnClicked += UpdateBtn_Click;
            editControl.clsEditControlLblClicked += (s, ev) => 
            { 
                Controls.Remove(editControl);
                editControl.Dispose();
            };
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            // Cast sender to Button and ensure it's not null
            var edBtn = sender as Button;
            
            var edC = edBtn.Parent as EditControl;
            var res = new EmployeeController().SelectEmployee(Guid.Parse(empIDProfTxtBx.Text));
            LoadProfile(new EmployeeResponseDTO
            {
                EmployeeId = res.EmployeeId,
                FirstName = res.FirstName,
                LastName = res.LastName,
                Gender = res.Gender,
                Age = res.Age,
                Position = res.Position,
                Salary = res.Salary,
                Tax = res.Tax,
                Catagory = res.Catagory
            });
            Controls.Remove(edC);
            edC.Dispose();
        }

    }
}