using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DB_Project
{
    public partial class TravellerDashboardForm : Form
    {
        string user_email;
        int userId;
        //Panel navbar_panel;        // created in designer
        //TabControl tab_control;   // created in designer
        TabPage profile_tab;       // created here

        public TravellerDashboardForm(int id)
        {
            InitializeComponent();

            userId = id;
            this.WindowState = FormWindowState.Maximized;

            SetupInterface();
        }

        private void SetupInterface()
        {
            // Initializing interface
            SetupNavigationBar();

            SetupTripSearchTab();
            SetupTripDashboardTab();
            //SetupTripBookTab();
            SetupTravelPassTab();
            SetupReviewsTab();
            SetupProfileTab();

        }

        private void SetupNavigationBar()
        {
            // Navigation panel created in designer

            string firstName = "Traveler";
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();
                string query = "SELECT first_name FROM users WHERE user_id = @userId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            firstName = reader["first_name"].ToString();
                        }
                    }
                }
            }
            welcome_label.Text = "Welcome, " + firstName + "!";
        }

        private void SetupTripSearchTab()
        {
            // Created in Designer //
            // Search Tab
            // Filters panel
            // Labels and Boxes
            // Search button
            // Grid Table for Trips
            // Added columns

            bool checkDest, checkStdate, checkminp, checkmaxp, checkactivity, checkgsize;


            // SEARCH Button Click Event
            searchButton.Click += (s, e) =>
            {
                checkDest = false;
                checkStdate = false;
                checkminp = false;
                checkmaxp = false;
                checkactivity = false;
                checkgsize = false;

                if (!string.IsNullOrWhiteSpace(destinationBox.Text) && destinationcheckBox.Checked)
                    checkDest = true;
                if(pricecheckBox.Checked)
                {
                    checkminp = true;
                    checkmaxp = true;
                }
                if (!string.IsNullOrWhiteSpace(activityTypeBox.Text) && acttypecheckBox.Checked)
                    checkactivity = true;
                if (stdatecheckBox.Checked)
                    checkStdate = true;
                if (gsizecheckBox.Checked)
                    checkgsize = true;

                tripsGrid.Rows.Clear();
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
                {
                    conn.Open();
                    string query = "SELECT trip_id, destination, start_date, duration, price, activity_type, group_size " +
                                   "FROM trips " +
                                   "WHERE 1 = 1";

                    if (checkDest)
                        query += " AND destination LIKE @dest";
                    if (checkStdate)
                        query += " AND start_date = @st_date";
                    if (checkminp)
                        query += " AND price >= @minprice";
                    if (checkmaxp)
                        query += " AND price <= @maxprice";
                    if (checkactivity)
                        query += " AND activity_type = @activity";
                    if (checkgsize)
                        query += " AND group_size = @gsize";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters only if the filter is applied
                        if (checkDest)
                            cmd.Parameters.AddWithValue("@dest", "%" + destinationBox.Text.Trim() + "%");
                        if (checkStdate)
                            cmd.Parameters.AddWithValue("@st_date", startDatePicker.Value.Date);
                        if (checkminp)
                            cmd.Parameters.AddWithValue("@minprice", (decimal)MinPriceBox.Value);
                        if (checkmaxp)
                            cmd.Parameters.AddWithValue("@maxprice", (decimal)MaxPriceBox.Value);
                        if (checkactivity)
                            cmd.Parameters.AddWithValue("@activity", activityTypeBox.Text);
                        if (checkgsize)
                            cmd.Parameters.AddWithValue("@gsize", (int)groupSizeBox.Value);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tripsGrid.Rows.Add(reader["trip_id"].ToString(), reader["destination"].ToString(), Convert.ToDateTime(reader["start_date"]).ToString("yyyy-MM-dd"), reader["duration"].ToString(), reader["price"].ToString(), reader["activity_type"].ToString(), reader["group_size"].ToString());
                            }
                        }
                    }
                }
            };

            tripsGrid.CellClick += (s, e) =>
            {
                if (e.RowIndex < 0 || e.RowIndex == tripsGrid.Rows.Count - 1)
                    return;

                int tripId = Convert.ToInt32(tripsGrid.Rows[e.RowIndex].Cells["TripId"].Value),
                    bookingId = 0;
                if (e.ColumnIndex == tripsGrid.Columns["BookTrip"].Index)
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
                    {
                        conn.Open();

                        // Inserting in Booking table
                        string query = "INSERT INTO booking (date_booked) " +
                                       "OUTPUT INSERTED.booking_id " +
                                       "VALUES (GETDATE())";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            bookingId = (int)cmd.ExecuteScalar();
                        }

                        // Inserting in Books
                        query = "INSERT INTO books (trip_id, booking_id, traveller_id) " +
                                "VALUES(@tripid, @bookingid, @travellerid)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Add parameters
                            cmd.Parameters.AddWithValue("@tripid", tripId);
                            cmd.Parameters.AddWithValue("@bookingid", bookingId);
                            cmd.Parameters.AddWithValue("@travellerid", userId);
                            cmd.ExecuteNonQuery();
                        }
                        //MessageBox.Show("Trip Booked!\nNow Waiting for approval", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };
                string message = "Trip with booking id " + bookingId.ToString() + " has been booked successfully!";
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadMyTrips();
            };
        }

        private void loadMyTrips()
        {
            myTripsGrid.Rows.Clear();
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();
                string query = "SELECT bk.booking_id, t.trip_id, destination, start_date, activity_type, duration, price, group_size, bk.book_status, itinery " +
                               "FROM trips t " +
                               "JOIN books b ON t.trip_id = b.trip_id " +
                               "JOIN booking bk ON bk.booking_id = b.booking_id " +
                               "WHERE b.traveller_id = @travellerId AND CAST(t.start_date AS DATE) >= CAST(GETDATE() AS DATE) ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@travellerId", userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            myTripsGrid.Rows.Add(reader["booking_id"].ToString(), reader["trip_id"].ToString(), reader["destination"].ToString(), Convert.ToDateTime(reader["start_date"]).ToString("yyyy-MM-dd"), reader["activity_type"].ToString(), reader["duration"].ToString(), reader["price"].ToString(), reader["group_size"].ToString(), reader["itinery"].ToString(), reader["book_status"].ToString());
                        }
                    }
                }
            }
        }

        private void SetupTripDashboardTab()
        {
            // Created in Designer //
            // My Trips Tab
            // Grid Table for Trips
            // Added columns


            //// Load upcoming trips
            loadMyTrips();

            //// Handle View Cancel
            myTripsGrid.CellClick += (s, e) =>
            {
                if (e.RowIndex < 0 || e.RowIndex == myTripsGrid.Rows.Count - 1)
                    return;

                int bookingId = Convert.ToInt32(myTripsGrid.Rows[e.RowIndex].Cells["mytripsBookingId"].Value);
                if(e.ColumnIndex == myTripsGrid.Columns["mytripsCancel"].Index)
                {
                    string message = "Are you sure you want to cancel trip with booking Id " + bookingId.ToString() + "?";
                    if (MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
                        {
                            conn.Open();
                            // Update Bookings Table
                            string query = "UPDATE booking " +
                                           "SET book_status = 'cancelled' " +
                                           "WHERE booking_id = @bookingId";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@bookingId", bookingId);
                                cmd.ExecuteNonQuery();
                            }

                            /*   
                            // Update Trips Table
                            query = "UPDATE t " +
                                    "SET t.status = 'Cancelled' " +
                                    "FROM trips t " +
                                    "JOIN books b ON b.trip_id = t.trip_id " +
                                    "WHERE b.booking_id = @bookingId ";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@bookingId", bookingId);
                                cmd.ExecuteNonQuery();
                            }
                            */

                            // Update Books Table
                            query = "DELETE FROM books " +
                                    "WHERE booking_id = @bookingId";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@bookingId", bookingId);
                                //cmd.ExecuteNonQuery();
                            }
                        }
                        loadMyTrips();
                        message = "Trip with booking id " + bookingId.ToString() + " has been cancelled successfully!";
                        MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            };
        }

        /*
        private void LoadBookTrips()
        {
            bookTripsGrid.Rows.Clear();
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();
                string query = "SELECT t.trip_id, destination, start_date, activity_type, duration, price, group_size, itinery, bk.book_status " +
                               "FROM trips t " +
                               "JOIN books b ON t.trip_id = b.trip_id " +
                               "JOIN booking bk ON bk.booking_id = b.booking_id " +
                               "WHERE b.traveller_id = @travellerId AND bk.book_status = 'pending'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@travellerId", userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bookTripsGrid.Rows.Add(reader["trip_id"].ToString(), reader["destination"].ToString(), Convert.ToDateTime(reader["start_date"]).ToString("yyyy-MM-dd"), reader["activity_type"].ToString(), reader["duration"].ToString(), reader["price"].ToString(), reader["group_size"].ToString(), reader["itinery"].ToString(), reader["book_status"].ToString());
                        }
                    }
                }
            }
        }

        private void SetupTripBookTab()
        {
            // Created in Designer //
            // Book Tab
            // Booking panel
            // Labels and Boxes
            // Book button
            // Grid Table for Trips
            // Added columns

            bool checkStdate, checkactivity, checkItinerary;


            LoadBookTrips();
            // in click event call this func again


            // BOOK Button Click Event
            bookButton.Click += (s, e) =>
            {
                checkStdate = true;
                checkactivity = true;
                checkItinerary = true;

                if (string.IsNullOrWhiteSpace(bookDestinationBox.Text))
                {
                    MessageBox.Show("Please select a destination.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(bookDatePicker.Text))
                {
                    //MessageBox.Show("Please select a start date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                    checkStdate = false;
                }
                if (string.IsNullOrWhiteSpace(bookPriceBox.Text))
                {
                    MessageBox.Show("Please select the price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(bookActivityBox.Text))
                {
                    //MessageBox.Show("Please select an activity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                    checkactivity = false;
                }
                if (string.IsNullOrWhiteSpace(bookGSizeBox.Text))
                {
                    MessageBox.Show("Please select the group size.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(bookDurationBox.Text))
                {
                    MessageBox.Show("Please select the duration in hours.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(bookItineraryBox.Text))
                {
                    //MessageBox.Show("Please write the itinerary.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                    checkItinerary = false;
                }

                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
                {
                    conn.Open();
                    
                    // Inserting in Trips
                    string query = "INSERT INTO trips (destination, start_date, activity_type, duration, price, group_size, itinery) " +
                                   "OUTPUT INSERTED.trip_id " +
                                   "VALUES(@dest, @stDate, @actType, @dur, @price, @gsize, @it)";
                    int tripId;
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@dest", bookDestinationBox.Text);
                        if (checkStdate)
                            cmd.Parameters.AddWithValue("@stDate", bookDatePicker.Value.Date);
                        else
                            cmd.Parameters.AddWithValue("@stDate", DBNull.Value);
                        if (checkactivity)
                            cmd.Parameters.AddWithValue("@actType", bookActivityBox.Text);
                        else
                            cmd.Parameters.AddWithValue("@actType", DBNull.Value);
                        cmd.Parameters.AddWithValue("@dur", (int)bookDurationBox.Value);
                        cmd.Parameters.AddWithValue("@price", (decimal)bookPriceBox.Value);
                        cmd.Parameters.AddWithValue("@gsize", (int)bookGSizeBox.Value);
                        if (checkItinerary)
                            cmd.Parameters.AddWithValue("@it", bookItineraryBox.Text);
                        else
                            cmd.Parameters.AddWithValue("@it", DBNull.Value);

                        tripId = (int)cmd.ExecuteScalar();
                    }

                    // Inserting in Booking table
                    query = "INSERT INTO booking (date_booked) " +
                            "OUTPUT INSERTED.booking_id " +
                            "VALUES (GETDATE())";
                    int bookingId;
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        bookingId = (int)cmd.ExecuteScalar();
                    }

                    // Inserting in Books
                    query = "INSERT INTO books (trip_id, booking_id, traveller_id) " +
                                   "VALUES(@tripid, @bookingid, @travellerid)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@tripid", tripId);
                        cmd.Parameters.AddWithValue("@bookingid", bookingId);
                        cmd.Parameters.AddWithValue("@travellerid", userId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Trip Booked!\nNow Waiting for approval", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadBookTrips();
                }
            };
        }
        */

        // Class for ComboBox items
        public class TripItem
        {
            public int TripId 
            { 
                get; 
                set; 
            }
            public string Destination 
            { 
                get; 
                set; 
            }
            public override string ToString()
            {
                return Destination;
            }
        }

        private void SetupTravelPassTab()
        {
            // Created in Designer //
            // Travel Pass Tab
            // Labels and Boxes
            // Grid Table for Trips

            bool isLoading = true;

            //// Load trips into ComboBox
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();
                string query = "SELECT b.trip_id, t.destination " +
                               "FROM books b " +
                               "JOIN trips t ON b.trip_id = t.trip_id " +
                               "JOIN booking bk ON b.booking_id = bk.booking_id " +
                               "WHERE b.traveller_id = @travellerId AND bk.book_status LIKE 'confirmed%'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@travellerId", userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        tripSelector.DisplayMember = "Destination";
                        tripSelector.ValueMember = "TripId";
                        while (reader.Read())
                        {
                            tripSelector.Items.Add(new TripItem{
                                                                   TripId = reader.GetInt32(0),
                                                                   Destination = reader["destination"].ToString()
                                                               }
                                                  );
                            Console.WriteLine($"Added item: TripId={reader.GetInt32(0)}, Destination={reader["destination"]}");
                        }
                        Console.WriteLine($"Items added: {tripSelector.Items.Count}");
                        //if (tripSelector.Items.Count > 0)
                        //    tripSelector.SelectedIndex = 0;
                    }
                }
            }
            isLoading = false;

            //// Show travel pass details when a trip is selected
            tripSelector.SelectedIndexChanged += (s, e) =>
            {
                if (isLoading || tripSelector.SelectedItem == null)
                    return;
                TripItem selectedTrip = (TripItem)tripSelector.SelectedItem;
                int tripId = selectedTrip.TripId;

                //MessageBox.Show($"Selected TripId: {tripId}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
                {
                    conn.Open();
                    string query = "SELECT dp.pass_id, t.ticket_number, v.voucher_number, v.room_number, ap.Activity_name, ap.timing " +
                                   " FROM books " +
                                   " JOIN booking bk ON books.booking_id = bk.booking_id " +
                                   " JOIN digital_pass dp ON dp.pass_id = bk.pass_id " +
                                   " LEFT JOIN ticket t ON t.pass_id = dp.pass_id " +
                                   " LEFT JOIN voucher v ON v.pass_id = dp.pass_id " +
                                   " LEFT JOIN activity_pass ap ON ap.pass_id = dp.pass_id " +
                                   " WHERE books.traveller_id = @travellerId AND books.trip_id = @tripId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@travellerId", userId);
                        cmd.Parameters.AddWithValue("@tripId", tripId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            string t_num = "N/A",
                                   v_num = "N/A",
                                   room_num = "N/A",
                                   a_name = "N/A",
                                   timing = "N/A";

                            if (reader.Read())
                            {
                                if (reader["ticket_number"] != DBNull.Value)
                                    t_num = reader["ticket_number"].ToString();
                                if (reader["voucher_number"] != DBNull.Value)
                                    v_num = reader["voucher_number"].ToString();
                                if (reader["room_number"] != DBNull.Value)
                                    room_num = reader["room_number"].ToString();
                                if (reader["Activity_name"] != DBNull.Value)
                                    a_name = reader["Activity_name"].ToString();
                                if (reader["timing"] != DBNull.Value)
                                    timing = reader["timing"].ToString();
                            }
                            eticket_text.Text = t_num;
                            voucher_text.Text = "Voucher Number: " + v_num + ",  Room Number: " + room_num;
                            apass_text.Text = "Activity Name: " + a_name + ",  Timings: " + timing;
                        }
                    }

                };
            };
        }

        public class OperatorItem
        {
            public int OperatorId
            {
                get;
                set;
            }
            public string FullName
            {
                get;
                set;
            }
            public override string ToString()
            {
                return FullName;
            }
        }
        
        public class TravelHistoryEntry
        {
            public int TravellerId 
            { get; set; }
            public int TripId 
            { get; set; }
            public DateTime TravelDate 
            { get; set; }
        }

        private void SetupReviewsTab()
        {
            // Created in Designer //
            // Reviews Tab
            // Labels and Boxes
            // Submit button

            // TRIP REVIEWS //
            // Rating Options
            int ratingValue = 1;
            star1.Click += (s, e) =>
            {
                ratingValue = 1;
                star1.Image = DB_Project.Properties.Resources.stars;
                star2.Image = DB_Project.Properties.Resources.faded_star;
                star3.Image = DB_Project.Properties.Resources.faded_star;
                star4.Image = DB_Project.Properties.Resources.faded_star;
                star5.Image = DB_Project.Properties.Resources.faded_star;
            };
            star2.Click += (s, e) =>
            {
                ratingValue = 2;
                star1.Image = DB_Project.Properties.Resources.stars;
                star2.Image = DB_Project.Properties.Resources.stars;
                star3.Image = DB_Project.Properties.Resources.faded_star;
                star4.Image = DB_Project.Properties.Resources.faded_star;
                star5.Image = DB_Project.Properties.Resources.faded_star;
            };
            star3.Click += (s, e) =>
            {
                ratingValue = 3;
                star1.Image = DB_Project.Properties.Resources.stars;
                star2.Image = DB_Project.Properties.Resources.stars;
                star3.Image = DB_Project.Properties.Resources.stars;
                star4.Image = DB_Project.Properties.Resources.faded_star;
                star5.Image = DB_Project.Properties.Resources.faded_star;
            };
            star4.Click += (s, e) =>
            {
                ratingValue = 4;
                star1.Image = DB_Project.Properties.Resources.stars;
                star2.Image = DB_Project.Properties.Resources.stars;
                star3.Image = DB_Project.Properties.Resources.stars;
                star4.Image = DB_Project.Properties.Resources.stars;
                star5.Image = DB_Project.Properties.Resources.faded_star;
            };
            star5.Click += (s, e) =>
            {
                ratingValue = 5;
                star1.Image = DB_Project.Properties.Resources.stars;
                star2.Image = DB_Project.Properties.Resources.stars;
                star3.Image = DB_Project.Properties.Resources.stars;
                star4.Image = DB_Project.Properties.Resources.stars;
                star5.Image = DB_Project.Properties.Resources.stars;
            };

            bool isLoading = true;

            //// Update trips to make it into Trip History
            List<TravelHistoryEntry> entries = new List<TravelHistoryEntry>();
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();
                string query = "SELECT b.traveller_id, t.trip_id, t.start_date " +
                               "FROM trips t " +
                               "JOIN books b ON b.trip_id = t.trip_id " +
                               "WHERE CAST(DATEADD(DAY, t.duration, t.start_date) AS DATE) <= CAST(GETDATE() AS DATE) " +
                               "      AND NOT EXISTS (SELECT 1 FROM travel_history th WHERE th.traveller_id = b.traveller_id AND th.trip_id = b.trip_id)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            entries.Add(new TravelHistoryEntry
                            {
                                TravellerId = Convert.ToInt32(reader["traveller_id"]),
                                TripId = Convert.ToInt32(reader["trip_id"]),
                                TravelDate = Convert.ToDateTime(reader["start_date"])
                            });
                        }
                    }
                }

                foreach (var entry in entries)
                {
                    string query2 = "INSERT INTO travel_history (traveller_id, trip_id, travel_date) " +
                                    "VALUES (@travellerId, @tripId, @travelDate)";

                    using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                    {
                        cmd2.Parameters.AddWithValue("@travellerId", entry.TravellerId);
                        cmd2.Parameters.AddWithValue("@tripId", entry.TripId);
                        cmd2.Parameters.AddWithValue("@travelDate", entry.TravelDate.Date);
                        cmd2.ExecuteNonQuery();
                    }
                }
            }

            //// Load past trips from travel_history
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();
                string query = @"SELECT th.trip_id, t.destination 
                                 FROM trips t 
                                 JOIN travel_history th ON th.trip_id = t.trip_id
                                 WHERE th.traveller_id = @travellerId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@travellerId", userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        tripSelectorRev.DisplayMember = "Destination";
                        tripSelectorRev.ValueMember = "TripId";
                        while (reader.Read())
                        {
                            tripSelectorRev.Items.Add(new TripItem
                            {
                                TripId = reader.GetInt32(0),
                                Destination = reader["destination"].ToString()
                            }
                                                  );
                        }
                        //if (tripSelectorRev.Items.Count > 0)
                        //    tripSelectorRev.SelectedIndex = 0;
                    }
                }
            }
            isLoading = false;

            //// Submit review
            submitButton.Click += (s, e) =>
            {
                if (tripSelectorRev.SelectedItem == null || string.IsNullOrWhiteSpace(reviewBox.Text) || isLoading)
                {
                    MessageBox.Show("Please select a trip and write a review.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                TripItem selectedTrip = (TripItem)tripSelectorRev.SelectedItem;
                int tripId = selectedTrip.TripId;

                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
                {
                    conn.Open();
                    string query = "INSERT INTO trip_reviews (traveller_id, trip_id, rating, comments) " +
                                   "VALUES (@travellerId, @tripId, @rating, @comments)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@travellerId", userId);
                        cmd.Parameters.AddWithValue("@tripId", tripId);
                        cmd.Parameters.AddWithValue("@rating", ratingValue);
                        cmd.Parameters.AddWithValue("@comments", reviewBox.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Review submitted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Resetting Reviews Tab
                reviewBox.Clear();
                ratingValue = 1;
                star1.Image = DB_Project.Properties.Resources.stars;
                star2.Image = DB_Project.Properties.Resources.faded_star;
                star3.Image = DB_Project.Properties.Resources.faded_star;
                star4.Image = DB_Project.Properties.Resources.faded_star;
                star5.Image = DB_Project.Properties.Resources.faded_star;
                tripSelectorRev.SelectedIndex = -1;
            };



            // OPERATOR REVIEWS //
            // Rating Options
            ratingValue = 1;
            star1Op.Click += (s, e) =>
            {
                ratingValue = 1;
                star1Op.Image = DB_Project.Properties.Resources.stars;
                star2Op.Image = DB_Project.Properties.Resources.faded_star;
                star3Op.Image = DB_Project.Properties.Resources.faded_star;
                star4Op.Image = DB_Project.Properties.Resources.faded_star;
                star5Op.Image = DB_Project.Properties.Resources.faded_star;
            };
            star2Op.Click += (s, e) =>
            {
                ratingValue = 2;
                star1Op.Image = DB_Project.Properties.Resources.stars;
                star2Op.Image = DB_Project.Properties.Resources.stars;
                star3Op.Image = DB_Project.Properties.Resources.faded_star;
                star4Op.Image = DB_Project.Properties.Resources.faded_star;
                star5Op.Image = DB_Project.Properties.Resources.faded_star;
            };
            star3Op.Click += (s, e) =>
            {
                ratingValue = 3;
                star1Op.Image = DB_Project.Properties.Resources.stars;
                star2Op.Image = DB_Project.Properties.Resources.stars;
                star3Op.Image = DB_Project.Properties.Resources.stars;
                star4Op.Image = DB_Project.Properties.Resources.faded_star;
                star5Op.Image = DB_Project.Properties.Resources.faded_star;
            };
            star4Op.Click += (s, e) =>
            {
                ratingValue = 4;
                star1Op.Image = DB_Project.Properties.Resources.stars;
                star2Op.Image = DB_Project.Properties.Resources.stars;
                star3Op.Image = DB_Project.Properties.Resources.stars;
                star4Op.Image = DB_Project.Properties.Resources.stars;
                star5Op.Image = DB_Project.Properties.Resources.faded_star;
            };
            star5Op.Click += (s, e) =>
            {
                ratingValue = 5;
                star1Op.Image = DB_Project.Properties.Resources.stars;
                star2Op.Image = DB_Project.Properties.Resources.stars;
                star3Op.Image = DB_Project.Properties.Resources.stars;
                star4Op.Image = DB_Project.Properties.Resources.stars;
                star5Op.Image = DB_Project.Properties.Resources.stars;
            };

            isLoading = true;

            //// Load operators
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();
                string query = @"SELECT u.user_id, CONCAT(u.first_name, ' ', u.last_name) as full_name 
                                 FROM users u 
                                 JOIN operator o ON o.user_id = u.user_id 
                                 JOIN trips t ON t.operator_id = o.user_id 
                                 JOIN travel_history th ON th.trip_id = t.trip_id
                                 WHERE th.traveller_id = @travellerId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@travellerId", userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        tripSelectorRevOp.DisplayMember = "full_name";
                        tripSelectorRevOp.ValueMember = "user_id";
                        while (reader.Read())
                        {
                            tripSelectorRevOp.Items.Add(new OperatorItem
                            {
                                OperatorId = reader.GetInt32(0),
                                FullName = reader["full_name"].ToString()
                            }
                            );
                        }
                        //if (tripSelectorRevOp.Items.Count > 0)
                        //    tripSelectorRevOp.SelectedIndex = 0;
                    }
                }
            }
            isLoading = false;

            //// Submit review
            submitButtonOp.Click += (s, e) =>
            {
                if (tripSelectorRevOp.SelectedItem == null || string.IsNullOrWhiteSpace(reviewBoxOp.Text) || isLoading)
                {
                    MessageBox.Show("Please select an operator and write a review.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                OperatorItem selectedTrip = (OperatorItem)tripSelectorRevOp.SelectedItem;
                int operatorId = selectedTrip.OperatorId;

                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
                {
                    conn.Open();
                    string query = "INSERT INTO operator_reviews (operator_id, traveller_id, comments, rating) " +
                                   "VALUES (@operatorId, @tripId, @comments, @rating)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@operatorId", operatorId);
                        cmd.Parameters.AddWithValue("@tripId", userId);
                        cmd.Parameters.AddWithValue("@rating", ratingValue);
                        cmd.Parameters.AddWithValue("@comments", reviewBoxOp.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Review submitted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Resetting Reviews Tab
                reviewBoxOp.Clear();
                ratingValue = 1;
                star1Op.Image = DB_Project.Properties.Resources.stars;
                star2Op.Image = DB_Project.Properties.Resources.faded_star;
                star3Op.Image = DB_Project.Properties.Resources.faded_star;
                star4Op.Image = DB_Project.Properties.Resources.faded_star;
                star5Op.Image = DB_Project.Properties.Resources.faded_star;
                tripSelectorRevOp.SelectedIndex = -1;
            };
        }

        private void SetupProfileTab()
        {
            // Created in Designer //
            // Profile Tab
            // Profile Details panel
            // Labels and Boxes
            // Update button
            // Grid Table for Travel History


            //// Load profile data
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();
                string query = "SELECT u.first_name, u.last_name, u.email, u.phone, t.dob, t.nationality " +
                               "FROM users u " +
                               "JOIN traveller t ON t.user_id = u.user_id " +
                               "WHERE u.user_id = @userId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            fnameBox.Text = reader["first_name"].ToString();
                            lnameBox.Text = reader["last_name"].ToString();
                            emailBox.Text = reader["email"].ToString();
                            if (reader["phone"] != DBNull.Value)
                                phoneBox.Text = reader["phone"].ToString();
                            if (reader["nationality"] != DBNull.Value)
                                nationalityBox.Text = reader["nationality"].ToString();
                            if (reader["dob"] != DBNull.Value)
                                dobBox.Value = (DateTime)reader["dob"];
                        }
                    }
                }
            }

            //// Update profile
            updateButton.Click += (s, e) =>
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
                {
                    conn.Open();

                    // Update users table
                    string query1 = "UPDATE users " +
                                    "SET first_name = @fname, last_name = @lname, phone = @phone " +
                                    "WHERE user_id = @userId";
                    using (SqlCommand cmd = new SqlCommand(query1, conn))
                    {
                        cmd.Parameters.AddWithValue("@fname", fnameBox.Text);
                        cmd.Parameters.AddWithValue("@lname", lnameBox.Text);
                        cmd.Parameters.AddWithValue("@phone", phoneBox.Text);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.ExecuteNonQuery();
                    }

                    // Update traveller table
                    string query2 = "UPDATE traveller " +
                                    "SET nationality = @nationality, dob = @dob " +
                                    "WHERE user_id = @userId";
                    using (SqlCommand cmd = new SqlCommand(query2, conn))
                    {
                        cmd.Parameters.AddWithValue("@nationality", nationalityBox.Text);
                        cmd.Parameters.AddWithValue("@dob", dobBox.Value);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Profile updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            //// Update Travel history
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();

                List<(int TripId, DateTime StartDate)> trips = new List<(int, DateTime)>();
                string query1 = "SELECT t.trip_id, t.start_date " +
                                "FROM trips t " +
                                "JOIN books b ON t.trip_id = b.trip_id " +
                                "WHERE b.traveller_id = @userId AND t.status = 'Done'";

                using (SqlCommand cmd1 = new SqlCommand(query1, conn))
                {
                    cmd1.Parameters.AddWithValue("@userId", userId);
                    using (SqlDataReader reader = cmd1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int tripId = (int)reader["trip_id"];
                            DateTime startDate = reader.GetDateTime(reader.GetOrdinal("start_date"));
                            trips.Add((tripId, startDate));
                        }
                    }
                }

                foreach (var trip in trips)
                {
                    int tripId = trip.TripId;
                    DateTime startDate = trip.StartDate;

                    string query2 = "SELECT 1 " +
                                    "FROM travel_history th " +
                                    "JOIN trips t ON t.trip_id = th.trip_id " +
                                    "WHERE th.trip_id = @tripId";

                    using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                    {
                        cmd2.Parameters.AddWithValue("@tripId", tripId);
                        using (SqlDataReader reader2 = cmd2.ExecuteReader())
                        {
                            if (reader2.Read())
                            {
                                continue;
                            }
                        }
                    }

                    string query3 = "INSERT INTO travel_history (traveller_id, trip_id, travel_date) " +
                                    "VALUES (@travellerId, @tripId, @travelDate)";

                    using (SqlCommand cmd3 = new SqlCommand(query3, conn))
                    {
                        cmd3.Parameters.AddWithValue("@travellerId", userId);
                        cmd3.Parameters.AddWithValue("@tripId", tripId);
                        cmd3.Parameters.AddWithValue("@travelDate", startDate);
                        cmd3.ExecuteNonQuery();
                    }
                }
            }


            //// Travel History Grid
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-19TDJ6L\\SQLEXPRESS;Initial Catalog=TravelEase_Userfilled;Integrated Security=True;"))
            {
                conn.Open();
                string query = "SELECT th.trip_id, t.destination, th.travel_date " +
                               "FROM travel_history th " +
                               "JOIN trips t ON th.trip_id = t.trip_id " +
                               "WHERE th.traveller_id = @travellerId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@travellerId", userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            historyGrid.Rows.Add(
                                                reader["trip_id"].ToString(),
                                                reader["destination"].ToString(),
                                                Convert.ToDateTime(reader["travel_date"]).ToShortDateString()
                                                );
                        }
                    }
                }
            }
        }


        private void TravellerDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void user_profilepic_Click(object sender, EventArgs e)
        {
            if (dp_select_panel.Visible)
                dp_select_panel.Visible = false;
            else
                dp_select_panel.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            user_profilepic.Image = Properties.Resources.dp3;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            user_profilepic.Image = Properties.Resources.dp4;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            user_profilepic.Image = Properties.Resources.dp1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            user_profilepic.Image = Properties.Resources.dp2;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            user_profilepic.Image = Properties.Resources.def_dp;
        }

        private void profile_button_Click(object sender, EventArgs e)
        {
            
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        private void tripsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void MaxPriceBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gsizecheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
