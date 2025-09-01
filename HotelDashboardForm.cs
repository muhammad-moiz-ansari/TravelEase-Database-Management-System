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

namespace DB_Project
{
    public partial class HotelDashboardForm : Form
    {
        private int currentServiceProviderId;
        public HotelDashboardForm(int currentServiceProviderId)
        {
            InitializeComponent();
            this.currentServiceProviderId = currentServiceProviderId;
            SetupNavigationBar();
        }

        private void SetupNavigationBar()
        {
            // Navigation panel created in designer

            string firstName = "Service Provider";
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();
                string query = "SELECT first_name FROM users WHERE user_id = @userId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", currentServiceProviderId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            firstName = reader["first_name"].ToString();
                        }
                    }
                }
            }
            welcome_label.Text = "Welcome, " + firstName + "!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBookingMgmt_Click(object sender, EventArgs e)
        {
            // open managebooking
            BookingManagementForm bookingManagementForm = new BookingManagementForm(currentServiceProviderId);
            bookingManagementForm.Show();
        }

        private void btnAssignedRequests_Click(object sender, EventArgs e)
        {
            //open assigned requests form
            AssignedRequestsForm assignedRequestsForm = new AssignedRequestsForm(currentServiceProviderId);
            assignedRequestsForm.Show();
        }

        private void btnManageServices_Click(object sender, EventArgs e)
        {
            ManageServicesForm manageServicesForm = new ManageServicesForm(currentServiceProviderId);
            manageServicesForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            //open reports form
            ReportsFormcs reportsForm = new ReportsFormcs(currentServiceProviderId);
            reportsForm.Show();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void user_profilepic_Click(object sender, EventArgs e)
        {
            if (dp_select_panel.Visible)
                dp_select_panel.Visible = false;
            else
                dp_select_panel.Visible = true;
        }

        private void dp1_Click(object sender, EventArgs e)
        {
            user_profilepic.Image = Properties.Resources.dp1;
        }

        private void dp2_Click(object sender, EventArgs e)
        {
            user_profilepic.Image = Properties.Resources.dp2;
        }

        private void dp3_Click(object sender, EventArgs e)
        {
            user_profilepic.Image = Properties.Resources.dp3;
        }

        private void dp4_Click(object sender, EventArgs e)
        {
            user_profilepic.Image = Properties.Resources.dp4;
        }

        private void dp0_Click(object sender, EventArgs e)
        {
            user_profilepic.Image = Properties.Resources.def_dp;
        }

        private void headingLabel_Click(object sender, EventArgs e)
        {

        }

        private void HotelDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
