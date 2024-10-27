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

namespace Venuelink_Booking_System.User_Control
{
    public partial class UCUpdateBooking : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        public UCUpdateBooking()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\austi\Downloads\VenueLink.accdb;Persist Security Info=False;";
        }

        private void UCUpdateBooking_Load(object sender, EventArgs e)
        {
            string CreateBookingUserID = ArrayClass.UserID[0];
            string FinalUSERID = CreateBookingUserID;
            label50.Text = FinalUSERID;
        }
        public void LoadFromDataBaseUpdateBooking()
        {
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

        private void btnUpdateVenue_Click(object sender, EventArgs e)
        {
           
            if (cboVenue.Text == string.Empty)
            {
                MessageBox.Show("Please select a Venue");
            }
            else 
            {
                // Temporarily disable the Selecting event handler
                tabControl1.Selecting -= tabControl1_Selecting;

                try
                {
                    // Open the connection
                    connection.Open();
                    // First, check if the booking ID exists and if the event date is in the future
                    OleDbCommand checkCommand = new OleDbCommand();
                    checkCommand.Connection = connection;
                    checkCommand.CommandText = "SELECT Event_Date FROM Bookings WHERE Booking_ID = " + txtBookingID.Text + " AND User_No = " + label50.Text + "";

                    OleDbDataReader reader = checkCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        DateTime eventDate = reader.GetDateTime(0);

                        // Compare eventDate with today's date
                        if (eventDate < DateTime.Today)
                        {
                            MessageBox.Show("You cannot delete past bookings.");
                            reader.Close();
                            connection.Close();
                            return; // Exit the method without deleting
                        }
                    }
                    else
                    {
                        MessageBox.Show("Booking ID not found.");
                        reader.Close();
                        connection.Close();
                        return; // Exit the method as the booking ID does not exist
                    }
                    reader.Close();

                    // Collect new values from the form
                    string newVenueName = cboVenue.Text;
                    DateTime newEventDate = dtpStartDate.Value.Date;
                    string userId = label2.Text;
                    string newEventType = txtEventType.Text;

                    // Collect all selected intervals into a string (e.g., "08:00 - 09:00, 09:00 - 10:00")
                    List<string> selectedIntervals = new List<string>();
                    foreach (var checkedItem in TimeSlot.CheckedItems)
                    {
                        selectedIntervals.Add(checkedItem.ToString().Trim());
                    }
                    string newTimeIntervals = string.Join(", ", selectedIntervals);

                    // SQL Update query
                    string updateQuery = @"
        UPDATE Bookings 
        SET Venue_Name = ?, Event_Date = ?, Time_Interval = ?, Event_Type = ?
        WHERE Booking_ID = ?";

                    OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("?", newVenueName);
                    updateCommand.Parameters.AddWithValue("?", newEventDate);
                    updateCommand.Parameters.AddWithValue("?", newTimeIntervals);  // Updated intervals
                    updateCommand.Parameters.AddWithValue("?", newEventType);
                    updateCommand.Parameters.AddWithValue("?", txtBookingID.Text);  // Only update the specific booking ID

                    // Execute the update
                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        
                            MessageBox.Show("Booking updated successfully!");

                            // Temporarily disable the Selecting event handler

                            int currentTabIndex = tabControl1.SelectedIndex;

                            // Check if the current tab is not the first one
                            if (currentTabIndex > 0)
                            {
                                // Move to the previous tab
                                tabControl1.SelectedTab = tabControl1.TabPages[currentTabIndex - 1];
                            }
                        
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating booking: " + ex.Message);
                }
                finally
                {
                    // Close the connection
                    connection.Close();
                }// Check if any items were added to cboVenue

                // Re-enable the Selecting event handler
                tabControl1.Selecting += tabControl1_Selecting;
            }
        }
        private void btnUpdateBooking_Click(object sender, EventArgs e)
        {
           
            cboVenue.Items.Clear();  // Clear the combobox first to avoid duplicates
            cboVenue.Text = string.Empty;

            bool blnValidateFindVenueform = BlnValidateFindVenueForm();  // Run validation and get the result

            if (blnValidateFindVenueform)
            {
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
                        checkCommand.Parameters.AddWithValue("?", eventDate);  // Ensure the date is considered
                        checkCommand.Parameters.AddWithValue("?", interval);   // Ensure the time interval is considered

                        int overlapCount = (int)checkCommand.ExecuteScalar();  // Check if there is an overlap
                        if (overlapCount > 0)
                        {
                            hasOverlap = true;  // If any overlap is found, mark it as such
                            break;  // Exit the loop if there's any overlap
                        }
                    }

                    // If no overlaps were found for the selected date and intervals, add the venue to the combobox
                    if (!hasOverlap)
                    {
                        cboVenue.Items.Add(venueName);
                    }
                }
                // Close the connection
                connection.Close();
                // Check if any items were added to cboVenue
                if (cboVenue.Items.Count > 0)
                {
                    // Temporarily disable the Selecting event handler
                    tabControl1.Selecting -= tabControl1_Selecting;

                    // Switch to the next tab
                    int currentTabIndex = tabControl1.SelectedIndex;
                    if (currentTabIndex < tabControl1.TabPages.Count - 1)
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[currentTabIndex + 1];
                    }
                    // Re-enable the Selecting event handler
                    tabControl1.Selecting += tabControl1_Selecting;
                }
                else
                {
                    // Show message that no venues are available
                    MessageBox.Show("No available venues found for the selected criteria.");
                }
            }

        }
        private bool BlnValidateFindVenueForm()
        {


            string errorMessage = "";

            // Check if the Booking ID is not empty
            if (string.IsNullOrWhiteSpace(txtBookingID.Text))  // Use IsNullOrWhiteSpace to handle spaces as well
            {
                errorMessage += "Please enter a valid Booking ID.\n";
            }
            if (string.IsNullOrWhiteSpace(txtEventType.Text))  // Use IsNullOrWhiteSpace to handle spaces as well
            {
                errorMessage += "Please enter your Event Type.\n";
            }
            // Check if the category is selected
            if (string.IsNullOrWhiteSpace(cboVenueCategory.Text))  // Ensure category is selected
            {
                errorMessage += "Please select a venue category.\n";
            }

            // Check if capacity is selected
            if (string.IsNullOrWhiteSpace(cboCapacityRequired.Text))  // Ensure capacity is selected
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
                MessageBox.Show(errorMessage, "Validation Errors", MessageBoxButtons.OK);  // Display all error messages at once
                return false;  // Validation failed
            }

            // If no errors, return true (validation passed)
            return true;
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // Only allow tab switching if the form input is valid
            if (!BlnValidateFindVenueForm())
            {
                e.Cancel = true;  // Prevent tab switching if validation fails
            }
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
        public void ClearUpdateBooking()
        {

        }

        private void cboCapacityRequired_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //QUIT BUTTON
            // Temporarily disable the Selecting event handler
            tabControl1.Selecting -= tabControl1_Selecting;

            int currentTabIndex = tabControl1.SelectedIndex;

            // Check if the current tab is not the first one
            if (currentTabIndex > 0)
            {
                // Move to the previous tab
                tabControl1.SelectedTab = tabControl1.TabPages[currentTabIndex - 1];
            }

            // Re-enable the Selecting event handler
            tabControl1.Selecting += tabControl1_Selecting;
        }
        public void ClearForm()
        {
            dtpStartDate.Value = DateTime.Now;
            txtBookingID.Text = "";
            TimeSlot.Items.Clear();
            cboVenueCategory.Items.Clear();
            cboCapacityRequired.Items.Clear();
            int currentTabIndex2 = tabControl1.SelectedIndex;
            if (currentTabIndex2 < 0)
            {
                // Move to the next tab
                tabControl1.SelectedTab = tabControl1.TabPages[currentTabIndex2 - 1];
            }
            cboVenue.Items.Clear();
            txtEventType.Text = string.Empty;
            cboCapacityRequired.Text = string.Empty;
            cboVenueCategory.Text = string.Empty;
        }

    }


}
      
    

