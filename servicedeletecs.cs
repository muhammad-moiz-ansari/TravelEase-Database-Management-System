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
    public partial class servicedeletecs : Form
    {
        private int currentServiceProviderId;
        public servicedeletecs(int currentServiceProviderId)
        {
            InitializeComponent();
            this.currentServiceProviderId = currentServiceProviderId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {

        }

        private void deleteserviceid_TextChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // back service form
            Close();
            ManageServicesForm manageServicesForm = new ManageServicesForm(currentServiceProviderId);
            manageServicesForm.Show();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(deleteserviceid.Text))
            {
                MessageBox.Show("Please enter a service ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int serviceId;
            if (!int.TryParse(deleteserviceid.Text, out serviceId))
            {
                MessageBox.Show("Service ID must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this service?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    SqlCommand delHotel = new SqlCommand("DELETE FROM hotel WHERE resource_id = @id", conn, transaction);
                    delHotel.Parameters.AddWithValue("@id", serviceId);
                    delHotel.ExecuteNonQuery();

                    SqlCommand delTransport = new SqlCommand("DELETE FROM transport WHERE resource_id = @id", conn, transaction);
                    delTransport.Parameters.AddWithValue("@id", serviceId);
                    delTransport.ExecuteNonQuery();

                    SqlCommand delResource = new SqlCommand("DELETE FROM resources WHERE resource_id = @id", conn, transaction);
                    delResource.Parameters.AddWithValue("@id", serviceId);
                    int rowsAffected = delResource.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        transaction.Rollback();
                        MessageBox.Show("No service found with that ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    transaction.Commit();
                    MessageBox.Show("Service deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    deleteserviceid.Clear();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error: {ex.Message}", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }
    }
}
