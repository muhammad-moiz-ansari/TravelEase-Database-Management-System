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
            ((System.ComponentModel.ISupportInitialize)(this.logo_main)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo_main
            // 
            this.logo_main.BackColor = System.Drawing.Color.Transparent;
            this.logo_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo_main.Image = global::DB_Project.Properties.Resources.logo5;
            this.logo_main.Location = new System.Drawing.Point(0, 0);
            this.logo_main.Name = "logo_main";
            this.logo_main.Size = new System.Drawing.Size(693, 194);
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
            this.tagline.Location = new System.Drawing.Point(1, 219);
            this.tagline.Name = "tagline";
            this.tagline.Size = new System.Drawing.Size(698, 54);
            this.tagline.TabIndex = 1;
            this.tagline.Text = "Your Journey, Seamlessly Connected";
            // 
            // signup_button
            // 
            this.signup_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(230)))), ((int)(((byte)(160)))));
            this.signup_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_button.Location = new System.Drawing.Point(161, 296);
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
            this.login_button.Location = new System.Drawing.Point(404, 296);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(130, 40);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Log In";
            this.login_button.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.logo_main);
            this.panel1.Controls.Add(this.signup_button);
            this.panel1.Controls.Add(this.tagline);
            this.panel1.Location = new System.Drawing.Point(98, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 403);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // welcome_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::DB_Project.Properties.Resources.airplane3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 492);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "welcome_window";
            this.Text = "Welcome";
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
    }
}

