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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Project
{
    public partial class signup_form : Form
    {
        public signup_form()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            usertype_box.SelectedIndex = 3; // Default = "Traveler"

            signup_button.FlatAppearance.BorderSize = 0;
            signup_button.Size = new Size(130, 40);
            SetButtonRoundedCorners(signup_button);

            signup_panel.Visible = true;
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
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"); //Connection string
            conn.Open();

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
                query = "Insert into users(first_name, last_name, phone, email, password, registration_date, user_type) values ('" + fname + "', '" + lname + "', '" + phoneno + "', '" + email + "', '" + password + "', GETDATE(), '" + usertype_box.SelectedItem?.ToString() + "')";

            if (!string.IsNullOrWhiteSpace(email_box.Text))
            {
                string queryUnique = "SELECT 1 FROM users WHERE email = @email";
                using (SqlCommand cmdUnique = new SqlCommand(queryUnique, conn))
                {
                    cmdUnique.Parameters.AddWithValue("@email", email);
                    using (SqlDataReader reader = cmdUnique.ExecuteReader())
                    if (reader.Read())
                    {
                        MessageBox.Show("Email already exists!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

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
            else    // Check Validations
            {
                if (!email_box.Text.Contains("@"))
                {
                    MessageBox.Show("Missing '@'...Enter email again", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool b1 = false, b2 = false, b3 = false;
                int ind = 0, count = 0;

                if (email == "")
                {
                    MessageBox.Show("Empty Input!...Enter email again", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (email[0] == '@')
                {
                    MessageBox.Show("Invalid input!...Enter email again", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    b1 = b2 = b3 = false;
                    ind = 0;
                    count = 0;
                    for (int i = 0; i < email.Length; ++i)
                    {
                        if (email[i] == '@')
                        {
                            b1 = true;
                            ind = i;
                            ++count;
                        }
                        if (email[i] == '.') // && ind1 != 0)
                            b2 = true;
                        if (email[i] == '.' && i == 0)
                            b3 = true;
                    }
                    if (count > 1)
                    {
                        MessageBox.Show("More than one @...Enter email again", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (b3)
                    {
                        MessageBox.Show("Invalid input!...Enter email again", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (email[ind] == '@' && email[ind + 1] == '.')
                    {
                        MessageBox.Show("Invalid input!...Enter email again", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (b1 && b2)
                    {
                        Console.WriteLine("Valid Email!");
                    }
                    else
                    {
                        MessageBox.Show("Missing '@' or '.'...Enter email again", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            if (string.IsNullOrWhiteSpace(password_box.Text))
            {
                MessageBox.Show("Please enter your password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (password_box.Text.Length < 6)
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
                //query3 = "Insert into "
            }

            //if (usertype == 0)

            query = "Insert into users(first_name, last_name, phone, email, password, registration_date, user_type, status) values ('" + fname + "', '" + lname + "', '" + phoneno + "', '" + email + "', '" + password + "', GETDATE(), '" + usertype_box.SelectedItem?.ToString() + "', 'Approved')";
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            conn.Close();

            /////////// print message
            this.Close();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            
        }

        private void login_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void signup_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login_form login_Form = new login_form();
            login_Form.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signup_form_Load(object sender, EventArgs e)
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
