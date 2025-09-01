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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DB_Project
{
    public partial class welcome_window : Form
    {
        public welcome_window()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            // Sign Up Button
            signup_button.Size = new Size(130, 40);
            signup_button.FlatAppearance.BorderSize = 0;

            // Login Button
            login_button.Size = new Size(130, 40);
            login_button.FlatAppearance.BorderSize = 0;

            // Generate Reports Button
            generateReportButton.Size = new Size(130, 40);
            generateReportButton.FlatAppearance.BorderSize = 0;

            // Apply rounded corners
            SetButtonRoundedCorners(signup_button);
            SetButtonRoundedCorners(login_button);
            SetButtonRoundedCorners(generateReportButton);



            ////////////////////////////////////////////////////////////////   just for testing
            /*  
            Form5 operatorDashboard = new Form5(14);
            operatorDashboard.ShowDialog();
            this.Close();
            */

            /*  
            TravellerDashboardForm travelerDashboard = new TravellerDashboardForm(10);
            travelerDashboard.ShowDialog();
            this.Close();
            */


            /*  
            AdminDashboardForm adminDashboard = new AdminDashboardForm(1);
            adminDashboard.ShowDialog();
            this.Close();
            */


            /*   
            HotelDashboardForm hotelDashboard = new HotelDashboardForm(12);
            hotelDashboard.ShowDialog();
            this.Close();
            */
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
            signup_form signup_Form = new signup_form();
            signup_Form.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            login_form login_Form = new login_form();
            login_Form.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TravellerDashboardForm travellerDashboard = new TravellerDashboardForm(1);
            travellerDashboard.ShowDialog();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminDashboardForm adminDashboard = new AdminDashboardForm(2);
            adminDashboard.ShowDialog();
            this.Close();
        }

        private void welcome_window_Load(object sender, EventArgs e)
        {

        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            GeneratedReports report = new GeneratedReports();
            report.ShowDialog();
        }
    }
}
