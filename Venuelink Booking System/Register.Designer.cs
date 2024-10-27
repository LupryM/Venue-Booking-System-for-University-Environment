namespace Venuelink_Booking_System
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label1 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            txtLastName = new TextBox();
            label3 = new Label();
            txtID = new TextBox();
            lblID = new Label();
            txtEmailAdress = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            txtConfirmPassword = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            radStudent = new RadioButton();
            radLecturer = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            lblError = new Label();
            btnClear = new Button();
            pictureBoxSHOWpassword = new PictureBox();
            pictureBoxSHOWpassword2 = new PictureBox();
            PictureBoxPasswordHide = new PictureBox();
            pictureBoxHidePassword2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSHOWpassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSHOWpassword2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxPasswordHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHidePassword2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(190, 7);
            label1.Name = "label1";
            label1.Size = new Size(160, 44);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(120, 192);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(313, 27);
            txtFirstName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(122, 164);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 5;
            label2.Text = "First Name:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(37, 198, 218);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(66, 634);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(162, 41);
            btnLogin.TabIndex = 17;
            btnLogin.Text = "Create Profile";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(120, 261);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(313, 27);
            txtLastName.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(122, 233);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 18;
            label3.Text = "Last Name:";
            // 
            // txtID
            // 
            txtID.Location = new Point(120, 335);
            txtID.Name = "txtID";
            txtID.Size = new Size(313, 27);
            txtID.TabIndex = 21;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.ForeColor = Color.Black;
            lblID.Location = new Point(120, 307);
            lblID.Name = "lblID";
            lblID.Size = new Size(208, 25);
            lblID.TabIndex = 20;
            lblID.Text = "Student/Staff Number:";
            // 
            // txtEmailAdress
            // 
            txtEmailAdress.Location = new Point(120, 406);
            txtEmailAdress.Name = "txtEmailAdress";
            txtEmailAdress.Size = new Size(313, 27);
            txtEmailAdress.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(120, 378);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 22;
            label4.Text = "Email Address:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(120, 476);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(313, 27);
            txtPassword.TabIndex = 25;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(120, 448);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 24;
            label5.Text = "Password:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(120, 551);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(313, 27);
            txtConfirmPassword.TabIndex = 27;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(120, 523);
            label6.Name = "label6";
            label6.Size = new Size(170, 25);
            label6.TabIndex = 26;
            label6.Text = "Confirm Password:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(523, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // radStudent
            // 
            radStudent.AutoSize = true;
            radStudent.FlatStyle = FlatStyle.System;
            radStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radStudent.Location = new Point(103, 67);
            radStudent.Name = "radStudent";
            radStudent.Size = new Size(116, 33);
            radStudent.TabIndex = 29;
            radStudent.TabStop = true;
            radStudent.Text = "Student";
            radStudent.UseVisualStyleBackColor = true;
            radStudent.CheckedChanged += radStudent_CheckedChanged;
            // 
            // radLecturer
            // 
            radLecturer.AutoSize = true;
            radLecturer.FlatStyle = FlatStyle.System;
            radLecturer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radLecturer.Location = new Point(325, 67);
            radLecturer.Name = "radLecturer";
            radLecturer.Size = new Size(120, 33);
            radLecturer.TabIndex = 30;
            radLecturer.TabStop = true;
            radLecturer.Text = "Lecturer";
            radLecturer.UseVisualStyleBackColor = true;
            radLecturer.CheckedChanged += radLecturer_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 198, 218);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(radStudent);
            panel1.Controls.Add(radLecturer);
            panel1.Location = new Point(-2, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 100);
            panel1.TabIndex = 31;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Mongolian Baiti", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(178, 110);
            lblError.Name = "lblError";
            lblError.Size = new Size(170, 18);
            lblError.TabIndex = 32;
            lblError.Text = "select account type!";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Silver;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(323, 634);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(162, 41);
            btnClear.TabIndex = 33;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // pictureBoxSHOWpassword
            // 
            pictureBoxSHOWpassword.Image = (Image)resources.GetObject("pictureBoxSHOWpassword.Image");
            pictureBoxSHOWpassword.Location = new Point(439, 476);
            pictureBoxSHOWpassword.Name = "pictureBoxSHOWpassword";
            pictureBoxSHOWpassword.Size = new Size(28, 27);
            pictureBoxSHOWpassword.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSHOWpassword.TabIndex = 34;
            pictureBoxSHOWpassword.TabStop = false;
            pictureBoxSHOWpassword.Click += pictureBoxSHOWpassword_Click;
            // 
            // pictureBoxSHOWpassword2
            // 
            pictureBoxSHOWpassword2.Image = (Image)resources.GetObject("pictureBoxSHOWpassword2.Image");
            pictureBoxSHOWpassword2.Location = new Point(439, 551);
            pictureBoxSHOWpassword2.Name = "pictureBoxSHOWpassword2";
            pictureBoxSHOWpassword2.Size = new Size(28, 27);
            pictureBoxSHOWpassword2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSHOWpassword2.TabIndex = 35;
            pictureBoxSHOWpassword2.TabStop = false;
            pictureBoxSHOWpassword2.Click += pictureBoxSHOWPassword2_Click;
            // 
            // PictureBoxPasswordHide
            // 
            PictureBoxPasswordHide.Image = (Image)resources.GetObject("PictureBoxPasswordHide.Image");
            PictureBoxPasswordHide.Location = new Point(439, 476);
            PictureBoxPasswordHide.Name = "PictureBoxPasswordHide";
            PictureBoxPasswordHide.Size = new Size(28, 27);
            PictureBoxPasswordHide.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxPasswordHide.TabIndex = 36;
            PictureBoxPasswordHide.TabStop = false;
            PictureBoxPasswordHide.Click += PictureBoxPasswordHide_Click;
            // 
            // pictureBoxHidePassword2
            // 
            pictureBoxHidePassword2.Image = (Image)resources.GetObject("pictureBoxHidePassword2.Image");
            pictureBoxHidePassword2.Location = new Point(439, 551);
            pictureBoxHidePassword2.Name = "pictureBoxHidePassword2";
            pictureBoxHidePassword2.Size = new Size(28, 27);
            pictureBoxHidePassword2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHidePassword2.TabIndex = 37;
            pictureBoxHidePassword2.TabStop = false;
            pictureBoxHidePassword2.Click += pictureBoxHidePassword2_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(558, 712);
            Controls.Add(btnClear);
            Controls.Add(lblError);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label6);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtEmailAdress);
            Controls.Add(label4);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(pictureBoxSHOWpassword);
            Controls.Add(PictureBoxPasswordHide);
            Controls.Add(pictureBoxSHOWpassword2);
            Controls.Add(pictureBoxHidePassword2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSHOWpassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSHOWpassword2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxPasswordHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHidePassword2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private Label label2;
        private Button btnLogin;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtID;
        private Label lblID;
        private TextBox txtEmailAdress;
        private Label label4;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtConfirmPassword;
        private Label label6;
        private PictureBox pictureBox1;
        private RadioButton radStudent;
        private RadioButton radLecturer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Label lblError;
        private Button btnClear;
        private PictureBox pictureBoxSHOWpassword;
        private PictureBox pictureBoxSHOWpassword2;
        private PictureBox PictureBoxPasswordHide;
        private PictureBox pictureBoxHidePassword2;
    }
}