using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RioHotel
{
    public partial class Home : Form
    {
        private function fn = new function(); // Instance of function class
        private string connectionString = "Data Source=WASI-LENOVO\\SQLEXPRESS;Initial Catalog=\"RIO HOTEL\";Persist Security Info=True;User ID=sa;Password=w4a4s4i4;Encrypt=True;TrustServerCertificate=True";
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datetimeLabel.Text = DateTime.Now.ToString("dd-MMM-yyyy  hh:mm:ss tt");
        }

        private void Home_Load(object sender, EventArgs e)
        {
            auC_Rooms1.Visible = false;
            timer1.Start();
            usernamelabel.Text = Username;
            uC_Booking1.Visible = false;
            cusinfoPanel.Visible = false;
            checkoutComboBox.Items.AddRange(new string[] { "Yes", "No" });
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            MovePanel(dashboardButton);
            auC_Rooms1.Visible = false;
            uC_Booking1.Visible = false;
            cusinfoPanel.Visible = false;
        }

        private void roomsButton_Click(object sender, EventArgs e)
        {
            MovePanel(roomsButton);
            auC_Rooms1.Visible = true;
            uC_Booking1.Visible = false;
            cusinfoPanel.Visible = false;
        }

        private void bookingButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MovePanel(bookingButton);
                    auC_Rooms1.Visible = false;
                    uC_Booking1.Visible = true;
                    cusinfoPanel.Visible = false;
                }
                catch (Exception ex) { }
            }
        }

        private void guestsbutton_Click(object sender, EventArgs e)
        {
            MovePanel(guestsbutton);
            auC_Rooms1.Visible = false;
            uC_Booking1.Visible = false;
            cusinfoPanel.Visible = true;
            cusinfoPanel.Refresh();
            string query = "SELECT * FROM customers";
            DataSet ds = fn.getData(query);
            cusinfoDataGridView.DataSource = ds.Tables[0];
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            uC_Booking1.Visible = false;
            auC_Rooms1.Visible = false;
            cusinfoPanel.Visible = false;
            MovePanel(logoutButton);
            DialogResult result = MessageBox.Show("Do you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                timer1.Stop();
                Form loginForm = Application.OpenForms["Login"];
                if (loginForm != null)
                {
                    ((Login)loginForm).ClearFields();
                    loginForm.Show();
                }
                else
                {
                    Login newLoginForm = new Login();
                    newLoginForm.Show();
                }
                this.Close();
            }
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM customers WHERE 1=1";

            // Add search filters based on name and phone number
            if (!string.IsNullOrEmpty(nameTextBox.Text))
            {
                query += " AND cname LIKE '%" + nameTextBox.Text + "%'";
            }

            if (!string.IsNullOrEmpty(phnnumberTextBox.Text))
            {
                query += " AND phoneNum LIKE '%" + phnnumberTextBox.Text + "%'";
            }

            // Add filter for checkedout status if selected
            if (checkoutComboBox.SelectedItem != null)
            {
                string status = checkoutComboBox.SelectedItem.ToString();
                query += " AND checkedout = '" + status + "'";
            }

            // Execute the query
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                // Get the first row from the result
                DataRow row = ds.Tables[0].Rows[0];

                // Populate the controls with data from the row
                nameTextBox.Text = row["cname"] != DBNull.Value ? row["cname"].ToString() : "";
                nationalityTextBox.Text = row["nationality"] != DBNull.Value ? row["nationality"].ToString() : "";
                phnnumberTextBox.Text = row["phoneNum"] != DBNull.Value ? row["phoneNum"].ToString() : "";
                nidTextBox.Text = row["nid"] != DBNull.Value ? row["nid"].ToString() : "";
                addressTextBox.Text = row["address"] != DBNull.Value ? row["address"].ToString() : "";

                // Handle DateTime values safely
                if (row["dob"] != DBNull.Value)
                {
                    dobDateTimePicker.Value = Convert.ToDateTime(row["dob"]);
                }

                if (row["checkin"] != DBNull.Value)
                {
                    checkinDateTimePicker.Value = Convert.ToDateTime(row["checkin"]);
                }

                if (row["checkout"] != DBNull.Value)
                {
                    checkoutDateTimePicker.Value = Convert.ToDateTime(row["checkout"]);
                }

                // Populate combo boxes
                genderComboBox.SelectedItem = row["gender"] != DBNull.Value ? row["gender"].ToString() : "";
                roomidComboBox.SelectedItem = row["roomid"] != DBNull.Value ? row["roomid"].ToString() : "";
                priceComboBox.SelectedItem = row["price"] != DBNull.Value ? row["price"].ToString() : "";
                discountComboBox.SelectedItem = row["discount"] != DBNull.Value ? row["discount"].ToString() : "";
                checkoutComboBox.SelectedItem = row["checkedout"] != DBNull.Value ? row["checkedout"].ToString() : "NO";

                // Populate text boxes for numeric values
                roomnoComboBox.Text = row["roomNo"] != DBNull.Value ? row["roomNo"].ToString() : "";
                advancepaidTextBox.Text = row["advancePaid"] != DBNull.Value ? row["advancePaid"].ToString() : "0";
                finalpriceComboBox.Text = row["finalPrice"] != DBNull.Value ? row["finalPrice"].ToString() : "0";
                fullpricepaidTextBox.Text = row["fullpricePaid"] != DBNull.Value ? row["fullpricePaid"].ToString() : "0";

                // Select the corresponding row in the DataGridView
                foreach (DataGridViewRow dgvRow in cusinfoDataGridView.Rows)
                {
                    if (dgvRow.Cells["cid"].Value != DBNull.Value && dgvRow.Cells["cid"].Value.ToString() == row["cid"].ToString())
                    {
                        dgvRow.Selected = true;
                        cusinfoDataGridView.CurrentCell = dgvRow.Cells[0]; // Set focus to the first column
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("No records found!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void updateButton_Click_1(object sender, EventArgs e)
        {
            if (cusinfoDataGridView.SelectedRows.Count > 0)
            {
                try
                {
                    int cid = Convert.ToInt32(cusinfoDataGridView.SelectedRows[0].Cells["cid"].Value);
                    string name = nameTextBox.Text;
                    string phone = phnnumberTextBox.Text;
                    string address = addressTextBox.Text;
                    string nationality = string.IsNullOrEmpty(nationalityTextBox.Text) ? "Unknown" : nationalityTextBox.Text; // Handle NULL Nationality
                    string checkedout = checkoutComboBox.SelectedItem.ToString();
                    string checkin = checkinDateTimePicker.Value.ToString("yyyy-MM-dd");

                    // Update query to include Nationality
                    string query = "UPDATE customers SET cname = '" + name + "', phoneNum = '" + phone + "', address = '" + address + "', nationality = '" + nationality + "', checkedout = '" + checkedout + "', checkin = '" + checkin + "' WHERE cid = " + cid;
                    fn.setData(query, "Customer details updated successfully!");

                    searchButton.PerformClick(); // Refresh DataGrid
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating customer details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select a customer to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            if (cusinfoDataGridView.SelectedRows.Count > 0)
            {
                try
                {
                    // Extract values safely
                    int cid = Convert.ToInt32(cusinfoDataGridView.SelectedRows[0].Cells["cid"].Value ?? 0);
                    string cname = cusinfoDataGridView.SelectedRows[0].Cells["cname"].Value?.ToString() ?? "Unknown";
                    string nationality = cusinfoDataGridView.SelectedRows[0].Cells["nationality"].Value?.ToString() ?? "Unknown";
                    string phoneNum = cusinfoDataGridView.SelectedRows[0].Cells["phoneNum"].Value?.ToString() ?? "N/A";
                    string nid = cusinfoDataGridView.SelectedRows[0].Cells["nid"].Value?.ToString() ?? "N/A";
                    string address = cusinfoDataGridView.SelectedRows[0].Cells["address"].Value?.ToString() ?? "N/A";
                    string gender = cusinfoDataGridView.SelectedRows[0].Cells["gender"].Value?.ToString() ?? "N/A";
                    string roomid = cusinfoDataGridView.SelectedRows[0].Cells["roomid"].Value?.ToString() ?? "Unknown";
                    string roomNo = cusinfoDataGridView.SelectedRows[0].Cells["roomNo"].Value?.ToString() ?? "Unknown";

                    // Parse DateTime safely
                    DateTime checkin = DateTime.TryParse(cusinfoDataGridView.SelectedRows[0].Cells["checkin"].Value?.ToString(), out DateTime tempCheckin) ? tempCheckin : DateTime.Now;
                    DateTime checkout = DateTime.Now; // Assuming checkout is now

                    // Check if dob is null
                    object dobValue = cusinfoDataGridView.SelectedRows[0].Cells["dob"].Value;
                    if (dobValue == null || dobValue == DBNull.Value || !DateTime.TryParse(dobValue.ToString(), out DateTime dob))
                    {
                        MessageBox.Show("Date of birth (DOB) is missing or invalid. Please check the selected customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Parse decimal values safely
                    decimal price = decimal.TryParse(cusinfoDataGridView.SelectedRows[0].Cells["price"].Value?.ToString(), out decimal tempPrice) ? tempPrice : 0;
                    decimal discount = decimal.TryParse(cusinfoDataGridView.SelectedRows[0].Cells["discount"].Value?.ToString(), out decimal tempDiscount) ? tempDiscount : 0;
                    decimal advancePaid = decimal.TryParse(cusinfoDataGridView.SelectedRows[0].Cells["advancePaid"].Value?.ToString(), out decimal tempAdvance) ? tempAdvance : 0;
                    decimal finalPrice = decimal.TryParse(cusinfoDataGridView.SelectedRows[0].Cells["finalPrice"].Value?.ToString(), out decimal tempFinal) ? tempFinal : 0;
                    decimal fullpricePaid = decimal.TryParse(cusinfoDataGridView.SelectedRows[0].Cells["fullpricePaid"].Value?.ToString(), out decimal tempFull) ? tempFull : 0;

                    // SQL Insert Query with Parameterized Query
                    string insertQuery = "INSERT INTO checkout (cid, cname, nationality, dob, phoneNum, nid, address, gender, roomid, roomNo, checkin, checkout, checkedout, price, discount, advancePaid, finalPrice, fullpricePaid) " +
                                         "VALUES (@cid, @cname, @nationality, @dob, @phoneNum, @nid, @address, @gender, @roomid, @roomNo, @checkin, @checkout, @checkedout, @price, @discount, @advancePaid, @finalPrice, @fullpricePaid)";

                    using (SqlConnection conn = new SqlConnection(connectionString)) // Use the actual connection string
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            // Assign Parameters
                            cmd.Parameters.AddWithValue("@cid", cid);
                            cmd.Parameters.AddWithValue("@cname", cname);
                            cmd.Parameters.AddWithValue("@nationality", nationality);
                            cmd.Parameters.AddWithValue("@dob", dob);
                            cmd.Parameters.AddWithValue("@phoneNum", phoneNum);
                            cmd.Parameters.AddWithValue("@nid", nid);
                            cmd.Parameters.AddWithValue("@address", address);
                            cmd.Parameters.AddWithValue("@gender", gender);
                            cmd.Parameters.AddWithValue("@roomid", roomid);
                            cmd.Parameters.AddWithValue("@roomNo", roomNo);
                            cmd.Parameters.AddWithValue("@checkin", checkin);
                            cmd.Parameters.AddWithValue("@checkout", checkout);
                            cmd.Parameters.AddWithValue("@checkedout", DateTime.Now);
                            cmd.Parameters.AddWithValue("@price", price);
                            cmd.Parameters.AddWithValue("@discount", discount);
                            cmd.Parameters.AddWithValue("@advancePaid", advancePaid);
                            cmd.Parameters.AddWithValue("@finalPrice", finalPrice);
                            cmd.Parameters.AddWithValue("@fullpricePaid", fullpricePaid);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Customer checked out successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Delete customer from customers table
                    string deleteQuery = "DELETE FROM customers WHERE cid = @cid";
                    using (SqlConnection conn = new SqlConnection(connectionString)) // Use the actual connection string
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@cid", cid);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Delete room from rooms table
                    string deleteRoomQuery = "DELETE FROM rooms WHERE roomid = @roomid";
                    using (SqlConnection conn = new SqlConnection(connectionString)) // Use the actual connection string
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(deleteRoomQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@roomid", roomid);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Refresh DataGrid
                    searchButton.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during checkout: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select a customer to check out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM customers WHERE 1=1";

            // Add search filters based on name and phone number
            if (!string.IsNullOrEmpty(nameTextBox.Text))
            {
                query += " AND cname LIKE '%" + nameTextBox.Text + "%'";
            }

            if (!string.IsNullOrEmpty(phnnumberTextBox.Text))
            {
                query += " AND phoneNum LIKE '%" + phnnumberTextBox.Text + "%'";
            }

            // Add filter for checkedout status if selected
            if (checkoutComboBox.SelectedItem != null)
            {
                string status = checkoutComboBox.SelectedItem.ToString();
                query += " AND checkedout = '" + status + "'";
            }

            // Execute the query
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                // Get the first row from the result
                DataRow row = ds.Tables[0].Rows[0];

                // Populate the controls with data from the row
                nameTextBox.Text = row["cname"] != DBNull.Value ? row["cname"].ToString() : "";
                nationalityTextBox.Text = row["nationality"] != DBNull.Value ? row["nationality"].ToString() : "";
                phnnumberTextBox.Text = row["phoneNum"] != DBNull.Value ? row["phoneNum"].ToString() : "";
                nidTextBox.Text = row["nid"] != DBNull.Value ? row["nid"].ToString() : "";
                addressTextBox.Text = row["address"] != DBNull.Value ? row["address"].ToString() : "";

                // Handle DateTime values safely
                if (row["dob"] != DBNull.Value)
                {
                    dobDateTimePicker.Value = Convert.ToDateTime(row["dob"]);
                }

                if (row["checkin"] != DBNull.Value)
                {
                    checkinDateTimePicker.Value = Convert.ToDateTime(row["checkin"]);
                }

                if (row["checkout"] != DBNull.Value)
                {
                    checkoutDateTimePicker.Value = Convert.ToDateTime(row["checkout"]);
                }

                // Populate combo boxes
                genderComboBox.SelectedItem = row["gender"] != DBNull.Value ? row["gender"].ToString() : "";
                roomidComboBox.SelectedItem = row["roomid"] != DBNull.Value ? row["roomid"].ToString() : "";
                priceComboBox.SelectedItem = row["price"] != DBNull.Value ? row["price"].ToString() : "";
                discountComboBox.SelectedItem = row["discount"] != DBNull.Value ? row["discount"].ToString() : "";
                checkoutComboBox.SelectedItem = row["checkedout"] != DBNull.Value ? row["checkedout"].ToString() : "NO";

                // Populate text boxes for numeric values
                roomnoComboBox.Text = row["roomNo"] != DBNull.Value ? row["roomNo"].ToString() : "";
                advancepaidTextBox.Text = row["advancePaid"] != DBNull.Value ? row["advancePaid"].ToString() : "0";
                finalpriceComboBox.Text = row["finalPrice"] != DBNull.Value ? row["finalPrice"].ToString() : "0";
                fullpricepaidTextBox.Text = row["fullpricePaid"] != DBNull.Value ? row["fullpricePaid"].ToString() : "0";

                // Select the corresponding row in the DataGridView
                foreach (DataGridViewRow dgvRow in cusinfoDataGridView.Rows)
                {
                    if (dgvRow.Cells["cid"].Value != DBNull.Value && dgvRow.Cells["cid"].Value.ToString() == row["cid"].ToString())
                    {
                        dgvRow.Selected = true;
                        cusinfoDataGridView.CurrentCell = dgvRow.Cells[0]; // Set focus to the first column
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("No records found!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (cusinfoDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a customer to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int cid = Convert.ToInt32(cusinfoDataGridView.SelectedRows[0].Cells["cid"].Value);
                string name = nameTextBox.Text;
                string phone = phnnumberTextBox.Text;
                string address = addressTextBox.Text;
                string nationality = string.IsNullOrEmpty(nationalityTextBox.Text) ? "Unknown" : nationalityTextBox.Text;
                string checkedout = checkoutComboBox.SelectedItem != null ? checkoutComboBox.SelectedItem.ToString() : "NO";
                string checkin = checkinDateTimePicker.Value.ToString("yyyy-MM-dd");

                string query = $"UPDATE customers SET cname = '{name}', phoneNum = '{phone}', address = '{address}', nationality = '{nationality}', checkedout = '{checkedout}', checkin = '{checkin}' WHERE cid = {cid}";

                fn.setData(query, "Customer details updated successfully!");

                searchButton.PerformClick(); // Refresh DataGrid
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("A required field is missing. Please check your inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating customer details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cusinfoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cusidLabel_Click(object sender, EventArgs e)
        {

        }

        private void cusidTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderLabel_Click(object sender, EventArgs e)
        {

        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nationalityLabel_Click(object sender, EventArgs e)
        {

        }

        private void nationalityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dobLabel_Click(object sender, EventArgs e)
        {

        }

        private void dobDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void phnnumLabel_Click(object sender, EventArgs e)
        {

        }

        private void phnnumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nidLabel_Click(object sender, EventArgs e)
        {

        }

        private void nidTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bedLabel_Click(object sender, EventArgs e)
        {

        }

        private void bedComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roomtypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void roomtypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roomLabel_Click(object sender, EventArgs e)
        {

        }

        private void roomnoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roomidLabel_Click(object sender, EventArgs e)
        {

        }

        private void roomidComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkinLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkinDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkoutDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }

        private void priceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void discountLabel_Click(object sender, EventArgs e)
        {

        }

        private void discountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void advancepaidLabel_Click(object sender, EventArgs e)
        {

        }

        private void advancepaidTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void finalpriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void finalpriceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
    