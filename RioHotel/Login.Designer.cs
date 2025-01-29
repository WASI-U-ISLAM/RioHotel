namespace RioHotel
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.welcometoLabel = new System.Windows.Forms.Label();
            this.rhmsLabel = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.showButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.canclebutton = new System.Windows.Forms.Button();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.logintoLabel = new System.Windows.Forms.Label();
            this.hideButton = new System.Windows.Forms.Button();
            this.usernamewarnLabel = new System.Windows.Forms.Label();
            this.passwarnLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RioHotel.Properties.Resources.WP;
            this.pictureBox1.Location = new System.Drawing.Point(1, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 409);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // welcometoLabel
            // 
            this.welcometoLabel.AutoSize = true;
            this.welcometoLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcometoLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcometoLabel.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.welcometoLabel.Location = new System.Drawing.Point(12, 9);
            this.welcometoLabel.Name = "welcometoLabel";
            this.welcometoLabel.Size = new System.Drawing.Size(193, 43);
            this.welcometoLabel.TabIndex = 1;
            this.welcometoLabel.Text = "Welcome to";
            // 
            // rhmsLabel
            // 
            this.rhmsLabel.AutoSize = true;
            this.rhmsLabel.BackColor = System.Drawing.Color.Transparent;
            this.rhmsLabel.Font = new System.Drawing.Font("Times New Roman", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rhmsLabel.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.rhmsLabel.Location = new System.Drawing.Point(56, 52);
            this.rhmsLabel.Name = "rhmsLabel";
            this.rhmsLabel.Size = new System.Drawing.Size(820, 68);
            this.rhmsLabel.TabIndex = 2;
            this.rhmsLabel.Text = "Rio Hotel Management System";
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.Cornsilk;
            this.loginPanel.Controls.Add(this.passwarnLabel);
            this.loginPanel.Controls.Add(this.usernamewarnLabel);
            this.loginPanel.Controls.Add(this.showButton);
            this.loginPanel.Controls.Add(this.nextButton);
            this.loginPanel.Controls.Add(this.canclebutton);
            this.loginPanel.Controls.Add(this.passTextBox);
            this.loginPanel.Controls.Add(this.usernameTextBox);
            this.loginPanel.Controls.Add(this.passLabel);
            this.loginPanel.Controls.Add(this.usernameLabel);
            this.loginPanel.Controls.Add(this.logintoLabel);
            this.loginPanel.Controls.Add(this.hideButton);
            this.loginPanel.Location = new System.Drawing.Point(650, 155);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(391, 478);
            this.loginPanel.TabIndex = 3;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.Color.White;
            this.showButton.BackgroundImage = global::RioHotel.Properties.Resources.eye;
            this.showButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.showButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showButton.Location = new System.Drawing.Point(299, 196);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(37, 32);
            this.showButton.TabIndex = 7;
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Khaki;
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nextButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(215, 297);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(87, 33);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // canclebutton
            // 
            this.canclebutton.BackColor = System.Drawing.Color.Moccasin;
            this.canclebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.canclebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.canclebutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canclebutton.Location = new System.Drawing.Point(96, 297);
            this.canclebutton.Name = "canclebutton";
            this.canclebutton.Size = new System.Drawing.Size(92, 33);
            this.canclebutton.TabIndex = 5;
            this.canclebutton.Text = "Cancle";
            this.canclebutton.UseVisualStyleBackColor = false;
            this.canclebutton.Click += new System.EventHandler(this.canclebutton_Click);
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox.Location = new System.Drawing.Point(160, 196);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(142, 32);
            this.passTextBox.TabIndex = 4;
            this.passTextBox.UseSystemPasswordChar = true;
            this.passTextBox.TextChanged += new System.EventHandler(this.passTextBox_TextChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(160, 111);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(142, 32);
            this.usernameTextBox.TabIndex = 3;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.Color.Transparent;
            this.passLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(46, 199);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(108, 24);
            this.passLabel.TabIndex = 2;
            this.passLabel.Text = "Password :";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(42, 114);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(112, 24);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username :";
            // 
            // logintoLabel
            // 
            this.logintoLabel.AutoSize = true;
            this.logintoLabel.BackColor = System.Drawing.Color.Transparent;
            this.logintoLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logintoLabel.Location = new System.Drawing.Point(40, 43);
            this.logintoLabel.Name = "logintoLabel";
            this.logintoLabel.Size = new System.Drawing.Size(296, 31);
            this.logintoLabel.TabIndex = 0;
            this.logintoLabel.Text = "Log-In To Your Account";
            this.logintoLabel.Click += new System.EventHandler(this.logintoLabel_Click);
            // 
            // hideButton
            // 
            this.hideButton.BackColor = System.Drawing.Color.White;
            this.hideButton.BackgroundImage = global::RioHotel.Properties.Resources.hidden;
            this.hideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hideButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hideButton.ForeColor = System.Drawing.Color.Transparent;
            this.hideButton.Location = new System.Drawing.Point(299, 196);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(37, 32);
            this.hideButton.TabIndex = 8;
            this.hideButton.UseVisualStyleBackColor = false;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // usernamewarnLabel
            // 
            this.usernamewarnLabel.AutoSize = true;
            this.usernamewarnLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamewarnLabel.ForeColor = System.Drawing.Color.Red;
            this.usernamewarnLabel.Location = new System.Drawing.Point(160, 160);
            this.usernamewarnLabel.Name = "usernamewarnLabel";
            this.usernamewarnLabel.Size = new System.Drawing.Size(196, 21);
            this.usernamewarnLabel.TabIndex = 9;
            this.usernamewarnLabel.Text = "You didn\'t fill username !";
            // 
            // passwarnLabel
            // 
            this.passwarnLabel.AutoSize = true;
            this.passwarnLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwarnLabel.ForeColor = System.Drawing.Color.Red;
            this.passwarnLabel.Location = new System.Drawing.Point(160, 252);
            this.passwarnLabel.Name = "passwarnLabel";
            this.passwarnLabel.Size = new System.Drawing.Size(200, 21);
            this.passwarnLabel.TabIndex = 10;
            this.passwarnLabel.Text = "You didn\'t fill Password !";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RioHotel.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(1084, 628);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.rhmsLabel);
            this.Controls.Add(this.welcometoLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label welcometoLabel;
        private System.Windows.Forms.Label rhmsLabel;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label logintoLabel;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button canclebutton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Label passwarnLabel;
        private System.Windows.Forms.Label usernamewarnLabel;
    }
}