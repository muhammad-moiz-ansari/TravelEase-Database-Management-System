using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class welcome_window : Form
    {
        public welcome_window()
        {
            InitializeComponent();

            // Sign Up Button
            //signup_button.FlatStyle = FlatStyle.Flat;
            //signup_button.BackColor = Color.FromArgb(84, 230, 160); // Mint Green
            //signup_button.ForeColor = Color.FromArgb(232, 236, 239); // Off-White
            //signup_button.Font = new Font("Calibri", 12, FontStyle.Bold);
            //signup_button.Size = new Size(130, 40);
            signup_button.FlatAppearance.BorderSize = 0;
            signup_button.Text = "Sign Up";
            // Add icon (if using a custom image)
            // signup_button.Image = Image.FromFile("path_to_arrow_icon.png");
            // signup_button.ImageAlign = ContentAlignment.MiddleLeft;
            // signup_button.TextAlign = ContentAlignment.MiddleCenter;

            // Login Button
            //login_button.FlatStyle = FlatStyle.Flat;
            //login_button.BackColor = Color.FromArgb(106, 176, 255); // Light Sky Blue
            //login_button.ForeColor = Color.FromArgb(232, 236, 239); // Off-White
            //login_button.Font = new Font("Calibri", 12, FontStyle.Bold);
            //login_button.Size = new Size(130, 40);
            login_button.FlatAppearance.BorderSize = 0;
            //login_button.Text = "Login";
            //// Add icon (if using a custom image)
            //// login_button.Image = Image.FromFile("path_to_arrow_icon.png");
            //// login_button.ImageAlign = ContentAlignment.MiddleLeft;
            //// login_button.TextAlign = ContentAlignment.MiddleCenter;

            // Apply rounded corners
            SetButtonRoundedCorners(signup_button);
            SetButtonRoundedCorners(login_button);
        }


    // Method for rounded corners
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

    private void signup_button_Click(object sender, EventArgs e)
        {
            signup_form signup_Form = new signup_form(1);
            signup_Form.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            signup_form signup_Form = new signup_form(0);
            signup_Form.ShowDialog();
            this.Close();
        }
    }
}
