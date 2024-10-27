using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venuelink_Booking_System.User_Control
{
    public partial class Delete_User : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();

        public Delete_User()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\austi\Downloads\VenueLink.accdb;Persist Security Info=False;";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Open Connection
                connection.Open();

                // First, check if the user ID exists
                OleDbCommand checkUserCommand = new OleDbCommand();
                checkUserCommand.Connection = connection;
                checkUserCommand.CommandText = "SELECT COUNT(*) FROM Users WHERE User_No = ?";
                checkUserCommand.Parameters.AddWithValue("?", txtUserID.Text);

                int userCount = (int)checkUserCommand.ExecuteScalar();

                if (userCount == 0)
                {
                    MessageBox.Show("User ID does not exist.");
                    return; // Exit the method without deleting
                }

                // If the user ID exists, proceed to delete the user
                OleDbCommand deleteCommand = new OleDbCommand();
                deleteCommand.Connection = connection;
                deleteCommand.CommandText = "DELETE FROM Users WHERE User_No = ?";
                deleteCommand.Parameters.AddWithValue("?", txtUserID.Text);

                deleteCommand.ExecuteNonQuery();

                MessageBox.Show("Profile Deleted");
                txtUserID.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed even if an error occurs
                connection.Close();
            }

            //

            // DELETE BOOKINGS THAT HAVEN'T HAPPENED YET

            // Open Connection
            connection.Open();

            // First, check if any bookings for the user exist with event dates in the future
            OleDbCommand checkCommand = new OleDbCommand();
            checkCommand.Connection = connection;
            checkCommand.CommandText = "SELECT Event_Date FROM Bookings WHERE User_No = @userNo";
            checkCommand.Parameters.AddWithValue("@userNo", label1.Text);  // Using parameterized query for User_No

            OleDbDataReader reader = checkCommand.ExecuteReader();
            bool futureBookingExists = false;

            while (reader.Read())
            {
                DateTime eventDate = reader.GetDateTime(0);

                // Compare eventDate with today's date
                if (eventDate >= DateTime.Today)
                {
                    futureBookingExists = true;
                    break;
                }
            }

            reader.Close();

            if (futureBookingExists)
            {
                // Delete bookings where User_No = label1.Text and Event_Date is in the future
                OleDbCommand deleteCommand = new OleDbCommand();
                deleteCommand.Connection = connection;
                deleteCommand.CommandText = "DELETE FROM Bookings WHERE User_No = @userNo AND Event_Date >= @today";
                deleteCommand.Parameters.AddWithValue("@userNo", label1.Text);  // User_No as a string
                deleteCommand.Parameters.AddWithValue("@today", DateTime.Today);  // Using parameterized query for the date

                int rowsAffected = deleteCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Future bookings deleted successfully.");
                }
                else
                {
                    MessageBox.Show("No future bookings found to delete.");
                }
            }
            else
            {
                MessageBox.Show("No future bookings found for this user.");
            }

            // Close Connection
            connection.Close();

            //

        }

        private void btnDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is not a digit and not a control key (like backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Prevent the character from being entered into the TextBox
            }
        }

        private void Delete_User_Load(object sender, EventArgs e)
        {
            string currentUserID = ArrayClass.UserID[0];
            string ViewBookingUSERID = currentUserID;
            label1.Text = ViewBookingUSERID;
        }
    }

}
