namespace RioHotel.Admin_Control
{
    partial class AC_Rooms
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
            this.bookedComboBox = new System.Windows.Forms.ComboBox();
            this.priceComboBox = new System.Windows.Forms.ComboBox();
            this.bedComboBox = new System.Windows.Forms.ComboBox();
            this.roomtypeComboBox = new System.Windows.Forms.ComboBox();
            this.roomnoTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.bookedLabel = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.bedLabel = new System.Windows.Forms.Label();
            this.roomtypeLabel = new System.Windows.Forms.Label();
            this.roomnoLabel = new System.Windows.Forms.Label();
            this.addroomLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookedComboBox
            // 
            this.bookedComboBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookedComboBox.FormattingEnabled = true;
            this.bookedComboBox.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.bookedComboBox.Location = new System.Drawing.Point(404, 370);
            this.bookedComboBox.Name = "bookedComboBox";
            this.bookedComboBox.Size = new System.Drawing.Size(107, 31);
            this.bookedComboBox.TabIndex = 31;
            //this.bookedComboBox.SelectedIndexChanged += new System.EventHandler(this.bookedComboBox_SelectedIndexChanged);
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
            this.priceComboBox.Location = new System.Drawing.Point(404, 320);
            this.priceComboBox.Name = "priceComboBox";
            this.priceComboBox.Size = new System.Drawing.Size(107, 31);
            this.priceComboBox.TabIndex = 30;
            //this.priceComboBox.SelectedIndexChanged += new System.EventHandler(this.priceComboBox_SelectedIndexChanged);
            // 
            // bedComboBox
            // 
            this.bedComboBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedComboBox.FormattingEnabled = true;
            this.bedComboBox.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.bedComboBox.Location = new System.Drawing.Point(160, 454);
            this.bedComboBox.Name = "bedComboBox";
            this.bedComboBox.Size = new System.Drawing.Size(107, 31);
            this.bedComboBox.TabIndex = 29;
            this.bedComboBox.SelectedIndexChanged += new System.EventHandler(this.bedComboBox_SelectedIndexChanged);
            // 
            // roomtypeComboBox
            // 
            this.roomtypeComboBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomtypeComboBox.FormattingEnabled = true;
            this.roomtypeComboBox.Items.AddRange(new object[] {
            "Ac",
            "NonAc"});
            this.roomtypeComboBox.Location = new System.Drawing.Point(160, 401);
            this.roomtypeComboBox.Name = "roomtypeComboBox";
            this.roomtypeComboBox.Size = new System.Drawing.Size(107, 31);
            this.roomtypeComboBox.TabIndex = 28;
            this.roomtypeComboBox.SelectedIndexChanged += new System.EventHandler(this.roomtypeComboBox_SelectedIndexChanged);
            // 
            // roomnoTextBox
            // 
            this.roomnoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roomnoTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomnoTextBox.Location = new System.Drawing.Point(160, 347);
            this.roomnoTextBox.Name = "roomnoTextBox";
            this.roomnoTextBox.Size = new System.Drawing.Size(107, 32);
            this.roomnoTextBox.TabIndex = 27;
            //this.roomnoTextBox.TextChanged += new System.EventHandler(this.roomnoTextBox_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.Color.LimeGreen;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(634, 448);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 39);
            this.addButton.TabIndex = 26;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // bookedLabel
            // 
            this.bookedLabel.AutoSize = true;
            this.bookedLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookedLabel.Location = new System.Drawing.Point(312, 373);
            this.bookedLabel.Name = "bookedLabel";
            this.bookedLabel.Size = new System.Drawing.Size(86, 23);
            this.bookedLabel.TabIndex = 25;
            this.bookedLabel.Text = "Booked :";
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelabel.Location = new System.Drawing.Point(332, 323);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(66, 23);
            this.pricelabel.TabIndex = 24;
            this.pricelabel.Text = "Price :";
            // 
            // bedLabel
            // 
            this.bedLabel.AutoSize = true;
            this.bedLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedLabel.Location = new System.Drawing.Point(99, 457);
            this.bedLabel.Name = "bedLabel";
            this.bedLabel.Size = new System.Drawing.Size(55, 23);
            this.bedLabel.TabIndex = 23;
            this.bedLabel.Text = "Bed :";
            // 
            // roomtypeLabel
            // 
            this.roomtypeLabel.AutoSize = true;
            this.roomtypeLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomtypeLabel.Location = new System.Drawing.Point(36, 401);
            this.roomtypeLabel.Name = "roomtypeLabel";
            this.roomtypeLabel.Size = new System.Drawing.Size(118, 23);
            this.roomtypeLabel.TabIndex = 22;
            this.roomtypeLabel.Text = "Room Type :";
            // 
            // roomnoLabel
            // 
            this.roomnoLabel.AutoSize = true;
            this.roomnoLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomnoLabel.Location = new System.Drawing.Point(48, 351);
            this.roomnoLabel.Name = "roomnoLabel";
            this.roomnoLabel.Size = new System.Drawing.Size(106, 23);
            this.roomnoLabel.TabIndex = 21;
            this.roomnoLabel.Text = "Room NO :";
            // 
            // addroomLabel
            // 
            this.addroomLabel.AutoSize = true;
            this.addroomLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addroomLabel.Location = new System.Drawing.Point(302, 17);
            this.addroomLabel.Name = "addroomLabel";
            this.addroomLabel.Size = new System.Drawing.Size(167, 31);
            this.addroomLabel.TabIndex = 20;
            this.addroomLabel.Text = "ADD ROOM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(685, 218);
            this.dataGridView1.TabIndex = 19;
            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackColor = System.Drawing.Color.OrangeRed;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(535, 448);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(85, 39);
            this.deleteButton.TabIndex = 34;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackColor = System.Drawing.Color.Orange;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(429, 448);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(91, 39);
            this.searchButton.TabIndex = 33;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.BackColor = System.Drawing.Color.SteelBlue;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(330, 448);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(83, 39);
            this.updateButton.TabIndex = 32;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(99, 305);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(43, 23);
            this.idLabel.TabIndex = 35;
            this.idLabel.Text = "ID :";
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(160, 300);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(72, 32);
            this.idTextBox.TabIndex = 36;
            //this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // AC_Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.bookedComboBox);
            this.Controls.Add(this.priceComboBox);
            this.Controls.Add(this.bedComboBox);
            this.Controls.Add(this.roomtypeComboBox);
            this.Controls.Add(this.roomnoTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.bookedLabel);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.bedLabel);
            this.Controls.Add(this.roomtypeLabel);
            this.Controls.Add(this.roomnoLabel);
            this.Controls.Add(this.addroomLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AC_Rooms";
            this.Size = new System.Drawing.Size(803, 511);
            this.Load += new System.EventHandler(this.AC_Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bookedComboBox;
        private System.Windows.Forms.ComboBox priceComboBox;
        private System.Windows.Forms.ComboBox bedComboBox;
        private System.Windows.Forms.ComboBox roomtypeComboBox;
        private System.Windows.Forms.TextBox roomnoTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label bookedLabel;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.Label bedLabel;
        private System.Windows.Forms.Label roomtypeLabel;
        private System.Windows.Forms.Label roomnoLabel;
        private System.Windows.Forms.Label addroomLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
    }
}
