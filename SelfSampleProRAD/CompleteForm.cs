using SelfSampleProRAD_DB.Model;
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
            
        }
        private void LogAccess(int logStat)
        {
            
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
        
        //List Tasks Assigned by Manager
        
       
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
            
        }

        private void dobSelector_ValueChanged(object sender, EventArgs e)
        {
            ageTxtBx.Text = (DateTime.Now.Year - dobSelector.Value.Year).ToString();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            employeeDataGrid.Rows.Clear();
            
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

        private void employeeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }

}