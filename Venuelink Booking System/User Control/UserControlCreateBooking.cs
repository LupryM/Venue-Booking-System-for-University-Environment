using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Diagnostics.Metrics;
using System.Collections;

namespace Venuelink_Booking_System.User_Control
{
    public partial class UserControlCreateBooking : UserControl
    {

        private OleDbConnection connection = new OleDbConnection();


        public UserControlCreateBooking()
        {
            InitializeComponent();

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\austi\Downloads\VenueLink.accdb;Persist Security Info=False;";

        }

        public void LoadFromDataBaseCreateBooking()
        {
            ClearForm();
            //Load Category ComboBox
            connection.Open();
            OleDbCommand commandCategory = new OleDbCommand();
            commandCategory.Connection = connection;
            string queryCategory = "select DISTINCT Venue_Cat from Venues";
            commandCategory.CommandText = queryCategory;

            //Read Values From Database
            OleDbDataReader readerCategory = commandCategory.ExecuteReader();
            while (readerCategory.Read())
            {
                cboVenueCategory.Items.Add(readerCategory["Venue_Cat"]);
            }
            connection.Close();


            //Load Capacity ComboBox
            connection.Open();
            OleDbCommand commandCapacity = new OleDbCommand();
            commandCapacity.Connection = connection;
            string queryCapacity = "SELECT DISTINCT Cap_Interval FROM Venues";
            commandCapacity.CommandText = queryCapacity;

            //Read Values From Database
            OleDbDataReader readerCapacity = commandCapacity.ExecuteReader();
            while (readerCapacity.Read())
            {
                cboCapacityRequired.Items.Add(readerCapacity["Cap_Interval"]);
            }
            connection.Close();

            //Load Time Intervals ListBox
            connection.Open();
            OleDbCommand commandTyme = new OleDbCommand();
            commandTyme.Connection = connection;
            string queryTyme = "SELECT DISTINCT Time_Interval FROM TimeIntervals";
            commandTyme.CommandText = queryTyme;

            //Read Values From Database
            OleDbDataReader readerTyme = commandTyme.ExecuteReader();
            while (readerTyme.Read())
            {
                TimeSlot.Items.Add(readerTyme["Time_Interval"]);
            }
            connection.Close();
        }


