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
    public partial class Form6 : Form
    {
        int operatorId;
        public Form6(int userId)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.operatorId = userId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 var=new Form5(operatorId);
            var.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;");
            conn.Open();

            string d1 = textBox1_operatorID.Text;
            string query = "SELECT trip_id as ID, appointed_date as Date, destination as Destination, duration as Duration, group_size as [Group Size] FROM trips WHERE operator_id = " + d1 + ";";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
