using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RioHotel.All_Users_Control
{
    public partial class UC_Booking : UserControl
    {
        function fn = new function();
        string query;

        public UC_Booking()
        {
            InitializeComponent();
        }

        private void UC_Booking_Load(object sender, EventArgs e)
        {
            LoadBedTypes();
            LoadRoomTypes();
            LoadAvailableRooms();
        }

        private void LoadBedTypes()
        {
            query = "SELECT DISTINCT bed FROM rooms";
            SqlDataReader dr = fn.getforCombo(query);
            bedComboBox.Items.Clear();
            while (dr.Read())
            {
                bedComboBox.Items.Add(dr["bed"].ToString());
            }
            dr.Close();
        }

        private void LoadRoomTypes()
        {
            query = "SELECT DISTINCT roomType FROM rooms";
            SqlDataReader dr = fn.getforCombo(query);
            roomtypeComboBox.Items.Clear();
            while (dr.Read())
            {
                roomtypeComboBox.Items.Add(dr["roomType"].ToString());
            }
            dr.Close();
        }

        private void LoadAvailableRooms()
        {
            query = "SELECT roomNo, roomid FROM rooms WHERE booked = 'NO'"; // Fetch both roomNo and roomid
            SqlDataReader dr = fn.getforCombo(query);
            roomnoComboBox.Items.Clear();
            roomidComboBox.Items.Clear();

            while (dr.Read())
            {
                roomnoComboBox.Items.Add(dr["roomNo"].ToString());
                roomidComboBox.Items.Add(dr["roomid"].ToString()); // Populate roomidComboBox
            }
            dr.Close();

            // Ensure combo boxes start empty and don't auto-select a value
            roomnoComboBox.Text = "";
            roomnoComboBox.SelectedIndex = -1;
            roomidComboBox.Text = "";
            roomidComboBox.SelectedIndex = -1;

            // If no rooms are available, show a message
            if (roomnoComboBox.Items.Count == 0)
            {
                MessageBox.Show("No rooms available for booking.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void roomtypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePriceOptions();
        }

        private void bedComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePriceOptions();
        }

        private void UpdatePriceOptions()
        {
            if (roomtypeComboBox.SelectedItem == null || bedComboBox.SelectedItem == null)
                return;

            string roomType = roomtypeComboBox.SelectedItem.ToString();
            string bedType = bedComboBox.SelectedItem.ToString();

            priceComboBox.Items.Clear();

            if (roomType == "Ac" && bedType == "Single")
                priceComboBox.Items.Add("5000");
            else if (roomType == "NonAc" && bedType == "Single")
                priceComboBox.Items.Add("4500");
            else if (roomType == "Ac" && bedType == "Double")
                priceComboBox.Items.Add("6000");
            else if (roomType == "NonAc" && bedType == "Double")
                priceComboBox.Items.Add("5500");
            else if (roomType == "Ac" && bedType == "Triple")
                priceComboBox.Items.Add("8000");
            else if (roomType == "NonAc" && bedType == "Triple")
                priceComboBox.Items.Add("7500");

            if (priceComboBox.Items.Count > 0)
                priceComboBox.SelectedIndex = 0;
        }

        private void discountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateFinalPrice();
        }

        private void advancepaidTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateFinalPrice();
        }

        private void CalculateFinalPrice()
        {
            if (priceComboBox.SelectedItem == null || discountComboBox.SelectedItem == null)
                return;

            decimal originalPrice = Convert.ToDecimal(priceComboBox.SelectedItem);
            int discountPercent = int.Parse(discountComboBox.SelectedItem.ToString().Replace("%", ""));
            decimal discountedPrice = originalPrice - (originalPrice * discountPercent / 100);

            if (decimal.TryParse(advancepaidTextBox.Text, out decimal advancePaid))
            {
                discountedPrice -= advancePaid;
            }

            finalpriceComboBox.Items.Clear();
            finalpriceComboBox.Items.Add(discountedPrice.ToString("0"));
            finalpriceComboBox.SelectedIndex = 0;
        }

        private void bookButton_Click_1(object sender, EventArgs e)
        {
            // Validate all required fields
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(nidTextBox.Text) ||
                string.IsNullOrWhiteSpace(nationalityTextBox.Text) ||
                string.IsNullOrWhiteSpace(phnnumberTextBox.Text) ||
                string.IsNullOrWhiteSpace(addressTextBox.Text) ||
                genderComboBox.SelectedItem == null ||
                roomtypeComboBox.SelectedItem == null ||
                bedComboBox.SelectedItem == null ||
                roomnoComboBox.SelectedItem == null ||
                roomidComboBox.SelectedItem == null ||
                priceComboBox.SelectedItem == null ||
                discountComboBox.SelectedItem == null ||
                string.IsNullOrWhiteSpace(advancepaidTextBox.Text) ||
                finalpriceComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve values from form controls
            string cname = nameTextBox.Text.Trim();
            string nationality = nationalityTextBox.Text.Trim();
            string dob = dobDateTimePicker.Value.ToString("yyyy-MM-dd");
            string phoneNum = phnnumberTextBox.Text.Trim();
            string nid = nidTextBox.Text.Trim();
            string address = addressTextBox.Text.Trim();
            string gender = genderComboBox.SelectedItem.ToString();
            string roomid = roomidComboBox.SelectedItem.ToString();
            string roomNo = roomnoComboBox.SelectedItem.ToString();
            string checkin = checkinDateTimePicker.Value.ToString("yyyy-MM-dd");
            string discount = discountComboBox.SelectedItem.ToString().Replace("%", "");
            string advancePaid = advancepaidTextBox.Text.Trim();
            string finalPrice = finalpriceComboBox.SelectedItem.ToString();
            string price = priceComboBox.SelectedItem.ToString();

            try
            {
                // Insert into customers table
                query = $@"INSERT INTO customers (cname, nationality, dob, phoneNum, nid, address, gender, roomid, roomNo, checkin, discount, advancePaid, finalPrice, price) 
                    VALUES ('{cname}', '{nationality}', '{dob}', '{phoneNum}', '{nid}', '{address}', '{gender}', '{roomid}', '{roomNo}', '{checkin}', '{discount}', '{advancePaid}', '{finalPrice}', '{price}')";
                fn.setData(query, "Customer details added successfully!");

                // Mark room as booked
                query = $"UPDATE rooms SET booked = 'YES' WHERE roomid = '{roomid}'";
                fn.setData(query, "Room marked as booked.");

                // Refresh available rooms
                LoadAvailableRooms();

                // Clear form fields after successful booking
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            // Clear all text boxes
            nameTextBox.Clear();
            nidTextBox.Clear();
            nationalityTextBox.Clear();
            phnnumberTextBox.Clear();
            addressTextBox.Clear();

            // Reset combo boxes
            genderComboBox.SelectedIndex = -1;
            roomtypeComboBox.SelectedIndex = -1;
            bedComboBox.SelectedIndex = -1;
            roomnoComboBox.SelectedIndex = -1;
            roomidComboBox.SelectedIndex = -1;
            priceComboBox.Items.Clear();
            discountComboBox.SelectedIndex = -1;
            advancepaidTextBox.Clear();
            finalpriceComboBox.Items.Clear();

            // Reset date pickers
            dobDateTimePicker.Value = DateTime.Now;
            checkinDateTimePicker.Value = DateTime.Now;
        }

        private void roomnoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Automatically select the corresponding roomid when roomNo is selected
            if (roomnoComboBox.SelectedIndex >= 0 && roomnoComboBox.SelectedIndex < roomidComboBox.Items.Count)
            {
                roomidComboBox.SelectedIndex = roomnoComboBox.SelectedIndex;
            }
        }

        private void roomidComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Automatically select the corresponding roomNo when roomid is selected
            if (roomidComboBox.SelectedIndex >= 0 && roomidComboBox.SelectedIndex < roomnoComboBox.Items.Count)
            {
                roomnoComboBox.SelectedIndex = roomidComboBox.SelectedIndex;
            }
        }
    }
}