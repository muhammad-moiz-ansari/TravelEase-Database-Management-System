namespace DB_Project
{
    partial class welcome_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome_window));
            this.logo_main = new System.Windows.Forms.PictureBox();
            this.tagline = new System.Windows.Forms.Label();
            this.signup_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.copyright_label = new System.Windows.Forms.Label();
            this.login_abovetext = new System.Windows.Forms.Label();
            this.signup_abovetext = new System.Windows.Forms.Label();
            this.message1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.generateReportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo_main)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo_main
            // 
            this.logo_main.BackColor = System.Drawing.Color.Transparent;
            this.logo_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo_main.Image = global::DB_Project.Properties.Resources.logo5;
            this.logo_main.Location = new System.Drawing.Point(3, 12);
            this.logo_main.Name = "logo_main";
            this.logo_main.Size = new System.Drawing.Size(1267, 222);
            this.logo_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_main.TabIndex = 0;
            this.logo_main.TabStop = false;
            // 
            // tagline
            // 
            this.tagline.AutoSize = true;
            this.tagline.BackColor = System.Drawing.Color.Transparent;
            this.tagline.Font = new System.Drawing.Font("Candara Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tagline.Location = new System.Drawing.Point(400, 294);
            this.tagline.Name = "tagline";
            this.tagline.Size = new System.Drawing.Size(478, 37);
            this.tagline.TabIndex = 1;
            this.tagline.Text = "Your Journey, Seamlessly Connected";
            // 
            // signup_button
            // 
            this.signup_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(230)))), ((int)(((byte)(160)))));
            this.signup_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_button.Location = new System.Drawing.Point(346, 468);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(130, 40);
            this.signup_button.TabIndex = 2;
            this.signup_button.Text = "Sign Up";
            this.signup_button.UseVisualStyleBackColor = false;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(806, 468);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(130, 40);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Log In";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.generateReportButton);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.copyright_label);
            this.panel1.Controls.Add(this.login_abovetext);
            this.panel1.Controls.Add(this.signup_abovetext);
            this.panel1.Controls.Add(this.message1);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.logo_main);
            this.panel1.Controls.Add(this.signup_button);
            this.panel1.Controls.Add(this.tagline);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 646);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkLabel2.Location = new System.Drawing.Point(836, 577);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(0, 45);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.Visible = false;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // copyright_label
            // 
            this.copyright_label.AutoSize = true;
            this.copyright_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.copyright_label.Location = new System.Drawing.Point(974, 614);
            this.copyright_label.Name = "copyright_label";
            this.copyright_label.Size = new System.Drawing.Size(292, 19);
            this.copyright_label.TabIndex = 7;
            this.copyright_label.Text = "© 2025 TravelEase Travel Hub • Contact Us";
            // 
            // login_abovetext
            // 
            this.login_abovetext.AutoSize = true;
            this.login_abovetext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_abovetext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.login_abovetext.Location = new System.Drawing.Point(694, 432);
            this.login_abovetext.Name = "login_abovetext";
            this.login_abovetext.Size = new System.Drawing.Size(382, 19);
            this.login_abovetext.TabIndex = 6;
            this.login_abovetext.Text = "Already a Member? Log In to Access Your Trips and More!";
            // 
            // signup_abovetext
            // 
            this.signup_abovetext.AutoSize = true;
            this.signup_abovetext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_abovetext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.signup_abovetext.Location = new System.Drawing.Point(201, 432);
            this.signup_abovetext.Name = "signup_abovetext";
            this.signup_abovetext.Size = new System.Drawing.Size(454, 19);
            this.signup_abovetext.TabIndex = 5;
            this.signup_abovetext.Text = "New to TravelEase? Sign Up to Start Exploring Amazing Destinations!";
            // 
            // message1
            // 
            this.message1.AutoSize = true;
            this.message1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.message1.Location = new System.Drawing.Point(418, 353);
            this.message1.Name = "message1";
            this.message1.Size = new System.Drawing.Size(441, 23);
            this.message1.TabIndex = 4;
            this.message1.Text = "Discover, Book, and Manage Your Perfect Trip with Ease!";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(272, 577);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 45);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // generateReportButton
            // 
            this.generateReportButton.AutoSize = true;
            this.generateReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(230)))), ((int)(((byte)(160)))));
            this.generateReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateReportButton.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold);
            this.generateReportButton.ForeColor = System.Drawing.Color.Black;
            this.generateReportButton.Location = new System.Drawing.Point(578, 567);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(150, 30);
            this.generateReportButton.TabIndex = 10;
            this.generateReportButton.Text = "Generate Reports";
            this.generateReportButton.UseVisualStyleBackColor = false;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // welcome_window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::DB_Project.Properties.Resources.airplane3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1279, 656);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "welcome_window";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.welcome_window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_main)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_main;
        private System.Windows.Forms.Label tagline;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label login_abovetext;
        private System.Windows.Forms.Label signup_abovetext;
        private System.Windows.Forms.Label message1;
        private System.Windows.Forms.Label copyright_label;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button generateReportButton;
    }
}

