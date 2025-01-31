using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RioHotel.Admin_Control
{
    public partial class AC_Rooms : UserControl
    {
        function fn = new function();
        String query;

        public AC_Rooms()
        {
            InitializeComponent();
        }

        private void AC_Rooms_Load(object sender, EventArgs e)
        {
            LoadRoomData();
        }

        private void LoadRoomData()
        {
            query = "SELECT * FROM rooms";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
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
            priceComboBox.Items.Clear();

            if (roomtypeComboBox.SelectedItem != null && bedComboBox.SelectedItem != null)
            {
                string roomType = roomtypeComboBox.SelectedItem.ToString();
                string bedType = bedComboBox.SelectedItem.ToString();

                if (roomType == "Ac" && bedType == "Single") priceComboBox.Items.Add("5000");
                if (roomType == "NonAc" && bedType == "Single") priceComboBox.Items.Add("4500");
                if (roomType == "Ac" && bedType == "Double") priceComboBox.Items.Add("6000");
                if (roomType == "NonAc" && bedType == "Double") priceComboBox.Items.Add("5500");
                if (roomType == "Ac" && bedType == "Triple") priceComboBox.Items.Add("8000");
                if (roomType == "NonAc" && bedType == "Triple") priceComboBox.Items.Add("7500");

                priceComboBox.SelectedIndex = 0; // Auto-select the first price
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(roomnoTextBox.Text) ||
                roomtypeComboBox.SelectedItem == null ||
                bedComboBox.SelectedItem == null ||
                priceComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields except 'Booked'!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string roomNo = roomnoTextBox.Text;
            string roomType = roomtypeComboBox.SelectedItem.ToString();
            string bed = bedComboBox.SelectedItem.ToString();
            string price = priceComboBox.SelectedItem.ToString();
            string booked = bookedComboBox.SelectedItem != null ? bookedComboBox.SelectedItem.ToString() : "NO";

            query = $"INSERT INTO rooms (roomNo, roomType, bed, price, booked) VALUES ('{roomNo}', '{roomType}', '{bed}', '{price}', '{booked}')";
            fn.setData(query, "Room Added Successfully!");
            LoadRoomData();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idTextBox.Text))
            {
                MessageBox.Show("Please enter a Room ID to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            query = $"SELECT * FROM rooms WHERE roomid = '{idTextBox.Text}'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                roomnoTextBox.Text = row["roomNo"].ToString();
                roomtypeComboBox.SelectedItem = row["roomType"].ToString();
                bedComboBox.SelectedItem = row["bed"].ToString();
                priceComboBox.SelectedItem = row["price"].ToString();
                bookedComboBox.SelectedItem = row["booked"].ToString();
            }
            else
            {
                MessageBox.Show("Room Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idTextBox.Text))
            {
                MessageBox.Show("Please enter a Room ID to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(roomnoTextBox.Text) ||
                roomtypeComboBox.SelectedItem == null ||
                bedComboBox.SelectedItem == null ||
                priceComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string roomNo = roomnoTextBox.Text;
            string roomType = roomtypeComboBox.SelectedItem.ToString();
            string bed = bedComboBox.SelectedItem.ToString();
            string price = priceComboBox.SelectedItem.ToString();
            string booked = bookedComboBox.SelectedItem != null ? bookedComboBox.SelectedItem.ToString() : "NO";

            query = $"UPDATE rooms SET roomNo='{roomNo}', roomType='{roomType}', bed='{bed}', price='{price}', booked='{booked}' WHERE roomid='{idTextBox.Text}'";
            fn.setData(query, "Room Updated Successfully!");
            LoadRoomData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idTextBox.Text))
            {
                MessageBox.Show("Please enter a Room ID to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            query = $"DELETE FROM rooms WHERE roomid='{idTextBox.Text}'";
            fn.setData(query, "Room Deleted Successfully!");
            LoadRoomData();
        }
    }
}
