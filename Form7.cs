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
using System.Windows.Forms.DataVisualization.Charting;

namespace DB_Project
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_tripID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;");
            conn.Open();

            string d1 = textBox1_tripID.Text;
            string query = "SELECT t.trip_id as [Trip ID], COUNT(*) as [Confirmed Books], SUM(t.price) as Revenue FROM trips t INNER JOIN books b on t.trip_id = b.trip_id INNER JOIN booking bk on b.booking_id = bk.booking_id INNER JOIN payment p on p.booking_id = bk.booking_id WHERE t.trip_id = " + d1 + " and p.payment_status LIKE '%paid%' and bk.book_status LIKE '%confirmed%' GROUP BY t.trip_id;";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
