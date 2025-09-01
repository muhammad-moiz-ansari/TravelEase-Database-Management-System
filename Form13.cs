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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show(); this.Hide();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;");
            conn.Open();

            string query = "SELECT MAX(pass_id) FROM digital_pass;";
            SqlCommand cmd = new SqlCommand(query, conn);
            object res = cmd.ExecuteScalar();
            int ticket = Convert.ToInt32(res);
            ticket += 1;

            string query1 = "SELECT MAX(pass_id) FROM digital_pass;";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            object result = cmd1.ExecuteScalar();
            int PassId = Convert.ToInt32(result);
            PassId += 1;

            string query2 = "INSERT INTO digital_pass VALUES(getdate());";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.ExecuteNonQuery();
            cmd2.Dispose();

            string query3 = "INSERT INTO ticket VALUES('" + PassId.ToString() + "','" + ticket.ToString() + "');";
            SqlCommand cmd3 = new SqlCommand(query3, conn);
            cmd3.ExecuteNonQuery();
            cmd3.Dispose();

            string d1 = textBox1_bookID.Text;
            string query4 = "UPDATE booking SET book_status='confirmed' WHERE booking_id = " + d1 + ";";
            string query5 = "UPDATE booking SET pass_id=" + PassId.ToString() +" WHERE booking_id = " + d1 + ";";
            string query6 = "UPDATE booking SET date_book_confirmed=getdate() WHERE booking_id = " + d1 + ";";

            SqlCommand cmd4 = new SqlCommand(query4, conn);
            cmd4.ExecuteNonQuery();
            cmd4.Dispose();
            SqlCommand cmd5 = new SqlCommand(query5, conn);
            cmd5.ExecuteNonQuery();
            cmd5.Dispose();
            SqlCommand cmd6 = new SqlCommand(query6, conn);
            cmd6.ExecuteNonQuery();
            cmd6.Dispose();

            conn.Close();
        }
    }
}
