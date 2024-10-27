namespace Venuelink_Booking_System.Properties
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            pictureBox2 = new PictureBox();
            btnDeleteUser = new Button();
            btnGenerateReport = new Button();
            btnUpdateUsrer = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panelslider = new Panel();
            adminViewBookings1 = new User_Control.AdminViewBookings();
            panel2 = new Panel();
            updateUser1 = new User_Control.UpdateUser();
            delete_User1 = new User_Control.Delete_User();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1255, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.FromArgb(37, 198, 218);
            btnDeleteUser.Cursor = Cursors.Hand;
            btnDeleteUser.FlatAppearance.BorderSize = 0;
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteUser.ForeColor = Color.White;
            btnDeleteUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteUser.Location = new Point(3, 400);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(233, 57);
            btnDeleteUser.TabIndex = 9;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.FromArgb(37, 198, 218);
            btnGenerateReport.Cursor = Cursors.Hand;
            btnGenerateReport.FlatAppearance.BorderSize = 0;
            btnGenerateReport.FlatStyle = FlatStyle.Flat;
            btnGenerateReport.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateReport.ForeColor = Color.White;
            btnGenerateReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerateReport.Location = new Point(3, 337);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(233, 57);
            btnGenerateReport.TabIndex = 8;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnUpdateUsrer
            // 
            btnUpdateUsrer.BackColor = Color.FromArgb(37, 198, 218);
            btnUpdateUsrer.Cursor = Cursors.Hand;
            btnUpdateUsrer.FlatAppearance.BorderSize = 0;
            btnUpdateUsrer.FlatStyle = FlatStyle.Flat;
            btnUpdateUsrer.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateUsrer.ForeColor = Color.White;
            btnUpdateUsrer.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateUsrer.Location = new Point(3, 274);
            btnUpdateUsrer.Name = "btnUpdateUsrer";
            btnUpdateUsrer.Size = new Size(233, 57);
            btnUpdateUsrer.TabIndex = 7;
            btnUpdateUsrer.Text = "Update User";
            btnUpdateUsrer.UseVisualStyleBackColor = false;
            btnUpdateUsrer.Click += btnUpdateUsrer_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-20, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 198, 218);
            panel1.Controls.Add(panelslider);
            panel1.Controls.Add(btnDeleteUser);
            panel1.Controls.Add(btnGenerateReport);
            panel1.Controls.Add(btnUpdateUsrer);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 781);
            panel1.TabIndex = 16;
            // 
            // panelslider
            // 
            panelslider.Anchor = AnchorStyles.Left;
            panelslider.BackColor = Color.White;
            panelslider.Location = new Point(3, 274);
            panelslider.Name = "panelslider";
            panelslider.Size = new Size(10, 57);
            panelslider.TabIndex = 10;
            // 
            // adminViewBookings1
            // 
            adminViewBookings1.Location = new Point(241, 273);
            adminViewBookings1.Name = "adminViewBookings1";
            adminViewBookings1.RightToLeft = RightToLeft.No;
            adminViewBookings1.Size = new Size(1053, 479);
            adminViewBookings1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 198, 218);
            panel2.Location = new Point(239, 207);
            panel2.Name = "panel2";
            panel2.Size = new Size(1207, 64);
            panel2.TabIndex = 19;
            // 
            // updateUser1
            // 
            updateUser1.BackColor = Color.White;
            updateUser1.Location = new Point(239, 273);
            updateUser1.Name = "updateUser1";
            updateUser1.Size = new Size(972, 480);
            updateUser1.TabIndex = 20;
            // 
            // delete_User1
            // 
            delete_User1.BackColor = Color.White;
            delete_User1.Location = new Point(247, 274);
            delete_User1.Name = "delete_User1";
            delete_User1.Size = new Size(984, 479);
            delete_User1.TabIndex = 21;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1290, 765);
            Controls.Add(panel2);
            Controls.Add(adminViewBookings1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(delete_User1);
            Controls.Add(updateUser1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Button btnDeleteUser;
        private Button btnGenerateReport;
        private Button btnUpdateUsrer;
        private PictureBox pictureBox1;
        private Panel panel1;
        private User_Control.AdminViewBookings adminViewBookings1;
        private Panel panel2;
        private User_Control.UpdateUser updateUser1;
        private User_Control.Delete_User delete_User1;
        private Panel panelslider;
    }
}