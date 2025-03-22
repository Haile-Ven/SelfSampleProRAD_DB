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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            loginPanel = new Panel();
            loginBtb = new Button();
            passwordLbl = new Label();
            userNameLbl = new Label();
            passwordTxt = new TextBox();
            userNameTxt = new TextBox();
            mainTab = new TabControl();
            employeeProfileTab = new TabPage();
            EditProfileLkLbl = new LinkLabel();
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
            taskAsgTbl = new DataGridView();
            addTaskLkLbl = new LinkLabel();
            LogoutBtn = new Button();
            loginPanel.SuspendLayout();
            mainTab.SuspendLayout();
            employeeProfileTab.SuspendLayout();
            viewTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeDataGrid).BeginInit();
            AddNewTabPage.SuspendLayout();
            regPanel.SuspendLayout();
            employeeTaskTab.SuspendLayout();
            taskManTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskAsgTbl).BeginInit();
            SuspendLayout();
            // 
            // loginPanel
            // 
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
            // loginBtb
            // 
            loginBtb.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtb.Location = new Point(365, 315);
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
            passwordLbl.Font = new Font("Segoe UI", 10.8F);
            passwordLbl.Location = new Point(153, 247);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(117, 25);
            passwordLbl.TabIndex = 8;
            passwordLbl.Text = "🔒 Password";
            // 
            // userNameLbl
            // 
            userNameLbl.AutoSize = true;
            userNameLbl.Font = new Font("Segoe UI", 10.8F);
            userNameLbl.Location = new Point(153, 207);
            userNameLbl.Name = "userNameLbl";
            userNameLbl.Size = new Size(121, 25);
            userNameLbl.TabIndex = 7;
            userNameLbl.Text = "👤 Username";
            // 
            // passwordTxt
            // 
            passwordTxt.BorderStyle = BorderStyle.FixedSingle;
            passwordTxt.Location = new Point(280, 250);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(314, 27);
            passwordTxt.TabIndex = 6;
            passwordTxt.UseSystemPasswordChar = true;
            // 
            // userNameTxt
            // 
            userNameTxt.BorderStyle = BorderStyle.FixedSingle;
            userNameTxt.Location = new Point(280, 209);
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
            viewTabPage.Size = new Size(825, 550);
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
            employeeDataGrid.Size = new Size(760, 492);
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
            ActionBtnClm.DefaultCellStyle = dataGridViewCellStyle1;
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
            AddNewTabPage.Size = new Size(825, 550);
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
            clearBtn.Click += ClearBtn_Click;
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
            employeeTaskTab.Size = new Size(825, 550);
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
            empTaskLbl.Location = new Point(22, 18);
            empTaskLbl.Name = "empTaskLbl";
            empTaskLbl.Size = new Size(96, 28);
            empTaskLbl.TabIndex = 1;
            empTaskLbl.Text = "📋 Tasks";
            // 
            // taskManTab
            // 
            taskManTab.Controls.Add(taskAsgTbl);
            taskManTab.Controls.Add(addTaskLkLbl);
            taskManTab.Location = new Point(4, 53);
            taskManTab.Name = "taskManTab";
            taskManTab.Padding = new Padding(3);
            taskManTab.Size = new Size(825, 550);
            taskManTab.TabIndex = 4;
            taskManTab.Text = "📋 Task Management";
            taskManTab.UseVisualStyleBackColor = true;
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
            addTaskLkLbl.LinkBehavior = LinkBehavior.NeverUnderline;
            addTaskLkLbl.Location = new Point(13, 23);
            addTaskLkLbl.Name = "addTaskLkLbl";
            addTaskLkLbl.Size = new Size(120, 20);
            addTaskLkLbl.TabIndex = 7;
            addTaskLkLbl.TabStop = true;
            addTaskLkLbl.Text = "➕📋 Add Tasks";
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
            viewTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)employeeDataGrid).EndInit();
            AddNewTabPage.ResumeLayout(false);
            regPanel.ResumeLayout(false);
            regPanel.PerformLayout();
            employeeTaskTab.ResumeLayout(false);
            employeeTaskTab.PerformLayout();
            taskManTab.ResumeLayout(false);
            taskManTab.PerformLayout();
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
        private TabControl mainTab;
        private TabPage employeeProfileTab;
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