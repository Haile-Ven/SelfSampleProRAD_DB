using Azure;
using SelfSampleProRAD_DB;
using SelfSampleProRAD_DB.Controller;
using SelfSampleProRAD_DB.DTOs;
using SelfSampleProRAD_DB.UserControls;

namespace SelfSampleProRAD
{
    public partial class CompleteForm : Form
    {
        private ToastNotification toastNotification;

        public CompleteForm()
        {
            InitializeComponent();
            InitPanels();
            InitializeToastNotification();
        }

        //Methods
        private void InitPanels()
        {
            mainTab.Visible = false;
            loginPanel.Visible = true;
            LogoutBtn.Visible = false;
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
            ClearAll(this);
            loginPanel.Visible = true;
            LogoutBtn.Visible = false;
            Text = "Employee Full Portal";
            InitializeToastNotification();
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
        
        private void ClearAll(Control parentControl)
        {
            for (int i = parentControl.Controls.Count - 1; i >= 0; i--)
            {
                Control control = parentControl.Controls[i];

                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (control is ListBox listBox)
                {
                    listBox.ClearSelected();
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                else if (control is RichTextBox richTextBox)
                {
                    richTextBox.Clear();
                }
                else if (control is UserControl userControl)
                {
                    parentControl.Controls.Remove(control);
                    control.Dispose();
                }

                if (control.HasChildren)
                {
                    ClearAll(control);
                }
            }
        }

        // Ensure toast notification is properly initialized
        private void InitializeToastNotification()
        {
            // Dispose of existing toast notification if it exists
            if (toastNotification != null)
            {
                if (toastNotification.IsHandleCreated && !toastNotification.IsDisposed)
                {
                    toastNotification.Visible = false;
                    toastNotification.Dispose();
                }
                toastNotification = null;
            }
            
            // Create a new toast notification
            toastNotification = new ToastNotification();
            toastNotification.AttachToForm(this);
        }

        //Event handlers
        private void LoginBtb_Click(object sender, EventArgs e)
        {
            var response = new AccountController().Login(userNameTxt.Text, passwordTxt.Text);

            if (response.Item1 == null)
            {
                InitializeToastNotification();
                toastNotification.Show(response.Item2, "Login Failed", false);
                LogAccess(0);
                return;
            }
            LogoutBtn.Visible = true;
            loginPanel.Visible = false;
            mainTab.Visible = true;
            InitializeToastNotification();
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
                    toastNotification.Show("Invalid Position", "Error", false);
                    return;
            }
            toastNotification.Show(response.Item2, "Login Successful", true);
            mainTab.SelectedTab = employeeProfileTab;
            LoadProfile(response.Item1);
            LogAccess(1);
        }

        private void AddTaskLkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var assignTaskControl = new AssignTaskControl(Guid.Parse(empIDProfTxtBx.Text));
            Controls.Add(assignTaskControl);
            assignTaskControl.Location = new Point(50, 50);
            assignTaskControl.BringToFront();
            assignTaskControl.Show();
            assignTaskControl.ClsTaskControlLblClicked += (s, ev) =>
            {
                Controls.Remove(assignTaskControl);
                assignTaskControl.Dispose();
                LoadTasksBy(Guid.Parse(empIDProfTxtBx.Text));
            };
            assignTaskControl.AsgnTaskBtnClicked += (s, ev) =>
            {
                LoadTasksBy(Guid.Parse(empIDProfTxtBx.Text));
            };
            assignTaskControl.ShowNotification += (message, title, isSuccess) =>
            {
                InitializeToastNotification();
                toastNotification.Show(message, title, isSuccess);
            };
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
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
                InitializeToastNotification();
                toastNotification.Show(response.Item1, response.Item2 ? "Success" : "Faild", response.Item2);
                mainTab.SelectedTab = viewTabPage;
            }
            catch (Exception ex)
            {
                InitializeToastNotification();
                toastNotification.Show(ex.Message,"Error",false);
            }
        }

        private void DobSelector_ValueChanged(object sender, EventArgs e)
        {
            ageTxtBx.Text = (DateTime.Now.Year - dobSelector.Value.Year).ToString();
        }

        private void CngPwdLkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var cngPwdControl = new ChangePasswordControl(Guid.Parse(empIDProfTxtBx.Text));
            Controls.Add(cngPwdControl);
            cngPwdControl.Location = new Point(50, 50);
            cngPwdControl.BringToFront();
            cngPwdControl.Show();
            cngPwdControl.ClsPwdCngLblClicked += (s, ev) =>
            {
                Controls.Remove(cngPwdControl);
                cngPwdControl.Dispose();
            };
            cngPwdControl.CngPwdBtnClicked += (s, ev) =>
            {
                Controls.Remove(cngPwdControl);
                cngPwdControl.Dispose();
            };
            cngPwdControl.ShowNotification += (message, title, isSuccess) =>
            {
                InitializeToastNotification();
                toastNotification.Show(message, title, isSuccess);
            };
        }

        private void SubmitTaskBtn_Click(object sender, EventArgs e)
        {
            if (emptaskListBox.SelectedItem == null)
            {
                toastNotification.Show("Please select a task to start working on.", "Error", false);
                return;
            }

            if (string.IsNullOrEmpty(doTaskRcTxtBx.Text))
            {
                toastNotification.Show("Please fill in the task details.", "Error", false);
                return;
            }

            var response = new TasksController().submitWork(Guid.Parse(emptaskListBox.SelectedValue.ToString()));
            doTaskRcTxtBx.Text = string.Empty;
            LoadTasksFor(Guid.Parse(empIDProfTxtBx.Text));
            toastNotification.Show(response.Item1, response.Item2?"Success":"Failed",response.Item2);
        }

        private void DoTaskRcTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (emptaskListBox.SelectedItem == null)
            {
                toastNotification.Show("Please select a task to start working on.", "Error",false);
                return;
            }
            if(!emptaskListBox.Text.Contains("Started"))
            {
                var response = new TasksController().startWorking(Guid.Parse(emptaskListBox.SelectedValue.ToString()));
                toastNotification.Show(response.Item1, response.Item2 ? "Success" : "Failed", response.Item2);
                LoadTasksFor(Guid.Parse(empIDProfTxtBx.Text));
            }
        }

        private void MainTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainTab.SelectedTab == viewTabPage)
            {
                LoadEmployeeData();
            }

            if (mainTab.SelectedTab == taskManTab)
            {
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
                InitializeToastNotification();
                toastNotification.Show(response.Item1,response.Item2?"Success":"Failed", response.Item2);
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
            editControl.ShowNotification += (message, title, isSuccess) => {
                InitializeToastNotification();
                toastNotification.Show(message, title, isSuccess);
            };
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

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            firstNameTxtBx.Text = string.Empty;
            lastNameTxtBx.Text = string.Empty;
            genderSelect.SelectedIndex = -1;
            ageTxtBx.Text = string.Empty;
            dobSelector.Value = DateTime.Now;
            positionSelect.SelectedIndex = -1;
            fullTimeRadBtn.Checked = false;
            partimeRdBtn.Checked = false;
            contrRdBtn.Checked = false;
            salaryProfTxtBx.Text = string.Empty;
            taxProfTxtBx.Text = string.Empty;
        }
    }
}