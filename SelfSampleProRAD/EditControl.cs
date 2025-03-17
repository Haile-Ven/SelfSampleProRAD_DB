﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SelfSampleProRAD_DB.DTOs;
using SelfSampleProRAD_DB.Controller;

namespace SelfSampleProRAD_DB
{
    public partial class EditControl : UserControl
    {
        EmployeeEditDTO employee;
        public EditControl()
        {
            InitializeComponent();
            MouseDown += UserControl_MouseDown;
            MouseMove += UserControl_MouseMove;
            MouseUp += UserControl_MouseUp;
        }

        public EditControl(EmployeeEditDTO employee)
        {
            InitializeComponent();
            MouseDown += UserControl_MouseDown;
            MouseMove += UserControl_MouseMove;
            MouseUp += UserControl_MouseUp;
            this.employee = employee;
            firstNameTxtBx.Text = employee.FirstName;
            lastNameTxtBx.Text = employee.LastName;
            genderSelect.SelectedItem = employee.Gender switch
            {
                'M' => "Male",
                'F' => "Female",
                _ => "Other"
            };
            dobSelector.Value = DateTime.Now.AddYears(-employee.Age);
            ageTxtBx.Text = employee.Age.ToString();
        }

        // Transfer Edit Link Lable Event Handler To CompleteForm
        public event LinkLabelLinkClickedEventHandler clsEditControlLblClicked;

        private void clsEditControlLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsEditControlLblClicked?.Invoke(sender, e);
        }

        // Make User Control Draggable
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        private void UserControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = e.Location; // Save the initial mouse position
            }
        }

        private void UserControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Calculate the new position based on mouse movement
                Left += e.X - startPoint.X;
                Top += e.Y - startPoint.Y;
            }
        }

        private void UserControl_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false; // Stop dragging
        }
        // Transfer Update Button Click Event Handler To CompleteForm After Finishing Update
        public event EventHandler UpdateBtnClicked;
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var response = new EmployeeController().UpdateEmployee
                (
                new EmployeeEditDTO
                {
                    EmployeeId = employee.EmployeeId,
                    FirstName = firstNameTxtBx.Text,
                    LastName = lastNameTxtBx.Text,
                    Gender = genderSelect.SelectedItem.ToString()[0],
                    Age = byte.Parse(ageTxtBx.Text)
                });
            MessageBox.Show(response);
            firstNameTxtBx.Text = string.Empty;
            lastNameTxtBx.Text = string.Empty;
            genderSelect.SelectedIndex = 0;
            ageTxtBx.Text = string.Empty;
            UpdateBtnClicked?.Invoke(sender, e);
        }

        private void DobSelector_ValueChanged(object sender, EventArgs e)
        {
            ageTxtBx.Text = (DateTime.Now.Year - dobSelector.Value.Year).ToString();
        }
    }
}
