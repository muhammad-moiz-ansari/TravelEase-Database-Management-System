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
    public partial class choice : Form
    {
        public choice()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            // back service form
            Close();
            ManageServicesForm manageServicesForm = new ManageServicesForm(5);
            manageServicesForm.Show();

        }
    }
}
