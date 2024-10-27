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

    public partial class UpdateUser : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        public UpdateUser()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\austi\Downloads\VenueLink.accdb;Persist Security Info=False;";
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (txtFname.Text == string.Empty || txtLname.Text == string.Empty)
            {
                MessageBox.Show("Please Enter All Fields");
            }
            else
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Collect new values from the form
                    string newFname = txtFname.Text;
                    string newLname = txtLname.Text;
                    string userId = txtUserID.Text;



                    // SQL Update query
                    string updateQuery = @"
        UPDATE Users 
        SET F_Name = ?, L_Name = ?
        WHERE User_No = ?";

                    OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("?", newFname);
                    updateCommand.Parameters.AddWithValue("?", newLname);

                    updateCommand.Parameters.AddWithValue("?", txtUserID.Text);  // Only update the specific booking ID

                    // Execute the update
                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profile updated successfully!");
                        txtUserID.Text = string.Empty;
                        txtFname.Text = string.Empty;
                        txtLname.Text = string.Empty;
                    }

                    else
                    {
                        MessageBox.Show("User ID not found");
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
                }
            }
        }
            private void btnClear_Click(object sender, EventArgs e)
            {
                txtUserID.Text = string.Empty;
                txtFname.Text = string.Empty;
                txtLname.Text = string.Empty;
            }

            private void UpdateUser_Load(object sender, EventArgs e)
            {

            }
        }
    } 
