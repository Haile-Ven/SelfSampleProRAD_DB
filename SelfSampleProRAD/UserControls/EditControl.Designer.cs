namespace SelfSampleProRAD_DB
{
    partial class EditControl
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
            UpdateBtn = new Button();
            genderSelect = new ComboBox();
            ageTxtBx = new TextBox();
            dobSelector = new DateTimePicker();
            lastNameTxtBx = new TextBox();
            firstNameTxtBx = new TextBox();
            genderLbl = new Label();
            ageLbl = new Label();
            lastNameLbl = new Label();
            firstNameLbl = new Label();
            label1 = new Label();
            clsEditControlLbl = new LinkLabel();
            SuspendLayout();
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.MediumSeaGreen;
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = SystemColors.ControlLightLight;
            UpdateBtn.Location = new Point(204, 246);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(118, 46);
            UpdateBtn.TabIndex = 21;
            UpdateBtn.Text = "🔄 Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // genderSelect
            // 
            genderSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            genderSelect.FormattingEnabled = true;
            genderSelect.Items.AddRange(new object[] { "Male", "Female", "Other" });
            genderSelect.Location = new Point(161, 192);
            genderSelect.Margin = new Padding(5, 4, 5, 4);
            genderSelect.Name = "genderSelect";
            genderSelect.Size = new Size(170, 28);
            genderSelect.TabIndex = 26;
            // 
            // ageTxtBx
            // 
            ageTxtBx.BorderStyle = BorderStyle.FixedSingle;
            ageTxtBx.Enabled = false;
            ageTxtBx.Location = new Point(161, 152);
            ageTxtBx.Margin = new Padding(5, 4, 5, 4);
            ageTxtBx.Name = "ageTxtBx";
            ageTxtBx.Size = new Size(66, 27);
            ageTxtBx.TabIndex = 25;
            // 
            // dobSelector
            // 
            dobSelector.Format = DateTimePickerFormat.Short;
            dobSelector.Location = new Point(234, 152);
            dobSelector.Margin = new Padding(5, 4, 5, 4);
            dobSelector.Name = "dobSelector";
            dobSelector.Size = new Size(158, 27);
            dobSelector.TabIndex = 24;
            dobSelector.ValueChanged += DobSelector_ValueChanged;
            // 
            // lastNameTxtBx
            // 
            lastNameTxtBx.BorderStyle = BorderStyle.FixedSingle;
            lastNameTxtBx.Location = new Point(161, 106);
            lastNameTxtBx.Margin = new Padding(5, 4, 5, 4);
            lastNameTxtBx.Name = "lastNameTxtBx";
            lastNameTxtBx.Size = new Size(287, 27);
            lastNameTxtBx.TabIndex = 20;
            // 
            // firstNameTxtBx
            // 
            firstNameTxtBx.BorderStyle = BorderStyle.FixedSingle;
            firstNameTxtBx.Location = new Point(161, 70);
            firstNameTxtBx.Margin = new Padding(5, 4, 5, 4);
            firstNameTxtBx.Name = "firstNameTxtBx";
            firstNameTxtBx.Size = new Size(287, 27);
            firstNameTxtBx.TabIndex = 19;
            // 
            // genderLbl
            // 
            genderLbl.AutoSize = true;
            genderLbl.Location = new Point(61, 200);
            genderLbl.Margin = new Padding(5, 0, 5, 0);
            genderLbl.Name = "genderLbl";
            genderLbl.Size = new Size(57, 20);
            genderLbl.TabIndex = 13;
            genderLbl.Text = "Gender";
            // 
            // ageLbl
            // 
            ageLbl.AutoSize = true;
            ageLbl.Location = new Point(61, 159);
            ageLbl.Margin = new Padding(5, 0, 5, 0);
            ageLbl.Name = "ageLbl";
            ageLbl.Size = new Size(36, 20);
            ageLbl.TabIndex = 11;
            ageLbl.Text = "Age";
            // 
            // lastNameLbl
            // 
            lastNameLbl.AutoSize = true;
            lastNameLbl.Location = new Point(61, 113);
            lastNameLbl.Margin = new Padding(5, 0, 5, 0);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(79, 20);
            lastNameLbl.TabIndex = 10;
            lastNameLbl.Text = "Last Name";
            // 
            // firstNameLbl
            // 
            firstNameLbl.AutoSize = true;
            firstNameLbl.Location = new Point(61, 77);
            firstNameLbl.Margin = new Padding(5, 0, 5, 0);
            firstNameLbl.Name = "firstNameLbl";
            firstNameLbl.Size = new Size(80, 20);
            firstNameLbl.TabIndex = 9;
            firstNameLbl.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 20);
            label1.Name = "label1";
            label1.Size = new Size(138, 23);
            label1.TabIndex = 31;
            label1.Text = "✏️👤Edit Profile";
            // 
            // clsEditControlLbl
            // 
            clsEditControlLbl.AutoSize = true;
            clsEditControlLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clsEditControlLbl.LinkBehavior = LinkBehavior.NeverUnderline;
            clsEditControlLbl.LinkColor = Color.Red;
            clsEditControlLbl.Location = new Point(485, 3);
            clsEditControlLbl.Name = "clsEditControlLbl";
            clsEditControlLbl.Size = new Size(47, 31);
            clsEditControlLbl.TabIndex = 32;
            clsEditControlLbl.TabStop = true;
            clsEditControlLbl.Text = "❌";
            clsEditControlLbl.LinkClicked += clsEditControlLbl_LinkClicked;
            // 
            // EditControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(clsEditControlLbl);
            Controls.Add(label1);
            Controls.Add(UpdateBtn);
            Controls.Add(genderSelect);
            Controls.Add(ageTxtBx);
            Controls.Add(dobSelector);
            Controls.Add(lastNameTxtBx);
            Controls.Add(firstNameTxtBx);
            Controls.Add(genderLbl);
            Controls.Add(ageLbl);
            Controls.Add(lastNameLbl);
            Controls.Add(firstNameLbl);
            ImeMode = ImeMode.NoControl;
            Name = "EditControl";
            Size = new Size(534, 328);
            ResumeLayout(false);
            PerformLayout();
        }

        private void UpdateBtn_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button clearBtn;
        private Button UpdateBtn;
        private ComboBox genderSelect;
        private TextBox ageTxtBx;
        private DateTimePicker dobSelector;
        private TextBox lastNameTxtBx;
        private TextBox firstNameTxtBx;
        private Label genderLbl;
        private Label ageLbl;
        private Label lastNameLbl;
        private Label firstNameLbl;
        private Label label1;
        private LinkLabel clsEditControlLbl;
    }
}
