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
    public partial class editservice : Form
    {
        private int currentServiceProviderId ;
        public editservice(int serviceProviderId)
        {
            InitializeComponent();
            currentServiceProviderId = serviceProviderId;
        }

        private void back_Click(object sender, EventArgs e)
        {
            
        }

        private void editservice_Load(object sender, EventArgs e)
        {

        }
        private bool ValidateInputs()
        {
            if (cbServiceType.SelectedIndex == -1 || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtresourcesid.Text))
                return false;

            if (cbServiceType.SelectedItem.ToString() == "Hotel")
            {
                if (string.IsNullOrEmpty(txtRooms.Text) || string.IsNullOrEmpty(txtHotelLocation.Text))
                    return false;
            }
            else if (cbServiceType.SelectedItem.ToString() == "Transport")
            {
                if (string.IsNullOrEmpty(txtVehicleNumber.Text) || string.IsNullOrEmpty(txtSeats.Text) ||
                    cbResourceType.SelectedIndex == -1)
                    return false;
            }

            return true;
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ManageServicesForm manageServicesForm = new ManageServicesForm(currentServiceProviderId);
            manageServicesForm.Show();
        }

        private void cbResourceType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void editHotelService(decimal price, int resourceId)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    SqlCommand cmd1 = new SqlCommand("UPDATE resources SET price = @price WHERE resource_id = @id", conn, transaction);
                    cmd1.Parameters.AddWithValue("@price", price);
                    cmd1.Parameters.AddWithValue("@id", resourceId);
                    cmd1.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand("UPDATE hotel SET location = @location WHERE resource_id = @id", conn, transaction);
                    cmd2.Parameters.AddWithValue("@location", txtHotelLocation.Text);
                    cmd2.Parameters.AddWithValue("@id", resourceId);
                    cmd2.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        private void editTransportService(decimal price, int resourceId)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    SqlCommand cmd1 = new SqlCommand("UPDATE resources SET price = @price WHERE resource_id = @id", conn, transaction);
                    cmd1.Parameters.AddWithValue("@price", price);
                    cmd1.Parameters.AddWithValue("@id", resourceId);
                    cmd1.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand(@"
                UPDATE transport SET 
                    vehicle_number = @veh,
                    number_of_seats = @seats,
                    transport_type = @type,
                    estimated_leaving_time = @est,
                    actual_leaving_time = @act
                WHERE resource_id = @id", conn, transaction);

                    //cmd2.Parameters.AddWithValue("@veh", txtVehicleNumber);
                    cmd2.Parameters.AddWithValue("@veh", txtVehicleNumber.Text);
                    cmd2.Parameters.AddWithValue("@seats", int.Parse(txtSeats.Text));
                    cmd2.Parameters.AddWithValue("@type", cbResourceType.SelectedItem.ToString());
                    cmd2.Parameters.AddWithValue("@est", dpEstimatedTime.Value.TimeOfDay);
                    cmd2.Parameters.AddWithValue("@act", dpActualTime.Value.TimeOfDay);
                    cmd2.Parameters.AddWithValue("@id", resourceId);
                    cmd2.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int resourcexid;
                if (!int.TryParse(txtresourcesid.Text, out resourcexid))
                {
                    MessageBox.Show("Invalid Operator ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string serviceType = cbServiceType.SelectedItem.ToString().ToLower();
                decimal price = decimal.Parse(txtPrice.Text);
                MessageBox.Show("Service edited successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (serviceType == "hotel")
                {
                    editHotelService(price, resourcexid);
                }
                else if (serviceType == "transport")
                {
                    editTransportService(price, resourcexid);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving service: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
