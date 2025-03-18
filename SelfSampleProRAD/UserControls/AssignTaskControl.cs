using SelfSampleProRAD_DB.Controller;

namespace SelfSampleProRAD_DB
{
    public partial class AssignTaskControl : UserControl
    {
        Guid employeeID;
        public AssignTaskControl()
        {
            InitializeComponent();
            MouseDown += AssignTaskControl_MouseDown;
            MouseMove += AssignTaskControl_MouseMove;
            MouseUp += AssignTaskControl_MouseUp;
        }

        public AssignTaskControl(Guid employeeID)
        {
            InitializeComponent();
            MouseDown += AssignTaskControl_MouseDown;
            MouseMove += AssignTaskControl_MouseMove;
            MouseUp += AssignTaskControl_MouseUp;
            this.employeeID = employeeID;
            LoadUseComboBox(employeeID);
        }

        public void LoadUseComboBox(Guid empID)
        {
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

        // Make User Control Draggable
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        private void AssignTaskControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = e.Location; // Save the initial mouse position
            }
        }

        private void AssignTaskControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Calculate the new position based on mouse movement
                Left += e.X - startPoint.X;
                Top += e.Y - startPoint.Y;
            }
        }

        private void AssignTaskControl_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false; // Stop dragging
        }

        public event EventHandler AsgnTaskBtnClicked;
        private void AsgnTaskBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tskNmTxtBx.Text) || asgToCmbBx.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            asgToCmbBx.SelectedValue.ToString();
            var response = new TasksController()
                .AssignTask(
                    tskNmTxtBx.Text,
                    Guid.Parse(asgToCmbBx.SelectedValue.ToString()),
                    employeeID);
            MessageBox.Show(response.Item2, "Task Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AsgnTaskBtnClicked?.Invoke(sender, e);
        }

        // Transfer Close Link Lable Event Handler To CompleteForm
        public event LinkLabelLinkClickedEventHandler ClsTaskControlLblClicked;
        private void ClsTaskControlLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClsTaskControlLblClicked?.Invoke(sender, e);
        }
    }
}
