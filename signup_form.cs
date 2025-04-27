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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Project
{
    public partial class signup_form : Form
    {
        public signup_form(int isSignup = 1)
        {
            InitializeComponent();

            usertype_box.SelectedIndex = 3; // Default = "Traveler"

            signup_button.FlatAppearance.BorderSize = 0;
            SetButtonRoundedCorners(signup_button);

            login_button.FlatAppearance.BorderSize = 0;
            SetButtonRoundedCorners(login_button);

            if (isSignup == 1)
            {
                signup_panel.Visible = true;
                login_panel.Visible = false;
            }
            else
            {
                signup_panel.Visible = false;
                login_panel.Visible = true;
            }
        }
        string[] usertypes = { "Admin", "Operator", "Service Provider", "Traveller" };
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void usertype_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void adminlevel_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usertype_box_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedUserType = usertype_box.SelectedItem?.ToString();
            Console.WriteLine($"Selected User Type: '{selectedUserType}'");

            // Check and set visibility
            if (selectedUserType == "Admin")
            {
                dob_panel.Visible = false;
                nationality_panel.Visible = false;
                location_panel.Visible = false;
                adminlevel_panel.Visible = true;
            }
            else if (selectedUserType == "Operator")
            {
                dob_panel.Visible = false;
                nationality_panel.Visible = true;
                location_panel.Visible = false;
                adminlevel_panel.Visible = false;
            }
            else if (selectedUserType == "Service Provider")
            {
                dob_panel.Visible = false;
                nationality_panel.Visible = false;
                location_panel.Visible = true;
                adminlevel_panel.Visible = false;
            }
            else    // traveller
            {
                dob_panel.Visible = true;
                nationality_panel.Visible = true;
                location_panel.Visible = false;
                adminlevel_panel.Visible = false;
            }
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=Forms;Integrated Security=True;"); //Connection string
            conn.Open();
            MessageBox.Show("Connection Open");
            SqlCommand cmd;
            int usertype = usertype_box.SelectedIndex;
            string fname = fname_box.Text,
                lname = lname_box.Text,
                email = email_box.Text,
                phoneno = phoneno_box.Text,
                password = password_box.Text,
                dob = dob_box.Text,
                nationality = nationality_box.Text,
                location = location_box.Text,
                adminlevel = adminlevel_box.Text,
                query = "Insert into users(firstname, lastname, phone, email, password, registration_date) values ('" + fname + "', '" + lname + "', '" + phoneno + "', '" + email + "', '" + password + "', ' GETDATE() ')",
                query0, query1, query2, query3;

            // Validation
            if (string.IsNullOrWhiteSpace(fname_box.Text))
            {
                MessageBox.Show("Please enter your first name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(lname_box.Text))
            {
                MessageBox.Show("Please enter your last name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(email_box.Text))
            {
                MessageBox.Show("Please enter your email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(!email_box.Text.Contains("@"))    // check more validation
            {
                MessageBox.Show("Please enter a valid email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(password_box.Text))
            {
                MessageBox.Show("Please enter your password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(password_box.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (usertype_box.SelectedIndex < 0 || usertype_box.SelectedIndex > 3)
            {
                MessageBox.Show("Please select a user type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (usertype == 0)
            {
                ComboBox cmbAdminLevel = adminlevel_panel.Controls.OfType<ComboBox>().FirstOrDefault();
                if (cmbAdminLevel == null || cmbAdminLevel.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select an admin level.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                query0 = "Insert into admin(admin_level, status) values ('" + adminlevel_box.SelectedItem?.ToString() + "')";
            }
            if (usertype == 1)
            {
                if (string.IsNullOrWhiteSpace(nationality_box.Text))
                {
                    MessageBox.Show("Please enter your nationality.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //query1 = "Insert into operator(user_id, admin_level) values ('" + adminlevel_box.SelectedItem?.ToString() + "')";
            }
            else if (usertype == 2)
            {
                if (string.IsNullOrWhiteSpace(location_box.Text))
                {
                    MessageBox.Show("Please enter your location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //query2 = "Insert into serice_provider(admin_level, status) values ('" + adminlevel_box.SelectedItem?.ToString() + "')";
            }
            else if (usertype == 3) 
            {
                if (string.IsNullOrWhiteSpace(nationality_box.Text))
                {
                    MessageBox.Show("Please enter your nationality.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(dob_box.Text))
                {
                    MessageBox.Show("Please enter your date of birth.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // DOB validation (if needed)
            }
            cmd = new SqlCommand(query, conn);
            //cmd.ExecuteNonQuery();    ////////////////////////////// #UNCOMMENT
            cmd.Dispose();
            conn.Close();

            login_panel.Visible = true;
            signup_panel.Visible = false;
            //this.Close();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            
        }

        private void login_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup_panel.Visible = true;
            login_panel.Visible = false;
        }
    }
}
