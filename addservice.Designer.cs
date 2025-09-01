namespace DB_Project
{
    partial class addservice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addservice));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbServiceType = new System.Windows.Forms.ComboBox();
            this.cbResourceType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtResourceName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.gbHotelFields = new System.Windows.Forms.GroupBox();
            this.txtHotelLocation = new System.Windows.Forms.TextBox();
            this.txtRooms = new System.Windows.Forms.TextBox();
            this.gbTransportFields = new System.Windows.Forms.GroupBox();
            this.cbTransportType = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dpActualTime = new System.Windows.Forms.DateTimePicker();
            this.dpEstimatedTime = new System.Windows.Forms.DateTimePicker();
            this.txtVehicleNumber = new System.Windows.Forms.TextBox();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.textOperatorid = new System.Windows.Forms.TextBox();
            this.lbloperaoterid = new System.Windows.Forms.Label();
            this.dgvOperators = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.gbHotelFields.SuspendLayout();
            this.gbTransportFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperators)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(541, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Service   ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(401, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Service Type: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(401, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resource Type:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(401, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name/Number:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbServiceType
            // 
            this.cbServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbServiceType.FormattingEnabled = true;
            this.cbServiceType.Items.AddRange(new object[] {
            "Hotel",
            "Transport"});
            this.cbServiceType.Location = new System.Drawing.Point(535, 100);
            this.cbServiceType.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbServiceType.Name = "cbServiceType";
            this.cbServiceType.Size = new System.Drawing.Size(188, 28);
            this.cbServiceType.TabIndex = 4;
            this.cbServiceType.Text = "Select";
            this.cbServiceType.SelectedIndexChanged += new System.EventHandler(this.cbServiceType_SelectedIndexChanged);
            // 
            // cbResourceType
            // 
            this.cbResourceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbResourceType.FormattingEnabled = true;
            this.cbResourceType.Items.AddRange(new object[] {
            "Room",
            "Guide",
            "Van"});
            this.cbResourceType.Location = new System.Drawing.Point(535, 135);
            this.cbResourceType.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbResourceType.Name = "cbResourceType";
            this.cbResourceType.Size = new System.Drawing.Size(188, 28);
            this.cbResourceType.TabIndex = 5;
            this.cbResourceType.Text = "Select";
            this.cbResourceType.SelectedIndexChanged += new System.EventHandler(this.cbResourceType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(401, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(3, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "No. of Rooms:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(4, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Location: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(3, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Vehicle #: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(3, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Seats:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(3, 129);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Est. Leave: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(3, 163);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Act. Leave:";
            // 
            // txtResourceName
            // 
            this.txtResourceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtResourceName.Location = new System.Drawing.Point(536, 170);
            this.txtResourceName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtResourceName.Name = "txtResourceName";
            this.txtResourceName.Size = new System.Drawing.Size(187, 26);
            this.txtResourceName.TabIndex = 13;
            this.txtResourceName.TextChanged += new System.EventHandler(this.txtResourceName_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrice.Location = new System.Drawing.Point(534, 205);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(189, 26);
            this.txtPrice.TabIndex = 14;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // gbHotelFields
            // 
            this.gbHotelFields.Controls.Add(this.txtHotelLocation);
            this.gbHotelFields.Controls.Add(this.txtRooms);
            this.gbHotelFields.Controls.Add(this.label6);
            this.gbHotelFields.Controls.Add(this.label7);
            this.gbHotelFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbHotelFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbHotelFields.Location = new System.Drawing.Point(398, 234);
            this.gbHotelFields.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbHotelFields.Name = "gbHotelFields";
            this.gbHotelFields.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbHotelFields.Size = new System.Drawing.Size(336, 103);
            this.gbHotelFields.TabIndex = 15;
            this.gbHotelFields.TabStop = false;
            this.gbHotelFields.Text = "Hotel Info";
            this.gbHotelFields.Enter += new System.EventHandler(this.gbHotelFields_Enter);
            // 
            // txtHotelLocation
            // 
            this.txtHotelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHotelLocation.Location = new System.Drawing.Point(136, 62);
            this.txtHotelLocation.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtHotelLocation.Name = "txtHotelLocation";
            this.txtHotelLocation.Size = new System.Drawing.Size(189, 26);
            this.txtHotelLocation.TabIndex = 10;
            this.txtHotelLocation.TextChanged += new System.EventHandler(this.txtHotelLocation_TextChanged);
            // 
            // txtRooms
            // 
            this.txtRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRooms.Location = new System.Drawing.Point(136, 27);
            this.txtRooms.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtRooms.Name = "txtRooms";
            this.txtRooms.Size = new System.Drawing.Size(189, 26);
            this.txtRooms.TabIndex = 9;
            this.txtRooms.TextChanged += new System.EventHandler(this.txtRooms_TextChanged);
            // 
            // gbTransportFields
            // 
            this.gbTransportFields.Controls.Add(this.cbTransportType);
            this.gbTransportFields.Controls.Add(this.label13);
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
            this.gbTransportFields.Location = new System.Drawing.Point(398, 234);
            this.gbTransportFields.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbTransportFields.Name = "gbTransportFields";
            this.gbTransportFields.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbTransportFields.Size = new System.Drawing.Size(343, 197);
            this.gbTransportFields.TabIndex = 16;
            this.gbTransportFields.TabStop = false;
            this.gbTransportFields.Text = "Transport Info";
            this.gbTransportFields.Enter += new System.EventHandler(this.gbTransportFields_Enter);
            // 
            // cbTransportType
            // 
            this.cbTransportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbTransportType.Location = new System.Drawing.Point(132, 92);
            this.cbTransportType.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbTransportType.Name = "cbTransportType";
            this.cbTransportType.Size = new System.Drawing.Size(193, 26);
            this.cbTransportType.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(4, 92);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 20);
            this.label13.TabIndex = 39;
            this.label13.Text = "Transport Type:";
            // 
            // dpActualTime
            // 
            this.dpActualTime.Location = new System.Drawing.Point(89, 159);
            this.dpActualTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dpActualTime.Name = "dpActualTime";
            this.dpActualTime.Size = new System.Drawing.Size(249, 26);
            this.dpActualTime.TabIndex = 37;
            // 
            // dpEstimatedTime
            // 
            this.dpEstimatedTime.Location = new System.Drawing.Point(89, 124);
            this.dpEstimatedTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dpEstimatedTime.Name = "dpEstimatedTime";
            this.dpEstimatedTime.Size = new System.Drawing.Size(249, 26);
            this.dpEstimatedTime.TabIndex = 38;
            // 
            // txtVehicleNumber
            // 
            this.txtVehicleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtVehicleNumber.Location = new System.Drawing.Point(131, 27);
            this.txtVehicleNumber.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtVehicleNumber.Name = "txtVehicleNumber";
            this.txtVehicleNumber.Size = new System.Drawing.Size(194, 26);
            this.txtVehicleNumber.TabIndex = 16;
            this.txtVehicleNumber.TextChanged += new System.EventHandler(this.txtVehicleNumber_TextChanged);
            // 
            // txtSeats
            // 
            this.txtSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSeats.Location = new System.Drawing.Point(132, 59);
            this.txtSeats.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(193, 26);
            this.txtSeats.TabIndex = 13;
            this.txtSeats.TextChanged += new System.EventHandler(this.txtSeats_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(462, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 52);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(230)))), ((int)(((byte)(160)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsave.Location = new System.Drawing.Point(534, 436);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(87, 73);
            this.btnsave.TabIndex = 19;
            this.btnsave.Text = "Save";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Image = global::DB_Project.Properties.Resources.back4;
            this.backButton.Location = new System.Drawing.Point(21, 21);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(42, 42);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backButton.TabIndex = 31;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // textOperatorid
            // 
            this.textOperatorid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textOperatorid.Location = new System.Drawing.Point(536, 64);
            this.textOperatorid.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textOperatorid.Name = "textOperatorid";
            this.textOperatorid.Size = new System.Drawing.Size(187, 26);
            this.textOperatorid.TabIndex = 32;
            // 
            // lbloperaoterid
            // 
            this.lbloperaoterid.AutoSize = true;
            this.lbloperaoterid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbloperaoterid.Location = new System.Drawing.Point(401, 64);
            this.lbloperaoterid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbloperaoterid.Name = "lbloperaoterid";
            this.lbloperaoterid.Size = new System.Drawing.Size(88, 20);
            this.lbloperaoterid.TabIndex = 33;
            this.lbloperaoterid.Text = "Operater id";
            this.lbloperaoterid.Click += new System.EventHandler(this.label12_Click);
            // 
            // dgvOperators
            // 
            this.dgvOperators.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOperators.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvOperators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperators.Location = new System.Drawing.Point(45, 130);
            this.dgvOperators.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvOperators.Name = "dgvOperators";
            this.dgvOperators.ReadOnly = true;
            this.dgvOperators.RowHeadersWidth = 51;
            this.dgvOperators.RowTemplate.Height = 24;
            this.dgvOperators.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperators.Size = new System.Drawing.Size(282, 315);
            this.dgvOperators.TabIndex = 34;
            this.dgvOperators.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOperators_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(122, 100);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Availble Operater";
            // 
            // addservice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DB_Project.Properties.Resources.bg5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(856, 532);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvOperators);
            this.Controls.Add(this.lbloperaoterid);
            this.Controls.Add(this.textOperatorid);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.gbTransportFields);
            this.Controls.Add(this.gbHotelFields);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtResourceName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbResourceType);
            this.Controls.Add(this.cbServiceType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "addservice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Service";
            this.Load += new System.EventHandler(this.addservice_Load);
            this.gbHotelFields.ResumeLayout(false);
            this.gbHotelFields.PerformLayout();
            this.gbTransportFields.ResumeLayout(false);
            this.gbTransportFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperators)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbServiceType;
        private System.Windows.Forms.ComboBox cbResourceType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtResourceName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.GroupBox gbHotelFields;
        private System.Windows.Forms.TextBox txtHotelLocation;
        private System.Windows.Forms.TextBox txtRooms;
        private System.Windows.Forms.GroupBox gbTransportFields;
        private System.Windows.Forms.TextBox txtVehicleNumber;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.TextBox textOperatorid;
        private System.Windows.Forms.Label lbloperaoterid;
        private System.Windows.Forms.DateTimePicker dpActualTime;
        private System.Windows.Forms.DateTimePicker dpEstimatedTime;
        private System.Windows.Forms.DataGridView dgvOperators;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cbTransportType;
        private System.Windows.Forms.Label label13;
    }
}