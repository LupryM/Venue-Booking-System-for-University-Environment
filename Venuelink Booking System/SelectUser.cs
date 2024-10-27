using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venuelink_Booking_System.Properties;

namespace Venuelink_Booking_System
{
    public partial class SelectUser : Form
    {
        public SelectUser()
        {
            InitializeComponent();
        }

        private void SelectUser_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panelAdmin_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void panelStudent_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panelLecturer_Paint(object sender, PaintEventArgs e)
        {
    
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            //Close Form and Go to Admin Form
            Admin f1 = new Admin();
            this.Visible = false;
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Close Form and Go to Login Form
            Login f2 = new Login();
            this.Visible = false;
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Close Form and Go to Login Form
            Login f2 = new Login();
            this.Visible = false;
            f2.ShowDialog();
        }
    }
}
