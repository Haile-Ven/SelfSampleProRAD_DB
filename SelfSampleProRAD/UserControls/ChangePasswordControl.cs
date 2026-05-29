using SelfSampleProRAD_DB.Controller;
using SelfSampleProRAD_DB_SQL.Controllers;

namespace SelfSampleProRAD_DB
{
    public partial class ChangePasswordControl : UserControl
    {
        public delegate void NotificationEventHandler(string message, string title, bool isSuccess);
        public event NotificationEventHandler ShowNotification;
        HelperMethodsUserControl _helper;

        Guid EmployeeID;
        public ChangePasswordControl()
        {
            InitializeComponent();
            _helper = new HelperMethodsUserControl(this);
            InitializeDragging();
        }

        public ChangePasswordControl(Guid EmployeeID)
        {
            InitializeComponent();
            _helper = new HelperMethodsUserControl(this);
            InitializeDragging();
            this.EmployeeID = EmployeeID;
        }

        public void InitializeDragging()
        {
            MouseDown += _helper._MouseDown;
            MouseMove += _helper._MouseMove;
            MouseUp += _helper._MouseUp;
            Click += _helper._Click;
        }
        public event EventHandler CngPwdBtnClicked;
        private void CngPwdBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(oldPwdTxtBx.Text) || string.IsNullOrEmpty(nwPwdTxtBx.Text) || string.IsNullOrEmpty(reNwPwdTxtBx.Text))
            {
                ShowNotification?.Invoke("Please Fill All Fields", "Error", false);
                return;
            }
            if (nwPwdTxtBx.Text != reNwPwdTxtBx.Text)
            {
                ShowNotification?.Invoke("New Password and Re-entered Password does not match.", "Error", false);
                return;
            }
            var response = new AccountController().ChangePassword(EmployeeID, oldPwdTxtBx.Text, nwPwdTxtBx.Text);
            ShowNotification?.Invoke(response.Item1, response.Item2 ? "Success" : "Failed", response.Item2);
            CngPwdBtnClicked?.Invoke(sender, e);
        }

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        private void ChangePasswordControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = e.Location;      
            }
        }

        private void ChangePasswordControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Left += e.X - startPoint.X;
                Top += e.Y - startPoint.Y;
            }
        }

        private void ChangePasswordControl_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;   
        }

        public event LinkLabelLinkClickedEventHandler ClsPwdCngLblClicked;
        private void ClsPwdCngLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClsPwdCngLblClicked?.Invoke(sender, e);
        }
    }
}
