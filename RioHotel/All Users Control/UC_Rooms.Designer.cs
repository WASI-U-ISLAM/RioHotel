namespace RioHotel.All_Users_Control
{
    partial class AUC_Rooms
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addroomLabel = new System.Windows.Forms.Label();
            this.roomnoLabel = new System.Windows.Forms.Label();
            this.roomtypeLabel = new System.Windows.Forms.Label();
            this.bedLabel = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.bookedLabel = new System.Windows.Forms.Label();
            this.addroomButton = new System.Windows.Forms.Button();
            this.roomnoTextBox = new System.Windows.Forms.TextBox();
            this.roomtypeComboBox = new System.Windows.Forms.ComboBox();
            this.bedComboBox = new System.Windows.Forms.ComboBox();
            this.priceComboBox = new System.Windows.Forms.ComboBox();
            this.bookedComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(648, 218);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addroomLabel
            // 
            this.addroomLabel.AutoSize = true;
            this.addroomLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addroomLabel.Location = new System.Drawing.Point(299, 11);
            this.addroomLabel.Name = "addroomLabel";
            this.addroomLabel.Size = new System.Drawing.Size(167, 31);
            this.addroomLabel.TabIndex = 1;
            this.addroomLabel.Text = "ADD ROOM";
            // 
            // roomnoLabel
            // 
            this.roomnoLabel.AutoSize = true;
            this.roomnoLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomnoLabel.Location = new System.Drawing.Point(45, 317);
            this.roomnoLabel.Name = "roomnoLabel";
            this.roomnoLabel.Size = new System.Drawing.Size(106, 23);
            this.roomnoLabel.TabIndex = 2;
            this.roomnoLabel.Text = "Room NO :";
            // 
            // roomtypeLabel
            // 
            this.roomtypeLabel.AutoSize = true;
            this.roomtypeLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomtypeLabel.Location = new System.Drawing.Point(33, 367);
            this.roomtypeLabel.Name = "roomtypeLabel";
            this.roomtypeLabel.Size = new System.Drawing.Size(118, 23);
            this.roomtypeLabel.TabIndex = 3;
            this.roomtypeLabel.Text = "Room Type :";
            // 
            // bedLabel
            // 
            this.bedLabel.AutoSize = true;
            this.bedLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedLabel.Location = new System.Drawing.Point(96, 423);
            this.bedLabel.Name = "bedLabel";
            this.bedLabel.Size = new System.Drawing.Size(55, 23);
            this.bedLabel.TabIndex = 4;
            this.bedLabel.Text = "Bed :";
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelabel.Location = new System.Drawing.Point(329, 317);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(66, 23);
            this.pricelabel.TabIndex = 5;
            this.pricelabel.Text = "Price :";
            // 
            // bookedLabel
            // 
            this.bookedLabel.AutoSize = true;
            this.bookedLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookedLabel.Location = new System.Drawing.Point(309, 367);
            this.bookedLabel.Name = "bookedLabel";
            this.bookedLabel.Size = new System.Drawing.Size(86, 23);
            this.bookedLabel.TabIndex = 6;
            this.bookedLabel.Text = "Booked :";
            // 
            // addroomButton
            // 
            this.addroomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addroomButton.BackColor = System.Drawing.Color.LimeGreen;
            this.addroomButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addroomButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addroomButton.Location = new System.Drawing.Point(613, 432);
            this.addroomButton.Name = "addroomButton";
            this.addroomButton.Size = new System.Drawing.Size(135, 40);
            this.addroomButton.TabIndex = 13;
            this.addroomButton.Text = "ADD ROOM";
            this.addroomButton.UseVisualStyleBackColor = false;
            this.addroomButton.Click += new System.EventHandler(this.addroomButton_Click);
            // 
            // roomnoTextBox
            // 
            this.roomnoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roomnoTextBox.BackColor = System.Drawing.Color.White;
            this.roomnoTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomnoTextBox.Location = new System.Drawing.Point(157, 313);
            this.roomnoTextBox.Name = "roomnoTextBox";
            this.roomnoTextBox.Size = new System.Drawing.Size(107, 32);
            this.roomnoTextBox.TabIndex = 14;
            // 
            // roomtypeComboBox
            // 
            this.roomtypeComboBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomtypeComboBox.FormattingEnabled = true;
            this.roomtypeComboBox.Items.AddRange(new object[] {
            "Ac",
            "NonAc"});
            this.roomtypeComboBox.Location = new System.Drawing.Point(157, 367);
            this.roomtypeComboBox.Name = "roomtypeComboBox";
            this.roomtypeComboBox.Size = new System.Drawing.Size(107, 31);
            this.roomtypeComboBox.TabIndex = 15;
            this.roomtypeComboBox.SelectedIndexChanged += new System.EventHandler(this.roomtypeComboBox_SelectedIndexChanged);
            // 
            // bedComboBox
            // 
            this.bedComboBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedComboBox.FormattingEnabled = true;
            this.bedComboBox.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.bedComboBox.Location = new System.Drawing.Point(157, 420);
            this.bedComboBox.Name = "bedComboBox";
            this.bedComboBox.Size = new System.Drawing.Size(107, 31);
            this.bedComboBox.TabIndex = 16;
            this.bedComboBox.SelectedIndexChanged += new System.EventHandler(this.bedComboBox_SelectedIndexChanged);
            // 
            // priceComboBox
            // 
            this.priceComboBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceComboBox.FormattingEnabled = true;
            this.priceComboBox.Items.AddRange(new object[] {
            "5000",
            "4500",
            "6000",
            "5500",
            "8000",
            "7500"});
            this.priceComboBox.Location = new System.Drawing.Point(401, 314);
            this.priceComboBox.Name = "priceComboBox";
            this.priceComboBox.Size = new System.Drawing.Size(107, 31);
            this.priceComboBox.TabIndex = 31;
            // 
            // bookedComboBox
            // 
            this.bookedComboBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookedComboBox.FormattingEnabled = true;
            this.bookedComboBox.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.bookedComboBox.Location = new System.Drawing.Point(401, 367);
            this.bookedComboBox.Name = "bookedComboBox";
            this.bookedComboBox.Size = new System.Drawing.Size(107, 31);
            this.bookedComboBox.TabIndex = 32;
            // 
            // AUC_Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Controls.Add(this.bookedComboBox);
            this.Controls.Add(this.priceComboBox);
            this.Controls.Add(this.bedComboBox);
            this.Controls.Add(this.roomtypeComboBox);
            this.Controls.Add(this.roomnoTextBox);
            this.Controls.Add(this.addroomButton);
            this.Controls.Add(this.bookedLabel);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.bedLabel);
            this.Controls.Add(this.roomtypeLabel);
            this.Controls.Add(this.roomnoLabel);
            this.Controls.Add(this.addroomLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AUC_Rooms";
            this.Size = new System.Drawing.Size(803, 511);
            this.Load += new System.EventHandler(this.AUC_Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label addroomLabel;
        private System.Windows.Forms.Label roomnoLabel;
        private System.Windows.Forms.Label roomtypeLabel;
        private System.Windows.Forms.Label bedLabel;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.Label bookedLabel;
        private System.Windows.Forms.Button addroomButton;
        private System.Windows.Forms.TextBox roomnoTextBox;
        private System.Windows.Forms.ComboBox roomtypeComboBox;
        private System.Windows.Forms.ComboBox bedComboBox;
        private System.Windows.Forms.ComboBox priceComboBox;
        private System.Windows.Forms.ComboBox bookedComboBox;
    }
}
