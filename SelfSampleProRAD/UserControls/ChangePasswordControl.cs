using Microsoft.Identity.Client;
using SelfSampleProRAD_DB.Controller;

namespace SelfSampleProRAD_DB
{
    public partial class ChangePasswordControl : UserControl
    {
        Guid EmployeeID;
        public ChangePasswordControl()
        {
            InitializeComponent();
            MouseDown += ChangePasswordControl_MouseDown;
            MouseMove += ChangePasswordControl_MouseMove;
            MouseUp += ChangePasswordControl_MouseUp;
        }

        public ChangePasswordControl(Guid EmployeeID)
        {
            InitializeComponent();
            this.EmployeeID = EmployeeID;
            MouseDown += ChangePasswordControl_MouseDown;
            MouseMove += ChangePasswordControl_MouseMove;
            MouseUp += ChangePasswordControl_MouseUp;
        }
        // Transfer Update Button Click Event Handler To CompleteForm After Finishing Update
        public event EventHandler CngPwdBtnClicked;
        private void CngPwdBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(oldPwdTxtBx.Text) || string.IsNullOrEmpty(nwPwdTxtBx.Text) || string.IsNullOrEmpty(reNwPwdTxtBx.Text))
            {
                MessageBox.Show("Please Fill All Fields", "Fields Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nwPwdTxtBx.Text != reNwPwdTxtBx.Text)
            {
                MessageBox.Show("New Password and Re-entered Password does not match.", "Password Change", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(
                new AccountController().ChangePassword(
                EmployeeID,
                oldPwdTxtBx.Text,
                nwPwdTxtBx.Text
            ), "Password Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CngPwdBtnClicked?.Invoke(sender, e);
        }

        // Make User Control Draggable
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        private void ChangePasswordControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = e.Location; // Save the initial mouse position
            }
        }

        private void ChangePasswordControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Calculate the new position based on mouse movement
                Left += e.X - startPoint.X;
                Top += e.Y - startPoint.Y;
            }
        }

        private void ChangePasswordControl_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false; // Stop dragging
        }

        // Transfer Close Link Lable Event Handler To CompleteForm
        public event LinkLabelLinkClickedEventHandler ClsPwdCngLblClicked;
        private void ClsPwdCngLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClsPwdCngLblClicked?.Invoke(sender, e);
        }
    }
}
