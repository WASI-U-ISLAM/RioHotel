﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RioHotel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            hideButton.Visible = false; // Ensure hideButton is initially hidden
            passTextBox.UseSystemPasswordChar = true; // Ensure password is hidden initially
            usernamewarnLabel.Visible = false;
            passwarnLabel.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void canclebutton_Click(object sender, EventArgs e)
        {
            // Show a confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?",
                                                  "Confirm Exit",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // Check the user's choice
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logintoLabel_Click(object sender, EventArgs e)
        {
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            passTextBox.UseSystemPasswordChar = false; // Show password
            showButton.Visible = false;
            hideButton.Visible = true;
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            passTextBox.UseSystemPasswordChar = true; // Hide password
            hideButton.Visible = false;
            showButton.Visible = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            hideButton.Visible = false;
            showButton.Visible = true;
            passTextBox.UseSystemPasswordChar = true; // Ensure password is hidden initially
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            // Check if the username text box is empty
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                usernamewarnLabel.Visible = true; // Show the username warning label
            }
            else
            {
                usernamewarnLabel.Visible = false; // Hide the username warning label
            }

            // Check if the password text box is empty
            if (string.IsNullOrWhiteSpace(passTextBox.Text))
            {
                passwarnLabel.Visible = true; // Show the password warning label
            }
            else
            {
                passwarnLabel.Visible = false; // Hide the password warning label
            }
        }
    }
}
