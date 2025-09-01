namespace DB_Project
{
    partial class AssignedRequestsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignedRequestsForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnacceptselected = new System.Windows.Forms.Button();
            this.btnrejectselected = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(416, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Assigned Requests";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvRequests
            // 
            this.dgvRequests.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRequests.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Location = new System.Drawing.Point(39, 122);
            this.dgvRequests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.RowHeadersWidth = 51;
            this.dgvRequests.RowTemplate.Height = 24;
            this.dgvRequests.Size = new System.Drawing.Size(917, 412);
            this.dgvRequests.TabIndex = 19;
            this.dgvRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(268, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 55);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnacceptselected
            // 
            this.btnacceptselected.AutoSize = true;
            this.btnacceptselected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(230)))), ((int)(((byte)(160)))));
            this.btnacceptselected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnacceptselected.BackgroundImage")));
            this.btnacceptselected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnacceptselected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacceptselected.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacceptselected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnacceptselected.Location = new System.Drawing.Point(1020, 166);
            this.btnacceptselected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnacceptselected.Name = "btnacceptselected";
            this.btnacceptselected.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnacceptselected.Size = new System.Drawing.Size(207, 119);
            this.btnacceptselected.TabIndex = 15;
            this.btnacceptselected.Text = "Accept selected";
            this.btnacceptselected.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnacceptselected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnacceptselected.UseVisualStyleBackColor = false;
            this.btnacceptselected.Click += new System.EventHandler(this.btnBookingMgmt_Click);
            // 
            // btnrejectselected
            // 
            this.btnrejectselected.AutoSize = true;
            this.btnrejectselected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(230)))), ((int)(((byte)(160)))));
            this.btnrejectselected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrejectselected.BackgroundImage")));
            this.btnrejectselected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnrejectselected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrejectselected.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrejectselected.Location = new System.Drawing.Point(1020, 370);
            this.btnrejectselected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnrejectselected.Name = "btnrejectselected";
            this.btnrejectselected.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnrejectselected.Size = new System.Drawing.Size(207, 119);
            this.btnrejectselected.TabIndex = 12;
            this.btnrejectselected.Text = "Reject selected";
            this.btnrejectselected.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnrejectselected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnrejectselected.UseVisualStyleBackColor = false;
            this.btnrejectselected.Click += new System.EventHandler(this.btnrejectselected_Click);
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
            this.backButton.TabIndex = 29;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AssignedRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DB_Project.Properties.Resources.bg41;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1277, 647);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dgvRequests);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnacceptselected);
            this.Controls.Add(this.btnrejectselected);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AssignedRequestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assigned Requests";
            this.Load += new System.EventHandler(this.AssignedRequestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnacceptselected;
        private System.Windows.Forms.Button btnrejectselected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.PictureBox backButton;
    }
}