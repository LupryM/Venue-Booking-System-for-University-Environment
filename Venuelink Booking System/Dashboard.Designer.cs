namespace Venuelink_Booking_System
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panelslider = new Panel();
            btnCancelBooking = new Button();
            btnViewBookings = new Button();
            btnCreateBooking = new Button();
            label2 = new Label();
            label6 = new Label();
            btnUpdateBooking = new Button();
            pictureBox2 = new PictureBox();
            lblLogout = new LinkLabel();
            panel6 = new Panel();
            lblUsername = new Label();
            label3 = new Label();
            imageList1 = new ImageList(components);
            timer1 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            lblDateTime = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            userControlCreateBooking1 = new User_Control.UserControlCreateBooking();
            ucUpdateBooking1 = new User_Control.UCUpdateBooking();
            ucDeleteBooking1 = new User_Control.UCDeleteBooking();
            ucViewBooking1 = new User_Control.UCViewBooking();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 198, 218);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panelslider);
            panel1.Controls.Add(btnCancelBooking);
            panel1.Controls.Add(btnViewBookings);
            panel1.Controls.Add(btnCreateBooking);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnUpdateBooking);
            panel1.Location = new Point(-29, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 832);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(62, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panelslider
            // 
            panelslider.Anchor = AnchorStyles.Left;
            panelslider.BackColor = Color.White;
            panelslider.Location = new Point(33, 318);
            panelslider.Name = "panelslider";
            panelslider.Size = new Size(10, 57);
            panelslider.TabIndex = 7;
            // 
            // btnCancelBooking
            // 
            btnCancelBooking.BackColor = Color.FromArgb(37, 198, 218);
            btnCancelBooking.Cursor = Cursors.Hand;
            btnCancelBooking.FlatAppearance.BorderSize = 0;
            btnCancelBooking.FlatStyle = FlatStyle.Flat;
            btnCancelBooking.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelBooking.ForeColor = Color.White;
            btnCancelBooking.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelBooking.Location = new Point(29, 511);
            btnCancelBooking.Name = "btnCancelBooking";
            btnCancelBooking.Size = new Size(224, 57);
            btnCancelBooking.TabIndex = 9;
            btnCancelBooking.Text = "Cancel Booking";
            btnCancelBooking.UseVisualStyleBackColor = false;
            btnCancelBooking.Click += btnCancelBooking_Click;
            // 
            // btnViewBookings
            // 
            btnViewBookings.BackColor = Color.FromArgb(37, 198, 218);
            btnViewBookings.Cursor = Cursors.Hand;
            btnViewBookings.FlatAppearance.BorderSize = 0;
            btnViewBookings.FlatStyle = FlatStyle.Flat;
            btnViewBookings.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewBookings.ForeColor = Color.White;
            btnViewBookings.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewBookings.Location = new Point(29, 385);
            btnViewBookings.Name = "btnViewBookings";
            btnViewBookings.Size = new Size(224, 57);
            btnViewBookings.TabIndex = 8;
            btnViewBookings.Text = "My Bookings";
            btnViewBookings.UseVisualStyleBackColor = false;
            btnViewBookings.Click += btnViewBookings_Click;
            // 
            // btnCreateBooking
            // 
            btnCreateBooking.BackColor = Color.FromArgb(37, 198, 218);
            btnCreateBooking.Cursor = Cursors.Hand;
            btnCreateBooking.FlatAppearance.BorderSize = 0;
            btnCreateBooking.FlatStyle = FlatStyle.Flat;
            btnCreateBooking.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateBooking.ForeColor = Color.White;
            btnCreateBooking.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateBooking.Location = new Point(29, 321);
            btnCreateBooking.Name = "btnCreateBooking";
            btnCreateBooking.Size = new Size(224, 57);
            btnCreateBooking.TabIndex = 6;
            btnCreateBooking.Text = "Create Booking";
            btnCreateBooking.UseVisualStyleBackColor = false;
            btnCreateBooking.Click += btnCtreateBooking_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(96, 203);
            label2.Name = "label2";
            label2.Size = new Size(91, 27);
            label2.TabIndex = 5;
            label2.Text = "System";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(33, 176);
            label6.Name = "label6";
            label6.Size = new Size(226, 27);
            label6.TabIndex = 4;
            label6.Text = "VenueLink Booking";
            // 
            // btnUpdateBooking
            // 
            btnUpdateBooking.BackColor = Color.FromArgb(37, 198, 218);
            btnUpdateBooking.Cursor = Cursors.Hand;
            btnUpdateBooking.FlatAppearance.BorderSize = 0;
            btnUpdateBooking.FlatStyle = FlatStyle.Flat;
            btnUpdateBooking.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateBooking.ForeColor = Color.White;
            btnUpdateBooking.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateBooking.Location = new Point(29, 448);
            btnUpdateBooking.Name = "btnUpdateBooking";
            btnUpdateBooking.Size = new Size(224, 57);
            btnUpdateBooking.TabIndex = 10;
            btnUpdateBooking.Text = "Update Booking";
            btnUpdateBooking.UseVisualStyleBackColor = false;
            btnUpdateBooking.Click += btnUpdateBooking_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1238, 95);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lblLogout
            // 
            lblLogout.AutoSize = true;
            lblLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogout.LinkColor = Color.FromArgb(37, 198, 218);
            lblLogout.Location = new Point(1286, 106);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(87, 28);
            lblLogout.TabIndex = 4;
            lblLogout.TabStop = true;
            lblLogout.Text = "Log Out";
            lblLogout.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(37, 198, 218);
            panel6.Controls.Add(lblUsername);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(226, 139);
            panel6.Name = "panel6";
            panel6.Size = new Size(1147, 107);
            panel6.TabIndex = 5;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(142, 29);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(21, 28);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 29);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 1;
            label3.Text = "Welcome:";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateTime.ForeColor = Color.FromArgb(37, 198, 218);
            lblDateTime.Location = new Point(236, 114);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(40, 22);
            lblDateTime.TabIndex = 7;
            lblDateTime.Text = "???";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // userControlCreateBooking1
            // 
            userControlCreateBooking1.BackColor = Color.White;
            userControlCreateBooking1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlCreateBooking1.ForeColor = Color.FromArgb(37, 198, 250);
            userControlCreateBooking1.Location = new Point(230, 243);
            userControlCreateBooking1.Margin = new Padding(4, 3, 4, 3);
            userControlCreateBooking1.MinimumSize = new Size(1128, 48);
            userControlCreateBooking1.Name = "userControlCreateBooking1";
            userControlCreateBooking1.Size = new Size(1136, 552);
            userControlCreateBooking1.TabIndex = 8;
            userControlCreateBooking1.Load += userControlCreateBooking1_Load;
            // 
            // ucUpdateBooking1
            // 
            ucUpdateBooking1.Location = new Point(230, 244);
            ucUpdateBooking1.MinimumSize = new Size(1128, 521);
            ucUpdateBooking1.Name = "ucUpdateBooking1";
            ucUpdateBooking1.Size = new Size(1128, 529);
            ucUpdateBooking1.TabIndex = 9;
            // 
            // ucDeleteBooking1
            // 
            ucDeleteBooking1.BackColor = Color.White;
            ucDeleteBooking1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            ucDeleteBooking1.Location = new Point(230, 244);
            ucDeleteBooking1.Margin = new Padding(4, 3, 4, 3);
            ucDeleteBooking1.Name = "ucDeleteBooking1";
            ucDeleteBooking1.Size = new Size(1143, 551);
            ucDeleteBooking1.TabIndex = 10;
            // 
            // ucViewBooking1
            // 
            ucViewBooking1.BackColor = Color.White;
            ucViewBooking1.BackgroundImageLayout = ImageLayout.Center;
            ucViewBooking1.Location = new Point(230, 244);
            ucViewBooking1.Name = "ucViewBooking1";
            ucViewBooking1.Size = new Size(1099, 514);
            ucViewBooking1.TabIndex = 11;
            // 
            // Dashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1372, 819);
            Controls.Add(lblDateTime);
            Controls.Add(panel6);
            Controls.Add(lblLogout);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(userControlCreateBooking1);
            Controls.Add(ucViewBooking1);
            Controls.Add(ucDeleteBooking1);
            Controls.Add(ucUpdateBooking1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private LinkLabel lblLogout;
        private Label label2;
        private Label label6;
        private Panel panel6;
        private Label lblUsername;
        private Label label3;
        private Button btnCreateBooking;
        private Button btnCancelBooking;
        private Button btnViewBookings;
        private ImageList imageList1;
        private Panel panelslider;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer3;
        private Label lblDateTime;
        private Button btnUpdateBooking;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private PictureBox pictureBox1;
        private User_Control.UserControlCreateBooking userControlCreateBooking1;
        private User_Control.UCUpdateBooking ucUpdateBooking1;
        private User_Control.UCDeleteBooking ucDeleteBooking1;
        private User_Control.UCViewBooking ucViewBooking1;
    }
}