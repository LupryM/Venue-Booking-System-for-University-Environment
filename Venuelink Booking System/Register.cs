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

namespace Venuelink_Booking_System
{
    public partial class Register : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Register()
        {
            InitializeComponent();

            //Connect To Database
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\austi\Downloads\VenueLink.accdb;Persist Security Info=False;";
        }

        private void Register_Load(object sender, EventArgs e)
        {
            txtFirstName.Enabled = false;
            txtPassword.Enabled = false;
            txtLastName.Enabled = false;
            txtConfirmPassword.Enabled = false;
            txtEmailAdress.Enabled = false;
            txtID.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                Login f9 = new Login();
                this.Hide();
                f9.ShowDialog();
            }
        }

        private void radStudent_CheckedChanged(object sender, EventArgs e)
        {
            lblID.Text = "Student Number:";
            lblError.Visible = false;
            MakeVisible();
        }

        private void radLecturer_CheckedChanged(object sender, EventArgs e)
        {
            lblID.Text = "Staff Number:";
            lblError.Visible = false;
            MakeVisible();
        }
        private void MakeVisible()
        {
            txtFirstName.Enabled = true;
            txtPassword.Enabled = true;
            txtLastName.Enabled = true;
            txtConfirmPassword.Enabled = true;
            txtEmailAdress.Enabled = true;
            txtID.Enabled = true;
        }
        private bool IsAllLetters(string input)
        {
            //Letters entered
            return input.All(char.IsLetter);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                // if any field is missing
                bool isMissingField = false;

                // Check if the first name is empty
                if (txtFirstName.Text == "")
                {
                    MessageBox.Show("First Name is missing");
                    isMissingField = true;

                }
                else if (!char.IsUpper(txtFirstName.Text[0]) || !IsAllLetters(txtFirstName.Text))
                {
                    MessageBox.Show("First Name must start with a capital letter and contain only alphabets.");
                    isMissingField = true;
                    txtFirstName.Text = "";
                }
                // Check if the last name is empty
                if (txtLastName.Text == "")
                {
                    MessageBox.Show("Last Name is missing");
                    isMissingField = true;
                }
                else if (!char.IsUpper(txtLastName.Text[0]) || !IsAllLetters(txtLastName.Text))
                {
                    MessageBox.Show("Last Name must start with a capital letter and contain only alphabets.");
                    isMissingField = true;
                    txtLastName.Text = "";
                }

                // Check if the student/staff number is empty
                if (txtID.Text == "")
                {
                    MessageBox.Show("Student/Staff Number is missing");
                    isMissingField = true;
                }
                else if (txtID.Text.Length != 5 || !int.TryParse(txtID.Text, out _))
                {
                    MessageBox.Show("Student/Staff Number must be exactly 5 digits.");
                    isMissingField = true;
                    txtID.Text = "";
                }
                else if (radStudent.Checked && !txtID.Text.StartsWith("2"))
                {
                    MessageBox.Show("Student Number must start with 2.");
                    isMissingField = true;
                    txtID.Text = "";
                }
                else if (radLecturer.Checked && !txtID.Text.StartsWith("1"))
                {
                    MessageBox.Show("Staff Number must start with 1.");
                    isMissingField = true;
                    txtID.Text = "";
                }

                // Check if the email address is empty
                if (txtEmailAdress.Text == "")
                {
                    MessageBox.Show("Email Address is missing");
                    isMissingField = true;
                }
                else
                {
                    // Validate email for student
                    if (radStudent.Checked)
                    {
                        string expectedEmail = txtID.Text + "@students.wits.ac.za";
                        if (txtEmailAdress.Text != expectedEmail)
                        {
                            MessageBox.Show($"Student email must be {txtID.Text}@students.wits.ac.za and match the Student Number entered.");
                            isMissingField = true;
                            txtEmailAdress.Text = "";
                        }
                    }
                    // Validate email for lecturer
                    else if (radLecturer.Checked)
                    {
                        string expectedEmail = txtID.Text + "@wits.ac.za";
                        if (txtEmailAdress.Text != expectedEmail)
                        {
                            MessageBox.Show($"Lecturer email must be {txtID.Text}@wits.ac.za and match the Staff Number entered.");
                            isMissingField = true;
                            txtEmailAdress.Text = "";
                        }
                    }
                }

                // Check if the password is empty
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Enter Password");
                    isMissingField = true;
                }
                else
                {
                    // Check password requirements
                    if (txtPassword.Text.Length < 8 ||
                    !txtPassword.Text.Any(char.IsUpper) ||
                    !txtPassword.Text.Any(char.IsLower) ||
                    !txtPassword.Text.Any(char.IsDigit))
                    {
                        MessageBox.Show("Password must be at least 8 characters long, include an uppercase letter, a lowercase letter, and a number.");
                        isMissingField = true;
                        txtPassword.Text = "";
                    }

                    // Check if the confirm password is empty
                    if (txtConfirmPassword.Text == "")
                    {
                        MessageBox.Show("Enter Password Confirmation");
                        isMissingField = true;
                    }
                }

                // If there are missing field
                if (isMissingField)
                {
                    return; // Exit the method
                }

                // Check if passwords match
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    try
                    {
                        connection.Open();

                        // student/staff number already exists
                        string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE User_No = @Username";
                        using (OleDbCommand checkCmd = new OleDbCommand(checkUserQuery, connection))
                        {
                            checkCmd.Parameters.AddWithValue("@Username", txtID.Text);
                            int userExists = (int)checkCmd.ExecuteScalar();

                            if (userExists > 0) // the user already exists
                            {
                                MessageBox.Show("You have already registered, please login.");
                                connection.Close();
                                return; // Exit the method
                            }
                        }

                        // If the user doesn't exist, proceed with registration
                        string register = "INSERT INTO Users ([F_Name], [L_Name], [User_No], [Email_Adress], [User_Paswrd], [User_Type]) " +
                        "VALUES (@FirstName, @LastName, @Username, @Email, @Password, @StudentType)";

                        using (OleDbCommand cmd = new OleDbCommand(register, connection))
                        {
                            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                            cmd.Parameters.AddWithValue("@Username", txtID.Text);
                            cmd.Parameters.AddWithValue("@Email", txtEmailAdress.Text);
                            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                            cmd.Parameters.AddWithValue("@StudentType", radStudent.Checked ? "Student" : "Lecturer");

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Your account has been successfully created, Registration Complete");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match, please re-enter", "Registration Failed");
                    txtPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtPassword.Focus();
                }
            }

            Login f7 = new Login();
            this.Hide();
            f7.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtID.Text = "";
            txtID.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            radStudent.Checked = false;
            radLecturer.Checked = false;
        }

        private void pictureBoxSHOWpassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            pictureBoxSHOWpassword.Visible = false;
            PictureBoxPasswordHide.Visible = true;
        }

        private void pictureBoxSHOWPassword2_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = false;
            pictureBoxHidePassword2.Visible = true;
            pictureBoxSHOWpassword2.Visible = false;
        }

        private void PictureBoxPasswordHide_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            PictureBoxPasswordHide.Visible = false;
            pictureBoxSHOWpassword.Visible = true;
        }

        private void pictureBoxHidePassword2_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = true;
            pictureBoxHidePassword2.Visible = false;
            pictureBoxSHOWpassword2.Visible = true;
        }
    }
}
