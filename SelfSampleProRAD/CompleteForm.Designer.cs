namespace SelfSampleProRAD
{
    partial class CompleteForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            loginPanel = new Panel();
            loginInfoLbl = new Label();
            loginBtb = new Button();
            passwordLbl = new Label();
            userNameLbl = new Label();
            passwordTxt = new TextBox();
            userNameTxt = new TextBox();
            mainTab = new TabControl();
            employeeProfileTab = new TabPage();
            EditProfileLkLbl = new LinkLabel();
            pwdChangePanel = new Panel();
            cngPwdBtn = new Button();
            oldPwdTxtBx = new TextBox();
            nwPwdTxtBx = new TextBox();
            reNwPwdTxtBx = new TextBox();
            reNwPwdLbl = new Label();
            clsPwdCngLbl = new LinkLabel();
            pwdCngLbl = new Label();
            nwPwdLbl = new Label();
            oldPwdLbl = new Label();
            cngPwdLkLbl = new LinkLabel();
            catagProfTxtBx = new TextBox();
            positionProfTxtBx = new TextBox();
            genderProfTxtBx = new TextBox();
            ageProfTxtBx = new TextBox();
            taxProfTxtBx = new TextBox();
            salaryProfTxtBx = new TextBox();
            lNameProfTxtBx = new TextBox();
            fNameProfTxtBx = new TextBox();
            empIDProfTxtBx = new TextBox();
            taxProfLbl = new Label();
            salaryProfLbl = new Label();
            catgProfLbl = new Label();
            posProfLbl = new Label();
            genderProfLbl = new Label();
            empIdProfLbl = new Label();
            ageProfLbl = new Label();
            lNameProfLbl = new Label();
            fNameProfLbl = new Label();
            viewTabPage = new TabPage();
            employeeDataGrid = new DataGridView();
            UserIdClm = new DataGridViewTextBoxColumn();
            UsernameClm = new DataGridViewTextBoxColumn();
            StatusClm = new DataGridViewTextBoxColumn();
            ActionBtnClm = new DataGridViewButtonColumn();
            AddNewTabPage = new TabPage();
            clearBtn = new Button();
            saveBtn = new Button();
            regPanel = new Panel();
            contrRdBtn = new RadioButton();
            partimeRdBtn = new RadioButton();
            fullTimeRadBtn = new RadioButton();
            positionSelect = new ComboBox();
            genderSelect = new ComboBox();
            ageTxtBx = new TextBox();
            dobSelector = new DateTimePicker();
            taxTxtBx = new TextBox();
            salaryTxtBx = new TextBox();
            lastNameTxtBx = new TextBox();
            firstNameTxtBx = new TextBox();
            taxLbl = new Label();
            salaryLbl = new Label();
            catagoryLbl = new Label();
            positionLbl = new Label();
            genderLbl = new Label();
            ageLbl = new Label();
            lastNameLbl = new Label();
            firstNameLbl = new Label();
            employeeTaskTab = new TabPage();
            emptaskListBox = new ListBox();
            submitTaskBtn = new Button();
            doTaskRcTxtBx = new RichTextBox();
            empTaskLbl = new Label();
            taskManTab = new TabPage();
            addTaskPanel = new Panel();
            manClsLbl = new LinkLabel();
            asgnTaskBtn = new Button();
            asgToCmbBx = new ComboBox();
            tskNmTxtBx = new TextBox();
            assgToLbl = new Label();
            taskNameLbl = new Label();
            taskAsgTbl = new DataGridView();
            addTaskLkLbl = new LinkLabel();
            LogoutBtn = new Button();
            loginPanel.SuspendLayout();
            mainTab.SuspendLayout();
            employeeProfileTab.SuspendLayout();
            pwdChangePanel.SuspendLayout();
            viewTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeDataGrid).BeginInit();
            AddNewTabPage.SuspendLayout();
            regPanel.SuspendLayout();
            employeeTaskTab.SuspendLayout();
            taskManTab.SuspendLayout();
            addTaskPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskAsgTbl).BeginInit();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.Controls.Add(loginInfoLbl);
            loginPanel.Controls.Add(loginBtb);
            loginPanel.Controls.Add(passwordLbl);
            loginPanel.Controls.Add(userNameLbl);
            loginPanel.Controls.Add(passwordTxt);
            loginPanel.Controls.Add(userNameTxt);
            loginPanel.Location = new Point(3, -1);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(831, 613);
            loginPanel.TabIndex = 0;
            // 
            // loginInfoLbl
            // 
            loginInfoLbl.AutoSize = true;
            loginInfoLbl.ForeColor = Color.Red;
            loginInfoLbl.Location = new Point(279, 196);
            loginInfoLbl.Name = "loginInfoLbl";
            loginInfoLbl.Size = new Size(0, 20);
            loginInfoLbl.TabIndex = 10;
            // 
            // loginBtb
            // 
            loginBtb.Location = new Point(373, 334);
            loginBtb.Name = "loginBtb";
            loginBtb.Size = new Size(109, 37);
            loginBtb.TabIndex = 9;
            loginBtb.Text = "Login";
            loginBtb.UseVisualStyleBackColor = true;
            loginBtb.Click += LoginBtb_Click;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Location = new Point(169, 280);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(70, 20);
            passwordLbl.TabIndex = 8;
            passwordLbl.Text = "Password";
            // 
            // userNameLbl
            // 
            userNameLbl.AutoSize = true;
            userNameLbl.Location = new Point(169, 240);
            userNameLbl.Name = "userNameLbl";
            userNameLbl.Size = new Size(79, 20);
            userNameLbl.TabIndex = 7;
            userNameLbl.Text = "User name";
            // 
            // passwordTxt
            // 
            passwordTxt.BorderStyle = BorderStyle.FixedSingle;
            passwordTxt.Location = new Point(279, 280);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '•';
            passwordTxt.Size = new Size(314, 27);
            passwordTxt.TabIndex = 6;
            // 
            // userNameTxt
            // 
            userNameTxt.BorderStyle = BorderStyle.FixedSingle;
            userNameTxt.Location = new Point(279, 240);
            userNameTxt.Name = "userNameTxt";
            userNameTxt.Size = new Size(314, 27);
            userNameTxt.TabIndex = 5;
            // 
            // mainTab
            // 
            mainTab.Controls.Add(employeeProfileTab);
            mainTab.Controls.Add(viewTabPage);
            mainTab.Controls.Add(AddNewTabPage);
            mainTab.Controls.Add(employeeTaskTab);
            mainTab.Controls.Add(taskManTab);
            mainTab.Location = new Point(6, 2);
            mainTab.Name = "mainTab";
            mainTab.Padding = new Point(10, 15);
            mainTab.SelectedIndex = 0;
            mainTab.Size = new Size(833, 607);
            mainTab.SizeMode = TabSizeMode.FillToRight;
            mainTab.TabIndex = 47;
            mainTab.SelectedIndexChanged += MainTab_SelectedIndexChanged;
            // 
            // employeeProfileTab
            // 
            employeeProfileTab.BackColor = SystemColors.Control;
            employeeProfileTab.Controls.Add(EditProfileLkLbl);
            employeeProfileTab.Controls.Add(pwdChangePanel);
            employeeProfileTab.Controls.Add(cngPwdLkLbl);
            employeeProfileTab.Controls.Add(catagProfTxtBx);
            employeeProfileTab.Controls.Add(positionProfTxtBx);
            employeeProfileTab.Controls.Add(genderProfTxtBx);
            employeeProfileTab.Controls.Add(ageProfTxtBx);
            employeeProfileTab.Controls.Add(taxProfTxtBx);
            employeeProfileTab.Controls.Add(salaryProfTxtBx);
            employeeProfileTab.Controls.Add(lNameProfTxtBx);
            employeeProfileTab.Controls.Add(fNameProfTxtBx);
            employeeProfileTab.Controls.Add(empIDProfTxtBx);
            employeeProfileTab.Controls.Add(taxProfLbl);
            employeeProfileTab.Controls.Add(salaryProfLbl);
            employeeProfileTab.Controls.Add(catgProfLbl);
            employeeProfileTab.Controls.Add(posProfLbl);
            employeeProfileTab.Controls.Add(genderProfLbl);
            employeeProfileTab.Controls.Add(empIdProfLbl);
            employeeProfileTab.Controls.Add(ageProfLbl);
            employeeProfileTab.Controls.Add(lNameProfLbl);
            employeeProfileTab.Controls.Add(fNameProfLbl);
            employeeProfileTab.Location = new Point(4, 53);
            employeeProfileTab.Name = "employeeProfileTab";
            employeeProfileTab.Padding = new Padding(3);
            employeeProfileTab.Size = new Size(825, 550);
            employeeProfileTab.TabIndex = 1;
            employeeProfileTab.Text = "👤Profile";
            // 
            // EditProfileLkLbl
            // 
            EditProfileLkLbl.AutoSize = true;
            EditProfileLkLbl.LinkBehavior = LinkBehavior.NeverUnderline;
            EditProfileLkLbl.Location = new Point(11, 17);
            EditProfileLkLbl.Name = "EditProfileLkLbl";
            EditProfileLkLbl.Size = new Size(77, 20);
            EditProfileLkLbl.TabIndex = 47;
            EditProfileLkLbl.TabStop = true;
            EditProfileLkLbl.Text = "✏️👤Edit";
            EditProfileLkLbl.LinkClicked += EditProfileLkLbl_LinkClicked;
            // 
            // pwdChangePanel
            // 
            pwdChangePanel.BorderStyle = BorderStyle.FixedSingle;
            pwdChangePanel.Controls.Add(cngPwdBtn);
            pwdChangePanel.Controls.Add(oldPwdTxtBx);
            pwdChangePanel.Controls.Add(nwPwdTxtBx);
            pwdChangePanel.Controls.Add(reNwPwdTxtBx);
            pwdChangePanel.Controls.Add(reNwPwdLbl);
            pwdChangePanel.Controls.Add(clsPwdCngLbl);
            pwdChangePanel.Controls.Add(pwdCngLbl);
            pwdChangePanel.Controls.Add(nwPwdLbl);
            pwdChangePanel.Controls.Add(oldPwdLbl);
            pwdChangePanel.Location = new Point(236, 84);
            pwdChangePanel.Margin = new Padding(5);
            pwdChangePanel.Name = "pwdChangePanel";
            pwdChangePanel.Size = new Size(536, 367);
            pwdChangePanel.TabIndex = 42;
            pwdChangePanel.Visible = false;
            // 
            // cngPwdBtn
            // 
            cngPwdBtn.Location = new Point(198, 217);
            cngPwdBtn.Name = "cngPwdBtn";
            cngPwdBtn.Size = new Size(176, 29);
            cngPwdBtn.TabIndex = 8;
            cngPwdBtn.Text = "Change Password";
            cngPwdBtn.UseVisualStyleBackColor = true;
            cngPwdBtn.Click += CngPwdBtn_Click;
            // 
            // oldPwdTxtBx
            // 
            oldPwdTxtBx.Location = new Point(213, 69);
            oldPwdTxtBx.Name = "oldPwdTxtBx";
            oldPwdTxtBx.PasswordChar = '•';
            oldPwdTxtBx.Size = new Size(283, 27);
            oldPwdTxtBx.TabIndex = 7;
            // 
            // nwPwdTxtBx
            // 
            nwPwdTxtBx.Location = new Point(213, 116);
            nwPwdTxtBx.Name = "nwPwdTxtBx";
            nwPwdTxtBx.PasswordChar = '•';
            nwPwdTxtBx.Size = new Size(283, 27);
            nwPwdTxtBx.TabIndex = 6;
            // 
            // reNwPwdTxtBx
            // 
            reNwPwdTxtBx.Location = new Point(213, 157);
            reNwPwdTxtBx.Name = "reNwPwdTxtBx";
            reNwPwdTxtBx.PasswordChar = '•';
            reNwPwdTxtBx.Size = new Size(283, 27);
            reNwPwdTxtBx.TabIndex = 5;
            // 
            // reNwPwdLbl
            // 
            reNwPwdLbl.AutoSize = true;
            reNwPwdLbl.Location = new Point(35, 163);
            reNwPwdLbl.Name = "reNwPwdLbl";
            reNwPwdLbl.Size = new Size(159, 20);
            reNwPwdLbl.TabIndex = 4;
            reNwPwdLbl.Text = "Reenter New Password";
            // 
            // clsPwdCngLbl
            // 
            clsPwdCngLbl.AutoSize = true;
            clsPwdCngLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clsPwdCngLbl.LinkBehavior = LinkBehavior.NeverUnderline;
            clsPwdCngLbl.LinkColor = Color.Red;
            clsPwdCngLbl.Location = new Point(485, 3);
            clsPwdCngLbl.Name = "clsPwdCngLbl";
            clsPwdCngLbl.Size = new Size(47, 31);
            clsPwdCngLbl.TabIndex = 3;
            clsPwdCngLbl.TabStop = true;
            clsPwdCngLbl.Text = "❌";
            clsPwdCngLbl.LinkClicked += ClsPwdCngLbl_LinkClicked;
            // 
            // pwdCngLbl
            // 
            pwdCngLbl.AutoSize = true;
            pwdCngLbl.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pwdCngLbl.Location = new Point(181, 19);
            pwdCngLbl.Name = "pwdCngLbl";
            pwdCngLbl.Size = new Size(157, 25);
            pwdCngLbl.TabIndex = 2;
            pwdCngLbl.Text = "Change Password";
            // 
            // nwPwdLbl
            // 
            nwPwdLbl.AutoSize = true;
            nwPwdLbl.Location = new Point(35, 119);
            nwPwdLbl.Name = "nwPwdLbl";
            nwPwdLbl.Size = new Size(104, 20);
            nwPwdLbl.TabIndex = 1;
            nwPwdLbl.Text = "New Password";
            // 
            // oldPwdLbl
            // 
            oldPwdLbl.AutoSize = true;
            oldPwdLbl.Location = new Point(35, 76);
            oldPwdLbl.Name = "oldPwdLbl";
            oldPwdLbl.Size = new Size(98, 20);
            oldPwdLbl.TabIndex = 0;
            oldPwdLbl.Text = "Old Password";
            // 
            // cngPwdLkLbl
            // 
            cngPwdLkLbl.AutoSize = true;
            cngPwdLkLbl.LinkBehavior = LinkBehavior.NeverUnderline;
            cngPwdLkLbl.Location = new Point(590, 51);
            cngPwdLkLbl.Name = "cngPwdLkLbl";
            cngPwdLkLbl.Size = new Size(170, 20);
            cngPwdLkLbl.TabIndex = 46;
            cngPwdLkLbl.TabStop = true;
            cngPwdLkLbl.Text = "🔒✏️ Change Password";
            cngPwdLkLbl.LinkClicked += CngPwdLkLbl_LinkClicked;
            // 
            // catagProfTxtBx
            // 
            catagProfTxtBx.BackColor = SystemColors.Control;
            catagProfTxtBx.BorderStyle = BorderStyle.None;
            catagProfTxtBx.Enabled = false;
            catagProfTxtBx.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            catagProfTxtBx.Location = new Point(171, 328);
            catagProfTxtBx.Margin = new Padding(5);
            catagProfTxtBx.Name = "catagProfTxtBx";
            catagProfTxtBx.Size = new Size(158, 24);
            catagProfTxtBx.TabIndex = 44;
            // 
            // positionProfTxtBx
            // 
            positionProfTxtBx.BackColor = SystemColors.Control;
            positionProfTxtBx.BorderStyle = BorderStyle.None;
            positionProfTxtBx.Enabled = false;
            positionProfTxtBx.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            positionProfTxtBx.Location = new Point(171, 283);
            positionProfTxtBx.Margin = new Padding(5);
            positionProfTxtBx.Name = "positionProfTxtBx";
            positionProfTxtBx.Size = new Size(158, 24);
            positionProfTxtBx.TabIndex = 43;
            // 
            // genderProfTxtBx
            // 
            genderProfTxtBx.BackColor = SystemColors.Control;
            genderProfTxtBx.BorderStyle = BorderStyle.None;
            genderProfTxtBx.Enabled = false;
            genderProfTxtBx.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            genderProfTxtBx.Location = new Point(171, 231);
            genderProfTxtBx.Margin = new Padding(5);
            genderProfTxtBx.Name = "genderProfTxtBx";
            genderProfTxtBx.Size = new Size(74, 24);
            genderProfTxtBx.TabIndex = 42;
            // 
            // ageProfTxtBx
            // 
            ageProfTxtBx.BackColor = SystemColors.Control;
            ageProfTxtBx.BorderStyle = BorderStyle.None;
            ageProfTxtBx.Enabled = false;
            ageProfTxtBx.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            ageProfTxtBx.Location = new Point(171, 184);
            ageProfTxtBx.Margin = new Padding(5);
            ageProfTxtBx.Name = "ageProfTxtBx";
            ageProfTxtBx.Size = new Size(74, 24);
            ageProfTxtBx.TabIndex = 40;
            // 
            // taxProfTxtBx
            // 
            taxProfTxtBx.BackColor = SystemColors.Control;
            taxProfTxtBx.BorderStyle = BorderStyle.None;
            taxProfTxtBx.Enabled = false;
            taxProfTxtBx.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            taxProfTxtBx.Location = new Point(171, 472);
            taxProfTxtBx.Margin = new Padding(5);
            taxProfTxtBx.Name = "taxProfTxtBx";
            taxProfTxtBx.Size = new Size(243, 24);
            taxProfTxtBx.TabIndex = 39;
            // 
            // salaryProfTxtBx
            // 
            salaryProfTxtBx.BackColor = SystemColors.Control;
            salaryProfTxtBx.BorderStyle = BorderStyle.None;
            salaryProfTxtBx.Enabled = false;
            salaryProfTxtBx.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            salaryProfTxtBx.Location = new Point(171, 427);
            salaryProfTxtBx.Margin = new Padding(5);
            salaryProfTxtBx.Name = "salaryProfTxtBx";
            salaryProfTxtBx.Size = new Size(243, 24);
            salaryProfTxtBx.TabIndex = 38;
            // 
            // lNameProfTxtBx
            // 
            lNameProfTxtBx.BackColor = SystemColors.Control;
            lNameProfTxtBx.BorderStyle = BorderStyle.None;
            lNameProfTxtBx.Enabled = false;
            lNameProfTxtBx.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lNameProfTxtBx.Location = new Point(171, 133);
            lNameProfTxtBx.Margin = new Padding(5);
            lNameProfTxtBx.Name = "lNameProfTxtBx";
            lNameProfTxtBx.Size = new Size(323, 24);
            lNameProfTxtBx.TabIndex = 37;
            // 
            // fNameProfTxtBx
            // 
            fNameProfTxtBx.BackColor = SystemColors.Control;
            fNameProfTxtBx.BorderStyle = BorderStyle.None;
            fNameProfTxtBx.Enabled = false;
            fNameProfTxtBx.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            fNameProfTxtBx.Location = new Point(171, 91);
            fNameProfTxtBx.Margin = new Padding(5);
            fNameProfTxtBx.Name = "fNameProfTxtBx";
            fNameProfTxtBx.Size = new Size(323, 24);
            fNameProfTxtBx.TabIndex = 36;
            // 
            // empIDProfTxtBx
            // 
            empIDProfTxtBx.BackColor = SystemColors.Control;
            empIDProfTxtBx.BorderStyle = BorderStyle.None;
            empIDProfTxtBx.Enabled = false;
            empIDProfTxtBx.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            empIDProfTxtBx.Location = new Point(171, 47);
            empIDProfTxtBx.Margin = new Padding(5);
            empIDProfTxtBx.Name = "empIDProfTxtBx";
            empIDProfTxtBx.Size = new Size(411, 24);
            empIDProfTxtBx.TabIndex = 35;
            empIDProfTxtBx.Tag = "";
            // 
            // taxProfLbl
            // 
            taxProfLbl.AutoSize = true;
            taxProfLbl.Location = new Point(34, 478);
            taxProfLbl.Margin = new Padding(5, 0, 5, 0);
            taxProfLbl.Name = "taxProfLbl";
            taxProfLbl.Size = new Size(30, 20);
            taxProfLbl.TabIndex = 34;
            taxProfLbl.Text = "Tax";
            // 
            // salaryProfLbl
            // 
            salaryProfLbl.AutoSize = true;
            salaryProfLbl.Location = new Point(30, 435);
            salaryProfLbl.Margin = new Padding(5, 0, 5, 0);
            salaryProfLbl.Name = "salaryProfLbl";
            salaryProfLbl.Size = new Size(77, 20);
            salaryProfLbl.TabIndex = 33;
            salaryProfLbl.Text = "Net Salary";
            // 
            // catgProfLbl
            // 
            catgProfLbl.AutoSize = true;
            catgProfLbl.Location = new Point(30, 334);
            catgProfLbl.Margin = new Padding(5, 0, 5, 0);
            catgProfLbl.Name = "catgProfLbl";
            catgProfLbl.Size = new Size(69, 20);
            catgProfLbl.TabIndex = 32;
            catgProfLbl.Text = "Catagory";
            // 
            // posProfLbl
            // 
            posProfLbl.AutoSize = true;
            posProfLbl.Location = new Point(30, 288);
            posProfLbl.Margin = new Padding(5, 0, 5, 0);
            posProfLbl.Name = "posProfLbl";
            posProfLbl.Size = new Size(61, 20);
            posProfLbl.TabIndex = 31;
            posProfLbl.Text = "Position";
            // 
            // genderProfLbl
            // 
            genderProfLbl.AutoSize = true;
            genderProfLbl.Location = new Point(30, 238);
            genderProfLbl.Margin = new Padding(5, 0, 5, 0);
            genderProfLbl.Name = "genderProfLbl";
            genderProfLbl.Size = new Size(57, 20);
            genderProfLbl.TabIndex = 30;
            genderProfLbl.Text = "Gender";
            // 
            // empIdProfLbl
            // 
            empIdProfLbl.AutoSize = true;
            empIdProfLbl.Location = new Point(30, 52);
            empIdProfLbl.Margin = new Padding(5, 0, 5, 0);
            empIdProfLbl.Name = "empIdProfLbl";
            empIdProfLbl.Size = new Size(94, 20);
            empIdProfLbl.TabIndex = 29;
            empIdProfLbl.Text = "Employee ID";
            // 
            // ageProfLbl
            // 
            ageProfLbl.AutoSize = true;
            ageProfLbl.Location = new Point(30, 191);
            ageProfLbl.Margin = new Padding(5, 0, 5, 0);
            ageProfLbl.Name = "ageProfLbl";
            ageProfLbl.Size = new Size(36, 20);
            ageProfLbl.TabIndex = 28;
            ageProfLbl.Text = "Age";
            // 
            // lNameProfLbl
            // 
            lNameProfLbl.AutoSize = true;
            lNameProfLbl.Location = new Point(30, 144);
            lNameProfLbl.Margin = new Padding(5, 0, 5, 0);
            lNameProfLbl.Name = "lNameProfLbl";
            lNameProfLbl.Size = new Size(79, 20);
            lNameProfLbl.TabIndex = 27;
            lNameProfLbl.Text = "Last Name";
            // 
            // fNameProfLbl
            // 
            fNameProfLbl.AutoSize = true;
            fNameProfLbl.Location = new Point(30, 95);
            fNameProfLbl.Margin = new Padding(5, 0, 5, 0);
            fNameProfLbl.Name = "fNameProfLbl";
            fNameProfLbl.Size = new Size(80, 20);
            fNameProfLbl.TabIndex = 26;
            fNameProfLbl.Text = "First Name";
            // 
            // viewTabPage
            // 
            viewTabPage.Controls.Add(employeeDataGrid);
            viewTabPage.Location = new Point(4, 53);
            viewTabPage.Name = "viewTabPage";
            viewTabPage.Padding = new Padding(3);
            viewTabPage.Size = new Size(827, 552);
            viewTabPage.TabIndex = 5;
            viewTabPage.Text = "👥✅ View Accounts";
            viewTabPage.UseVisualStyleBackColor = true;
            // 
            // employeeDataGrid
            // 
            employeeDataGrid.AllowUserToAddRows = false;
            employeeDataGrid.AllowUserToDeleteRows = false;
            employeeDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeeDataGrid.BackgroundColor = SystemColors.ControlLightLight;
            employeeDataGrid.BorderStyle = BorderStyle.None;
            employeeDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            employeeDataGrid.ColumnHeadersHeight = 29;
            employeeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            employeeDataGrid.Columns.AddRange(new DataGridViewColumn[] { UserIdClm, UsernameClm, StatusClm, ActionBtnClm });
            employeeDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            employeeDataGrid.Location = new Point(18, 34);
            employeeDataGrid.Name = "employeeDataGrid";
            employeeDataGrid.RowHeadersVisible = false;
            employeeDataGrid.RowHeadersWidth = 51;
            employeeDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            employeeDataGrid.RowTemplate.Height = 40;
            employeeDataGrid.Size = new Size(760, 463);
            employeeDataGrid.StandardTab = true;
            employeeDataGrid.TabIndex = 3;
            employeeDataGrid.CellContentClick += EmployeeDataGrid_CellContentClick;
            // 
            // UserIdClm
            // 
            UserIdClm.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserIdClm.FillWeight = 25F;
            UserIdClm.HeaderText = "User ID";
            UserIdClm.MinimumWidth = 100;
            UserIdClm.Name = "UserIdClm";
            // 
            // UsernameClm
            // 
            UsernameClm.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UsernameClm.FillWeight = 35F;
            UsernameClm.HeaderText = "Username";
            UsernameClm.MinimumWidth = 150;
            UsernameClm.Name = "UsernameClm";
            // 
            // StatusClm
            // 
            StatusClm.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StatusClm.FillWeight = 15F;
            StatusClm.HeaderText = "Status";
            StatusClm.MinimumWidth = 80;
            StatusClm.Name = "StatusClm";
            // 
            // ActionBtnClm
            // 
            ActionBtnClm.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ActionBtnClm.DefaultCellStyle = dataGridViewCellStyle3;
            ActionBtnClm.FillWeight = 25F;
            ActionBtnClm.FlatStyle = FlatStyle.Flat;
            ActionBtnClm.HeaderText = "Action";
            ActionBtnClm.MinimumWidth = 120;
            ActionBtnClm.Name = "ActionBtnClm";
            // 
            // AddNewTabPage
            // 
            AddNewTabPage.Controls.Add(clearBtn);
            AddNewTabPage.Controls.Add(saveBtn);
            AddNewTabPage.Controls.Add(regPanel);
            AddNewTabPage.Location = new Point(4, 53);
            AddNewTabPage.Name = "AddNewTabPage";
            AddNewTabPage.Padding = new Padding(3);
            AddNewTabPage.Size = new Size(827, 552);
            AddNewTabPage.TabIndex = 3;
            AddNewTabPage.Text = "➕👤Add New Employee";
            AddNewTabPage.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(253, 462);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(94, 29);
            clearBtn.TabIndex = 19;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(148, 462);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 18;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += SaveBtn_Click;
            // 
            // regPanel
            // 
            regPanel.BorderStyle = BorderStyle.FixedSingle;
            regPanel.Controls.Add(contrRdBtn);
            regPanel.Controls.Add(partimeRdBtn);
            regPanel.Controls.Add(fullTimeRadBtn);
            regPanel.Controls.Add(positionSelect);
            regPanel.Controls.Add(genderSelect);
            regPanel.Controls.Add(ageTxtBx);
            regPanel.Controls.Add(dobSelector);
            regPanel.Controls.Add(taxTxtBx);
            regPanel.Controls.Add(salaryTxtBx);
            regPanel.Controls.Add(lastNameTxtBx);
            regPanel.Controls.Add(firstNameTxtBx);
            regPanel.Controls.Add(taxLbl);
            regPanel.Controls.Add(salaryLbl);
            regPanel.Controls.Add(catagoryLbl);
            regPanel.Controls.Add(positionLbl);
            regPanel.Controls.Add(genderLbl);
            regPanel.Controls.Add(ageLbl);
            regPanel.Controls.Add(lastNameLbl);
            regPanel.Controls.Add(firstNameLbl);
            regPanel.Location = new Point(10, 19);
            regPanel.Margin = new Padding(5, 4, 5, 4);
            regPanel.Name = "regPanel";
            regPanel.Size = new Size(479, 426);
            regPanel.TabIndex = 16;
            // 
            // contrRdBtn
            // 
            contrRdBtn.AutoSize = true;
            contrRdBtn.Location = new Point(344, 237);
            contrRdBtn.Name = "contrRdBtn";
            contrRdBtn.Size = new Size(86, 24);
            contrRdBtn.TabIndex = 30;
            contrRdBtn.TabStop = true;
            contrRdBtn.Text = "Contract";
            contrRdBtn.UseVisualStyleBackColor = true;
            // 
            // partimeRdBtn
            // 
            partimeRdBtn.AutoSize = true;
            partimeRdBtn.Location = new Point(242, 237);
            partimeRdBtn.Name = "partimeRdBtn";
            partimeRdBtn.Size = new Size(80, 24);
            partimeRdBtn.TabIndex = 29;
            partimeRdBtn.TabStop = true;
            partimeRdBtn.Text = "Partime";
            partimeRdBtn.UseVisualStyleBackColor = true;
            // 
            // fullTimeRadBtn
            // 
            fullTimeRadBtn.AutoSize = true;
            fullTimeRadBtn.Location = new Point(144, 237);
            fullTimeRadBtn.Name = "fullTimeRadBtn";
            fullTimeRadBtn.Size = new Size(87, 24);
            fullTimeRadBtn.TabIndex = 28;
            fullTimeRadBtn.TabStop = true;
            fullTimeRadBtn.Text = "Full time";
            fullTimeRadBtn.UseVisualStyleBackColor = true;
            // 
            // positionSelect
            // 
            positionSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            positionSelect.FormattingEnabled = true;
            positionSelect.Items.AddRange(new object[] { "Developer", "Project Manager", "Support Staff" });
            positionSelect.Location = new Point(146, 198);
            positionSelect.Margin = new Padding(5, 4, 5, 4);
            positionSelect.Name = "positionSelect";
            positionSelect.Size = new Size(170, 28);
            positionSelect.TabIndex = 27;
            // 
            // genderSelect
            // 
            genderSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            genderSelect.FormattingEnabled = true;
            genderSelect.Items.AddRange(new object[] { "Male", "Female", "Other" });
            genderSelect.Location = new Point(146, 153);
            genderSelect.Margin = new Padding(5, 4, 5, 4);
            genderSelect.Name = "genderSelect";
            genderSelect.Size = new Size(170, 28);
            genderSelect.TabIndex = 26;
            // 
            // ageTxtBx
            // 
            ageTxtBx.BorderStyle = BorderStyle.FixedSingle;
            ageTxtBx.Enabled = false;
            ageTxtBx.Location = new Point(146, 113);
            ageTxtBx.Margin = new Padding(5, 4, 5, 4);
            ageTxtBx.Name = "ageTxtBx";
            ageTxtBx.Size = new Size(66, 27);
            ageTxtBx.TabIndex = 25;
            // 
            // dobSelector
            // 
            dobSelector.Format = DateTimePickerFormat.Short;
            dobSelector.Location = new Point(219, 113);
            dobSelector.Margin = new Padding(5, 4, 5, 4);
            dobSelector.Name = "dobSelector";
            dobSelector.Size = new Size(158, 27);
            dobSelector.TabIndex = 24;
            dobSelector.ValueChanged += DobSelector_ValueChanged;
            // 
            // taxTxtBx
            // 
            taxTxtBx.BorderStyle = BorderStyle.FixedSingle;
            taxTxtBx.Enabled = false;
            taxTxtBx.Location = new Point(146, 362);
            taxTxtBx.Margin = new Padding(5, 4, 5, 4);
            taxTxtBx.Name = "taxTxtBx";
            taxTxtBx.Size = new Size(216, 27);
            taxTxtBx.TabIndex = 22;
            // 
            // salaryTxtBx
            // 
            salaryTxtBx.BorderStyle = BorderStyle.FixedSingle;
            salaryTxtBx.Enabled = false;
            salaryTxtBx.Location = new Point(146, 322);
            salaryTxtBx.Margin = new Padding(5, 4, 5, 4);
            salaryTxtBx.Name = "salaryTxtBx";
            salaryTxtBx.Size = new Size(216, 27);
            salaryTxtBx.TabIndex = 21;
            // 
            // lastNameTxtBx
            // 
            lastNameTxtBx.BorderStyle = BorderStyle.FixedSingle;
            lastNameTxtBx.Location = new Point(146, 67);
            lastNameTxtBx.Margin = new Padding(5, 4, 5, 4);
            lastNameTxtBx.Name = "lastNameTxtBx";
            lastNameTxtBx.Size = new Size(287, 27);
            lastNameTxtBx.TabIndex = 20;
            // 
            // firstNameTxtBx
            // 
            firstNameTxtBx.BorderStyle = BorderStyle.FixedSingle;
            firstNameTxtBx.Location = new Point(146, 31);
            firstNameTxtBx.Margin = new Padding(5, 4, 5, 4);
            firstNameTxtBx.Name = "firstNameTxtBx";
            firstNameTxtBx.Size = new Size(287, 27);
            firstNameTxtBx.TabIndex = 19;
            // 
            // taxLbl
            // 
            taxLbl.AutoSize = true;
            taxLbl.Location = new Point(18, 362);
            taxLbl.Margin = new Padding(5, 0, 5, 0);
            taxLbl.Name = "taxLbl";
            taxLbl.Size = new Size(30, 20);
            taxLbl.TabIndex = 17;
            taxLbl.Text = "Tax";
            // 
            // salaryLbl
            // 
            salaryLbl.AutoSize = true;
            salaryLbl.Location = new Point(14, 325);
            salaryLbl.Margin = new Padding(5, 0, 5, 0);
            salaryLbl.Name = "salaryLbl";
            salaryLbl.Size = new Size(77, 20);
            salaryLbl.TabIndex = 16;
            salaryLbl.Text = "Net Salary";
            // 
            // catagoryLbl
            // 
            catagoryLbl.AutoSize = true;
            catagoryLbl.Location = new Point(14, 237);
            catagoryLbl.Margin = new Padding(5, 0, 5, 0);
            catagoryLbl.Name = "catagoryLbl";
            catagoryLbl.Size = new Size(69, 20);
            catagoryLbl.TabIndex = 15;
            catagoryLbl.Text = "Catagory";
            // 
            // positionLbl
            // 
            positionLbl.AutoSize = true;
            positionLbl.Location = new Point(14, 198);
            positionLbl.Margin = new Padding(5, 0, 5, 0);
            positionLbl.Name = "positionLbl";
            positionLbl.Size = new Size(61, 20);
            positionLbl.TabIndex = 14;
            positionLbl.Text = "Position";
            // 
            // genderLbl
            // 
            genderLbl.AutoSize = true;
            genderLbl.Location = new Point(14, 153);
            genderLbl.Margin = new Padding(5, 0, 5, 0);
            genderLbl.Name = "genderLbl";
            genderLbl.Size = new Size(57, 20);
            genderLbl.TabIndex = 13;
            genderLbl.Text = "Gender";
            // 
            // ageLbl
            // 
            ageLbl.AutoSize = true;
            ageLbl.Location = new Point(14, 113);
            ageLbl.Margin = new Padding(5, 0, 5, 0);
            ageLbl.Name = "ageLbl";
            ageLbl.Size = new Size(36, 20);
            ageLbl.TabIndex = 11;
            ageLbl.Text = "Age";
            // 
            // lastNameLbl
            // 
            lastNameLbl.AutoSize = true;
            lastNameLbl.Location = new Point(14, 73);
            lastNameLbl.Margin = new Padding(5, 0, 5, 0);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(79, 20);
            lastNameLbl.TabIndex = 10;
            lastNameLbl.Text = "Last Name";
            // 
            // firstNameLbl
            // 
            firstNameLbl.AutoSize = true;
            firstNameLbl.Location = new Point(14, 29);
            firstNameLbl.Margin = new Padding(5, 0, 5, 0);
            firstNameLbl.Name = "firstNameLbl";
            firstNameLbl.Size = new Size(80, 20);
            firstNameLbl.TabIndex = 9;
            firstNameLbl.Text = "First Name";
            // 
            // employeeTaskTab
            // 
            employeeTaskTab.Controls.Add(emptaskListBox);
            employeeTaskTab.Controls.Add(submitTaskBtn);
            employeeTaskTab.Controls.Add(doTaskRcTxtBx);
            employeeTaskTab.Controls.Add(empTaskLbl);
            employeeTaskTab.Location = new Point(4, 53);
            employeeTaskTab.Name = "employeeTaskTab";
            employeeTaskTab.Padding = new Padding(3);
            employeeTaskTab.Size = new Size(827, 552);
            employeeTaskTab.TabIndex = 2;
            employeeTaskTab.Text = "📝 Tasks";
            employeeTaskTab.UseVisualStyleBackColor = true;
            // 
            // emptaskListBox
            // 
            emptaskListBox.BackColor = SystemColors.Control;
            emptaskListBox.BorderStyle = BorderStyle.FixedSingle;
            emptaskListBox.FormattingEnabled = true;
            emptaskListBox.Location = new Point(17, 51);
            emptaskListBox.Name = "emptaskListBox";
            emptaskListBox.Size = new Size(418, 162);
            emptaskListBox.TabIndex = 5;
            // 
            // submitTaskBtn
            // 
            submitTaskBtn.Location = new Point(327, 467);
            submitTaskBtn.Name = "submitTaskBtn";
            submitTaskBtn.Size = new Size(94, 29);
            submitTaskBtn.TabIndex = 3;
            submitTaskBtn.Text = "Submit";
            submitTaskBtn.UseVisualStyleBackColor = true;
            submitTaskBtn.Click += SubmitTaskBtn_Click;
            // 
            // doTaskRcTxtBx
            // 
            doTaskRcTxtBx.BorderStyle = BorderStyle.FixedSingle;
            doTaskRcTxtBx.Location = new Point(17, 220);
            doTaskRcTxtBx.Name = "doTaskRcTxtBx";
            doTaskRcTxtBx.Size = new Size(741, 241);
            doTaskRcTxtBx.TabIndex = 2;
            doTaskRcTxtBx.Text = "";
            doTaskRcTxtBx.TextChanged += DoTaskRcTxtBx_TextChanged;
            // 
            // empTaskLbl
            // 
            empTaskLbl.AutoSize = true;
            empTaskLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            empTaskLbl.Location = new Point(24, 26);
            empTaskLbl.Name = "empTaskLbl";
            empTaskLbl.Size = new Size(62, 28);
            empTaskLbl.TabIndex = 1;
            empTaskLbl.Text = "Tasks";
            // 
            // taskManTab
            // 
            taskManTab.Controls.Add(addTaskPanel);
            taskManTab.Controls.Add(taskAsgTbl);
            taskManTab.Controls.Add(addTaskLkLbl);
            taskManTab.Location = new Point(4, 53);
            taskManTab.Name = "taskManTab";
            taskManTab.Padding = new Padding(3);
            taskManTab.Size = new Size(827, 552);
            taskManTab.TabIndex = 4;
            taskManTab.Text = "📋 Task Management";
            taskManTab.UseVisualStyleBackColor = true;
            // 
            // addTaskPanel
            // 
            addTaskPanel.BorderStyle = BorderStyle.FixedSingle;
            addTaskPanel.Controls.Add(manClsLbl);
            addTaskPanel.Controls.Add(asgnTaskBtn);
            addTaskPanel.Controls.Add(asgToCmbBx);
            addTaskPanel.Controls.Add(tskNmTxtBx);
            addTaskPanel.Controls.Add(assgToLbl);
            addTaskPanel.Controls.Add(taskNameLbl);
            addTaskPanel.Location = new Point(410, 115);
            addTaskPanel.Name = "addTaskPanel";
            addTaskPanel.Size = new Size(382, 225);
            addTaskPanel.TabIndex = 5;
            addTaskPanel.Visible = false;
            // 
            // manClsLbl
            // 
            manClsLbl.AutoEllipsis = true;
            manClsLbl.AutoSize = true;
            manClsLbl.LinkBehavior = LinkBehavior.NeverUnderline;
            manClsLbl.LinkColor = Color.Red;
            manClsLbl.Location = new Point(346, 5);
            manClsLbl.Name = "manClsLbl";
            manClsLbl.Size = new Size(30, 20);
            manClsLbl.TabIndex = 14;
            manClsLbl.TabStop = true;
            manClsLbl.Text = "❌";
            manClsLbl.LinkClicked += ManClsLbl_LinkClicked;
            // 
            // asgnTaskBtn
            // 
            asgnTaskBtn.Location = new Point(142, 155);
            asgnTaskBtn.Name = "asgnTaskBtn";
            asgnTaskBtn.Size = new Size(119, 29);
            asgnTaskBtn.TabIndex = 13;
            asgnTaskBtn.Text = "Assign Tasks";
            asgnTaskBtn.UseVisualStyleBackColor = true;
            asgnTaskBtn.Click += AsgnTaskBtn_Click;
            // 
            // asgToCmbBx
            // 
            asgToCmbBx.DropDownStyle = ComboBoxStyle.DropDownList;
            asgToCmbBx.FormattingEnabled = true;
            asgToCmbBx.Location = new Point(120, 91);
            asgToCmbBx.Name = "asgToCmbBx";
            asgToCmbBx.Size = new Size(237, 28);
            asgToCmbBx.TabIndex = 12;
            // 
            // tskNmTxtBx
            // 
            tskNmTxtBx.Location = new Point(120, 50);
            tskNmTxtBx.Name = "tskNmTxtBx";
            tskNmTxtBx.Size = new Size(237, 27);
            tskNmTxtBx.TabIndex = 11;
            // 
            // assgToLbl
            // 
            assgToLbl.AutoSize = true;
            assgToLbl.Location = new Point(16, 89);
            assgToLbl.Name = "assgToLbl";
            assgToLbl.Size = new Size(89, 20);
            assgToLbl.TabIndex = 9;
            assgToLbl.Text = "Assigned To";
            // 
            // taskNameLbl
            // 
            taskNameLbl.AutoSize = true;
            taskNameLbl.Location = new Point(16, 50);
            taskNameLbl.Name = "taskNameLbl";
            taskNameLbl.Size = new Size(79, 20);
            taskNameLbl.TabIndex = 8;
            taskNameLbl.Text = "task Name";
            // 
            // taskAsgTbl
            // 
            taskAsgTbl.AllowUserToAddRows = false;
            taskAsgTbl.AllowUserToDeleteRows = false;
            taskAsgTbl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            taskAsgTbl.BackgroundColor = SystemColors.ControlLightLight;
            taskAsgTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            taskAsgTbl.EditMode = DataGridViewEditMode.EditProgrammatically;
            taskAsgTbl.Location = new Point(34, 64);
            taskAsgTbl.MultiSelect = false;
            taskAsgTbl.Name = "taskAsgTbl";
            taskAsgTbl.RowHeadersWidth = 51;
            taskAsgTbl.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            taskAsgTbl.Size = new Size(662, 349);
            taskAsgTbl.TabIndex = 4;
            // 
            // addTaskLkLbl
            // 
            addTaskLkLbl.AutoSize = true;
            addTaskLkLbl.Location = new Point(13, 23);
            addTaskLkLbl.Name = "addTaskLkLbl";
            addTaskLkLbl.Size = new Size(74, 20);
            addTaskLkLbl.TabIndex = 7;
            addTaskLkLbl.TabStop = true;
            addTaskLkLbl.Text = "Add Tasks";
            addTaskLkLbl.LinkClicked += AddTaskLkLbl_LinkClicked;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.Teal;
            LogoutBtn.FlatAppearance.BorderSize = 0;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Font = new Font("Segoe UI", 9F);
            LogoutBtn.ForeColor = SystemColors.ControlLightLight;
            LogoutBtn.Location = new Point(737, 7);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(94, 49);
            LogoutBtn.TabIndex = 47;
            LogoutBtn.Text = "🔓 Logout";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // CompleteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 611);
            Controls.Add(LogoutBtn);
            Controls.Add(mainTab);
            Controls.Add(loginPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CompleteForm";
            Text = "Employee Full Portal";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            mainTab.ResumeLayout(false);
            employeeProfileTab.ResumeLayout(false);
            employeeProfileTab.PerformLayout();
            pwdChangePanel.ResumeLayout(false);
            pwdChangePanel.PerformLayout();
            viewTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)employeeDataGrid).EndInit();
            AddNewTabPage.ResumeLayout(false);
            regPanel.ResumeLayout(false);
            regPanel.PerformLayout();
            employeeTaskTab.ResumeLayout(false);
            employeeTaskTab.PerformLayout();
            taskManTab.ResumeLayout(false);
            taskManTab.PerformLayout();
            addTaskPanel.ResumeLayout(false);
            addTaskPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)taskAsgTbl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private Button loginBtb;
        private Label passwordLbl;
        private Label userNameLbl;
        private TextBox passwordTxt;
        private TextBox userNameTxt;
        private Label loginInfoLbl;
        private TabControl mainTab;
        private TabPage employeeProfileTab;
        private Panel pwdChangePanel;
        private Button cngPwdBtn;
        private TextBox oldPwdTxtBx;
        private TextBox nwPwdTxtBx;
        private TextBox reNwPwdTxtBx;
        private Label reNwPwdLbl;
        private LinkLabel clsPwdCngLbl;
        private Label pwdCngLbl;
        private Label nwPwdLbl;
        private Label oldPwdLbl;
        private LinkLabel cngPwdLkLbl;
        private TextBox catagProfTxtBx;
        private TextBox positionProfTxtBx;
        private TextBox genderProfTxtBx;
        private TextBox ageProfTxtBx;
        private TextBox taxProfTxtBx;
        private TextBox salaryProfTxtBx;
        private TextBox lNameProfTxtBx;
        private TextBox fNameProfTxtBx;
        private TextBox empIDProfTxtBx;
        private Label taxProfLbl;
        private Label salaryProfLbl;
        private Label catgProfLbl;
        private Label posProfLbl;
        private Label genderProfLbl;
        private Label empIdProfLbl;
        private Label ageProfLbl;
        private Label lNameProfLbl;
        private Label fNameProfLbl;
        private TabPage AddNewTabPage;
        private Button clearBtn;
        private Button saveBtn;
        private Panel regPanel;
        private RadioButton contrRdBtn;
        private RadioButton partimeRdBtn;
        private RadioButton fullTimeRadBtn;
        private ComboBox positionSelect;
        private ComboBox genderSelect;
        private TextBox ageTxtBx;
        private DateTimePicker dobSelector;
        private TextBox taxTxtBx;
        private TextBox salaryTxtBx;
        private TextBox lastNameTxtBx;
        private TextBox firstNameTxtBx;
        private Label taxLbl;
        private Label salaryLbl;
        private Label catagoryLbl;
        private Label positionLbl;
        private Label genderLbl;
        private Label ageLbl;
        private Label lastNameLbl;
        private Label firstNameLbl;
        private TabPage employeeTaskTab;
        private ListBox emptaskListBox;
        private Button submitTaskBtn;
        private RichTextBox doTaskRcTxtBx;
        private Label empTaskLbl;
        private TabPage taskManTab;
        private Panel addTaskPanel;
        private LinkLabel manClsLbl;
        private Button asgnTaskBtn;
        private ComboBox asgToCmbBx;
        private TextBox tskNmTxtBx;
        private Label assgToLbl;
        private Label taskNameLbl;
        private DataGridView taskAsgTbl;
        private LinkLabel addTaskLkLbl;
        private TabPage viewTabPage;
        private DataGridView employeeDataGrid;
        private DataGridViewTextBoxColumn UserIdClm;
        private DataGridViewTextBoxColumn UsernameClm;
        private DataGridViewTextBoxColumn StatusClm;
        private DataGridViewButtonColumn ActionBtnClm;
        private TabPage logoutBtn;
        private Button LogoutBtn;
        private LinkLabel EditProfileLkLbl;
    }
}