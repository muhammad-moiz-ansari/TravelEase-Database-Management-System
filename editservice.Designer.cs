namespace DB_Project
{
    partial class editservice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editservice));
            this.backButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtVehicleNumber = new System.Windows.Forms.TextBox();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.gbTransportFields = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHotelLocation = new System.Windows.Forms.TextBox();
            this.txtRooms = new System.Windows.Forms.TextBox();
            this.gbHotelFields = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtResourceName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbResourceType = new System.Windows.Forms.ComboBox();
            this.cbServiceType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dpActualTime = new System.Windows.Forms.DateTimePicker();
            this.dpEstimatedTime = new System.Windows.Forms.DateTimePicker();
            this.txtresourcesid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbTransportFields.SuspendLayout();
            this.gbHotelFields.SuspendLayout();
            this.SuspendLayout();
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
            this.backButton.TabIndex = 45;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(442, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 64);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // txtVehicleNumber
            // 
            this.txtVehicleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtVehicleNumber.Location = new System.Drawing.Point(175, 33);
            this.txtVehicleNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVehicleNumber.Name = "txtVehicleNumber";
            this.txtVehicleNumber.Size = new System.Drawing.Size(257, 30);
            this.txtVehicleNumber.TabIndex = 16;
            // 
            // txtSeats
            // 
            this.txtSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSeats.Location = new System.Drawing.Point(176, 76);
            this.txtSeats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(256, 30);
            this.txtSeats.TabIndex = 13;
            // 
            // gbTransportFields
            // 
            this.gbTransportFields.Controls.Add(this.dpActualTime);
            this.gbTransportFields.Controls.Add(this.dpEstimatedTime);
            this.gbTransportFields.Controls.Add(this.txtVehicleNumber);
            this.gbTransportFields.Controls.Add(this.txtSeats);
            this.gbTransportFields.Controls.Add(this.label8);
            this.gbTransportFields.Controls.Add(this.label9);
            this.gbTransportFields.Controls.Add(this.label10);
            this.gbTransportFields.Controls.Add(this.label11);
            this.gbTransportFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTransportFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbTransportFields.Location = new System.Drawing.Point(412, 286);
            this.gbTransportFields.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTransportFields.Name = "gbTransportFields";
            this.gbTransportFields.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTransportFields.Size = new System.Drawing.Size(448, 213);
            this.gbTransportFields.TabIndex = 42;
            this.gbTransportFields.TabStop = false;
            this.gbTransportFields.Text = "Transport Info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(4, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Vehicle #: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(4, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Seats:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(4, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Est. Leave: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(4, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "Act. Leave:";
            // 
            // txtHotelLocation
            // 
            this.txtHotelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHotelLocation.Location = new System.Drawing.Point(181, 76);
            this.txtHotelLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHotelLocation.Name = "txtHotelLocation";
            this.txtHotelLocation.Size = new System.Drawing.Size(251, 30);
            this.txtHotelLocation.TabIndex = 10;
            // 
            // txtRooms
            // 
            this.txtRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRooms.Location = new System.Drawing.Point(181, 33);
            this.txtRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRooms.Name = "txtRooms";
            this.txtRooms.Size = new System.Drawing.Size(251, 30);
            this.txtRooms.TabIndex = 9;
            // 
            // gbHotelFields
            // 
            this.gbHotelFields.Controls.Add(this.txtHotelLocation);
            this.gbHotelFields.Controls.Add(this.txtRooms);
            this.gbHotelFields.Controls.Add(this.label6);
            this.gbHotelFields.Controls.Add(this.label7);
            this.gbHotelFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbHotelFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbHotelFields.Location = new System.Drawing.Point(412, 286);
            this.gbHotelFields.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbHotelFields.Name = "gbHotelFields";
            this.gbHotelFields.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbHotelFields.Size = new System.Drawing.Size(448, 127);
            this.gbHotelFields.TabIndex = 41;
            this.gbHotelFields.TabStop = false;
            this.gbHotelFields.Text = "Hotel Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(4, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "No. of Rooms:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(5, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Location: ";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrice.Location = new System.Drawing.Point(593, 250);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(251, 30);
            this.txtPrice.TabIndex = 40;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(230)))), ((int)(((byte)(160)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsave.Location = new System.Drawing.Point(593, 521);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(116, 94);
            this.btnsave.TabIndex = 43;
            this.btnsave.Text = "Save";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtResourceName
            // 
            this.txtResourceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtResourceName.Location = new System.Drawing.Point(596, 207);
            this.txtResourceName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResourceName.Name = "txtResourceName";
            this.txtResourceName.Size = new System.Drawing.Size(248, 30);
            this.txtResourceName.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(416, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Price:";
            // 
            // cbResourceType
            // 
            this.cbResourceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbResourceType.FormattingEnabled = true;
            this.cbResourceType.Items.AddRange(new object[] {
            "Room",
            "Guide",
            "Van"});
            this.cbResourceType.Location = new System.Drawing.Point(595, 164);
            this.cbResourceType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbResourceType.Name = "cbResourceType";
            this.cbResourceType.Size = new System.Drawing.Size(249, 33);
            this.cbResourceType.TabIndex = 37;
            this.cbResourceType.Text = "Select";
            this.cbResourceType.SelectedIndexChanged += new System.EventHandler(this.cbResourceType_SelectedIndexChanged);
            // 
            // cbServiceType
            // 
            this.cbServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbServiceType.FormattingEnabled = true;
            this.cbServiceType.Items.AddRange(new object[] {
            "Hotel",
            "Transport"});
            this.cbServiceType.Location = new System.Drawing.Point(595, 121);
            this.cbServiceType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbServiceType.Name = "cbServiceType";
            this.cbServiceType.Size = new System.Drawing.Size(249, 33);
            this.cbServiceType.TabIndex = 36;
            this.cbServiceType.Text = "Select";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(416, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Name/Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(416, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Resource Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(416, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Service Type: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(565, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 32;
            this.label1.Text = "Edit Service   ";
            // 
            // dpActualTime
            // 
            this.dpActualTime.Location = new System.Drawing.Point(140, 161);
            this.dpActualTime.Name = "dpActualTime";
            this.dpActualTime.Size = new System.Drawing.Size(314, 30);
            this.dpActualTime.TabIndex = 40;
            // 
            // dpEstimatedTime
            // 
            this.dpEstimatedTime.Location = new System.Drawing.Point(139, 119);
            this.dpEstimatedTime.Name = "dpEstimatedTime";
            this.dpEstimatedTime.Size = new System.Drawing.Size(309, 30);
            this.dpEstimatedTime.TabIndex = 41;
            // 
            // txtresourcesid
            // 
            this.txtresourcesid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresourcesid.Location = new System.Drawing.Point(595, 79);
            this.txtresourcesid.Name = "txtresourcesid";
            this.txtresourcesid.Size = new System.Drawing.Size(248, 30);
            this.txtresourcesid.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(418, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 25);
            this.label12.TabIndex = 46;
            this.label12.Text = "Service ID: ";
            // 
            // editservice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DB_Project.Properties.Resources.bg5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1277, 647);
            this.Controls.Add(this.txtresourcesid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbTransportFields);
            this.Controls.Add(this.gbHotelFields);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtResourceName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbResourceType);
            this.Controls.Add(this.cbServiceType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "editservice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Service";
            this.Load += new System.EventHandler(this.editservice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbTransportFields.ResumeLayout(false);
            this.gbTransportFields.PerformLayout();
            this.gbHotelFields.ResumeLayout(false);
            this.gbHotelFields.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtVehicleNumber;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.GroupBox gbTransportFields;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHotelLocation;
        private System.Windows.Forms.TextBox txtRooms;
        private System.Windows.Forms.GroupBox gbHotelFields;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtResourceName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbResourceType;
        private System.Windows.Forms.ComboBox cbServiceType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpActualTime;
        private System.Windows.Forms.DateTimePicker dpEstimatedTime;
        private System.Windows.Forms.TextBox txtresourcesid;
        private System.Windows.Forms.Label label12;
    }
}