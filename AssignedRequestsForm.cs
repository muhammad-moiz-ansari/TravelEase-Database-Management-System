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
    public partial class AssignedRequestsForm : Form
    {
        private int currentServiceProviderId ;
        public AssignedRequestsForm(int currentServiceProviderId)
        {
            InitializeComponent();
            LoadAssignedRequests();
            this.currentServiceProviderId = currentServiceProviderId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnBookingMgmt_Click(object sender, EventArgs e)
        {
            UpdateBookingStatus("accept");
        }
        private void LoadAssignedRequests()
        {

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();

                string query = @"
        SELECT rr.booking_id, b.date_booked, rr.Resource_Status, rr.payment_status, r.resource_type
        FROM ResourceRequest rr
        JOIN booking b ON rr.booking_id = b.booking_id
        JOIN resources r ON rr.resource_id = r.resource_id
        WHERE rr.Resource_Status = 'pending' AND r.provider_id = @pid";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pid", currentServiceProviderId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRequests.DataSource = dt;
            }

            dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void UpdateBookingStatus(string status)
        {
            try
            {
                if (dgvRequests.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a booking to update.");
                    return;
                }

                int bookingId = Convert.ToInt32(dgvRequests.SelectedRows[0].Cells["booking_id"].Value);

                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(@"
                UPDATE ResourceRequest
                SET Resource_Status = @status
                WHERE booking_id = @id", conn);

                    cmd.Parameters.AddWithValue("@status", status);  // 'accept' or 'reject'
                    cmd.Parameters.AddWithValue("@id", bookingId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show($"Booking {status}.");
                LoadAssignedRequests(); // Refresh list
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating booking status: {ex.Message}");
            }
        }
        private void btnViewReports_Click(object sender, EventArgs e)
        {
            HotelDashboardForm dashboardForm = new HotelDashboardForm(currentServiceProviderId);
            dashboardForm.Show();
            this.Hide();
            this.Close();
        }

        private void AssignedRequestsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnrejectselected_Click(object sender, EventArgs e)
        {
            UpdateBookingStatus("reject");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
