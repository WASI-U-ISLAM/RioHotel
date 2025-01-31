﻿namespace RioHotel
{
    partial class Admin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usersButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.aC_Users1 = new RioHotel.Admin_Control.AC_Users();
            this.guestsbutton = new System.Windows.Forms.Button();
            this.bookingButton = new System.Windows.Forms.Button();
            this.roomsButton = new System.Windows.Forms.Button();
            this.movePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.label6.Location = new System.Drawing.Point(69, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "ADMIN PAGE";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::RioHotel.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(13, 40);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 59);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RioHotel.Properties.Resources.login_5087607;
            this.pictureBox1.Location = new System.Drawing.Point(105, 245);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 138);
            this.panel1.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.maximizeButton);
            this.panel4.Controls.Add(this.closeButton);
            this.panel4.Controls.Add(this.minimizeButton);
            this.panel4.Location = new System.Drawing.Point(953, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(138, 54);
            this.panel4.TabIndex = 18;
            // 
            // maximizeButton
            // 
            this.maximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.ForeColor = System.Drawing.Color.Transparent;
            this.maximizeButton.Image = global::RioHotel.Properties.Resources.maximize2;
            this.maximizeButton.Location = new System.Drawing.Point(61, -2);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(36, 38);
            this.maximizeButton.TabIndex = 7;
            this.maximizeButton.UseVisualStyleBackColor = false;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = global::RioHotel.Properties.Resources.close2;
            this.closeButton.Location = new System.Drawing.Point(100, -2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(36, 38);
            this.closeButton.TabIndex = 5;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Image = global::RioHotel.Properties.Resources.minimize2;
            this.minimizeButton.Location = new System.Drawing.Point(22, -2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(37, 38);
            this.minimizeButton.TabIndex = 6;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.movePanel);
            this.panel2.Controls.Add(this.guestsbutton);
            this.panel2.Controls.Add(this.bookingButton);
            this.panel2.Controls.Add(this.roomsButton);
            this.panel2.Controls.Add(this.logoutButton);
            this.panel2.Controls.Add(this.usersButton);
            this.panel2.Location = new System.Drawing.Point(-2, 142);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 464);
            this.panel2.TabIndex = 16;
            // 
            // usersButton
            // 
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.usersButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.usersButton.Image = global::RioHotel.Properties.Resources.BG;
            this.usersButton.Location = new System.Drawing.Point(65, 15);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(182, 54);
            this.usersButton.TabIndex = 17;
            this.usersButton.Text = "Users\r\n";
            this.usersButton.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.logoutButton.Image = global::RioHotel.Properties.Resources.BG;
            this.logoutButton.Location = new System.Drawing.Point(65, 334);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(182, 60);
            this.logoutButton.TabIndex = 18;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // aC_Users1
            // 
            this.aC_Users1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aC_Users1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.aC_Users1.Location = new System.Drawing.Point(275, 142);
            this.aC_Users1.Name = "aC_Users1";
            this.aC_Users1.Size = new System.Drawing.Size(803, 511);
            this.aC_Users1.TabIndex = 17;
            // 
            // guestsbutton
            // 
            this.guestsbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guestsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guestsbutton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestsbutton.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.guestsbutton.Image = global::RioHotel.Properties.Resources.BG;
            this.guestsbutton.Location = new System.Drawing.Point(65, 218);
            this.guestsbutton.Name = "guestsbutton";
            this.guestsbutton.Size = new System.Drawing.Size(182, 52);
            this.guestsbutton.TabIndex = 21;
            this.guestsbutton.Text = "Guests";
            this.guestsbutton.UseVisualStyleBackColor = true;
            // 
            // bookingButton
            // 
            this.bookingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bookingButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingButton.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.bookingButton.Image = global::RioHotel.Properties.Resources.BG;
            this.bookingButton.Location = new System.Drawing.Point(65, 152);
            this.bookingButton.Name = "bookingButton";
            this.bookingButton.Size = new System.Drawing.Size(182, 52);
            this.bookingButton.TabIndex = 20;
            this.bookingButton.Text = "Booking";
            this.bookingButton.UseVisualStyleBackColor = true;
            // 
            // roomsButton
            // 
            this.roomsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roomsButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsButton.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.roomsButton.Image = global::RioHotel.Properties.Resources.BG;
            this.roomsButton.Location = new System.Drawing.Point(65, 85);
            this.roomsButton.Name = "roomsButton";
            this.roomsButton.Size = new System.Drawing.Size(182, 52);
            this.roomsButton.TabIndex = 19;
            this.roomsButton.Text = "Rooms";
            this.roomsButton.UseVisualStyleBackColor = true;
            // 
            // movePanel
            // 
            this.movePanel.BackgroundImage = global::RioHotel.Properties.Resources.BG;
            this.movePanel.Location = new System.Drawing.Point(251, 13);
            this.movePanel.Name = "movePanel";
            this.movePanel.Size = new System.Drawing.Size(14, 58);
            this.movePanel.TabIndex = 22;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RioHotel.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(1090, 666);
            this.Controls.Add(this.aC_Users1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button usersButton;
        private Admin_Control.AC_Users aC_Users1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button guestsbutton;
        private System.Windows.Forms.Button bookingButton;
        private System.Windows.Forms.Button roomsButton;
        private System.Windows.Forms.Panel movePanel;
    }
}