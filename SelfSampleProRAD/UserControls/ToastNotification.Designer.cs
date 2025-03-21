namespace SelfSampleProRAD_DB.UserControls
{
    partial class ToastNotification
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            messageLabel = new Label();
            iconPictureBox = new PictureBox();
            closeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.FromArgb(76, 175, 80);
            titleLabel.Location = new Point(55, 11);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(118, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "SUCCESS";
            // 
            // messageLabel
            // 
            messageLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageLabel.ForeColor = Color.FromArgb(100, 100, 100);
            messageLabel.Location = new Point(55, 48);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(454, 53);
            messageLabel.TabIndex = 1;
            messageLabel.Text = "Notification message";
            // 
            // iconPictureBox
            // 
            iconPictureBox.BackColor = Color.Transparent;
            iconPictureBox.Location = new Point(20, 11);
            iconPictureBox.Margin = new Padding(3, 4, 3, 4);
            iconPictureBox.Name = "iconPictureBox";
            iconPictureBox.Size = new Size(24, 30);
            iconPictureBox.TabIndex = 2;
            iconPictureBox.TabStop = false;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Transparent;
            closeButton.Cursor = Cursors.Hand;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.ForeColor = Color.Gray;
            closeButton.Location = new Point(503, -1);
            closeButton.Margin = new Padding(3, 4, 3, 4);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(24, 30);
            closeButton.TabIndex = 3;
            closeButton.Text = "×";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // ToastNotification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(closeButton);
            Controls.Add(iconPictureBox);
            Controls.Add(messageLabel);
            Controls.Add(titleLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ToastNotification";
            Size = new Size(531, 101);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Button closeButton;
    }
}
