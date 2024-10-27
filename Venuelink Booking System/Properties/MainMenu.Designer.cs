namespace Venuelink_Booking_System.Properties
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnUpdateUsrer = new Button();
            btnGenerateReport = new Button();
            btnDeleteUser = new Button();
            panel1 = new Panel();
            lblDateTime = new Label();
            ucUpdateBooking1 = new User_Control.UCUpdateBooking();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1185, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            btnUpdateUsrer.Location = new Point(6, 222);
            btnUpdateUsrer.Name = "btnUpdateUsrer";
            btnUpdateUsrer.Size = new Size(233, 57);
            btnUpdateUsrer.TabIndex = 7;
            btnUpdateUsrer.Text = "Update User";
            btnUpdateUsrer.UseVisualStyleBackColor = false;
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
            btnGenerateReport.Location = new Point(6, 285);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(233, 57);
            btnGenerateReport.TabIndex = 8;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
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
            btnDeleteUser.Location = new Point(6, 348);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(233, 57);
            btnDeleteUser.TabIndex = 9;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 198, 218);
            panel1.Controls.Add(btnDeleteUser);
            panel1.Controls.Add(btnGenerateReport);
            panel1.Controls.Add(btnUpdateUsrer);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, -11);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 751);
            panel1.TabIndex = 12;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateTime.ForeColor = Color.FromArgb(37, 198, 218);
            lblDateTime.Location = new Point(249, 17);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(40, 22);
            lblDateTime.TabIndex = 14;
            lblDateTime.Text = "???";
            // 
            // ucUpdateBooking1
            // 
            ucUpdateBooking1.Location = new Point(732, 142);
            ucUpdateBooking1.Name = "ucUpdateBooking1";
            ucUpdateBooking1.Size = new Size(8, 8);
            ucUpdateBooking1.TabIndex = 15;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 691);
            Controls.Add(ucUpdateBooking1);
            Controls.Add(lblDateTime);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenu";
            Text = "MainMenu";
            Load += MainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnUpdateUsrer;
        private Button btnGenerateReport;
        private Button btnDeleteUser;
        private Panel panel1;
        private Label lblDateTime;
        private User_Control.UCUpdateBooking ucUpdateBooking1;
    }
}