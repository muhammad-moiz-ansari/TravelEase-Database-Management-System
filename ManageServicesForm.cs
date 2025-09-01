using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class ManageServicesForm : Form
    {
        private int currentServiceProviderId;
        public ManageServicesForm(int currentServiceProviderId)
        {
            InitializeComponent();
            this.currentServiceProviderId = currentServiceProviderId;
        }

        private void ManageServicesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBookingMgmt_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {

        }

        private void btnAssignedRequests_Click(object sender, EventArgs e)
        {

        }

        private void btnManageServices_Click(object sender, EventArgs e)
        {

        }

        private void btnaddd_Click(object sender, EventArgs e)
        {
            //open add
            addservice addServiceForm = new addservice(currentServiceProviderId);
            addServiceForm.Show();
            this.Hide();

        }

        private void edit_Click(object sender, EventArgs e)
        {
            //open edit
            editservice editServiceForm = new editservice(currentServiceProviderId);
            editServiceForm.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void list_Click(object sender, EventArgs e)
        {
            //open list form
            list listServiceForm = new list(currentServiceProviderId);
            listServiceForm.Show();
            this.Hide();


        }

        private void delete_Click(object sender, EventArgs e)
        {
            //open
            servicedeletecs deleteServiceForm = new servicedeletecs(currentServiceProviderId);
            deleteServiceForm.Show();
            this.Hide();


        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
