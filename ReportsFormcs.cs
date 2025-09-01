using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DB_Project
{
    public partial class ReportsFormcs : Form
    {
        private int currentServiceProviderId;
        public ReportsFormcs(int currentServiceProviderId)
        {
            InitializeComponent();
            this.currentServiceProviderId = currentServiceProviderId;
        }

        private void ReportsFormcs_Load(object sender, EventArgs e)
        {

            LoadPerformanceChart();
        }
        private void LoadPerformanceChart()
        {
            operatorreport.Series.Clear();
            operatorreport.Titles.Clear();
            operatorreport.ChartAreas[0].AxisX.Title = "Month";
            operatorreport.ChartAreas[0].AxisY.Title = "Total Bookings";

            Series bookingSeries = operatorreport.Series.Add("Monthly Bookings");
            bookingSeries.ChartType = SeriesChartType.Column;

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();

                SqlCommand monthlyCmd = new SqlCommand(@"
            SELECT MONTH(date_booked) AS Month, COUNT(*) AS Total
            FROM booking b
            JOIN resources r ON b.resource_id = r.resource_id
            WHERE r.provider_id = @pid
            GROUP BY MONTH(date_booked)
            ORDER BY Month", conn);
                monthlyCmd.Parameters.AddWithValue("@pid", currentServiceProviderId);

                SqlDataReader reader = monthlyCmd.ExecuteReader();
                while (reader.Read())
                {
                    int month = (int)reader["Month"];
                    int total = (int)reader["Total"];
                    bookingSeries.Points.AddXY(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(month), total);
                }
                reader.Close();

                SqlCommand totalBookingCmd = new SqlCommand(@"
            SELECT COUNT(*) 
            FROM booking b
            JOIN resources r ON b.resource_id = r.resource_id
            WHERE r.provider_id = @pid", conn);
                totalBookingCmd.Parameters.AddWithValue("@pid", currentServiceProviderId);
                int totalBookings = (int)totalBookingCmd.ExecuteScalar();

                SqlCommand feedbackCmd = new SqlCommand(@"
            SELECT AVG(sr.rating)
            FROM service_reviews sr
            JOIN for_relation fr ON sr.service_review_id = fr.service_review_id
            JOIN resources r ON fr.resource_id = r.resource_id
            WHERE r.provider_id = @pid", conn);
                feedbackCmd.Parameters.AddWithValue("@pid", currentServiceProviderId);
                object feedbackObj = feedbackCmd.ExecuteScalar();
                double avgFeedback = feedbackObj != DBNull.Value ? Convert.ToDouble(feedbackObj) : 0;

                SqlCommand revenueCmd = new SqlCommand(@"
            SELECT SUM(p.amount)
            FROM payment p
            JOIN booking b ON p.booking_id = b.booking_id
            JOIN resources r ON b.resource_id = r.resource_id
            WHERE r.provider_id = @pid", conn);
                revenueCmd.Parameters.AddWithValue("@pid", currentServiceProviderId);
                object revenueObj = revenueCmd.ExecuteScalar();
                double revenue = revenueObj != DBNull.Value ? Convert.ToDouble(revenueObj) : 0;

                lblOccupancy.Text = $"Occupancy Rate: {totalBookings} bookings";
                lblFeedback.Text = $"Average Feedback: {avgFeedback:F1} ★";
                lblRevenue.Text = $"Total Revenue: Rs. {revenue:N0}";
            }
        }
        private void btnViewReports_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void operatorreport_Click(object sender, EventArgs e)
        {

        }
    }
}
