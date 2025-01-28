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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            timer1.Start(); // Ensure the timer starts
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            // Optional: Any additional setup for loading screen
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 5;

            if (panel2.Width >= 800)
            {
                timer1.Stop(); // Corrected from panel2.Stop()

                // Hide the Loading form
                this.Hide();

                // Ensure the Login form exists before calling it
                Login lp = new Login();
                lp.ShowDialog();

                // Close the Loading form after Login is closed
                this.Close();
            }
        }
    }
}
