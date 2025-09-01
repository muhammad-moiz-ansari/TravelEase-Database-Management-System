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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show(); this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show(); this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form12 var = new Form12();
            var.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form13 var = new Form13();
            var.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;");
            conn.Open();

            string d1 = textBox1_operatorID.Text;
            string query = "SELECT bk.booking_id as [Booking ID], t.trip_id as [Trip ID], tr.user_id as [Traveller ID], bk.resource_id as [Resource ID], bk.book_status as [Book Status], p.payment_status as [Payment Status] " +
                           "FROM books b " +
                           "INNER JOIN booking bk ON b.booking_id=bk.booking_id " +
                           "INNER JOIN traveller tr ON tr.user_id=b.traveller_id " +
                           "INNER JOIN payment p ON bk.booking_id=p.booking_id " +
                           "INNER JOIN trips t ON t.trip_id=b.trip_id " +
                           "INNER JOIN operator o ON t.operator_id=o.user_id " +
                           "WHERE bk.book_status LIKE '%pending%' and o.user_id = " + d1 + " or bk.resource_id is NULL ;";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form14 var = new Form14();
            var.Show(); this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.Show();
        }
    }
}
