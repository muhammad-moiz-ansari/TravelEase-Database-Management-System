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
    public partial class BookingManagementForm : Form
    {
        private int providerId ;
        public BookingManagementForm(int providerId)
        {
            InitializeComponent();
            this.providerId = providerId;
            LoadBookings();
        }

        private void BookingManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
        private void LoadBookings()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
                {
                    string query = @"SELECT rr.booking_id, b.date_booked, rr.Resource_Status AS book_status, ISNULL(rr.payment_status, 'N/A') AS payment_status
                                     FROM ResourceRequest rr
                                     JOIN booking b ON rr.booking_id = b.booking_id
                                     JOIN resources r ON rr.resource_id = r.resource_id
                                     WHERE r.provider_id = @pid";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@pid", providerId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvBooking.DataSource = dt;
                }

                dgvBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message);
            }
        }
        private void UpdateBooking(string status)
        {
            if (dgvBooking.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a booking to update.");
                return;
            }

            int bookingId = Convert.ToInt32(dgvBooking.SelectedRows[0].Cells["booking_id"].Value);

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ResourceRequest SET Resource_Status = @status WHERE booking_id = @id", conn);
                cmd.Parameters.AddWithValue("@status", status); // 'confirmed', 'reject', etc.
                cmd.Parameters.AddWithValue("@id", bookingId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show($"Booking marked as {status}.");
            LoadBookings();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmbooking_Click(object sender, EventArgs e)
        {
            UpdateBooking("accept");
        }

        private void btnMarkPaid_Click(object sender, EventArgs e)
        {
            if (dgvBooking.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a booking to mark as paid.");
                return;
            }

            int bookingId = Convert.ToInt32(dgvBooking.SelectedRows[0].Cells["booking_id"].Value);

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ResourceRequest SET payment_status = 'paid' WHERE booking_id = @id", conn);
                cmd.Parameters.AddWithValue("@id", bookingId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Booking marked as paid.");
            LoadBookings();
        }

        private void dgvBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
