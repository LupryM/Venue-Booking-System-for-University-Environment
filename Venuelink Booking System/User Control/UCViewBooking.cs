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
    public partial class UCViewBooking : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();

        public UCViewBooking()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\austi\Downloads\VenueLink.accdb;Persist Security Info=False;";
        }

        private void TCViewBookings_Click_1(object sender, EventArgs e)
        {

        }

        private void DGVviewBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UCViewBooking_Load(object sender, EventArgs e)
        {
            string currentUserID = ArrayClass.UserID[0];
            string ViewBookingUSERID = currentUserID;
            USERID.Text = ViewBookingUSERID;
            USERID.Visible = false; 
            LoadFromDatabaseViewBookings();
            
        }
        public void LoadFromDatabaseViewBookings()
        {
            connection.Open();
            OleDbCommand commandViewBooking = new OleDbCommand();
            commandViewBooking.Connection = connection;
            string queryViewBooking = "SELECT * FROM Bookings WHERE User_No = " + USERID.Text + "";


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

        private void DGVviewBookings_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
