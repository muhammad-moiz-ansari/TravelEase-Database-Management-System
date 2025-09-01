namespace DB_Project
{
    partial class choice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choice));
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hotel = new System.Windows.Forms.Button();
            this.transport = new System.Windows.Forms.Button();
            this.TravelEaseDataSet = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.TravelEaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold);
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.back.Location = new System.Drawing.Point(652, 182);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(159, 78);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter the Service Type";
            // 
            // hotel
            // 
            this.hotel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.hotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotel.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold);
            this.hotel.Image = ((System.Drawing.Image)(resources.GetObject("hotel.Image")));
            this.hotel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotel.Location = new System.Drawing.Point(407, 182);
            this.hotel.Margin = new System.Windows.Forms.Padding(2);
            this.hotel.Name = "hotel";
            this.hotel.Size = new System.Drawing.Size(159, 78);
            this.hotel.TabIndex = 6;
            this.hotel.Text = "Hotel";
            this.hotel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotel.UseVisualStyleBackColor = false;
            // 
            // transport
            // 
            this.transport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.transport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transport.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold);
            this.transport.Image = ((System.Drawing.Image)(resources.GetObject("transport.Image")));
            this.transport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.transport.Location = new System.Drawing.Point(160, 182);
            this.transport.Margin = new System.Windows.Forms.Padding(2);
            this.transport.Name = "transport";
            this.transport.Size = new System.Drawing.Size(159, 78);
            this.transport.TabIndex = 7;
            this.transport.Text = "Transport";
            this.transport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.transport.UseVisualStyleBackColor = false;
            // 
            // TravelEaseDataSet
            // 
            this.TravelEaseDataSet.DataSetName = "NewDataSet";
            // 
            // choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DB_Project.Properties.Resources.bg41;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 526);
            this.Controls.Add(this.transport);
            this.Controls.Add(this.hotel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "choice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choice";
            ((System.ComponentModel.ISupportInitialize)(this.TravelEaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hotel;
        private System.Windows.Forms.Button transport;
        private System.Data.DataSet TravelEaseDataSet;
    }
}