        private void UserControlCreateBooking_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            string CreateBookingUserID = ArrayClass.UserID[0];
            string FinalUSERID = CreateBookingUserID;
            label2.Text = FinalUSERID;
            ClearForm();
        }
        private void btnFindVenue_Click_1(object sender, EventArgs e)
        {
            int futureBookingsCount = CountFutureBookings();

            if (futureBookingsCount >= 3)
            {
                MessageBox.Show("You already have 3 upcoming bookings. Please cancel one before making a new booking.");
            }
            else

            //Continue with the rest of the logic

            //Clear Text To Avoid Double Booking
            {

                //Clear Text To Avoid Double Booking
                cboVenue.Text = string.Empty;

                // Validate the form
                bool blnValidateFindVenueform = BlnValidateFindVenueForm();  // Run validation and get the result

                if (blnValidateFindVenueform)  // Proceed only if validation passed
                {
                    // Clear the combobox first to avoid duplicates
                    cboVenue.Items.Clear();

                    // Open database connection
                    connection.Open();

                    // SQL query to load venues based on category and capacity
                    string queryLoadVenue = "SELECT Venue_Name FROM Venues WHERE Venue_Cat = ? AND Cap_Interval = ? ORDER BY Venue_Name ASC";
                    OleDbCommand commandLoadVenue = new OleDbCommand(queryLoadVenue, connection);
                    commandLoadVenue.Parameters.AddWithValue("?", cboVenueCategory.Text);
                    commandLoadVenue.Parameters.AddWithValue("?", cboCapacityRequired.Text);

                    // Read venue names from the database
                    OleDbDataReader readerCapacity = commandLoadVenue.ExecuteReader();
                    while (readerCapacity.Read())
                    {
                        string venueName = readerCapacity["Venue_Name"].ToString();  // Get venue name
                        DateTime eventDate = dtpStartDate.Value.Date;  // Get selected date

                        // Collect selected intervals from the checklist
                        List<string> selectedIntervals = new List<string>();
                        foreach (var checkedItem in TimeSlot.CheckedItems)
                        {
                            selectedIntervals.Add(checkedItem.ToString().Trim());  // Add each selected interval
                        }

                        // Assume no overlapping bookings initially
                        bool hasOverlap = false;

                        // Check for overlapping bookings for the current venue for the selected date and intervals
                        foreach (var interval in selectedIntervals)
                        {
                            string checkQuery = @"
    SELECT COUNT(*) 
    FROM Bookings 
    WHERE Venue_Name = ? 
    AND Event_Date = ? 
    AND Time_Interval LIKE '%' + ? + '%'";  // Check if the venue is booked for the same date and interval

                            // Prepare and execute the SQL command
                            OleDbCommand checkCommand = new OleDbCommand(checkQuery, connection);
                            checkCommand.Parameters.AddWithValue("?", venueName);
                            checkCommand.Parameters.AddWithValue("?", eventDate);
                            checkCommand.Parameters.AddWithValue("?", interval);

                            int overlapCount = (int)checkCommand.ExecuteScalar();  // Check if there is an overlap
                            if (overlapCount > 0)
                            {
                                hasOverlap = true;
                                break;
                            }

                        }

                        // If no overlaps were found for the selected date and intervals, add the venue to the combobox
                        if (!hasOverlap)
                        {
                            cboVenue.Items.Add(venueName);
                        }
                    }

                    connection.Close();  // Close the database connection

                    // Check if any items were added to cboVenue
                    if (cboVenue.Items.Count > 0)
                    {
                        // Temporarily disable the Selecting event handler
                        tabpageCreateaBooking.Selecting -= tabpageCreateaBooking_Selecting_1;

                        // Switch to the next tab
                        int currentTabIndex = tabpageCreateaBooking.SelectedIndex;
                        if (currentTabIndex < tabpageCreateaBooking.TabPages.Count - 1)
                        {
                            tabpageCreateaBooking.SelectedTab = tabpageCreateaBooking.TabPages[currentTabIndex + 1];
                        }
                        // Re-enable the Selecting event handler
                        tabpageCreateaBooking.Selecting += tabpageCreateaBooking_Selecting_1;
                    }
                    else
                    {
                        // Show message that no venues are available
                        MessageBox.Show("No available venues found for the selected criteria.");
                    }
                }

            }
        }


