using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private Point startPoint = new Point(0, 0);

        public void _MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = e.Location; // Save the initial mouse position
            }
        }

        public void _MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Calculate the new position based on mouse movement
                _userControl.Left += e.X - startPoint.X;
                _userControl.Top += e.Y - startPoint.Y;
            }
        }

        public void _MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false; // Stop dragging
        }
    }
}
