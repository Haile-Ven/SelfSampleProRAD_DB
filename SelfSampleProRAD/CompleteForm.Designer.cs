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
            loginPanel = new Panel();
            loginInfoLbl = new Label();
            loginBtb = new Button();
            passwordLbl = new Label();
            userNameLbl = new Label();
            passwordTxt = new TextBox();
            userNameTxt = new TextBox();
            managerPanel = new Panel();
            manLogoutLbl = new LinkLabel();
            addTaskLkLbl = new LinkLabel();
            mgrLbl = new Label();
            addTaskPanel = new Panel();
            manClsLbl = new LinkLabel();
            asgnTaskBtn = new Button();
            asgToCmbBx = new ComboBox();
            tskNmTxtBx = new TextBox();
            tskIdTxtBx = new TextBox();
            assgToLbl = new Label();
            taskNameLbl = new Label();
            taskIdLbl = new Label();
            taskAsgTbl = new DataGridView();
            taskIdClm = new DataGridViewTextBoxColumn();
            taskName = new DataGridViewTextBoxColumn();
            assignedToClm = new DataGridViewTextBoxColumn();
            taskStatusClm = new DataGridViewTextBoxColumn();
            adminPanel = new Panel();
            adminTabCrtl = new TabControl();
            viewTabPage = new TabPage();
            refreshBtn = new Button();
            adminLogoutLbl1 = new LinkLabel();
            employeeDataGrid = new DataGridView();
            uID = new DataGridViewTextBoxColumn();
            usrNameClm = new DataGridViewTextBoxColumn();
            accStatusClm = new DataGridViewTextBoxColumn();
            cngStBtn = new DataGridViewButtonColumn();
            newEmpLink = new LinkLabel();
            AddNewTabPage = new TabPage();
            adminLogoutLbl2 = new LinkLabel();
            clearBtn = new Button();
            saveBtn = new Button();
            empImgPanel = new Panel();
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
            fNameTxtBx = new TextBox();
            empIdTxtBx = new TextBox();
            taxLbl = new Label();
            salaryLbl = new Label();
            catagoryLbl = new Label();
            positionLbl = new Label();
            genderLbl = new Label();
            empIdLbl = new Label();
            ageLbl = new Label();
            lastNameLbl = new Label();
            firstNameLbl = new Label();
            devPanel = new Panel();
            employeeTabs = new TabControl();
            employeeProfileTab = new TabPage();
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
            devLogoutLbl1 = new LinkLabel();
            catagProfTxtBx = new TextBox();
            positionProfTxtBx = new TextBox();
            genderProfTxtBx = new TextBox();
            ageProfTxtBx = new TextBox();
            taxProfTxtBx = new TextBox();
            salaryProfTxtBx = new TextBox();
            lNameProfTxtBx = new TextBox();
            fNameProfTxtBx = new TextBox();
            empIDProfTxtBx = new TextBox();
            imgProPanel = new Panel();
            taxProfLbl = new Label();
            salaryProfLbl = new Label();
            catgProfLbl = new Label();
            posProfLbl = new Label();
            genderProfLbl = new Label();
            empIdProfLbl = new Label();
            ageProfLbl = new Label();
            lNameProfLbl = new Label();
            fNameProfLbl = new Label();
            employeeTaskTab = new TabPage();
            devLogoutLbl2 = new LinkLabel();
            emptaskListBox = new ListBox();
            submitTaskBtn = new Button();
            doTaskRcTxtBx = new RichTextBox();
            empTaskLbl = new Label();
            loginPanel.SuspendLayout();
            managerPanel.SuspendLayout();
            addTaskPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskAsgTbl).BeginInit();
            adminPanel.SuspendLayout();
            adminTabCrtl.SuspendLayout();
            viewTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeDataGrid).BeginInit();
            AddNewTabPage.SuspendLayout();
            regPanel.SuspendLayout();
            devPanel.SuspendLayout();
            employeeTabs.SuspendLayout();
            employeeProfileTab.SuspendLayout();
            pwdChangePanel.SuspendLayout();
            employeeTaskTab.SuspendLayout();
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
            loginPanel.Location = new Point(0, -1);
            loginPanel.Margin = new Padding(3, 2, 3, 2);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(714, 427);
            loginPanel.TabIndex = 0;
            // 
            // loginInfoLbl
            // 
            loginInfoLbl.AutoSize = true;
            loginInfoLbl.ForeColor = Color.Red;
            loginInfoLbl.Location = new Point(238, 109);
            loginInfoLbl.Name = "loginInfoLbl";
            loginInfoLbl.Size = new Size(0, 15);
            loginInfoLbl.TabIndex = 10;
            // 
            // loginBtb
            // 
            loginBtb.Location = new Point(320, 212);
            loginBtb.Margin = new Padding(3, 2, 3, 2);
            loginBtb.Name = "loginBtb";
            loginBtb.Size = new Size(95, 28);
            loginBtb.TabIndex = 9;
            loginBtb.Text = "Login";
            loginBtb.UseVisualStyleBackColor = true;
            loginBtb.Click += loginBtb_Click;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Location = new Point(142, 172);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(57, 15);
            passwordLbl.TabIndex = 8;
            passwordLbl.Text = "Password";
            // 
            // userNameLbl
            // 
            userNameLbl.AutoSize = true;
            userNameLbl.Location = new Point(142, 142);
            userNameLbl.Name = "userNameLbl";
            userNameLbl.Size = new Size(63, 15);
            userNameLbl.TabIndex = 7;
            userNameLbl.Text = "User name";
            // 
            // passwordTxt
            // 
            passwordTxt.BorderStyle = BorderStyle.FixedSingle;
            passwordTxt.Location = new Point(238, 172);
            passwordTxt.Margin = new Padding(3, 2, 3, 2);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '•';
            passwordTxt.Size = new Size(275, 23);
            passwordTxt.TabIndex = 6;
            // 
            // userNameTxt
            // 
            userNameTxt.BorderStyle = BorderStyle.FixedSingle;
            userNameTxt.Location = new Point(238, 142);
            userNameTxt.Margin = new Padding(3, 2, 3, 2);
            userNameTxt.Name = "userNameTxt";
            userNameTxt.Size = new Size(275, 23);
            userNameTxt.TabIndex = 5;
            userNameTxt.TextChanged += userNameTxt_TextChanged;
            // 
            // managerPanel
            // 
            managerPanel.Controls.Add(manLogoutLbl);
            managerPanel.Controls.Add(addTaskLkLbl);
            managerPanel.Controls.Add(mgrLbl);
            managerPanel.Controls.Add(addTaskPanel);
            managerPanel.Controls.Add(taskAsgTbl);
            managerPanel.Location = new Point(-1, 0);
            managerPanel.Margin = new Padding(3, 2, 3, 2);
            managerPanel.Name = "managerPanel";
            managerPanel.Size = new Size(714, 427);
            managerPanel.TabIndex = 1;
            // 
            // manLogoutLbl
            // 
            manLogoutLbl.AutoSize = true;
            manLogoutLbl.Location = new Point(634, 27);
            manLogoutLbl.Name = "manLogoutLbl";
            manLogoutLbl.Size = new Size(45, 15);
            manLogoutLbl.TabIndex = 8;
            manLogoutLbl.TabStop = true;
            manLogoutLbl.Text = "Logout";
            manLogoutLbl.LinkClicked += manLogoutLbl_LinkClicked;
            // 
            // addTaskLkLbl
            // 
            addTaskLkLbl.AutoSize = true;
            addTaskLkLbl.Location = new Point(11, 68);
            addTaskLkLbl.Name = "addTaskLkLbl";
            addTaskLkLbl.Size = new Size(60, 15);
            addTaskLkLbl.TabIndex = 7;
            addTaskLkLbl.TabStop = true;
            addTaskLkLbl.Text = "Add Tasks";
            addTaskLkLbl.LinkClicked += addTaskLkLbl_LinkClicked;
            // 
            // mgrLbl
            // 
            mgrLbl.AutoSize = true;
            mgrLbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mgrLbl.Location = new Point(175, 27);
            mgrLbl.Name = "mgrLbl";
            mgrLbl.Size = new Size(254, 45);
            mgrLbl.TabIndex = 6;
            mgrLbl.Text = "Manager Portal";
            // 
            // addTaskPanel
            // 
            addTaskPanel.BorderStyle = BorderStyle.FixedSingle;
            addTaskPanel.Controls.Add(manClsLbl);
            addTaskPanel.Controls.Add(asgnTaskBtn);
            addTaskPanel.Controls.Add(asgToCmbBx);
            addTaskPanel.Controls.Add(tskNmTxtBx);
            addTaskPanel.Controls.Add(tskIdTxtBx);
            addTaskPanel.Controls.Add(assgToLbl);
            addTaskPanel.Controls.Add(taskNameLbl);
            addTaskPanel.Controls.Add(taskIdLbl);
            addTaskPanel.Location = new Point(391, 88);
            addTaskPanel.Margin = new Padding(3, 2, 3, 2);
            addTaskPanel.Name = "addTaskPanel";
            addTaskPanel.Size = new Size(312, 263);
            addTaskPanel.TabIndex = 5;
            addTaskPanel.Visible = false;
            // 
            // manClsLbl
            // 
            manClsLbl.AutoSize = true;
            manClsLbl.LinkColor = Color.Red;
            manClsLbl.Location = new Point(291, 0);
            manClsLbl.Name = "manClsLbl";
            manClsLbl.Size = new Size(14, 15);
            manClsLbl.TabIndex = 14;
            manClsLbl.TabStop = true;
            manClsLbl.Text = "X";
            manClsLbl.LinkClicked += manClsLbl_LinkClicked;
            // 
            // asgnTaskBtn
            // 
            asgnTaskBtn.Location = new Point(127, 128);
            asgnTaskBtn.Margin = new Padding(3, 2, 3, 2);
            asgnTaskBtn.Name = "asgnTaskBtn";
            asgnTaskBtn.Size = new Size(104, 22);
            asgnTaskBtn.TabIndex = 13;
            asgnTaskBtn.Text = "Assign Tasks";
            asgnTaskBtn.UseVisualStyleBackColor = true;
            asgnTaskBtn.Click += asgnTaskBtn_Click;
            // 
            // asgToCmbBx
            // 
            asgToCmbBx.DropDownStyle = ComboBoxStyle.DropDownList;
            asgToCmbBx.FormattingEnabled = true;
            asgToCmbBx.Location = new Point(94, 91);
            asgToCmbBx.Margin = new Padding(3, 2, 3, 2);
            asgToCmbBx.Name = "asgToCmbBx";
            asgToCmbBx.Size = new Size(208, 23);
            asgToCmbBx.TabIndex = 12;
            // 
            // tskNmTxtBx
            // 
            tskNmTxtBx.Location = new Point(94, 60);
            tskNmTxtBx.Margin = new Padding(3, 2, 3, 2);
            tskNmTxtBx.Name = "tskNmTxtBx";
            tskNmTxtBx.Size = new Size(208, 23);
            tskNmTxtBx.TabIndex = 11;
            // 
            // tskIdTxtBx
            // 
            tskIdTxtBx.Location = new Point(94, 30);
            tskIdTxtBx.Margin = new Padding(3, 2, 3, 2);
            tskIdTxtBx.Name = "tskIdTxtBx";
            tskIdTxtBx.Size = new Size(208, 23);
            tskIdTxtBx.TabIndex = 10;
            // 
            // assgToLbl
            // 
            assgToLbl.AutoSize = true;
            assgToLbl.Location = new Point(3, 89);
            assgToLbl.Name = "assgToLbl";
            assgToLbl.Size = new Size(71, 15);
            assgToLbl.TabIndex = 9;
            assgToLbl.Text = "Assigned To";
            // 
            // taskNameLbl
            // 
            taskNameLbl.AutoSize = true;
            taskNameLbl.Location = new Point(3, 60);
            taskNameLbl.Name = "taskNameLbl";
            taskNameLbl.Size = new Size(63, 15);
            taskNameLbl.TabIndex = 8;
            taskNameLbl.Text = "task Name";
            // 
            // taskIdLbl
            // 
            taskIdLbl.AutoSize = true;
            taskIdLbl.Location = new Point(3, 32);
            taskIdLbl.Name = "taskIdLbl";
            taskIdLbl.Size = new Size(48, 15);
            taskIdLbl.TabIndex = 7;
            taskIdLbl.Text = "Tasks Id";
            // 
            // taskAsgTbl
            // 
            taskAsgTbl.AllowUserToAddRows = false;
            taskAsgTbl.AllowUserToDeleteRows = false;
            taskAsgTbl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            taskAsgTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            taskAsgTbl.Columns.AddRange(new DataGridViewColumn[] { taskIdClm, taskName, assignedToClm, taskStatusClm });
            taskAsgTbl.EditMode = DataGridViewEditMode.EditProgrammatically;
            taskAsgTbl.Location = new Point(11, 86);
            taskAsgTbl.Margin = new Padding(3, 2, 3, 2);
            taskAsgTbl.MultiSelect = false;
            taskAsgTbl.Name = "taskAsgTbl";
            taskAsgTbl.RowHeadersWidth = 51;
            taskAsgTbl.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            taskAsgTbl.Size = new Size(374, 262);
            taskAsgTbl.TabIndex = 4;
            // 
            // taskIdClm
            // 
            taskIdClm.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            taskIdClm.FillWeight = 2F;
            taskIdClm.HeaderText = "ID";
            taskIdClm.MinimumWidth = 6;
            taskIdClm.Name = "taskIdClm";
            taskIdClm.Width = 30;
            // 
            // taskName
            // 
            taskName.HeaderText = "Task Name";
            taskName.MinimumWidth = 6;
            taskName.Name = "taskName";
            // 
            // assignedToClm
            // 
            assignedToClm.HeaderText = "Assigned to";
            assignedToClm.MinimumWidth = 6;
            assignedToClm.Name = "assignedToClm";
            // 
            // taskStatusClm
            // 
            taskStatusClm.HeaderText = "Tasks Status";
            taskStatusClm.MinimumWidth = 6;
            taskStatusClm.Name = "taskStatusClm";
            // 
            // adminPanel
            // 
            adminPanel.Controls.Add(adminTabCrtl);
            adminPanel.Location = new Point(0, 0);
            adminPanel.Margin = new Padding(3, 2, 3, 2);
            adminPanel.Name = "adminPanel";
            adminPanel.Size = new Size(714, 427);
            adminPanel.TabIndex = 2;
            // 
            // adminTabCrtl
            // 
            adminTabCrtl.Controls.Add(viewTabPage);
            adminTabCrtl.Controls.Add(AddNewTabPage);
            adminTabCrtl.Location = new Point(10, 9);
            adminTabCrtl.Margin = new Padding(3, 2, 3, 2);
            adminTabCrtl.Name = "adminTabCrtl";
            adminTabCrtl.SelectedIndex = 0;
            adminTabCrtl.Size = new Size(691, 408);
            adminTabCrtl.TabIndex = 0;
            // 
            // viewTabPage
            // 
            viewTabPage.Controls.Add(refreshBtn);
            viewTabPage.Controls.Add(adminLogoutLbl1);
            viewTabPage.Controls.Add(employeeDataGrid);
            viewTabPage.Controls.Add(newEmpLink);
            viewTabPage.Location = new Point(4, 24);
            viewTabPage.Margin = new Padding(3, 2, 3, 2);
            viewTabPage.Name = "viewTabPage";
            viewTabPage.Padding = new Padding(3, 2, 3, 2);
            viewTabPage.Size = new Size(683, 380);
            viewTabPage.TabIndex = 0;
            viewTabPage.Text = "View Employees";
            viewTabPage.UseVisualStyleBackColor = true;
            // 
            // refreshBtn
            // 
            refreshBtn.FlatStyle = FlatStyle.Flat;
            refreshBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshBtn.Location = new Point(430, 11);
            refreshBtn.Margin = new Padding(3, 2, 3, 2);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(36, 30);
            refreshBtn.TabIndex = 47;
            refreshBtn.Text = "↻";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // adminLogoutLbl1
            // 
            adminLogoutLbl1.AutoSize = true;
            adminLogoutLbl1.Location = new Point(629, 2);
            adminLogoutLbl1.Name = "adminLogoutLbl1";
            adminLogoutLbl1.Size = new Size(45, 15);
            adminLogoutLbl1.TabIndex = 46;
            adminLogoutLbl1.TabStop = true;
            adminLogoutLbl1.Text = "Logout";
            adminLogoutLbl1.LinkClicked += adminLogoutLbl1_LinkClicked;
            // 
            // employeeDataGrid
            // 
            employeeDataGrid.AllowUserToAddRows = false;
            employeeDataGrid.AllowUserToDeleteRows = false;
            employeeDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeeDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            employeeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeDataGrid.Columns.AddRange(new DataGridViewColumn[] { uID, usrNameClm, accStatusClm, cngStBtn });
            employeeDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            employeeDataGrid.Location = new Point(17, 46);
            employeeDataGrid.Margin = new Padding(3, 2, 3, 2);
            employeeDataGrid.Name = "employeeDataGrid";
            employeeDataGrid.RowHeadersWidth = 51;
            employeeDataGrid.Size = new Size(449, 322);
            employeeDataGrid.StandardTab = true;
            employeeDataGrid.TabIndex = 3;
            employeeDataGrid.CellContentClick += employeeDataGrid_CellContentClick;
            // 
            // uID
            // 
            uID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            uID.FillWeight = 70.58823F;
            uID.HeaderText = "ID";
            uID.MinimumWidth = 6;
            uID.Name = "uID";
            uID.Resizable = DataGridViewTriState.False;
            uID.Width = 50;
            // 
            // usrNameClm
            // 
            usrNameClm.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            usrNameClm.FillWeight = 152.036209F;
            usrNameClm.HeaderText = "User name";
            usrNameClm.MinimumWidth = 6;
            usrNameClm.Name = "usrNameClm";
            usrNameClm.Width = 230;
            // 
            // accStatusClm
            // 
            accStatusClm.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            accStatusClm.FillWeight = 45.6108551F;
            accStatusClm.HeaderText = "Status";
            accStatusClm.MinimumWidth = 6;
            accStatusClm.Name = "accStatusClm";
            accStatusClm.Resizable = DataGridViewTriState.False;
            accStatusClm.Width = 70;
            // 
            // cngStBtn
            // 
            cngStBtn.FlatStyle = FlatStyle.Flat;
            cngStBtn.HeaderText = "Change";
            cngStBtn.MinimumWidth = 6;
            cngStBtn.Name = "cngStBtn";
            cngStBtn.UseColumnTextForButtonValue = true;
            // 
            // newEmpLink
            // 
            newEmpLink.AutoSize = true;
            newEmpLink.Location = new Point(17, 17);
            newEmpLink.Name = "newEmpLink";
            newEmpLink.Size = new Size(111, 15);
            newEmpLink.TabIndex = 2;
            newEmpLink.TabStop = true;
            newEmpLink.Text = "Add New Employee";
            newEmpLink.LinkClicked += newEmpLink_LinkClicked;
            // 
            // AddNewTabPage
            // 
            AddNewTabPage.Controls.Add(adminLogoutLbl2);
            AddNewTabPage.Controls.Add(clearBtn);
            AddNewTabPage.Controls.Add(saveBtn);
            AddNewTabPage.Controls.Add(empImgPanel);
            AddNewTabPage.Controls.Add(regPanel);
            AddNewTabPage.Location = new Point(4, 24);
            AddNewTabPage.Margin = new Padding(3, 2, 3, 2);
            AddNewTabPage.Name = "AddNewTabPage";
            AddNewTabPage.Padding = new Padding(3, 2, 3, 2);
            AddNewTabPage.Size = new Size(683, 380);
            AddNewTabPage.TabIndex = 1;
            AddNewTabPage.Text = "Add New Employee";
            AddNewTabPage.UseVisualStyleBackColor = true;
            // 
            // adminLogoutLbl2
            // 
            adminLogoutLbl2.AutoSize = true;
            adminLogoutLbl2.Location = new Point(629, 2);
            adminLogoutLbl2.Name = "adminLogoutLbl2";
            adminLogoutLbl2.Size = new Size(45, 15);
            adminLogoutLbl2.TabIndex = 47;
            adminLogoutLbl2.TabStop = true;
            adminLogoutLbl2.Text = "Logout";
            adminLogoutLbl2.LinkClicked += adminLogoutLbl2_LinkClicked;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(221, 356);
            clearBtn.Margin = new Padding(3, 2, 3, 2);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(82, 22);
            clearBtn.TabIndex = 19;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(134, 356);
            saveBtn.Margin = new Padding(3, 2, 3, 2);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(82, 22);
            saveBtn.TabIndex = 18;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // empImgPanel
            // 
            empImgPanel.BorderStyle = BorderStyle.FixedSingle;
            empImgPanel.Location = new Point(434, 23);
            empImgPanel.Margin = new Padding(4, 3, 4, 3);
            empImgPanel.Name = "empImgPanel";
            empImgPanel.Size = new Size(246, 187);
            empImgPanel.TabIndex = 17;
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
            regPanel.Controls.Add(fNameTxtBx);
            regPanel.Controls.Add(empIdTxtBx);
            regPanel.Controls.Add(taxLbl);
            regPanel.Controls.Add(salaryLbl);
            regPanel.Controls.Add(catagoryLbl);
            regPanel.Controls.Add(positionLbl);
            regPanel.Controls.Add(genderLbl);
            regPanel.Controls.Add(empIdLbl);
            regPanel.Controls.Add(ageLbl);
            regPanel.Controls.Add(lastNameLbl);
            regPanel.Controls.Add(firstNameLbl);
            regPanel.Location = new Point(9, 14);
            regPanel.Margin = new Padding(4, 3, 4, 3);
            regPanel.Name = "regPanel";
            regPanel.Size = new Size(419, 336);
            regPanel.TabIndex = 16;
            // 
            // contrRdBtn
            // 
            contrRdBtn.AutoSize = true;
            contrRdBtn.Location = new Point(301, 197);
            contrRdBtn.Margin = new Padding(3, 2, 3, 2);
            contrRdBtn.Name = "contrRdBtn";
            contrRdBtn.Size = new Size(71, 19);
            contrRdBtn.TabIndex = 30;
            contrRdBtn.TabStop = true;
            contrRdBtn.Text = "Contract";
            contrRdBtn.UseVisualStyleBackColor = true;
            // 
            // partimeRdBtn
            // 
            partimeRdBtn.AutoSize = true;
            partimeRdBtn.Location = new Point(212, 197);
            partimeRdBtn.Margin = new Padding(3, 2, 3, 2);
            partimeRdBtn.Name = "partimeRdBtn";
            partimeRdBtn.Size = new Size(66, 19);
            partimeRdBtn.TabIndex = 29;
            partimeRdBtn.TabStop = true;
            partimeRdBtn.Text = "Partime";
            partimeRdBtn.UseVisualStyleBackColor = true;
            // 
            // fullTimeRadBtn
            // 
            fullTimeRadBtn.AutoSize = true;
            fullTimeRadBtn.Location = new Point(126, 197);
            fullTimeRadBtn.Margin = new Padding(3, 2, 3, 2);
            fullTimeRadBtn.Name = "fullTimeRadBtn";
            fullTimeRadBtn.Size = new Size(71, 19);
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
            positionSelect.Location = new Point(128, 168);
            positionSelect.Margin = new Padding(4, 3, 4, 3);
            positionSelect.Name = "positionSelect";
            positionSelect.Size = new Size(149, 23);
            positionSelect.TabIndex = 27;
            // 
            // genderSelect
            // 
            genderSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            genderSelect.FormattingEnabled = true;
            genderSelect.Items.AddRange(new object[] { "Male", "Female", "Other" });
            genderSelect.Location = new Point(128, 134);
            genderSelect.Margin = new Padding(4, 3, 4, 3);
            genderSelect.Name = "genderSelect";
            genderSelect.Size = new Size(149, 23);
            genderSelect.TabIndex = 26;
            // 
            // ageTxtBx
            // 
            ageTxtBx.BorderStyle = BorderStyle.FixedSingle;
            ageTxtBx.Enabled = false;
            ageTxtBx.Location = new Point(128, 104);
            ageTxtBx.Margin = new Padding(4, 3, 4, 3);
            ageTxtBx.Name = "ageTxtBx";
            ageTxtBx.Size = new Size(58, 23);
            ageTxtBx.TabIndex = 25;
            // 
            // dobSelector
            // 
            dobSelector.Format = DateTimePickerFormat.Short;
            dobSelector.Location = new Point(192, 104);
            dobSelector.Margin = new Padding(4, 3, 4, 3);
            dobSelector.Name = "dobSelector";
            dobSelector.Size = new Size(139, 23);
            dobSelector.TabIndex = 24;
            dobSelector.ValueChanged += dobSelector_ValueChanged;
            // 
            // taxTxtBx
            // 
            taxTxtBx.BorderStyle = BorderStyle.FixedSingle;
            taxTxtBx.Enabled = false;
            taxTxtBx.Location = new Point(128, 291);
            taxTxtBx.Margin = new Padding(4, 3, 4, 3);
            taxTxtBx.Name = "taxTxtBx";
            taxTxtBx.Size = new Size(189, 23);
            taxTxtBx.TabIndex = 22;
            // 
            // salaryTxtBx
            // 
            salaryTxtBx.BorderStyle = BorderStyle.FixedSingle;
            salaryTxtBx.Enabled = false;
            salaryTxtBx.Location = new Point(128, 261);
            salaryTxtBx.Margin = new Padding(4, 3, 4, 3);
            salaryTxtBx.Name = "salaryTxtBx";
            salaryTxtBx.Size = new Size(189, 23);
            salaryTxtBx.TabIndex = 21;
            // 
            // lastNameTxtBx
            // 
            lastNameTxtBx.BorderStyle = BorderStyle.FixedSingle;
            lastNameTxtBx.Location = new Point(128, 70);
            lastNameTxtBx.Margin = new Padding(4, 3, 4, 3);
            lastNameTxtBx.Name = "lastNameTxtBx";
            lastNameTxtBx.Size = new Size(251, 23);
            lastNameTxtBx.TabIndex = 20;
            // 
            // fNameTxtBx
            // 
            fNameTxtBx.BorderStyle = BorderStyle.FixedSingle;
            fNameTxtBx.Location = new Point(128, 43);
            fNameTxtBx.Margin = new Padding(4, 3, 4, 3);
            fNameTxtBx.Name = "fNameTxtBx";
            fNameTxtBx.Size = new Size(251, 23);
            fNameTxtBx.TabIndex = 19;
            // 
            // empIdTxtBx
            // 
            empIdTxtBx.BorderStyle = BorderStyle.FixedSingle;
            empIdTxtBx.Location = new Point(128, 14);
            empIdTxtBx.Margin = new Padding(4, 3, 4, 3);
            empIdTxtBx.Name = "empIdTxtBx";
            empIdTxtBx.Size = new Size(251, 23);
            empIdTxtBx.TabIndex = 18;
            empIdTxtBx.Tag = "";
            // 
            // taxLbl
            // 
            taxLbl.AutoSize = true;
            taxLbl.Location = new Point(16, 291);
            taxLbl.Margin = new Padding(4, 0, 4, 0);
            taxLbl.Name = "taxLbl";
            taxLbl.Size = new Size(24, 15);
            taxLbl.TabIndex = 17;
            taxLbl.Text = "Tax";
            // 
            // salaryLbl
            // 
            salaryLbl.AutoSize = true;
            salaryLbl.Location = new Point(12, 263);
            salaryLbl.Margin = new Padding(4, 0, 4, 0);
            salaryLbl.Name = "salaryLbl";
            salaryLbl.Size = new Size(60, 15);
            salaryLbl.TabIndex = 16;
            salaryLbl.Text = "Net Salary";
            // 
            // catagoryLbl
            // 
            catagoryLbl.AutoSize = true;
            catagoryLbl.Location = new Point(12, 197);
            catagoryLbl.Margin = new Padding(4, 0, 4, 0);
            catagoryLbl.Name = "catagoryLbl";
            catagoryLbl.Size = new Size(55, 15);
            catagoryLbl.TabIndex = 15;
            catagoryLbl.Text = "Catagory";
            // 
            // positionLbl
            // 
            positionLbl.AutoSize = true;
            positionLbl.Location = new Point(12, 168);
            positionLbl.Margin = new Padding(4, 0, 4, 0);
            positionLbl.Name = "positionLbl";
            positionLbl.Size = new Size(50, 15);
            positionLbl.TabIndex = 14;
            positionLbl.Text = "Position";
            // 
            // genderLbl
            // 
            genderLbl.AutoSize = true;
            genderLbl.Location = new Point(12, 134);
            genderLbl.Margin = new Padding(4, 0, 4, 0);
            genderLbl.Name = "genderLbl";
            genderLbl.Size = new Size(45, 15);
            genderLbl.TabIndex = 13;
            genderLbl.Text = "Gender";
            // 
            // empIdLbl
            // 
            empIdLbl.AutoSize = true;
            empIdLbl.Location = new Point(12, 14);
            empIdLbl.Margin = new Padding(4, 0, 4, 0);
            empIdLbl.Name = "empIdLbl";
            empIdLbl.Size = new Size(73, 15);
            empIdLbl.TabIndex = 12;
            empIdLbl.Text = "Employee ID";
            // 
            // ageLbl
            // 
            ageLbl.AutoSize = true;
            ageLbl.Location = new Point(12, 104);
            ageLbl.Margin = new Padding(4, 0, 4, 0);
            ageLbl.Name = "ageLbl";
            ageLbl.Size = new Size(28, 15);
            ageLbl.TabIndex = 11;
            ageLbl.Text = "Age";
            // 
            // lastNameLbl
            // 
            lastNameLbl.AutoSize = true;
            lastNameLbl.Location = new Point(12, 74);
            lastNameLbl.Margin = new Padding(4, 0, 4, 0);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(63, 15);
            lastNameLbl.TabIndex = 10;
            lastNameLbl.Text = "Last Name";
            // 
            // firstNameLbl
            // 
            firstNameLbl.AutoSize = true;
            firstNameLbl.Location = new Point(12, 41);
            firstNameLbl.Margin = new Padding(4, 0, 4, 0);
            firstNameLbl.Name = "firstNameLbl";
            firstNameLbl.Size = new Size(64, 15);
            firstNameLbl.TabIndex = 9;
            firstNameLbl.Text = "First Name";
            // 
            // devPanel
            // 
            devPanel.Controls.Add(employeeTabs);
            devPanel.Location = new Point(0, 0);
            devPanel.Margin = new Padding(3, 2, 3, 2);
            devPanel.Name = "devPanel";
            devPanel.Size = new Size(714, 427);
            devPanel.TabIndex = 3;
            // 
            // employeeTabs
            // 
            employeeTabs.Controls.Add(employeeProfileTab);
            employeeTabs.Controls.Add(employeeTaskTab);
            employeeTabs.Location = new Point(13, 5);
            employeeTabs.Margin = new Padding(3, 2, 3, 2);
            employeeTabs.Name = "employeeTabs";
            employeeTabs.SelectedIndex = 0;
            employeeTabs.Size = new Size(688, 416);
            employeeTabs.TabIndex = 1;
            // 
            // employeeProfileTab
            // 
            employeeProfileTab.Controls.Add(pwdChangePanel);
            employeeProfileTab.Controls.Add(cngPwdLkLbl);
            employeeProfileTab.Controls.Add(devLogoutLbl1);
            employeeProfileTab.Controls.Add(catagProfTxtBx);
            employeeProfileTab.Controls.Add(positionProfTxtBx);
            employeeProfileTab.Controls.Add(genderProfTxtBx);
            employeeProfileTab.Controls.Add(ageProfTxtBx);
            employeeProfileTab.Controls.Add(taxProfTxtBx);
            employeeProfileTab.Controls.Add(salaryProfTxtBx);
            employeeProfileTab.Controls.Add(lNameProfTxtBx);
            employeeProfileTab.Controls.Add(fNameProfTxtBx);
            employeeProfileTab.Controls.Add(empIDProfTxtBx);
            employeeProfileTab.Controls.Add(imgProPanel);
            employeeProfileTab.Controls.Add(taxProfLbl);
            employeeProfileTab.Controls.Add(salaryProfLbl);
            employeeProfileTab.Controls.Add(catgProfLbl);
            employeeProfileTab.Controls.Add(posProfLbl);
            employeeProfileTab.Controls.Add(genderProfLbl);
            employeeProfileTab.Controls.Add(empIdProfLbl);
            employeeProfileTab.Controls.Add(ageProfLbl);
            employeeProfileTab.Controls.Add(lNameProfLbl);
            employeeProfileTab.Controls.Add(fNameProfLbl);
            employeeProfileTab.Location = new Point(4, 24);
            employeeProfileTab.Margin = new Padding(3, 2, 3, 2);
            employeeProfileTab.Name = "employeeProfileTab";
            employeeProfileTab.Padding = new Padding(3, 2, 3, 2);
            employeeProfileTab.Size = new Size(680, 388);
            employeeProfileTab.TabIndex = 0;
            employeeProfileTab.Text = "Profile";
            employeeProfileTab.UseVisualStyleBackColor = true;
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
            pwdChangePanel.Location = new Point(113, 50);
            pwdChangePanel.Margin = new Padding(4);
            pwdChangePanel.Name = "pwdChangePanel";
            pwdChangePanel.Size = new Size(469, 276);
            pwdChangePanel.TabIndex = 42;
            pwdChangePanel.Visible = false;
            // 
            // cngPwdBtn
            // 
            cngPwdBtn.Location = new Point(173, 163);
            cngPwdBtn.Margin = new Padding(3, 2, 3, 2);
            cngPwdBtn.Name = "cngPwdBtn";
            cngPwdBtn.Size = new Size(154, 22);
            cngPwdBtn.TabIndex = 8;
            cngPwdBtn.Text = "Change Password";
            cngPwdBtn.UseVisualStyleBackColor = true;
            cngPwdBtn.Click += cngPwdBtn_Click;
            // 
            // oldPwdTxtBx
            // 
            oldPwdTxtBx.Location = new Point(186, 52);
            oldPwdTxtBx.Margin = new Padding(3, 2, 3, 2);
            oldPwdTxtBx.Name = "oldPwdTxtBx";
            oldPwdTxtBx.PasswordChar = '•';
            oldPwdTxtBx.Size = new Size(248, 23);
            oldPwdTxtBx.TabIndex = 7;
            // 
            // nwPwdTxtBx
            // 
            nwPwdTxtBx.Location = new Point(186, 87);
            nwPwdTxtBx.Margin = new Padding(3, 2, 3, 2);
            nwPwdTxtBx.Name = "nwPwdTxtBx";
            nwPwdTxtBx.PasswordChar = '•';
            nwPwdTxtBx.Size = new Size(248, 23);
            nwPwdTxtBx.TabIndex = 6;
            // 
            // reNwPwdTxtBx
            // 
            reNwPwdTxtBx.Location = new Point(186, 118);
            reNwPwdTxtBx.Margin = new Padding(3, 2, 3, 2);
            reNwPwdTxtBx.Name = "reNwPwdTxtBx";
            reNwPwdTxtBx.PasswordChar = '•';
            reNwPwdTxtBx.Size = new Size(248, 23);
            reNwPwdTxtBx.TabIndex = 5;
            // 
            // reNwPwdLbl
            // 
            reNwPwdLbl.AutoSize = true;
            reNwPwdLbl.Location = new Point(31, 122);
            reNwPwdLbl.Name = "reNwPwdLbl";
            reNwPwdLbl.Size = new Size(127, 15);
            reNwPwdLbl.TabIndex = 4;
            reNwPwdLbl.Text = "Reenter New Password";
            // 
            // clsPwdCngLbl
            // 
            clsPwdCngLbl.AutoSize = true;
            clsPwdCngLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clsPwdCngLbl.LinkColor = Color.Red;
            clsPwdCngLbl.Location = new Point(431, 6);
            clsPwdCngLbl.Name = "clsPwdCngLbl";
            clsPwdCngLbl.Size = new Size(24, 25);
            clsPwdCngLbl.TabIndex = 3;
            clsPwdCngLbl.TabStop = true;
            clsPwdCngLbl.Text = "X";
            clsPwdCngLbl.LinkClicked += clsPwdCngLbl_LinkClicked;
            // 
            // pwdCngLbl
            // 
            pwdCngLbl.AutoSize = true;
            pwdCngLbl.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pwdCngLbl.Location = new Point(158, 14);
            pwdCngLbl.Name = "pwdCngLbl";
            pwdCngLbl.Size = new Size(129, 20);
            pwdCngLbl.TabIndex = 2;
            pwdCngLbl.Text = "Change Password";
            // 
            // nwPwdLbl
            // 
            nwPwdLbl.AutoSize = true;
            nwPwdLbl.Location = new Point(31, 89);
            nwPwdLbl.Name = "nwPwdLbl";
            nwPwdLbl.Size = new Size(84, 15);
            nwPwdLbl.TabIndex = 1;
            nwPwdLbl.Text = "New Password";
            // 
            // oldPwdLbl
            // 
            oldPwdLbl.AutoSize = true;
            oldPwdLbl.Location = new Point(31, 57);
            oldPwdLbl.Name = "oldPwdLbl";
            oldPwdLbl.Size = new Size(79, 15);
            oldPwdLbl.TabIndex = 0;
            oldPwdLbl.Text = "Old Password";
            // 
            // cngPwdLkLbl
            // 
            cngPwdLkLbl.AutoSize = true;
            cngPwdLkLbl.Location = new Point(546, 206);
            cngPwdLkLbl.Name = "cngPwdLkLbl";
            cngPwdLkLbl.Size = new Size(101, 15);
            cngPwdLkLbl.TabIndex = 46;
            cngPwdLkLbl.TabStop = true;
            cngPwdLkLbl.Text = "Change Password";
            cngPwdLkLbl.LinkClicked += cngPwdLkLbl_LinkClicked;
            // 
            // devLogoutLbl1
            // 
            devLogoutLbl1.AutoSize = true;
            devLogoutLbl1.Location = new Point(626, 4);
            devLogoutLbl1.Name = "devLogoutLbl1";
            devLogoutLbl1.Size = new Size(45, 15);
            devLogoutLbl1.TabIndex = 45;
            devLogoutLbl1.TabStop = true;
            devLogoutLbl1.Text = "Logout";
            devLogoutLbl1.LinkClicked += devLogoutLbl1_LinkClicked;
            // 
            // catagProfTxtBx
            // 
            catagProfTxtBx.BackColor = SystemColors.Control;
            catagProfTxtBx.BorderStyle = BorderStyle.None;
            catagProfTxtBx.Enabled = false;
            catagProfTxtBx.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            catagProfTxtBx.Location = new Point(150, 246);
            catagProfTxtBx.Margin = new Padding(4);
            catagProfTxtBx.Name = "catagProfTxtBx";
            catagProfTxtBx.Size = new Size(138, 20);
            catagProfTxtBx.TabIndex = 44;
            // 
            // positionProfTxtBx
            // 
            positionProfTxtBx.BackColor = SystemColors.Control;
            positionProfTxtBx.BorderStyle = BorderStyle.None;
            positionProfTxtBx.Enabled = false;
            positionProfTxtBx.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            positionProfTxtBx.Location = new Point(150, 212);
            positionProfTxtBx.Margin = new Padding(4);
            positionProfTxtBx.Name = "positionProfTxtBx";
            positionProfTxtBx.Size = new Size(138, 20);
            positionProfTxtBx.TabIndex = 43;
            // 
            // genderProfTxtBx
            // 
            genderProfTxtBx.BackColor = SystemColors.Control;
            genderProfTxtBx.BorderStyle = BorderStyle.None;
            genderProfTxtBx.Enabled = false;
            genderProfTxtBx.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            genderProfTxtBx.Location = new Point(150, 173);
            genderProfTxtBx.Margin = new Padding(4);
            genderProfTxtBx.Name = "genderProfTxtBx";
            genderProfTxtBx.Size = new Size(65, 20);
            genderProfTxtBx.TabIndex = 42;
            // 
            // ageProfTxtBx
            // 
            ageProfTxtBx.BackColor = SystemColors.Control;
            ageProfTxtBx.BorderStyle = BorderStyle.None;
            ageProfTxtBx.Enabled = false;
            ageProfTxtBx.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            ageProfTxtBx.Location = new Point(150, 138);
            ageProfTxtBx.Margin = new Padding(4);
            ageProfTxtBx.Name = "ageProfTxtBx";
            ageProfTxtBx.Size = new Size(65, 20);
            ageProfTxtBx.TabIndex = 40;
            // 
            // taxProfTxtBx
            // 
            taxProfTxtBx.BackColor = SystemColors.Control;
            taxProfTxtBx.BorderStyle = BorderStyle.None;
            taxProfTxtBx.Enabled = false;
            taxProfTxtBx.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            taxProfTxtBx.Location = new Point(150, 354);
            taxProfTxtBx.Margin = new Padding(4);
            taxProfTxtBx.Name = "taxProfTxtBx";
            taxProfTxtBx.Size = new Size(213, 20);
            taxProfTxtBx.TabIndex = 39;
            // 
            // salaryProfTxtBx
            // 
            salaryProfTxtBx.BackColor = SystemColors.Control;
            salaryProfTxtBx.BorderStyle = BorderStyle.None;
            salaryProfTxtBx.Enabled = false;
            salaryProfTxtBx.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            salaryProfTxtBx.Location = new Point(150, 320);
            salaryProfTxtBx.Margin = new Padding(4);
            salaryProfTxtBx.Name = "salaryProfTxtBx";
            salaryProfTxtBx.Size = new Size(213, 20);
            salaryProfTxtBx.TabIndex = 38;
            // 
            // lNameProfTxtBx
            // 
            lNameProfTxtBx.BackColor = SystemColors.Control;
            lNameProfTxtBx.BorderStyle = BorderStyle.None;
            lNameProfTxtBx.Enabled = false;
            lNameProfTxtBx.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lNameProfTxtBx.Location = new Point(150, 100);
            lNameProfTxtBx.Margin = new Padding(4);
            lNameProfTxtBx.Name = "lNameProfTxtBx";
            lNameProfTxtBx.Size = new Size(283, 20);
            lNameProfTxtBx.TabIndex = 37;
            // 
            // fNameProfTxtBx
            // 
            fNameProfTxtBx.BackColor = SystemColors.Control;
            fNameProfTxtBx.BorderStyle = BorderStyle.None;
            fNameProfTxtBx.Enabled = false;
            fNameProfTxtBx.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            fNameProfTxtBx.Location = new Point(150, 68);
            fNameProfTxtBx.Margin = new Padding(4);
            fNameProfTxtBx.Name = "fNameProfTxtBx";
            fNameProfTxtBx.Size = new Size(283, 20);
            fNameProfTxtBx.TabIndex = 36;
            // 
            // empIDProfTxtBx
            // 
            empIDProfTxtBx.BackColor = SystemColors.Control;
            empIDProfTxtBx.BorderStyle = BorderStyle.None;
            empIDProfTxtBx.Enabled = false;
            empIDProfTxtBx.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            empIDProfTxtBx.Location = new Point(150, 35);
            empIDProfTxtBx.Margin = new Padding(4);
            empIDProfTxtBx.Name = "empIDProfTxtBx";
            empIDProfTxtBx.Size = new Size(283, 20);
            empIDProfTxtBx.TabIndex = 35;
            empIDProfTxtBx.Tag = "";
            // 
            // imgProPanel
            // 
            imgProPanel.BorderStyle = BorderStyle.FixedSingle;
            imgProPanel.Location = new Point(441, 34);
            imgProPanel.Margin = new Padding(4);
            imgProPanel.Name = "imgProPanel";
            imgProPanel.Size = new Size(214, 168);
            imgProPanel.TabIndex = 41;
            // 
            // taxProfLbl
            // 
            taxProfLbl.AutoSize = true;
            taxProfLbl.Location = new Point(27, 356);
            taxProfLbl.Margin = new Padding(4, 0, 4, 0);
            taxProfLbl.Name = "taxProfLbl";
            taxProfLbl.Size = new Size(24, 15);
            taxProfLbl.TabIndex = 34;
            taxProfLbl.Text = "Tax";
            // 
            // salaryProfLbl
            // 
            salaryProfLbl.AutoSize = true;
            salaryProfLbl.Location = new Point(24, 324);
            salaryProfLbl.Margin = new Padding(4, 0, 4, 0);
            salaryProfLbl.Name = "salaryProfLbl";
            salaryProfLbl.Size = new Size(60, 15);
            salaryProfLbl.TabIndex = 33;
            salaryProfLbl.Text = "Net Salary";
            // 
            // catgProfLbl
            // 
            catgProfLbl.AutoSize = true;
            catgProfLbl.Location = new Point(24, 248);
            catgProfLbl.Margin = new Padding(4, 0, 4, 0);
            catgProfLbl.Name = "catgProfLbl";
            catgProfLbl.Size = new Size(55, 15);
            catgProfLbl.TabIndex = 32;
            catgProfLbl.Text = "Catagory";
            // 
            // posProfLbl
            // 
            posProfLbl.AutoSize = true;
            posProfLbl.Location = new Point(24, 214);
            posProfLbl.Margin = new Padding(4, 0, 4, 0);
            posProfLbl.Name = "posProfLbl";
            posProfLbl.Size = new Size(50, 15);
            posProfLbl.TabIndex = 31;
            posProfLbl.Text = "Position";
            // 
            // genderProfLbl
            // 
            genderProfLbl.AutoSize = true;
            genderProfLbl.Location = new Point(24, 176);
            genderProfLbl.Margin = new Padding(4, 0, 4, 0);
            genderProfLbl.Name = "genderProfLbl";
            genderProfLbl.Size = new Size(45, 15);
            genderProfLbl.TabIndex = 30;
            genderProfLbl.Text = "Gender";
            // 
            // empIdProfLbl
            // 
            empIdProfLbl.AutoSize = true;
            empIdProfLbl.Location = new Point(24, 37);
            empIdProfLbl.Margin = new Padding(4, 0, 4, 0);
            empIdProfLbl.Name = "empIdProfLbl";
            empIdProfLbl.Size = new Size(73, 15);
            empIdProfLbl.TabIndex = 29;
            empIdProfLbl.Text = "Employee ID";
            // 
            // ageProfLbl
            // 
            ageProfLbl.AutoSize = true;
            ageProfLbl.Location = new Point(24, 141);
            ageProfLbl.Margin = new Padding(4, 0, 4, 0);
            ageProfLbl.Name = "ageProfLbl";
            ageProfLbl.Size = new Size(28, 15);
            ageProfLbl.TabIndex = 28;
            ageProfLbl.Text = "Age";
            // 
            // lNameProfLbl
            // 
            lNameProfLbl.AutoSize = true;
            lNameProfLbl.Location = new Point(24, 106);
            lNameProfLbl.Margin = new Padding(4, 0, 4, 0);
            lNameProfLbl.Name = "lNameProfLbl";
            lNameProfLbl.Size = new Size(63, 15);
            lNameProfLbl.TabIndex = 27;
            lNameProfLbl.Text = "Last Name";
            // 
            // fNameProfLbl
            // 
            fNameProfLbl.AutoSize = true;
            fNameProfLbl.Location = new Point(24, 69);
            fNameProfLbl.Margin = new Padding(4, 0, 4, 0);
            fNameProfLbl.Name = "fNameProfLbl";
            fNameProfLbl.Size = new Size(64, 15);
            fNameProfLbl.TabIndex = 26;
            fNameProfLbl.Text = "First Name";
            // 
            // employeeTaskTab
            // 
            employeeTaskTab.Controls.Add(devLogoutLbl2);
            employeeTaskTab.Controls.Add(emptaskListBox);
            employeeTaskTab.Controls.Add(submitTaskBtn);
            employeeTaskTab.Controls.Add(doTaskRcTxtBx);
            employeeTaskTab.Controls.Add(empTaskLbl);
            employeeTaskTab.Location = new Point(4, 24);
            employeeTaskTab.Margin = new Padding(3, 2, 3, 2);
            employeeTaskTab.Name = "employeeTaskTab";
            employeeTaskTab.Padding = new Padding(3, 2, 3, 2);
            employeeTaskTab.Size = new Size(680, 388);
            employeeTaskTab.TabIndex = 1;
            employeeTaskTab.Text = "Tasks";
            employeeTaskTab.UseVisualStyleBackColor = true;
            // 
            // devLogoutLbl2
            // 
            devLogoutLbl2.AutoSize = true;
            devLogoutLbl2.Location = new Point(626, 4);
            devLogoutLbl2.Name = "devLogoutLbl2";
            devLogoutLbl2.Size = new Size(45, 15);
            devLogoutLbl2.TabIndex = 46;
            devLogoutLbl2.TabStop = true;
            devLogoutLbl2.Text = "Logout";
            devLogoutLbl2.LinkClicked += devLogoutLbl2_LinkClicked;
            // 
            // emptaskListBox
            // 
            emptaskListBox.BorderStyle = BorderStyle.FixedSingle;
            emptaskListBox.FormattingEnabled = true;
            emptaskListBox.ItemHeight = 15;
            emptaskListBox.Location = new Point(15, 38);
            emptaskListBox.Margin = new Padding(3, 2, 3, 2);
            emptaskListBox.Name = "emptaskListBox";
            emptaskListBox.Size = new Size(244, 122);
            emptaskListBox.TabIndex = 5;
            // 
            // submitTaskBtn
            // 
            submitTaskBtn.Location = new Point(286, 350);
            submitTaskBtn.Margin = new Padding(3, 2, 3, 2);
            submitTaskBtn.Name = "submitTaskBtn";
            submitTaskBtn.Size = new Size(82, 22);
            submitTaskBtn.TabIndex = 3;
            submitTaskBtn.Text = "Submit";
            submitTaskBtn.UseVisualStyleBackColor = true;
            submitTaskBtn.Click += submitTaskBtn_Click;
            // 
            // doTaskRcTxtBx
            // 
            doTaskRcTxtBx.BorderStyle = BorderStyle.FixedSingle;
            doTaskRcTxtBx.Location = new Point(15, 165);
            doTaskRcTxtBx.Margin = new Padding(3, 2, 3, 2);
            doTaskRcTxtBx.Name = "doTaskRcTxtBx";
            doTaskRcTxtBx.Size = new Size(649, 182);
            doTaskRcTxtBx.TabIndex = 2;
            doTaskRcTxtBx.Text = "";
            doTaskRcTxtBx.TextChanged += doTaskRcTxtBx_TextChanged;
            // 
            // empTaskLbl
            // 
            empTaskLbl.AutoSize = true;
            empTaskLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            empTaskLbl.Location = new Point(18, 17);
            empTaskLbl.Name = "empTaskLbl";
            empTaskLbl.Size = new Size(50, 21);
            empTaskLbl.TabIndex = 1;
            empTaskLbl.Text = "Tasks";
            // 
            // CompleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 426);
            Controls.Add(adminPanel);
            Controls.Add(devPanel);
            Controls.Add(managerPanel);
            Controls.Add(loginPanel);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "CompleteForm";
            Text = "Employee Full Portal";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            managerPanel.ResumeLayout(false);
            managerPanel.PerformLayout();
            addTaskPanel.ResumeLayout(false);
            addTaskPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)taskAsgTbl).EndInit();
            adminPanel.ResumeLayout(false);
            adminTabCrtl.ResumeLayout(false);
            viewTabPage.ResumeLayout(false);
            viewTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeDataGrid).EndInit();
            AddNewTabPage.ResumeLayout(false);
            AddNewTabPage.PerformLayout();
            regPanel.ResumeLayout(false);
            regPanel.PerformLayout();
            devPanel.ResumeLayout(false);
            employeeTabs.ResumeLayout(false);
            employeeProfileTab.ResumeLayout(false);
            employeeProfileTab.PerformLayout();
            pwdChangePanel.ResumeLayout(false);
            pwdChangePanel.PerformLayout();
            employeeTaskTab.ResumeLayout(false);
            employeeTaskTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private Panel managerPanel;
        private Panel adminPanel;
        private Panel devPanel;
        private Button loginBtb;
        private Label passwordLbl;
        private Label userNameLbl;
        private TextBox passwordTxt;
        private TextBox userNameTxt;
        private TabControl adminTabCrtl;
        private TabPage viewTabPage;
        private TabPage AddNewTabPage;
        private DataGridView employeeDataGrid;
        private LinkLabel newEmpLink;
        private Button clearBtn;
        private Button saveBtn;
        private Panel empImgPanel;
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
        private TextBox fNameTxtBx;
        private TextBox empIdTxtBx;
        private Label taxLbl;
        private Label salaryLbl;
        private Label catagoryLbl;
        private Label positionLbl;
        private Label genderLbl;
        private Label empIdLbl;
        private Label ageLbl;
        private Label lastNameLbl;
        private Label firstNameLbl;
        private TabControl employeeTabs;
        private TabPage employeeProfileTab;
        private TextBox catagProfTxtBx;
        private TextBox positionProfTxtBx;
        private TextBox genderProfTxtBx;
        private TextBox ageProfTxtBx;
        private TextBox taxProfTxtBx;
        private TextBox salaryProfTxtBx;
        private TextBox lNameProfTxtBx;
        private TextBox fNameProfTxtBx;
        private TextBox empIDProfTxtBx;
        private Panel imgProPanel;
        private Label taxProfLbl;
        private Label salaryProfLbl;
        private Label catgProfLbl;
        private Label posProfLbl;
        private Label genderProfLbl;
        private Label empIdProfLbl;
        private Label ageProfLbl;
        private Label lNameProfLbl;
        private Label fNameProfLbl;
        private TabPage employeeTaskTab;
        private ListBox emptaskListBox;
        private Button submitTaskBtn;
        private RichTextBox doTaskRcTxtBx;
        private Label empTaskLbl;
        private DataGridView taskAsgTbl;
        private Label mgrLbl;
        private Panel addTaskPanel;
        private TextBox tskNmTxtBx;
        private TextBox tskIdTxtBx;
        private Label assgToLbl;
        private Label taskNameLbl;
        private Label taskIdLbl;
        private Button asgnTaskBtn;
        private ComboBox asgToCmbBx;
        private LinkLabel addTaskLkLbl;
        private LinkLabel manLogoutLbl;
        private LinkLabel devLogoutLbl1;
        private LinkLabel devLogoutLbl2;
        private LinkLabel adminLogoutLbl1;
        private LinkLabel adminLogoutLbl2;
        private LinkLabel manClsLbl;
        private Label loginInfoLbl;
        private Button refreshBtn;
        private Panel pwdChangePanel;
        private Label pwdCngLbl;
        private Label nwPwdLbl;
        private Label oldPwdLbl;
        private LinkLabel clsPwdCngLbl;
        private TextBox oldPwdTxtBx;
        private TextBox nwPwdTxtBx;
        private TextBox reNwPwdTxtBx;
        private Label reNwPwdLbl;
        private Button cngPwdBtn;
        private LinkLabel cngPwdLkLbl;
        private DataGridViewTextBoxColumn taskIdClm;
        private DataGridViewTextBoxColumn taskName;
        private DataGridViewTextBoxColumn assignedToClm;
        private DataGridViewTextBoxColumn taskStatusClm;
        private DataGridViewTextBoxColumn uID;
        private DataGridViewTextBoxColumn usrNameClm;
        private DataGridViewTextBoxColumn accStatusClm;
        private DataGridViewButtonColumn cngStBtn;
    }
}