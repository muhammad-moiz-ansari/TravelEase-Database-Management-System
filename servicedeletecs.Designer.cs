namespace DB_Project
{
    partial class servicedeletecs
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
            System.Windows.Forms.Button confirm;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(servicedeletecs));
            this.label1 = new System.Windows.Forms.Label();
            this.deleteserviceid = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.PictureBox();
            confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.SuspendLayout();
            // 
            // confirm
            // 
            confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(230)))), ((int)(((byte)(160)))));
            confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            confirm.Image = ((System.Drawing.Image)(resources.GetObject("confirm.Image")));
            confirm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            confirm.Location = new System.Drawing.Point(567, 326);
            confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            confirm.Name = "confirm";
            confirm.Size = new System.Drawing.Size(156, 96);
            confirm.TabIndex = 2;
            confirm.Text = "Delete";
            confirm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            confirm.UseVisualStyleBackColor = false;
            confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(443, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Service ID to delete";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // deleteserviceid
            // 
            this.deleteserviceid.BackColor = System.Drawing.Color.White;
            this.deleteserviceid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.deleteserviceid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteserviceid.ForeColor = System.Drawing.Color.Black;
            this.deleteserviceid.Location = new System.Drawing.Point(405, 241);
            this.deleteserviceid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteserviceid.Name = "deleteserviceid";
            this.deleteserviceid.Size = new System.Drawing.Size(487, 30);
            this.deleteserviceid.TabIndex = 13;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Image = global::DB_Project.Properties.Resources.back4;
            this.backButton.Location = new System.Drawing.Point(28, 26);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 52);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backButton.TabIndex = 31;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // servicedeletecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DB_Project.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1277, 647);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteserviceid);
            this.Controls.Add(confirm);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "servicedeletecs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Service";
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deleteserviceid;
        private System.Windows.Forms.PictureBox backButton;
    }
}