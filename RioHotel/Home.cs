using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RioHotel
{
    public partial class Home : Form
    {
        private Timer timer;
        private object labeltime;

        public Home()
        {
            InitializeComponent();
            InitializeClock();
        }

        private void InitializeClock()
        {
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy HH:mm");

        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (sidePnl.Width == 200)
            {
                sidePnl.Width = 38;
            } else
            {
                sidePnl.Width = 200;
            }
        }

        private void AdminPicBox_Click(object sender, EventArgs e)
        {
            if (sidePnl.Width == 38)
            {
                sidePnl.Width = 200;
            }
            else
            {
                sidePnl.Width = 38;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lp = new Login();
            lp.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }
    }
}
