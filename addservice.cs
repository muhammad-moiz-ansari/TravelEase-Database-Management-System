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
    public partial class addservice : Form
    {
        private int currentServiceProviderId;
        public addservice(int serviceProviderId)
        {
            InitializeComponent();
            LoadOperatorsToGrid();
            currentServiceProviderId = serviceProviderId;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbResourceType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addservice_Load(object sender, EventArgs e)
        {

        }

        private void cbServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbServiceType.Text == "Hotel")
            {
                gbHotelFields.Visible = true;
                gbTransportFields.Visible = false;
            }
            else if (cbServiceType.Text == "Transport")
            {
                gbHotelFields.Visible = false;
                gbTransportFields.Visible = true;
            }
        }
        private void LoadOperatorsToGrid()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;") )
            {
                string query = @"SELECT u.user_id AS OperatorID, u.email AS Email
                         FROM operator o 
                         JOIN users u ON o.user_id = u.user_id";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOperators.DataSource = dt;
            }

            dgvOperators.Columns["OperatorID"].HeaderText = "ID";
            dgvOperators.Columns["Email"].HeaderText = "Email";
        }
        private bool ValidateInputs()
        {
            if (cbServiceType.SelectedIndex == -1 || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(textOperatorid.Text))
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
        private void txtResourceName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbHotelFields_Enter(object sender, EventArgs e)
        {

        }

        private void txtRooms_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHotelLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbTransportFields_Enter(object sender, EventArgs e)
        {

        }

        private void txtVehicleNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeats_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstimatedTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtActualTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

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
                int operatorId;
                if (!int.TryParse(textOperatorid.Text, out operatorId))
                {
                    MessageBox.Show("Invalid Operator ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string serviceType = cbServiceType.SelectedItem.ToString().ToLower();
                decimal price = decimal.Parse(txtPrice.Text);
                MessageBox.Show("Service added successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (serviceType == "hotel")
                {
                    SaveHotelService(price, operatorId);
                }
                else if (serviceType == "transport")
                {
                    SaveTransportService(price, operatorId);
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

        private void back_Click(object sender, EventArgs e)
        {
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ManageServicesForm manageServicesForm = new ManageServicesForm(currentServiceProviderId);
            manageServicesForm.Show();
        }
        private void SaveHotelService(decimal price, int operatorId)

        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        int resourceId;
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandText = @"INSERT INTO resources 
                                         (operator_id, provider_id, resource_type, price) 
                                         VALUES (@operatorId, @providerId, @resourceType, @price); 
                                         SELECT SCOPE_IDENTITY();";

                            cmd.Parameters.AddWithValue("@operatorId", operatorId);
                            cmd.Parameters.AddWithValue("@providerId", currentServiceProviderId);
                            cmd.Parameters.AddWithValue("@resourceType", "hotel");
                            cmd.Parameters.AddWithValue("@price", price);

                            resourceId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandText = @"INSERT INTO hotel 
                                         (resource_id, number_of_rooms, location) 
                                         VALUES (@resourceId, @rooms, @location)";

                            cmd.Parameters.AddWithValue("@resourceId", resourceId);
                            cmd.Parameters.AddWithValue("@rooms", int.Parse(txtRooms.Text));
                            cmd.Parameters.AddWithValue("@location", txtHotelLocation.Text);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        private void SaveTransportService(decimal price, int operatorId)

        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        int resourceId;
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandText = @"INSERT INTO resources 
                                         (operator_id, provider_id, resource_type, price) 
                                         VALUES (@operatorId, @providerId, @resourceType, @price); 
                                         SELECT SCOPE_IDENTITY();";

                            cmd.Parameters.AddWithValue("@operatorId", operatorId);
                            cmd.Parameters.AddWithValue("@providerId", currentServiceProviderId);
                            cmd.Parameters.AddWithValue("@resourceType", "transport");
                            cmd.Parameters.AddWithValue("@price", price);

                            resourceId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandText = @"INSERT INTO transport 
                                         (vehicle_number, resource_id, number_of_seats, transport_type, estimated_leaving_time,actual_leaving_time) 
                                         VALUES (@vehicleNumber, @resourceId, @seats, @transportType, @leavingTime,@actualtime)";

                            cmd.Parameters.AddWithValue("@vehicleNumber", txtVehicleNumber.Text);
                            cmd.Parameters.AddWithValue("@resourceId", resourceId);
                            cmd.Parameters.AddWithValue("@seats", int.Parse(txtSeats.Text));
                            cmd.Parameters.AddWithValue("@transportType", cbTransportType.Text.ToString());
                            cmd.Parameters.AddWithValue("@leavingTime", dpEstimatedTime.Value.TimeOfDay);
                            cmd.Parameters.AddWithValue("@actualtime", dpActualTime.Value.TimeOfDay);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void dgvOperators_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }
    }
}
