using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Venuelink_Booking_System
{
    public partial class Login : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Login()
        {
            InitializeComponent();

            //Connect To Database
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\austi\Downloads\VenueLink.accdb;Persist Security Info=False;";
        }
  

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            //Close Login Form
            SelectUser f1 = new SelectUser();
            this.Visible = false;
            f1.ShowDialog();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            pictureBoxSHOWpassword.Visible = false;
            PictureBoxPasswordHide.Visible = true;
        }

        private void PictureBoxPasswordHide_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            PictureBoxPasswordHide.Visible = false;
            pictureBoxSHOWpassword.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string User = txtUserID.Text;
            //string[] NewUser = new string[1] {User};
            
            
            
            if (!string.IsNullOrEmpty(User))
            {
                ArrayClass.UserID[0] = User;
                //if password is empty or there's space
                if (txtPassword.Text == "" || txtPassword.Text == " ")
                {
                    MessageBox.Show("Enter Password");
                    return;
                }
                // if username is empty or there's space
                else if (txtUserID.Text == "" || txtUserID.Text == " ")
                {
                    MessageBox.Show("Enter Username");
                    return;
                }

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from Users where User_No= '" + txtUserID.Text + "' and User_Paswrd= '" + txtPassword.Text + "'";

                OleDbDataReader reader = command.ExecuteReader();
                int count = 0; // count number of results
                while (reader.Read())
                {
                    count++;
                }

                if (count == 1)
                {
                    MessageBox.Show("Login Successful");
                    Dashboard dashboard = new Dashboard(User);
                    dashboard.Show();
                    this.Hide();

                    //Tranfer UserID to Dashboard Form

          

                }

                else
                {
                    MessageBox.Show("Invalid login, please try again");
                }

                connection.Close();
            }
        }
        private bool ValidateForm(bool blnValidForm)
        {
            return blnValidForm;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

       
    }
}
