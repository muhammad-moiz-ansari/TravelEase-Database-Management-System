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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;");
            conn.Open();

            string d1 = textBox1_bookID.Text, d2 = textBox1_resource.Text;
            string query1 = "UPDATE booking SET resource_id = "+d2+"WHERE booking_id = "+d1+";";
            string query2 = "DELETE FROM ResourceRequest WHERE booking_id = "+d1+" and resource_id = "+d2+";";

            SqlCommand cmd = new SqlCommand(query1, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.ExecuteNonQuery();
            cmd2.Dispose();

            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;");
            conn.Open();

            string query = "SELECT booking_id as [Booking ID],resource_id as [Resource ID], payment_status as [Payment Status], Resource_Status as [Resource Status] FROM ResourceRequest;";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();
        }
    }
}
