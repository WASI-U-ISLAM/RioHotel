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
    public partial class Home : Form
    {
        public string Username;

        public Home()
        {
            InitializeComponent();
        }

        private void MovePanel(Control btn)
        {
            movePanel.Top = btn.Top;
            movePanel.Height = btn.Height;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
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

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void datetimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datetimeLabel.Text = DateTime.Now.ToString("dd-MMM-yyyy  hh:mm:ss tt");
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
            usernamelabel.Text = Username;
        }

        private void movePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            MovePanel(dashboardButton);
        }

        private void roomsButton_Click(object sender, EventArgs e)
        {
            MovePanel(roomsButton);
        }

        private void bookingButton_Click(object sender, EventArgs e)
        {
            MovePanel(bookingButton);
        }

        private void guestsbutton_Click(object sender, EventArgs e)
        {
            MovePanel(guestsbutton);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            MovePanel(logoutButton);
            DialogResult result = MessageBox.Show("do you want to Log out?", "logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void usernamelabel_Click(object sender, EventArgs e)
        {

        }
    }
}
