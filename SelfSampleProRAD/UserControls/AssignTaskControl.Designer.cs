namespace SelfSampleProRAD_DB
{
    partial class AssignTaskControl
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
            AsgnTaskBtn = new Button();
            asgToCmbBx = new ComboBox();
            tskNmTxtBx = new TextBox();
            assgToLbl = new Label();
            taskNameLbl = new Label();
            ClsTaskControlLbl = new LinkLabel();
            pwdCngLbl = new Label();
            SuspendLayout();
            // 
            // AsgnTaskBtn
            // 
            AsgnTaskBtn.BackColor = Color.MediumSeaGreen;
            AsgnTaskBtn.FlatStyle = FlatStyle.Flat;
            AsgnTaskBtn.ForeColor = SystemColors.ControlLightLight;
            AsgnTaskBtn.Location = new Point(202, 187);
            AsgnTaskBtn.Name = "AsgnTaskBtn";
            AsgnTaskBtn.Size = new Size(139, 42);
            AsgnTaskBtn.TabIndex = 19;
            AsgnTaskBtn.Text = "📝 Assign Task";
            AsgnTaskBtn.UseVisualStyleBackColor = false;
            AsgnTaskBtn.Click += AsgnTaskBtn_Click;
            // 
            // asgToCmbBx
            // 
            asgToCmbBx.DropDownStyle = ComboBoxStyle.DropDownList;
            asgToCmbBx.FlatStyle = FlatStyle.Popup;
            asgToCmbBx.FormattingEnabled = true;
            asgToCmbBx.Location = new Point(168, 132);
            asgToCmbBx.Name = "asgToCmbBx";
            asgToCmbBx.Size = new Size(237, 28);
            asgToCmbBx.TabIndex = 18;
            // 
            // tskNmTxtBx
            // 
            tskNmTxtBx.Location = new Point(168, 91);
            tskNmTxtBx.Name = "tskNmTxtBx";
            tskNmTxtBx.Size = new Size(237, 27);
            tskNmTxtBx.TabIndex = 17;
            // 
            // assgToLbl
            // 
            assgToLbl.AutoSize = true;
            assgToLbl.Location = new Point(64, 130);
            assgToLbl.Name = "assgToLbl";
            assgToLbl.Size = new Size(89, 20);
            assgToLbl.TabIndex = 16;
            assgToLbl.Text = "Assigned To";
            // 
            // taskNameLbl
            // 
            taskNameLbl.AutoSize = true;
            taskNameLbl.Location = new Point(64, 91);
            taskNameLbl.Name = "taskNameLbl";
            taskNameLbl.Size = new Size(80, 20);
            taskNameLbl.TabIndex = 15;
            taskNameLbl.Text = "Task Name";
            // 
            // ClsTaskControlLbl
            // 
            ClsTaskControlLbl.AutoSize = true;
            ClsTaskControlLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClsTaskControlLbl.LinkBehavior = LinkBehavior.NeverUnderline;
            ClsTaskControlLbl.LinkColor = Color.Red;
            ClsTaskControlLbl.Location = new Point(429, 3);
            ClsTaskControlLbl.Name = "ClsTaskControlLbl";
            ClsTaskControlLbl.Size = new Size(47, 31);
            ClsTaskControlLbl.TabIndex = 33;
            ClsTaskControlLbl.TabStop = true;
            ClsTaskControlLbl.Text = "❌";
            ClsTaskControlLbl.LinkClicked += ClsTaskControlLbl_LinkClicked;
            // 
            // pwdCngLbl
            // 
            pwdCngLbl.AutoSize = true;
            pwdCngLbl.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pwdCngLbl.Location = new Point(203, 34);
            pwdCngLbl.Name = "pwdCngLbl";
            pwdCngLbl.Size = new Size(106, 25);
            pwdCngLbl.TabIndex = 34;
            pwdCngLbl.Text = "Assign Task";
            // 
            // AssignTaskControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pwdCngLbl);
            Controls.Add(ClsTaskControlLbl);
            Controls.Add(AsgnTaskBtn);
            Controls.Add(asgToCmbBx);
            Controls.Add(tskNmTxtBx);
            Controls.Add(assgToLbl);
            Controls.Add(taskNameLbl);
            Name = "AssignTaskControl";
            Size = new Size(477, 258);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AsgnTaskBtn;
        private ComboBox asgToCmbBx;
        private TextBox tskNmTxtBx;
        private Label assgToLbl;
        private Label taskNameLbl;
        private LinkLabel ClsTaskControlLbl;
        private Label pwdCngLbl;
    }
}
