namespace DB_Project
{
    partial class BookingManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingManagementForm));
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfirmbooking = new System.Windows.Forms.Button();
            this.btnMarkPaid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooking
            // 
            this.dgvBooking.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBooking.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Location = new System.Drawing.Point(35, 111);
            this.dgvBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.RowHeadersWidth = 51;
            this.dgvBooking.RowTemplate.Height = 24;
            this.dgvBooking.Size = new System.Drawing.Size(876, 414);
            this.dgvBooking.TabIndex = 27;
            this.dgvBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooking_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 24;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(453, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(309, 32);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Booking Management";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Image = global::DB_Project.Properties.Resources.back4;
            this.backButton.Location = new System.Drawing.Point(28, 26);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 52);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backButton.TabIndex = 28;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(315, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 55);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnConfirmbooking
            // 
            this.btnConfirmbooking.AutoSize = true;
            this.btnConfirmbooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(230)))), ((int)(((byte)(160)))));
            this.btnConfirmbooking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmbooking.BackgroundImage")));
            this.btnConfirmbooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfirmbooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmbooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmbooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnConfirmbooking.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmbooking.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmbooking.Location = new System.Drawing.Point(991, 165);
            this.btnConfirmbooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmbooking.Name = "btnConfirmbooking";
            this.btnConfirmbooking.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnConfirmbooking.Size = new System.Drawing.Size(207, 117);
            this.btnConfirmbooking.TabIndex = 23;
            this.btnConfirmbooking.Text = "Confirm Booking";
            this.btnConfirmbooking.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirmbooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmbooking.UseVisualStyleBackColor = false;
            this.btnConfirmbooking.Click += new System.EventHandler(this.btnConfirmbooking_Click);
            // 
            // btnMarkPaid
            // 
            this.btnMarkPaid.AutoSize = true;
            this.btnMarkPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(230)))), ((int)(((byte)(160)))));
            this.btnMarkPaid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMarkPaid.BackgroundImage")));
            this.btnMarkPaid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMarkPaid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnMarkPaid.ForeColor = System.Drawing.Color.Black;
            this.btnMarkPaid.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMarkPaid.Location = new System.Drawing.Point(991, 353);
            this.btnMarkPaid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMarkPaid.Name = "btnMarkPaid";
            this.btnMarkPaid.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnMarkPaid.Size = new System.Drawing.Size(207, 117);
            this.btnMarkPaid.TabIndex = 21;
            this.btnMarkPaid.Text = "Mark as Paid";
            this.btnMarkPaid.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMarkPaid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMarkPaid.UseVisualStyleBackColor = false;
            this.btnMarkPaid.Click += new System.EventHandler(this.btnMarkPaid_Click);
            // 
            // BookingManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DB_Project.Properties.Resources.bg41;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1277, 647);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dgvBooking);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirmbooking);
            this.Controls.Add(this.btnMarkPaid);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BookingManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingManagementForm";
            this.Load += new System.EventHandler(this.BookingManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmbooking;
        private System.Windows.Forms.Button btnMarkPaid;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox backButton;
    }
}