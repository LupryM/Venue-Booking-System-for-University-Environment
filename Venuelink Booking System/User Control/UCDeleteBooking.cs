using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venuelink_Booking_System.User_Control
{
    public partial class UCDeleteBooking : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        public UCDeleteBooking()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\austi\Downloads\VenueLink.accdb;Persist Security Info=False;";
        }

        private void UCDeleteBooking_Load(object sender, EventArgs e)
        {
            string currentUserID = ArrayClass.UserID[0];
            string ViewBookingUSERID = currentUserID;
            label1.Text = ViewBookingUSERID;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool blnValidateDelete = true;
            if (txtBookingID.Text == "")
            {
                MessageBox.Show("Please Enter a Booking ID");
                blnValidateDelete = false;
                return;
            }
 

            if (blnValidateDelete == true)
            {
                // Open Connection
                connection.Open();

                // First, check if the booking ID exists and if the event date is in the future
                OleDbCommand checkCommand = new OleDbCommand();
                checkCommand.Connection = connection;
                checkCommand.CommandText = "SELECT Event_Date FROM Bookings WHERE Booking_ID = " + txtBookingID.Text +" AND User_No = " + label1.Text + "";

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
                    MessageBox.Show("Booking ID not found or does not belong to this user.");
                    reader.Close();
                    connection.Close();
                    return; // Exit the method as the booking ID does not exist
                }
                reader.Close();
                

                // If the event date is in the future, proceed to delete the booking
                OleDbCommand Deletecommand = new OleDbCommand();
                Deletecommand.Connection = connection;
                string Deletequery = "DELETE FROM Bookings WHERE Booking_ID = " + txtBookingID.Text + " AND Event_Date >= Date()";
                Deletecommand.CommandText = Deletequery;

                Deletecommand.ExecuteNonQuery();
                MessageBox.Show("Booking Deleted");
                txtBookingID.Text = string.Empty;
                connection.Close();
            }
        }
        }
        
    }
    

