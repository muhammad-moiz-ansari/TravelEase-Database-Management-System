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
    public partial class list : Form
    {
        private int currentServiceProviderId;
        public list(int currentServiceProviderId)
        {
            InitializeComponent();
            this.currentServiceProviderId = currentServiceProviderId;
            LoadServices();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            ManageServicesForm manageServicesForm = new ManageServicesForm(currentServiceProviderId);
            manageServicesForm.Show();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ManageServicesForm manageServicesForm = new ManageServicesForm(currentServiceProviderId);
            manageServicesForm.Show();
        }
        private void LoadServices()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;") )
            {
                conn.Open();
                string query = @"
                                    SELECT r.resource_id, r.resource_type, r.price,
                                           CASE 
                                               WHEN h.resource_id IS NOT NULL THEN 'Hotel' 
                                               WHEN t.resource_id IS NOT NULL THEN 'Transport' 
                                           END AS service_type,
                                           ISNULL(h.location, t.vehicle_number) AS name_or_number
                                    FROM resources r
                                    LEFT JOIN hotel h ON r.resource_id = h.resource_id
                                    LEFT JOIN transport t ON r.resource_id = t.resource_id
                                    WHERE r.provider_id = @pid";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pid", currentServiceProviderId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvservice.DataSource = dt;
            }

            dgvservice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvservice.ReadOnly = true;
            dgvservice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvservice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvservice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }
        private void list_Load(object sender, EventArgs e)
        {

        }

        private void dgvservice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
