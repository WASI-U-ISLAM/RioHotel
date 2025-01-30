using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RioHotel.Admin_Control
{
    public partial class AC_Users : UserControl
    {
        private string connectionString = "Data Source=WASI-LENOVO\\SQLEXPRESS;Initial Catalog=RIO HOTEL;Persist Security Info=True;User ID=sa;Password=w4a4s4i4;Encrypt=True;TrustServerCertificate=True";

        public AC_Users()
        {
            InitializeComponent();
        }

        private void AC_Users_Load(object sender, EventArgs e)
        {
            LoadData(); // Load employee data when the form loads
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Employee";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Employee (ID, Username, Password, Email, Phone) VALUES (@ID, @Username, @Password, @Email, @Phone)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(idtextBox.Text));
                        cmd.Parameters.AddWithValue("@Username", usernameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Password", passTextBox.Text);
                        cmd.Parameters.AddWithValue("@Email", emailTextBox.Text);
                        cmd.Parameters.AddWithValue("@Phone", phoneTextBox.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("User added successfully!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE Employee SET Username=@Username, Password=@Password, Email=@Email, Phone=@Phone WHERE ID=@ID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(idtextBox.Text));
                        cmd.Parameters.AddWithValue("@Username", usernameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Password", passTextBox.Text);
                        cmd.Parameters.AddWithValue("@Email", emailTextBox.Text);
                        cmd.Parameters.AddWithValue("@Phone", phoneTextBox.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            MessageBox.Show("User updated successfully!");
                        else
                            MessageBox.Show("User not found!");
                    }
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Employee WHERE ID=@ID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(idtextBox.Text));
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                dataGridView1.DataSource = dt;
                                usernameTextBox.Text = dt.Rows[0]["Username"].ToString();
                                passTextBox.Text = dt.Rows[0]["Password"].ToString();
                                emailTextBox.Text = dt.Rows[0]["Email"].ToString();
                                phoneTextBox.Text = dt.Rows[0]["Phone"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No User found with this ID.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM Employee WHERE ID=@ID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(idtextBox.Text));
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            MessageBox.Show("User deleted successfully!");
                        else
                            MessageBox.Show("User not found!");
                    }
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
