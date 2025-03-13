using Azure;
using SelfSampleProRAD_DB.Controller;
using SelfSampleProRAD_DB.DTOs;
using System.Drawing; 
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
            loginInfoLbl.Text = string.Empty;
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
            mainTab.Visible = false;
            mainTab.TabPages.Clear();
            loginPanel.Visible = true;
            loginInfoLbl.Text = string.Empty;
        }

        private string CatagorySelector()
        {
            if (fullTimeRadBtn.Checked) return fullTimeRadBtn.Text;
            if (partimeRdBtn.Checked) return partimeRdBtn.Text;
            if (contrRdBtn.Checked) return contrRdBtn.Text;
            else return string.Empty;
        }

        public void LoadProfile(EmployeeDTO response)
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
            foreach(var account in accounts)
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
        //Event handlers
        private void loginBtb_Click(object sender, EventArgs e)
        {
            var response = new AccountController().Login(userNameTxt.Text, passwordTxt.Text);

            if (response.Item1 == null)
            {
                loginInfoLbl.Text = response.Item2;
                return;
            }

            loginPanel.Visible = false;
            mainTab.Visible = true;

            // Clear all tab pages first
            mainTab.TabPages.Clear();

            // Load tabs based on position
            switch (response.Item1.Position)
            {
                case "Developer":
                    mainTab.TabPages.Add(employeeProfileTab);
                    mainTab.TabPages.Add(employeeTaskTab);
                    break;

                case "Manager":
                    mainTab.TabPages.Add(employeeProfileTab);
                    mainTab.TabPages.Add(taskManTab);
                    break;

                case "Admin":
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

        }

        private void dobSelector_ValueChanged(object sender, EventArgs e)
        {
            ageTxtBx.Text = (DateTime.Now.Year - dobSelector.Value.Year).ToString();
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

        }

        private void submitTaskBtn_Click(object sender, EventArgs e)
        {

        }

        private void asgnTaskBtn_Click(object sender, EventArgs e)
        {

        }

        private void doTaskRcTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void EmployeeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var msg = employeeDataGrid.Rows[e.RowIndex].Cells["StatusClm"].Value.ToString() == "A"?"Deactivate":"Activate";
            if (MessageBox.Show($"Are You Sure You Want To {msg}", "Account Change", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (e.RowIndex >= 0 && employeeDataGrid.Columns[e.ColumnIndex].Name == "ActionBtnClm")
                {
                    var userid = Guid.Parse(employeeDataGrid.Rows[e.RowIndex].Cells["UserIdClm"].Value.ToString());
                    var response = new AccountController().ChangeAccountStatus(userid);
                    LoadEmployeeData();
                }
            }
        }
    }

}