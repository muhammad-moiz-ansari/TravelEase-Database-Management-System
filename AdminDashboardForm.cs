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
    public partial class AdminDashboardForm : Form
    {
        int userid;
        public AdminDashboardForm(int id)
        {
            InitializeComponent();
            userid = id;

            this.WindowState = FormWindowState.Maximized;

            SetupAdminInterface();
        }

        private void SetupAdminInterface()
        {
            // Created in Designer //
            // Tab control

            SetupNavigationBar();

            // Setup tabs
            SetupUserManagementTab();
            SetupTourCategoriesTab();
            SetupPlatformAnalyticsTab();
            SetupReviewApprovalTab();
        }

        private void SetupNavigationBar()
        {
            // Created in Designer //
            // Navigation Bar
            // Logout button

            string firstName = "Admin";
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();
                string query = "SELECT first_name FROM users WHERE user_id = @userId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userid);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            firstName = reader["first_name"].ToString();
                        }
                    }
                }
            }
            string welcome_text = "Welcome, " + firstName + "!";
            welcome_label.Text = welcome_text;
        }

        private void SetupUserManagementTab()
        {
            // Created in Designer //
            // Grid Table for Trips
            // Added columns

            // Load pending registrations from the database
            LoadPendingRegistrations();

            // Button clicks
            usersGrid.CellClick += (s, e) =>
            {
                if (e.RowIndex < 0 || e.RowIndex == usersGrid.Rows.Count - 1)
                    return;

                int userId = Convert.ToInt32(usersGrid.Rows[e.RowIndex].Cells["UserId"].Value);
                if (e.ColumnIndex == usersGrid.Columns["Approve"].Index)
                {
                    string message = "Are you sure you want to approve user with Id " + userId.ToString() + "?";
                    if (MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
                        {
                            conn.Open();
                            // Update Users Table
                            string query = "UPDATE users " +
                                           "SET status = 'Approved' " +
                                           "WHERE user_id = @userId";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@userId", userId);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    loadAnalyticsData();
                }
                else if (e.ColumnIndex == usersGrid.Columns["Reject"].Index)
                {
                    string message = "Are you sure you want to reject user with Id " + userId.ToString() + "?";
                    if (MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
                        {
                            conn.Open();
                            // Update Users Table
                            string query = "UPDATE users " +
                                           "SET status = 'Rejected' " +
                                           "WHERE user_id = @userId";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@userId", userId);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    loadAnalyticsData();
                }
                LoadPendingRegistrations();
            };
        }

        private void LoadPendingRegistrations()
        {
            usersGrid.Rows.Clear();
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();
                string query = "SELECT user_id, first_name, last_name, email, user_type, registration_date, status " +
                               "FROM users " +
                               "WHERE status LIKE 'Pending%' OR status LIKE 'Rejected%' ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usersGrid.Rows.Add(reader["user_id"], reader["first_name"], reader["last_name"], reader["email"], reader["user_type"], reader["registration_date"], reader["status"]);
                        }
                    }
                }
            }
        }

        private void SetupTourCategoriesTab()
        {
            // Created in Designer //
            // Grid Table for Trips
            // Added columns
            // New Category Button

            // Add New Category button
            addCategoryButton.Click += (s, e) =>
            {
                ShowAddEditCategoryForm();
            };

            // Load tour categories
            LoadTourCategories();

            // Button clicks
            categoriesGrid.CellClick += (s, e) =>
            {
                if (e.RowIndex < 0 || e.RowIndex == categoriesGrid.Rows.Count - 1)
                    return;

                int categoryId = Convert.ToInt32(categoriesGrid.Rows[e.RowIndex].Cells["CategoryId"].Value);
                string categoryName = categoriesGrid.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();
                if (e.ColumnIndex == categoriesGrid.Columns["Edit"].Index)
                {
                    ShowAddEditCategoryForm(categoryId);
                }
                else if (e.ColumnIndex == categoriesGrid.Columns["Delete"].Index)
                {
                    string message = "Are you sure you want to delete the category \"" + categoryName + "\"?";
                    if (MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
                        {
                            conn.Open();
                            // Update Users Table
                            string query = "DELETE FROM tour_categories " +
                                           "WHERE category_id = @categoryId";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@categoryId", categoryId);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    LoadTourCategories();
                }
            };
        }

        private void LoadTourCategories()
        {
            categoriesGrid.Rows.Clear();
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS; Initial Catalog = TravelEase_Userfilled; Integrated Security = True; "))
            {
                conn.Open();

                string query = "SELECT category_id, category_name, description " +
                               "FROM tour_categories ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            categoriesGrid.Rows.Add(reader["category_id"].ToString(), reader["category_name"].ToString(), reader["description"].ToString());
                        }
                    }
                }
            }
        }

        private void ShowAddEditCategoryForm(int categoryId = -1)
        {
            string categoryName = "", description = "";
            if (categoryId > 0)
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS; Initial Catalog = TravelEase_Userfilled; Integrated Security = True; "))
                {
                    conn.Open();
                    string query = "SELECT category_name, description " +
                                   "FROM tour_categories " +
                                   "WHERE category_id = @categoryId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@categoryId", categoryId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                categoryName = reader["category_name"].ToString();
                                description = reader["description"].ToString();
                            }
                        }
                    }
                }
            }

            CategoryForm CategoryForm = new CategoryForm(categoryName, description);

            CategoryForm.saveButton.Click += (s, e) =>
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS; Initial Catalog = TravelEase_Userfilled; Integrated Security = True; "))
                {
                    conn.Open();
                    if (categoryId > 0) // that means we are editing category
                    {
                        string query = "UPDATE tour_categories " +
                                       "SET category_name = @categoryName, description = @desc " +
                                       "WHERE category_id = @categoryId ";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@categoryId", categoryId);
                            cmd.Parameters.AddWithValue("@categoryName", CategoryForm.catNameBox.Text.ToString());
                            cmd.Parameters.AddWithValue("@desc", CategoryForm.descriptionBox.Text.ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else    // Added new category
                    {
                        string query = "INSERT INTO tour_categories (category_name, description) " +
                                       "VALUES (@categoryName, @desc) ";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@categoryName", CategoryForm.catNameBox.Text.ToString());
                            cmd.Parameters.AddWithValue("@desc", CategoryForm.descriptionBox.Text.ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                CategoryForm.Close();
            };
            CategoryForm.ShowDialog();
            LoadTourCategories();
        }

        private void SetupPlatformAnalyticsTab()
        {
            // Created in Designer //
            // Penel
            // Labels and texts
            // Charts

            // Load metrics
            loadAnalyticsData();
        }
        

        private void loadAnalyticsData()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();
                // Total Users
                string usersQuery = "SELECT COUNT(*) FROM users WHERE status = 'Approved'";
                using (SqlCommand cmd = new SqlCommand(usersQuery, conn))
                {
                    totalUsersLabel.Text = cmd.ExecuteScalar().ToString();
                }

                // Total Bookings
                string bookingsQuery = "SELECT COUNT(*) FROM booking";
                using (SqlCommand cmd = new SqlCommand(bookingsQuery, conn))
                {
                    totalBookingsLabel.Text = cmd.ExecuteScalar().ToString();
                }

                // Total Revenue
                string revenueQuery = "SELECT SUM(amount) FROM payment";
                using (SqlCommand cmd = new SqlCommand(revenueQuery, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result == DBNull.Value)
                        totalRevenueLabel.Text = "0";
                    else
                    {
                        string str = "Rs. " + Convert.ToDecimal(result).ToString();
                        totalRevenueLabel.Text = str;
                    }
                }
            }

            // Load booking trends (Bookings per Month)
            bookingChart.Series["series"].Points.Clear();
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();
                string query = "SELECT DATEPART(MONTH, date_booked) AS Month, COUNT(*) AS BookingCount " +
                               "FROM booking " +
                               "GROUP BY DATEPART(MONTH, date_booked)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bookingChart.Series["series"].Points.AddXY(reader["Month"], reader["BookingCount"]);
                        }
                    }
                }
            }
        }

        private void SetupReviewApprovalTab()
        {
            // Created in Designer //
            // Grid Table for Trips
            // Added columns

            // TRIP REVIEWS //
            // Load reviews
            LoadTripReviews();

            // Button clicks
            tripReviewsGrid.CellClick += (s, e) =>
            {
                if (e.RowIndex < 0 || e.RowIndex == tripReviewsGrid.Rows.Count - 1)
                    return;

                int tripReviewId = Convert.ToInt32(tripReviewsGrid.Rows[e.RowIndex].Cells["tripReviewID"].Value);
                if (e.ColumnIndex == tripReviewsGrid.Columns["tripApprove_rev"].Index)
                {
                    string message = "Are you sure you want to approve review with Id " + tripReviewId.ToString() + "?";
                    if (MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
                        {
                            conn.Open();
                            string query = "UPDATE trip_reviews " +
                                           "SET status = 'Approved' " +
                                           "WHERE trip_review_id = @reviewId";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@reviewId", tripReviewId);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                else if (e.ColumnIndex == tripReviewsGrid.Columns["tripReject_rev"].Index)
                {
                    string message = "Are you sure you want to reject review with Id " + tripReviewId.ToString() + "?";
                    if (MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
                        {
                            conn.Open();
                            string query = "UPDATE trip_reviews " +
                                           "SET status = 'Rejected' " +
                                           "WHERE trip_review_id = @reviewId";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@reviewId", tripReviewId);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                LoadTripReviews();
            };




            // OPERATOR REVIEWS //
            // Load reviews
            LoadOperatorReviews();

            // Button clicks
            operatorReviewsGrid.CellClick += (s, e) =>
            {
                if (e.RowIndex < 0 || e.RowIndex == operatorReviewsGrid.Rows.Count - 1)
                    return;

                int operatorReviewId = Convert.ToInt32(operatorReviewsGrid.Rows[e.RowIndex].Cells["operatorReviewID"].Value);
                if (e.ColumnIndex == operatorReviewsGrid.Columns["operatorApprove_rev"].Index)
                {
                    string message = "Are you sure you want to approve review with Id " + operatorReviewId.ToString() + "?";
                    if (MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
                        {
                            conn.Open();
                            string query = "UPDATE operator_reviews " +
                                           "SET status = 'Approved' " +
                                           "WHERE operator_review_id = @reviewId";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@reviewId", operatorReviewId);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                else if (e.ColumnIndex == operatorReviewsGrid.Columns["operatorReject_rev"].Index)
                {
                    string message = "Are you sure you want to reject review with Id " + operatorReviewId.ToString() + "?";
                    if (MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
                        {
                            conn.Open();
                            string query = "UPDATE operator_reviews " +
                                           "SET status = 'Rejected' " +
                                           "WHERE operator_review_id = @reviewId";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@reviewId", operatorReviewId);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                LoadOperatorReviews();
            };
        }

        private void LoadTripReviews()
        {
            tripReviewsGrid.Rows.Clear();
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();
                string query = "SELECT trip_review_id, trip_id, traveller_id, rating, comments, status " +
                               "FROM trip_reviews";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tripReviewsGrid.Rows.Add(reader["trip_review_id"], reader["trip_id"], reader["traveller_id"], reader["rating"], reader["comments"], reader["status"]);
                        }
                    }
                }
            }
        }

        private void LoadOperatorReviews()
        {
            operatorReviewsGrid.Rows.Clear();
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();
                string query = "SELECT operator_review_id, operator_id, traveller_id, rating, comments, status " +
                               "FROM operator_reviews";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            operatorReviewsGrid.Rows.Add(reader["operator_review_id"], reader["operator_id"], reader["traveller_id"], reader["rating"], reader["comments"], reader["status"]);
                        }
                    }
                }
            }
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void user_profilepic_Click(object sender, EventArgs e)
        {
            if (dp_select_panel.Visible)
                dp_select_panel.Visible = false;
            else
                dp_select_panel.Visible = true;
        }

        private void dp1_Click(object sender, EventArgs e)
        {
            user_profilepic.Image = DB_Project.Properties.Resources.dp3;
        }

        private void dp2_Click(object sender, EventArgs e)
        {
            user_profilepic.Image = DB_Project.Properties.Resources.dp4;
        }

        private void dp3_Click(object sender, EventArgs e)
        {
            user_profilepic.Image = DB_Project.Properties.Resources.dp1;
        }

        private void dp4_Click(object sender, EventArgs e)
        {
            user_profilepic.Image = DB_Project.Properties.Resources.dp2;
        }

        private void dp0_Click(object sender, EventArgs e)
        {
            user_profilepic.Image = DB_Project.Properties.Resources.def_dp;
        }

        private void totalRevenueLabel_Click(object sender, EventArgs e)
        {

        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
