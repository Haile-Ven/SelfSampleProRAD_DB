using System.Drawing.Drawing2D;

namespace SelfSampleProRAD_DB.UserControls
{
    public partial class ToastNotification : UserControl
    {
        private Form _parentForm;
        private System.Windows.Forms.Timer _notificationTimer;
        private bool _isErrorStyle = false;

        public ToastNotification()
        {
            InitializeComponent();
            this.Visible = false;

            _notificationTimer = new System.Windows.Forms.Timer
            {
                Interval = 5000   
            };
            _notificationTimer.Tick += (s, e) =>
            {
                this.Visible = false;
                _notificationTimer.Stop();
            };
        }

        public void AttachToForm(Form parentForm)
        {
            _parentForm = parentForm;

            if (!_parentForm.Controls.Contains(this))
            {
                _parentForm.Controls.Add(this);
            }

            _parentForm.Resize += (s, e) =>
            {
                if (this.Visible)
                {
                    PositionNotification();
                }
            };
        }

        private void PositionNotification()
        {
            if (_parentForm != null)
            {
                this.Location = new Point(
                    20,    
                    _parentForm.ClientSize.Height - this.Height - 20);    
            }
        }

        public void Show(string message, string title = "SUCCESS", bool isSuccess = true)
        {
            if (_parentForm == null)
            {
                throw new InvalidOperationException("Toast notification must be attached to a form before showing. Call AttachToForm first.");
            }

            titleLabel.Text = title;
            messageLabel.Text = message;

            _isErrorStyle = !isSuccess;
            UpdateStyle();

            PositionNotification();

            this.BringToFront();
            this.Visible = true;

            _notificationTimer.Start();
        }

        private void UpdateStyle()
        {
            if (_isErrorStyle)
            {
                titleLabel.ForeColor = Color.FromArgb(255, 99, 71);     
                iconPictureBox.Image = CreateErrorImage();
            }
            else
            {
                titleLabel.ForeColor = Color.FromArgb(76, 175, 80);    
                iconPictureBox.Image = CreateCheckmarkImage();
            }
            this.Invalidate();   
        }

        private Image CreateCheckmarkImage()
        {
            Bitmap bmp = new Bitmap(24, 24);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(Color.FromArgb(76, 175, 80), 3))
                {
                    g.DrawLines(pen, new Point[] {
                        new Point(5, 12),
                        new Point(10, 17),
                        new Point(19, 7)
                    });
                }
            }
            return bmp;
        }

        private Image CreateErrorImage()
        {
            Bitmap bmp = new Bitmap(24, 24);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(Color.FromArgb(255, 99, 71), 3))
                {
                    g.DrawLine(pen, 6, 6, 18, 18);
                    g.DrawLine(pen, 6, 18, 18, 6);
                }
            }
            return bmp;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Color borderColor = _isErrorStyle ?
                Color.FromArgb(255, 99, 71) :     
                Color.FromArgb(76, 175, 80);     

            using (SolidBrush brush = new SolidBrush(borderColor))
            {
                e.Graphics.FillRectangle(brush, 0, 0, 5, this.Height);
            }

            using (Pen pen = new Pen(Color.FromArgb(230, 230, 230)))
            {
                e.Graphics.DrawLines(pen, new Point[] {
                    new Point(5, 0),
                    new Point(this.Width - 1, 0),
                    new Point(this.Width - 1, this.Height - 1),
                    new Point(5, this.Height - 1)
                });
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _notificationTimer.Stop();
        }
    }
}
