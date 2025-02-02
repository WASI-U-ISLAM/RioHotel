using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RioHotel.All_Users_Control
{
    public partial class AUC_Rooms : UserControl
    {
        function fn = new function();
        String query;
        Random random = new Random();

        public AUC_Rooms()
        {
            InitializeComponent();
        }

        private void AUC_Rooms_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void GenerateRoomNumber()
        {
            roomnoTextBox.Text = random.Next(100, 999).ToString();
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
            if (roomtypeComboBox.SelectedItem == null || bedComboBox.SelectedItem == null)
                return;

            string roomType = roomtypeComboBox.SelectedItem.ToString();
            string bedType = bedComboBox.SelectedItem.ToString();

            if (roomType == "Ac")
            {
                if (bedType == "Single")
                    priceComboBox.Items.Add("5000");
                else if (bedType == "Double")
                    priceComboBox.Items.Add("6000");
                else if (bedType == "Triple")
                    priceComboBox.Items.Add("8000");
            }
            else if (roomType == "NonAc")
            {
                if (bedType == "Single")
                    priceComboBox.Items.Add("4500");
                else if (bedType == "Double")
                    priceComboBox.Items.Add("5500");
                else if (bedType == "Triple")
                    priceComboBox.Items.Add("7500");
            }
        }

        private void addroomButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(roomnoTextBox.Text) ||
                roomtypeComboBox.SelectedItem == null ||
                bedComboBox.SelectedItem == null ||
                priceComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields except Booked before adding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string roomNo = roomnoTextBox.Text;
            string roomType = roomtypeComboBox.SelectedItem.ToString();
            string bedType = bedComboBox.SelectedItem.ToString();
            string price = priceComboBox.SelectedItem.ToString();
            string booked = bookedComboBox.SelectedItem?.ToString() ?? "NO";

            query = $"INSERT INTO rooms (roomNo, roomType, bed, price, booked) VALUES ('{roomNo}', '{roomType}', '{bedType}', '{price}', '{booked}')";
            fn.setData(query, "Room Added Successfully!");

            AUC_Rooms_Load(sender, e); // Refresh Grid
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
