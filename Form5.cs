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
    public partial class Form5 : Form
    {
        int operatorId;
        public Form5(int userId)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.operatorId = userId;
            SetupNavigationBar();
        }

        private void SetupNavigationBar()
        {
            // Navigation panel created in designer

            string firstName = "Operator";
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();
                string query = "SELECT first_name FROM users WHERE user_id = @userId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", operatorId);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form6 var = new Form6(operatorId);
            var.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 var = new Form7();
            var.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 var = new Form9();
            var.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form10 var = new Form10();
            var.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void headingLabel_Click(object sender, EventArgs e)
        {

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

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
