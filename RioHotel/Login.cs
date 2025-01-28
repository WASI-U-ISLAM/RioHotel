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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
            // If the user selects "No", the application continues running
        }

        private void logintoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
