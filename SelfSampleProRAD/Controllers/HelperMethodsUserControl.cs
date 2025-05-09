namespace SelfSampleProRAD_DB_SQL.Controllers
{
    class HelperMethodsUserControl
    {
        UserControl _userControl;
        public HelperMethodsUserControl(UserControl userControl)
        {
            _userControl = userControl;
        }
        // Make User Control Draggable
        private bool isDragging = false;
        private Point StartingPosition = new Point(0, 0);

        public void _MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                StartingPosition = e.Location; // Save the initial mouse position
            }
        }

        public void _MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                _userControl.BringToFront();
                var newX = _userControl.Location.X + e.X - StartingPosition.X;
                var newY = _userControl.Location.Y + e.Y - StartingPosition.Y;
                _userControl.Location = new Point(newX, newY);
            }
        }

        public void _MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false; // Stop dragging
        }

        public void _Click(object sender, EventArgs e) 
        {
            _userControl.BringToFront();
        }
    }
}
