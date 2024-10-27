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

namespace Venuelink_Booking_System.Properties
{
    public partial class Admin : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Admin()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\austi\Downloads\VenueLink.accdb;Persist Security Info=False;";
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            MovePanel(btnGenerateReport);
            adminViewBookings1.Visible = true;
            delete_User1.Visible = false;
            updateUser1.Visible = false;
            adminViewBookings1.LoadFromDatabaseViewBookings();
            adminViewBookings1.LoadViewUser();
            
        }
        private void MovePanel(Control btn)
        {
            panelslider.Top = btn.Top;
            panelslider.Height = btn.Height;
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            adminViewBookings1.Visible = false;
            updateUser1.Visible = false;
            delete_User1.Visible = false;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            MovePanel(btnDeleteUser);
            delete_User1.Visible = true;
            updateUser1.Visible = false;
            adminViewBookings1.Visible = false;
        }

        private void btnUpdateUsrer_Click(object sender, EventArgs e)
        {
            adminViewBookings1.LoadViewUser();
            MovePanel(btnUpdateUsrer);
            updateUser1.Visible = true;
            delete_User1.Visible = false;
            adminViewBookings1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SelectUser f1 = new SelectUser();
            this.Visible = false;
            f1.ShowDialog();
        }
    }
}
