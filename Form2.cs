using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;");
            conn.Open();
            
            string d1= textBox1_tripID.Text, d2= textBox9_operatorID.Text, d3= textBox8_tripDate.Text, d4= textBox7_Destination.Text, d5= textBox6_Activity.Text, d6= textBox5_price.Text, d7= textBox4_duration.Text, d8= textBox3_size.Text, d9= textBox2_itinery.Text;
            string query = "INSERT INTO trips VALUES ('" + d1 + "','" + d2 + "','" + d5 + "','" + d6 + "','" + d7 + "','" + d8 + "','" + d9 + "','" + d3 + "','" + d4 + "');";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            conn.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void textBox9_operatorID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_Activity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
