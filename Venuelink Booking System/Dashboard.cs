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
using Venuelink_Booking_System.User_Control;


namespace Venuelink_Booking_System
{
    public partial class Dashboard : Form
    {
        private OleDbConnection connection = new OleDbConnection();


        public Dashboard(string User)
        {

            InitializeComponent();
            lblUsername.Text = User;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\austi\Downloads\VenueLink.accdb;Persist Security Info=False;";

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            string[] UserdID = new string[1];

            userControlCreateBooking1.Hide();
            ucViewBooking1.Hide();
            ucUpdateBooking1.Hide();
            ucDeleteBooking1.Hide();

        }
        private void MovePanel(Control btn)
        {
            panelslider.Top = btn.Top;
            panelslider.Height = btn.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void btnCtreateBooking_Click(object sender, EventArgs e)
        {
            userControlCreateBooking1.ClearForm();
            MovePanel(btnCreateBooking);
            userControlCreateBooking1.Show();
            ucViewBooking1.Hide();
            ucUpdateBooking1.Hide();
            ucDeleteBooking1.Hide();

            //Refresh Form Data
            userControlCreateBooking1.LoadFromDataBaseCreateBooking();
        }

        private void btnViewBookings_Click(object sender, EventArgs e)
        {

            MovePanel(btnViewBookings);
            userControlCreateBooking1.Hide();
            ucViewBooking1.Show();
            ucUpdateBooking1.Hide();
            ucDeleteBooking1.Hide();

            //Refresh Form Data
            ucViewBooking1.LoadFromDatabaseViewBookings();

        }



        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            MovePanel(btnCancelBooking);
            userControlCreateBooking1.Hide();
            ucViewBooking1.Hide();
            ucUpdateBooking1.Hide();
            ucDeleteBooking1.Show();
        }

        private void btnUpdateBooking_Click(object sender, EventArgs e)
        {
            ucUpdateBooking1.ClearForm();
            MovePanel(btnUpdateBooking);
            ucUpdateBooking1.Show();
            userControlCreateBooking1.Hide();
            ucViewBooking1.Hide();
            ucDeleteBooking1.Hide();

            //Refresh Form Data
            ucUpdateBooking1.LoadFromDataBaseUpdateBooking();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                //Stop the timer
                timer1.Stop();

                //Close Application
                this.Close();

                //Return to Login Form
                new Login().Show();
                this.Close();

            }

        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void userControlCreateBooking1_Load(object sender, EventArgs e)
        {

        }
    }
}
