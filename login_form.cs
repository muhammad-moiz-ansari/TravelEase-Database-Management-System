using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            login_button.FlatAppearance.BorderSize = 0;
            login_button.Size = new Size(130, 40);
            SetButtonRoundedCorners(login_button);

            login_panel.Visible = true;
        }

        private void SetButtonRoundedCorners(Button button)
        {
            int radius = 20;
            GraphicsPath path = new GraphicsPath();
            Rectangle bounds = new Rectangle(0, 0, button.Width, button.Height);
            int diameter = radius * 2;
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Width - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Width - diameter, bounds.Height - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Height - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            button.Region = new Region(path);
        }

        private void header1_Click(object sender, EventArgs e)
        {

        }

        private void login_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup_form signup_Form = new signup_form();
            signup_Form.ShowDialog();
            this.Close();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"); //Connection string
            conn.Open();
            //MessageBox.Show("Connection Open");
            int userId;
            string email = email_box.Text,
                password = password_box.Text,
                user_type = "",
                status = "",
                query1 = "SELECT email FROM users WHERE email = @email",
                query2 = "SELECT user_id, user_type, status FROM users WHERE email = @email AND password = @password";

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter your email", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlCommand cmd1 = new SqlCommand(query1, conn))
            {
                cmd1.Parameters.AddWithValue("@email", email);
                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        MessageBox.Show("This email does not exists!\nPlease signup", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            using (SqlCommand cmd2 = new SqlCommand(query2, conn))
            {
                cmd2.Parameters.AddWithValue("@email", email);
                cmd2.Parameters.AddWithValue("@password", password);
                using (SqlDataReader reader = cmd2.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        MessageBox.Show("Incorrect password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    userId = Convert.ToInt32(reader["user_id"]);
                    user_type = reader["user_type"].ToString();
                    status = reader["status"].ToString();
                }
            }
            conn.Close();

            if (status == "Pending")
            {
                MessageBox.Show("Login Failed!\nAccount registration is Pending", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (status == "Rejected")
            {
                MessageBox.Show("Login Failed!\nAccount registration is Rejected", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (user_type == "Admin")
            {
                AdminDashboardForm adminDashboard = new AdminDashboardForm(userId);
                adminDashboard.ShowDialog();
                //this.Close();
            }
            else if (user_type == "Operator")
            {
                Form5 operatorform = new Form5(userId);
                operatorform.ShowDialog();
                //this.Close();
            }
            else if (user_type == "Service Provider")
            {
                HotelDashboardForm hotelDashboard = new HotelDashboardForm(userId);
                hotelDashboard.ShowDialog();
                //this.Close();
            }
            else    // Traveller
            {
                TravellerDashboardForm travellerDashboard = new TravellerDashboardForm(userId);
                travellerDashboard.ShowDialog();
                //this.Close();
            }


            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }

        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            if (password_box.UseSystemPasswordChar)
            {
                password_box.UseSystemPasswordChar = false;
                showPasswordButton.Image = DB_Project.Properties.Resources.eye2;
            }
            else
            {
                password_box.UseSystemPasswordChar = true;
                showPasswordButton.Image = DB_Project.Properties.Resources.eye_hide2;
            }
        }
    }
}
