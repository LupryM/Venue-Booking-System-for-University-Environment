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
    public partial class AdminViewBookings : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        public AdminViewBookings()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\austi\Downloads\VenueLink.accdb;Persist Security Info=False;";
        }

        private void AdminViewBookings_Load(object sender, EventArgs e)
        {
            string currentUserID = ArrayClass.UserID[0];
            string ViewBookingUSERID = currentUserID;
            USERID.Text = ViewBookingUSERID;
            USERID.Visible = false;
            LoadFromDatabaseViewBookings();
            LoadViewUser();

        }
        public void LoadFromDatabaseViewBookings()
        {
            connection.Open();
            OleDbCommand commandViewBooking = new OleDbCommand();
            commandViewBooking.Connection = connection;
            string queryViewBooking = "SELECT * FROM Bookings ";

            commandViewBooking.CommandText = queryViewBooking;

            //Read Values in Database
            OleDbDataAdapter da = new OleDbDataAdapter(commandViewBooking);

            //Declare Data Table
            DataTable dt = new DataTable();

            //Fill Table with Data
            da.Fill(dt);
            DGVviewBookings.DataSource = dt;

            connection.Close();
        }
        public void LoadViewUser()
        {
            connection.Open();
            OleDbCommand commandViewBooking = new OleDbCommand();
            commandViewBooking.Connection = connection;

            // Updated SQL query to select specific columns
            string queryViewBooking = "SELECT F_Name, L_Name, Email_Adress, User_Type, User_No FROM Users";

            commandViewBooking.CommandText = queryViewBooking;

            // Use OleDbDataAdapter to fill the DataTable
            OleDbDataAdapter da = new OleDbDataAdapter(commandViewBooking);

            // Declare and fill the DataTable with the selected data
            DataTable dt2 = new DataTable();
            da.Fill(dt2);

            // Bind the data to the DataGridView
            dgvViewUser.DataSource = dt2;

            connection.Close();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dgvViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
