namespace SelfSampleProRAD_DB
{
    partial class ChangePasswordControl
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
            cngPwdBtn = new Button();
            oldPwdTxtBx = new TextBox();
            nwPwdTxtBx = new TextBox();
            reNwPwdTxtBx = new TextBox();
            reNwPwdLbl = new Label();
            clsPwdCngLbl = new LinkLabel();
            pwdCngLbl = new Label();
            nwPwdLbl = new Label();
            oldPwdLbl = new Label();
            SuspendLayout();
            // 
            // cngPwdBtn
            // 
            cngPwdBtn.BackColor = Color.MediumSeaGreen;
            cngPwdBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cngPwdBtn.ForeColor = SystemColors.ControlLightLight;
            cngPwdBtn.Location = new Point(186, 271);
            cngPwdBtn.Name = "cngPwdBtn";
            cngPwdBtn.Size = new Size(182, 45);
            cngPwdBtn.TabIndex = 17;
            cngPwdBtn.Text = "✏️ Update Password";
            cngPwdBtn.UseVisualStyleBackColor = false;
            cngPwdBtn.Click += CngPwdBtn_Click;
            // 
            // oldPwdTxtBx
            // 
            oldPwdTxtBx.Location = new Point(186, 124);
            oldPwdTxtBx.Name = "oldPwdTxtBx";
            oldPwdTxtBx.PasswordChar = '•';
            oldPwdTxtBx.Size = new Size(283, 27);
            oldPwdTxtBx.TabIndex = 16;
            // 
            // nwPwdTxtBx
            // 
            nwPwdTxtBx.Location = new Point(186, 171);
            nwPwdTxtBx.Name = "nwPwdTxtBx";
            nwPwdTxtBx.PasswordChar = '•';
            nwPwdTxtBx.Size = new Size(283, 27);
            nwPwdTxtBx.TabIndex = 15;
            // 
            // reNwPwdTxtBx
            // 
            reNwPwdTxtBx.Location = new Point(186, 212);
            reNwPwdTxtBx.Name = "reNwPwdTxtBx";
            reNwPwdTxtBx.PasswordChar = '•';
            reNwPwdTxtBx.Size = new Size(283, 27);
            reNwPwdTxtBx.TabIndex = 14;
            // 
            // reNwPwdLbl
            // 
            reNwPwdLbl.AutoSize = true;
            reNwPwdLbl.Location = new Point(13, 218);
            reNwPwdLbl.Name = "reNwPwdLbl";
            reNwPwdLbl.Size = new Size(159, 20);
            reNwPwdLbl.TabIndex = 13;
            reNwPwdLbl.Text = "Reenter New Password";
            // 
            // clsPwdCngLbl
            // 
            clsPwdCngLbl.AutoSize = true;
            clsPwdCngLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clsPwdCngLbl.LinkBehavior = LinkBehavior.NeverUnderline;
            clsPwdCngLbl.LinkColor = Color.Red;
            clsPwdCngLbl.Location = new Point(478, 3);
            clsPwdCngLbl.Name = "clsPwdCngLbl";
            clsPwdCngLbl.Size = new Size(47, 31);
            clsPwdCngLbl.TabIndex = 12;
            clsPwdCngLbl.TabStop = true;
            clsPwdCngLbl.Text = "❌";
            clsPwdCngLbl.LinkClicked += ClsPwdCngLbl_LinkClicked;
            // 
            // pwdCngLbl
            // 
            pwdCngLbl.AutoSize = true;
            pwdCngLbl.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pwdCngLbl.Location = new Point(186, 60);
            pwdCngLbl.Name = "pwdCngLbl";
            pwdCngLbl.Size = new Size(157, 25);
            pwdCngLbl.TabIndex = 11;
            pwdCngLbl.Text = "Change Password";
            // 
            // nwPwdLbl
            // 
            nwPwdLbl.AutoSize = true;
            nwPwdLbl.Location = new Point(13, 174);
            nwPwdLbl.Name = "nwPwdLbl";
            nwPwdLbl.Size = new Size(104, 20);
            nwPwdLbl.TabIndex = 10;
            nwPwdLbl.Text = "New Password";
            // 
            // oldPwdLbl
            // 
            oldPwdLbl.AutoSize = true;
            oldPwdLbl.Location = new Point(13, 131);
            oldPwdLbl.Name = "oldPwdLbl";
            oldPwdLbl.Size = new Size(98, 20);
            oldPwdLbl.TabIndex = 9;
            oldPwdLbl.Text = "Old Password";
            // 
            // ChangePasswordControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(cngPwdBtn);
            Controls.Add(oldPwdTxtBx);
            Controls.Add(nwPwdTxtBx);
            Controls.Add(reNwPwdTxtBx);
            Controls.Add(reNwPwdLbl);
            Controls.Add(clsPwdCngLbl);
            Controls.Add(pwdCngLbl);
            Controls.Add(nwPwdLbl);
            Controls.Add(oldPwdLbl);
            Name = "ChangePasswordControl";
            Size = new Size(527, 352);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cngPwdBtn;
        private TextBox oldPwdTxtBx;
        private TextBox nwPwdTxtBx;
        private TextBox reNwPwdTxtBx;
        private Label reNwPwdLbl;
        private LinkLabel clsPwdCngLbl;
        private Label pwdCngLbl;
        private Label nwPwdLbl;
        private Label oldPwdLbl;
    }
}
