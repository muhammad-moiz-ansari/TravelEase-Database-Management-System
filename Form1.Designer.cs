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
            ((System.ComponentModel.ISupportInitialize)(this.logo_main)).BeginInit();
            this.SuspendLayout();
            // 
            // logo_main
            // 
            this.logo_main.BackColor = System.Drawing.Color.Transparent;
            this.logo_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo_main.Image = global::DB_Project.Properties.Resources.logo5;
            this.logo_main.Location = new System.Drawing.Point(297, 26);
            this.logo_main.Name = "logo_main";
            this.logo_main.Size = new System.Drawing.Size(306, 194);
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
            this.tagline.Location = new System.Drawing.Point(112, 233);
            this.tagline.Name = "tagline";
            this.tagline.Size = new System.Drawing.Size(698, 54);
            this.tagline.TabIndex = 1;
            this.tagline.Text = "Your Journey, Seamlessly Connected";
            // 
            // signup_button
            // 
            this.signup_button.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_button.Location = new System.Drawing.Point(258, 320);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(128, 61);
            this.signup_button.TabIndex = 2;
            this.signup_button.Text = "Sign Up";
            this.signup_button.UseVisualStyleBackColor = true;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // welcome_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DB_Project.Properties.Resources.airplane3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 492);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.tagline);
            this.Controls.Add(this.logo_main);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "welcome_window";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.logo_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_main;
        private System.Windows.Forms.Label tagline;
        private System.Windows.Forms.Button signup_button;
    }
}