        private void btnCreate_Booking_Click(object sender, EventArgs e)
        {
            // Temporarily disable the Selecting event handler
            tabpageCreateaBooking.Selecting -= tabpageCreateaBooking_Selecting_1;
            if (cboVenue.Text == string.Empty)
            {
                MessageBox.Show("Please Select a Venue");
            }
            else
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Get the values from the form
                    string venueName = cboVenue.Text;
                    DateTime eventDate = dtpStartDate.Value.Date;
                    string userId = label2.Text;

                    // Collect all selected intervals into a list (e.g., "08:00 - 09:00, 09:00 - 10:00")
                    List<string> selectedIntervals = new List<string>();
                    foreach (var checkedItem in TimeSlot.CheckedItems)
                    {
                        selectedIntervals.Add(checkedItem.ToString().Trim());  // Add each selected interval
                    }

                    // Join the intervals into one string separated by commas
                    string timeIntervals = string.Join(", ", selectedIntervals);



                    // No overlap, proceed with the booking
                    string insertQuery = @"
        INSERT INTO Bookings (Venue_Name, Event_Date, Time_Interval, User_No, Event_Type)
        VALUES (?, ?, ?, ?, ?)";

                    OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("?", venueName);
                    insertCommand.Parameters.AddWithValue("?", eventDate);
                    insertCommand.Parameters.AddWithValue("?", timeIntervals);
                    insertCommand.Parameters.AddWithValue("?", userId);
                    insertCommand.Parameters.AddWithValue("?", txtEventType.Text);

                    // Execute the query to insert the booking with combined intervals
                    insertCommand.ExecuteNonQuery();

                   
                    
                        MessageBox.Show("Booking successfully created.");
                        cboVenue.Text = string.Empty;
                        int currentTabIndex = tabpageCreateaBooking.SelectedIndex;

                        // Check if the current tab is not the first one
                        if (currentTabIndex > 0)
                        {
                            // Move to the previous tab
                            tabpageCreateaBooking.SelectedTab = tabpageCreateaBooking.TabPages[currentTabIndex - 1];
                        }

                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                }
                finally
                {
                    // Close the connection
                    connection.Close();
                }
                // Re-enable the Selecting event handler
                tabpageCreateaBooking.Selecting += tabpageCreateaBooking_Selecting_1;
            }
        }
            private bool BlnValidateFindVenueForm()
            {
                // Initialize an empty error message string
                string errorMessage = "";

                // Check if the category is selected
                if (string.IsNullOrWhiteSpace(txtEventType.Text))
                {
                    errorMessage += "Please Enter the Even Type.\n";
                }

                // Check if the category is selected
                if (string.IsNullOrWhiteSpace(cboVenueCategory.Text))
                {
                    errorMessage += "Please select a venue category.\n";
                }

                // Check if capacity is selected
                if (string.IsNullOrWhiteSpace(cboCapacityRequired.Text))
                {
                    errorMessage += "Please select the required capacity.\n";
                }

                // Check if at least one time interval is selected
                if (TimeSlot.CheckedItems.Count == 0)
                {
                    errorMessage += "Please select at least one time interval.\n";
                }

                // If there are errors, show all of them in a MessageBox
                if (!string.IsNullOrEmpty(errorMessage))
                {
                    MessageBox.Show(errorMessage);  // Display all error messages at once
                    return false;  // Validation failed
                }

                // If no errors, return true (validation passed)
                return true;
            }

            private void btnClear_Click(object sender, EventArgs e)
            {

                ClearForm();

                //Load Time Intervals ListBox
                connection.Open();
                OleDbCommand commandTyme = new OleDbCommand();
                commandTyme.Connection = connection;
                string queryTyme = "SELECT DISTINCT Time_Interval FROM TimeIntervals";
                commandTyme.CommandText = queryTyme;

                //Read Values From Database
                OleDbDataReader readerTyme = commandTyme.ExecuteReader();
                while (readerTyme.Read())
                {
                    TimeSlot.Items.Add(readerTyme["Time_Interval"]);
                }
                connection.Close();


            }
            public void ClearForm()
            {
                dtpStartDate.Value = DateTime.Now;
                TimeSlot.Items.Clear();
                cboVenueCategory.Items.Clear();
                cboCapacityRequired.Items.Clear();
                int currentTabIndex2 = tabpageCreateaBooking.SelectedIndex;
                if (currentTabIndex2 < 0)
                {
                    // Move to the next tab
                    tabpageCreateaBooking.SelectedTab = tabpageCreateaBooking.TabPages[currentTabIndex2 - 1];
                }
                cboVenue.Items.Clear();
                txtEventType.Text = string.Empty;
                cboCapacityRequired.Text = string.Empty;
                cboVenueCategory.Text = string.Empty;
            }
            private int CountFutureBookings()
            {
                string userIdText = label2.Text; // Get the User ID from the label
                int userId = int.Parse(userIdText); // Directly parse the User ID
                int count = 0;

                string query = @"SELECT COUNT(*) FROM Bookings WHERE User_No = ? AND Event_Date >= Date();";

                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", userId);
                        count = (int)command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                return count;
            } 
        private void button2_Click(object sender, EventArgs e)
        {
            //Clear Form
            cboVenue.Text += string.Empty;
            cboVenue.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //QUIT BUTTON
            // Temporarily disable the Selecting event handler
            tabpageCreateaBooking.Selecting -= tabpageCreateaBooking_Selecting_1;

            int currentTabIndex = tabpageCreateaBooking.SelectedIndex;

            // Check if the current tab is not the first one
            if (currentTabIndex > 0)
            {
                // Move to the previous tab
                tabpageCreateaBooking.SelectedTab = tabpageCreateaBooking.TabPages[currentTabIndex - 1];
            }

            // Re-enable the Selecting event handler
            tabpageCreateaBooking.Selecting += tabpageCreateaBooking_Selecting_1;
        }

        private void tabpageCreateaBooking_Selecting_1(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}

    
