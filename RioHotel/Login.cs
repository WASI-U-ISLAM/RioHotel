using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RioHotel
{
    public partial class Login : Form
    {
        private string connectionString = "Data Source=WASI-LENOVO\\SQLEXPRESS;Initial Catalog=\"RIO HOTEL\";Persist Security Info=True;User ID=sa;Password=w4a4s4i4;Encrypt=True;TrustServerCertificate=True";

        public Login()
        {
            InitializeComponent();
            hideButton.Visible = false;
            passTextBox.UseSystemPasswordChar = true;
            usernamewarnLabel.Visible = false;
            passwarnLabel.Visible = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            hideButton.Visible = false;
            showButton.Visible = true;
            passTextBox.UseSystemPasswordChar = true;
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e) { }
        private void passTextBox_TextChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void logintoLabel_Click(object sender, EventArgs e) { }
        private void showButton_Click(object sender, EventArgs e)
        {
            passTextBox.UseSystemPasswordChar = false;
            showButton.Visible = false;
            hideButton.Visible = true;
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            passTextBox.UseSystemPasswordChar = true;
            hideButton.Visible = false;
            showButton.Visible = true;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
                usernamewarnLabel.Visible = true;
            else
                usernamewarnLabel.Visible = false;

            if (string.IsNullOrWhiteSpace(passTextBox.Text))
                passwarnLabel.Visible = true;
            else
                passwarnLabel.Visible = false;

            if (!string.IsNullOrWhiteSpace(usernameTextBox.Text) && !string.IsNullOrWhiteSpace(passTextBox.Text))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string employeeQuery = "SELECT COUNT(*) FROM Employee WHERE Username = @username AND Password = @password";
                        using (SqlCommand empCmd = new SqlCommand(employeeQuery, conn))
                        {
                            empCmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                            empCmd.Parameters.AddWithValue("@password", passTextBox.Text);
                            int empCount = (int)empCmd.ExecuteScalar();
                            if (empCount > 0)
                            {
                                MessageBox.Show("Employee login successful! Redirecting to Home.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Home homePage = new Home();
                                homePage.Show();
                                //this.Hide();
                                //this.Close();
                                return;
                            }
                        }

                        string adminQuery = "SELECT COUNT(*) FROM Admin WHERE Username = @username AND Password = @password";
                        using (SqlCommand adminCmd = new SqlCommand(adminQuery, conn))
                        {
                            adminCmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                            adminCmd.Parameters.AddWithValue("@password", passTextBox.Text);
                            int adminCount = (int)adminCmd.ExecuteScalar();
                            if (adminCount > 0)
                            {
                                MessageBox.Show("Admin login successful! Redirecting to Admin page.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Admin adminPage = new Admin();
                                adminPage.Show();
                                //this.Hide();
                                //this.Close();
                                return;
                            }
                        }

                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
