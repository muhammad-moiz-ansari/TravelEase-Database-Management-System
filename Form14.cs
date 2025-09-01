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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;");
            conn.Open();

            string d1 = textBox1_bookID.Text;
            string query1 = "DELETE FROM payment WHERE booking_id = " + d1 + ";";
            string query = "DELETE FROM booking WHERE booking_id = " + d1 + ";";

            SqlCommand cmd = new SqlCommand(query1, conn);
            SqlCommand cmd2 = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd2.ExecuteNonQuery();
            cmd2.Dispose();

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
        }
    }
}
