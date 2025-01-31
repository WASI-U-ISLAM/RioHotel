using System;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void MovePanel(Control btn)
        {
            movePanel.Top = btn.Top;
            movePanel.Height = btn.Height;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Show a confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?",
                                                  "Confirm Exit",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // Check the user's choice
            if (result == DialogResult.Yes)
            {
                Environment.Exit(1); // Exit the application
            }
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal; // Restore if already maximized
            }
            else
            {
                WindowState = FormWindowState.Maximized; // Maximize if not already maximized
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            MovePanel(logoutButton);
            DialogResult result = MessageBox.Show("Do you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Find the login form if it's already open
                Form loginForm = Application.OpenForms["Login"];

                if (loginForm != null)
                {
                    // Reset textboxes before showing login form
                    ((Login)loginForm).ClearFields();
                    loginForm.Show();
                }
                else
                {
                    // If not found, create a new instance
                    Login newLoginForm = new Login();
                    newLoginForm.Show();
                }

                // Close the current admin form
                this.Close();
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void aC_Rooms1_Load(object sender, EventArgs e)
        {

        }

        private void aC_Users1_Load(object sender, EventArgs e)
        {

        }

        private void usersButton_Click(object sender, EventArgs e)
        {

        }

        private void roomsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
